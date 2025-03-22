using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BibleReadingSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class BrsAddProfessorGrantsReadingPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ReadingPlanModeId",
                schema: "brs",
                table: "ReadingPlans",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ReadingPlanListBibleBookCompletions",
                schema: "brs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReadingPlanListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReadingPlanListInstanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BibleBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTimeCompleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingPlanListBibleBookCompletions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReadingPlanListBibleBookCompletions_BibleBooks_BibleBookId",
                        column: x => x.BibleBookId,
                        principalSchema: "brs",
                        principalTable: "BibleBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReadingPlanListBibleBookCompletions_ReadingPlanListInstances_ReadingPlanListInstanceId",
                        column: x => x.ReadingPlanListInstanceId,
                        principalSchema: "brs",
                        principalTable: "ReadingPlanListInstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReadingPlanListBibleBookCompletions_ReadingPlanLists_ReadingPlanListId",
                        column: x => x.ReadingPlanListId,
                        principalSchema: "brs",
                        principalTable: "ReadingPlanLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReadingPlanListBibleBooks",
                schema: "brs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReadingPlanListId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BibleBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingPlanListBibleBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReadingPlanListBibleBooks_BibleBooks_BibleBookId",
                        column: x => x.BibleBookId,
                        principalSchema: "brs",
                        principalTable: "BibleBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReadingPlanListBibleBooks_ReadingPlanLists_ReadingPlanListId",
                        column: x => x.ReadingPlanListId,
                        principalSchema: "brs",
                        principalTable: "ReadingPlanLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReadingPlanModes",
                schema: "brs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingPlanModes", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "brs",
                table: "ReadingPlanModes",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { new Guid("cfe77371-fd3c-4d90-82dd-98f6e4443112"), false, "One Chapter Per List" });

            migrationBuilder.InsertData(
                schema: "brs",
                table: "ReadingPlans",
                columns: new[] { "Id", "IsDeleted", "Name", "ReadingPlanModeId" },
                values: new object[] { new Guid("02fd2897-c17c-44ab-869f-94817f2790c8"), false, "Professor Grant Horner's Bible Reading System", new Guid("cfe77371-fd3c-4d90-82dd-98f6e4443112") });

            migrationBuilder.InsertData(
                schema: "brs",
                table: "ReadingPlanLists",
                columns: new[] { "Id", "IsDeleted", "Name", "Order", "ReadingPlanId" },
                values: new object[,]
                {
                    { new Guid("0081f906-5098-412a-8bc0-823b5cc09cef"), false, "List 2", 2, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") },
                    { new Guid("1bd7761b-7eb8-40cf-ace0-8e59db3a9bf0"), false, "List 6", 6, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") },
                    { new Guid("35fe8b97-642e-405a-961e-6b56a2d596ad"), false, "List 5", 5, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") },
                    { new Guid("918615d5-c406-4e9b-8916-fd265b203c3a"), false, "List 4", 4, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") },
                    { new Guid("9d84e0de-8592-47e1-86a5-252f3111240d"), false, "List 3", 3, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") },
                    { new Guid("a9e354ca-a508-443f-9676-10d097518bac"), false, "List 7", 7, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") },
                    { new Guid("bbc79590-54bc-4189-b072-dd44c60492ad"), false, "List 1", 1, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") },
                    { new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7"), false, "List 8", 8, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") },
                    { new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef"), false, "List 9", 9, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") },
                    { new Guid("ff3633ca-f6b6-4e03-9e94-451ac1fc6846"), false, "List 10", 10, new Guid("02fd2897-c17c-44ab-869f-94817f2790c8") }
                });

            migrationBuilder.InsertData(
                schema: "brs",
                table: "ReadingPlanListBibleBooks",
                columns: new[] { "Id", "BibleBookId", "IsDeleted", "ReadingPlanListId" },
                values: new object[,]
                {
                    { new Guid("03aea73e-a649-4128-bb39-d07d6d9c98df"), new Guid("d89b5ca2-b8cf-4494-aa74-6ec0202854ef"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("072361ed-9d6f-4fbd-9e12-498e23a89488"), new Guid("18d4a16c-cb0b-409b-b547-a8e37009a140"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("0947026c-6f85-4615-8082-87a9455a5865"), new Guid("d7049536-570d-426e-9e00-7cac584d9e7a"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("0956b0a6-afd8-48fd-8cc5-0af1e1113aba"), new Guid("59bf320b-23de-431c-ac47-0c38afd4bbfb"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("1183d607-7e21-4fee-8935-4377184dd63f"), new Guid("6813231c-d685-4698-9df8-a47b4a6a3527"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("11d4fd27-9594-40ea-bf60-bb0d8e025c80"), new Guid("c3d8e507-ffe2-4b27-9d08-f0c90dd07d82"), false, new Guid("9d84e0de-8592-47e1-86a5-252f3111240d") },
                    { new Guid("178a2bf8-8a21-421c-aaa3-f7101f345f88"), new Guid("ff5c2160-a444-4d35-b98e-9135d03a80cc"), false, new Guid("9d84e0de-8592-47e1-86a5-252f3111240d") },
                    { new Guid("1cbb49ca-beae-4369-8bcc-94054d702dc7"), new Guid("6a856d0a-a699-426b-a205-6593b7e5ff93"), false, new Guid("9d84e0de-8592-47e1-86a5-252f3111240d") },
                    { new Guid("21c6af9d-ca16-4983-bb10-43655e45cd05"), new Guid("563b55a8-af45-4ea0-be09-c21a20e5cd47"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("21e10a44-342f-4f05-8f9b-1c011809ca86"), new Guid("46b1336e-801b-4f79-a496-f792549af4d4"), false, new Guid("9d84e0de-8592-47e1-86a5-252f3111240d") },
                    { new Guid("29fd0bb2-97e6-4838-873d-4659bf77170f"), new Guid("7d8c8d88-7cf4-4409-a8af-7735b1d0481f"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("2bd80269-2f2c-43af-9d56-af548be2fbb2"), new Guid("1e57b873-250d-47e2-a5bf-a536abb416dd"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("2dd9ac14-2b29-4026-bfaf-cad8fb624404"), new Guid("faf838c8-ad2b-46ff-b34c-e137c91e9628"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("2e5e2403-ac50-4af8-82b0-6194df4b5c26"), new Guid("63473956-dbd2-4827-b8e0-fd5991614530"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("2ebd4c98-c4be-4447-9232-5af31750fc5c"), new Guid("d0bda764-7a29-4a14-a782-17d25c0a3aa4"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("3058131c-a8b8-408f-b504-13ca4c3caff5"), new Guid("8268d09d-7115-4584-b167-9e28edb028a7"), false, new Guid("0081f906-5098-412a-8bc0-823b5cc09cef") },
                    { new Guid("307c946e-864f-4900-ab1c-6a43f29082ce"), new Guid("7ebc039e-f313-40cf-9802-1c1f50586af8"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("313c1544-8b6b-43c3-b32c-0e9ad8281bd5"), new Guid("dff15288-5e76-436e-ac26-33c2866a12e7"), false, new Guid("a9e354ca-a508-443f-9676-10d097518bac") },
                    { new Guid("329d2214-eccc-4549-9df2-787d4c4a5265"), new Guid("7c39f9bb-ce5f-4de7-a8ac-a517a188f1c8"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("35ab1fc5-cc72-48b6-9384-97689e06f388"), new Guid("c7e4acf8-9c97-428d-b556-ec297ec678d0"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("3da32fd6-f1c2-45cf-9cb3-50c3fe2cc43b"), new Guid("0c13d0aa-c792-4729-af5d-5b44c413b1fa"), false, new Guid("1bd7761b-7eb8-40cf-ace0-8e59db3a9bf0") },
                    { new Guid("48b36396-c984-4d9b-bfe9-d482444d84c3"), new Guid("bb943306-ae15-43d3-b801-5c3e641389eb"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("4ac7a9c1-83e2-4443-a642-6c7f3df50b26"), new Guid("259413ba-8b67-423b-9f80-046e2a787e8b"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("4ef34407-8540-42df-959b-16c28aaf4d03"), new Guid("d4e1733f-a95e-4889-bfaa-c26a2c1fe6c7"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("5d47149e-d5d4-4117-8faa-992b7a1158c7"), new Guid("0bc854a8-adb6-46b9-bd4b-747adcdb85d1"), false, new Guid("ff3633ca-f6b6-4e03-9e94-451ac1fc6846") },
                    { new Guid("60bc5193-dddc-4ade-bbe8-bc6feccb402b"), new Guid("d5835b64-9f8c-4f75-b786-2a0d006ee04e"), false, new Guid("0081f906-5098-412a-8bc0-823b5cc09cef") },
                    { new Guid("639f5c36-c2d4-4d29-ae4c-230ea285da11"), new Guid("0ac7dd9e-ef81-4878-851a-11a03fb59e7a"), false, new Guid("bbc79590-54bc-4189-b072-dd44c60492ad") },
                    { new Guid("642538b5-1d13-4234-8f35-f6cadf33ee75"), new Guid("e39ee606-c075-43e1-b180-392b8c3aa2e8"), false, new Guid("9d84e0de-8592-47e1-86a5-252f3111240d") },
                    { new Guid("667e2a41-0cb7-492a-9f18-2a09665f7ac6"), new Guid("75b320b4-c904-4aba-a374-27ad6d285cdc"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("67d97c49-432e-4775-b034-756f19dceadd"), new Guid("6e2a4f0f-fc19-4b6c-ad5b-dfff3dcc5f2f"), false, new Guid("9d84e0de-8592-47e1-86a5-252f3111240d") },
                    { new Guid("74b45c2d-489e-4f93-a86a-a32eee6c3a5c"), new Guid("31186281-c83c-4d27-958e-07a23443e508"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("760f2ac2-d602-4f70-a786-aeeb54b6454d"), new Guid("941362d9-a2e0-4fb8-8943-1de741f7db8f"), false, new Guid("0081f906-5098-412a-8bc0-823b5cc09cef") },
                    { new Guid("784f2449-d09f-41e7-b227-2e00080a5940"), new Guid("1bdbb875-17fb-42df-9b82-1abf7fca1903"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("7c32f3c7-0069-408c-9d6d-e89f4fd4adc4"), new Guid("b392194d-1a88-49d3-92f6-3671e6e1f113"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("7de49009-cbd9-4f2c-9976-015633d58e53"), new Guid("fd10c485-96b3-45fa-be35-48a66fb994a0"), false, new Guid("35fe8b97-642e-405a-961e-6b56a2d596ad") },
                    { new Guid("7e6771b6-de0e-42f9-b8fa-c48b1d9d2726"), new Guid("4e19ecfe-3f08-4717-967e-ddc8d0b31105"), false, new Guid("35fe8b97-642e-405a-961e-6b56a2d596ad") },
                    { new Guid("81e4dd1b-96cc-4568-b219-85b71662040b"), new Guid("e0a7e635-a130-4811-be6a-31d532e2fc1c"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("84c66e88-f825-4553-89ac-338db0eedcf6"), new Guid("9458fe07-bc47-4c43-9fb1-3a9912de3a07"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("955b8b77-f7e7-4671-a62d-de746c3d846a"), new Guid("517ba936-2726-49a6-b119-e81e3544a45b"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("9b2ea912-c30e-4375-86a6-38a4071a6b6c"), new Guid("f99e0e0a-3dc0-4851-a5df-0aa45e9a0e56"), false, new Guid("bbc79590-54bc-4189-b072-dd44c60492ad") },
                    { new Guid("a45e8705-371e-488d-a7d0-660c26271ab8"), new Guid("58b893dd-0454-483c-b848-fce040c8c13e"), false, new Guid("bbc79590-54bc-4189-b072-dd44c60492ad") },
                    { new Guid("a6c5315d-9732-4733-81fa-1a627a9a2c1f"), new Guid("d20745d1-46e4-4cb8-9d99-ef865b058651"), false, new Guid("0081f906-5098-412a-8bc0-823b5cc09cef") },
                    { new Guid("ad836274-1d1c-4b10-a401-305e6f0660d6"), new Guid("758da933-cf9a-4322-ab46-eccf8e4edf3c"), false, new Guid("0081f906-5098-412a-8bc0-823b5cc09cef") },
                    { new Guid("adc92ac7-ec4d-4b22-898d-5f75b6cde99c"), new Guid("7f78c54f-306a-4885-847c-908766e83283"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("b45563e0-4342-42ec-8f6b-4309307577c4"), new Guid("e664e47e-1189-41dd-8870-390ff91a2084"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("be3aec6a-88a1-49c9-bc25-b2038c41f2e9"), new Guid("4022fb3b-5a47-4e18-a0c7-7ded87110e8c"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("c0ebac88-d1e0-4b09-8017-b79033d16f3a"), new Guid("ba6298da-003b-493e-b120-34191af3cbc8"), false, new Guid("9d84e0de-8592-47e1-86a5-252f3111240d") },
                    { new Guid("c12ae676-23b6-4b99-8e0d-0443445495fd"), new Guid("9310ac4a-d730-40e9-9302-d7f068fc1fc8"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("c762d218-6127-45c4-90b3-136d0df8839d"), new Guid("d8c07813-02c1-4e4a-8e64-d0b8cf4a5132"), false, new Guid("9d84e0de-8592-47e1-86a5-252f3111240d") },
                    { new Guid("c9677f1a-cabc-42cc-9daf-c7a7428b8af9"), new Guid("fdf95d6f-bc0e-45b9-9da2-75605314093b"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("cbaca0dc-4d34-4f0d-95cb-7acf992a502c"), new Guid("170abe4e-ff9e-4fc3-b2a0-cc3c5aa0edff"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("cbeb4e2b-db3d-4c83-b6ac-cb24e4842fb8"), new Guid("6ec286f3-2cc1-4cb7-9b97-a95fdf76cee1"), false, new Guid("35fe8b97-642e-405a-961e-6b56a2d596ad") },
                    { new Guid("cd3d0e20-7f81-47fc-a456-2a812b9ce9ab"), new Guid("4f65cdc4-a25c-4dd0-a450-4960ae0f76d0"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("cfd66731-372b-4717-9ed7-79cee0cc5617"), new Guid("9fc43925-78be-47e5-b61a-0aa306e36a25"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("d76b5935-909d-4117-89ce-b9951dd4f105"), new Guid("c4831b20-1c23-40c3-91a2-0aab04e23092"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("d7d6d21c-e6dd-447f-a15e-57052fd619a2"), new Guid("92f9cf16-81d6-4ff7-a436-b3a19b3853ac"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("df99713c-d2cf-4e85-9309-bfa0fbe7bcc7"), new Guid("53354d0e-cd91-4454-be35-de0a6a7eb776"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("e4afcc2d-c5ac-4c78-9080-609bf86fdb49"), new Guid("95c194b2-49d0-4861-9823-ea6aba1eba49"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("e6d0bfd2-f582-45e9-bedd-f5116a1ee0e5"), new Guid("5e2d70d2-20b5-45a6-952c-1f6b6436f0fc"), false, new Guid("bbc79590-54bc-4189-b072-dd44c60492ad") },
                    { new Guid("e9166a80-56e8-4aa5-a391-43508b506e31"), new Guid("a8240d3a-b208-415b-b851-95207252534a"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("ed268988-27f1-4f3c-b4ac-611155bd4fbd"), new Guid("b0388411-9316-4164-a917-6d01e3c2c23f"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("f3b120bd-f8f1-42b6-a24f-602d4728cfd9"), new Guid("5d560094-1de6-413b-85d4-a431d8b1725b"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("f4706fdc-cff4-45c5-a551-90e5c995ae24"), new Guid("873250c8-88bc-4c7f-bb50-529207bd90a5"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") },
                    { new Guid("f8552edf-0cde-4ad6-b9f4-5187d9b6713a"), new Guid("38e989dd-13ad-4ae3-b973-0ca0f619b86d"), false, new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef") },
                    { new Guid("fc0a6ce6-b15d-4bcb-a272-69adaff35af0"), new Guid("740f2044-0f63-4b13-a07b-6c802d159a99"), false, new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7") },
                    { new Guid("fc6a8505-1a5e-4bd8-8a07-db8838676ce1"), new Guid("3e9afb72-3795-423d-badb-50cd71013e47"), false, new Guid("918615d5-c406-4e9b-8916-fd265b203c3a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlans_ReadingPlanModeId",
                schema: "brs",
                table: "ReadingPlans",
                column: "ReadingPlanModeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlanListBibleBookCompletions_BibleBookId",
                schema: "brs",
                table: "ReadingPlanListBibleBookCompletions",
                column: "BibleBookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlanListBibleBookCompletions_IsDeleted",
                schema: "brs",
                table: "ReadingPlanListBibleBookCompletions",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlanListBibleBookCompletions_ReadingPlanListId",
                schema: "brs",
                table: "ReadingPlanListBibleBookCompletions",
                column: "ReadingPlanListId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlanListBibleBookCompletions_ReadingPlanListInstanceId",
                schema: "brs",
                table: "ReadingPlanListBibleBookCompletions",
                column: "ReadingPlanListInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlanListBibleBooks_BibleBookId",
                schema: "brs",
                table: "ReadingPlanListBibleBooks",
                column: "BibleBookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlanListBibleBooks_IsDeleted",
                schema: "brs",
                table: "ReadingPlanListBibleBooks",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlanListBibleBooks_ReadingPlanListId",
                schema: "brs",
                table: "ReadingPlanListBibleBooks",
                column: "ReadingPlanListId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlanModes_IsDeleted",
                schema: "brs",
                table: "ReadingPlanModes",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadingPlans_ReadingPlanModes_ReadingPlanModeId",
                schema: "brs",
                table: "ReadingPlans",
                column: "ReadingPlanModeId",
                principalSchema: "brs",
                principalTable: "ReadingPlanModes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadingPlans_ReadingPlanModes_ReadingPlanModeId",
                schema: "brs",
                table: "ReadingPlans");

            migrationBuilder.DropTable(
                name: "ReadingPlanListBibleBookCompletions",
                schema: "brs");

            migrationBuilder.DropTable(
                name: "ReadingPlanListBibleBooks",
                schema: "brs");

            migrationBuilder.DropTable(
                name: "ReadingPlanModes",
                schema: "brs");

            migrationBuilder.DropIndex(
                name: "IX_ReadingPlans_ReadingPlanModeId",
                schema: "brs",
                table: "ReadingPlans");

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("0081f906-5098-412a-8bc0-823b5cc09cef"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("1bd7761b-7eb8-40cf-ace0-8e59db3a9bf0"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("35fe8b97-642e-405a-961e-6b56a2d596ad"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("918615d5-c406-4e9b-8916-fd265b203c3a"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("9d84e0de-8592-47e1-86a5-252f3111240d"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("a9e354ca-a508-443f-9676-10d097518bac"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("bbc79590-54bc-4189-b072-dd44c60492ad"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("bf640718-0c8b-4236-afb6-3b5ea43ffcd7"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("faa7b54a-5d4d-4bf8-a767-abc9dc4aa7ef"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlanLists",
                keyColumn: "Id",
                keyValue: new Guid("ff3633ca-f6b6-4e03-9e94-451ac1fc6846"));

            migrationBuilder.DeleteData(
                schema: "brs",
                table: "ReadingPlans",
                keyColumn: "Id",
                keyValue: new Guid("02fd2897-c17c-44ab-869f-94817f2790c8"));

            migrationBuilder.DropColumn(
                name: "ReadingPlanModeId",
                schema: "brs",
                table: "ReadingPlans");
        }
    }
}
