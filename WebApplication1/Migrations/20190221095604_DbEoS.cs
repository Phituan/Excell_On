using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class DbEoS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyLogo = table.Column<string>(nullable: true),
                    CompanyDescription = table.Column<string>(nullable: true),
                    CompanyPhone = table.Column<string>(nullable: true),
                    CompanyEmail = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    CompanyIsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    EmployeeFirtName = table.Column<string>(nullable: true),
                    EmployeeLastName = table.Column<string>(nullable: true),
                    EmployeeGender = table.Column<bool>(nullable: true),
                    EmployeeDateOfBirth = table.Column<DateTime>(nullable: true),
                    EmployeeAddress = table.Column<string>(nullable: true),
                    EmployeePhoneNumber = table.Column<string>(nullable: true),
                    EmployeeEmail = table.Column<string>(nullable: true),
                    EmployeeAvatar = table.Column<string>(nullable: true),
                    EmployeeIsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "OrderOfService",
                columns: table => new
                {
                    OrderOfServiceId = table.Column<Guid>(nullable: false),
                    OrderOfServiceDescription = table.Column<string>(nullable: true),
                    OrderOfServicePrice = table.Column<int>(nullable: false),
                    OrderOfServiceCreatedAt = table.Column<DateTime>(nullable: false),
                    OrderOfServicePaymentMethod = table.Column<string>(nullable: true),
                    OrderOfServicePaymentDate = table.Column<DateTime>(nullable: false),
                    OrderOfServiceBillDate = table.Column<DateTime>(nullable: false),
                    OrderOfServiceStatus = table.Column<int>(nullable: false),
                    OrderOfServiceIsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderOfService", x => x.OrderOfServiceId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    ServiceTypeId = table.Column<Guid>(nullable: false),
                    ServiceTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.ServiceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(nullable: true),
                    AccountUserName = table.Column<string>(nullable: true),
                    AccountPassword = table.Column<string>(nullable: true),
                    AccountIsLocked = table.Column<bool>(nullable: false),
                    AccountIsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Account_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<Guid>(nullable: false),
                    ServiceName = table.Column<string>(nullable: true),
                    ServiceImage = table.Column<string>(nullable: true),
                    ServicePrice = table.Column<int>(nullable: false),
                    ServiceDescription = table.Column<string>(nullable: true),
                    ServiceCharge = table.Column<string>(nullable: true),
                    ServiceIsDelete = table.Column<bool>(nullable: false),
                    EmployeeEmployeeId = table.Column<Guid>(nullable: false),
                    ServiceTypeServiceTypeId = table.Column<Guid>(nullable: false),
                    CompanyCompanyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Service_Company_CompanyCompanyId",
                        column: x => x.CompanyCompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Employee_EmployeeEmployeeId",
                        column: x => x.EmployeeEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_ServiceType_ServiceTypeServiceTypeId",
                        column: x => x.ServiceTypeServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "ServiceTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderOfServiceDetail",
                columns: table => new
                {
                    OrderOfServiceId = table.Column<Guid>(nullable: false),
                    ServiceId = table.Column<Guid>(nullable: false),
                    OrderOfServiceDetailPrice = table.Column<int>(nullable: false),
                    OrderOfServiceDetailFromDate = table.Column<DateTime>(nullable: false),
                    OrderOfServiceDetailToDate = table.Column<DateTime>(nullable: false),
                    OrderOfServiceDetailNumberOfEmployee = table.Column<int>(nullable: false),
                    OrderOfServiceDetailIsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderOfServiceDetail", x => new { x.ServiceId, x.OrderOfServiceId });
                    table.ForeignKey(
                        name: "FK_OrderOfServiceDetail_OrderOfService_OrderOfServiceId",
                        column: x => x.OrderOfServiceId,
                        principalTable: "OrderOfService",
                        principalColumn: "OrderOfServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderOfServiceDetail_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_EmployeeId",
                table: "Account",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderOfServiceDetail_OrderOfServiceId",
                table: "OrderOfServiceDetail",
                column: "OrderOfServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_CompanyCompanyId",
                table: "Service",
                column: "CompanyCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_EmployeeEmployeeId",
                table: "Service",
                column: "EmployeeEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServiceTypeServiceTypeId",
                table: "Service",
                column: "ServiceTypeServiceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "OrderOfServiceDetail");

            migrationBuilder.DropTable(
                name: "OrderOfService");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ServiceType");
        }
    }
}
