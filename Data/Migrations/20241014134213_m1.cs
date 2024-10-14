using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LookupFunction.Data.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    OrganisationId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LookupId = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.OrganisationId);
                });

            migrationBuilder.InsertData(
                table: "Organisations",
                columns: new[] { "OrganisationId", "Country", "LookupId", "Name" },
                values: new object[,]
                {
                    { "0abd7a2f-918e-4ded-a651-7b763c468c80", "United Kingdom", "8-10238178", "Inner Wheel Club of Worthing" },
                    { "13803ced-2960-4a4e-851c-94b5cfe80195", "United Kingdom", "8-10237731", "Rotary Club of Barnstaple" },
                    { "172151af-35d7-41d7-87e1-03aed1f922c9", "United Kingdom", "8-10238215", "Inner Wheel Club of Axminster" },
                    { "1989d138-791f-460d-8573-c4118f9d54bf", "United Kingdom", "8-10238123", "Interact Club of Interact Clubs of Bexley & Hamburg-Harburg" },
                    { "30b7c310-1c4f-4d06-aaf2-864771aeefb1", "United Kingdom", "8-10238079", "Inner Wheel Club of Leominster" },
                    { "5c204f1a-40d6-47c9-9add-e0f391b794b3", "United Kingdom", "8-10238050", "Inner Wheel Club of Ross on Wye" },
                    { "6558e8f1-a607-4e5d-be7b-c73e243fd0b9", "United Kingdom", "8-10238205", "Rotary Club Of Kings Lynn Priory" },
                    { "65618224-185f-481e-af10-3900650dce9a", "United Kingdom", "8-10237750", "Rotary Club of Market Bosworth" },
                    { "69132e16-7203-48e5-a13a-54ac2bbc7b19", "United Kingdom", "8-10237743", "Rotary Club of Hitchin Priory" },
                    { "74a09f63-b6ed-47e9-89f0-7d38066543ed", "United Kingdom", "8-10238099", "Rotary Club of Haddington" },
                    { "76fdd04c-484f-4a71-8f8c-420686afe6a5", "United Kingdom", "8-10238100", "Rotary Club of Helston" },
                    { "872b474e-f148-4965-8e29-3e9463725a9f", "United Kingdom", "8-10237872", "Inner Wheel Club of Hayle" },
                    { "8752e313-d09d-4bba-a1c1-53e842e77ec7", "United Kingdom", "8-10238298", "Inner Wheel Club of Londonderry" },
                    { "8a8b1c7a-4708-4cdf-b99d-f949afc1c269", "United Kingdom", "8-10237914", "Rotary Club of Mk Watling" },
                    { "98dc4146-9111-4c55-b14c-a3d6762d7136", "United Kingdom", "8-10238315", "Inner Wheel Club of Darent Valley" },
                    { "ae3e8b16-6bce-47ee-a8a0-60e6341bc181", "United Kingdom", "8-10238255", "Inner Wheel District 6" },
                    { "af45bf68-ad67-4619-8849-2d602630fafb", "United Kingdom", "8-10238092", "Rotary Club of Bridgwater" },
                    { "c17275cd-6b29-41ff-9768-d4a4fdbc997c", "United Kingdom", "8-10237759", "Rotary Club of Dover" },
                    { "e0832ca6-867f-4818-ad7a-6de13187afec", "United Kingdom", "8-10237834", "Inner Wheel Club of District 17 East Zone" },
                    { "f4d1f57d-7fc3-41e9-b554-fbf0929a130a", "United Kingdom", "8-10238097", "Rotary Club of Bury" },
                    { "f50e6933-ac7f-4e31-b23b-e247065042aa", "United Kingdom", "8-10238193", "Rotary Club of Cardigan" },
                    { "fc40b064-6a20-496d-8a4b-379b12df34c6", "United Kingdom", "8-10238282", "Rotary Club of Shepperton and Sunbury" },
                    { "fec51c57-d00b-4c03-84d8-a631a91f045f", "United Kingdom", "8-10238214", "Rotaract Club of Cambridge" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organisations");
        }
    }
}
