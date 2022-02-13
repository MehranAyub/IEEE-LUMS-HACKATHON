﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Migrations
{
    public partial class Added_Poll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "GLACGRP");

            //migrationBuilder.DropTable(
            //    name: "GLBOOKS");

            //migrationBuilder.DropTable(
            //    name: "GLCstCent");

            //migrationBuilder.DropTable(
            //    name: "GLSRCE");

            migrationBuilder.CreateTable(
                name: "Polls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Option1 = table.Column<string>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    Option3 = table.Column<string>(nullable: true),
                    Option4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Polls");

            //migrationBuilder.CreateTable(
            //    name: "GLACGRP",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(nullable: false),
            //        ACCTGRPCOD = table.Column<string>(nullable: false),
            //        ACCTGRPDES = table.Column<string>(nullable: false),
            //        AUDTDATE = table.Column<DateTime>(nullable: false),
            //        AUDTORG = table.Column<string>(nullable: false),
            //        AUDTTIME = table.Column<string>(nullable: false),
            //        AUDTUSER = table.Column<string>(nullable: false),
            //        GRPCOD = table.Column<short>(nullable: false),
            //        SORTCODE = table.Column<string>(nullable: false),
            //        TenantId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GLACGRP", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GLBOOKS",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        BookID = table.Column<int>(nullable: false),
            //        BookName = table.Column<string>(nullable: false),
            //        DbID = table.Column<int>(nullable: true),
            //        Integrated = table.Column<bool>(nullable: false),
            //        NormalEntry = table.Column<int>(nullable: false),
            //        Restricted = table.Column<short>(nullable: true),
            //        SysDate = table.Column<decimal>(nullable: true),
            //        TenantId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GLBOOKS", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GLCstCent",
            //    columns: table => new
            //    {
            //        CostCenterID = table.Column<string>(nullable: false),
            //        CCStructID = table.Column<string>(nullable: false),
            //        CostCenter = table.Column<string>(nullable: false),
            //        TenantId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GLCstCent", x => x.CostCenterID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GLSRCE",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        SRCEDESC = table.Column<string>(nullable: false),
            //        SRCELEDGER = table.Column<string>(nullable: false),
            //        SRCETYPE = table.Column<string>(nullable: false),
            //        TenantId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GLSRCE", x => x.Id);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_GLACGRP_TenantId",
            //    table: "GLACGRP",
            //    column: "TenantId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GLBOOKS_TenantId",
            //    table: "GLBOOKS",
            //    column: "TenantId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GLCstCent_TenantId",
            //    table: "GLCstCent",
            //    column: "TenantId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GLSRCE_TenantId",
            //    table: "GLSRCE",
            //    column: "TenantId");
        }
    }
}
