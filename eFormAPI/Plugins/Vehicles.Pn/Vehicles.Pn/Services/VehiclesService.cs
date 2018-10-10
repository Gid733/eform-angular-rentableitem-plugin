﻿using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microting.eFormApi.BasePn.Infrastructure.Extensions;
using Microting.eFormApi.BasePn.Infrastructure.Models.API;
using Vehicles.Pn.Abstractions;
using Vehicles.Pn.Infrastructure.Data;
using Vehicles.Pn.Infrastructure.Data.Entities;
using Vehicles.Pn.Infrastructure.Models;

namespace Vehicles.Pn.Services
{
    public class VehiclesService : IVehiclesService
    {
        private readonly ILogger<VehiclesService> _logger;
        private readonly IVehicleLocalizationService _vehicleLocalizationService;
        private readonly VehiclesPnDbContext _dbContext;

        public VehiclesService(VehiclesPnDbContext dbContext,
            ILogger<VehiclesService> logger, 
            IVehicleLocalizationService vehicleLocalizationService)
        {
            _dbContext = dbContext;
            _logger = logger;
            _vehicleLocalizationService = vehicleLocalizationService;
        }

        public OperationDataResult<VehiclesModel> GetAllVehicles(VehiclesRequestModel pnRequestModel)
        {
            try
            {
                var vehiclesPnModel = new VehiclesModel();
                var vehiclesQuery = _dbContext.Vehicles.AsQueryable();
                if (!string.IsNullOrEmpty(pnRequestModel.SortColumnName))
                {
                    if (pnRequestModel.IsSortDsc)
                    {
                        vehiclesQuery = vehiclesQuery.CustomOrderByDescending(pnRequestModel.SortColumnName);
                    }
                    else
                    {
                        vehiclesQuery = vehiclesQuery.CustomOrderBy(pnRequestModel.SortColumnName);
                    }
                }

                vehiclesPnModel.Total = vehiclesQuery.Count();
                vehiclesQuery = vehiclesQuery.Skip(pnRequestModel.Offset).Take(pnRequestModel.PageSize);
                var vehicles = vehiclesQuery.ToList();
                vehicles.ForEach(vehicle =>
                {
                    vehiclesPnModel.Vehicles.Add(new VehicleModel()
                    {
                        VinNumber = vehicle.VinNumber,
                        ContractEndDate = vehicle.ContractEndDate,
                        ContractStartDate = vehicle.ContractStartDate,
                        CustomerName = vehicle.CustomerName,
                        RegistrationDate = vehicle.RegistrationDate,
                        Brand = vehicle.Brand,
                        ContactNumber = vehicle.ContractNumber,
                        ModelName = vehicle.ModelName,
                        Id = vehicle.Id,
                    });
                });
                return new OperationDataResult<VehiclesModel>(true, vehiclesPnModel);
            }
            catch (Exception e)
            {
                Trace.TraceError(e.Message);
                _logger.LogError(e.Message);
                return new OperationDataResult<VehiclesModel>(true,
                    _vehicleLocalizationService.GetString("ErrorObtainingVehiclesInfo"));
            }
        }

        public OperationResult CreateVehicle(VehicleModel vehiclePnCreateModel)
        {
            try
            {
                var vehiclePn = new Vehicle
                {
                    VinNumber = vehiclePnCreateModel.VinNumber,
                    Brand = vehiclePnCreateModel.Brand,
                    ContractNumber = vehiclePnCreateModel.ContactNumber,
                    ContractEndDate = vehiclePnCreateModel.ContractEndDate,
                    ContractStartDate = vehiclePnCreateModel.ContractStartDate,
                    CustomerName = vehiclePnCreateModel.CustomerName,
                    ModelName = vehiclePnCreateModel.ModelName,
                    RegistrationDate = vehiclePnCreateModel.RegistrationDate,
                };
                _dbContext.Vehicles.Add(vehiclePn);
                _dbContext.SaveChanges();
                return new OperationResult(true,
                    _vehicleLocalizationService.GetString("VehicleCreated", vehiclePnCreateModel.Brand,
                        vehiclePnCreateModel.ModelName));
            }
            catch (Exception e)
            {
                Trace.TraceError(e.Message);
                _logger.LogError(e.Message);
                return new OperationResult(true, _vehicleLocalizationService.GetString("ErrorWhileCreatingVehicle"));
            }
        }

        public OperationResult UpdateVehicle(VehicleModel vehiclePnUpdateModel)
        {
            try
            {
                var vehicle = _dbContext.Vehicles.FirstOrDefault(x => x.Id == vehiclePnUpdateModel.Id);
                if (vehicle == null)
                {
                    return new OperationResult(true, "Vehicle not found");
                }

                vehicle.VinNumber = vehiclePnUpdateModel.VinNumber;
                vehicle.Brand = vehiclePnUpdateModel.Brand;
                vehicle.ContractNumber = vehiclePnUpdateModel.ContactNumber;
                vehicle.ContractEndDate = vehiclePnUpdateModel.ContractEndDate;
                vehicle.ContractStartDate = vehiclePnUpdateModel.ContractStartDate;
                vehicle.CustomerName = vehiclePnUpdateModel.CustomerName;
                vehicle.ModelName = vehiclePnUpdateModel.ModelName;
                vehicle.RegistrationDate = vehiclePnUpdateModel.RegistrationDate;
                _dbContext.SaveChanges();
                return new OperationDataResult<VehiclesModel>(true);
            }
            catch (Exception e)
            {
                Trace.TraceError(e.Message);
                _logger.LogError(e.Message);
                return new OperationDataResult<VehiclesModel>(true,
                    _vehicleLocalizationService.GetString("ErrorWhileUpdatingVehicleInfo"));
            }
        }
    }
}