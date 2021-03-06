﻿// <auto-generated />

namespace RentableItems.Pn.Infrastructure.Migrations
{
    using System;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;

    [DbContext(typeof(RentableItemsPnDbContext))]
    [Migration("20191002062253_ChangingSDKCaseIdToInt")]
    partial class ChangingSDKCaseIdToInt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            string autoIDGenStrategy = "SqlServer:ValueGenerationStrategy";
            object autoIDGenStrategyValue = SqlServerValueGenerationStrategy.IdentityColumn;
            if (DbConfig.IsMySQL)
            {
                autoIDGenStrategy = "MySql:ValueGenerationStrategy";
                autoIDGenStrategyValue = MySqlValueGenerationStrategy.IdentityColumn;
            }
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValues");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValueVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValueVersions");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime?>("ContractEnd");

                    b.Property<int?>("ContractNr");

                    b.Property<DateTime?>("ContractStart");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("CustomerId");

                    b.Property<int?>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.ContractInspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("ContractId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime?>("DoneAt");

                    b.Property<int>("SDKCaseId");

                    b.Property<int>("SiteId");

                    b.Property<int?>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractInspection");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.ContractInspectionVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("ContractId");

                    b.Property<int>("ContractInspectionId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime?>("DoneAt");

                    b.Property<int>("SDKCaseId");

                    b.Property<int>("SiteId");

                    b.Property<int?>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ContractInspectionVersion");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.ContractVersions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime?>("ContractEnd");

                    b.Property<int>("ContractId");

                    b.Property<int?>("ContractNr");

                    b.Property<DateTime?>("ContractStart");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("CustomerId");

                    b.Property<int?>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ContractVersions");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.RentableItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<string>("Brand")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("ModelName")
                        .HasMaxLength(100);

                    b.Property<string>("PlateNumber");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<string>("SerialNumber");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("VinNumber");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("VinNumber")
                        .IsUnique()
                        .HasFilter("[VinNumber] IS NOT NULL");

                    b.ToTable("RentableItem");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.RentableItemContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("ContractId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("RentableItemId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("RentableItemId");

                    b.ToTable("RentableItemContract");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.RentableItemsContractVersions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<int>("ContractId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("RentableItemContractId");

                    b.Property<int>("RentableItemId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("RentableItemsContractVersions");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.RentableItemsField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("FieldId");

                    b.Property<int>("FieldStatus");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("RentableItemsFields");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.RentableItemsSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.Property<int?>("eFormId");

                    b.HasKey("Id");

                    b.ToTable("RentableItemsSettings");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.RentableItemsSettingsVersions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("RentableItemsSettingId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.Property<int>("eFormId");

                    b.HasKey("Id");

                    b.ToTable("RentableItemsSettingsVersions");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.RentableItemsVersions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<string>("Brand")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("ModelName")
                        .HasMaxLength(100);

                    b.Property<string>("PlateNumber");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<int>("RentableItemId");

                    b.Property<string>("SerialNumber");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("VinNumber");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("RentableItemsVersion");
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.ContractInspection", b =>
                {
                    b.HasOne("RentableItems.Pn.Infrastructure.Data.Entities.Contract", "Contract")
                        .WithMany("ContractInspections")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.RentableItemContract", b =>
                {
                    b.HasOne("RentableItems.Pn.Infrastructure.Data.Entities.RentableItem", "RentableItem")
                        .WithMany("RentableItemContracts")
                        .HasForeignKey("RentableItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentableItems.Pn.Infrastructure.Data.Entities.RentableItemsField", b =>
                {
                    b.HasOne("RentableItems.Pn.Infrastructure.Data.Entities.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
