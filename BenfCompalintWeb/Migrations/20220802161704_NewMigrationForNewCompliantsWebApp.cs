using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BenfCompalintWeb.Migrations
{
    public partial class NewMigrationForNewCompliantsWebApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.CreateTable(
                name: "BenefCommunication",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    TypeCommunicationId = table.Column<string>(type: "varchar(100)", nullable: false),
                    CommunDescribed = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    BeneficiariesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefCommunication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Governorates",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LimitationOrders",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    UserResponsibleId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LimitationOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    permissionsName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Societys",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StagesComplaints",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StagesComplaints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusCompalints",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCompalints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeBeneficiari",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "varchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeBeneficiari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directorates",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Directorates_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "Identity",
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubDirectorates",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubDirectorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubDirectorates_Directorates_DirectorateId",
                        column: x => x.DirectorateId,
                        principalSchema: "Identity",
                        principalTable: "Directorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Villages",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDirectorateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Villages_SubDirectorates_SubDirectorateId",
                        column: x => x.SubDirectorateId,
                        principalSchema: "Identity",
                        principalTable: "SubDirectorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolesId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: true),
                    DirectorateId = table.Column<int>(type: "int", nullable: true),
                    SubDirectorateId = table.Column<int>(type: "int", nullable: true),
                    VillageId = table.Column<int>(type: "int", nullable: true),
                    SocietyId = table.Column<int>(type: "int", nullable: true),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermissionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Directorates_DirectorateId",
                        column: x => x.DirectorateId,
                        principalSchema: "Identity",
                        principalTable: "Directorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "Identity",
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalSchema: "Identity",
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Role_RolesId",
                        column: x => x.RolesId,
                        principalSchema: "Identity",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Societys_SocietyId",
                        column: x => x.SocietyId,
                        principalSchema: "Identity",
                        principalTable: "Societys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_SubDirectorates_SubDirectorateId",
                        column: x => x.SubDirectorateId,
                        principalSchema: "Identity",
                        principalTable: "SubDirectorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Villages_VillageId",
                        column: x => x.VillageId,
                        principalSchema: "Identity",
                        principalTable: "Villages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiaries",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    IdentityNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AdminId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PresentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPersonalCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: true),
                    DirectorateId = table.Column<int>(type: "int", nullable: true),
                    SubDirectorateId = table.Column<int>(type: "int", nullable: true),
                    VillageId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "تحديد وقت ادخال الصف في قاعدية البيانات"),
                    Update_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeBeneficiariId = table.Column<int>(type: "int", nullable: true),
                    TypeBeneficiarisId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_Directorates_DirectorateId",
                        column: x => x.DirectorateId,
                        principalSchema: "Identity",
                        principalTable: "Directorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "Identity",
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_SubDirectorates_SubDirectorateId",
                        column: x => x.SubDirectorateId,
                        principalSchema: "Identity",
                        principalTable: "SubDirectorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_TypeBeneficiari_TypeBeneficiarisId",
                        column: x => x.TypeBeneficiarisId,
                        principalSchema: "Identity",
                        principalTable: "TypeBeneficiari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_User_AdminId",
                        column: x => x.AdminId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beneficiaries_Villages_VillageId",
                        column: x => x.VillageId,
                        principalSchema: "Identity",
                        principalTable: "Villages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypeComplaints",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "varchar(150)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsersAddTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeComplaints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeComplaints_User_UsersAddTypeId",
                        column: x => x.UsersAddTypeId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "Identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersCommunications",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UsersHasId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Titile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersCommunications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersCommunications_User_UsersHasId",
                        column: x => x.UsersHasId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BenefCommunicationBeneficiarie",
                schema: "Identity",
                columns: table => new
                {
                    BenefCommunicationsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BeneficiariesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefCommunicationBeneficiarie", x => new { x.BenefCommunicationsId, x.BeneficiariesId });
                    table.ForeignKey(
                        name: "FK_BenefCommunicationBeneficiarie_BenefCommunication_BenefCommunicationsId",
                        column: x => x.BenefCommunicationsId,
                        principalSchema: "Identity",
                        principalTable: "BenefCommunication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BenefCommunicationBeneficiarie_Beneficiaries_BeneficiariesId",
                        column: x => x.BeneficiariesId,
                        principalSchema: "Identity",
                        principalTable: "Beneficiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communication_Counter",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Communic_Counter = table.Column<int>(type: "int", nullable: false),
                    BeneficiarieId = table.Column<int>(type: "int", nullable: false),
                    BeneficiariesId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BenefCommunicationId = table.Column<int>(type: "int", nullable: false),
                    BenefCommunicationsId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communication_Counter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communication_Counter_BenefCommunication_BenefCommunicationsId",
                        column: x => x.BenefCommunicationsId,
                        principalSchema: "Identity",
                        principalTable: "BenefCommunication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Communication_Counter_Beneficiaries_BeneficiariesId",
                        column: x => x.BeneficiariesId,
                        principalSchema: "Identity",
                        principalTable: "Beneficiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proposals",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    TitileProposal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescProposal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSubmeted = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "تحديد وقت ادخال الصف في قاعدية البيانات"),
                    BeneficiarieId = table.Column<int>(type: "int", nullable: false),
                    BeneficiarieId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proposals_Beneficiaries_BeneficiarieId1",
                        column: x => x.BeneficiarieId1,
                        principalSchema: "Identity",
                        principalTable: "Beneficiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compalints",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    TitleComplaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeComplaintId = table.Column<int>(type: "int", nullable: false),
                    DescComplaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocietyId = table.Column<int>(type: "int", nullable: true),
                    StatusCompalintId = table.Column<int>(type: "int", nullable: false),
                    StagesComplaintId = table.Column<int>(type: "int", nullable: false),
                    PropBeneficiarie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    DirectorateId = table.Column<int>(type: "int", nullable: true),
                    SubDirectorateId = table.Column<int>(type: "int", nullable: true),
                    VillageId = table.Column<int>(type: "int", nullable: true),
                    CompDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompDateUp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BeneficiarieId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compalints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compalints_Beneficiaries_BeneficiarieId",
                        column: x => x.BeneficiarieId,
                        principalSchema: "Identity",
                        principalTable: "Beneficiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compalints_Directorates_DirectorateId",
                        column: x => x.DirectorateId,
                        principalSchema: "Identity",
                        principalTable: "Directorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compalints_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalSchema: "Identity",
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compalints_Societys_SocietyId",
                        column: x => x.SocietyId,
                        principalSchema: "Identity",
                        principalTable: "Societys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compalints_StagesComplaints_StagesComplaintId",
                        column: x => x.StagesComplaintId,
                        principalSchema: "Identity",
                        principalTable: "StagesComplaints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compalints_StatusCompalints_StatusCompalintId",
                        column: x => x.StatusCompalintId,
                        principalSchema: "Identity",
                        principalTable: "StatusCompalints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compalints_SubDirectorates_SubDirectorateId",
                        column: x => x.SubDirectorateId,
                        principalSchema: "Identity",
                        principalTable: "SubDirectorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compalints_TypeComplaints_TypeComplaintId",
                        column: x => x.TypeComplaintId,
                        principalSchema: "Identity",
                        principalTable: "TypeComplaints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compalints_User_HoUserId",
                        column: x => x.HoUserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compalints_Villages_VillageId",
                        column: x => x.VillageId,
                        principalSchema: "Identity",
                        principalTable: "Villages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compalints_Solutions",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UserAddSolutionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompalintId = table.Column<int>(type: "int", nullable: false),
                    CompalintsHasSolutionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BeneficiarieId = table.Column<int>(type: "int", nullable: true),
                    BeneficiariesId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ContentSolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSolution = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compalints_Solutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compalints_Solutions_Beneficiaries_BeneficiariesId",
                        column: x => x.BeneficiariesId,
                        principalSchema: "Identity",
                        principalTable: "Beneficiaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compalints_Solutions_Compalints_CompalintsHasSolutionId",
                        column: x => x.CompalintsHasSolutionId,
                        principalSchema: "Identity",
                        principalTable: "Compalints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compalints_Solutions_User_UserAddSolutionId",
                        column: x => x.UserAddSolutionId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cbc43a8e-f7bb-1445-baaf-1rdd431ffbbf", "fde8879d-5559-4957-a92c-002a20fac621", "AdminVillages", "ADMINVILLAGES" },
                    { "cbc43a8e-f7bb-4445-baaf-1wdd431ffbbf", "d6f0807d-5457-4a66-a7c9-aca2d109863d", "AdminDirectorate", "ADMINDIRECTORATE" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "0eec3f54-f426-4393-830e-5839bf48bdc5", "AdminGovernorate", "ADMINGOVERNORATE" },
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "ab8dac9f-c6c0-4041-acfd-501210b10b87", "AdminGeneralFederation", "ADMINGENERALFEDERATION" },
                    { "cbc43a8e-f7bb-4445-baaf-1rdd431ffbbf", "3834cb57-f4ae-4f3e-9205-bbf7e2c4f2bb", "AdminSubDirectorate", "ADMINSUBDIRECTORATE" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Societys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "جمعية الحبوب" },
                    { 2, "جمعية الالبان" },
                    { 1, "جمعية البن" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "StagesComplaints",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "القرية" },
                    { 5, "الإتحاد العام" },
                    { 4, "المحافظة" },
                    { 3, "المديرية" },
                    { 2, "العزلة" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "StatusCompalints",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "مرفوضة" },
                    { 2, "محلولة" },
                    { 1, "جديدة" },
                    { 4, "معلقة" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "TypeComplaints",
                columns: new[] { "Id", "CreatedDate", "Type", "UsersAddTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "زراعية", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مماطلة", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "إرتشاء", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "فساد", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenefCommunicationBeneficiarie_BeneficiariesId",
                schema: "Identity",
                table: "BenefCommunicationBeneficiarie",
                column: "BeneficiariesId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_AdminId",
                schema: "Identity",
                table: "Beneficiaries",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_DirectorateId",
                schema: "Identity",
                table: "Beneficiaries",
                column: "DirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_GovernorateId",
                schema: "Identity",
                table: "Beneficiaries",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_SubDirectorateId",
                schema: "Identity",
                table: "Beneficiaries",
                column: "SubDirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_TypeBeneficiarisId",
                schema: "Identity",
                table: "Beneficiaries",
                column: "TypeBeneficiarisId");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiaries_VillageId",
                schema: "Identity",
                table: "Beneficiaries",
                column: "VillageId");

            migrationBuilder.CreateIndex(
                name: "IX_Communication_Counter_BenefCommunicationsId",
                schema: "Identity",
                table: "Communication_Counter",
                column: "BenefCommunicationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Communication_Counter_BeneficiariesId",
                schema: "Identity",
                table: "Communication_Counter",
                column: "BeneficiariesId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_BeneficiarieId",
                schema: "Identity",
                table: "Compalints",
                column: "BeneficiarieId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_DirectorateId",
                schema: "Identity",
                table: "Compalints",
                column: "DirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_GovernorateId",
                schema: "Identity",
                table: "Compalints",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_HoUserId",
                schema: "Identity",
                table: "Compalints",
                column: "HoUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_SocietyId",
                schema: "Identity",
                table: "Compalints",
                column: "SocietyId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_StagesComplaintId",
                schema: "Identity",
                table: "Compalints",
                column: "StagesComplaintId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_StatusCompalintId",
                schema: "Identity",
                table: "Compalints",
                column: "StatusCompalintId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_SubDirectorateId",
                schema: "Identity",
                table: "Compalints",
                column: "SubDirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_TypeComplaintId",
                schema: "Identity",
                table: "Compalints",
                column: "TypeComplaintId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_VillageId",
                schema: "Identity",
                table: "Compalints",
                column: "VillageId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_Solutions_BeneficiariesId",
                schema: "Identity",
                table: "Compalints_Solutions",
                column: "BeneficiariesId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_Solutions_CompalintsHasSolutionId",
                schema: "Identity",
                table: "Compalints_Solutions",
                column: "CompalintsHasSolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_Solutions_UserAddSolutionId",
                schema: "Identity",
                table: "Compalints_Solutions",
                column: "UserAddSolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Directorates_GovernorateId",
                schema: "Identity",
                table: "Directorates",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_BeneficiarieId1",
                schema: "Identity",
                table: "Proposals",
                column: "BeneficiarieId1");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Identity",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "Identity",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDirectorates_DirectorateId",
                schema: "Identity",
                table: "SubDirectorates",
                column: "DirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeComplaints_UsersAddTypeId",
                schema: "Identity",
                table: "TypeComplaints",
                column: "UsersAddTypeId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Identity",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_User_DirectorateId",
                schema: "Identity",
                table: "User",
                column: "DirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_User_GovernorateId",
                schema: "Identity",
                table: "User",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PermissionId",
                schema: "Identity",
                table: "User",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RolesId",
                schema: "Identity",
                table: "User",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_User_SocietyId",
                schema: "Identity",
                table: "User",
                column: "SocietyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_SubDirectorateId",
                schema: "Identity",
                table: "User",
                column: "SubDirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_User_VillageId",
                schema: "Identity",
                table: "User",
                column: "VillageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Identity",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "Identity",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "Identity",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Identity",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCommunications_UsersHasId",
                schema: "Identity",
                table: "UsersCommunications",
                column: "UsersHasId");

            migrationBuilder.CreateIndex(
                name: "IX_Villages_SubDirectorateId",
                schema: "Identity",
                table: "Villages",
                column: "SubDirectorateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenefCommunicationBeneficiarie",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Communication_Counter",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Compalints_Solutions",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "LimitationOrders",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Proposals",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UsersCommunications",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "BenefCommunication",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Compalints",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Beneficiaries",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "StagesComplaints",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "StatusCompalints",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "TypeComplaints",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "TypeBeneficiari",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Permissions",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Societys",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Villages",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "SubDirectorates",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Directorates",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Governorates",
                schema: "Identity");
        }
    }
}
