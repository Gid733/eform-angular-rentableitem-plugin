﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microting.eForm.Infrastructure.Constants;
using Microting.eFormApi.BasePn.Abstractions;
using RentableItems.Pn.Infrastructure.Data;
using RentableItems.Pn.Infrastructure.Data.Entities;

namespace RentableItems.Pn.Infrastructure.Models
{
    public class ContractInspectionModel : IModel
    {
        public int Id { get; set; }
        public string WorkflowState { get; set; }
        public int Version { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int CreatedByUserID { get; set; }
        public int UpdatedByUserID { get; set; }
        public int ContractId { get; set; }
        public int SdkCaseId { get; set; }
        public int SiteId { get; set; }
        public DateTime? DoneAt { get; set; }
        private readonly IEFormCoreService _coreHelper;


        public async Task Create(RentableItemsPnDbContext _dbContext)
        {
            ContractInspection contractInspection = new ContractInspection();

            contractInspection.WorkflowState = Constants.WorkflowStates.Created;
            contractInspection.Version = Version;
            contractInspection.CreatedAt = DateTime.Now;
            contractInspection.UpdatedAt = DateTime.Now;
            contractInspection.CreatedByUserId = CreatedByUserID;
            contractInspection.UpdatedByUserId = UpdatedByUserID;
            contractInspection.SiteId = SiteId;
            contractInspection.ContractId = ContractId;
            contractInspection.SDKCaseId = SdkCaseId;
            contractInspection.DoneAt = DoneAt;

            _dbContext.ContractInspection.Add(contractInspection);
            await _dbContext.SaveChangesAsync();

            _dbContext.ContractInspectionVersion.Add(MapContractInspection(_dbContext, contractInspection));
            await _dbContext.SaveChangesAsync();


            //Core core = _coreHelper.GetCore();
            //Template_Dto templateDto = core.TemplateItemRead(RentableItemsSettings.eformid);
            //    MainElement mainElement = core.TemplateRead(RentableItemsSettings.eformid);
            //    mainElement.Repeated =
            //        0; // We set this right now hardcoded, this will let the eForm be deployed until end date or we actively retract it.
            //    mainElement.EndDate = DateTime.Now.AddYears(10).ToUniversalTime();
            //    mainElement.StartDate = DateTime.Now.ToUniversalTime();
            //    core.CaseCreate(mainElement, "", sitesToBeDeployedTo, "");            

            //foreach (int siteUId in sitesToBeRetractedFrom)
            //{
            //    core.CaseDelete(deployModel.Id, siteUId);
            //}

        }

        public async Task Update(RentableItemsPnDbContext _dbContext)
        {
            ContractInspection contractInspection = _dbContext.ContractInspection.FirstOrDefault(x => x.Id == Id);

            if (contractInspection == null)
            {
                throw new NullReferenceException($"Could not find Contract Inspection with id {Id}");
            }

            contractInspection.WorkflowState = contractInspection.WorkflowState;
            contractInspection.ContractId = ContractId;
            contractInspection.SDKCaseId = SdkCaseId;
            contractInspection.DoneAt = DoneAt;
            
            if(_dbContext.ChangeTracker.HasChanges())
            {
                contractInspection.UpdatedAt = DateTime.Now;
                contractInspection.UpdatedByUserId = UpdatedByUserID;
                contractInspection.Version += 1;

                _dbContext.ContractInspectionVersion.Add(MapContractInspection(_dbContext, contractInspection));
                await _dbContext.SaveChangesAsync();

            }

        }

        public async Task Delete(RentableItemsPnDbContext _dbContext)
        {
            ContractInspection contractInspection = _dbContext.ContractInspection.FirstOrDefault(x => x.Id == Id);

            if (contractInspection == null)
            {
                throw new NullReferenceException($"Could not find Contract Inspection with id {Id}");
            }

            contractInspection.WorkflowState = Constants.WorkflowStates.Removed;
            

            if (_dbContext.ChangeTracker.HasChanges())
            {
                contractInspection.UpdatedAt = DateTime.Now;
                contractInspection.UpdatedByUserId = UpdatedByUserID;
                contractInspection.Version += 1;

                _dbContext.ContractInspectionVersion.Add(MapContractInspection(_dbContext, contractInspection));
                await _dbContext.SaveChangesAsync();

            }
        }

        public ContractInspectionVersion MapContractInspection(RentableItemsPnDbContext _dbContext, ContractInspection contractInspection)
        {
            ContractInspectionVersion contractInspectionVer = new ContractInspectionVersion();

            contractInspectionVer.ContractId = contractInspection.ContractId;
            contractInspectionVer.CreatedAt = contractInspection.CreatedAt;
            contractInspectionVer.CreatedByUserId = contractInspection.CreatedByUserId;
            contractInspectionVer.DoneAt = contractInspection.DoneAt;
            contractInspectionVer.SDKCaseId = contractInspection.SDKCaseId;
            contractInspectionVer.Status = contractInspection.Status;
            contractInspectionVer.UpdatedAt = contractInspection.UpdatedAt;
            contractInspectionVer.UpdatedByUserId = contractInspection.UpdatedByUserId;
            contractInspectionVer.Version = contractInspection.Version;
            contractInspectionVer.WorkflowState = contractInspection.WorkflowState;

            contractInspectionVer.ContractInspectionId = contractInspection.Id;

            return contractInspectionVer;

        }
    }
}
