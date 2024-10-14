using Microsoft.EntityFrameworkCore;
using System;

namespace LookupFunction.Models;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext() { }
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
	public DbSet<Organisation> Organisations { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder.UseSqlite(Utils.GetSQLiteConnectionString());
		}
	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);

		builder.Entity<Organisation>().HasData(
			new
			{
				OrganisationId = "13803ced-2960-4a4e-851c-94b5cfe80195",
				Name = "Rotary Club of Barnstaple",
				LookupId = "8-10237731",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "69132e16-7203-48e5-a13a-54ac2bbc7b19",
				Name = "Rotary Club of Hitchin Priory",
				LookupId = "8-10237743",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "65618224-185f-481e-af10-3900650dce9a",
				Name = "Rotary Club of Market Bosworth",
				LookupId = "8-10237750",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c17275cd-6b29-41ff-9768-d4a4fdbc997c",
				Name = "Rotary Club of Dover",
				LookupId = "8-10237759",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e0832ca6-867f-4818-ad7a-6de13187afec",
				Name = "Inner Wheel Club of District 17 East Zone",
				LookupId = "8-10237834",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "872b474e-f148-4965-8e29-3e9463725a9f",
				Name = "Inner Wheel Club of Hayle",
				LookupId = "8-10237872",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8a8b1c7a-4708-4cdf-b99d-f949afc1c269",
				Name = "Rotary Club of Mk Watling",
				LookupId = "8-10237914",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5c204f1a-40d6-47c9-9add-e0f391b794b3",
				Name = "Inner Wheel Club of Ross on Wye",
				LookupId = "8-10238050",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "30b7c310-1c4f-4d06-aaf2-864771aeefb1",
				Name = "Inner Wheel Club of Leominster",
				LookupId = "8-10238079",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "af45bf68-ad67-4619-8849-2d602630fafb",
				Name = "Rotary Club of Bridgwater",
				LookupId = "8-10238092",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f4d1f57d-7fc3-41e9-b554-fbf0929a130a",
				Name = "Rotary Club of Bury",
				LookupId = "8-10238097",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "74a09f63-b6ed-47e9-89f0-7d38066543ed",
				Name = "Rotary Club of Haddington",
				LookupId = "8-10238099",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "76fdd04c-484f-4a71-8f8c-420686afe6a5",
				Name = "Rotary Club of Helston",
				LookupId = "8-10238100",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1989d138-791f-460d-8573-c4118f9d54bf",
				Name = "Interact Club of Interact Clubs of Bexley & Hamburg-Harburg",
				LookupId = "8-10238123",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0abd7a2f-918e-4ded-a651-7b763c468c80",
				Name = "Inner Wheel Club of Worthing",
				LookupId = "8-10238178",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f50e6933-ac7f-4e31-b23b-e247065042aa",
				Name = "Rotary Club of Cardigan",
				LookupId = "8-10238193",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6558e8f1-a607-4e5d-be7b-c73e243fd0b9",
				Name = "Rotary Club Of Kings Lynn Priory",
				LookupId = "8-10238205",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fec51c57-d00b-4c03-84d8-a631a91f045f",
				Name = "Rotaract Club of Cambridge",
				LookupId = "8-10238214",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "172151af-35d7-41d7-87e1-03aed1f922c9",
				Name = "Inner Wheel Club of Axminster",
				LookupId = "8-10238215",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ae3e8b16-6bce-47ee-a8a0-60e6341bc181",
				Name = "Inner Wheel District 6",
				LookupId = "8-10238255",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fc40b064-6a20-496d-8a4b-379b12df34c6",
				Name = "Rotary Club of Shepperton and Sunbury",
				LookupId = "8-10238282",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8752e313-d09d-4bba-a1c1-53e842e77ec7",
				Name = "Inner Wheel Club of Londonderry",
				LookupId = "8-10238298",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "98dc4146-9111-4c55-b14c-a3d6762d7136",
				Name = "Inner Wheel Club of Darent Valley",
				LookupId = "8-10238315",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85a402f0-9d6f-433a-941b-a8d893c97fb3",
				Name = "Rotary Club of Eyemouth & District",
				LookupId = "8-10238325",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8ff65797-383f-4437-b079-8878afde5041",
				Name = "Inner Wheel Club of Bacup",
				LookupId = "8-10238433",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3a22aa5b-d7b9-428b-96d0-a926286e5208",
				Name = "Rotary Club of Whitburn",
				LookupId = "8-10238434",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec84c9fa-c87a-4f4f-8294-011abe6ed98b",
				Name = "Inner Wheel Club of Hereford Wye Valley",
				LookupId = "8-10238450",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "358837dd-b643-4094-a3b8-9ac3f1c55c0a",
				Name = "Inner Wheel Club of Uxbridge",
				LookupId = "8-10238481",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3eddcfd4-6e93-4fa7-9ba8-8c1bb7e5b3e0",
				Name = "Rotaract Club of Dublin",
				LookupId = "8-10238568",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d7ae4505-5aa5-4929-9522-7f8bac927db0",
				Name = "Rotary Club of Burnham-on-Sea",
				LookupId = "8-10238603",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "af4348f8-2e7a-4f24-b733-fe45a12a660e",
				Name = "Rotary Club of Ipswich Wolsey",
				LookupId = "8-10238614",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f279af98-4d39-492a-9e5c-4f94a699d05e",
				Name = "Rotary Club of Kirriemuir",
				LookupId = "8-10238615",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a8454861-b4a4-46be-aabe-4d242f4dc42e",
				Name = "Rotary Club of Looe Valley",
				LookupId = "8-10238618",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ffd1e0a3-08fa-4dc0-83fc-cd1e9e236657",
				Name = "Inner Wheel Club of Mansfield",
				LookupId = "8-10238621",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "91a9f6e5-3f06-4e5b-ad39-9b267175b851",
				Name = "Rotary Club of Ponteland",
				LookupId = "8-10238627",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b223c6e9-385f-48ab-a649-ae37ccbd66a5",
				Name = "Inner Wheel Club of Minehead & the Quantocks",
				LookupId = "8-10238635",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7cf96bf5-4272-4bec-a88c-7957777fa596",
				Name = "Rotary Club of Basildon",
				LookupId = "8-10238668",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0b0d44dd-1a76-48a0-9588-b845627a3644",
				Name = "Rotary Club of Gainsborough",
				LookupId = "8-10238739",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b71811f6-6d9f-4060-9a47-3dcd15b1076e",
				Name = "Rotary Club of Hampstead",
				LookupId = "8-10238742",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d4415cba-660b-457e-838a-02d86982f087",
				Name = "Rotary Club of Coatbridge, Airdrie and Monklands",
				LookupId = "8-10238760",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "df301082-1f2b-4c44-8574-0e2b4937126a",
				Name = "Rotary Club of Highdown",
				LookupId = "8-10238790",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "49c478ed-e043-4d0d-8b82-1fa3f1d80543",
				Name = "Rotary Club of Cowbridge /Interact Club of Cowbridge School",
				LookupId = "8-10238878",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c643f903-daea-4e91-94f9-3f679bed182a",
				Name = "Inner Wheel Club of Worsley",
				LookupId = "8-10238918",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ac8f9ddd-1a37-4de2-82df-ea86bfd0e87d",
				Name = "Inner Wheel Club of Arundel",
				LookupId = "8-10238994",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f0766e19-3f60-46c4-98e9-fc68e6529ed6",
				Name = "Rotary Club of Auchterarder & District",
				LookupId = "8-10238997",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "96dbcb92-23f8-4e78-a144-be43767df73c",
				Name = "Rotary Club of Banbury",
				LookupId = "8-10238998",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "30050b1c-f879-4b40-a824-0c257911bc51",
				Name = "Rotary Club of Brigg",
				LookupId = "8-10239002",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "83c66b95-c7a2-4bf6-91c3-903799436531",
				Name = "Rotary Club of Great Harwood & Rishton",
				LookupId = "8-10239009",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e0b2538f-dfdc-4072-92ac-8bf900aecddd",
				Name = "Rotary Club Of Havering",
				LookupId = "8-10239010",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0cd99ba3-b8cb-49ef-9e06-0b470458e38d",
				Name = "Rotary Club of Market Drayton",
				LookupId = "8-10239017",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9c2aec1a-6e6b-4ce5-8d98-c244e9d3a74b",
				Name = "Rotary Club of Melcombe Regis",
				LookupId = "8-10239018",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "14be6ac6-c3ab-4db4-94c6-0317f21eb89f",
				Name = "Inner Wheel District 7",
				LookupId = "8-10239023",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8bcfdc05-d5f7-4939-811e-b077bfd45a69",
				Name = "Rotary Club of Becton and District",
				LookupId = "8-10239146",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d915b28b-0817-45a3-bec5-63c5ce02f310",
				Name = "Inner Wheel Club of Isleworth",
				LookupId = "8-10239322",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2a43f28a-c03e-450b-b1ba-2f45ef669b8f",
				Name = "Rotary Club of Sherwood Sunrisers",
				LookupId = "8-10239324",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ee65864b-5ba3-4695-809f-6910bde8a7b0",
				Name = "Inner Wheel District 11",
				LookupId = "8-10239326",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6ad6bcf1-6feb-410f-9e66-c24aa7e581f4",
				Name = "Rotary Club of Duns",
				LookupId = "8-10239353",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7d28f448-ffe3-482c-82de-85019fcbc3dd",
				Name = "Inner Wheel Club of Bolsover",
				LookupId = "8-10239358",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e34a1d8d-1ab4-45a4-8b42-2f2616957fb7",
				Name = "Rotary Club of Coleraine",
				LookupId = "8-10239368",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b0ed810-2ea9-4ee2-8e2b-18dcb7fbe0a3",
				Name = "Rotary Club of Bristol (Breakfast)",
				LookupId = "8-10239475",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7bf80cb8-05eb-436a-a017-e4aa66f47fe1",
				Name = "Rotary Club of Halstead",
				LookupId = "8-10239482",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c65fa26e-babe-433d-8aed-913b424ecc1f",
				Name = "Rotary Club of Holt",
				LookupId = "8-10239486",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6dffd7f1-b016-4bfa-a028-57b80bf8f8ab",
				Name = "Inner Wheel District 24",
				LookupId = "8-10239487",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ddfe7fad-5f64-4ec1-a10a-7e41e73ae7f8",
				Name = "Rotary Club of Lowestoft South",
				LookupId = "8-10239491",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ac26e03d-6c61-4288-9590-2ccb82395066",
				Name = "Rotary Club of Morriston",
				LookupId = "8-10239494",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1e4ce563-fd8d-4ec6-8618-fe988f9bd624",
				Name = "Rotary Club of Larne",
				LookupId = "8-10239507",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "90d69fc6-0603-4414-b843-bd8d3bfa7232",
				Name = "Rotary Club of Aberdeen St. Machar",
				LookupId = "8-10239513",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aacb550f-b8f4-42a1-b3ac-cb5d89ed6d65",
				Name = "Rotary Club of Hagley",
				LookupId = "8-10239585",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0d69919d-d52b-4b2a-b40f-0ae0abc82d20",
				Name = "Rotaract Club of West Berkshire",
				LookupId = "8-10239589",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9b57dae5-e9e4-41f6-9599-e5a39bde25b1",
				Name = "Rotary Club of Forres",
				LookupId = "8-10239638",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1f7e0ee8-3e6d-4734-b29e-27727976bb39",
				Name = "Inner Wheel Club of Wylde Green",
				LookupId = "8-10239657",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a0407f61-1469-4c5f-a2d0-1762ecce10b3",
				Name = "Inner Wheel Club of Billericay",
				LookupId = "8-10239667",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9de4785e-7329-40f6-ba98-94aa50e707f9",
				Name = "Rotary Club of Erdington",
				LookupId = "8-10239773",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "45b28ff8-2fbb-4781-8988-110f8b25057e",
				Name = "Rotary Club of Orkney",
				LookupId = "8-10239841",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1414cb7c-08cc-4a69-a0cf-8ed9c12ec605",
				Name = "Rotary Club of Ilfracombe",
				LookupId = "8-10239867",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7cbdeb32-216f-4a66-80cd-bd37d0d20c3d",
				Name = "Rotary Club of Jordans & District",
				LookupId = "8-10239868",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bd8e86ed-e9ae-48f7-b9ca-f4009018c0d0",
				Name = "Rotary Club of Nantwich",
				LookupId = "8-10239873",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "954955fe-2c08-4a22-abf4-cb0fffb3fb94",
				Name = "Rotary Club of Dunbar",
				LookupId = "8-10239876",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8c293b95-431b-4b90-9610-d5494e83dcf0",
				Name = "Inner Wheel Club of Porthcawl",
				LookupId = "8-10239877",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "64baa4f9-8baa-46fa-98fe-c31e458c564f",
				Name = "Inner Wheel Club of Blandford",
				LookupId = "8-10239885",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f5a8ba17-01be-4ecb-a64c-85b6c7cf7de3",
				Name = "Rotary Club of Whitehaven",
				LookupId = "8-10239937",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "504e3432-bba1-4eda-9b1d-685136a4e643",
				Name = "Rotary Club of Great Missenden and District",
				LookupId = "8-10239985",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "59348e62-5a13-4aa0-810a-f29f4fc3b4d6",
				Name = "Rotary Club of Melksham",
				LookupId = "8-10239990",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "238a07be-95e7-4774-a4db-ab177d5031e8",
				Name = "Rotary Club of Motherwell & Wishaw",
				LookupId = "8-10239993",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aad990b6-cdd4-424d-9cf7-345a191b983f",
				Name = "Rotary Club of Bracknell",
				LookupId = "8-10240008",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d1c6cb05-f37c-4e7a-a231-8d70f2c0364d",
				Name = "Rotary Club of Meriden",
				LookupId = "8-10240011",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b855a78a-a055-4e52-bca4-935c0b8df9e7",
				Name = "Rotary Club of Caerleon",
				LookupId = "8-10240016",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "66a13778-0996-424e-a8cb-20ede0deebb3",
				Name = "Rotary Club of Cotswold Tyndale",
				LookupId = "8-10240056",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3acdc321-62ac-482c-a0da-88901ba8c508",
				Name = "Rotary Club of Donaghadee",
				LookupId = "8-10240060",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3b0c12d-aeba-4316-9734-e2855813dbdc",
				Name = "Rotary Club of Downham Market",
				LookupId = "8-10240062",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4dbd4eca-207b-4faf-bdaf-4fb749140d96",
				Name = "Rotary Club of Kingsbridge",
				LookupId = "8-10240068",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "be9361e8-1a59-415c-b3dd-90fac6cae28b",
				Name = "Inner Wheel Club of Sidcup",
				LookupId = "8-10240236",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "706766ca-af24-4745-8856-64166381dc3d",
				Name = "Rotary Club Of Bexhill-On-Sea",
				LookupId = "8-10240241",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fdae035e-c965-455c-a1a5-f9a0c714b4aa",
				Name = "Rotary Club of Brownhills",
				LookupId = "8-10240244",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f371440a-62e5-41e2-8fab-9c3208b4e9f6",
				Name = "Rotary Club of Holyhead",
				LookupId = "8-10240256",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c43cac69-5f79-489b-b45e-682c432c6fa5",
				Name = "Rotary Club of Midsomer Norton & Radstock",
				LookupId = "8-10240262",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b6a4f116-fae4-4a13-8bbf-d7b1c7e70003",
				Name = "Interact Club of Sandwich",
				LookupId = "8-10240263",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "47605104-4156-4afc-87b8-63f085594b3b",
				Name = "Inner Wheel District 9",
				LookupId = "8-10240266",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "38e81183-7187-4aab-8778-4972bd4a39b9",
				Name = "Inner Wheel Club of Farnham Weyside",
				LookupId = "8-10240275",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9cb22cfe-8990-4555-9a89-b6fa726dc7d3",
				Name = "Rotary Club of Windsor & Eton",
				LookupId = "8-10240283",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ba26b338-3637-413a-bc71-1bbab387ada5",
				Name = "Rotary Club of Axminster",
				LookupId = "8-10240313",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "38294b1e-8aa2-405d-b8cc-43b5784c0129",
				Name = "Rotary Club of Frome",
				LookupId = "8-10240323",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f9455138-d9e5-445b-8c0a-7473925c213b",
				Name = "Inner Wheel Club of The Quantocks",
				LookupId = "8-10240502",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ed37e052-1df9-4b39-b54d-c41ca8d37cd4",
				Name = "Rotaract Club of Ealing",
				LookupId = "8-10240520",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aabbce6c-cdde-4cab-96ab-cf94f5feb118",
				Name = "Rotary Club of Halifax Calder",
				LookupId = "8-10240560",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "74fba896-59b2-4b88-810a-5f4c5f1cfc17",
				Name = "Rotary Club of Oxford Spires",
				LookupId = "8-10240648",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0ba1622d-1811-4f90-a4cd-1238da398ee1",
				Name = "Inner Wheel Club of Seaton",
				LookupId = "8-10240828",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cb4e639c-6b1f-4d34-9776-73d536815d8a",
				Name = "Interact Club of Thurso High School",
				LookupId = "8-10240872",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aca179e8-ed98-49e3-9c08-e83588c30cb0",
				Name = "Rotary Club of New Mills, Marple & District",
				LookupId = "8-10240900",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a13d4831-3d58-40d6-8601-c5d79d9cab31",
				Name = "Inner Wheel Club of Padiham",
				LookupId = "8-10240902",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e5dce8ba-f6f6-480b-b86d-021a845976fe",
				Name = "Rotary Club of Alcester & Bidford",
				LookupId = "8-10240934",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fc87f664-8987-4cfd-a67f-4212bff46d2c",
				Name = "Inner Wheel Club of Sherborne",
				LookupId = "8-10241076",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c170cac3-514b-4ded-b1ce-894c25588fb4",
				Name = "Rotary Club of Ilkeston",
				LookupId = "8-10241082",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2179ea27-c2c2-4a75-a304-cdfe402c3649",
				Name = "Inner Wheel Club of Glossop",
				LookupId = "8-10241098",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "511bbbae-c384-4db8-8e14-bcc879278b1c",
				Name = "Rotary Club of Derwentside",
				LookupId = "8-10241164",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85614743-2f0b-47fc-ba40-002700894cad",
				Name = "Inner Wheel Club of Gillingham (Kent)",
				LookupId = "8-10241231",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "795bf99d-57b3-4036-9f74-7c708a08109d",
				Name = "Rotary Club of Alderney",
				LookupId = "8-10241359",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aae87368-87de-4bac-8a9d-7bd4d0bb8576",
				Name = "Rotary Club of Northwich",
				LookupId = "8-10241375",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec99f4a4-db74-4580-bb77-0d1b40eb61d2",
				Name = "Rotary Club of Birkenhead",
				LookupId = "8-10241409",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "94c1ba88-b63e-4055-8a10-78a4360773b1",
				Name = "Rotary Club of Camberley",
				LookupId = "8-10241410",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0cdb6561-cab9-4f2a-b31a-42721e402568",
				Name = "Inner Wheel Club of Cardiff",
				LookupId = "8-10241411",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "acb909e0-459f-45e0-a416-623f3230fb99",
				Name = "Rotary Club of Inverness",
				LookupId = "8-10241412",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "29ad1db3-9644-495d-9547-53e6866c2560",
				Name = "Rotary Club of Northallerton Mowbray",
				LookupId = "8-10241414",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c63fb226-72fc-4a0b-a68f-ae4ab1650ebb",
				Name = "Rotary Club of Reading Matins",
				LookupId = "8-10241415",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea39e1fe-90da-43c9-abc4-2d67ef0c0818",
				Name = "Rotary Club of Reepham & District",
				LookupId = "8-10241420",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4fc9be93-233a-4143-a42b-89f0efeac19d",
				Name = "Rotary Club of Whitchurch",
				LookupId = "8-10241429",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b379ec57-8151-4710-af93-9686b2be3461",
				Name = "Rotary Club of Felixstowe Landguard",
				LookupId = "8-10241430",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "916103e0-65fd-4e17-b074-164643a25928",
				Name = "Inner Wheel Club of Weybridge & Byfleet",
				LookupId = "8-10241432",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9bf024e2-7c4c-489b-a06f-8b072e5a1a29",
				Name = "Rotary Club of East Grinstead Meridian",
				LookupId = "8-10241435",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f2836734-6d97-4ecc-82e8-99de5f38013c",
				Name = "Rotary Club of Amber Valley",
				LookupId = "8-10241436",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d97064f7-5ecd-4e70-a7df-ef7accc492b6",
				Name = "Rotary Club of Otley",
				LookupId = "8-10241437",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8a4ab805-5913-4593-b16d-e143fb451966",
				Name = "Rotary Club of Bangor Co. Down",
				LookupId = "8-10241439",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1fdc192d-cff6-4cb4-b75a-9f0cf46a6ef5",
				Name = "Inner Wheel Club of Wimbledon",
				LookupId = "8-10241629",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "901e1d48-86f3-4a85-ba8f-e9df0fe1937a",
				Name = "Rotary Club of Cramlington",
				LookupId = "8-10241638",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a158f8d4-c824-4c6a-a22d-490da59d1108",
				Name = "Interact Club of Darrick Wood",
				LookupId = "8-10241657",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "134b67ac-095f-4e81-b290-bdef262ff7ae",
				Name = "Rotary Club of Crowthorne and Sandhurst",
				LookupId = "8-10241744",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b7ed42a7-ea59-4a47-bc11-f0e7555cd0ce",
				Name = "Rotary Club of York Ainsty",
				LookupId = "8-10241751",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "31b0513e-a9e2-498a-a425-7b708d231295",
				Name = "Inner Wheel Club of Dawlish",
				LookupId = "8-10241763",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1bdcd12c-547c-4ad5-bcf5-8aa15890c5b8",
				Name = "Inner Wheel Club of Uckfield",
				LookupId = "8-10241880",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5144fab3-c419-4486-9e73-ef20762695c3",
				Name = "Rotary Club of Coulsdon Manor",
				LookupId = "8-10242136",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0e2b6c4b-a1c5-4749-9805-e029d420bf80",
				Name = "Rotary Club of Brewood & District",
				LookupId = "8-10242164",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2bd8c042-e5de-45cc-aad0-5bc9b849ab9a",
				Name = "Rotary Club of Lunesdale",
				LookupId = "8-10242166",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "402bf932-ba0b-4c44-8a95-75058b0f4ae7",
				Name = "Rotary Club of West Ashfield",
				LookupId = "8-10242252",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "05935aa1-0039-4bdc-93fb-addef29ddd4a",
				Name = "Rotary District 1110",
				LookupId = "8-10242265",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9d0c8ade-e057-4356-9e8d-66c5c34ffb14",
				Name = "Rotary Club of East Kilbride",
				LookupId = "8-10242266",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eeb7e98b-d678-4729-bd8b-f42948727e84",
				Name = "Rotary Club of Haverhill & District",
				LookupId = "8-10242329",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "72fba48c-0fbb-4931-951c-032c9327e762",
				Name = "Rotary Club of Blairgowrie",
				LookupId = "8-10242428",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6740684e-b6f6-4ed1-a447-91844e4d4040",
				Name = "Rotary Club Of Blandford & Stour",
				LookupId = "8-10242429",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7638d81c-3916-474c-9c60-2be6ea9d5644",
				Name = "Rotary Club of Worcester",
				LookupId = "8-10242432",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "68c28643-4f99-4562-a66d-c0b395f594e0",
				Name = "Rotary Club of Nairn",
				LookupId = "8-10242433",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6bdd7450-c448-443d-b9f3-268a0edbefcc",
				Name = "Rotary Club of Newhaven",
				LookupId = "8-10242434",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1f032b63-7ed6-42a1-9669-86cf143a9d30",
				Name = "Rotary Club Of Kingston upon Thames",
				LookupId = "8-10242435",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "43bb7b15-e07a-43df-80eb-ac7251d35911",
				Name = "Rotary Club of Hull Paragon",
				LookupId = "8-10242436",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b1a232b6-99ce-407b-b5a2-00bcfe308c1f",
				Name = "Inner Wheel Club of Thetford",
				LookupId = "8-10242452",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fceb6f93-57ea-4ca6-9a1f-6a30a95ef863",
				Name = "Rotary Club of Erskine & District",
				LookupId = "8-10242456",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f21b2667-fcc4-41a9-b7ce-c67fb3f7de41",
				Name = "Rotary Club of Colwall",
				LookupId = "8-10242504",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "43f08160-2e89-4619-bad4-67c2ad3354ce",
				Name = "Rotary Club of Birtley",
				LookupId = "8-10242515",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fad55c20-2117-460d-bfc5-6c0bf30d4db2",
				Name = "Rotary Club of Bradford",
				LookupId = "8-10242517",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0114f0c9-881b-4ac3-866e-88d30b22f1f3",
				Name = "Rotary Club of North Fife",
				LookupId = "8-10242534",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b4574171-45b7-4a37-b1be-76cec0bc8523",
				Name = "Rotary District 1220",
				LookupId = "8-10242556",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bc5a871e-f4ee-4236-a0a4-76abc4b0f4ae",
				Name = "Rotary Club of Lowestoft East Point",
				LookupId = "8-10242650",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "95d24ce2-6f6a-41bf-830e-ff950118cd9f",
				Name = "Inner Wheel Club of Southgate",
				LookupId = "8-10242676",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ef18c6cd-a1c4-47e4-99bc-88fd6fc40397",
				Name = "Inner Wheel Club of Kendal",
				LookupId = "8-10242677",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9ee6f6a3-a035-45cf-9a26-7be31706b37b",
				Name = "Inner Wheel Club of Newton Aycliffe",
				LookupId = "8-10242698",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "96bc401c-6b18-4c9d-b482-15b6bc13ae39",
				Name = "Rotary Club Of Dunmow",
				LookupId = "8-10242742",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85b593bf-14c1-47cd-a964-0367478ee89d",
				Name = "Rotary Club of Manchester",
				LookupId = "8-10242743",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4e2f0811-9f03-4724-ad14-9f1dd6fa0c7b",
				Name = "Inner Wheel Club of Southampton",
				LookupId = "8-10242747",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cfb96410-46fe-4d7b-982a-f7b7993f73f5",
				Name = "Inner Wheel Club of Feltham",
				LookupId = "8-10242748",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "90881ff4-8ad9-45c4-9f7f-286492fea7dd",
				Name = "Rotary Club of Richmond, Surrey",
				LookupId = "8-10242758",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "99ae43e9-700e-4c7f-9085-db682b7c39bf",
				Name = "Rotary Club of Beaconsfield",
				LookupId = "8-10242779",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "821a6c0b-279c-40a9-ac84-cb7fd563fc0f",
				Name = "Rotary Club of Campbeltown",
				LookupId = "8-10242780",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dccb06ac-ca1f-4bdb-a82e-5981a841ce3f",
				Name = "Rotary Club of Maghull & Aughton",
				LookupId = "8-10242782",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "709037f8-6fea-4975-854c-eefd40dbd617",
				Name = "Rotary District 1090",
				LookupId = "8-10242787",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bdb4fa85-b28b-4024-b735-0de7379976af",
				Name = "Rotary Club of Stowmarket Gipping Valley",
				LookupId = "8-10242789",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "37930d52-27e6-4644-a276-3cce545af5b6",
				Name = "Rotary Club of Conwy Valley",
				LookupId = "8-10242793",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bb2f88a2-15fe-47d7-aaca-722a888f3b84",
				Name = "Rotary Club of Cockermouth",
				LookupId = "8-10242798",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "26131fbb-c6ba-42a7-b4b8-181eea1b371b",
				Name = "Rotary Club of Exeter",
				LookupId = "8-10242800",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "03090044-4eb4-4a83-b11e-62a4e5eb5c03",
				Name = "Rotary Club of Wigan",
				LookupId = "8-10242802",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d7378ca5-739a-4bd6-a766-210cbc57162a",
				Name = "Rotary Club of Naas",
				LookupId = "8-10242807",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7195ff8a-a1f9-435f-93eb-50e771229d73",
				Name = "Rotary Club of Leeds Elmete",
				LookupId = "8-10242869",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "494f5229-af13-4ec0-93cc-e1190559db2a",
				Name = "Rotary Club of Haslemere",
				LookupId = "8-10242870",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aaa772f9-25c4-480d-b4a0-a0843282e62b",
				Name = "Rotary Club of Bradgate",
				LookupId = "8-10243127",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0874eb8c-5b65-4f2d-a2c5-3b569b66d926",
				Name = "Rotary Club of Stratford-upon-Avon",
				LookupId = "8-10243129",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cfdd6464-a0e7-464f-a625-7f3e3d5c8172",
				Name = "Inner Wheel Club of Babbacombe",
				LookupId = "8-10243130",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e2242acb-0578-4bd8-bdae-4e2922cbd190",
				Name = "Rotary Club of South Molton",
				LookupId = "8-10243131",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f7e527d2-f6c8-4fce-9987-8c05fad867a3",
				Name = "Inner Wheel Club of Market Bosworth",
				LookupId = "8-10243153",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c1284998-e51e-46ea-ab4d-067bc88ed056",
				Name = "Inner Wheel Club of Littlehampton",
				LookupId = "8-10243154",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3efd1a45-914f-4f80-9b11-be407b69ede6",
				Name = "Rotary Club of Bridport",
				LookupId = "8-10243160",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d7257427-3700-458f-97b3-10c59a116075",
				Name = "Rotary Club of Gryffe Valley",
				LookupId = "8-10243161",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c762525d-4799-4201-a627-f2f5e0f35809",
				Name = "Inner Wheel Club of Strathaven",
				LookupId = "8-10243167",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6bac968e-a1fa-4bd1-83d2-c1f8f36b5e18",
				Name = "Rotary Club of Westcliff-On-Sea",
				LookupId = "8-10243168",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7450dacb-c8fa-4798-bb90-968688d398ad",
				Name = "Rotary Club of Uppingham",
				LookupId = "8-10243197",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d51b5874-6bdb-4218-9e36-816426b6a00c",
				Name = "Rotary Club of Hexham",
				LookupId = "8-10243198",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8e9ca9be-2411-442d-a968-25dc7dff887e",
				Name = "Rotary Club of Radlett",
				LookupId = "8-10243207",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e05d3ca5-d9ab-4c8c-838c-957444b6a3ce",
				Name = "Inner Wheel Club of Dereham",
				LookupId = "8-10243221",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0abbeea5-570b-4844-8cd5-ad008693c6a0",
				Name = "Rotary Club of Reading Abbey",
				LookupId = "8-10243222",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "14e34a7a-a36b-4c18-b90d-0d122fa9942c",
				Name = "Interact Club of Lytham St Annes",
				LookupId = "8-10243231",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "232a41e8-87b0-4a1d-a032-32f8c35a3b1c",
				Name = "Inner Wheel Club of Wednesfield",
				LookupId = "8-10243243",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4f9f4466-7aef-4199-812b-afb9bab41fc7",
				Name = "Rotary Club of Wolverton and Stony Stratford",
				LookupId = "8-10243333",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "52b38626-79aa-4157-add2-7d47102b5e5d",
				Name = "Inner Wheel Club of Babbacombe & St Mary Church",
				LookupId = "8-10243341",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "62fe1ae6-0706-46b7-b7de-1c7b5a5663b3",
				Name = "Inner Wheel Club of Wallasey",
				LookupId = "8-10243439",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7948bf91-ca42-4b95-a2cc-4c8947cd155b",
				Name = "Interact Club Archbishop Blanch School",
				LookupId = "8-10243441",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e8f6c333-98da-4a7d-9850-ed09413ddccd",
				Name = "Rotary Club of Lymm",
				LookupId = "8-10243443",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2c8a4ddc-4181-4fd2-b1a2-0e0e908bdec2",
				Name = "Inner Wheel Club of Pontefract",
				LookupId = "8-10243447",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f9ae88e5-456a-4cfd-b000-87491247db8a",
				Name = "Rotary Club of Storrington & Pulborough District",
				LookupId = "8-10243478",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3ae5177e-c947-4896-b953-9e068380e20f",
				Name = "Rotary Club of Erith",
				LookupId = "8-10243482",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6852c113-8bf4-4efe-8c9d-2bea9027c854",
				Name = "Rotary Club of Birstall Luddites",
				LookupId = "8-10243484",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8895b756-0a6a-469e-aa59-34bc9cafa616",
				Name = "Interact Club of Wilmington Grammar School For Boys",
				LookupId = "8-10243490",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fdfc34cb-4a55-4092-b1b1-d406ab106a74",
				Name = "Rotary E-Club of London Centenary",
				LookupId = "8-10243506",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e5af8c51-cde6-487f-a2ff-c2f98210c073",
				Name = "Interact Club of Wirral Grammar School For Girls",
				LookupId = "8-10243546",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2abc4c6b-fd90-4fab-ae00-403847ab622b",
				Name = "Inner Wheel Club of Glastonbury & Street",
				LookupId = "8-10243592",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0db3ae0e-aaaf-45c1-8e79-41c85679ad27",
				Name = "Rotary Club of Aylesbury",
				LookupId = "8-10243606",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f16ea8d9-9ddf-4172-aabb-f67b83d7a6bb",
				Name = "Rotary Club of Bognor Regis",
				LookupId = "8-10243607",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c3fd329f-0160-452f-a8ee-0123885930ff",
				Name = "Rotary Club of Brentwood Breakfast",
				LookupId = "8-10243608",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "56d5e3b1-adf9-404e-b8c4-4398f65aec05",
				Name = "Rotary Club of Camelford",
				LookupId = "8-10243609",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "71c0f848-5bc9-4125-9980-a6cd3e12f1b9",
				Name = "Rotary Club of Midhurst & Petworth",
				LookupId = "8-10243611",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4ddd58a1-689e-4890-99e0-ed5ad08be87d",
				Name = "Rotary Club of Worcester Vigornia",
				LookupId = "8-10243620",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "287e16b6-d959-4ecc-ae12-f20735ab84bc",
				Name = "Rotary Club of Chelwood Bridge",
				LookupId = "8-10243628",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1607f87b-14b0-4955-8e95-2f9a1f9976bc",
				Name = "Rotary Club of Aboyne & Upper Deeside",
				LookupId = "8-10243629",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f55e79cb-da04-489a-94b1-75a847586bf6",
				Name = "Rotary Club of Weston-Super-Mare",
				LookupId = "8-10243631",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2ebce6c5-9f17-4e4d-90d9-b69c3605be5d",
				Name = "Rotary Club of Whitehaven Castle",
				LookupId = "8-10243632",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "579c48f9-a34b-4f90-ab0a-8055a647c609",
				Name = "Rotary Club of Yeo Vale",
				LookupId = "8-10243633",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "87a6dff5-56f3-4f34-8220-672f39c43d2f",
				Name = "Inner Wheel Club of Durham",
				LookupId = "8-10243664",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "476d3363-399b-4ddd-9f10-5e94fd70b195",
				Name = "Rotary Club of Oldbury",
				LookupId = "8-10243666",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "007b7035-cea3-41ed-b082-6b143dd68622",
				Name = "Inner Wheel Club of Mendip",
				LookupId = "8-10243672",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec374478-a067-4020-8fe1-e2f3e8fb9193",
				Name = "Rotary Club of Ormskirk",
				LookupId = "8-10243699",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2eb6592d-8b0e-413c-b82b-c153abe1594c",
				Name = "Rotary Club of Inverness Riverside",
				LookupId = "8-10243706",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "782a05a0-ddad-4d6a-8c39-521fb9c4911c",
				Name = "Inner Wheel Club of Langport & Somerton",
				LookupId = "8-10243717",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "41a3bcb4-42b1-446a-96f6-b79d3d62e1a3",
				Name = "Rotary Club of York",
				LookupId = "8-10243757",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "14c41b6a-7c20-4a58-ad78-ee1f082c23d4",
				Name = "Rotary Club of Hillside (Finchley)",
				LookupId = "8-10243919",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f311c666-883f-4afd-ab57-16cbd778976c",
				Name = "Rotary Club of Aberdeen",
				LookupId = "8-10243922",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2da9b8c4-6ba7-4922-b671-8805b16b330a",
				Name = "Inner Wheel Club of Saxmundham & District",
				LookupId = "8-10243943",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f20d66bf-fbf7-4ba3-8120-95ebccccb97f",
				Name = "Inner Wheel Club of Wellingborough",
				LookupId = "8-10243944",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "91e04afd-d694-4672-9c6c-d6a12bb90ea0",
				Name = "Inner Wheel Club of Armagh",
				LookupId = "8-10244230",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a10ffef6-f727-4bc6-91b2-4b87811c768e",
				Name = "Rotary Club of Cricklade & District",
				LookupId = "8-10244231",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7f39636c-7f31-414a-92d3-cc9966244bf7",
				Name = "Rotary Club of Canterbury Sunrise",
				LookupId = "8-10244232",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c89786d0-4844-4086-a37e-3b18c2b3fb7e",
				Name = "Rotary Club of Strood",
				LookupId = "8-10244282",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "981a8fc1-5c6e-409a-a20c-76bb3c0e0c22",
				Name = "Interact Club of Hockerill Anglo-European College",
				LookupId = "8-10244324",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9baf0c1b-7417-4f0a-897a-94053e9c27dc",
				Name = "Rotary Club of Mill Hill",
				LookupId = "8-10244334",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "33527ea1-5701-4ea8-8e30-715085174628",
				Name = "Rotary Club of Stokesley",
				LookupId = "8-10244346",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b9db45cb-3900-49b3-bb25-2c3bb6367d3d",
				Name = "Rotary Club of Dungannon",
				LookupId = "8-10244347",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "01b56ef6-15eb-454c-bb6a-4388538aaaa2",
				Name = "Inner Wheel Club of Cosham",
				LookupId = "8-10244572",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a2a4395f-8506-4594-8e22-3ac687167725",
				Name = "Interact Club of Ash Manor School",
				LookupId = "8-10244573",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "84d22f15-c9c6-45d3-9a54-af945b31ddf6",
				Name = "Rotary Club of Redditch",
				LookupId = "8-10244594",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2f138e11-d19b-4b9a-a473-acdab51e3ee4",
				Name = "Rotary Club of Sowerby Bridge",
				LookupId = "8-10244596",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a70fea63-d9d9-46e3-80dc-23d44f20f28d",
				Name = "Inner Wheel Club of Henley Bridge",
				LookupId = "8-10244724",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e59de6cf-04f1-40f5-bd00-38e0904b7e6c",
				Name = "Inner Wheel Club of Camborne",
				LookupId = "8-10244727",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ca87de2a-8e99-4393-af0b-883ab019fca5",
				Name = "Inner Wheel Club of Bookham & Horsley",
				LookupId = "8-10244737",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2c9170f7-c385-4354-9779-9cf94f9ee3d6",
				Name = "Inner Wheel Club of Kingsbridge",
				LookupId = "8-10244738",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8705d2e1-988b-4b6a-996e-a13125c97620",
				Name = "Rotary Club of Ellesmere Port, Wirral",
				LookupId = "8-10244739",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "53e1950e-a06b-4511-8c82-c79e3c404c24",
				Name = "Rotary Club of Todmorden",
				LookupId = "8-10244764",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ff51ec3e-200c-43d2-984b-49d1243b2ee1",
				Name = "Inner Wheel Club of Hamble Valley",
				LookupId = "8-10244784",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7b3617ec-e472-4cf9-bd7b-c3d072cc7efd",
				Name = "Interact Club of St Patrick's Academy Dungannon",
				LookupId = "8-10244909",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2b11bfb1-3239-485f-8dbe-bb6355c1a312",
				Name = "Rotary Club of Fermoy & District",
				LookupId = "8-10244912",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5e082d50-ff10-4259-ab9f-d82efd94b791",
				Name = "Inner Wheel Club of Lowestoft",
				LookupId = "8-10245036",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1703f67b-3030-420e-849d-a73343c002cc",
				Name = "Rotary Club of Poole",
				LookupId = "8-10245053",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a7e99c1f-7731-457d-821c-20d5f24ca44b",
				Name = "Rotary Club of Stafford Knot",
				LookupId = "8-10245065",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e1b0ff6a-5369-42f1-818d-84f926e4889c",
				Name = "Rotary Club of Stirling",
				LookupId = "8-10245066",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a96e5ec3-e4f8-491f-9619-7a8f959eac4f",
				Name = "Inner Wheel Club of Thorne",
				LookupId = "8-10245068",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3055abf-fb77-42d7-bee1-d6d0671b1b8f",
				Name = "Interact Club of Canterbury Interact @ Simon Langton Girls Grammer",
				LookupId = "8-10245094",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c587f2a2-706c-4b35-b988-9ca23746fc65",
				Name = "Interact Club of King Edward VI Five Ways School",
				LookupId = "8-10245278",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d67a89ea-9f29-49b3-86f7-1988c63dfb76",
				Name = "Rotary Club of Brynmawr",
				LookupId = "8-10245282",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2a6e95b2-24eb-4751-9852-0d425fcd1586",
				Name = "Rotaract Club of Langley and Iver",
				LookupId = "8-10245594",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b29a031c-288e-4596-bfd9-6a80958378f1",
				Name = "Rotary Club of Scarborough Cavaliers",
				LookupId = "8-10245624",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1e929c08-7009-4548-a6e6-87715fcba61b",
				Name = "Inner Wheel Club of Porthmadog",
				LookupId = "8-10245729",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a75e2743-d6d3-4ac1-966b-115547c29cb3",
				Name = "Interact Club of Wheatley Park School",
				LookupId = "8-10245827",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "be76901c-502a-4d8e-a418-2d1e163691a5",
				Name = "Rotary Club of Irlam",
				LookupId = "8-10245912",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e88b9e40-fd8b-47e3-a81e-6f56335d6d01",
				Name = "Rotary Club of Perranzabuloe",
				LookupId = "8-10246027",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fe9e421e-38cc-41c2-9c32-3e1b5b0819f8",
				Name = "Rotary Club of Roborough",
				LookupId = "8-10246032",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fe6c370d-6a17-4afe-a3b6-627b3dd4fa73",
				Name = "Rotary Club of Clay Cross",
				LookupId = "8-10246238",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "243985d6-74cc-46e8-b115-d17f3a3cda0f",
				Name = "Inner Wheel Club of Clay Cross",
				LookupId = "8-10246239",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a878cba3-5965-4110-8f5a-ecf47916ae1f",
				Name = "Rotary Club of Congleton",
				LookupId = "8-10246240",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cd456abb-482d-4161-ab16-bf6076dd5229",
				Name = "Rotary Club of Egham",
				LookupId = "8-10246245",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c0bab878-a0c0-46dc-a76d-77a48e25cf73",
				Name = "Interact Club of Wye Valley Bourne",
				LookupId = "8-10246329",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a54a81f6-9b58-4471-9118-1af3f3b7ffb9",
				Name = "Rotary Club of Amersham",
				LookupId = "8-10246351",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cb948d59-310b-45e6-bc18-ba8a5e4c4dbf",
				Name = "Inner Wheel Club of Whitley Bay",
				LookupId = "8-10246486",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cb8cb494-5504-45fd-997c-942fa478522e",
				Name = "Interact Club of Carterton Community College",
				LookupId = "8-10246502",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bd74c087-f944-49b3-adc8-7306416f6fc1",
				Name = "Rotary Club of Taunton",
				LookupId = "8-10246591",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "298aaf3e-2538-4f31-b7c0-dcd49811e246",
				Name = "Rotary Club of Cheltenham",
				LookupId = "8-10246597",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ef84e55d-c21b-4513-95f1-5f59043fe5b5",
				Name = "Rotary Club of Leominster",
				LookupId = "8-10246598",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d387a2d4-ffef-4d62-928b-3954aac425ac",
				Name = "Rotary Club of Llangefni",
				LookupId = "8-10246610",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5b66ffed-2793-4789-a1ca-c22999ec44df",
				Name = "Inner Wheel Club of Dunfermline",
				LookupId = "8-10246617",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0a87d44b-3975-44a4-9771-7799000c410d",
				Name = "Inner Wheel Club of Aberdeen",
				LookupId = "8-10246652",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "22f8d5a9-17f2-44c0-a780-8eba37cdc2dc",
				Name = "Interact Club of Rhyddings",
				LookupId = "8-10246658",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b6c8a7cb-a241-47fb-a944-fcf933891804",
				Name = "Inner Wheel Club of Evesham",
				LookupId = "8-10246768",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4e4f955a-862d-4699-b424-66ab593a754a",
				Name = "Inner Wheel Club of West Wickham",
				LookupId = "8-10246928",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "31a172ff-32cb-47c2-a94b-3db5c71f211a",
				Name = "Rotary Club of Bath",
				LookupId = "8-10246932",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1f3e0e3d-5e45-49cc-8463-9f1b47a5ed45",
				Name = "Rotary Club of Carluke",
				LookupId = "8-10246934",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7f5a1214-d6f0-4710-b502-082c4a92b90d",
				Name = "Rotary Club of Guildford",
				LookupId = "8-10246935",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6d3b4b70-6816-4cd7-8dbc-bb626e1eac15",
				Name = "Rotary Club of Huntingdon Cromwell",
				LookupId = "8-10246936",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "692250c0-3218-4045-873e-1394f1c178ae",
				Name = "Rotary Club of Sherwood Forest",
				LookupId = "8-10246948",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ca89f1a0-eb41-400b-acd4-92340554f121",
				Name = "Inner Wheel Club of Yeovil",
				LookupId = "8-10246949",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3887aad0-2817-496f-8a0f-b2d058c9c152",
				Name = "Rotary Club of Llandeilo",
				LookupId = "8-10246952",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0e5017d9-ed65-44d1-ad6b-f124f8650cf5",
				Name = "Inner Wheel Club of Welshpool",
				LookupId = "8-10246954",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f74697fc-bf24-4574-af1a-28d8d7cbfe8e",
				Name = "Rotary Club of Dartford",
				LookupId = "8-10246960",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7af73f97-b3e6-436b-b543-0457a8e0ce37",
				Name = "Rotary Club of Turriff & District",
				LookupId = "8-10246961",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "284ef210-a435-4d4d-9cca-850cb79f1b32",
				Name = "Inner Wheel Club of Lisburn",
				LookupId = "8-10246964",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a0e94a47-cc5d-412b-9852-1aff5095232c",
				Name = "Inner Wheel Club of Newtownards",
				LookupId = "8-10246965",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "707634f9-add6-46bf-adec-9f09160144d8",
				Name = "Rotary Club of Pickering",
				LookupId = "8-10246966",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cdc0aaef-45a8-4ce4-953b-18ed76131790",
				Name = "Inner Wheel Club of Sligo",
				LookupId = "8-10246968",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cc58d9c4-1502-48b1-a4cd-2a1740c344c6",
				Name = "Rotary Club of Ely",
				LookupId = "8-10246971",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "298a0ba2-25a0-4b4a-bc65-cb385f8e8f35",
				Name = "Rotary Club of Kelvedon & District",
				LookupId = "8-10246972",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e432cd36-812a-429e-9cae-4498456fa976",
				Name = "Rotary Club of Leeds White Rose",
				LookupId = "8-10246977",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a85a49d2-52b8-424d-ba8f-540eb761efc0",
				Name = "Inner Wheel Club of Formby",
				LookupId = "8-10246978",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c7919643-035c-4cbe-b2b4-2172a2dc74f7",
				Name = "Inner Wheel District 3",
				LookupId = "8-10246982",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "25134de4-9f2c-4a04-8cfa-61e6f3a23dbc",
				Name = "Rotary Club of Sandbach",
				LookupId = "8-10247054",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0a2b10e6-bc4a-47ff-a008-5aacb9dbeac3",
				Name = "Rotary Club of Peterborough Minster",
				LookupId = "8-10247062",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9be83dda-4abd-42c8-a35e-630c0f7d8d83",
				Name = "Rotaract Club of Chichester",
				LookupId = "8-10247128",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "70ade993-e466-4c61-a3ac-108874055f7a",
				Name = "Inner Wheel Club of Wells",
				LookupId = "8-10247129",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "89101a6b-8d79-4cf9-a785-60829933535a",
				Name = "Inner Wheel Club of Humberside",
				LookupId = "8-10247138",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e7b0a763-2d8a-4695-a96b-012b7fd83984",
				Name = "Rotary Club of Bristol",
				LookupId = "8-10247143",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "47a37303-8f8c-43a6-be6c-455357902cdb",
				Name = "Rotary Club of Tullamore",
				LookupId = "8-10247149",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2025bcf3-933f-4326-acf0-63e1b9f2b2c4",
				Name = "Rotary Club of Carse of Stirling, Central",
				LookupId = "8-10247255",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4e00dfa7-d96b-49b9-ab3f-60135034e2ee",
				Name = "Rotary Club of Formby",
				LookupId = "8-10247256",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ee1a5f6e-0353-40d0-8300-ea0ec9841ecd",
				Name = "Rotary Club of Gateshead-Upon-Tyne",
				LookupId = "8-10247257",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a568cd3f-5e9a-4962-8c99-ed0a8bf4667b",
				Name = "Inner Wheel Club of Rushden",
				LookupId = "8-10247266",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aab7edaa-4c8a-46e7-9199-4debe99c06dc",
				Name = "Rotary Club of South Woodham Ferrers",
				LookupId = "8-10247277",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "12da9be1-8690-4cd8-89cb-d3e718d89b9c",
				Name = "Rotary Club of Haworth & Worth Valley",
				LookupId = "8-10247279",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "86244ed5-85f7-4d92-bb51-ed19eba7fc3a",
				Name = "Rotary Club of Douglas, IOM",
				LookupId = "8-10247281",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9a1478d5-0edd-4425-a1a8-bb3820c30917",
				Name = "Inner Wheel Club of Lymm",
				LookupId = "8-10247288",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "739ebba0-ee4a-4849-ab6e-2c8bbade3afb",
				Name = "Inner Wheel Club of Heswall",
				LookupId = "8-10247294",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4776dbb7-3e32-400c-8506-53c2ee810004",
				Name = "Rotary Club of Drogheda",
				LookupId = "8-10247322",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c9451cc4-252b-456e-832b-229c51e65521",
				Name = "Rotaract Club of Kintore",
				LookupId = "8-10247369",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b5a9b770-d11f-4b33-bcd1-37ffe52b8417",
				Name = "Rotary Club of Rhos-On-Sea",
				LookupId = "8-10247507",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f4157e7c-bfab-41e0-a7c8-098f9f57d55c",
				Name = "Inner Wheel Club of Sandy & District",
				LookupId = "8-10247699",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "880a6e55-0f1c-49c6-ada0-46127d320a87",
				Name = "Rotary Club Of St Albans Priory",
				LookupId = "8-10247701",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d0713099-e64e-4526-91c7-df0b138847c1",
				Name = "Inner Wheel Club of Mold",
				LookupId = "8-10247797",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "36d505bf-436e-48f8-8e6a-dc9f936f073e",
				Name = "Rotary Club of Tyldesley with Atherton",
				LookupId = "8-10247889",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1ee44713-fff9-4d61-9ef1-a2def9aa9b11",
				Name = "Interact Club Stratton Upper School",
				LookupId = "8-10247892",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2be797ac-8af4-4836-a468-aaf1687e227d",
				Name = "Rotary Club of Alnwick",
				LookupId = "8-10247909",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1c6c3d4b-b00b-47dd-87e5-59c711e5f14d",
				Name = "Rotary Club of Penzance",
				LookupId = "8-10247916",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "66266d9e-7f3a-4b93-bb18-b7c399eb035e",
				Name = "Rotary Club of Pitlochry",
				LookupId = "8-10247917",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "586d070f-3007-4a18-9751-c6313c86b200",
				Name = "Rotary Club of Saltash",
				LookupId = "8-10247926",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6f1ef1b4-30b6-4827-8f9c-512da973943b",
				Name = "Rotary Club of Govan (Glasgow)",
				LookupId = "8-10247945",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3b38b0ee-8dd5-4e2a-8631-4f4a2478111b",
				Name = "Rotary Club of Brackley",
				LookupId = "8-10248073",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3eb7b47a-1402-4ee0-82bb-164952bc1b2d",
				Name = "Rotary Club of Bush Hill Park",
				LookupId = "8-10248102",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0c48c9c2-e7e2-43e6-8e88-d1d6b24e3766",
				Name = "Rotary Club of Mexborough & District",
				LookupId = "8-10248106",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f92e8ef6-bc6b-4740-be35-836166839fbd",
				Name = "Rotary Club of Kilsyth",
				LookupId = "8-10248129",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dd3364ba-8b14-40c1-a23a-d7f8d879c63e",
				Name = "Rotary Club of Whitley Bay",
				LookupId = "8-10248140",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2fc96e10-ad06-4fd4-8479-ad9f95d8b65d",
				Name = "Rotary Club of Stafford",
				LookupId = "8-10248141",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9175d5cf-2863-4ca5-8a39-e36eb8fc386e",
				Name = "Rotary Club of Guildford District",
				LookupId = "8-10248145",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a4c9a731-ad90-445c-b1a1-563d6bd28edf",
				Name = "Rotary Club of The Weald of Kent",
				LookupId = "8-10248146",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b791bb65-72dd-4bfa-923f-6a68b499b86b",
				Name = "Rotary Club of Newham",
				LookupId = "8-10248151",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "48c2793d-fefc-4342-a35e-f1a028142c28",
				Name = "Rotary Club of Carmarthen Tywi",
				LookupId = "8-10248157",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cdf03904-c374-4f71-9d84-8eb0b01f7aa8",
				Name = "Rotary Club of Gloucester",
				LookupId = "8-10248164",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "62cf5bab-28ed-46ec-8b21-3660b92f9ba0",
				Name = "Rotary Club of Barton-le-Clay",
				LookupId = "8-10248169",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d31bb7ff-217b-4a7a-af2b-b4f52830618f",
				Name = "Inner Wheel Club of Workington Derwent",
				LookupId = "8-10248285",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2b5eb55b-539a-43bc-9ad4-cef3913e9c67",
				Name = "Rotary Club of Portlaoise",
				LookupId = "8-10248317",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6bfa4ffc-0598-47d2-99e5-af6445b70982",
				Name = "Inner Wheel Club of Barrow-in-Furness",
				LookupId = "8-10248671",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fbd660bf-10e8-4454-b9fc-77c0b84fd292",
				Name = "Rotary Club of Ampthill & District",
				LookupId = "8-10248695",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "52bf04b3-67c7-4fa9-bc03-ec428abf7d00",
				Name = "Rotary Club of Padiham",
				LookupId = "8-10248696",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bd62c6e7-2886-4ac9-82cc-f725f6dc34fa",
				Name = "Rotary Club of Truro",
				LookupId = "8-10248705",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4dac74bb-76a2-4f28-a946-a2d8607da8ef",
				Name = "Inner Wheel Club of Tranent",
				LookupId = "8-10248724",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "702a35fe-b371-4dc2-97cd-95ac6c918fb5",
				Name = "Rotary Club of Lurgan",
				LookupId = "8-10248746",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d79b4dac-9bd8-48eb-adb5-5867e75392e8",
				Name = "Rotary Club of Carlisle",
				LookupId = "8-10248754",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6039bb9b-be56-49f3-9f6c-21d9c0291995",
				Name = "Rotary Club of Chelmer Bridge",
				LookupId = "8-10248760",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "11554fd0-bcca-40f4-9be2-2f73bbb7a36a",
				Name = "Rotary Club of Maidenhead",
				LookupId = "8-10248761",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2375c884-f769-4968-b0b4-e074d683deeb",
				Name = "Rotary Club of Newcastle-upon-Tyne",
				LookupId = "8-10248762",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3de64d56-e30c-41f2-8f85-ba5982cd6d29",
				Name = "Rotary Club of Wellingborough Hatton",
				LookupId = "8-10248792",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4381f701-3562-4db2-99dd-c041447528df",
				Name = "Rotary Club of Hadrian's Wall (Tynedale)",
				LookupId = "8-10248793",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e7a1bc5c-d9b4-4554-a033-a530f1ff8de7",
				Name = "Interact Club of Towers School",
				LookupId = "8-10248798",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3e7ea99c-15b1-47d7-ae30-389249c81606",
				Name = "Inner Wheel Club of Wellingborough Hatton",
				LookupId = "8-10248799",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bcba62c2-67a3-4a7b-af76-3e27974a8aa5",
				Name = "Rotary Club Of Burnham On Crouch & Dengie Hundred",
				LookupId = "8-10248806",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b245cb82-9481-44e0-a898-c5d6ad0ce927",
				Name = "Rotary Club of Monifieth & District",
				LookupId = "8-10248860",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0ead1ff8-55cd-4223-b0bc-cb3c69849f58",
				Name = "Inner Wheel Club of Dumbarton",
				LookupId = "8-10248862",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f559fbe8-ad9f-4e72-b3aa-8273dcf6d286",
				Name = "Rotary Club of Church & Oswaldtwistle",
				LookupId = "8-10248868",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3148cb3f-605e-40a5-be2c-467e27d3f7ad",
				Name = "Inner Wheel Club of Guernsey",
				LookupId = "8-10248874",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "df5afdcb-2def-4265-9fe8-4f8c2b96b5a7",
				Name = "Rotary Club of Birmingham Breakfast",
				LookupId = "8-10248877",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bef698df-9070-4087-824f-25cc544f4538",
				Name = "Rotary Club of Llanfairfechan & Penmaenmawr",
				LookupId = "8-10248879",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1fface71-ae6f-44f3-8106-5bc7d30b0959",
				Name = "Rotary Club of Rugeley",
				LookupId = "8-10248886",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b3da4255-1fab-447d-a9aa-55bf92adedfe",
				Name = "Rotary Club of Cowdenbeath",
				LookupId = "8-10248890",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9f9f7bc8-0079-4ce4-a8c1-0048f7e8421c",
				Name = "Rotary Club of Folkestone Channel",
				LookupId = "8-10248891",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bf78bbbc-3df9-4f71-bb92-9ac2955caca5",
				Name = "Rotary Club of Royden Revolve",
				LookupId = "8-10248899",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "20fb7d58-8982-4ef0-99af-dc7317c5a3e8",
				Name = "Rotary Club of Crompton & Royton",
				LookupId = "8-10248900",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "19059315-d6a4-4976-af6f-53920822f081",
				Name = "Rotary Club of Woodford Green",
				LookupId = "8-10248901",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "13ed8359-e00f-4a0b-9e3e-78f6ce21735a",
				Name = "Inner Wheel Club of Keyworth & Ruddington",
				LookupId = "8-10249025",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c83cca4b-3b8c-43d4-abd3-7ef0e6543923",
				Name = "Rotary Club of Hove",
				LookupId = "8-10249074",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1f3daeaf-f0e5-4b82-a5c3-879f7d96aa82",
				Name = "Rotary Club Of Lichfield St Chad",
				LookupId = "8-10249076",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d67b86b9-43d5-4f28-bb8e-5b290a1e737e",
				Name = "Rotary Club of Liskeard & Looe",
				LookupId = "8-10249077",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "20ae93ba-43ca-42e6-88df-98fc0bcf5f9d",
				Name = "Inner Wheel Club of Sedgemoor",
				LookupId = "8-10249088",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6a9e0e9f-fdab-41b2-8fa6-34d0e5b7ef54",
				Name = "Inner Wheel Club of Maidstone",
				LookupId = "8-10249091",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "08755e4b-b802-44d4-81cc-95dbd463d590",
				Name = "Rotary Club of Bishops Waltham",
				LookupId = "8-10249101",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "03d97648-0d95-4f23-b5c4-7f1e2a6c1387",
				Name = "Rotary Club of Hungerford",
				LookupId = "8-10249103",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e2ab8365-5faa-424e-a7e5-719d863919d8",
				Name = "Rotary Club of Leytonstone and Woodford",
				LookupId = "8-10249104",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3a665763-23c8-4e6f-acaf-a9c8c63076b1",
				Name = "Rotary Club of Loanhead & Roslin",
				LookupId = "8-10249105",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "707f5ec1-5b5b-4295-a0cb-9a6ca9a5864f",
				Name = "Rotary Club of Rushcliffe",
				LookupId = "8-10249107",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c8954f83-15dc-4c87-b950-4361bfbb4cdb",
				Name = "Rotaract Club of Newton Aycliffe",
				LookupId = "8-10249115",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "34f79166-1885-4316-a6f0-d38fc8096bc5",
				Name = "Rotary Club of Peterhead",
				LookupId = "8-10249121",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d2a4d590-3845-45ac-bd86-65de0a556def",
				Name = "Rotary District 1080",
				LookupId = "8-10249127",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dfd788ae-0a0a-4775-ac6d-403a92df257e",
				Name = "Rotary Club of Dunoon",
				LookupId = "8-10249128",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ffd33fde-fad1-49bf-a9e4-310dc5fbfbd6",
				Name = "Rotary Club of Tynedale",
				LookupId = "8-10249129",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "add1b4b9-1f60-484b-9899-e57b9ef6422e",
				Name = "Rotary Club of High Wycombe",
				LookupId = "8-10249130",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "957dfe2d-1eb4-48f0-bd16-940851cf6a9e",
				Name = "Rotary Club of Flitwick Vale",
				LookupId = "8-10249133",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "50659eb3-79c7-4385-a555-b48eb174c2cc",
				Name = "Inner Wheel Club of Lutterworth",
				LookupId = "8-10249143",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "30a70715-1b25-4213-8424-eb23ed2951cc",
				Name = "Inner Wheel Club of Hoddesdon",
				LookupId = "8-10249154",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f762aae3-d7a7-4482-bfc0-1ffc221f5c71",
				Name = "Rotary Club of Bathavon",
				LookupId = "8-10249177",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ebde1a11-88cd-4f70-9db2-251c457b575a",
				Name = "Rotary Club of Bideford",
				LookupId = "8-10249178",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b89a12b5-20c3-4fe3-a9fd-62a32cf85e6d",
				Name = "Rotary Club of Great Yarmouth",
				LookupId = "8-10249181",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85b2d4ad-32c1-4652-92db-e9e7aeeae307",
				Name = "Rotary Club of Hull",
				LookupId = "8-10249182",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "38616ad6-d204-44a7-969e-5de587d7893e",
				Name = "Inner Wheel Club of Larne",
				LookupId = "8-10249186",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "adc6e847-0f68-47c7-8ad6-5c666dbffcb3",
				Name = "Inner Wheel Club of Hall Green",
				LookupId = "8-10249192",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ecb5366a-e435-46f8-ac27-91aa8cc26a8e",
				Name = "Rotary Club of Woking District",
				LookupId = "8-10249195",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d0b9acc0-b09e-4053-9ac7-d1a2666eca16",
				Name = "Rotary Club of Cork Bishopstown",
				LookupId = "8-10249200",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cf7645c7-467c-4f03-a990-517aceccd415",
				Name = "Rotary Club of Swansea Valley",
				LookupId = "8-10249212",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4504e342-65f5-4cba-84f7-007564cf3a3b",
				Name = "Rotary Club of Cork",
				LookupId = "8-10249234",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a61a5190-054f-4434-963b-90e417f261b1",
				Name = "Rotary Club of Neath",
				LookupId = "8-10249246",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eac85aa0-5fc8-4ed6-bba0-517f76fa4473",
				Name = "Rotary Club of Kennington",
				LookupId = "8-10249247",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea74c4c7-6841-42f1-af96-5a688769b003",
				Name = "Rotary Club of Pantiles Tunbridge Wells",
				LookupId = "8-10249253",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d278d75f-7dd9-49a3-a84b-19f59d066b21",
				Name = "Rotary Club of Hucknall",
				LookupId = "8-10249256",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "52b7957a-6090-466e-a4b9-d13f4dbbe118",
				Name = "Rotary Club of Long Eaton Dawnbreakers",
				LookupId = "8-10249258",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "29dc114f-92f9-4ecf-9f8e-4365fa10d6f1",
				Name = "Rotary Club of Dawlish Water",
				LookupId = "8-10249261",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b20f2a86-e3b4-4980-9122-b647e42e7130",
				Name = "Rotary Club of Sherbourne Castles",
				LookupId = "8-10249263",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b4d0d9f-0676-45b5-bee3-184814fe114c",
				Name = "Rotary Club of Banbridge",
				LookupId = "8-10249264",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3cb86610-b9f7-42cb-81e8-e49019c3bbb4",
				Name = "Rotary Club of Fraserburgh",
				LookupId = "8-10249271",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "62576241-5a40-4aa0-b04c-e4c044ca7f4e",
				Name = "Inner Wheel Club of Chard",
				LookupId = "8-10249282",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "256083d3-48d8-4159-9ac9-cf4f0d539dee",
				Name = "Rotary Club of Denton & Audenshaw",
				LookupId = "8-10249292",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e388d1a1-3370-4676-a674-e9cefc827bad",
				Name = "Rotary Club of Framlingham",
				LookupId = "8-10249299",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3022133e-d18f-4102-9106-dfa16b25d493",
				Name = "Rotary Club of Crawley",
				LookupId = "8-10249300",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "61d24355-18c7-4277-8ad7-18104fa448be",
				Name = "Rotary Club of Bailgate Lincoln",
				LookupId = "8-10249312",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9c85554e-5958-4eda-858d-dc59e3b3b1ed",
				Name = "Rotary Club of Bude",
				LookupId = "8-10249313",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c525fa12-f823-46b5-b749-1c9f378f9b6c",
				Name = "Rotary Club of Carshalton Park",
				LookupId = "8-10249314",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f180460b-6955-4ffa-869c-7194035494a2",
				Name = "Rotary Club of Norwich",
				LookupId = "8-10249316",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "265391dd-d2c0-496c-8300-a09e621ae073",
				Name = "Rotary Club of Cupar",
				LookupId = "8-10249391",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "11923155-7e0d-485f-a471-322e13109ca4",
				Name = "Inner Wheel Club of Crayford",
				LookupId = "8-10249396",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "db9bf11f-080d-41ce-9bf4-8d4b54b43e2a",
				Name = "Inner Wheel Club of Wrexham",
				LookupId = "8-10249417",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6657f112-eb8c-43c1-b418-20d05977011e",
				Name = "Rotary Club of Burnley Pendleside",
				LookupId = "8-10249419",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c1735ff5-31ae-4ca3-a476-8d8221fce2c8",
				Name = "Rotary Club of Henley-In-Arden",
				LookupId = "8-10249420",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "36b38ab6-e703-4670-b5eb-7a0a5a6d9e95",
				Name = "Inner Wheel Club of Cwmbran",
				LookupId = "8-10249430",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "599b11a9-c9fb-4d78-96fc-bf064da19425",
				Name = "Rotary Club of Dorchester Casterbridge",
				LookupId = "8-10249432",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f21aad4f-0eba-4e5a-a7e7-e1c0fe3e9535",
				Name = "Rotary Club of Ware",
				LookupId = "8-10249434",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "397ac9d4-7c7d-4614-b525-27d74da0b088",
				Name = "Rotary Club of Oldham",
				LookupId = "8-10249437",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dd25b0cd-c6b8-44e4-abd1-125442a1ad40",
				Name = "Rotary Club of Preston Guild",
				LookupId = "8-10249438",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bfa09b51-dfa3-49a0-9745-062cb354a48b",
				Name = "Rotary Club of Oxford North",
				LookupId = "8-10249439",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8ae59605-9327-4794-9341-b34d320523f3",
				Name = "Inner Wheel Club of Dursley",
				LookupId = "8-10249441",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "223dec77-ac6a-4269-9ef4-6e4d0c603404",
				Name = "Inner Wheel Club of Exmouth",
				LookupId = "8-10249442",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "47c5f955-6ff8-44e9-ac38-5e281cca0845",
				Name = "Inner Wheel Club of Abergele",
				LookupId = "8-10249443",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "688e6c77-2303-4c19-a04c-f257b410417f",
				Name = "Inner Wheel Club of Kibworth & Fleckney",
				LookupId = "8-10249444",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "927420f7-a2fc-4b5b-afd0-61f85855eb1c",
				Name = "Rotary Club of Portlethen & District",
				LookupId = "8-10249445",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "df687c73-9b24-4019-80f3-d52fe4ed8111",
				Name = "Inner Wheel Club of Ballymena",
				LookupId = "8-10249448",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6dfbec91-d61f-4e79-b23e-9f51959b48ef",
				Name = "Interact Club of Bexley At Bexleyheath School",
				LookupId = "8-10249454",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a6faba6f-1605-46c2-958a-3bdb4f6ac980",
				Name = "Inner Wheel Club of Warsop",
				LookupId = "8-10249463",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "39b76998-0180-43d7-b225-990cc8ea4248",
				Name = "Rotary Club of Barnoldswick & Earby",
				LookupId = "8-10249467",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c6db22a0-0cbc-4235-b28a-653d9a4ba18d",
				Name = "Interact Club of The Royal School",
				LookupId = "8-10249471",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "95704f16-9c69-41a9-9d11-1057395af15a",
				Name = "Rotary Club of Prestwick",
				LookupId = "8-10249562",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a1405bc4-787d-4cf7-bfda-d72c096ad3d8",
				Name = "Inner Wheel Club of Mumbles",
				LookupId = "8-10249565",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b3fc9d80-514d-4b1c-ac00-4e22465cd5c4",
				Name = "Rotary Club of Bradford Blaize",
				LookupId = "8-10249570",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "991e3235-d2cf-49fc-b30b-ca1ec03d5738",
				Name = "Rotary Club of Nuneaton",
				LookupId = "8-10249571",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9ba842cb-9d11-43d3-8128-3dfc9fb2a3c9",
				Name = "Inner Wheel District 26",
				LookupId = "8-10249573",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c275df6a-2b7b-4a05-baf9-e978662b6339",
				Name = "Rotary Club of Grimsby Havelok",
				LookupId = "8-10249575",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d26f05ba-7eff-484a-9f99-99a765f15f09",
				Name = "Rotary District 1240",
				LookupId = "8-10249576",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3008b262-842e-4f74-899a-edba1eb575c1",
				Name = "Inner Wheel Club of Witney",
				LookupId = "8-10249589",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "de251fdf-ad8f-48b8-9c75-182b4c706c8b",
				Name = "Inner Wheel Club of Wickford",
				LookupId = "8-10249603",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "44123501-1370-4fc7-9374-ac8fa83f77eb",
				Name = "Rotary Club of Torrington",
				LookupId = "8-10249794",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fd25ba79-e102-4f09-92c0-47098f203835",
				Name = "Rotary Club of Chester-Le-Street",
				LookupId = "8-10249795",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f17c9875-7c17-4181-b669-1f9bf7d3a3a8",
				Name = "Rotaract In Great Britain and Ireland",
				LookupId = "8-10249796",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8790f47d-842a-456c-b209-541ca4fde397",
				Name = "Rotary Club of St. Neots St. Marys",
				LookupId = "8-10249808",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b76cede4-04cb-4873-abad-b38c1ac5fa0b",
				Name = "Rotaract Club of Tottington & Bury West",
				LookupId = "8-10249819",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b14f859-61be-49c3-96dd-2d0f9a934fab",
				Name = "Rotary Club of Maesteg",
				LookupId = "8-10249822",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a384dcf7-0b5f-425e-b825-2110bdc53df5",
				Name = "Rotary Club of Strathaven",
				LookupId = "8-10249823",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "78926f1b-37e6-430d-b0f9-0f4a0df7e859",
				Name = "Rotary Club of Kidderminster",
				LookupId = "8-10249829",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "791d7f1c-606a-4167-a3e0-9800f24211e6",
				Name = "Inner Wheel Club Of North Fife",
				LookupId = "8-10249830",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f31304af-ccd2-47b2-a36c-1ef35e144c2a",
				Name = "Rotary Club of Uttoxeter",
				LookupId = "8-10249872",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1bd7623f-7f67-4df5-86d4-95f3afcd8c27",
				Name = "Rotary Club of Workington Derwent",
				LookupId = "8-10249874",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "09c95de1-e1f4-45a0-8982-730912fd3682",
				Name = "Rotary Club of Heywood",
				LookupId = "8-10249875",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6732a9fa-6e8a-463f-b380-ef4aa9881b82",
				Name = "Inner Wheel Club of Southend Estuary",
				LookupId = "8-10249902",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a48b6194-9d3a-4441-87f8-6706732a7d6a",
				Name = "Rotary Club of Thatcham & District",
				LookupId = "8-10249911",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b01c6d74-b6ee-4fbb-813d-9c009b9823e0",
				Name = "Inner Wheel Club of Milford Haven",
				LookupId = "8-10249948",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8d33833c-9855-46b1-846f-bf455d44271b",
				Name = "Rotary Club of Beeston",
				LookupId = "8-10250025",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "78594b62-67de-4e82-b916-1db0f14906fa",
				Name = "Rotary Club of Leatherhead",
				LookupId = "8-10250027",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "76714758-dbb2-46fe-9018-36815f4b1374",
				Name = "Rotary Club of Uckfield",
				LookupId = "8-10250028",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2438f8bb-6896-48f7-b48a-f5357e5e21cd",
				Name = "Rotary Club of West Wirral",
				LookupId = "8-10250030",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e9a505c7-77c8-4c83-914a-15104425fb32",
				Name = "Rotary Club of Chipping Campden",
				LookupId = "8-10250031",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "788816df-50e5-414a-a4f6-a43df0837565",
				Name = "Rotary Club of Amble & Warkworth",
				LookupId = "8-10250032",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f241e6e3-574f-4d16-9588-321f54ecd09a",
				Name = "Rotaract Club of Swale",
				LookupId = "8-10250059",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ae306dc2-01be-4931-b5c1-be1677be00c4",
				Name = "Rotary Club of North Berwick",
				LookupId = "8-10250060",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8cad7133-14b5-43e1-97d2-898a6d0bd8c3",
				Name = "Rotary Club of Andover Anton",
				LookupId = "8-10250073",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "07cd6da2-34b7-463f-97ac-a8bd506db9f5",
				Name = "Rotary Club of Ilminster",
				LookupId = "8-10250094",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fa35d13b-6bb9-450e-844b-71a1e8d35485",
				Name = "Rotary Club of Margate",
				LookupId = "8-10250096",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7005eeec-eabf-41ea-a3f1-d7e09a8fd328",
				Name = "Rotary District 1190",
				LookupId = "8-10250103",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2aeb65dc-6a27-460e-be76-d96704033ca9",
				Name = "Inner Wheel Club of Bebington",
				LookupId = "8-10250104",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1dd8117f-299a-4626-a8c0-3f3350b06293",
				Name = "Inner Wheel Club of Rothwell",
				LookupId = "8-10250232",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "53925fc8-5a25-4e39-b318-d1912754c8f5",
				Name = "Inner Wheel Club of Morecambe & Heysham",
				LookupId = "8-10250254",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "edebc8e9-8a66-4865-bdb9-0444035177b5",
				Name = "Rotary Club of Edgbaston Convention",
				LookupId = "8-10250364",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "487dc810-20be-4f75-8e7a-31d9932db41d",
				Name = "Rotary Club of Biggleswade",
				LookupId = "8-10250367",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c8f042f4-1196-4fa8-87df-432265137149",
				Name = "Rotary Club of North Worcestershire",
				LookupId = "8-10250369",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9aa3d69e-9aea-400c-bb23-57fd95909ad8",
				Name = "Rotary Club of Wetherby & District",
				LookupId = "8-10250372",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "518845ea-de30-4549-b889-d0d12589572c",
				Name = "Rotary Club of Caterham",
				LookupId = "8-10250377",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3552890-079d-4ff2-8fe3-3b2276d28378",
				Name = "Rotary Club of East Sutherland",
				LookupId = "8-10250381",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "008155f1-0ecc-49ae-bf9c-033bae5f30e5",
				Name = "Rotary Club of Northallerton",
				LookupId = "8-10250382",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7535ff5d-d8ac-4d28-9ae1-96d5977507dc",
				Name = "Inner Wheel Club of Alfreton",
				LookupId = "8-10250425",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cb79219e-6b49-4992-97e0-db259673d48e",
				Name = "Rotary Club of Dalbeattie",
				LookupId = "8-10250576",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1ac4c99c-9753-47f0-a1de-f035db051068",
				Name = "Rotary Club of Newcastle-under-Lyme",
				LookupId = "8-10250580",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "031bcd64-a03a-4a0d-b967-6eb4096790ea",
				Name = "Rotary Club of Ellon",
				LookupId = "8-10250587",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f4f94f33-6dd3-49d0-b4d6-602decebe7df",
				Name = "Inner Wheel Club of Stone",
				LookupId = "8-10250606",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "22cc3e0d-250d-40e5-802a-29d963e7a432",
				Name = "Inner Wheel Club of Renfrew & Govan",
				LookupId = "8-10250619",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9d0417e2-3e2d-43b2-b8f3-ba09991bb2e8",
				Name = "Rotary E-Club of Aviation",
				LookupId = "8-10250660",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "78d87273-e3c5-4b40-979c-1e36afeeffdf",
				Name = "Rotary Club of Greenford",
				LookupId = "8-10250662",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2ce33ce9-aeaa-4a8c-b9d1-36a4b8e9fcb1",
				Name = "Rotary Club of Anstruther",
				LookupId = "8-10250663",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c3f1c85b-c496-417d-aea2-b3d365798fcf",
				Name = "Rotary Club of Horbury & Ossett Phoenix",
				LookupId = "8-10250670",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d0b25a11-7a2b-4131-b4d7-d3e3a40cef6b",
				Name = "Inner Wheel Club of Cupar",
				LookupId = "8-10250679",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec9f9441-99fb-4eca-9e7c-f808a94f1a3b",
				Name = "Rotary Club of Christchurch",
				LookupId = "8-10250682",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0ec42651-2f21-489c-ba7b-1342ee699df8",
				Name = "Inner Wheel Club of Falkirk",
				LookupId = "8-10250683",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ecb9884a-0713-450f-be3d-3b1dd8356f1e",
				Name = "Rotary Club of Blackwood",
				LookupId = "8-10250685",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0c9d112c-1f32-483d-baee-2d124ed703cf",
				Name = "Inner Wheel Club of Flitwick Vale",
				LookupId = "8-10250712",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1079f03f-31fa-4623-b7cc-a283e386412a",
				Name = "Rotary Club of Bloxwich Phoenix",
				LookupId = "8-10250812",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "276bd0f7-dd36-44a3-8be9-48a66a48e98f",
				Name = "Inner Wheel Club of Bourne End & Cookham",
				LookupId = "8-10250813",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b19d8bbd-9ca9-405f-9b8c-40e1cf520804",
				Name = "Inner Wheel District 4",
				LookupId = "8-10250815",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f6369080-5936-45d9-a0cf-2a650524e493",
				Name = "Rotary Club of Ironbridge",
				LookupId = "8-10250816",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1fe6a283-f960-445c-8827-58c300f46ee3",
				Name = "Rotary Club of Maryport",
				LookupId = "8-10250817",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "228905ec-3e18-4361-909f-887eefd447fe",
				Name = "Rotary Club of Newport, Gwent",
				LookupId = "8-10250818",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e2a506e6-514c-4364-80d7-f72819051b9f",
				Name = "Inner Wheel Club of Worksop",
				LookupId = "8-10250831",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ff412258-3a26-4c45-9d75-34770deaf43c",
				Name = "Rotary Club of Droitwich Spa",
				LookupId = "8-10250832",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3cf3230b-c66b-40f7-a059-0ca93c50e0c7",
				Name = "Rotary Club of Yeovil",
				LookupId = "8-10250833",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7d3a2ab2-41f4-4d25-8263-548e4925d6f7",
				Name = "Rotary Club of Edenbridge and Westerham",
				LookupId = "8-10250876",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85ffa178-1259-4c0d-ae76-c6a1fb56d694",
				Name = "Rotary Club of Westminster West",
				LookupId = "8-10250881",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fdfbcc8c-4b59-4460-b4bc-55e96e08887b",
				Name = "Inner Wheel Club of Chelsea & Westminster",
				LookupId = "8-10250890",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "80493690-d12c-4ecb-826d-e193d0627f98",
				Name = "Rotary Club of Brookmans Park",
				LookupId = "8-10250898",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2b0cc2f4-399d-4d96-8c79-a6da4b1e08bb",
				Name = "Rotary Club of Kingsbridge Estuary",
				LookupId = "8-10250900",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "817cf1d9-fa5c-4dd4-8070-632428a2e5f9",
				Name = "Rotary Club of Lewes Castle",
				LookupId = "8-10250901",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "32136bef-4ef1-4482-bd8d-3b23eca328a2",
				Name = "Rotary Club of Wallasey",
				LookupId = "8-10250910",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5a21bed7-5e4b-475f-9c3b-da5997b58808",
				Name = "Rotary Club of Royal Wootton Bassett & District",
				LookupId = "8-10250911",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3b73a663-f45f-4c78-9f41-dd1eeae61292",
				Name = "Rotary Club of Oban",
				LookupId = "8-10250913",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "00f256a4-321e-43bf-ba80-d8a2f4e7784a",
				Name = "Rotary Club of Doncaster",
				LookupId = "8-10250915",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8a7b0609-f226-4e09-9dfc-ba63ffcfec2a",
				Name = "Inner Wheel Club of Seaford",
				LookupId = "8-10250917",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "557b2bc9-0a65-4497-a451-fc9bc5393714",
				Name = "Rotary Club of Settle",
				LookupId = "8-10250918",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea509bd9-5bfc-4bc0-b68b-b2dbd45e3a27",
				Name = "Inner Wheel Club of Thornton-Cleveleys",
				LookupId = "8-10250921",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "567db46d-e424-4b5d-84d9-e290ce21cd7e",
				Name = "Inner Wheel Club of Thame",
				LookupId = "8-10250931",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bc52055e-48b6-4bc2-821c-b35836d8b0f4",
				Name = "Rotary Club of Shrewsbury",
				LookupId = "8-10250960",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c57e8acf-cce2-4ea2-88c7-c5731e227536",
				Name = "Rotary Club of The Deepings",
				LookupId = "8-10250978",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "383d1056-869d-4e2d-a691-9e31dbe6d31b",
				Name = "Rotaract Club of Wallingford",
				LookupId = "8-10250997",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3b2d2c4e-f936-4369-8a92-6e99cb2658e0",
				Name = "Inner Wheel Club of Leighton Buzzard",
				LookupId = "8-10251034",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0cec2be9-9c98-4855-ab47-ed103385b919",
				Name = "Rotary Club of St. Helens",
				LookupId = "8-10251123",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d4049880-d8a5-42de-bd9a-e688ecb0dda0",
				Name = "Rotary Club of Whickham",
				LookupId = "8-10251160",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "db02452a-a6fd-428c-bb82-6d8945727933",
				Name = "Inner Wheel District 10",
				LookupId = "8-10251421",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4b095e54-0670-41bf-8c8b-73a98921e7fd",
				Name = "Rotary Club of Paignton",
				LookupId = "8-10251436",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "653b4a3e-6d9a-4b83-a646-ace60d096c98",
				Name = "Rotaract Club of Camberley",
				LookupId = "8-10251525",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2f777c99-b90e-4d0d-989f-7cb072fb1457",
				Name = "Inner Wheel Club of Blackburn",
				LookupId = "8-10251529",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0919f6dc-0ed5-4c7e-b583-0e37cee6b1b2",
				Name = "Rotary Club of Chard",
				LookupId = "8-10251531",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "76d0653f-ac16-4a55-bef5-35d2636207dc",
				Name = "Rotary Club of Lymington",
				LookupId = "8-10251534",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "442808bc-eb8b-406e-a650-12a37a8f4ced",
				Name = "Rotary Club of Crickhowell",
				LookupId = "8-10251535",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5c236a3a-9d5d-4ff0-a3de-60518e3746db",
				Name = "Rotary Club of Penicuik",
				LookupId = "8-10251536",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3249d5e-a04a-4f71-ae3f-ded77563d6c6",
				Name = "Rotary Club Of Ashburton & Buckfastleigh",
				LookupId = "8-10251543",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f6e00951-c837-4256-92db-8f4620d7a20c",
				Name = "Rotary Club of Cleethorpes",
				LookupId = "8-10251548",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1010b60d-61d9-4c11-90ae-6471dd2c09bd",
				Name = "Inner Wheel Club of Dunstable",
				LookupId = "8-10251550",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "01f88ff4-0848-4edd-b191-7751bf6efab4",
				Name = "Rotary Club of Eastleigh",
				LookupId = "8-10251551",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f21e2051-4621-4835-97ca-2208d5ddd7e9",
				Name = "Rotary Club of Falmouth",
				LookupId = "8-10251552",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "89c0efd8-387a-4098-8484-08a78e6dda29",
				Name = "Rotary Club of Sidcup",
				LookupId = "8-10251562",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7ac79105-e467-4312-a83c-81533fbba2e7",
				Name = "Rotary Club of Alton",
				LookupId = "8-10251563",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e6d19ed3-1283-4ca6-a6f4-276285aa19ff",
				Name = "Rotary Club of Dumfries Devorgilla",
				LookupId = "8-10251564",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d0fb9fd7-2d34-4c00-acf4-6169ea7b1992",
				Name = "Rotary Club of Coalville",
				LookupId = "8-10251567",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "42e3fef5-4f04-4ac5-852d-927fbf31ec41",
				Name = "Inner Wheel Club of Newark",
				LookupId = "8-10251658",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eb2d1e93-0c6c-48b1-8311-bf482a00172f",
				Name = "Rotary Club of Helensburgh",
				LookupId = "8-10252046",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "290b10d2-a8bd-4737-af11-038beb95dfdf",
				Name = "Rotary Club of Loughborough",
				LookupId = "8-10252048",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e5c381b4-4153-439b-a138-b5c1c02389ee",
				Name = "Rotary Club of Malling",
				LookupId = "8-10252049",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4929e58a-247f-4cbc-bc43-0d5669908064",
				Name = "Rotary Club of Basingstoke Deane",
				LookupId = "8-10252051",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f02de341-15b2-45dd-ac8e-1dfb82a62dc8",
				Name = "Rotary Club of Dublin Central",
				LookupId = "8-10252058",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f658df0a-defc-4b4e-9055-f7932eb81442",
				Name = "Inner Wheel Club of Lancaster",
				LookupId = "8-10252060",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8874fdd1-de57-4afa-8624-106907d042ed",
				Name = "Rotary Club of Abergele",
				LookupId = "8-10252063",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "03940c2d-101f-4096-9bac-b07981a70ce3",
				Name = "Rotary Club of St. Ives, Cambridgeshire",
				LookupId = "8-10252066",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "49553da3-33f4-47e2-9727-b15d23d5d0a5",
				Name = "Rotary Club of Aireborough",
				LookupId = "8-10252068",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e75b9c59-9510-41d5-a084-8cf65fe7ceca",
				Name = "Inner Wheel Club of Croydon",
				LookupId = "8-10252070",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9430537d-e5c9-4d60-9f10-f3a8c197dd63",
				Name = "Rotary Club of St. Woolos Newport",
				LookupId = "8-10252071",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "33dcc2c3-225f-4d24-bf25-6c30d714360a",
				Name = "Rotary Club of Athlone",
				LookupId = "8-10252072",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f97738e2-4e92-4577-9c77-a77d808e4cc4",
				Name = "Inner Wheel Club of Leicester",
				LookupId = "8-10252074",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "63702245-7216-4979-990d-9b88faa69e3c",
				Name = "Rotary Club of Clydebank",
				LookupId = "8-10252075",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "47576fa2-e7d2-44a1-8b00-e4e029a90dde",
				Name = "Rotary Club of Andover",
				LookupId = "8-10252077",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "06f73052-8c01-455e-a2b5-0d132b720574",
				Name = "Rotary Club of Southend-on-Sea",
				LookupId = "8-10252078",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "45b70606-8471-4b98-8f48-7bfcc2fc928e",
				Name = "Inner Wheel Club of Tamworth Anker",
				LookupId = "8-10252085",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e1896525-79f7-43dc-88bb-246078582b2c",
				Name = "Inner Wheel Club of Carnforth",
				LookupId = "8-10252097",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b1695e73-25ab-47a3-a65f-266da662d7c2",
				Name = "Inner Wheel Club of Parkstone & Poole District",
				LookupId = "8-10252098",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e77eb645-19f1-470e-a3d9-b469ab030416",
				Name = "Inner Wheel Club of Abbeydale",
				LookupId = "8-10252105",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0cbb1d2f-6d70-4ad7-a9e8-005dbab2137f",
				Name = "Rotary Club of Aylesbury Hundreds",
				LookupId = "8-10252211",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a1e889fd-a458-4904-af47-d0effe7fc1ca",
				Name = "Rotary Club of Thrapston & Raunds",
				LookupId = "8-10252619",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1f25c99a-895e-4d9b-a508-128b633281fb",
				Name = "Rotary Club of Sale",
				LookupId = "8-10252621",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "230866f4-a409-41cf-80ec-0837e83aedde",
				Name = "Rotary Club of Basingstoke Loddon",
				LookupId = "8-10252622",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "20ae1ba0-9d1e-4c3f-94a7-d5d3ae7bbeb9",
				Name = "Rotary Club of Pall Mall",
				LookupId = "8-10252627",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c32ce419-71a3-406a-b9c1-1884c20c9636",
				Name = "Rotary Club of Enfield Chase",
				LookupId = "8-10252639",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c109a393-a82b-4fdd-b002-80b721531bc4",
				Name = "Rotary Club of Chichester",
				LookupId = "8-10252641",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3ae6f68a-8458-4e53-8c7c-27ccd2a7131e",
				Name = "Rotary Club of Elstree & Boreham Wood",
				LookupId = "8-10252648",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ebe9f481-d037-4ca9-bb50-7361da5cdcb4",
				Name = "Rotary Club of Ewell",
				LookupId = "8-10252649",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4f9819f0-11ca-487c-a0da-fab7eadc1243",
				Name = "Rotary Club of Kelvin (Glasgow)",
				LookupId = "8-10252651",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eaf423f1-6a66-4d0f-a0b2-a9f440bef592",
				Name = "Rotary Club of Saltburn-by-the-Sea",
				LookupId = "8-10252652",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "22823b69-ed5f-4fbf-a9d6-57de97b21d4a",
				Name = "Rotary E-Club of District 1070",
				LookupId = "8-10252663",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2202bc94-7f84-4d0b-9d2f-65c47db2ce9b",
				Name = "Interact Club of Bulmershe Rotary",
				LookupId = "8-10253113",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "20b22d8b-d47f-4953-acd9-07b5fd480760",
				Name = "Inner Wheel Club of Hawarden & District",
				LookupId = "8-10253300",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1cd93c1a-74e7-4366-915c-d1821b9663ea",
				Name = "Rotary Club of Romsey",
				LookupId = "8-10253307",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0f749734-c38b-45a6-af01-cf94cdd51592",
				Name = "Rotary Club of Thorpe Bay",
				LookupId = "8-10253322",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b6df78ad-458d-4d29-9604-4c2f4ee5a205",
				Name = "Rotaract Club of Thurles",
				LookupId = "8-10253932",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "50335c48-72c9-48c6-af9b-ff0277344a67",
				Name = "Rotary Club of Salisbury",
				LookupId = "8-10254220",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ada7acba-1c44-4979-9c35-448cc24abd84",
				Name = "Rotary Club of Salcombe",
				LookupId = "8-10254236",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bb9ea0e6-2b26-470d-8c69-50c5280264fa",
				Name = "Rotary Club of Westminster International",
				LookupId = "8-10254284",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "90fc1a9a-7fed-4029-95c5-28e13c0d1efc",
				Name = "Bosham Bridge Monday Evening",
				LookupId = "8-10254458",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "58dcf3c9-b637-4792-bab1-fec21cd6bcd8",
				Name = "Rotary Club of Stornoway",
				LookupId = "8-10254936",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9bb374a4-eec0-4819-bc05-e4c0b288fb1e",
				Name = "Inner Wheel Club Of North Wirral",
				LookupId = "8-10255089",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "81b2c8b2-523e-4bdd-a428-881241b30af7",
				Name = "Inner Wheel Club of Wollaton Park",
				LookupId = "8-10255717",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "31d9ecb6-0b0c-4d54-beb9-0e3619676ea4",
				Name = "Rotary Club of Winsford & Middlewich",
				LookupId = "8-10255750",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6dad00cf-bf79-4b12-aa1d-00ee5188c21f",
				Name = "Rotary Club of Etruria",
				LookupId = "8-10255825",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "399ae181-80b6-42c0-aede-79f77164add9",
				Name = "Rotary Club of Bedford De Parys",
				LookupId = "8-10255830",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fc2f8b59-dd1c-4ad6-993e-7ee1eb5812e3",
				Name = "Rotary Club of Huddersfield Pennine",
				LookupId = "8-10255832",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9fdd136a-6b6e-4798-b800-bbbf4ac0c0d1",
				Name = "Rotary Club of Lancaster",
				LookupId = "8-10255833",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "19dc8e3e-f7a5-49f7-96e4-3dff1d07b1fa",
				Name = "Rotary Club of Chislehurst",
				LookupId = "8-10255842",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ae5f318a-4caa-42aa-8d74-2add9573ced8",
				Name = "Rotary Club of Crewe",
				LookupId = "8-10255844",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "78c4eeb0-0e4b-4e76-a9f6-cebab95790a2",
				Name = "Interact Club St Edmunds School Canterbury",
				LookupId = "8-10255866",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6222f29c-25f4-4059-bdaf-d40901e695b3",
				Name = "Rotary Club of Ripley",
				LookupId = "8-10255898",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "71064c7f-f8fd-4e8d-a9e6-9a59c337ef60",
				Name = "Inner Wheel Club of Bedford",
				LookupId = "8-10256088",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f0bbf6ae-30e7-46bb-97ce-927dbe52e4a5",
				Name = "Rotary Club of Darwen",
				LookupId = "8-10256237",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "afe7d278-17f4-4195-a65b-bc46d701b9a6",
				Name = "Rotary Club of Padstow",
				LookupId = "8-10256240",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b17dd5ec-1a72-4732-9ca5-2feb1b44efbf",
				Name = "Rotary Club of Wadebridge",
				LookupId = "8-10256241",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6d7105a4-ad81-424a-bdc0-c194b6e6b768",
				Name = "Rotary Club of Warwick Avon",
				LookupId = "8-10256242",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "32dabd95-06b5-462b-b2fb-2bcc2961da07",
				Name = "Rotary Club of Workington",
				LookupId = "8-10256243",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7040d484-6c6c-4dfc-a1bb-f17d5e0f8c5d",
				Name = "Rotary Club of North Cotswolds",
				LookupId = "8-10256246",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "335e426a-b6c6-432a-bbfa-99b48be9f00b",
				Name = "Inner Wheel Club of Rushmoor",
				LookupId = "8-10256247",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4af40177-ae23-48cb-9700-acc59af1a18a",
				Name = "Rotary Club of Thornhill & District",
				LookupId = "8-10256249",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "39dfc149-46d1-4355-9dd0-733959f4cca4",
				Name = "Inner Wheel Club of Canterbury",
				LookupId = "8-10256250",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6a758e7c-1bcd-4b70-bc65-3d58e558a8de",
				Name = "Inner Wheel Club of Church Stretton",
				LookupId = "8-10256254",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fd87a781-43b3-4857-9b5e-8dbbb307d981",
				Name = "Inner Wheel Club of Rochdale",
				LookupId = "8-10256266",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c687d8cd-8042-4aa6-a3e0-b4caefa1a5cf",
				Name = "Inner Wheel Club of Bailgate (Lincoln)",
				LookupId = "8-10256274",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2f9e2747-084a-4baa-a82e-0648dffe7199",
				Name = "Rotary Club of Wem & District",
				LookupId = "8-10256282",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "914dd14d-1bdc-45b6-87d1-690838367c71",
				Name = "Rotary Club of Saddleworth, W. Yorks.",
				LookupId = "8-10256283",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e806bbff-0b12-495f-8e14-67ad22402c16",
				Name = "Rotary Club of Burntisland & Kinghorn",
				LookupId = "8-10256358",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bdd2aca5-c930-44d2-9067-192e89bb8180",
				Name = "Rotary Club of Kirkintilloch",
				LookupId = "8-10256361",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6389ba45-df3c-45b2-9081-dbc7c542acbf",
				Name = "Rotary Club of Lewes Barbican",
				LookupId = "8-10256362",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "92f229c8-3fb5-408b-ba7d-0ee388d5a10e",
				Name = "Inner Wheel Club of Newquay",
				LookupId = "8-10256364",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8a2275e6-ee94-4f17-aa6c-9f8998bd08a2",
				Name = "Rotary Club of Easthampstead",
				LookupId = "8-10256365",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b6323b48-39e3-4a23-b152-41515325dce2",
				Name = "Rotary Club of Hetton-Le-Hole",
				LookupId = "8-10256373",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f35d0ea4-8ea8-4170-8096-16c5cca37d53",
				Name = "Rotary Club of Diss & District",
				LookupId = "8-10256382",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b8ffae06-c6e9-4704-b245-57b8cb6ec653",
				Name = "Rotary Club of West Derby-Liverpool",
				LookupId = "8-10256384",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9c3b86e1-7f57-4012-9448-38e8711ea7c8",
				Name = "Rotary Club of Rochester",
				LookupId = "8-10257164",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3a456544-88bd-40bb-9921-803e0f4359fa",
				Name = "Rotary Club of Clacton-on-Sea",
				LookupId = "8-10257166",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "08f52352-1fa7-412a-b48c-5ee8d9c77820",
				Name = "Rotary Club of Orpington Crofton",
				LookupId = "8-10257167",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c19f734f-1341-421f-8020-b12e80015dc4",
				Name = "Inner Wheel Club of Penkridge",
				LookupId = "8-10257177",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "08483643-f5d6-4440-b8a2-63412d788d96",
				Name = "Rotary Club of Nottingham",
				LookupId = "8-10257179",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9a740bda-8a5b-4350-aa89-5aec7891002b",
				Name = "Rotary Club of Rushden",
				LookupId = "8-10257193",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a5b9a965-8541-4a47-8484-223ffce1ae6d",
				Name = "Inner Wheel Club of Neston",
				LookupId = "8-10257196",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cd85f842-ba05-4ab7-b8c8-d3d80558c9ef",
				Name = "Interact Club of Cumnock Academy",
				LookupId = "8-10258420",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6c03fc84-2fe8-47a7-80a9-e0ec200b0841",
				Name = "Rotary Club of Tralee",
				LookupId = "8-10258969",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4d4bb79d-b580-4112-8b6a-6f6b192d2313",
				Name = "Rotary Club of Blyth",
				LookupId = "8-10258974",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dfb38a5f-a9ac-4049-a785-47060d8f0754",
				Name = "Rotary Club of Blackpool Sunrise",
				LookupId = "8-10258975",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bb2951d5-7068-4b45-b56a-9f998851f03b",
				Name = "Rotary Club of Henley-On-Thames",
				LookupId = "8-10258976",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a0b9cee4-135f-44b0-94c4-677f91bec03b",
				Name = "Rotary Club of Ivybridge",
				LookupId = "8-10258977",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ac61ca45-8526-44a0-ba40-bb62f3af8f9a",
				Name = "Rotary Club of Ludlow",
				LookupId = "8-10258978",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "84b0bacf-176a-473f-a0a8-e01ed7333885",
				Name = "Rotary Club of Kettering",
				LookupId = "8-10258979",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "30cd5f73-8cf4-46bc-872f-025fe0966846",
				Name = "Rotary Club of Hornchurch and Upminster",
				LookupId = "8-10258985",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7dbd3a6a-1d1c-4b76-8204-0b17c9864456",
				Name = "Rotary Club of City of Liverpool",
				LookupId = "8-10258986",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "78487a50-5648-4b46-b4ac-b3a99f73a301",
				Name = "Rotary Club of Trent Bridge",
				LookupId = "8-10258993",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d757ba2c-bfcf-40ac-84af-b404b62ed297",
				Name = "Rotary Club of Seaford Martello",
				LookupId = "8-10258994",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4f36b75d-ebad-47cb-b325-f4bcd18e9ed4",
				Name = "Rotary Club of Aberdeen Bon Accord",
				LookupId = "8-10258995",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e81883dd-d23a-45a1-8f75-d2e6e26cc58d",
				Name = "Rotary Club of Cheltenham Cleeve Vale",
				LookupId = "8-10258996",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a6f2c7ef-ac8d-4bd4-aa02-237c51cda426",
				Name = "Inner Wheel Club of Uttoxeter",
				LookupId = "8-10258998",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "14ea65fd-d0f0-4b4a-8e84-812f3be9b853",
				Name = "Rotary Club of Coventry",
				LookupId = "8-10258999",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f58aacd6-f3d7-4275-b631-70697d25254b",
				Name = "Rotary Club of Hedge End Breakfast",
				LookupId = "8-10259000",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "50d89a83-f54f-416f-910e-710a245569ff",
				Name = "Inner Wheel Club of Wigston",
				LookupId = "8-10259013",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7fd141d6-5bd2-42b0-aa17-878b8e52bbdc",
				Name = "Inner Wheel Club of Ayr",
				LookupId = "8-10259593",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1c508604-3775-423e-a9ff-2cd630beaa6c",
				Name = "Rotary Club of Crewe & Nantwich Weaver",
				LookupId = "8-10259920",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a00e1bb6-8e66-4935-be3a-5c559947075d",
				Name = "Rotary Club of Chatham",
				LookupId = "8-10259924",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3b29fe4-b2d2-4332-b227-f4756d513cc2",
				Name = "Inner Wheel Club of Cambridge",
				LookupId = "8-10259938",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3e1a79e3-037d-45fc-bb4e-ead822d45e04",
				Name = "Rotary Club of Shetland",
				LookupId = "8-10259942",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0cf24239-a379-440c-88a4-2e543c271cc9",
				Name = "Inner Wheel Club of Herford",
				LookupId = "8-10260414",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5b60a81a-d589-4ba7-a1a1-bd42f491c891",
				Name = "Rotary Club of Brentwood A Becket",
				LookupId = "8-10260518",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "197a9c8d-03cb-4ce2-91a1-15a31939aacb",
				Name = "Rotary Club of Lowestoft",
				LookupId = "8-10260520",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "43735fad-4148-4393-97ca-b0f44782d29e",
				Name = "Rotary Club of Hunterston",
				LookupId = "8-10260526",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea30fd93-c200-45d3-88fa-3826ae71cfeb",
				Name = "Rotaract Club of Previous Members of Edgbaston",
				LookupId = "8-10260530",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3ac7ae95-89fe-4d15-be96-43643f1e1d79",
				Name = "Rotary Club of Brighton",
				LookupId = "8-10260540",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "71359dca-3cbb-4d0f-8901-47084c256203",
				Name = "Rotary Club of Brighouse",
				LookupId = "8-10260543",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6ed180a9-2ef6-449b-a8eb-e72b30448475",
				Name = "Rotary Club of Benfleet",
				LookupId = "8-10260544",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8b5e1d1b-9bb9-4b79-81ca-1911071e5a4d",
				Name = "Rotary Club of Chesterfield",
				LookupId = "8-10260566",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "81626b8b-1b80-478e-b659-51db4bc6a709",
				Name = "Interact Club of Frome Community College",
				LookupId = "8-10260591",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0e958c60-1656-4d6e-8336-65472df9fc38",
				Name = "Rotary Club of Wroxham Bure Valley",
				LookupId = "8-10260822",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2f1464d2-0f49-492a-8691-497c03c1195f",
				Name = "Rotary Club of Ventnor",
				LookupId = "8-10262579",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c8b66e89-5f5e-4a4d-af9c-f362198ed5a0",
				Name = "Inner Wheel Club of Lancaster Loyne",
				LookupId = "8-10262584",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "25855c80-04d0-4927-be9e-a113a66847b3",
				Name = "Inner Wheel Club of Plymouth",
				LookupId = "8-10262594",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f20727fe-7993-4433-bd3a-c37c35c7df5c",
				Name = "Rotary Club of Wimborne",
				LookupId = "8-10262597",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5344aa24-14ab-4c94-a3ef-2c5a167c7a3e",
				Name = "Rotary Club of Prescot",
				LookupId = "8-10263883",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1953cdef-e909-4c36-a345-5e28c4bf1dae",
				Name = "Inner Wheel Club of Carshalton",
				LookupId = "8-10263913",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "88983746-1092-4628-9a3e-c2adc7e1b50a",
				Name = "Inner Wheel Club of Coleshill",
				LookupId = "8-10263928",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8a00213d-c364-4fe9-8c34-b8e68263c2e5",
				Name = "Upottery Village",
				LookupId = "8-10264093",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea1c0ffa-c861-4259-a1e6-fd00013a426f",
				Name = "Rotary Club of Trowbridge Wessex Mead",
				LookupId = "8-10264193",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dd9118ff-0ba8-49a6-b31d-f65bfc15217f",
				Name = "Rotary Club of West Bromwich",
				LookupId = "8-10264194",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c49a755e-8b31-4fbc-b1ad-2dff882b4c02",
				Name = "Rotary Club of Kirkham & Rural Fylde",
				LookupId = "8-10264208",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "57702f4e-da9f-4215-9da6-99387691b704",
				Name = "Rotary Club of Willaston & South Wirral",
				LookupId = "8-10264210",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7aaf561e-6295-4ad1-8b00-f890a1ac4a7a",
				Name = "Rotary Club of Aberaeron A'R Cylch",
				LookupId = "8-10264226",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b0173354-a398-43a6-898e-f543bcf9b638",
				Name = "Rotary Club of Audley",
				LookupId = "8-10264264",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "40c7520f-eea7-47ad-bd31-58f42a92e1d8",
				Name = "Inner Wheel Club of Haverfordwest",
				LookupId = "8-10264267",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "97313118-0025-49cf-9f08-0a3895c176ac",
				Name = "Rotary Club of Lancaster Loyne",
				LookupId = "8-10264269",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "235c46b0-3248-437b-b429-52ae2c67c595",
				Name = "Rotary Club of Leyland",
				LookupId = "8-10264270",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "676394cd-9921-4da3-9460-62ec9383d5c4",
				Name = "Rotary Club of Maidenhead Bridge",
				LookupId = "8-10264288",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d889d6cd-91c0-4ddd-97cd-d9f62fd24f96",
				Name = "Rotary Club of Cirencester",
				LookupId = "8-10264289",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a3f01a23-9f14-479d-9c46-38d64b4a5f3c",
				Name = "Rotary Club of Dursley",
				LookupId = "8-10264290",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bc54206c-998a-4644-85ab-b7f8da454c25",
				Name = "Rotary Club of Shipston-on-Stour",
				LookupId = "8-10264302",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3f4e985e-564b-46bd-b5a0-5a06d3c87408",
				Name = "Rotary Club Of Chestfield",
				LookupId = "8-10264307",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a47072f4-3745-4070-954c-82c2fc326a1e",
				Name = "Rotary Club of Banchory-Ternan",
				LookupId = "8-10264311",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "60b204a6-5ae0-403a-8869-efeffd1f2042",
				Name = "Inner Wheel Club of Llangefni",
				LookupId = "8-10264312",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1f2a28c7-5592-46d3-98f9-27097725ffc0",
				Name = "Inner Wheel Club of St Ives, Cambridgeshire",
				LookupId = "8-10264358",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "33630044-3651-43a0-ad63-ae47b7f91a07",
				Name = "Interact Club of Faringdon",
				LookupId = "8-10264677",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b8c0b422-9579-4ea1-b9af-f3dbab9a59c4",
				Name = "Rotary Club of Moseley & Sparkbrook",
				LookupId = "8-10264683",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f37f331b-d6a9-4607-8544-1d2fdc26b8ee",
				Name = "Inner Wheel Club of Lurgan",
				LookupId = "8-10264684",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0bef81a6-99e3-4687-bccd-5d28d990f546",
				Name = "Rotary Club of Bournemouth North",
				LookupId = "8-10265054",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0666a329-c339-4a93-92cb-b1ccbb885f03",
				Name = "Rotary Club of Glossop",
				LookupId = "8-10265060",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bc913cd7-428f-425b-812a-67c2074418d8",
				Name = "Rotary Club of St. Neots",
				LookupId = "8-10265062",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "484a6dd1-0096-47bf-8cff-c056c883974b",
				Name = "Rotary Club of Dalkeith",
				LookupId = "8-10265063",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d9165228-c796-4ca3-9f4f-59781d6ffd81",
				Name = "Rotary Club of Derby Mercia",
				LookupId = "8-10265067",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aa567af5-4d4e-4313-bcf2-4e238abccc7c",
				Name = "Rotary Club of Bury St. Edmunds",
				LookupId = "8-10265073",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f2380a1f-0186-4740-9df8-326e528c2869",
				Name = "Rotary Club of Dunfermline",
				LookupId = "8-10265077",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5a31cb09-3dea-40d1-99a0-53388554ba1f",
				Name = "Inner Wheel Club of Ellon",
				LookupId = "8-10265168",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8549e462-6f8a-4064-9f9f-a3a5733c9783",
				Name = "Inner Wheel Club of Alton",
				LookupId = "8-10265169",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "36694382-e7fa-48ca-a8bf-b5f5bb754141",
				Name = "Rotary Club of Rye & Winchelsea",
				LookupId = "8-10265761",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6a1d2a55-e7d2-4aec-928d-f77d277edd00",
				Name = "Rotary Club of Somer Valley",
				LookupId = "8-10265763",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fe09eab7-e2f3-447c-be69-33b197241685",
				Name = "Rotary Club of Tettenhall",
				LookupId = "8-10265776",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b73a95fc-ab4d-48d8-8a09-7e9418697337",
				Name = "Inner Wheel Club of Birkenhead",
				LookupId = "8-10265965",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea9d0ff9-e19e-435a-aa63-542a5bad5d0d",
				Name = "Rotary Club of Teesside West",
				LookupId = "8-10265966",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "32d66586-0a47-4013-9b7b-cfe457406f58",
				Name = "Rotary Club of Tonbridge",
				LookupId = "8-10265967",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fdcced67-200e-462a-a257-6d8a54176ea3",
				Name = "Rotary District 1120",
				LookupId = "8-10265974",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4d8c92b6-780e-4182-ba83-5e3c87a36819",
				Name = "Inner Wheel Club of Bangor (NI)",
				LookupId = "8-10265981",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e469b1b9-6fa8-42b9-b726-bbf8280aa3f9",
				Name = "Rotary Club of Mallow",
				LookupId = "8-10268914",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6b312dcd-75ac-4085-bc4c-b8b67358b4f5",
				Name = "Rotary Club of Kensington & Chelsea",
				LookupId = "8-10269416",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9c390483-e115-445b-bddd-7341ef597e9a",
				Name = "Interact Club of Oldershaw Academy",
				LookupId = "8-10270509",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "045aba1e-6ad4-4287-a713-614eb08faff7",
				Name = "Rotary Club of Watton",
				LookupId = "8-10270794",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "349c4b36-e7af-49c6-9f64-430b0027556f",
				Name = "Rotary Club of Bourne End & Cookham",
				LookupId = "8-10273343",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "773c6347-11b5-4413-bc3c-9d95b92b4dbc",
				Name = "Rotary Club of Canvey Island",
				LookupId = "8-10273344",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4e576e81-507e-41bb-9843-a67bd9d3673d",
				Name = "Inner Wheel Club of Kirkcudbright",
				LookupId = "8-10273361",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a32b1c2f-c5b9-4041-a1cc-c2bc60083560",
				Name = "Rotary Club of North Fylde",
				LookupId = "8-10273372",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "80b9227d-cead-4b2f-88e9-4a41a84485c1",
				Name = "Rotary Club of Redhill Redstone",
				LookupId = "8-10273373",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "67726cad-a4d1-410a-880c-0a1dd93311ea",
				Name = "Inner Wheel Club of Torquay",
				LookupId = "8-10273377",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "71d26e91-ac15-4406-90aa-9a313496a8aa",
				Name = "Rotary Club of Leicester De Montfort",
				LookupId = "8-10273378",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9b5155ad-4088-4a9b-95f1-1f7f6cb9b093",
				Name = "Rotary Club of Aylsham",
				LookupId = "8-10273380",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c7934ab0-7f70-49b2-afa9-245629009cc2",
				Name = "Inner Wheel Club of Berkhamsted Bulbourne",
				LookupId = "8-10273382",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d6914658-c856-4bf2-b191-4d32418c73d0",
				Name = "Rotary Club of Cowbridge",
				LookupId = "8-10273385",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d5495854-3f8d-4440-976c-623f37d739f4",
				Name = "Interact Club of Blackwood Comprehensive School",
				LookupId = "8-10273510",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e57604a9-b99b-4c7d-8d89-845800409170",
				Name = "Rotary Club of Ipswich Orwell",
				LookupId = "8-10275235",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3414cee-50e8-4cf6-8263-d29c3987a479",
				Name = "Rotary Club of Musselburgh",
				LookupId = "8-10275236",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "75c6f43d-0991-48e0-b285-adbc3f9a634a",
				Name = "Rotary Club of Newark Castle",
				LookupId = "8-10275237",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "68faf6de-c85e-4de1-8834-7ec68a0522b0",
				Name = "Inner Wheel Club of Kettering and Members",
				LookupId = "8-10275238",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e8c18b5a-8a0e-462f-ab5d-f9302710be86",
				Name = "Rotary Club of Epworth & Isle Of Axholme",
				LookupId = "8-10275239",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0bc52f18-df7f-41f6-bc78-5cbb56d0ebe7",
				Name = "Rotary Club of Ormskirk Clocktower",
				LookupId = "8-10275247",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0b650d35-d891-486b-afcd-dcc855c80e95",
				Name = "Rotary Club of Newport, Shropshire",
				LookupId = "8-10275997",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ab5b2242-dc87-4662-a183-9f8a37fb80c3",
				Name = "Rotary Club of Fakenham & District",
				LookupId = "8-10276004",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b1c32b30-e130-49ba-b461-8670f7121e42",
				Name = "Inner Wheel Club of Morpeth",
				LookupId = "8-10276005",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e2e13f83-78e4-45fd-90f2-285916d5cee4",
				Name = "Rotary Club of Dukinfield & Stalybridge",
				LookupId = "8-10276014",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e1906019-1f5e-4073-a1de-dff003d10acc",
				Name = "Rotary Club of Gravesend & Meopham",
				LookupId = "8-10276015",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "feaedb31-91f1-4d76-8dbb-e4ab76287958",
				Name = "Rotary Club of Arbroath",
				LookupId = "8-10276557",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "be7b19d7-aa27-43ac-a990-65080a78a03c",
				Name = "Rotary Club of Braintree Rivers",
				LookupId = "8-10276558",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b5c36d1a-30b3-4b3f-80fb-47824e46612e",
				Name = "Rotary Club of Felixstowe",
				LookupId = "8-10276560",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "57cac9f4-58ac-4b24-9943-ccc353065f40",
				Name = "Rotary Club of Croydon Whitgift",
				LookupId = "8-10276569",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c533fdbe-7701-4ef7-8743-e2893c85529e",
				Name = "Rotary Club of Abertillery & Blaina",
				LookupId = "8-10276570",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8d39292f-2edb-406e-981e-1b23564cf6a4",
				Name = "Inner Wheel Club of Knutsford",
				LookupId = "8-10276572",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cf577096-de74-487a-8a4b-21b6eec0c789",
				Name = "Rotary Club of Newport Pagnell",
				LookupId = "8-10276575",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f8c1e80e-5432-46d3-a4f6-0c3ed82e277d",
				Name = "Rotary Club of Wolverhampton St. Georges",
				LookupId = "8-10276579",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "84bdbeb7-0662-418d-98f7-130c2e519f31",
				Name = "Rotary Club of Etwall & Hilton",
				LookupId = "8-10276580",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "69ace961-899b-496b-bcfd-c888449e3a6b",
				Name = "Rotary Club of Tormohun (Torquay)",
				LookupId = "8-10276581",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "590c55ba-1f97-4302-8cdd-43f4cd6a5ed9",
				Name = "Rotary Club of Shaftesbury",
				LookupId = "8-10276600",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2686affb-b44b-414e-a0a2-5a5f56a3dcd3",
				Name = "Rotary Club of Shepperton Aurora",
				LookupId = "8-10276601",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7a18779c-c210-4085-a5d2-7c3d08acf1be",
				Name = "Rotary Club of Cumnock",
				LookupId = "8-10276687",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "19e8e33c-5a12-40cf-a502-b860c992ad20",
				Name = "Rotary Club of Bedworth",
				LookupId = "8-10276688",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9611da4a-80eb-474f-ab54-ad01f413403d",
				Name = "Rotary Club of Heswall, Wirral",
				LookupId = "8-10276690",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0690fe2d-e1e3-475c-87a8-d3f50f144ed2",
				Name = "Rotary Club of Jersey",
				LookupId = "8-10276691",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "042f945b-8849-4539-a09c-ed2448db9427",
				Name = "Rotary Club of Knowle & Dorridge",
				LookupId = "8-10276692",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2f9455da-b131-436b-8c7f-bd1acb1a8d91",
				Name = "Rotary Club of Llanishen (Cardiff)",
				LookupId = "8-10276693",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bdde7496-d8df-4994-b0cf-23b7f098c4fd",
				Name = "Rotary Club of Hemel Hempstead",
				LookupId = "8-10276694",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3c3e4c78-1b9b-48fb-9cb7-fa412a8c8260",
				Name = "Rotary Club of North Downs",
				LookupId = "8-10276696",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7451244e-d553-4d92-8061-7388861e60f9",
				Name = "Rotary Club of Kinross & District",
				LookupId = "8-10276705",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b62260fc-231a-4775-bfef-aaac8c6134d7",
				Name = "Rotary Club of Bishops Stortford",
				LookupId = "8-10276710",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c86403b1-ff64-4f35-ae65-42cc7d7b0433",
				Name = "Inner Wheel Club of Dartmouth",
				LookupId = "8-10276712",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "edf1be8f-98e2-41e3-bab7-d187ee260706",
				Name = "Rotary Club of Oadby",
				LookupId = "8-10276725",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8fe11a70-04bc-4ca3-9b87-c3a674647b6d",
				Name = "Inner Wheel Club of Harpenden",
				LookupId = "8-10276726",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "58196c9e-cb5b-4790-9780-daa93ec1138b",
				Name = "Rotary Club of Portobello",
				LookupId = "8-10276727",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9472dc88-1a6d-4dce-b96e-4ff49ed4804f",
				Name = "Rotary Club of Tenterden",
				LookupId = "8-10276729",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "24f207d7-e580-426f-bd58-aee0d0551e01",
				Name = "Rotary Club of Livingston",
				LookupId = "8-10277014",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6132967d-2bf8-48ee-a7da-94b69aa1f7de",
				Name = "Inner Wheel Club of Ballymoney",
				LookupId = "8-10277024",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c3e82d80-4190-423a-a4ea-901c51cdcf1c",
				Name = "Rotary Club of Chiswick & Brentford",
				LookupId = "8-10277026",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f58ac017-d008-40c8-b21d-83503c3d9379",
				Name = "Rotary Club of Southam 2000",
				LookupId = "8-10277028",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85a8e18e-5819-4c79-baa1-f66dfedd84c6",
				Name = "Inner Wheel Club of Tywyn",
				LookupId = "8-10277031",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c93a49ee-249c-4f96-94f6-b5ed895145a3",
				Name = "Rotary Club of Woodbridge Deben",
				LookupId = "8-10277032",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "da91f0ce-92e5-41f9-8066-7cb19b0e66e8",
				Name = "Inner Wheel Club of Bideford",
				LookupId = "8-10277033",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7213125b-b48b-4070-832e-d32fdfd8898c",
				Name = "Inner Wheel Club of Faversham",
				LookupId = "8-10277040",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f257d21c-812b-4205-bc84-c5f1e4da1c55",
				Name = "Rotary Club of Bray",
				LookupId = "8-10277043",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "39589967-8127-4e59-9685-2cc7642db4c7",
				Name = "Rotary Club of Navan",
				LookupId = "8-10277044",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "02c5b112-f033-451e-865a-2a96d05800e9",
				Name = "Rotary Club of Blaby",
				LookupId = "8-10277057",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c72e9d3e-b8e5-4bbb-a6a4-6cbb27ea2913",
				Name = "Rotary Club of Leith",
				LookupId = "8-10277058",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5928329a-7437-4890-8400-2763dfd14c70",
				Name = "Rotary Club of Long Eaton",
				LookupId = "8-10277059",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "68cada47-37c6-4764-bad9-dc9e044161be",
				Name = "Rotary Club of Harrow",
				LookupId = "8-10277060",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6d7ec561-d89b-4955-b84f-5565787ce273",
				Name = "Rotary Club of Comber",
				LookupId = "8-10277061",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c7592b55-d773-4fa9-8e87-9d6a532203f9",
				Name = "Rotary Club of Paisley",
				LookupId = "8-10277071",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e3b69f00-bf36-4fcd-a61e-e3aaf6b7ddd1",
				Name = "Rotary Club of Seaford",
				LookupId = "8-10277072",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "35101ede-290b-4f7f-989e-61cb5f42d441",
				Name = "Rotary Club of Hyde",
				LookupId = "8-10277076",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d4f63ab0-9d67-4504-9bb6-9541e543ef70",
				Name = "Rotary Club of Boston",
				LookupId = "8-10277103",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "16140842-624c-4eaf-8c0e-926c96db7a30",
				Name = "Rotary Club of Leicester",
				LookupId = "8-10277104",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "afae9357-799e-4582-befd-f7ccb280c9d7",
				Name = "Rotary Club of Marlow",
				LookupId = "8-10277105",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f3d543c8-3cf4-4c79-8f4a-a9b6cb8755ef",
				Name = "Rotaract Club of Christchurch",
				LookupId = "8-10277108",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ded6f0a2-937c-437b-b459-fcbdf42403ab",
				Name = "Rotary Club of Isle of Thanet Sunrise",
				LookupId = "8-10277110",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b2896709-9f95-4746-8f8f-d58fca9bba9a",
				Name = "Inner Wheel Club of Chichester",
				LookupId = "8-10277114",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e8c96be0-70d9-4d2b-bb95-f06df0a099da",
				Name = "Inner Wheel Club of Slough",
				LookupId = "8-10277116",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3670edf8-8c71-4145-9f7d-9773cb17342c",
				Name = "Rotary Club of Elthorne-Hillingdon",
				LookupId = "8-10277117",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "83a0b118-011e-4b65-8800-ee797367fc8a",
				Name = "Interact Club of Castle Community Coll",
				LookupId = "8-10277123",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ca27df8f-dd69-4e80-98d6-8f7737e9ffb8",
				Name = "Rotary Club of Alford & Mablethorpe",
				LookupId = "8-10277131",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "309c1787-059d-488d-ab86-85b187426836",
				Name = "Rotary Club of Stamford St Martin's",
				LookupId = "8-10277141",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e1c338bf-0c8c-409f-a321-3a4a8f08f3ad",
				Name = "Rotary Club of Thirsk",
				LookupId = "8-10277142",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d372c461-b620-42ba-bf72-a892440badc9",
				Name = "Rotary E-Club of Southern Scotland",
				LookupId = "8-10277148",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f0377d55-15bc-4930-9e2f-7bd7b794fdda",
				Name = "Rotary Club of Pembroke",
				LookupId = "8-10277201",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1bc5ae1e-52d8-4347-a073-ebbd23912d5b",
				Name = "Rotary Club of Putney",
				LookupId = "8-10277202",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "019d50cd-755f-45b1-95f7-6bf1aa90c11c",
				Name = "Interact Club of St Matthew's Academy, Saltcoats",
				LookupId = "8-10277218",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b572d09b-5ed7-48b6-962c-e84478af35d8",
				Name = "Rotary Club of Derby South",
				LookupId = "8-10277227",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1d15b9bc-0ee6-46d9-811a-9ef2168426ec",
				Name = "Rotary Club of Dorking",
				LookupId = "8-10277265",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "203c03b3-b901-424d-821b-d14555a82b2c",
				Name = "Rotary Club of Heathfield & Waldron",
				LookupId = "8-10277270",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2f8d29e0-9002-40d5-973b-1da77c687ad2",
				Name = "Rotary Club of Willenhall",
				LookupId = "8-10277272",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6b0abad9-b4c3-48af-925e-e4a9083a2a04",
				Name = "Inner Wheel Club of Bangor (N. Wales)",
				LookupId = "8-10277290",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fd51f57a-fcfd-4251-b4d4-f74e38c1f45b",
				Name = "Rotary Club of Morpeth",
				LookupId = "8-10277293",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5fa8fe7c-7112-404b-aa3d-b4622d6fcee6",
				Name = "Rotary Club of Sandwich",
				LookupId = "8-10277299",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9de9ad2c-76ca-4e0d-949c-9c8562aae07d",
				Name = "Rotary Club of Plympton",
				LookupId = "8-10277307",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "008a049a-6dea-4135-ba80-9430eb1e782b",
				Name = "Rotary Club of Saltram Plympton",
				LookupId = "8-10277308",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d7db8448-3cd1-45ec-a920-5e946b40d46b",
				Name = "Rotary Club of Sutton-in-Ashfield",
				LookupId = "8-10277309",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0ab8c932-cced-4c82-9d2e-e488d442458b",
				Name = "Rotary Club of Tiverton",
				LookupId = "8-10277310",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a8f44462-eb5d-4a25-bf34-a0b246dc7cb7",
				Name = "Rotary Club of Tranent",
				LookupId = "8-10277311",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a1207a34-a3ed-492f-b118-96edea039108",
				Name = "Rotary Club of Hereford Wye Valley",
				LookupId = "8-10277350",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5ae24a3a-9113-4a13-9c94-3495c91b0a95",
				Name = "Rotary Club of Hounslow",
				LookupId = "8-10277351",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d480bc53-c57d-4091-af11-950d0bd72fb1",
				Name = "Rotary Club of Leigh",
				LookupId = "8-10277352",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "447fc587-1c8e-42c3-8689-59854ce8e10e",
				Name = "Rotary Club of Manchester Breakfast",
				LookupId = "8-10277353",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9d4dc71c-7de8-47a7-ae48-ad33f0f4b205",
				Name = "Rotary Club of Mar Dyke Valley",
				LookupId = "8-10277357",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2552d96e-e781-4e3d-8c7e-7bd50fef8a7a",
				Name = "Rotary Club of Dudley",
				LookupId = "8-10277362",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "81792a88-46ae-40f4-95fb-291fa8f1f575",
				Name = "Rotary Club of Middlesbrough Erimus",
				LookupId = "8-10277364",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b8a0b00f-c9ca-4f6e-8886-a0b5e53f550a",
				Name = "Rotary Club of Twickenham",
				LookupId = "8-10277373",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a925cbe2-3ed0-4fe0-a79d-4225a387f7bb",
				Name = "Rotary Club of Wollaton Park",
				LookupId = "8-10277375",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "02afd97c-9b72-40a2-83cb-55d6b2a9c7cc",
				Name = "Rotary Club of Folkestone",
				LookupId = "8-10277377",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "126d2576-f766-4de9-915e-021c3d628b1d",
				Name = "Rotary Club of Pontllanfraith",
				LookupId = "8-10277396",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c4fc966c-c7b8-4686-95cf-fda76cd307fb",
				Name = "Rotary Club of Princes Risborough",
				LookupId = "8-10277397",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "73c55aec-b4c3-41bd-babe-a0ce758aab35",
				Name = "Rotary Club of Sleaford",
				LookupId = "8-10277399",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e81c04e4-47be-43f7-bf78-c0e076059b21",
				Name = "Inner Wheel Club of Brixham",
				LookupId = "8-10277403",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "791087b1-2d8e-4671-be8c-383770b75ad0",
				Name = "Rotary Club of Denbigh",
				LookupId = "8-10277426",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eee2f078-da23-43bd-b4d3-6e5bd4a38c07",
				Name = "Rotary Club of Hatfield",
				LookupId = "8-10277427",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "26b4c7eb-5a62-4311-8afb-2355e30680d7",
				Name = "Rotary Club of Aberdeen Deeside",
				LookupId = "8-10277429",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3804b0d4-e262-48f3-b45c-e9b97f54d3ba",
				Name = "Rotary Club of Swadlincote",
				LookupId = "8-10277432",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "63aad25c-aac1-4644-89ea-7983b4b64d3c",
				Name = "Interact Club of Crosby",
				LookupId = "8-10277433",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "03743a60-da99-464b-baf0-9bf6fd8598e7",
				Name = "Rotary Club of Bridgend",
				LookupId = "8-10277451",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1e55b88e-9660-4c20-8c05-871e163418e9",
				Name = "Rotary Club of South Holland",
				LookupId = "8-10277470",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e659f46c-7bfc-4a87-9bfe-a0554b245758",
				Name = "Inner Wheel Club of Bourne",
				LookupId = "8-10277473",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1dbfd66a-afa7-4b26-a81a-779becc66400",
				Name = "Inner Wheel Club of Dorking",
				LookupId = "8-10277558",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "82dbdab5-0c81-443b-9285-4e63a6952803",
				Name = "Rotaract Club of Dover",
				LookupId = "8-10277559",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d9b4bdc9-e051-439d-900c-5cdf098a7117",
				Name = "Rotary Club of Hythe",
				LookupId = "8-10277560",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b12034bb-5f81-4e8f-8f6d-58f394bda34f",
				Name = "Inner Wheel Club of Royal Forest Of Dean",
				LookupId = "8-10277567",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "49d3bbe2-d2a9-41f9-97a0-20118e223432",
				Name = "Rotary Club of Southampton",
				LookupId = "8-10277572",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b6f52c24-db75-4055-99fb-efcb20ec261e",
				Name = "Rotary Club of Brechin",
				LookupId = "8-10277609",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "04c0dbc4-8707-4b80-8eca-8e0ae08ff503",
				Name = "Inner Wheel Club of Ashton-Under-Lyne",
				LookupId = "8-10277625",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e7f74674-716c-45ca-ab82-fc72c13099d8",
				Name = "Rotary Club of Barry",
				LookupId = "8-10277626",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5b56e78b-a2fd-4d86-bf33-a7e6f10c4734",
				Name = "Rotary Club of Lutterworth Wycliffe",
				LookupId = "8-10277628",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "72e7307f-6f19-48f0-b707-fe3de6a0acf2",
				Name = "Inner Wheel Club of Stamford Burghley",
				LookupId = "8-10277732",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0342244b-2b5e-4578-8add-6aa987874a45",
				Name = "Inner Wheel Club of Bodmin",
				LookupId = "8-10277736",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "803bddf8-df0b-429d-ae51-7d481951dd98",
				Name = "Rotary Club of Broadstairs",
				LookupId = "8-10277737",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6cf9599e-047c-4251-b6ee-69a313c95940",
				Name = "Rotary Club of Farnham Weyside",
				LookupId = "8-10277738",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7e68227d-da14-4119-bf20-ccd4f94c6938",
				Name = "Rotary Club of Market Harborough",
				LookupId = "8-10277741",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9a913f05-2c11-497c-9965-2479b03a6a06",
				Name = "Inner Wheel Club of Midsomer Norton & Radstock",
				LookupId = "8-10277742",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7847d28a-257e-4962-8308-787862939728",
				Name = "Rotary Club of Evesham",
				LookupId = "8-10277745",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a12e1f4e-4567-476e-94e8-a4b45bec5868",
				Name = "Rotary Club of Croydon Jubilee",
				LookupId = "8-10277750",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b0353319-8af0-4877-8545-7bf0061ba46f",
				Name = "Rotary Club of Kendal",
				LookupId = "8-10277751",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "24b62f01-5937-4bd8-acbe-0f753e4ea4a2",
				Name = "Rotary Club of Wisbech",
				LookupId = "8-10277754",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e1fa5896-3167-4c9d-bda5-c7222cc27607",
				Name = "Rotary Club of Cheltenham North",
				LookupId = "8-10277758",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e11477c0-27bd-4a0b-aa04-fc6d078c3e72",
				Name = "Rotary Club of Bridge of Allan & Dunblane",
				LookupId = "8-10277776",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6a4d6ebd-70e5-4ea2-ba49-d0b1e1a91baf",
				Name = "Rotary Club of Frodsham & Helsby",
				LookupId = "8-10277780",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "14c2ac12-7208-4114-a2c7-f1abdd1c4549",
				Name = "Rotary Club of Portsmouth North",
				LookupId = "8-10277781",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4a7cedb8-861a-4117-8154-dbd0dbdfe8da",
				Name = "Rotary Club of Burntwood & District",
				LookupId = "8-10277796",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fa232d0a-c203-453f-8a5a-af0839c5e066",
				Name = "Rotary Club of Colne Noyna",
				LookupId = "8-10277798",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a402ac88-fe20-4b38-9a59-f1bb32f15c4d",
				Name = "Inner Wheel Club of Woodhall Spa",
				LookupId = "8-10277799",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c044ea3c-dbe1-4503-ba51-b625dd1b6a06",
				Name = "Rotary Club of Grays Thurrock",
				LookupId = "8-10277805",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7716241a-c7a7-4c8d-85c2-7fac1fb8fe32",
				Name = "Rotary Club of Langley & Iver",
				LookupId = "8-10277806",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1e2ce961-7918-4ba4-a28b-4f4ee6b01bc8",
				Name = "Rotary Club of Streatham",
				LookupId = "8-10277837",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "54aa6481-338d-4e6f-a437-01f06a2d62ac",
				Name = "Rotary Club of Havant",
				LookupId = "8-10277844",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "20a3cff4-46a3-452a-be22-ee3079f953ca",
				Name = "Rotary Club of Howe of Fife",
				LookupId = "8-10277845",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "32318a04-abd8-4fc5-9087-93116c661825",
				Name = "Rotary Club of Newton Aycliffe",
				LookupId = "8-10277847",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "33b8989d-ccab-42af-b1a9-3a840a688473",
				Name = "Rotary Club of Wendover & District",
				LookupId = "8-10277858",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e6641c18-ce7b-4e1f-9295-b1c0c48ed39b",
				Name = "Rotary Club of Solihull",
				LookupId = "8-10277863",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "21bb3539-e442-4521-ad6a-996e56f59656",
				Name = "Inner Wheel Club of Oldham",
				LookupId = "8-10277960",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "299646d4-75e7-4961-8ed2-ea76d5418280",
				Name = "Inner Wheel Club of Huntingdon",
				LookupId = "8-10277966",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "98b62911-2e40-4b5e-893d-aec138248179",
				Name = "Inner Wheel Club of Roborough",
				LookupId = "8-10277981",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "72dd1bef-8351-491b-ac1a-5810cb79cee0",
				Name = "Inner Wheel Club of Eastern Borders",
				LookupId = "8-10277995",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3dac799f-8d78-4f4f-8b2b-4a76286ba849",
				Name = "Rotary Club of Galashiels and District",
				LookupId = "8-10278002",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "86c6721f-a17b-4183-bf61-595f427affd1",
				Name = "Rotary Club of Larbert",
				LookupId = "8-10278003",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "46a326e2-2b91-4913-b088-6c91b955e3f6",
				Name = "Inner Wheel Club of Hinckley",
				LookupId = "8-10278006",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "190c77ae-1129-47f2-9647-c18a4e99498a",
				Name = "Rotary Club of Epping",
				LookupId = "8-10278014",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "315746ef-93d1-454e-9bd8-e59eb6badedc",
				Name = "Rotary Club of Canary Wharf",
				LookupId = "8-10278051",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d759f8fc-de28-4f93-9fcb-1c67f016be3e",
				Name = "Rotary Club of Lichfield",
				LookupId = "8-10278053",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a179d257-2728-467b-ba2e-be09909638d3",
				Name = "Rotary Club of Mendip",
				LookupId = "8-10278054",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6e329024-0753-46f8-8a65-c04e30d3a27e",
				Name = "Rotary Club Of Lomond",
				LookupId = "8-10278055",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "523331ed-8150-4e7d-8100-75f909532042",
				Name = "Inner Wheel Club of Luton Chiltern",
				LookupId = "8-10278060",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7a3601c4-6b2b-42c7-ac64-1374be01cb6a",
				Name = "Rotary Club of Scunthorpe",
				LookupId = "8-10278067",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c8c0d8f3-2453-4106-9c94-1845353e0e76",
				Name = "Rotary Club of Gravesend",
				LookupId = "8-10278069",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a21164ff-c0f1-4152-948d-d5847efc30c1",
				Name = "Rotary Club of Chadderton & Failsworth",
				LookupId = "8-10278070",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "22472575-3a9b-4369-aaac-4907d45ba0ec",
				Name = "Rotary Club of Eastbourne Am",
				LookupId = "8-10278071",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4755a3f5-b03d-4a65-bdf8-725c8bfb5769",
				Name = "Rotary Club of Antrim",
				LookupId = "8-10278073",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e931a81f-1d10-4144-8c6a-65d72981a2b8",
				Name = "Rotary Club Of Hereford City",
				LookupId = "8-10278078",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0a967cb0-e3b5-47ad-b5b7-d3cf2eaef897",
				Name = "Rotary Club of Montrose",
				LookupId = "8-10278080",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ed3b6083-34f5-4075-8a8e-95acbe72c9c9",
				Name = "Inner Wheel Club of Knowle & Dorridge",
				LookupId = "8-10278094",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e380b34b-768f-4aef-8a2e-2456e881296d",
				Name = "Inner Wheel Club of Newton & District",
				LookupId = "8-10278095",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b208689c-ba49-4514-b564-f387b0ef5526",
				Name = "Rotary Club of Alsager",
				LookupId = "8-10278096",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "58600458-e4e2-41b3-af5d-962721ce868c",
				Name = "Inner Wheel Club of Ammanford",
				LookupId = "8-10278118",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6c83797d-84ec-4a16-a9b2-64617761a9e1",
				Name = "Rotary Club of Croydon",
				LookupId = "8-10278123",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "42154dd3-25a6-4293-b1a9-66648c17e330",
				Name = "Rotary Club of Cambridge Rutherford",
				LookupId = "8-10278124",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "418df8b8-1f0e-4dcb-ad20-b49e16bbade6",
				Name = "Rotary Club of Knighton & District",
				LookupId = "8-10278125",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4d2d1d17-a2dd-4c37-a024-5d39e9203bb2",
				Name = "Rotary Club of Inverness Culloden",
				LookupId = "8-10278129",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a9c19386-0ab0-42e8-89ba-c02ed1cc56ee",
				Name = "Rotary Club of Pontefract",
				LookupId = "8-10278132",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a2dffb56-735f-496f-890e-baa7ab8dde27",
				Name = "Rotary Club of Allander",
				LookupId = "8-10278139",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "07d1ebe6-d784-4b2c-9492-0774e66ab1d5",
				Name = "Inner Wheel Club of Ware",
				LookupId = "8-10278140",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8cc4f4ce-42a3-4e14-a3d0-ad410c9d39c9",
				Name = "Rotary Club of Otter Valley",
				LookupId = "8-10278144",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "28a5ce7a-54bc-43d5-b6c8-fcb777456850",
				Name = "Rotary Club of Senlac",
				LookupId = "8-10278145",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "43b8b960-6be2-443c-b746-0da2e4b1822c",
				Name = "Rotary Club of Pershore",
				LookupId = "8-10278148",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "76c929a8-a67d-4dc4-a61a-2ac863877670",
				Name = "Rotary Club of Stroud",
				LookupId = "8-10278149",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "83dbc3aa-923b-49dc-902a-7c419f8c5383",
				Name = "Interact Club of Kennet School",
				LookupId = "8-10278153",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4454fa3d-75fd-4bad-bb4e-ab285a170c66",
				Name = "Rotary Club of Bognor Hotham",
				LookupId = "8-10278155",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "859490e7-76c7-413d-be3b-4ff45ca3e60b",
				Name = "Rotary Club of Basingstoke",
				LookupId = "8-10278159",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e3881523-0362-4399-ab00-25595ad14909",
				Name = "Rotary Club of Keswick",
				LookupId = "8-10278171",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dcdf91a1-e7ec-4ace-b235-345f71fac1cf",
				Name = "Interact Club of Barnard Case (Teesdale School)",
				LookupId = "8-10278181",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3173329a-1666-402c-b345-91becdc3b081",
				Name = "Inner Wheel Club of Farnborough",
				LookupId = "8-10278186",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7dfb6baa-0a75-4e5f-82ba-44067a23afb4",
				Name = "Rotary Club of Basildon Concord",
				LookupId = "8-10278188",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0862e8c6-74d8-4a95-b5f5-94d65d419f40",
				Name = "Rotary Club of Limavady",
				LookupId = "8-10278190",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0ddd53f1-17b2-4987-aa43-37f8af7fc5bc",
				Name = "Rotary Club of Barnard Castle",
				LookupId = "8-10278195",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a9a3ec34-077d-4c5d-98e6-26b40af9083a",
				Name = "Rotary Club of Kirkcaldy",
				LookupId = "8-10278196",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d45f2d70-5c29-4908-85c1-561972399b1d",
				Name = "Rotary Club of Durham",
				LookupId = "8-10278197",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3e2b0f9c-d70b-4582-a626-5559223cd8cb",
				Name = "Rotary Club of Warsop, Shirebrook & District",
				LookupId = "8-10278205",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "06a1dd91-7807-4df5-85c4-6023fdf23dd4",
				Name = "Rotary Club of Westgate & Birchington",
				LookupId = "8-10278235",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ed29b4d1-57bb-432b-97b0-ad727d9797a3",
				Name = "Rotary Club of Harrogate Brigantes",
				LookupId = "8-10278241",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "327b9232-ca69-4132-a40f-1927b46d7e64",
				Name = "Rotary Club of Oxford",
				LookupId = "8-10278250",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "782622ac-52fc-4b30-8d5b-8e5baa935b86",
				Name = "Rotary Club of Builth Wells",
				LookupId = "8-10278251",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7a69561d-a527-4104-a177-0defe0dc0ebd",
				Name = "Rotary Club of Newton Abbot",
				LookupId = "8-10278252",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b414b01e-5394-4c3b-91f8-c9fc7a136757",
				Name = "Inner Wheel Club of Newport",
				LookupId = "8-10278256",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cd7f26a4-de74-4936-8ced-d7b2a0649994",
				Name = "Rotary Club of Barrhead",
				LookupId = "8-10278259",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5cf79034-3cd7-411b-b4cc-69739a8098e8",
				Name = "Rotary Club of Hebden Bridge",
				LookupId = "8-10278261",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b706e388-45e1-436c-ab13-399bb3ac5ef9",
				Name = "Rotary Club of Boston St. Botolph",
				LookupId = "8-10278263",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d6b5726c-b07c-4234-9bf3-fdf2fe76672c",
				Name = "Rotary Club of Crewkerne",
				LookupId = "8-10278270",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "583a00f7-bb1b-4386-b7a5-dde1dc2de439",
				Name = "Rotary Club of Carlisle Castle",
				LookupId = "8-10278271",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "435a4d3e-b369-49a8-abad-d8e4b988383c",
				Name = "Rotary Club of Manningtree Stour Valley",
				LookupId = "8-10278276",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4b93c53c-6734-4aa7-8b93-21171cae6437",
				Name = "Rotary Club of Warwick",
				LookupId = "8-10278277",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "65d461d9-1fe2-43dc-9351-362e0b6dbae6",
				Name = "Rotary Club of Carrickfergus",
				LookupId = "8-10278278",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c7fd4ea6-d500-46ee-a559-eaf1d4652954",
				Name = "Rotary Club of Peebles",
				LookupId = "8-10278279",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a1823879-9df6-4676-89b4-742fe4baee10",
				Name = "Rotary Club of Barnsley (Rockley)",
				LookupId = "8-10278280",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "711c6541-53da-4fe4-b398-6355a94c1e8f",
				Name = "Rotary Club of The City of St. Asaph",
				LookupId = "8-10278282",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2114c0f1-5d7f-417e-b021-b0bfe48b98f0",
				Name = "Inner Wheel Club of Thornbury",
				LookupId = "8-10278286",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4cee3f99-c658-4f26-b5ad-04f06b576ce6",
				Name = "Inner Wheel Club of Woodhall Spa Charity",
				LookupId = "8-10278292",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "36372172-2207-4055-8faf-fec41d9d6f36",
				Name = "Rotary Club of Mersea Island",
				LookupId = "8-10278306",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1d0ff62e-3475-4764-a65f-a1bab5e5e80f",
				Name = "Rotary Club of Roding",
				LookupId = "8-10278313",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c3411649-a0ef-43b3-81f3-c01f3820a7e3",
				Name = "Inner Wheel Club of Chelmsford Mildmay",
				LookupId = "8-10278317",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eb436f4d-3cb9-4eda-9c07-1f4147104369",
				Name = "Rotary Club of St Agnes & St Piran",
				LookupId = "8-10278334",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f153f415-a589-4a2d-b2e8-f222f0fbc1a5",
				Name = "Rotary Club of Harlow Tye",
				LookupId = "8-10278337",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aab0f5ed-71ae-4fa7-850e-b873185606a9",
				Name = "Inner Wheel Club of Llandrindod Wells",
				LookupId = "8-10278346",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e7e21963-d66b-421b-abb5-edb76c7cc549",
				Name = "Rotary Club of Huddersfield",
				LookupId = "8-10278348",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4edbc80d-1b59-4284-878f-9e98ed31c806",
				Name = "Rotary Club of Southport Sunrise",
				LookupId = "8-10278352",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ce7f9bd8-6466-4370-ac52-c2a30d830cec",
				Name = "Rotary Club of Renfrew",
				LookupId = "8-10278356",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2dc5f550-800c-4290-b6d3-9426823e5816",
				Name = "Inner Wheel Clubs of District 16 North & South of Ireland",
				LookupId = "8-10278370",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ebae9590-7e1a-40f4-b3b0-e7c0771868ea",
				Name = "Rotary Club of Braids",
				LookupId = "8-10278380",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "88b22ca6-b371-412a-9a90-ba93ae7efc09",
				Name = "Rotary Club of Cardiff Bay",
				LookupId = "8-10278381",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0bbd654b-5669-4b91-a9db-873212c33ac2",
				Name = "Rotary Club of Chelmsford Phoenix",
				LookupId = "8-10278400",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a80efdd6-ce9f-444f-b645-39327dd9ab85",
				Name = "Rotary Club of Cleckheaton & District",
				LookupId = "8-10278402",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7a79bdb8-cfba-4eb0-86d0-08b39dfe8b4e",
				Name = "Rotary Club of Porthcawl",
				LookupId = "8-10278403",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5a8251df-448d-4395-a2f6-b97fabb7da6e",
				Name = "Rotary Club of Brue Valley",
				LookupId = "8-10278409",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "907b2ce4-616b-47d0-90ab-1074ec9a712d",
				Name = "Rotary Club of Grimsby",
				LookupId = "8-10278413",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c429ead6-2a90-4e5f-8a78-496613c48527",
				Name = "Inner Wheel Club of Boscombe & Southbourne",
				LookupId = "8-10278414",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bf9ddfea-4952-4c3a-a269-0e664f08b06e",
				Name = "Rotary Club of Stamford",
				LookupId = "8-10278416",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0a58aa4a-0641-4e21-bad7-7356899e6051",
				Name = "Rotary Club of Newry",
				LookupId = "8-10278418",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec48045b-ba23-4f52-9751-ae110b1c629c",
				Name = "Rotary Club of Waterford",
				LookupId = "8-10278420",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e0a8fba2-844d-46f5-9d2e-18445a46ee86",
				Name = "Rotary Club of Wilmslow Dean",
				LookupId = "8-10278421",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c20b3dea-4370-4e8f-a355-8ea392838ee0",
				Name = "Rotary Club of Middleton",
				LookupId = "8-10278424",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8b336435-cab1-4e1e-bae2-929b39850cc1",
				Name = "Rotary Club of Kilkenny",
				LookupId = "8-10278434",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c0885830-37d5-4de6-9e97-79b364b85505",
				Name = "Rotary Club of South Cave & Wolds",
				LookupId = "8-10278444",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a3f595b3-1ad3-42d4-afe8-bff29e6b305a",
				Name = "Rotary Club of Tain & Easter Ross",
				LookupId = "8-10278446",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "51dea00b-e10d-4b62-ae68-a7ea01cb1028",
				Name = "Rotary Club of Thanet",
				LookupId = "8-10278447",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "230d1983-c19e-463e-b9a9-a9a4df6b00ed",
				Name = "Rotary Club of Millom",
				LookupId = "8-10278459",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "38f99ad8-db2b-4e9a-a6fd-bf69a4faf818",
				Name = "Rotary Club of Beccles",
				LookupId = "8-10278466",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2c385341-1d9e-440a-bdf4-ae399774be80",
				Name = "Rotary Club of Lincoln",
				LookupId = "8-10278470",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f61f9d9a-f21f-44c7-a708-72ec1339ba99",
				Name = "Inner Wheel Club of Liskeard & Looe",
				LookupId = "8-10278471",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "28208746-d121-4e5f-834b-1d0ee1acc3ad",
				Name = "Rotary Club of Loddon Vale",
				LookupId = "8-10278472",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9171d7fd-21eb-4e86-bffe-dc5a1e2895bc",
				Name = "Rotary Club of Londonderry",
				LookupId = "8-10278473",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8e661d43-a207-4c40-9d7a-66e34731b32e",
				Name = "Inner Wheel Club of Anstruther",
				LookupId = "8-10278474",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3dbce246-a9e9-48b9-897a-b10333b1977e",
				Name = "Rotary Club of Milton Keynes",
				LookupId = "8-10278475",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "35db176e-0273-4690-8292-e7ce1b40d69a",
				Name = "Inner Wheel Club of Blaby",
				LookupId = "8-10278480",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea8ded98-9f58-455e-834c-a5a2971b978f",
				Name = "Rotary Club of Southsea Castle",
				LookupId = "8-10278492",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2a64693e-a036-4e81-89c2-d52ca0a7dd05",
				Name = "Rotary Club of Ayr",
				LookupId = "8-10278497",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9c748a4d-3c51-4786-92fa-cdf1d7bd7c88",
				Name = "Rotary Club of Barking",
				LookupId = "8-10278498",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d67c2e05-eea6-42da-8be3-264ee269b272",
				Name = "Rotary Club of Bookham & Horsley",
				LookupId = "8-10278499",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1da2778d-1155-4704-996c-8843df4445e1",
				Name = "Rotary Club of Barnet",
				LookupId = "8-10278502",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9c6325f9-b906-4fb6-b991-516b93ee9ba5",
				Name = "Inner Wheel Club of Basingstoke",
				LookupId = "8-10278503",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "65de7212-bd87-4e94-ac78-1cc879a59992",
				Name = "Rotary Club of Callander & West Perthshire",
				LookupId = "8-10278504",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d91c3fad-b8b6-4dad-9600-f6cc38318c57",
				Name = "Rotary District 1040",
				LookupId = "8-10278507",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e85103ed-4d8a-4316-b2d6-77907c6357ed",
				Name = "Rotary Club of Accrington",
				LookupId = "8-10278509",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "340d70ef-3d8f-4d7b-8d47-04c519c6a837",
				Name = "Rotary Club of Alresford",
				LookupId = "8-10278510",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bc33713e-b8dc-4392-b481-9dc1f5b1a366",
				Name = "Rotary Club of Saundersfoot",
				LookupId = "8-10278514",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "822a2bd1-bbac-42dd-9681-8acd050e842b",
				Name = "Rotary Club of Wolverhampton",
				LookupId = "8-10278518",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dc25fbe9-15ab-4971-ad20-0b70bdb0517c",
				Name = "Inner Wheel Club of Padstow",
				LookupId = "8-10278519",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8b93136f-5bbb-419b-a636-0105d079e9dd",
				Name = "Rotary Club of Bingley",
				LookupId = "8-10278522",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4ba9a5fc-f36d-485d-9234-18c4b1d0f897",
				Name = "Rotary Club of Coventry Jubilee",
				LookupId = "8-10278525",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "436a5122-6452-43e6-ba9e-b9080becfcd2",
				Name = "Inner Wheel District 23",
				LookupId = "8-10278531",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "da472dac-b12e-46c0-b147-3ca3afe7cc20",
				Name = "Rotary Club Of Rushen & Western Mann",
				LookupId = "8-10278542",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cf70be28-ad85-4d83-aadf-d846274dead2",
				Name = "Inner Wheel Club of Saltash",
				LookupId = "8-10278543",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8f92deea-9bc8-4c50-b45e-be37eddd59fb",
				Name = "Rotary Club of Titsey & District",
				LookupId = "8-10278545",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e98bdd2f-bc15-4303-bcdf-922566913791",
				Name = "Rotary Club Of Maidstone Dawn Patrol",
				LookupId = "8-10278575",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4d9f553a-3e4c-4962-9a14-261499077126",
				Name = "Rotary Club of Wednesfield",
				LookupId = "8-10278576",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "16589ddd-182c-4ddd-83b2-081907c567c1",
				Name = "Rotary Club of Wellington, Shropshire",
				LookupId = "8-10278577",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0ee9b38b-fe4e-438f-9c68-de15faa0d47c",
				Name = "Rotary Club of Poulton-Le-Fylde",
				LookupId = "8-10278583",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5cd841cd-301e-4c18-9580-8219f215e8b2",
				Name = "Inner Wheel Club of Aberdeen St Fittick",
				LookupId = "8-10278590",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "38312dcb-a666-42ec-bac8-e0b68adb987e",
				Name = "Rotary Club of Coventry Phoenix",
				LookupId = "8-10278594",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d0873997-54dd-43bf-a18b-62869e403bfc",
				Name = "Rotary Club of Rainhill",
				LookupId = "8-10278603",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d317eb82-9e3a-47d7-bc47-0e9c2dc454dd",
				Name = "Rotary Club of Shoreham & Southwick",
				LookupId = "8-10278604",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a777b8ef-9eec-4004-a1a4-47a73072d7a8",
				Name = "Inner Wheel Club of Salisbury",
				LookupId = "8-10278619",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "31e70b9b-5a54-4bd6-92d3-221dccec4c16",
				Name = "Inner Wheel Club of Shepton Mallet",
				LookupId = "8-10278622",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "20d3570a-01a7-477c-9c57-618fc984a169",
				Name = "Rotary Club of Scarborough",
				LookupId = "8-10278623",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d2deeb04-95e4-4673-a987-8c32040ebe80",
				Name = "Inner Wheel Clubs of District 4",
				LookupId = "8-10278626",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "afe25402-bc1e-465d-9b7c-d4ae4f3b92ec",
				Name = "Rotary Club of Knutsford",
				LookupId = "8-10278630",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "acc06af1-a276-4824-a9af-9414a9890988",
				Name = "Rotary Club of Chertsey",
				LookupId = "8-10278633",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6bde3fcc-a0d8-4dc5-8c36-2097168574dd",
				Name = "Rotary Club of Corby Phoenix",
				LookupId = "8-10278634",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fcab5133-64d6-4954-b136-9ca7a80346b6",
				Name = "Inner Wheel Club of Taunton Vale",
				LookupId = "8-10278750",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c7a5cb67-7761-4548-85e5-fb92f676e928",
				Name = "Rotary Club of Battersea, Brixton & Clapham",
				LookupId = "8-10278754",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "04c6a878-6850-4451-8b6a-1a9a7f40665c",
				Name = "Inner Wheel Club of Matlock",
				LookupId = "8-10278758",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "51cc41a2-3de6-402e-b13b-e8b88a1effcf",
				Name = "Rotary Club of Milford Haven",
				LookupId = "8-10278762",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fdda3f1a-dac8-4f24-877a-f7f5f36ac7e6",
				Name = "Interact Club of E-ACT Burnham Park Academy",
				LookupId = "8-10278769",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1920305f-97ce-466a-a7f4-6c34931eabb5",
				Name = "Inner Wheel Club of Ramsey",
				LookupId = "8-10278773",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5e929cc3-99ff-4bdc-b9a3-88b96f7c710d",
				Name = "Interact Club of Port Talbot",
				LookupId = "8-10278780",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d29fc27b-15f0-4ecb-8df2-16db014dbb81",
				Name = "Rotary Club of Okehampton",
				LookupId = "8-10278783",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "489af716-41b1-46c7-964f-42c9758b7caa",
				Name = "Rotary Club of Rotary@Kingsholm, Gloucester",
				LookupId = "8-10278797",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "232eac94-613d-4335-930b-2cbbfe7b9116",
				Name = "Rotaract Club of Peterborough",
				LookupId = "8-10278801",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c97a618c-66c0-4f23-9b59-d6e0a219166c",
				Name = "Rotary Club of Ryde",
				LookupId = "8-10278814",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6d5ee335-1cd9-443b-bd33-bb6ef9850507",
				Name = "Rotary Club of Southgate",
				LookupId = "8-10278815",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a781dea0-343b-4282-a5dd-03c7fe625389",
				Name = "Inner Wheel Club of Stirling",
				LookupId = "8-10278817",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ae16c97d-c918-496d-8673-2b1d39ea300a",
				Name = "Rotary Club of Ashby De La Zouch Castle",
				LookupId = "8-10278821",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ba557905-081f-4ce7-b2fa-f7174057d416",
				Name = "Rotary Club of Diss Waveney",
				LookupId = "8-10278843",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f90cef23-809c-4451-a8bf-45c140cb1c61",
				Name = "Inner Wheel Club of Camelford",
				LookupId = "8-10278857",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7313f512-ec09-4349-a823-1dc4d47919bb",
				Name = "Inner Wheel Club of St. Austell",
				LookupId = "8-10278859",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3ba99fd3-9e72-428c-9268-b8a1c60437fc",
				Name = "Rotary Club of Louth",
				LookupId = "8-10278861",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0e28c640-6f98-4b83-aa50-77bc173ae65c",
				Name = "Rotary Club of Sandy",
				LookupId = "8-10278869",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "74b95255-503a-40bd-a983-f98a6a44cd75",
				Name = "Rotary Club of Blackburn",
				LookupId = "8-10278870",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f6cc2c3d-d0c0-44a7-b8d3-36486df5c0f2",
				Name = "Rotary Club of Kilmarnock",
				LookupId = "8-10278878",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f0932eca-a43b-426f-8064-f513fac1af74",
				Name = "Rotary Club of Chipping Sodbury",
				LookupId = "8-10278891",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8ac34fae-385a-4cbf-a7d3-8fb9efe4637a",
				Name = "Rotary Club of Hawick",
				LookupId = "8-10278893",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a4a5eafd-b3de-4a5f-9d98-5bdcceacc34e",
				Name = "Inner Wheel District 25",
				LookupId = "8-10278894",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9e88039b-00f1-4cdf-a611-8b6fb63de0fa",
				Name = "Inner Wheel Club of Kettering",
				LookupId = "8-10278909",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0c92af99-d4dc-4e64-a745-b7c536933232",
				Name = "Rotary Club of Guisborough & Great Ayton",
				LookupId = "8-10278919",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "10bea18c-9e9d-4d70-aba1-e3c3de2b75ac",
				Name = "Rotary Club of Harpenden Village",
				LookupId = "8-10278920",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "de9a84a6-dd30-4aa7-b5ea-3c47beb707b4",
				Name = "Rotary Club of Linlithgow & Bo'Ness",
				LookupId = "8-10278921",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8c9f94e7-dd24-4134-8cf5-c5b7611ba236",
				Name = "Rotary Club of Littleport",
				LookupId = "8-10278922",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7b871f88-b595-43fd-adba-32c880cbc731",
				Name = "Rotary Club of Loughton, Buckhurst Hill & Chigwell",
				LookupId = "8-10278923",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ca9ced2a-efdd-48ff-b87e-901ec5a160ae",
				Name = "Rotary Club of Market Rasen",
				LookupId = "8-10278924",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "14ca57fc-f894-409b-9369-950e99d68c52",
				Name = "Rotary Club of Norwich St. Edmund",
				LookupId = "8-10278926",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f1899ee8-e9b1-46ab-b8bc-b562b78d109b",
				Name = "Rotary Club of Richmond, Yorks",
				LookupId = "8-10278934",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "79f697a8-4e13-4ea0-a8fd-734d667f9bd6",
				Name = "Rotary Club of Sheppey, The Isle of",
				LookupId = "8-10278943",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ae8c5a30-9d6f-47b1-9039-10463f82fcc0",
				Name = "Rotary Club of Hastings",
				LookupId = "8-10278944",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "76f600ff-e927-4252-b064-2205c06ee26b",
				Name = "Rotary Club of Llandovery",
				LookupId = "8-10278962",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fc660abb-9a67-49f3-841d-17c2d758c67b",
				Name = "Rotary Club of Nailsworth",
				LookupId = "8-10278979",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "751470e0-e49c-42c6-87d8-a70d4f4feb49",
				Name = "Rotary Club of York Vikings",
				LookupId = "8-10278980",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "061cdbd2-6d9a-4b61-89cb-da20c24f64ac",
				Name = "Inner Wheel Club of Marlborough",
				LookupId = "8-10278981",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "83d5abeb-7e16-4e2e-9fc8-251c5e832708",
				Name = "Inner Wheel Club of Basingstoke Deane",
				LookupId = "8-10279015",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9d02e00d-d3c2-40fd-ab45-fbab6ccc20a7",
				Name = "Rotary Club of Aberfeldy & District",
				LookupId = "8-10279076",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ed053540-e5fa-4689-aef4-c00cd008d620",
				Name = "Rotary Club of Weymouth",
				LookupId = "8-10279087",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d8876af6-2454-45b9-a3f4-139bc13b5862",
				Name = "Rotary Club of Edinburgh",
				LookupId = "8-10279094",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c2e2b54c-f120-4bb9-80a4-bd877a071cdc",
				Name = "Ladies Social Group",
				LookupId = "8-10279107",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3abd31d6-6d30-46a7-9fb7-5dcd0b5ef6a7",
				Name = "Rotary Club of Tower Hamlets",
				LookupId = "8-10279117",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c9a31e18-60a4-4993-9d66-2f64c872702e",
				Name = "Inner Wheel Club of Southam",
				LookupId = "8-10279124",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "21cab790-bdda-4fec-8c59-7a70fe146e0f",
				Name = "Rotary Club of Severn Vale",
				LookupId = "8-10279125",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b450e537-48aa-4926-bf95-f2d24ebb774e",
				Name = "Rotaract Club of Glasgow",
				LookupId = "8-10279136",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b239c39b-7487-4dc9-951d-06e09ef41a27",
				Name = "Rotary Club of Kettering Huxloe",
				LookupId = "8-10279140",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "67f06bff-fb9a-40a6-9404-e433ce4eb309",
				Name = "Inner Wheel District 14",
				LookupId = "8-10279160",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9269f4b3-0b67-4556-913e-d31342c457d0",
				Name = "Inner Wheel Club of Chipping Sodbury",
				LookupId = "8-10279162",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "39a2359a-4f16-4251-9045-0f9dc1024e91",
				Name = "Rotary Club of Dagenham",
				LookupId = "8-10279163",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f9a1ddf1-75f5-4564-af34-022202259d9e",
				Name = "Rotary Club of Farnborough",
				LookupId = "8-10279166",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "463a2d56-de7b-43cb-96d3-a9a175dcaeba",
				Name = "Rotary Club of Llanelli",
				LookupId = "8-10279168",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eb27618d-dcb5-4bbc-a315-159f7359d7b9",
				Name = "Rotary District 1060",
				LookupId = "8-10279171",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "960b12a9-e081-44e2-bba4-cccc4f7f93de",
				Name = "Rotary Club of St. Leonards-on-Sea",
				LookupId = "8-10279174",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "70619649-7a7a-454d-ab4b-1b354f3b95f4",
				Name = "Rotary Club of Wick",
				LookupId = "8-10279175",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a9b3ad7d-a4d0-42b0-a480-95acaeed5075",
				Name = "Rotary Club of Canterbury",
				LookupId = "8-10279182",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e8865c45-152d-45be-96dc-c0d59b847ed3",
				Name = "Inner Wheel Club of Grantham",
				LookupId = "8-10279197",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "80a954df-8572-485b-926e-828f3af54de1",
				Name = "Rotary Club of Spalding and Welland",
				LookupId = "8-10279210",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e499e7c7-19c8-40e6-bdac-68c1f6396e9f",
				Name = "Rotary Club of Grantham",
				LookupId = "8-10279211",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3d4ab283-ec9e-4a56-b967-f4f21830428b",
				Name = "Rotary Club of St. Columb",
				LookupId = "8-10279213",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a5cd1b8e-8c51-42b7-8da2-b8a2a53ae22a",
				Name = "Inner Wheel Club of Lincoln District 127",
				LookupId = "8-10279233",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "994109c8-759a-4cb3-83d1-303e709579cf",
				Name = "Inner Wheel Club of Wolverhampton",
				LookupId = "8-10279237",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "edaccb8e-4cd2-4f57-acc9-bd729429ffef",
				Name = "Rotary Club Of Winchester",
				LookupId = "8-10279244",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7e339537-4f34-4ed3-ba49-bf9ed7b92701",
				Name = "Rotary Club of Southport Links",
				LookupId = "8-10279245",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f6cd5c5a-b86b-4ba8-a9ee-08b98d2a4c1c",
				Name = "Rotary Club of Dyce",
				LookupId = "8-10279247",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "51cb7efa-be30-4dee-b4de-842c9cbca237",
				Name = "Rotary Club of Southampton Magna",
				LookupId = "8-10279248",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5dec01dc-14e8-49ff-97df-50ad894990bb",
				Name = "Inner Wheel Club of Blaby Meridian",
				LookupId = "8-10279258",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "333ec214-4ec4-4ad2-8313-66139c0287fb",
				Name = "Rotary Club of Stainborough",
				LookupId = "8-10279261",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c451e947-bdd9-4f93-b16c-0502175a129f",
				Name = "Rotary Club of Stourport-on-Severn",
				LookupId = "8-10279262",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "255642a7-8a39-42c9-9665-b8cfad325fe8",
				Name = "Rotary Club of Thorne",
				LookupId = "8-10279263",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d77c2d47-9654-42ba-9096-545a1ea74fd7",
				Name = "Inner Wheel Club of Helston-Lizard",
				LookupId = "8-10279277",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c0a10ea7-e8d4-49ca-9e91-29033347d484",
				Name = "Rotary Club of Holsworthy",
				LookupId = "8-10279278",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b5375899-f14d-475f-8aa3-437d50162cd7",
				Name = "Rotary Club of South Cotswolds",
				LookupId = "8-10279287",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6565a868-8448-47e6-918c-618d09f6469c",
				Name = "Inner Wheel Club of Southport Meols",
				LookupId = "8-10279302",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9acfdad5-39a7-42fc-824e-db69ce5ae2f4",
				Name = "Inner Wheel District 12",
				LookupId = "8-10279308",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8f274448-920e-49bd-886d-4f7821c0607e",
				Name = "Rotary Club of Redcar",
				LookupId = "8-10279315",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5a0619bb-0afe-4b20-9538-e4f0f2ccd0e2",
				Name = "Rotary Club of Rotherham Sitwell",
				LookupId = "8-10279316",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c3d6fdc1-1bff-4684-b24f-a578bd3dc23d",
				Name = "Rotary Club of Tavistock",
				LookupId = "8-10279317",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3bed4a6f-b978-4a92-9e94-9fb6aaa5f985",
				Name = "Rotary Club of Banff",
				LookupId = "8-10279331",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2d940db7-777a-4240-ab3e-ac2b691813ed",
				Name = "Rotary Club of Gosport",
				LookupId = "8-10279332",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aad12af3-2739-455d-9df3-d0fdca1fd508",
				Name = "Rotary Club of Llandudno",
				LookupId = "8-10279333",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7c625622-ce8a-4eb1-923d-58bf1979d668",
				Name = "Rotary Club of Billingshurst and District",
				LookupId = "8-10279334",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4e508866-4a4d-472b-920c-1b1c7d01a6f6",
				Name = "Rotary Club of Bargoed",
				LookupId = "8-10279338",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f520caf3-ac0d-4197-b06c-4710ef03f6aa",
				Name = "Inner Wheel Club of Perth",
				LookupId = "8-10279343",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7dfa1ce7-50fe-4db8-ade4-9141d5036123",
				Name = "Rotary Club of Corstorphine",
				LookupId = "8-10279346",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "12a7ed40-aa7b-4bfc-b499-86643d6e9b0e",
				Name = "Rotary Club of Watton & District",
				LookupId = "8-10279349",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d495b9c2-1e3a-4ccf-b8af-62c61d3c7401",
				Name = "Rotary Club of Royal Wootton Bassett Town",
				LookupId = "8-10279350",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a492029e-da45-4989-933a-7ecd548e011f",
				Name = "Rotary Club of Lewisham and Penge",
				LookupId = "8-10279351",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cad218eb-0a64-4c19-8dd0-cacb51f9c732",
				Name = "Inner Wheel Club of Coleraine",
				LookupId = "8-10279352",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4da9807f-caac-45ea-89cf-4cacaa9796da",
				Name = "Rotary Club of Portsmouth & Southsea",
				LookupId = "8-10279353",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cdef7a4c-83b0-4d72-9788-5b1f17ef53ed",
				Name = "Rotary Club of Brampton & Longtown",
				LookupId = "8-10279354",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4c30064f-9e50-4b59-9a8a-806bda8e40af",
				Name = "Rotary Club of Leicester Novus",
				LookupId = "8-10279358",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c9bbc886-b582-4ab0-93e3-838dd85c679f",
				Name = "Rotary Club of Aberdeen-St. Nicholas",
				LookupId = "8-10279361",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0f508b2e-9693-4ecd-a800-3523e24c7d79",
				Name = "Rotary Club of Bransgore & District",
				LookupId = "8-10279362",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3e8070e0-e73d-48d1-93a8-1567097ff5f4",
				Name = "Rotary Club of Saffron Walden",
				LookupId = "8-10279366",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3707b275-4ca0-4717-a953-05a40e8401c6",
				Name = "Rotary Club of Broughty Ferry",
				LookupId = "8-10279368",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "700bc735-333d-4c3a-9df5-08ef247e9d5f",
				Name = "Interact Club of Davis College Mallow",
				LookupId = "8-10279377",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2b10c80d-7aec-46b5-a551-47e1ad7232e3",
				Name = "Rotary Club of Bodmin",
				LookupId = "8-10279382",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e418f96a-9fb0-47f8-a06e-a2abc768d33a",
				Name = "Rotary Club of Horwich",
				LookupId = "8-10279384",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "471f61bc-6666-4fb4-86de-58228a3a1a23",
				Name = "Rotary Club of Solihull St. Alphege",
				LookupId = "8-10279386",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "91841af7-797f-4b5e-adfd-d804cbac3f61",
				Name = "Inner Wheel Club of Horwich",
				LookupId = "8-10279393",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a3d74bdf-7b45-431d-a280-2b6070195f3b",
				Name = "Inner Wheel Club of Farnham",
				LookupId = "8-10279397",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f3e60e4b-1ffa-413c-ab97-f6b8fe16dea8",
				Name = "Rotary Club of Belfast",
				LookupId = "8-10279400",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5a1bccdc-f64f-408b-84a6-ede35b4a6b66",
				Name = "Rotary Club of Dublin North",
				LookupId = "8-10279401",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6a16c818-622e-4215-af57-bcc4d778d249",
				Name = "Rotary Club of Marlborough & District",
				LookupId = "8-10279402",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9b8d28eb-43e5-4b38-bb9c-af970464a2be",
				Name = "Rotary Club of Galway-Salthill",
				LookupId = "8-10279403",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3558adbc-71eb-4b80-a53b-3716bcf49c6b",
				Name = "Rotary Club of Oxted & Limpsfield",
				LookupId = "8-10279404",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "058bd33b-f0f4-4245-969d-1dec71d2d2c4",
				Name = "Inner Wheel Club of The Soar Valley",
				LookupId = "8-10279415",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "75110bf6-df66-41be-847d-9ec87263aabd",
				Name = "Rotary Club of Cambridge South",
				LookupId = "8-10279421",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d225cc73-394c-47bb-9ad0-a620143d5f6a",
				Name = "Rotary Club of Plymouth Mayflower",
				LookupId = "8-10279424",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "53ae1b46-5b6d-42c7-bad1-a5ced3783803",
				Name = "Rotary Club of Ripon",
				LookupId = "8-10279427",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e87c3f75-d1fd-442e-828d-a852358e72db",
				Name = "Rotary Club of Lisburn",
				LookupId = "8-10279430",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "54adb467-d34c-4704-a9f0-3da122776a20",
				Name = "Rotary Club of Shepshed",
				LookupId = "8-10279486",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cf9e2424-084c-42f8-b16d-7a74e33be07a",
				Name = "Rotary Club of Formby Squirrels",
				LookupId = "8-10279539",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "691f8e21-d3fb-402d-928d-ab7e317edcb0",
				Name = "Inner Wheel Club of Tarporley",
				LookupId = "8-10279553",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6788b5ed-e65c-40c3-a2cd-e843e8998fe3",
				Name = "Rotary Club of Astley",
				LookupId = "8-10279554",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "26d22936-0849-4514-b89f-154b5c4d03ac",
				Name = "Rotary Club of Bungay",
				LookupId = "8-10279555",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b4893d8e-139c-44ad-b10d-3832f78ac8e9",
				Name = "Rotary Club of Great Yarmouth Haven",
				LookupId = "8-10279556",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "77972257-b0e0-4322-b509-478c39c86938",
				Name = "Rotary Club of Westhoughton",
				LookupId = "8-10279558",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "192a2934-6133-4af0-8ab0-180f6c6fffc7",
				Name = "Rotary Club of Keynsham",
				LookupId = "8-10279569",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "14f4a35f-fbe4-42de-9e27-59e314a77c7f",
				Name = "Rotary Club of Ilkley Wharfedale",
				LookupId = "8-10279572",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8759d867-ba24-4bc8-87f7-618bfc67352d",
				Name = "Inner Wheel Club of Atherstone",
				LookupId = "8-10279573",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7ae56436-cf64-4ab1-8427-84dd0fcb541d",
				Name = "Inner Wheel Club of Rushen & Western Mann",
				LookupId = "8-10279575",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7065b224-b609-48e3-8b36-5209ae838875",
				Name = "Inner Wheel Club of Ferndown",
				LookupId = "8-10279593",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "91b8e8b6-5255-4b2f-8d3a-c70675b7eb78",
				Name = "Rotary Club of Torbay Sunrise",
				LookupId = "8-10279594",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b55981b2-796d-4319-b3ef-369d69d35616",
				Name = "Inner Wheel Club of Windsor & Eton",
				LookupId = "8-10279618",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ac0f7d1d-bd24-4809-9053-8b60581ba18f",
				Name = "Inner Wheel Club of Warwick",
				LookupId = "8-10279622",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "579eee23-6c79-444c-b7df-d74b75a2f759",
				Name = "Rotary Club of Kinver",
				LookupId = "8-10279660",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2886a9f9-563f-4400-98bf-484e98c5002d",
				Name = "Inner Wheel Club of Blyth",
				LookupId = "8-10279663",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0b16597a-a438-463d-886f-cac48b441382",
				Name = "Rotary Club of Tooting",
				LookupId = "8-10279670",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7e4c89bd-3ad4-4f59-a987-bd1900b1254a",
				Name = "Rotary Club of Wellington, Somerset",
				LookupId = "8-10279671",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ae6950d9-0fc4-4735-a4f8-edcceac0ca34",
				Name = "Rotary Club of Purley",
				LookupId = "8-10279675",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "711e0a89-d419-4fa2-9ef1-3515d02589b0",
				Name = "Rotary District 1070",
				LookupId = "8-10279676",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7367eefd-6834-4a91-bd23-e55f5087c4f4",
				Name = "Interact Club of St Andrews R C High School",
				LookupId = "8-10279685",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "31928b80-b1db-440c-921d-878421f82d0c",
				Name = "Rotary Club of Barnstaple Link",
				LookupId = "8-10279694",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "98f1c4e3-b742-4b38-9642-d24925705d6e",
				Name = "Rotary Club of Burnham Beeches",
				LookupId = "8-10279695",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "201ba82a-86d2-4ab5-b954-b47b6eb08402",
				Name = "Rotary Club of Leek",
				LookupId = "8-10279698",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9be5883e-ecd0-4d5e-8f89-88af04314e72",
				Name = "Rotary Club of Littlehampton",
				LookupId = "8-10279699",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "14c3b6ab-f0ce-44c5-8d98-6dc08778c876",
				Name = "Inner Wheel Club of Gatley & District",
				LookupId = "8-10279705",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d1dc0cb3-d43a-4d7d-87a0-9eb062b56696",
				Name = "Rotary Club of Stamford Burghley",
				LookupId = "8-10279707",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b53daf1d-8cc6-4a37-90d9-0f2babaa6484",
				Name = "Rotary Club of Westbourne",
				LookupId = "8-10279713",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "27b28831-79c9-4b97-8072-9c36a4837ed3",
				Name = "Inner Wheel Club of Teignmouth",
				LookupId = "8-10279720",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7cf1574d-0bab-432c-945a-d972730c89cc",
				Name = "Rotary Club of Cowes",
				LookupId = "8-10279722",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8804303a-d24d-492b-8fed-e6c55d30ad05",
				Name = "Rotary Club of Burgess Hill & District",
				LookupId = "8-10279739",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3c5ea1b-879c-4ff5-9e3b-e49d2271c0e6",
				Name = "Rotary Club of Llangollen Dee Valley",
				LookupId = "8-10279743",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d6e8ca8f-89cb-48f1-a2e5-004ee1194789",
				Name = "Inner Wheel Club of Thurso",
				LookupId = "8-10279749",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e51b2d97-c013-4560-afeb-bac5bb91e795",
				Name = "Rotary Club of Darlington",
				LookupId = "8-10279752",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "46bdf38d-68f8-4574-a52b-9e6b25399a05",
				Name = "Rotary Club of Southport",
				LookupId = "8-10279754",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c2526cc2-fe93-440e-9a0e-f30f67827f78",
				Name = "Rotary Club of Redhill, Reigate & District",
				LookupId = "8-10279765",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e312ba51-895a-4bb6-a37d-e8539e0c9744",
				Name = "Rotary Club of Ashford, Kent",
				LookupId = "8-10279770",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a3274188-7d18-4bab-b616-c4ea96fc743a",
				Name = "Rotary Club of Hythe & Waterside",
				LookupId = "8-10279773",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9dcbdbae-4add-416e-928e-524445264f35",
				Name = "Rotary Club of Swanage & Purbeck",
				LookupId = "8-10279775",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "58c42ede-4093-429f-82ce-0440ba68f1f5",
				Name = "Rotary Club of Chester Deva",
				LookupId = "8-10279779",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "648c7816-2ee2-4a83-85aa-79431ae01b64",
				Name = "Rotary Club of Garstang & Over Wyre",
				LookupId = "8-10279781",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ee39774f-037e-471a-b887-7c76c0161417",
				Name = "Rotary Club of Telford Centre",
				LookupId = "8-10279782",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a914a682-d6f5-423a-9b3e-d553e7171a44",
				Name = "Rotary Club of Durham Elvet",
				LookupId = "8-10279783",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c9dddb34-06f0-40cf-bebc-9c063701ae56",
				Name = "Rotary Club of Battersea Park",
				LookupId = "8-10279784",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a1d9f16a-2429-41ff-885d-a4d2b77b7a93",
				Name = "Inner Wheel Club of Chipping Norton",
				LookupId = "8-10279786",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7ba538d7-2467-495d-9caf-8608474e3858",
				Name = "Inner Wheel Club of Cleethorpes",
				LookupId = "8-10279787",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d1fb2d99-bf2a-4231-a005-0ed22fcbff66",
				Name = "Rotary Club of Dronfield",
				LookupId = "8-10279791",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b23f6bb8-982e-488f-9a55-3ca245116370",
				Name = "Rotary Club of Crieff",
				LookupId = "8-10279793",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5c4be556-33e8-4cda-a732-81076812c6de",
				Name = "Rotary Club of Horsham",
				LookupId = "8-10279794",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bb008d5f-3ee9-42f6-8509-75abca3a2318",
				Name = "Rotary Club of Handsworth",
				LookupId = "8-10279800",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bbbcd0e3-5635-40a3-b524-8a20e64c2368",
				Name = "Inner Wheel Club of Arbury",
				LookupId = "8-10279808",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2131c1b9-74c9-4835-88c0-c36dd5be5c80",
				Name = "Rotary Club of Gordano Breakfast",
				LookupId = "8-10279810",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c0b29937-8de3-4e37-a290-1ebdeaa0bb0e",
				Name = "Rotary Club of North Down",
				LookupId = "8-10279814",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "18d77d3b-7e9e-4802-8593-a1fae64ebbca",
				Name = "Rotary Club of Twickenham-Upon-Thames",
				LookupId = "8-10279815",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8a6a4c47-eda5-49b9-b61e-158e7441c4cb",
				Name = "Rotary Club of Stafford Castle",
				LookupId = "8-10279817",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a81769d9-2fa3-417f-a0e0-ca0dfefde4d9",
				Name = "Rotary Club of Teignmouth",
				LookupId = "8-10279818",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a1e964b8-d36f-4621-aeca-caa7a4e900b9",
				Name = "Inner Wheel Club of Clifton",
				LookupId = "8-10279829",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9409c247-5c5f-478a-83c6-af4e39f6329e",
				Name = "Rotary Club of Bewdley",
				LookupId = "8-10279831",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6dd3008f-60eb-4adf-a544-79f1b550adf6",
				Name = "Rotary Club of Bournemouth",
				LookupId = "8-10279832",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b49cb06e-b915-421e-a864-15cee4f5e6fc",
				Name = "Inner Wheel Club of Llanfairfechan & Penmaenmawr",
				LookupId = "8-10279842",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a5032fed-dec7-4b27-86e2-8bcba8239f42",
				Name = "Rotary Club of Buckie",
				LookupId = "8-10279849",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a2d14fa2-78bb-40b9-9632-25d669c7a45d",
				Name = "Rotary Club of Alford and District",
				LookupId = "8-10279852",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8573258e-9f0e-4d49-b5c3-33a31a35b8bf",
				Name = "Rotary Club of March",
				LookupId = "8-10279854",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c86b8922-afa9-4342-a89d-76782a093722",
				Name = "Rotary Club of Chichester Priory",
				LookupId = "8-10279856",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a18d05bb-0118-4377-970b-4970227988f8",
				Name = "Rotary Club of Gloucester Quays",
				LookupId = "8-10279862",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "72ac41ae-7aae-411c-9420-f557c846212d",
				Name = "Rotary Club of Newtownabbey",
				LookupId = "8-10279874",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "33e24882-dd1f-41cd-ae51-f021d3ba78c5",
				Name = "Rotary Club of Perth Kinnoull",
				LookupId = "8-10279876",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "354d5fca-fef4-4046-9432-3359db9d77df",
				Name = "Rotary Club of St. Albans",
				LookupId = "8-10279878",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "06b7c446-9dd8-4e6c-b1e9-b66439a6f1f8",
				Name = "Rotary Club of Longridge and North Preston",
				LookupId = "8-10280006",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85b584fa-aec9-4a65-b4a4-7651c32373db",
				Name = "Interact Club of Llanidloes",
				LookupId = "8-10280013",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3133c6e8-d33c-4b2b-b7f7-3a73a89d70a0",
				Name = "Rotary Club of Soar Valley",
				LookupId = "8-10280025",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f0548bfb-0a89-4b25-9277-114d8fc22dcf",
				Name = "Rotary Club of St. Ives, Cornwall",
				LookupId = "8-10280026",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85016b36-d3f4-47dc-85c2-7ee5fe895bd5",
				Name = "Rotary Club of Norwich Centenary",
				LookupId = "8-10280070",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5643a3e2-933b-4119-833a-220f7b484d17",
				Name = "Inner Wheel Club of Halesowen",
				LookupId = "8-10280077",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b7b79143-cd6f-4d43-87a3-933fda88c922",
				Name = "Rotary Club of Lewes",
				LookupId = "8-10280078",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d6961ed5-4964-45af-af80-f6243a058fb9",
				Name = "Rotary Club of Welshpool",
				LookupId = "8-10280082",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ce66682f-8759-48f3-91e8-bad93e8573c2",
				Name = "Rotary Club of Wokingham",
				LookupId = "8-10280083",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e26d7701-094f-4891-9b9b-89b31d1a130b",
				Name = "Rotary Club of Faversham",
				LookupId = "8-10280092",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e970e200-53fe-4712-93fa-edb484f8739b",
				Name = "Rotary Club of Chelmsford Rivermead",
				LookupId = "8-10280098",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7f1e34bd-1087-4db6-9237-885ff826c7f8",
				Name = "Rotary Club of Clitheroe",
				LookupId = "8-10280102",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a9998a35-2a6c-48fc-877d-5d609c15eecf",
				Name = "Rotary Club of Selkirk",
				LookupId = "8-10280108",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "065cf40a-964b-4a7d-9a63-be1df76dccb0",
				Name = "Rotary Club of Hertford Shires",
				LookupId = "8-10280109",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c64b6cab-de7e-467e-a009-33bdd6f3ce9f",
				Name = "Rotary Club of Exmoor",
				LookupId = "8-10280111",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "670b2381-677b-4210-8134-0f6bafe26b83",
				Name = "Rotary Club of Slough",
				LookupId = "8-10280122",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2f9ecdb5-fced-41d3-b9a7-45b94bae17ca",
				Name = "Inner Wheel Club of Cockermouth",
				LookupId = "8-10280137",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ce6ca4d1-d56f-4046-8fb1-1e8a65880e64",
				Name = "Rotary Club of Abergavenny",
				LookupId = "8-10280153",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "72fc4685-3de3-459e-a86d-e9c6a86a645d",
				Name = "Rotary Club of Bassenthwaite",
				LookupId = "8-10280178",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1bd2115b-57f7-404d-9b37-d07b19441704",
				Name = "Rotary Club of Halifax",
				LookupId = "8-10280179",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "95f868bc-ddcf-449c-a6d3-7a864a85dd95",
				Name = "Rotary Club of Hertford",
				LookupId = "8-10280180",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "626254d9-3d0e-4c1d-a0e5-27fe09af0daa",
				Name = "Rotary Club of Elland",
				LookupId = "8-10280186",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "178db39b-00f7-4b77-84a7-614809b9ae77",
				Name = "Inner Wheel Club of Tavistock",
				LookupId = "8-10280194",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5371fd9d-4843-4810-8791-c866733be891",
				Name = "Inner Wheel Club of Bretby",
				LookupId = "8-10280213",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d19e89e3-404b-4bac-8192-42a2688baedd",
				Name = "Rotary Club of Biggar",
				LookupId = "8-10280223",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5482eb74-4902-4842-8b05-f9d68f23c141",
				Name = "Rotary Club of Bradford West",
				LookupId = "8-10280224",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "45721272-51d2-42c1-a725-93447de97de9",
				Name = "Rotary Club of Newcastle Gosforth",
				LookupId = "8-10280226",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "829ff184-eb3b-4e82-b61c-57ba44cfe8b9",
				Name = "Rotary Club of Bury St. Edmunds Abbey",
				LookupId = "8-10280233",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e0dbdfc2-720c-4637-ae2a-63c3b4275d9d",
				Name = "Inner Wheel District 22",
				LookupId = "8-10280235",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9c704352-b8a0-49b8-8c87-20b05bde2f6f",
				Name = "Inner Wheel Club of Otley Chevin",
				LookupId = "8-10280236",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8e763fcb-fd06-4c05-8242-858f4b3f7d4e",
				Name = "Rotary Club of Hendon",
				LookupId = "8-10280237",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0596ead7-475b-4952-9b81-b579f5702a0d",
				Name = "Rotary Club of Guildford Chantries",
				LookupId = "8-10280240",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea599d09-9695-460a-9ea3-d547ffd7a450",
				Name = "Rotary Club of Cleadon & District",
				LookupId = "8-10280243",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d455352e-742c-481d-b5b1-0075346b0c52",
				Name = "Rotary Club of Kimbolton Castle",
				LookupId = "8-10280248",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e661f0a7-4114-4e9b-a8b9-822a070623bb",
				Name = "Rotary Club of Holderness",
				LookupId = "8-10280253",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "639e48cd-cf8d-4a04-8007-99562e1ef922",
				Name = "Interact Club of Dyffryn",
				LookupId = "8-10280258",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "df701b3e-84bd-4de5-9eab-026e2643cdd8",
				Name = "Rotary Club of Glanmire & District",
				LookupId = "8-10280273",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0c44f26d-a0cc-4a02-90f8-d1c8e83260b1",
				Name = "Rotary Club of Beckenham",
				LookupId = "8-10280293",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "09c145cd-e313-44d0-b09e-7841a09b36a9",
				Name = "Rotary Club of Ferndown",
				LookupId = "8-10280295",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fb301a4d-6011-47c1-8ff5-617d6ccc7560",
				Name = "Rotary Club Of Reading Maiden Erlegh",
				LookupId = "8-10280297",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85d25207-ba45-446b-8ade-9cacf95130b9",
				Name = "Rotary Club of Matlock",
				LookupId = "8-10280298",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "62a5888a-e95b-49c2-9a19-d85755706b61",
				Name = "Rotary Club of South Ribble",
				LookupId = "8-10280299",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b8ab4a8c-68f7-4167-b94b-a09dc45a1b3c",
				Name = "Rotary Club of Mapperley & Arnold",
				LookupId = "8-10280311",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d068da3d-8e78-4ae4-a5fc-b1081dd3ede0",
				Name = "Rotary Club of Westhill & District",
				LookupId = "8-10280316",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5a0e44db-5494-4edd-a2a8-c987491c94c7",
				Name = "Rotary Club Of Charing Cross Glasgow",
				LookupId = "8-10280317",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b597f58-5951-4d18-8020-faa14da2d05d",
				Name = "Rotary Club of Dorchester Poundbury",
				LookupId = "8-10280334",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fed89395-5eb5-4626-8aba-1d43cee89f54",
				Name = "Rotary Club of Dunstable Downs",
				LookupId = "8-10280337",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "80c80e16-5250-4f97-b778-f6ff3bd834db",
				Name = "Rotary Club of Northampton",
				LookupId = "8-10280341",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ab4c92fe-a507-49ad-b03c-81f907f9ef3c",
				Name = "Inner Wheel District 18",
				LookupId = "8-10280342",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "20c7ba22-a80a-4d00-a9c4-5ef041f9e53c",
				Name = "Rotary Club of Melton Mowbray",
				LookupId = "8-10280343",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d53aad5c-1a49-4819-a9b1-4e67b33186ea",
				Name = "Inner Wheel Club of Alsager",
				LookupId = "8-10280363",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1a79a502-77bf-45f2-88f3-1cea935ecb76",
				Name = "Rotary Club of Walton-on-Thames",
				LookupId = "8-10280366",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e39fc506-8696-44ee-a515-f0a0caddd7c0",
				Name = "Rotary Club of Wolstanton",
				LookupId = "8-10280378",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b2d7b8c-8fc1-4a14-93ba-e5ce777168cb",
				Name = "Inner Wheel Club of Henley-in-Arden",
				LookupId = "8-10280380",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "39f1c3e3-72ff-4887-a6ac-2f3139b51df3",
				Name = "Inner Wheel Club of Locks Heath",
				LookupId = "8-10280389",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8fd2fe18-6d39-450c-a92f-ebd04068e0ad",
				Name = "Rotary Club of Leeds",
				LookupId = "8-10280401",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e64ccf07-37a1-424b-b574-b7ba00ef86f8",
				Name = "Inner Wheel Club of Tettenhall",
				LookupId = "8-10280407",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "281a6d2c-a087-4476-97e5-02f16bc90080",
				Name = "Rotary Club of Orpington",
				LookupId = "8-10280410",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2f141c01-3da3-497d-a9d9-5c31acb070d7",
				Name = "Inner Wheel Club of Ripon",
				LookupId = "8-10280416",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "31da566c-7f01-446d-ab92-4227c885f400",
				Name = "Inner Wheel Club of Gateshead East",
				LookupId = "8-10280429",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "35345727-bf86-488e-8007-e1c1918321ce",
				Name = "Rotary Club of Hamble Valley",
				LookupId = "8-10280430",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bd2137f0-b4e5-4d13-906e-2c028a3e10f0",
				Name = "Rotary Club of Hinckley Ambion",
				LookupId = "8-10280431",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5bff1b84-7895-4ca4-be4e-d85cae7f4311",
				Name = "Inner Wheel Club of Beccles",
				LookupId = "8-10280434",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f8df775a-6e3d-42aa-91bb-1ff3e45b38d7",
				Name = "Rotary Club of West Wight",
				LookupId = "8-10280442",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "67a4b375-bcc9-4abf-98c4-c885e804fcbc",
				Name = "Inner Wheel Club of Weymouth",
				LookupId = "8-10280443",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "191882f4-a20b-4149-b26a-887e48b24a98",
				Name = "Rotary Club of Winslow",
				LookupId = "8-10280444",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "536eaa58-42aa-49c7-9508-13973120ca2d",
				Name = "Rotary Club of Hull Kingston",
				LookupId = "8-10280446",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e662dda2-caa7-42e8-a03d-277c5730da8a",
				Name = "Rotary Club of Normanton",
				LookupId = "8-10280447",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4ea89424-7e31-4b5a-8fda-3482a54849bc",
				Name = "Rotary Club of Callington",
				LookupId = "8-10280460",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c0eb3c2a-8b61-449f-8aa4-c3e26861b571",
				Name = "Rotary Club of Godalming",
				LookupId = "8-10280461",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a9bb8832-63a0-4a33-9a5a-4c283f9a347e",
				Name = "Rotary Club of Chichester Harbour",
				LookupId = "8-10280468",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "201fb942-44aa-4b61-8b7c-aba32358d968",
				Name = "Rotary Club of Soham Staploe",
				LookupId = "8-10280472",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7761e4e1-875e-48b8-92de-2859b4db0996",
				Name = "Rotary Club of Aston",
				LookupId = "8-10280481",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4de19e1a-147f-45c7-8fed-38e2fc268d4c",
				Name = "Rotary Club of Retford",
				LookupId = "8-10280504",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "32963abc-1d58-4bcf-b1e1-00e8527bedb7",
				Name = "Rotary Club of Sandbach Crosses",
				LookupId = "8-10280505",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "491dd9a1-d698-4c57-a937-9b2190d4362d",
				Name = "Inner Wheel Club of Coventry",
				LookupId = "8-10280512",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e6ce2a9d-afb6-485e-a128-41c923715a1f",
				Name = "Inner Wheel Club of Stowmarket",
				LookupId = "8-10280516",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a085e987-0849-4381-aa8c-81961f79a4b1",
				Name = "Rotary Club of Cleveland",
				LookupId = "8-10280536",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f75e1f73-8511-46b0-9476-a148f780cc09",
				Name = "Rotary Club of Turton",
				LookupId = "8-10280544",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "94dfe016-23d4-4524-9717-0044ce8c85ce",
				Name = "Rotary Club of Dartmouth",
				LookupId = "8-10280554",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "341b2c75-d254-4fb8-af77-7d49ba7cfdc0",
				Name = "Inner Wheel Club of Edgbaston Convention",
				LookupId = "8-10280556",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2cfbbb04-ee4b-4de8-80f9-684b8fbdf9a5",
				Name = "Rotary Club of Belfast West",
				LookupId = "8-10280571",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ebe19a2c-63c1-4707-86c0-cefff15e15cc",
				Name = "Rotary Club of Prestatyn",
				LookupId = "8-10280572",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a93181e6-f70b-4c91-87e5-81f2b00ede97",
				Name = "Inner Wheel Club of Tottington & Bury West",
				LookupId = "8-10280574",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9b69601d-d687-43a4-8103-6f82e4bb79b2",
				Name = "Inner Wheel Club of Midhurst & Petworth",
				LookupId = "8-10280588",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3d913543-2bf4-4cb2-a792-aeb4873e48d3",
				Name = "Rotary Club of Wilton",
				LookupId = "8-10280593",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a5032591-fe42-459e-9d2b-1bd4cf1a3941",
				Name = "Rotary Club of Banstead",
				LookupId = "8-10280595",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5d2a3ef4-e3ed-4c9f-878a-fe03c8f3f22c",
				Name = "Rotary Club of Buckingham",
				LookupId = "8-10280596",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0d885433-c6e8-4e06-bd90-8ec68d4ee0d8",
				Name = "Rotary Club of Launceston",
				LookupId = "8-10280597",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "25745420-7601-4c10-9978-7e9542ddda1a",
				Name = "Rotary Club of Maidstone",
				LookupId = "8-10280598",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "99b510a1-0ec7-4fb7-aef8-cc747d629823",
				Name = "Rotary Club Of Helston Cober Valley",
				LookupId = "8-10280602",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2d2dda3a-4c36-4c19-98f1-bf6f75a07f9a",
				Name = "Rotary Club of Ullapool",
				LookupId = "8-10280604",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0f9fe087-098c-451c-970a-cc1957200bac",
				Name = "Rotary Club of Witney",
				LookupId = "8-10280605",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d634081f-103d-461c-8dd7-31303b076003",
				Name = "Rotary Club of Birmingham",
				LookupId = "8-10280612",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "11f04fea-c60e-47eb-a341-0931da1944e7",
				Name = "Rotary Club of Llanidloes",
				LookupId = "8-10280613",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9cb86ecb-e20a-405d-9f71-cde8273c719f",
				Name = "Inner Wheel Club of Wadebridge",
				LookupId = "8-10280625",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fb8246e2-dbf0-4817-a4e9-1e7d081ba30a",
				Name = "Rotary Club of Wrington Vale",
				LookupId = "8-10280626",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "faa859e6-567c-49ba-b98b-56db129dab74",
				Name = "Rotary Club of Bedford Castle",
				LookupId = "8-10280627",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f5a62bc9-9de2-4baa-a89f-46125098978d",
				Name = "Inner Wheel Club of Chorley Astley",
				LookupId = "8-10280634",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2b6121dc-c5c4-4eeb-a8aa-d6969da3fda7",
				Name = "Rotary Club of Romsey Test",
				LookupId = "8-10280645",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6b97c540-b1df-451e-9971-dd921bfc8b81",
				Name = "Inner Wheel Club of Thornaby & Yarm",
				LookupId = "8-10280652",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "89b948fd-ccc5-448d-8d23-157ae0702296",
				Name = "Rotary Club of Cumbernauld",
				LookupId = "8-10280680",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fdefbd47-8622-4671-8ab6-5be7411ffa9e",
				Name = "Rotary Club of Dulwich, Peckham & Crystal Palace",
				LookupId = "8-10280682",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "09ec2708-6e88-4b23-9dc5-f31453178a8f",
				Name = "Rotary Club of Shanklin",
				LookupId = "8-10280683",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8c3ae15e-5caa-415d-90de-94a791b0a928",
				Name = "Inner Wheel Club of Gosport",
				LookupId = "8-10280685",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5d0c9d1f-579c-465c-9be3-094f72748dbe",
				Name = "Inner Wheel Club of Ventnor",
				LookupId = "8-10280686",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eefc2640-c372-4743-a2d6-edf64c11f975",
				Name = "Rotary Club of Teddington & The Hamptons",
				LookupId = "8-10280724",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "667f3beb-b090-43eb-a981-f7e010b276a7",
				Name = "Rotary Club of Church Wilne",
				LookupId = "8-10280725",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "98060c08-9066-426d-8e4f-271e305b5bec",
				Name = "Rotary Club of Carlton",
				LookupId = "8-10280727",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "476cd009-2316-4466-b869-49e24010a886",
				Name = "Inner Wheel Club of Hart",
				LookupId = "8-10280728",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8c27bf4f-7015-4da2-aab6-dd15985e02be",
				Name = "Rotary Club of Ipswich East",
				LookupId = "8-10280729",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8ab82a78-bd8d-49f8-8aae-040ef3d456fa",
				Name = "Rotary Club of Lockerbie and District",
				LookupId = "8-10280730",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d13ee3c4-2954-4912-bf13-fccafa4666cb",
				Name = "Rotary Club of Cardiff Breakfast",
				LookupId = "8-10280732",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "375d3300-cc31-477e-ac6c-cd53161689e5",
				Name = "Rotary Club of Bingley Airedale",
				LookupId = "8-10280733",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "194da208-4fdc-42b6-a521-b5a0248955da",
				Name = "Rotary Club of Laurencekirk & District",
				LookupId = "8-10280737",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "697ab91c-f28d-46c1-8f8b-123aaca5ab6c",
				Name = "Inner Wheel Club of Crompton & Royton",
				LookupId = "8-10280739",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2d95de99-fedf-44bb-8d3f-49eaff060b26",
				Name = "Rotary Club of Aberdeen Balgownie",
				LookupId = "8-10280741",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "55bd2b86-d4a6-401a-ad6e-d72c39664535",
				Name = "Rotary Club of Aldridge",
				LookupId = "8-10280743",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "98453ab5-9c53-45c9-a05d-ade5606253e3",
				Name = "Inner Wheel Club of Burnham",
				LookupId = "8-10280746",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "35906d85-1ad6-441f-8c69-22726a35736e",
				Name = "Rotary Club of South Foreland",
				LookupId = "8-10280748",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cef3eb54-752b-4a98-aa8d-2d7c92524b63",
				Name = "Rotary Club of Mid Argyll",
				LookupId = "8-10280749",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "266fe61f-a8a2-48e7-9301-826a4a493c8c",
				Name = "Rotary Club of Exe Valley (Tiverton)",
				LookupId = "8-10280765",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "48c1dce2-8522-40d0-b56e-d58d1c6f31fd",
				Name = "Rotary Club of Enniskillen",
				LookupId = "8-10280766",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ed849b06-ad21-4924-a453-15c7ab30bdad",
				Name = "Rotary Club of Bangor Gwynedd",
				LookupId = "8-10280773",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec17b14a-353b-435f-91ec-24df5d62d834",
				Name = "Rotary Club of Guernesiais",
				LookupId = "8-10280780",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "21b63238-801b-406e-bdbd-30bf4a4bc261",
				Name = "Inner Wheel Club of Reading Maiden Erlegh",
				LookupId = "8-10280782",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0a2c1ad3-7c8b-4b36-93c6-1e6401d06916",
				Name = "Inner Wheel Club of Wrexham Erddig",
				LookupId = "8-10280784",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "81eacc2c-83ae-4b91-a409-53c2cb797f41",
				Name = "Rotary Club of Eastwood",
				LookupId = "8-10280785",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c9d283e6-bb1c-49ca-9934-915beff18d4a",
				Name = "Rotary Club of Gloucester Severn",
				LookupId = "8-10280787",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ba52e194-096f-4d48-9ecc-a4447302f46e",
				Name = "Rotary Club of Wiveliscombe & District",
				LookupId = "8-10280791",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e641c78a-9644-4275-9b16-a5051d6bc0b6",
				Name = "Rotary Club of Redditch Kingfisher",
				LookupId = "8-10280795",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f4b4603f-ac73-4daf-88a4-bcdc65b9cac4",
				Name = "Rotary Club of Clent Hills",
				LookupId = "8-10280803",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4cbf7930-c3a6-4842-babf-44a2f6c8ca0f",
				Name = "Rotary Club of Biddulph",
				LookupId = "8-10280819",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85b02163-53b4-4a56-9058-81a48f65ed3b",
				Name = "Rotary Club of Totnes",
				LookupId = "8-10280820",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2929ca73-d645-45d4-aeb7-083239dd4f37",
				Name = "Inner Wheel Club of Godalming",
				LookupId = "8-10280823",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "75f1d18d-449b-4de3-b658-e08bb9465f9b",
				Name = "Inner Wheel Club of Frodsham & Helsby",
				LookupId = "8-10280829",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3fc67332-d2f0-4f63-99b7-589ba711a9a8",
				Name = "Rotary Club of Berwick-Upon-Tweed",
				LookupId = "8-10280832",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "31c9edad-1402-45bb-bc89-f628022f816b",
				Name = "Rotary Club of Bromley",
				LookupId = "8-10280833",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0abcd325-e0b8-453f-8221-b54385740275",
				Name = "Rotary Club of Longniddry & District",
				LookupId = "8-10280836",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "51f7c47a-a588-4969-aa5e-7c21a289c67d",
				Name = "Interact Club of Tendring Technology College",
				LookupId = "8-10280842",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b0ac39ac-8655-4ca8-809c-b835ccd0bf49",
				Name = "Inner Wheel Club of Wakefield",
				LookupId = "8-10280843",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1a3f93a7-582f-40c3-80ef-8502023f0395",
				Name = "Inner Wheel Club of Auchterarder & District",
				LookupId = "8-10280930",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ba2b8d2c-2cdc-436e-859c-e48be9dc5f6a",
				Name = "Inner Wheel Club of Port Talbot",
				LookupId = "8-10281040",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "965ee575-3558-4b19-bc32-cc631b947905",
				Name = "Rotary Club of Belfast East",
				LookupId = "8-10281042",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2a5bc149-a562-46e6-b425-2919c782df08",
				Name = "Rotary Club of Hadleigh",
				LookupId = "8-10281044",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c3143baa-4164-4dc7-9b67-d294734dfb0e",
				Name = "Rotary Club Of Backwell And Nailsea",
				LookupId = "8-10281045",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b6980d6c-f23c-4ee9-a4f2-04dd1f8b42d9",
				Name = "Rotary Club of Bolton Daybreak",
				LookupId = "8-10281046",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7d1c169e-77a6-4704-9c59-763ee3f5d282",
				Name = "Rotary Club of Glasgow North & Bishopbriggs",
				LookupId = "8-10281047",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8fb9e0e3-1f42-431f-a5cf-3624c64419b6",
				Name = "Rotary Club of Kings Hill Kent",
				LookupId = "8-10281050",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e29d0fd2-8c7c-44c5-bfed-1949ab920a8f",
				Name = "Rotary Club of Fishponds & Downend, Bristol",
				LookupId = "8-10281051",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "227d1e6b-64bf-4721-bb4e-2b08e9adbcf5",
				Name = "Rotary Club of Wreake Valley",
				LookupId = "8-10281054",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "410e74a1-ce72-426e-8a2f-c0e8001976fc",
				Name = "Rotary Club of Stevenage",
				LookupId = "8-10281067",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8a9b7870-273b-4fd4-a561-217e9092b214",
				Name = "Rotary Club of Killarney",
				LookupId = "8-10281068",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85f1dcf8-97fb-486f-8127-ad1464ab0156",
				Name = "Rotary Club of Walsall Saddlers",
				LookupId = "8-10281081",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2e8ae043-fd1e-47cf-ae77-c50b347b27d5",
				Name = "Rotary Club of Grantham Kesteven",
				LookupId = "8-10281103",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4ff8c218-83ad-4250-90d9-6cd2848fd209",
				Name = "Rotary Club of Morley",
				LookupId = "8-10281104",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6d0e6c95-c4e5-4e34-94a4-01638dabae83",
				Name = "Rotary Club of Northwick Park",
				LookupId = "8-10281105",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "61264ccb-f17a-4809-a564-19de4a99c6ba",
				Name = "Rotary Club of Chester",
				LookupId = "8-10281108",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0d626674-2c4e-4d18-9c29-030ac349da97",
				Name = "Rotary Club of Falkirk",
				LookupId = "8-10281114",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f0234ea1-cda0-402a-9e60-50fa4bb8a272",
				Name = "Inner Wheel Club of Wolverton",
				LookupId = "8-10281118",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ac34a5b2-a640-4c7e-a5cf-e27c29d2587c",
				Name = "Rotary Club of Jedburgh",
				LookupId = "8-10281119",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0dc03fba-30a4-41ca-828c-983dc626a442",
				Name = "Rotary Club of Cookham Bridge",
				LookupId = "8-10281128",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "21a7c427-cbdf-4833-a50b-9acfae30f7ee",
				Name = "Rotary Club of Oswestry Borderland",
				LookupId = "8-10281129",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1de69474-8b6d-4f9a-9c7c-00e70eeee72b",
				Name = "Inner Wheel Club of Penryn",
				LookupId = "8-10281132",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1ad143b3-ff99-4bbe-bbed-31ad298e4f55",
				Name = "Rotary Club of Ramsey, Cambridgeshire",
				LookupId = "8-10281133",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9e61fefe-db34-468e-8290-be545e027999",
				Name = "Rotary Club of Blackburn & District",
				LookupId = "8-10281135",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e6b98c67-81cd-4ec8-a707-34cc902de6e0",
				Name = "Interact Club of Bexley",
				LookupId = "8-10281138",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "052bffbb-adac-4b3c-bf66-f1623d38eab5",
				Name = "Rotary Club Of Cheam & Sutton",
				LookupId = "8-10281141",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b76794ae-bc63-4ec2-9b57-634fc156e9a4",
				Name = "Rotary Club of Morden",
				LookupId = "8-10281143",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d4968982-ca70-462d-80c6-c1f87b710fdd",
				Name = "Inner Wheel Club of Stratford-Upon-Avon",
				LookupId = "8-10281144",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2c5d4817-298b-442a-81ce-5c1308223045",
				Name = "Rotary Club of Aberdare",
				LookupId = "8-10281151",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9f8e7a5e-ef29-4dc6-95ad-4a5eb673f603",
				Name = "Inner Wheel Club of Wantage",
				LookupId = "8-10281153",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "855bc56c-32cf-4560-b270-21b15d527c78",
				Name = "Rotary Club of Tunbridge Wells",
				LookupId = "8-10281157",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e96f244f-28f4-4dfc-817d-81d782623c4f",
				Name = "Rotary Club Of Wrexham Yale",
				LookupId = "8-10281158",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7fab0c59-5ac0-41dc-a90c-0efe359ddc15",
				Name = "Inner Wheel Club of Rayleigh Mill",
				LookupId = "8-10281165",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3dcdcde9-e52c-4b0c-82a8-4074eb39ff03",
				Name = "Rotary Club of Epping Forest",
				LookupId = "8-10281167",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "78525094-2625-4f14-a15c-08bcd9985651",
				Name = "Inner Wheel Club of Gravesend",
				LookupId = "8-10281168",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6faa899c-78f2-4bfa-b846-42530ac8d7f5",
				Name = "Rotary Club of London",
				LookupId = "8-10281203",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dadf3a7e-b0c6-4082-8234-22d175765d5a",
				Name = "Rotary Club of Mirfield",
				LookupId = "8-10281204",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1c70e442-2600-439e-b14a-c7ff9545d91b",
				Name = "Rotary Club of Pontypool",
				LookupId = "8-10281209",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "184dfe23-bbe4-4d4f-8d37-acf81c57130f",
				Name = "Rotary Club of Verwood",
				LookupId = "8-10281211",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "716f3040-a6c6-4cc0-8c63-32907239fa5c",
				Name = "Rotary Club of Clacton Jubilee",
				LookupId = "8-10281212",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6a7e073b-cea0-4ef0-9d26-065b4dddbc0a",
				Name = "Rotary Club of Tyneside",
				LookupId = "8-10281213",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e841a5cf-5603-49ab-9a37-9a05e55a5fd8",
				Name = "Inner Wheel Club of Doncaster St Leger",
				LookupId = "8-10281214",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "04a273d7-1b7d-4d71-971c-724d82445e07",
				Name = "Rotary Club of Lagan Valley",
				LookupId = "8-10281217",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6cddd617-1e25-40bb-bb09-747b58e73927",
				Name = "Rotary Club of Chesterfield Scarsdale",
				LookupId = "8-10281220",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f4193040-b47f-426c-b7b8-939c9e99469b",
				Name = "Rotary Club of Vale Of Belvoir",
				LookupId = "8-10281221",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b3f205a8-684a-4c4d-8015-88c27f1bf672",
				Name = "Rotary Club of Huntingdon",
				LookupId = "8-10281222",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ef6369e1-8878-41e4-8d4f-a7624e82fcf7",
				Name = "Rotary Club of St. Marylebone",
				LookupId = "8-10281224",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7e25dc90-a59d-4cb5-ae02-4a44b40acfe4",
				Name = "Rotary Club of Thame and District",
				LookupId = "8-10281225",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a9f4be71-6221-476b-a49a-5365ec31fd00",
				Name = "Rotary Club of Didcot",
				LookupId = "8-10281230",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "50211f85-0299-453f-ac7a-5ee64e2adc62",
				Name = "Rotary Club of Alloa",
				LookupId = "8-10281231",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "996e00dc-bd67-404b-8d8e-d8ce009f0b36",
				Name = "Rotary Club of Ross-On-Wye",
				LookupId = "8-10281245",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e28321f3-66b4-4450-981c-cb56f8a3f612",
				Name = "Rotary Club of Sandown",
				LookupId = "8-10281246",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3998b80b-ca7c-4d61-92aa-e4a9f1a0b45e",
				Name = "Rotary Club of Ravensbourne",
				LookupId = "8-10281261",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "81d9c59f-4517-40c2-98ac-44a24860655d",
				Name = "Inner Wheel Club of York",
				LookupId = "8-10281263",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec21c3df-ed1d-4ab0-8269-8f4b083576aa",
				Name = "Rotary Club Of Bolsover",
				LookupId = "8-10281268",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "da33b831-16b4-439d-ac88-e0fb4db866ee",
				Name = "Rotary Club of Brixham",
				LookupId = "8-10281269",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "604471a8-5811-454b-8777-ac60664d5048",
				Name = "Rotary Club of Knaresborough",
				LookupId = "8-10281270",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d9f0c26c-89df-4bac-a70b-5e6eea95e0f7",
				Name = "Rotary Club of Sussex Vale",
				LookupId = "8-10281273",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "795fb9c5-b8ee-4158-b364-c288e407151f",
				Name = "Rotary Club of Truro Boscawen",
				LookupId = "8-10281278",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "774b4d54-31c9-4ce2-9bab-0f4933afce5d",
				Name = "Rotary Club of Walsall",
				LookupId = "8-10281279",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b43a2089-c094-4f07-90e7-899bc67e52b8",
				Name = "Rotary Club of Abingdon Vesper",
				LookupId = "8-10281282",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "85e338c7-bc84-424d-a913-3b4b57eb416a",
				Name = "Inner Wheel Club of Colchester Forum",
				LookupId = "8-10281283",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8bf619e9-8204-43f9-8e29-7e3353f7f9dc",
				Name = "Rotary Club of Locks Heath",
				LookupId = "8-10281308",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7c7eec25-5ad6-4091-aeca-71c15318563a",
				Name = "Inner Wheel Club of Wednesbury",
				LookupId = "8-10281311",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "350d4bf0-9226-44a1-8003-a09a0ffac90e",
				Name = "Rotary Club of Wylde Green",
				LookupId = "8-10281330",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e97f0810-a355-46e8-892f-dab528666a48",
				Name = "Rotary Club Of Preston Torbay",
				LookupId = "8-10281348",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6952ceb2-20b1-4cd7-a808-ff318dd2d44c",
				Name = "Interact Club of Maesydderwen School",
				LookupId = "8-10281357",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0a57e493-df34-4589-bb02-5a82a0458416",
				Name = "Rotary Club of Godalming Woolsack",
				LookupId = "8-10281364",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ca36753a-f7fd-4d6e-b522-c12d201691a9",
				Name = "Rotary Club of Harrogate",
				LookupId = "8-10281365",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9366fbf9-1f31-40c2-bf4e-0b85d1e47753",
				Name = "Inner Wheel Club of Wellington (Somerset)",
				LookupId = "8-10281366",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a295c3ab-852c-40bd-a804-17740cdcff8c",
				Name = "Rotary Club of Ipswich",
				LookupId = "8-10281367",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3b9c87de-3d87-4bf1-8e1c-00949b629d4f",
				Name = "Rotary Club of Limerick Shannon",
				LookupId = "8-10281372",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c2e0ea30-46ab-4f75-9eb9-d1b1a1c88eb8",
				Name = "Rotary Club of Colchester Forum",
				LookupId = "8-10281376",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9cc65640-1d45-4baa-ad8a-69dfc07c4ed6",
				Name = "Rotary Club of Troon",
				LookupId = "8-10281377",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d885e297-7587-47d5-bcec-c4bbf354e2eb",
				Name = "Rotary Club of Upper Eden",
				LookupId = "8-10281378",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "80c5d966-843f-478e-8618-ad513f23b607",
				Name = "Inner Wheel Club of Montrose",
				LookupId = "8-10281383",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "af773880-1762-493b-9a01-e70ad725933d",
				Name = "Rotary Club of Cambridge Sawston",
				LookupId = "8-10281395",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5c931468-9cc3-48c3-a019-be780ec00806",
				Name = "Inner Wheel Club of Rhyl",
				LookupId = "8-10281397",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "57a3e08e-bea7-4950-8418-18bc338e527c",
				Name = "Rotary Club of Rutherglen",
				LookupId = "8-10281398",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2906d56a-b168-44b5-a819-1b3fd60aece8",
				Name = "Rotary Club of Leven",
				LookupId = "8-10281399",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "46ac8a96-e07f-4899-88ab-1f2bdeea12f6",
				Name = "Rotary Club of Exeter Southernhay",
				LookupId = "8-10281404",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c9293655-be95-4446-bf3e-e625b4d477c1",
				Name = "Rotary Club of Sheffield",
				LookupId = "8-10281405",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "12597235-c152-4cbb-8b14-c375863cde3f",
				Name = "Rotary Club of Mumbles",
				LookupId = "8-10281413",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec985db3-f315-4f20-99f8-e7956d3e6e84",
				Name = "Inner Wheel Club of Totnes",
				LookupId = "8-10281430",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "acc3f6e8-4d9e-41ff-8cd5-68fbe84053c1",
				Name = "Rotary District 1030",
				LookupId = "8-10281446",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3efa9591-7021-4d22-8045-95a135a24f24",
				Name = "Rotary Club of Bretby",
				LookupId = "8-10281447",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a9d27212-537e-449b-bb52-ea5f2d3b01cc",
				Name = "Rotary Club of Kingswood (Bristol)",
				LookupId = "8-10281448",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6731e020-e23d-4131-ae73-7791115b685e",
				Name = "Rotary Club of Lochaber",
				LookupId = "8-10281449",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9e7e173f-991e-45dc-8050-bfd2532811b1",
				Name = "Rotary Club of Lytham",
				LookupId = "8-10281450",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c57dae48-dae4-43aa-a46c-734581f6f883",
				Name = "Rotary Club of Cwmbran Vale",
				LookupId = "8-10281457",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "836bf73c-d5b3-461a-8f6a-ddf217a2a9f6",
				Name = "Rotary District 1320",
				LookupId = "8-10281463",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "037e7a5d-eceb-4624-aa3c-3a3ea3aa0c2d",
				Name = "Rotary Club of Rhondda",
				LookupId = "8-10281469",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3f73c0b0-113c-4d81-a85d-1daf837b4b60",
				Name = "Inner Wheel Club of Chester",
				LookupId = "8-10281486",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec1170ca-4f2f-4f2a-9995-44d37bdc0079",
				Name = "Rotary Club of Stranraer",
				LookupId = "8-10281488",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1fd6995c-43f0-4473-9db5-367fa585ed9c",
				Name = "Rotary Club of Preston South",
				LookupId = "8-10281490",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7d1da5f3-ec98-4e48-9a2f-26d0c3201526",
				Name = "Rotary Club of Rugby Dunsmore",
				LookupId = "8-10281491",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9ba34e0a-a1fa-4114-ab9b-894ce74fa6fc",
				Name = "Rotary Club of Melton Mowbray Belvoir",
				LookupId = "8-10281503",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "79f2cb94-93fd-4cf8-8f14-4175333dbfda",
				Name = "Inner Wheel Club of Kingston-Upon-Thames",
				LookupId = "8-10281505",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b78a11ef-d8aa-4fcb-a24e-036dad85a204",
				Name = "Rotary Club of Yatton",
				LookupId = "8-10281509",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2ecefaff-5e16-4529-9fbf-7a7a0ea0e6c5",
				Name = "Rotary District 1130",
				LookupId = "8-10281510",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0122ea03-c82a-45c9-8505-93309ba4f8ec",
				Name = "Rotary Club of Bletchley",
				LookupId = "8-10281511",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "11ac270e-473d-42c7-bf78-9e7ee31015a8",
				Name = "Rotary Club of Chippenham Wiltshire Vale",
				LookupId = "8-10281512",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5e484f47-1ac3-4ca9-a148-010ffee4a388",
				Name = "Rotary Club of Tewkesbury",
				LookupId = "8-10281513",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2e45a496-fbdc-479d-8391-6d4d04920b08",
				Name = "Inner Wheel Club of Omagh",
				LookupId = "8-10281517",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "17f5cd89-49a0-43b9-b571-df769b393a22",
				Name = "Rotary Club of Peterborough",
				LookupId = "8-10281533",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7ec056b4-667f-4577-a514-b76a7f2c3728",
				Name = "Rotary Club Of Potters Bar",
				LookupId = "8-10281534",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "08cdaaa2-27ea-4671-9ea1-32f0340d777b",
				Name = "Rotary Club of Bala & Penllyn",
				LookupId = "8-10281535",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "79707752-2116-4a4a-83a4-b8c0c5989061",
				Name = "Inner Wheel Club of Rutherglen",
				LookupId = "8-10281547",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8c5695ae-fe48-4973-8a19-7620531adce7",
				Name = "Inner Wheel Club of Barnstaple",
				LookupId = "8-10281639",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6f2906af-494a-444f-a792-1f8fe7c4f72c",
				Name = "Rotary Club of Rhyl",
				LookupId = "8-10281642",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "95077bff-de1a-4f02-9d2b-eecef7deeb2a",
				Name = "Rotary Club of Braunton Caen",
				LookupId = "8-10281643",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4440cc3d-5183-4797-9db0-3bc7ae654573",
				Name = "Rotary Club of Loughborough Beacon",
				LookupId = "8-10281645",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "efad04c0-d632-4453-acac-c435fbb86d9f",
				Name = "Rotary Club of Heybridge Blackwater",
				LookupId = "8-10281718",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "41d6759b-d888-461c-9cbb-76a5e4f5b2c3",
				Name = "Rotary Club of Hitchin",
				LookupId = "8-10281721",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c2db3d87-08e3-4960-ba34-5169c706454f",
				Name = "Rotary Club of Penrith",
				LookupId = "8-10281739",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fe74c716-a02b-45c9-94d8-7b530a8d5890",
				Name = "Inner Wheel Club of Redruth",
				LookupId = "8-10281740",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9612c3e0-ad88-43a8-a95e-3bfb177f74b0",
				Name = "Rotary Club of Swindon",
				LookupId = "8-10281742",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4c7ce98a-3bec-42f4-a7e8-20917b41714f",
				Name = "Inner Wheel Club of Winchester",
				LookupId = "8-10281746",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2b5f2914-f5c6-44cd-afa3-4ef43ef0f0d9",
				Name = "Rotary Club of Ashtead",
				LookupId = "8-10281757",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3d78184a-2ca6-4f93-b63c-48a3d29d6dbd",
				Name = "Rotary Club of Sherborne Castles",
				LookupId = "8-10281771",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "25a21e10-26f9-4ae1-a728-0a0c633f0da0",
				Name = "Inner Wheel Club of Newtown",
				LookupId = "8-10281794",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a1706275-3a70-4d39-8ae3-1ab95cb0ab14",
				Name = "Rotary Club of Headingley (Leeds)",
				LookupId = "8-10281797",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e2626684-22fb-4cd6-9e0e-f94a1fef6b15",
				Name = "Inner Wheel Club of Watton",
				LookupId = "8-10281798",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aa3bd8a9-d464-4734-b6bc-94504bf87a41",
				Name = "Inner Wheel Club of Crossgates",
				LookupId = "8-10281804",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9c9da46e-26e5-40bf-a404-245d9bdc57c5",
				Name = "Rotary Club of Abingdon",
				LookupId = "8-10281805",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c1bb5b25-60e7-40ab-9bca-84fc3ab07505",
				Name = "Rotary Club of Wareham",
				LookupId = "8-10281806",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ba8c6e24-bf2c-4c5b-bcb3-f00fa9ef858f",
				Name = "Rotary Club of Westbury",
				LookupId = "8-10281807",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "40600268-8021-41ff-a852-a48e315107b0",
				Name = "Inner Wheel Club of Chester: Chapter & Verse",
				LookupId = "8-10281813",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "63bae896-cea1-42bc-88a4-be12acc1a074",
				Name = "Rotary Club of Burton Upon Trent",
				LookupId = "8-10281814",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "58df790f-77a7-40d6-9140-0a7b3645c907",
				Name = "Inner Wheel Club of Portadown",
				LookupId = "8-10281817",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5c8c87c6-819f-4b5b-a423-732368a51f3a",
				Name = "Rotary Club of Crediton Boniface",
				LookupId = "8-10281842",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7e21567a-3a41-4c7e-85ed-647eb7e2a5d8",
				Name = "Rotary Club of Worsley",
				LookupId = "8-10281843",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "74d937f9-d0fd-4ad8-9dfc-ec03f498d1dd",
				Name = "Rotary Club of South Queensferry",
				LookupId = "8-10281845",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e6c6bf3d-a165-435f-8fbb-c13950e07764",
				Name = "Rotary Club of Ealing, Hanwell and Northfields",
				LookupId = "8-10281867",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b76092de-989e-4643-aa04-8ddd59e310d4",
				Name = "Rotary Club of Ribblesdale",
				LookupId = "8-10281870",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "69f019d3-8de7-4300-9dc5-798e2ac235ac",
				Name = "Rotary Club of Thornbury",
				LookupId = "8-10281877",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8850f205-d8e8-42dc-9e87-03f38fa8a923",
				Name = "Inner Wheel Club of Kettering Huxloe",
				LookupId = "8-10281896",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "15fb2ad3-5a45-46b2-9a29-a2287af9bd8a",
				Name = "Inner Wheel Club of Droitwich Spa",
				LookupId = "8-10281899",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ef95d7cc-8474-4f8c-a5d2-ebf465f88cb8",
				Name = "Rotary Club Of St Austell",
				LookupId = "8-10281933",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b7720d5e-ca60-4189-a300-51ed4701a9ef",
				Name = "Rotary Club of Stevenage Grange",
				LookupId = "8-10281934",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "250d5dda-60c2-4941-a4fa-6fe6574d127f",
				Name = "Inner Wheel Club of Walsall",
				LookupId = "8-10281945",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3007f99e-b8cd-44e1-a5e7-4123b876efb1",
				Name = "Rotary Club of Kenilworth",
				LookupId = "8-10281953",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "82f8640f-fa8b-4c73-8c1b-6eb0a3522ebc",
				Name = "Rotary Club of Stoke-on-Trent",
				LookupId = "8-10281960",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b61b1a60-4e8d-4c25-b00b-f2716d5e6c7e",
				Name = "Rotary Club of Staines",
				LookupId = "8-10281961",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4eb90b26-2e6b-432d-8773-e6a2b5f77441",
				Name = "Rotary Club Of St Austell Bay",
				LookupId = "8-10281962",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b30bb6a3-b613-4d20-be54-095daea8198c",
				Name = "Rotary Club of Lostwithiel",
				LookupId = "8-10281963",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bb9997c3-c7c2-4322-ae4a-fd758eae77aa",
				Name = "Rotary Club of Brighton & Hove Soiree",
				LookupId = "8-10281980",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bf68d9e9-7435-45d8-8c1f-7adc2ee725d0",
				Name = "Rotary Club of Hart",
				LookupId = "8-10281981",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e4740a39-7f70-4132-a9a4-79d45ce44c0e",
				Name = "Rotary Club of Hinckley",
				LookupId = "8-10281983",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "56483f6c-2069-4e6b-9e44-0fa9e80d1a37",
				Name = "Inner Wheel Club of Ruthin",
				LookupId = "8-10281986",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c840528f-9928-4ba6-8900-f3eeef44f5b9",
				Name = "Rotary Club of Whittlesey",
				LookupId = "8-10281996",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "56aa268a-7586-4f41-a63e-1b88b1052871",
				Name = "Inner Wheel Club of Gloucester",
				LookupId = "8-10282002",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3da1f8fa-7015-47e9-abfb-5836793cfc90",
				Name = "Inner Wheel Club of Motherwell & Wishaw",
				LookupId = "8-10282007",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f01f5901-a7b6-49a2-b29a-338841e41455",
				Name = "Rotary Club of Ilkley",
				LookupId = "8-10282016",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0a1eac04-3115-4edc-8a55-ebfc1460c601",
				Name = "Inner Wheel Club of Stroud",
				LookupId = "8-10282018",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "52bbfefd-36f8-410c-a239-63f2adf9c749",
				Name = "Rotary Club Of Nene Valley",
				LookupId = "8-10282103",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3df31a98-5806-409a-9d1d-7cca3aae1692",
				Name = "Rotary Club of Watford",
				LookupId = "8-10282105",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fa6803da-c4e3-47ad-9f20-d0ca7dd14dfc",
				Name = "Rotary Club of Wrexham",
				LookupId = "8-10282106",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "16018880-3fa9-416e-88fe-2935350e4b0f",
				Name = "Rotary Club of Eastbourne",
				LookupId = "8-10282110",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f2f1ff2f-4857-4b42-946c-a24a74d9b7c7",
				Name = "Rotary Club of Roundhay (Leeds)",
				LookupId = "8-10282112",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9087582f-21ba-42e9-8081-055e848b4bb0",
				Name = "Rotary Club of Bradford Bronte",
				LookupId = "8-10282116",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eaa5e1d2-b3dd-4f95-bf89-df471086bb1d",
				Name = "Inner Wheel Club of Dover",
				LookupId = "8-10282118",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6e28ea63-9282-441f-a78d-25123e080cb3",
				Name = "Rotary Club of Dundee",
				LookupId = "8-10282120",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0d25c162-39b3-4161-9208-1f67df08dc6d",
				Name = "Interact Club of Ramsbottom",
				LookupId = "8-10282131",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a85bc163-b603-4476-b924-b0eef1016bdf",
				Name = "Rotary Club of Guernsey",
				LookupId = "8-10282157",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d0f52848-7cbb-4c35-ba0d-77be418a2a83",
				Name = "Rotary Club of Leigh On Sea",
				LookupId = "8-10282170",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c8f26776-1f09-4287-87b0-2a8f905d8217",
				Name = "Rotary Club of Wakefield",
				LookupId = "8-10282179",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "63296bd8-c67a-404e-8d1c-1653c598eea2",
				Name = "Rotary Club of Wednesbury",
				LookupId = "8-10282180",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "195f6822-d1f5-4588-8268-2b9538619a47",
				Name = "Rotary Club of Bishop Auckland",
				LookupId = "8-10282262",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "58e04ed0-c899-43ad-8264-0befffb98efb",
				Name = "Rotary Club of Denby Dale & District",
				LookupId = "8-10282343",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "491f7044-8c01-4060-862b-aef3bfed3772",
				Name = "Inner Wheel Club of Dublin/Limerick & Shannon/Waterford",
				LookupId = "8-10282346",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9b53318c-fcb1-453c-a049-6ce08f8401af",
				Name = "Rotary Club of Belper and Duffield",
				LookupId = "8-10282347",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "143f9efd-b9ad-4fc2-81db-fab78cdd7468",
				Name = "Rotary District 1200",
				LookupId = "8-10282349",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9cbc5134-0ca5-4bdd-8cec-ba1b4bfd7566",
				Name = "Rotary Club of Frinton-On-Sea",
				LookupId = "8-10282350",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ee0672af-86c2-471a-9d15-c70092d1c083",
				Name = "Rotary Club of Blaby Meridian",
				LookupId = "8-10282352",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "13b98da5-b3ba-4186-85bc-0c0168dd0503",
				Name = "Rotary Club of Pwllheli",
				LookupId = "8-10282369",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8864028f-5c57-48e8-8e3a-dcea93590bc7",
				Name = "Rotary Club of Stourbridge",
				LookupId = "8-10282373",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "18b12b0a-2199-4560-941b-fb5fbabf5793",
				Name = "Inner Wheel Club of Belfast",
				LookupId = "8-10282397",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "33efd93b-7109-461d-8eb8-f76fb18ac33e",
				Name = "Rotary Club of Billericay",
				LookupId = "8-10282398",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f115aeae-6d78-4f0d-90a4-2a1827430731",
				Name = "Rotary Club of Newark",
				LookupId = "8-10282403",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d60b2108-39f7-4679-b431-e8bd62e6b077",
				Name = "Inner Wheel Club of Shirley",
				LookupId = "8-10282406",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6337f0ce-82b3-40d4-9c25-ab43061a8d05",
				Name = "Inner Wheel District 20",
				LookupId = "8-10282415",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e0d7d4e5-3b88-46fc-aaa6-30e94ced88fb",
				Name = "Rotary Club of Edmonton",
				LookupId = "8-10282416",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2350cb7e-cade-45a8-8933-4388a4b53e01",
				Name = "Rotary Club of Oxford Isis",
				LookupId = "8-10282417",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "33f1ca05-6607-48eb-bd0b-46adbcd8fc06",
				Name = "Inner Wheel Club of Loughborough",
				LookupId = "8-10282419",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d748bd61-cf9d-4c5a-8024-aec10589ca86",
				Name = "Inner Wheel Club of Long Eaton",
				LookupId = "8-10282605",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b0b71bbf-7daf-4e76-91e4-6d2bff0162ca",
				Name = "Rotary Club of Wembley",
				LookupId = "8-10282608",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4c900da7-4f77-47fd-8962-eab0b8876171",
				Name = "Inner Wheel Club of Pitlochry",
				LookupId = "8-10282626",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dd0a7472-d11b-4f6c-8675-6b9beca36c74",
				Name = "Rotary Club of Chippenham",
				LookupId = "8-10282627",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c2edc22d-64be-443f-acf9-01f91c4cbbf4",
				Name = "Rotary Club of Sutton Nonsuch",
				LookupId = "8-10282628",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "383736a1-56aa-4d70-b42d-8f0e654e383a",
				Name = "Rotary Club of Golders Green",
				LookupId = "8-10282629",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ed77c8d5-3697-4d79-a59e-f8f41dc1eaa2",
				Name = "Rotary Club of Lutterworth",
				LookupId = "8-10282630",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0046c3df-dc9e-4f33-a2c5-839fa5a92e07",
				Name = "Rotary Club of Woking",
				LookupId = "8-10282633",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dda0f4c5-b273-4ad8-aa7e-ad2856abfb29",
				Name = "Inner Wheel Club of Falmouth",
				LookupId = "8-10282634",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "484556f6-c860-4560-80ba-f81c9cd4f41c",
				Name = "Rotary Club of Sunderland",
				LookupId = "8-10282636",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0485734c-7fbf-4754-bd45-e2dab3951144",
				Name = "Rotary Club of Derby",
				LookupId = "8-10282639",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aa3426ab-3325-49c8-8a1c-cc9b502f91e7",
				Name = "Rotary Club of Worksop",
				LookupId = "8-10282640",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "22851689-1ad0-4c54-a2f3-5653fd1aa01d",
				Name = "Rotary Club of Babbacombe & St. Marychurch",
				LookupId = "8-10282646",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d37f40df-2925-4775-a68a-8a3f2a185285",
				Name = "Rotary Club of Conwy",
				LookupId = "8-10282650",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eb27556c-1be2-4bf7-b2ca-4c51a040e4a6",
				Name = "Inner Wheel Club of Reading",
				LookupId = "8-10282656",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d90af66c-4e9e-490d-90e8-15dc4f66fb21",
				Name = "Rotary Club of Radcliffe",
				LookupId = "8-10282659",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "43a895fd-1727-4c96-9c7c-bdb013899287",
				Name = "Rotary Club of Shipley",
				LookupId = "8-10282660",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "644ad96c-7253-4a6e-8f24-5bc06c0ece57",
				Name = "Inner Wheel Club of Tiverton",
				LookupId = "8-10282661",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f6cd10bb-0266-494b-9548-a2ab57c44bd0",
				Name = "Rotary Club of Bideford Bridge",
				LookupId = "8-10282666",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4c977180-c444-4522-b6fa-a6f498091ed0",
				Name = "Rotary Club of Newport Uskmouth",
				LookupId = "8-10282670",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "972759bc-5ca0-48c8-be16-d12c6d1eb740",
				Name = "Rotary Club of Sawbridgeworth & District",
				LookupId = "8-10282671",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e6f4b8ad-e733-40ad-a23c-b5e873c2ac6f",
				Name = "Rotary Club of Chelmsford",
				LookupId = "8-10282682",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5ff397e3-fe1c-4ed6-bebc-8fec08b83d1b",
				Name = "Rotary Club of Lanark",
				LookupId = "8-10282685",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9983687d-6366-4da8-8076-b95f6f24c5e1",
				Name = "Rotary Club of Fordingbridge",
				LookupId = "8-10282691",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9f5d212f-39bc-45e4-8560-faa334fbe4c4",
				Name = "Rotary Club of Kings Lynn Trinity",
				LookupId = "8-10282694",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fd14c7ec-5b97-461b-8813-15de4fed2680",
				Name = "Rotary Club of Colchester Centurion",
				LookupId = "8-10282695",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "08b1ba4b-2470-4b51-af9a-592e33e1535b",
				Name = "Inner Wheel Club of Tyldesley",
				LookupId = "8-10282702",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "afdd3f84-60b8-4551-aae0-458a284001cc",
				Name = "Rotary Club of Wensleydale",
				LookupId = "8-10282712",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "72be5425-5cd7-4ee0-a6fa-38d55c51789b",
				Name = "Rotary Club of Oldham Metro",
				LookupId = "8-10282713",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "018ff252-494b-493f-8128-ac991ede573e",
				Name = "Rotary Club of Parkstone",
				LookupId = "8-10282714",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0adbda02-3349-48b4-905d-169d30be33cf",
				Name = "Inner Wheel Club Of Clacton On Sea",
				LookupId = "8-10282717",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1a1370c6-a39d-47da-948d-f5477679ebb0",
				Name = "Inner Wheel Club of Prestatyn",
				LookupId = "8-10282727",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ffe27fd6-a061-4a4c-b42d-75f7518cbe76",
				Name = "Rotary Club of Bedford",
				LookupId = "8-10282736",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "abf3a639-8920-4032-8fa3-3b6517653ccb",
				Name = "Rotary Club of Esk Valley",
				LookupId = "8-10282739",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2e01b348-385e-4db3-b7b0-6d5b70a017ad",
				Name = "Rotary Club of Blandford",
				LookupId = "8-10282740",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e4896c43-d9cb-4421-a934-7f3469e7a38a",
				Name = "Rotary Club of Wakefield Chantry",
				LookupId = "8-10282744",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "edd55afd-cba1-49db-ad93-0954da93c9e8",
				Name = "Rotary Club of Woodbridge",
				LookupId = "8-10282745",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c631ef15-e0ba-4ee9-88ad-002eef7642a3",
				Name = "Rotary Club of Marlow Thames",
				LookupId = "8-10282748",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "07cc0360-657a-475a-a2ef-49a69a7581b8",
				Name = "Rotary Club of North Norfolk",
				LookupId = "8-10282749",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0d37be34-bbff-45f2-a6ea-45daa4d23888",
				Name = "Inner Wheel Club of Hitchin",
				LookupId = "8-10282750",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "731eb402-2c35-4454-9937-609edf2e0c9a",
				Name = "Inner Wheel Club of Bathavon",
				LookupId = "8-10282760",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d9f6f0f7-6488-4b7d-b48b-17782cb679fe",
				Name = "Rotary Club of Rochdale",
				LookupId = "8-10282768",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bd73f497-236a-4761-af7e-20dd270cb74f",
				Name = "Inner Wheel Club of Swinton & Pendlebury",
				LookupId = "8-10282775",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8e8fd02d-447f-4a35-98a8-847f6c2c05fb",
				Name = "Rotary Club of Leighton Linslade",
				LookupId = "8-10282784",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7a245e0f-4bfb-4b2d-a49a-537cea020043",
				Name = "Rotary Club of Linlithgow Grange",
				LookupId = "8-10282785",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f70e9530-23e8-45d4-9444-4c7b41cef8ff",
				Name = "Rotary Club of Canterbury, Forest Of Blean",
				LookupId = "8-10282787",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a65aaae8-5756-43ce-9593-cfed617d6c24",
				Name = "Inner Wheel Club of Louth",
				LookupId = "8-10282795",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ee12cd5d-af19-4f88-a1d2-964d7f779693",
				Name = "Inner Wheel Club of Colne Noyna",
				LookupId = "8-10282796",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3624d097-b341-42b0-ad21-754ce67935de",
				Name = "Rotary Club of Bakewell",
				LookupId = "8-10282802",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "104daea8-fdb1-40bf-972b-b254434e7efa",
				Name = "Rotary Club of Eckington & District",
				LookupId = "8-10282806",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b917f20-bb5a-47d4-a70b-d5642b0ba31c",
				Name = "Rotary Club of Royal Forest Of Dean",
				LookupId = "8-10282810",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "734e880a-b25d-477b-884e-179c367bb47b",
				Name = "Inner Wheel Club of Holmfirth",
				LookupId = "8-10282814",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "05130510-97b0-4c28-b9fa-81fde4172c4f",
				Name = "Rotary Club of Forfar",
				LookupId = "8-10282836",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d8fd41b3-bee3-476e-a8bf-ddf0af96365b",
				Name = "Rotary Club of New Malden",
				LookupId = "8-10282838",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a86d9bc0-09eb-45d1-95fe-9c6ff06c9962",
				Name = "Rotary Club of Newton & District Jubilee",
				LookupId = "8-10282840",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d88bb5ed-c616-47b2-a4ef-5c0c0f037f77",
				Name = "Rotary Club of Milton Keynes Grand Union",
				LookupId = "8-10282841",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "43d08b6e-b46b-4b43-adfa-7028b44d670b",
				Name = "Inner Wheel Club of North Wilts",
				LookupId = "8-10282848",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea1b682a-0760-472e-aebc-5427f50d66d5",
				Name = "Inner Wheel Club of Kendal South Westmorland",
				LookupId = "8-10282850",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d455450c-f620-4cd4-8697-5c944eb8f152",
				Name = "Rotary Club of Abbeydale",
				LookupId = "8-10282851",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c10f427c-8f40-4a77-8f95-4958ff6e69aa",
				Name = "Rotary District 1210",
				LookupId = "8-10282860",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4f21a28b-6a59-495a-ba36-a4f7ee256863",
				Name = "Rotary Club of Oswestry",
				LookupId = "8-10282861",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cf9015e8-c35d-49d4-8dd9-4d7af2d683bb",
				Name = "Rotary Club of Portadown",
				LookupId = "8-10282862",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea3f8dc2-c1b4-4c45-9b4e-8354c1a8682e",
				Name = "Rotary Club Of Ashby Hastings",
				LookupId = "8-10282875",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "57b8e2eb-9207-4d40-a9ec-d4b3f1be00ca",
				Name = "Rotary Club of Sittingbourne Invicta",
				LookupId = "8-10282877",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a58df0cb-75ae-4430-a9f8-8764d97d568d",
				Name = "Rotary Club of Sidmouth",
				LookupId = "8-10282878",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cef53ab4-906a-401a-a8e4-4ecdde61c0de",
				Name = "Inner Wheel Club of Corringham Thameside",
				LookupId = "8-10282886",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fa5daab4-aca4-40b4-926a-b71bc7740771",
				Name = "Inner Wheel Club of Dronfield",
				LookupId = "8-10282897",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2296822e-0f1b-49b1-8a20-7e8141459086",
				Name = "Rotary Club of Burslem",
				LookupId = "8-10282900",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e9d993ac-03fa-423d-ad71-242a57930bfd",
				Name = "Rotary Club of Mounts Bay",
				LookupId = "8-10282901",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eb499eb9-7fcb-4aa1-862c-74fd0c51e1a1",
				Name = "Rotary Club of Epsom",
				LookupId = "8-10282910",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d715c6c6-9b17-4ef8-aab9-f3095424522c",
				Name = "Rotary Club of Ambleside Kirkstone",
				LookupId = "8-10282911",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0207b410-6ab7-49cb-845e-9a85cecc9b27",
				Name = "Rotary Club of Batley",
				LookupId = "8-10282913",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "231ab69c-1c00-4faa-87c3-043795661eef",
				Name = "Inner Wheel Club of Southport",
				LookupId = "8-10282914",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "50855a90-8b9c-411a-bad0-5fa71e5f4400",
				Name = "Rotary Club of Melton Aurora",
				LookupId = "8-10282915",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "37597013-6f8a-4584-985d-362fd8d47261",
				Name = "Inner Wheel Club of Letchworth Garden City",
				LookupId = "8-10282916",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bfad95e9-9051-4d3c-882a-bb738295708e",
				Name = "Inner Wheel Club of Bridport",
				LookupId = "8-10282917",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "970176d5-78a6-4db8-afeb-9f9689325780",
				Name = "Rotary District 1100",
				LookupId = "8-10282937",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8c502019-e150-42f4-8305-5f39937608cf",
				Name = "Rotary Club of Rochford",
				LookupId = "8-10282938",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b1cdeca3-9275-490e-ab70-8c417feb1fb3",
				Name = "Rotary Club of Grantham Sunrise",
				LookupId = "8-10282946",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "069fa75d-8d48-47c3-b1d3-5571571f8b86",
				Name = "Rotary District 1145",
				LookupId = "8-10282950",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "12757299-c47e-485a-9764-ccb6beb2936a",
				Name = "Rotary Club of Dinas Powys",
				LookupId = "8-10282952",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "50318632-d4c6-4cbb-9d17-7827d8df69f3",
				Name = "Rotary Club of Bridgnorth",
				LookupId = "8-10282957",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "61c1eb3b-92e7-4b81-a2f1-1eda8cd51a8d",
				Name = "Rotary Club of Cardiff",
				LookupId = "8-10282959",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8c52c610-4bb4-45a0-9329-1d0a88319aee",
				Name = "Rotary Club of Carnforth",
				LookupId = "8-10282960",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "26ca4cf1-0ba8-4fd8-b5c3-0e41b45ec1ea",
				Name = "Rotary Club of Glasgow",
				LookupId = "8-10282961",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3f1de82-1e87-43f7-9b35-e822cde44d4f",
				Name = "Rotary Club of Llantwit Major",
				LookupId = "8-10282962",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4a6dfc7b-add6-4fae-b103-6685fcc66257",
				Name = "Rotary Club of Rochdale East",
				LookupId = "8-10282970",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3975b5d0-513a-479e-99d2-a979bb1359ba",
				Name = "Rotary Club of Blackpool Palatine",
				LookupId = "8-10282971",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ff5edbe8-ae33-482b-9cd9-3a6bb964d058",
				Name = "Rotary Club of Beverley",
				LookupId = "8-10282975",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7267736f-4023-417c-9d48-3d30e1e5d21c",
				Name = "Rotary Club of Dolgellau",
				LookupId = "8-10282981",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cea43b01-f298-4eb0-b0e3-ae249fa54b54",
				Name = "Rotary Club of Tamworth",
				LookupId = "8-10282997",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "84051aec-19be-452a-b0ed-9b0a147d2f73",
				Name = "Rotary Club of Flint & Holywell",
				LookupId = "8-10283081",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ad596b6a-45aa-4208-b9cb-bd91c18c6115",
				Name = "Rotary Club of Sudbury",
				LookupId = "8-10283086",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "014fbab9-0583-493d-8251-3d1fded8076c",
				Name = "Inner Wheel Club of Denbigh",
				LookupId = "8-10283425",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "37a5b60f-9f24-407f-8a10-a5e457fdcdb2",
				Name = "Inner Wheel Club of Kirriemuir",
				LookupId = "8-10283431",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e0c32299-3d48-4de0-a8c4-d0c29bd68326",
				Name = "Rotary Club of Braunton",
				LookupId = "8-10283435",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2bead99d-c657-4029-8815-97fd2d142136",
				Name = "Rotary Club of Gourock",
				LookupId = "8-10283436",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1997c2a4-9bf5-4d52-b69a-3b5b72b46b05",
				Name = "Rotary Club of Doncaster St. Leger",
				LookupId = "8-10283440",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b789784-f131-4a56-9a18-feb6c89048c7",
				Name = "Rotary Club of Golborne Lightshaw, Warrington",
				LookupId = "8-10283442",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e4eccd88-b433-4a17-81c2-7cdd657e8895",
				Name = "Inner Wheel Club of West Woodspring",
				LookupId = "8-10283449",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0ef0464a-0e0d-4bbb-9a5f-f1935da51c91",
				Name = "Rotary Club of Inverurie",
				LookupId = "8-10283451",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "04fe1542-e3b6-4e8c-95df-07cfdceff8c9",
				Name = "Rotary Club of Skipton Craven",
				LookupId = "8-10283452",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5f27259d-62b4-4076-855f-7359a9e03d90",
				Name = "Inner Wheel Club of Seaburn",
				LookupId = "8-10283474",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6c7bfad4-17f4-4728-be97-6679062d50a1",
				Name = "Rotary Club of Shrewsbury Severn",
				LookupId = "8-10283483",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6ac7236a-4172-4b88-974a-6d457b3ceaf7",
				Name = "Rotary Club of Ingatestone",
				LookupId = "8-10283486",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6de459fb-5763-49a7-9ca2-e08604ba479a",
				Name = "Inner Wheel Club of Guildford",
				LookupId = "8-10283488",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fe8dee5e-a1d4-4122-8b8a-e73edaf4ab19",
				Name = "Inner Wheel Club of Camberley",
				LookupId = "8-10283497",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9792794f-43c9-401b-a507-3e9e1cc1e7a2",
				Name = "Rotary Club of Eynsham",
				LookupId = "8-10283505",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1630b07a-6403-480e-86b4-39b45ede820a",
				Name = "Rotary Club of Chelmsford Mildmay",
				LookupId = "8-10283507",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9829d4f6-c052-46ee-bb0e-55f7e3c25479",
				Name = "Rotary Club of Islington, Highgate and Muswell Hill",
				LookupId = "8-10283509",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fc74cfed-809f-4b1b-9851-f88392d71f6d",
				Name = "Rotary Club of Ballymoney",
				LookupId = "8-10283511",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b9e28b10-4cb4-404e-b651-4ad97f1b7c54",
				Name = "Rotary Club of Banbury Cherwell",
				LookupId = "8-10283517",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ed976a77-66a8-477b-bf31-b94ce832cb6a",
				Name = "Rotary Club of Surbiton",
				LookupId = "8-10283521",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d6cb97a4-2863-43c6-936f-76ac4a95aa56",
				Name = "Rotary Club of Brecon",
				LookupId = "8-10283598",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "320c0037-dbf4-43cb-9f24-e60c6a8e9c9d",
				Name = "Rotary Club of Castle Douglas",
				LookupId = "8-10283599",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0716858e-a4e6-4c36-90f2-986eb66c0033",
				Name = "Rotary Club of Bramhall & Woodford",
				LookupId = "8-10283603",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e62881dc-a0ac-4c29-843d-79662993d2bd",
				Name = "Rotary Club of Brightlingsea & District",
				LookupId = "8-10283608",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d65aea96-2e67-45fe-83e8-eb60119eddd8",
				Name = "Rotary Club of Stonehouse",
				LookupId = "8-10283610",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "18ca1591-b5b8-46ee-8678-e9da9204d603",
				Name = "Inner Wheel Club of Woking District",
				LookupId = "8-10283617",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "358d6b6c-8cd0-4b95-826c-3665ef12939f",
				Name = "Rotary Club of Letterkenny",
				LookupId = "8-10283621",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7e4b5680-98cf-473d-9a1e-2023d3d4a291",
				Name = "Rotary Club of Monaghan",
				LookupId = "8-10283622",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "94b7ab41-2df9-4585-a2dd-77de9606672a",
				Name = "Inner Wheel Club of New Malden",
				LookupId = "8-10283623",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "30385ff5-795c-421f-8acc-2f2d6d3ffa21",
				Name = "Rotary Club of Helston-Lizard",
				LookupId = "8-10283633",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2e8e678c-7bdb-4ef9-a7c0-684c5f1c9bfc",
				Name = "Rotary Club of Norwich Blackfriars Breakfast",
				LookupId = "8-10283634",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0cf4d397-6474-486a-b4ab-7b003bffb691",
				Name = "Rotary Club of Omagh",
				LookupId = "8-10283636",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4d5f2094-d07c-4aa5-8f9f-c5ed26b5b566",
				Name = "Rotary Club of Devizes",
				LookupId = "8-10283637",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b6392c0c-84c7-4618-87e2-4f86e8d671bc",
				Name = "Rotary Club of Ashford, Middlesex",
				LookupId = "8-10283638",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5ead6ea4-901b-4948-95db-aaeef558088a",
				Name = "Inner Wheel Club of Northampton",
				LookupId = "8-10283643",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f2e99acc-8dc4-4378-8a45-669a80d7e54d",
				Name = "Tabernacle Chapel, Pontardawe and Interact Club of Maesydderwen School",
				LookupId = "8-10283646",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea4cd30c-9f3b-48fd-ad41-63829200a442",
				Name = "Inner Wheel Club of Market Drayton",
				LookupId = "8-10283648",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d71a0c82-260e-409e-961b-eae7c39b4fef",
				Name = "Rotary Club Of Faringdon & The White Horse",
				LookupId = "8-10283649",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "57cf46f7-23c4-43a2-86e4-547ac6eae5c8",
				Name = "Rotary Club of St. Andrews",
				LookupId = "8-10283651",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ef617524-c6ee-4902-a024-1f9fa652af76",
				Name = "Rotary Club of Odiham & Hook",
				LookupId = "8-10283652",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "88092189-d7ed-44e2-b79d-7ecc0b8fb331",
				Name = "Rotary Club of Youghal",
				LookupId = "8-10283653",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e441ce3e-eb54-4967-89d3-0c87542139df",
				Name = "Inner Wheel Club of Kinross & District",
				LookupId = "8-10283659",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a6014d66-06d9-4b37-9d64-495feff02f22",
				Name = "Inner Wheel Club of Kenilworth",
				LookupId = "8-10283660",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "41177474-e229-4bf4-9cac-8c3614614b93",
				Name = "Rotary Club of Burnley",
				LookupId = "8-10283684",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "daeeadc3-9acd-4a33-ab29-65315349075a",
				Name = "Rotary Club of Ramsbottom",
				LookupId = "8-10283687",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a7f70320-02e0-4f98-aab7-6d07e7d12a8e",
				Name = "Rotary Club of Shrewsbury Darwin",
				LookupId = "8-10283688",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0b17da67-9037-4e2c-bec8-423a5cd27e12",
				Name = "Rotary Club of Arbury",
				LookupId = "8-10283699",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8cd30713-8051-447c-b8f6-207f27da8529",
				Name = "Rotary Club of Brandon & District",
				LookupId = "8-10283701",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dec2013b-ceb5-462a-8967-6147a91a51cc",
				Name = "Inner Wheel Club of Felixstowe",
				LookupId = "8-10283702",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8ee64b1c-030a-46b7-982c-ed304fb0d776",
				Name = "Rotary Club of Grangemouth",
				LookupId = "8-10283703",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b40354f-2bf6-49ad-982d-3270a81893d7",
				Name = "Rotary Club of Northampton West",
				LookupId = "8-10283705",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "83e0d399-1c61-474d-9f6b-70ca06c1176f",
				Name = "Rotary Club Of Annan And District",
				LookupId = "8-10283706",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bdd63589-17ef-48b6-a64b-de31089fd037",
				Name = "Rotary Club of Cardiff East",
				LookupId = "8-10283707",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8b6f1eb0-52c8-484f-a82e-3bad0bbf0199",
				Name = "Rotary Club of Inverkeithing & Dalgety Bay",
				LookupId = "8-10283709",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "04c719a9-eff2-42a5-b6fd-6e9f71765efa",
				Name = "Rotary Club Of Swindon North And Thamesdown",
				LookupId = "8-10283710",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1bd37802-267d-426f-84e1-0a3243bdf32c",
				Name = "Inner Wheel District 128",
				LookupId = "8-10283714",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8068778e-839d-4e74-843c-f84658d186b7",
				Name = "Rotary Club of Crook",
				LookupId = "8-10283715",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7627c920-75c2-4578-9c87-34a856bbaf56",
				Name = "Rotary Club of Romney Marsh",
				LookupId = "8-10283717",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b0dc3c24-1bf9-4c62-9056-5867e8471a26",
				Name = "Rotary Club of Church Stretton",
				LookupId = "8-10283725",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cad2b468-5d75-45fa-902a-93cd2d7b81a7",
				Name = "Rotary Club of Enfield",
				LookupId = "8-10283727",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e4bd56cb-f866-47f7-a43d-041abb89a614",
				Name = "Rotary Club of Kew Gardens",
				LookupId = "8-10283728",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5a6ee400-94f1-46a4-a082-2f46aa1cb12b",
				Name = "Rotary Club of Widnes",
				LookupId = "8-10283729",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d35f12d9-1cc1-4c1c-aef4-2d3f396e4619",
				Name = "The Association of Inner Wheel Clubs in GB & I",
				LookupId = "8-10283731",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "59a133fb-0a61-4103-be7b-2e4b6549114c",
				Name = "Rotary Club of Horley",
				LookupId = "8-10283735",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bc3bcb94-2f13-40c3-a2b8-915222d0bd29",
				Name = "Rotaract Club of Burnham",
				LookupId = "8-10283742",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "91bcad0f-a6d1-43f3-9a64-f39038939353",
				Name = "Inner Wheel District 16",
				LookupId = "8-10283744",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b0adce17-320b-4f8c-b253-894a15f6ed7a",
				Name = "Rotary Club of Swaffham",
				LookupId = "8-10283745",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5cac14ac-fbff-4d2e-a6a7-3ef5ef994b07",
				Name = "Rotary Club of Rushmoor",
				LookupId = "8-10283748",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e1924a37-99c4-4e44-b76b-b291878d8a75",
				Name = "Rotary Club of Stonehaven",
				LookupId = "8-10283749",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2383dcfe-0a31-44a5-b193-cff6697e8f87",
				Name = "Interact Club of Friary School",
				LookupId = "8-10283775",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aa731649-ce0e-4fa2-b9c8-476bba047a42",
				Name = "Rotary Club of Wickford",
				LookupId = "8-10283785",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "944d41d0-3bd9-43f0-b2f2-c715c3e3e78d",
				Name = "Inner Wheel Club of Buxton",
				LookupId = "8-10283798",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "acc69aef-33ce-4387-a937-f7a9bd81c112",
				Name = "Rotary Club of Barrow-In-Furness",
				LookupId = "8-10283801",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d7f37e03-f6c0-430a-b50c-f3e0c25ede83",
				Name = "Rotary Club of Halesowen & Rowley Regis",
				LookupId = "8-10283802",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "074ec71d-8761-4fe6-8fdf-8905c5faf9c0",
				Name = "Rotary Club of Lindum Lincoln",
				LookupId = "8-10283803",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "705e5003-9cb9-48ae-a84c-ed85346e827e",
				Name = "Rotary Club of Island & Royal Manor Of Portland",
				LookupId = "8-10283805",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "659e89df-5126-4c11-8838-7f1b70c2036d",
				Name = "Inner Wheel Club of Witham",
				LookupId = "8-10283806",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d808f832-89a0-4e66-a278-c3b7398ca597",
				Name = "Rotary Club of Gillingham, Kent",
				LookupId = "8-10283808",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "720a8b0e-34b4-4511-95e7-7f492aa5d925",
				Name = "Rotary Club of Shepshed Charnwood",
				LookupId = "8-10283811",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "013a0a73-1a16-42ee-be0f-2e644f91f269",
				Name = "Inner Wheel Club of Colwyn Bay",
				LookupId = "8-10283816",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "510ba59f-33df-4207-a711-3965f7b314a8",
				Name = "Rotary Club of Dumbarton",
				LookupId = "8-10283818",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b741f013-6adb-486b-aacd-367b92f9a327",
				Name = "Rotary Club of Cardiff St. Davids",
				LookupId = "8-10283823",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5bf635a8-abb5-4cec-ba46-550087ff270c",
				Name = "Rotary Club of Letchworth Howard",
				LookupId = "8-10283829",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2dc3cfb1-ff9e-4476-a872-4e79259c226b",
				Name = "Rotary Club of Malton & Norton",
				LookupId = "8-10283831",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "815f5372-e405-41be-a436-7c386c00a329",
				Name = "Rotary Club of Ely Hereward",
				LookupId = "8-10283837",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "225833d4-fd92-4fb0-b9fe-5363a1f77c54",
				Name = "Rotary Club of Aberystwyth",
				LookupId = "8-10283838",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "06ef1e65-838f-4a74-a2ba-c22f4adca871",
				Name = "Rotary Club of Gorleston-On-Sea",
				LookupId = "8-10283840",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "99f2ac42-a6a7-4693-a403-5f27bfa76b98",
				Name = "Rotary Club of Baldock",
				LookupId = "8-10283853",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f36d9d4f-103c-4570-9153-dd3743f8b929",
				Name = "Inner Wheel Club of Spalding",
				LookupId = "8-10283860",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cfd5c492-8699-4f66-8ec2-c043d468e8c9",
				Name = "Rotary Club of West Wickham",
				LookupId = "8-10283864",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "92762d1f-d92d-44b4-a42f-716359d405db",
				Name = "Rotary Club of Washington Forge",
				LookupId = "8-10283880",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ee7b70bc-7a4d-4f03-a5fa-803a686503ac",
				Name = "Rotary Club of Cranleigh",
				LookupId = "8-10283883",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7f41471c-098b-4e32-8b60-e23d7ac8ad51",
				Name = "Rotary Club of Wortley",
				LookupId = "8-10283884",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "69ce8722-fed0-4014-8ab6-347dc2954d03",
				Name = "Inner Wheel Club of Thirsk",
				LookupId = "8-10283887",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f7a9b219-5af4-4edb-ba21-abde8fb22f7e",
				Name = "Rotary Club of Bolton Lever",
				LookupId = "8-10283897",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "07bbd7c1-f8e0-4e60-91c3-5912276176f4",
				Name = "Rotary Club of Seaburn",
				LookupId = "8-10283901",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bccd7158-bc9d-4205-87e3-992c83270fcc",
				Name = "Rotary Club of Pinner",
				LookupId = "8-10283902",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3241c8fb-2497-47c3-837c-126a6ebb11f7",
				Name = "Rotary Club of Chepstow",
				LookupId = "8-10283911",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cde03e36-e5db-4ad5-8e5c-ba3912c02ca3",
				Name = "Rotary Club of Colwyn Bay",
				LookupId = "8-10283912",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "eb8de256-99fd-48d6-8c29-a8ca49d38aaf",
				Name = "Rotary Club of Kidsgrove",
				LookupId = "8-10283913",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "29486fc9-6d47-46f8-93c9-53c77aacbe15",
				Name = "Rotary Club of Pangbourne",
				LookupId = "8-10283914",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f4cdd8a1-349f-4570-9554-708844d605c7",
				Name = "Rotary Club of Peterborough Ortons",
				LookupId = "8-10283915",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "67d11c0e-74aa-4107-872a-18fe949909fc",
				Name = "Inner Wheel Club of Havering",
				LookupId = "8-10283922",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0c16acec-b435-4584-bc2a-770fa3897be6",
				Name = "Rotary Club of Caterham Harestone",
				LookupId = "8-10283929",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a9d30380-c3b1-4e8b-bc7a-5658a61eab02",
				Name = "Interact Club of The Prendergast Hilly Fields",
				LookupId = "8-10283943",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "60a99978-18c5-4085-bfd7-009b819f381a",
				Name = "Rotary Club Of Ringwood",
				LookupId = "8-10283946",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cc590939-ec08-46f5-a671-a265debd6da8",
				Name = "Rotary Club of Ripon Rowels",
				LookupId = "8-10283947",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "07256be2-5fb1-435f-a519-b91682e81e7e",
				Name = "Rotary Club of Stort Valley",
				LookupId = "8-10283966",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f22e1df7-82ae-4f2c-8161-942c0b34fcaa",
				Name = "Rotary Club of Ashby-De-La-Zouch",
				LookupId = "8-10283973",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8188fc18-ceed-4ea2-8ebe-f4a62e0daa56",
				Name = "Rotary Club of Cambridge",
				LookupId = "8-10283974",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c50506ed-7e2e-46bb-982a-ff3901eadb0a",
				Name = "Rotary Club of Fareham Meon",
				LookupId = "8-10283975",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "07706f76-7d10-4448-9669-465c33b6642d",
				Name = "Rotary Club of Welwyn Garden City",
				LookupId = "8-10283990",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cf925e74-04e9-4c91-be79-6cf19b78ec44",
				Name = "Inner Wheel Club of Millom",
				LookupId = "8-10283995",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4935d76e-afa3-442d-a04f-5e3535f8c0b2",
				Name = "Rotary Club Of Herne Bay",
				LookupId = "8-10283997",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "003f7f27-020d-4391-9f35-7d6890a1f1a2",
				Name = "Rotary Club of Bournemouth East Cliff",
				LookupId = "8-10284018",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "09471209-c83e-40f1-bf8f-744903c98d97",
				Name = "Rotary Club of Barrow Meridian",
				LookupId = "8-10284027",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "47e28fd6-ab75-4074-9c2a-2ba8bf20e114",
				Name = "Rotary Club of Wallingford & Didcot District",
				LookupId = "8-10284029",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "59875603-fb1e-4bde-9018-f526ac9c711d",
				Name = "Rotary Club of Bexley",
				LookupId = "8-10284032",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a65914fd-a57c-405f-b0ee-3c1f9861c6e9",
				Name = "Rotary Club of Ballymena",
				LookupId = "8-10284048",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c0d7daa0-404e-4cf5-af5e-e37c9c9338dc",
				Name = "Rotary Club of Newton-Le-Willows",
				LookupId = "8-10284049",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6f750772-8c03-420c-a817-4517dbf4599a",
				Name = "Rotary Club of Tenby",
				LookupId = "8-10284050",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dbaa7af2-72a5-4bb5-816e-17e9437ee21a",
				Name = "Inner Wheel Club of Dorchester",
				LookupId = "8-10284051",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea7bda02-9a4d-40d0-b860-413746f59087",
				Name = "Rotaract Club of Tyneside",
				LookupId = "8-10284069",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "03fcf947-d165-4926-9882-9266b4c7bb44",
				Name = "Rotary Club of Medway Sunlight",
				LookupId = "8-10284077",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f2bf2185-1f1a-4ef7-85b9-41cd578aa7a0",
				Name = "Rotary Club Of Truro Evolution",
				LookupId = "8-10284081",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "908cbce3-6a44-4ea2-80db-6123a6f127c0",
				Name = "Rotary Club of Deal",
				LookupId = "8-10284085",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a0f36c79-71ca-4f9c-9042-4979287b6858",
				Name = "Rotary Club of Hadleigh Castle",
				LookupId = "8-10284091",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "743ef2da-50c7-4174-99e0-0df9a48ed8f4",
				Name = "Rotary Club of Plymouth",
				LookupId = "8-10284098",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "791849c2-4396-4099-87eb-48f6c72fdc9d",
				Name = "Rotary Club of St. Albans-Verulamium",
				LookupId = "8-10284099",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "23363333-4f06-44e5-b59c-beabd534fec7",
				Name = "Rotary Club of Towcester",
				LookupId = "8-10284100",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "89c66114-0977-4c4a-b43a-e0504a78cf34",
				Name = "Rotary Club of Lincoln Colonia",
				LookupId = "8-10284118",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c45e2682-5ef5-4138-82f0-6aecdf0cd02d",
				Name = "Rotary Club of Mold",
				LookupId = "8-10284119",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "83f7f87b-cc27-43ea-9d0c-bc1220ae7366",
				Name = "Rotary Club of Bebington",
				LookupId = "8-10284121",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0c009390-3b5a-48d2-b7b6-fb38b65996c5",
				Name = "Rotary Club of Jersey-de La Manche",
				LookupId = "8-10284123",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4b64e0ba-cb9f-4a50-98fa-054381291d01",
				Name = "Rotary Club of Chingford",
				LookupId = "8-10284129",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3e5b3cd7-056a-41f5-b14c-5ecf8adddfba",
				Name = "Rotary Club of Cosham",
				LookupId = "8-10284130",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "76e76fd6-259f-4c08-aa5d-b6be67cb9930",
				Name = "Rotary Club of Wells",
				LookupId = "8-10284132",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6e600b3b-262c-4d53-8ad2-75f3f48d1a19",
				Name = "Inner Wheel Club of Appleby",
				LookupId = "8-10284142",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f5e81856-1220-4377-ad1b-bf57d3aac83e",
				Name = "Rotary Club of Bradley Stoke",
				LookupId = "8-10284143",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "22938188-c217-4ff8-8ca3-225c686e45e4",
				Name = "Rotary Club of Derby Daybreak",
				LookupId = "8-10284144",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ccdc0da0-2673-4d2d-ae3b-2c8f6bd61c7b",
				Name = "Rotary Club of Redbridge",
				LookupId = "8-10284148",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f39717ff-f98e-490d-b8f5-969151a18dab",
				Name = "Rotary Club of Usk",
				LookupId = "8-10284149",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cb8fc276-7113-47d4-b6c9-fc345f2f24be",
				Name = "Inner Wheel District 129",
				LookupId = "8-10284151",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1c53f3b1-1383-423c-8d06-e760f1369e61",
				Name = "Rotary Club of Ripley & Send",
				LookupId = "8-10284153",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0d66b507-08d0-4ba4-8fa8-a7385a6e6da2",
				Name = "Inner Wheel Club of Carrickfergus",
				LookupId = "8-10284156",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "48f38a3a-dca4-4f06-aadb-55dc4111642a",
				Name = "Rotary Club of Addiscombe and Shirley",
				LookupId = "8-10284645",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ac4214bc-6e6e-43b1-b98f-87c00e1f6a4d",
				Name = "Rotary Club of Vectis Sunrise (Newport I.O.W.)",
				LookupId = "8-10284648",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b2e54eb9-f623-4f96-a232-3d7a7a486aeb",
				Name = "Rotary Club of Southampton Clausentum",
				LookupId = "8-10284653",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b59d1584-e6e6-454d-baf5-d3c33030e8ef",
				Name = "Rotary Club of Fareham",
				LookupId = "8-10284673",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "285cc6ce-306e-4342-bca4-43f6220595b1",
				Name = "Rotary Club of Maldon",
				LookupId = "8-10284674",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4e95e0e3-9111-446b-a52e-af1ddc3e2e09",
				Name = "Rotary Club of Harleston & District",
				LookupId = "8-10284684",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ff8cee52-2991-4467-a7c1-055a903ff4a2",
				Name = "Rotary Club of Consett",
				LookupId = "8-10284688",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e12671ca-1799-4216-a130-6c9d011bf997",
				Name = "Rotary Club of Keighley",
				LookupId = "8-10284690",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d6c96dc9-ee01-4573-94f5-134c88e0a0c5",
				Name = "Rotary Club of Scunthorpe Pentagon",
				LookupId = "8-10284691",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b731621f-52f7-4ecf-8f22-37833fa55a09",
				Name = "Inner Wheel Club of Hove",
				LookupId = "8-10284692",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "416f6050-80e4-452d-a56a-ed1761754533",
				Name = "Rotary Club of Lauderdale",
				LookupId = "8-10284694",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "38b6f05e-18fd-4748-8978-68f70bdc3494",
				Name = "Rotary Club of Sedgefield",
				LookupId = "8-10284696",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b99687c4-16f6-4eda-bfd9-b81a932bdf11",
				Name = "Rotary Club of Houghton-le-Spring",
				LookupId = "8-10284698",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "90a77529-43a7-45e9-b4f9-690bf373e088",
				Name = "Rotary Club of Medway",
				LookupId = "8-10284699",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3b537283-f4a8-47b9-8446-44f97fd1da42",
				Name = "Rotary Club of Doncaster St. George's",
				LookupId = "8-10284714",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "47954005-102c-4af9-84c8-1dfe56e410b7",
				Name = "Rotary Club of Reigate",
				LookupId = "8-10284719",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b7795b5e-e531-4c7a-854e-fb26b10c8d97",
				Name = "Rotary Club of Danetre Daventry",
				LookupId = "8-10284722",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8179358e-fc88-42a2-b645-91813d37f375",
				Name = "Inner Wheel Club of Llangollen",
				LookupId = "8-10284727",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "57a885e7-d832-41fb-8d41-a5264aaf406e",
				Name = "Inner Wheel Club of Havant",
				LookupId = "8-10284744",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ce5614ae-2905-47c5-aa11-8568feecc37f",
				Name = "Rotary Club of Cannock",
				LookupId = "8-10284748",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e73bc942-d183-4aad-ab0b-f4b8f2b8f390",
				Name = "Rotary Club of Hamilton",
				LookupId = "8-10284749",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9a11ff57-2f88-4b3b-93f4-86e9052789d4",
				Name = "Inner Wheel Club of Windermere",
				LookupId = "8-10284750",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d729f514-95f1-4a1d-b6ab-6c3a46154927",
				Name = "Rotary Club of Witham",
				LookupId = "8-10284754",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d030d350-f32c-44bc-b00f-d6d9c6d97095",
				Name = "Rotary Club of Norwich Marchesi",
				LookupId = "8-10284760",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "acefce26-04c6-42c6-bf92-184d46ebb13c",
				Name = "Inner Wheel Club of Ironbridge",
				LookupId = "8-10284764",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7e791045-fcbf-4ad0-a76c-96eaa3fada26",
				Name = "Rotary Club of Claverhouse",
				LookupId = "8-10284765",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3fb89121-52ae-4b20-a326-d0f2810f3a10",
				Name = "Rotary Club of Lickey Hills, Birmingham",
				LookupId = "8-10284766",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "25ff7999-73b9-4cc4-ae8d-73b4670e574d",
				Name = "Rotary Club of Shepton Mallet",
				LookupId = "8-10284770",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "66cbf64c-70d9-4ad8-8b69-16e281a7589a",
				Name = "Inner Wheel Club of Battle",
				LookupId = "8-10284782",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "be8e6daa-2fe7-4763-bf19-ede12926d84a",
				Name = "Rotary Club of Innerleithen, Walkerburn & Traquair",
				LookupId = "8-10284789",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cd1cd658-6c4c-4a4e-a80c-492c82a2eed6",
				Name = "Rotary Club of Minster on Sea",
				LookupId = "8-10284792",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "62f0e495-d4e2-498b-895a-f292a50ed3e5",
				Name = "Rotary Club of Dingwall",
				LookupId = "8-10284793",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "666c9a4e-c9d6-4d86-aa3e-3071cdd43d32",
				Name = "Rotary Club of Crewkerne District",
				LookupId = "8-10284796",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f6278fcf-f47d-474d-ae1d-2e2eef65e3f9",
				Name = "Rotary Club of Llangollen",
				LookupId = "8-10284802",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "77329784-278d-4123-9ae4-abf415082468",
				Name = "Rotary Club of Hailsham",
				LookupId = "8-10284804",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1f15c545-2ae9-4162-8892-2b1eb4acb9af",
				Name = "Rotary Club of St. Andrews Kilrymont",
				LookupId = "8-10284805",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "befd3e06-a829-4c72-b957-1bca7698687b",
				Name = "Rotary Club of Northwich Vale Royal",
				LookupId = "8-10285534",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "53ea49ae-2cdd-4c35-98f5-b47cc5fa29e5",
				Name = "Rotary Club of Aberdeen (St. Fittick)",
				LookupId = "8-10285539",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "82ebeb14-8b85-4714-9ec9-3da070bb8129",
				Name = "Rotary Club of Crosby",
				LookupId = "8-10285540",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dfb33959-c20a-4170-a91a-0f643b530a6d",
				Name = "Rotary District 1010",
				LookupId = "8-10285541",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "83e8c8e5-35c9-4353-bfb4-37e82d01da2b",
				Name = "Rotary Club of Dunstable",
				LookupId = "8-10285542",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e4eafba6-7f4e-4160-9fb7-50e191131e40",
				Name = "Rotary Club of West Fife",
				LookupId = "8-10285544",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "504aa48e-1d73-4a7c-94e7-4dd9650daac8",
				Name = "Rotary Club of Whitstable",
				LookupId = "8-10285545",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "95a64f44-52a6-4941-9e48-a54593f65b63",
				Name = "Rotary Club of Huntly",
				LookupId = "8-10285548",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a54a9c22-bc79-4da9-b349-49b7d2fede3a",
				Name = "Rotary Club of Wrexham Erddig",
				LookupId = "8-10285552",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a8eb7cb2-64bf-4cbc-ac7e-9535b55677bf",
				Name = "Inner Wheel Club of Shanklin",
				LookupId = "8-10285553",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bce2dcd1-0e12-4a83-8393-bd4a1ab9739e",
				Name = "Interact Club of Waingels College",
				LookupId = "8-10285558",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3ddd6f53-3eb5-4ce1-a3ac-4a10544f42db",
				Name = "Rotary Club of Bromsgrove",
				LookupId = "8-10285560",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "50bdb103-ee00-47d5-a967-00746449b7f8",
				Name = "Rotary District 1160",
				LookupId = "8-10285569",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "db9e3472-cac3-4adb-955a-a01f7bd5ab5d",
				Name = "Rotary Club of Sleaford Kesteven",
				LookupId = "8-10285570",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8d06f48a-5004-4e32-9d17-6cbb90dfdf86",
				Name = "Rotary Club of Swindon Old Town",
				LookupId = "8-10285575",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a1aee30f-fcef-47ad-ad14-e62cebce4a27",
				Name = "Inner Wheel Club of Swanage & Purbeck",
				LookupId = "8-10285594",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d29e5af9-244d-4f85-b985-57c07ccc91fe",
				Name = "Rotary Club of Southwold and District",
				LookupId = "8-10285595",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e44b66b7-f7ce-4620-949c-cf90a3541124",
				Name = "Rotary Club of Sedgley & Wombourne",
				LookupId = "8-10285608",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bd3242c7-3695-481b-a3e7-2af8e0ef31b4",
				Name = "Rotary Club of Sevenoaks",
				LookupId = "8-10285609",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cec8e193-f2c3-4418-a34a-fa9093ee35fd",
				Name = "Rotary Club of Sheffield Vulcan",
				LookupId = "8-10285610",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "63b3dbb9-494f-4894-9283-37cd156d42f4",
				Name = "Rotary Club of Skipton",
				LookupId = "8-10285617",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2410ca27-d4e2-4916-8b49-97e631d282aa",
				Name = "Inner Wheel Club of Taunton",
				LookupId = "8-10285653",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "67243634-ddd9-49ae-94f3-9500a8a2b851",
				Name = "Inner Wheel Club of St Ives, Cornwall",
				LookupId = "8-10285661",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "45c4248f-7314-4162-b814-dfe4c3ce0a55",
				Name = "Rotary Club of Cardiff West",
				LookupId = "8-10285667",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a68055fa-bf77-49a3-9bf7-7739691e9d6d",
				Name = "Rotary Club of Ravenshead & Blidworth",
				LookupId = "8-10285668",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c2a78419-7f43-40c7-ae2e-4fba71066436",
				Name = "Rotary Club of Chatteris",
				LookupId = "8-10285700",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8e0ae00c-f088-4398-bdd8-2111e7edc581",
				Name = "Rotary Club of Langport & Somerton",
				LookupId = "8-10285701",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "32a31a18-8063-48a3-975b-23c51b89ef7f",
				Name = "Rotary Club of Malvern",
				LookupId = "8-10285702",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4ee308bd-6d74-41e5-b511-27d58371c5ec",
				Name = "Rotary Club of Preston Amounderness",
				LookupId = "8-10285703",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e70252d7-d776-4cda-a3f8-1239c1a9606f",
				Name = "Rotary Club of Bacup",
				LookupId = "8-10285711",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a35703af-c475-470a-a284-236ada576afb",
				Name = "Rotary Club of Washington",
				LookupId = "8-10285713",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fefbd7ce-cfe1-4312-930b-aa938e3b0011",
				Name = "Rotary Club of Macclesfield Castle",
				LookupId = "8-10285723",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d43fd956-60f7-4efa-85d7-651ac78e7abb",
				Name = "Rotary Club of Northampton Becket",
				LookupId = "8-10285724",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ed4f1a23-ecf8-4efa-9daa-501f68ef70df",
				Name = "Inner Wheel Club of St. Helens",
				LookupId = "8-10285726",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4708184c-93a9-4798-a61b-ad2c15fac103",
				Name = "Rotary Club of Central Buchan",
				LookupId = "8-10285731",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "785bfc07-8883-4772-be5b-ed82cbea7265",
				Name = "Rotary Club of Uxbridge",
				LookupId = "8-10285736",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e468ccdc-897a-4d30-bb87-5f216fd1a973",
				Name = "Rotary Club of Edgware & Stanmore",
				LookupId = "8-10285737",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6bf541e7-b3f1-4635-b09f-3cb082b6c849",
				Name = "Rotary Club of Rushden Chichele",
				LookupId = "8-10285738",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4db3b115-45e1-4c66-889e-1367434e23cc",
				Name = "Rotary Club of Saxmundham & District",
				LookupId = "8-10285739",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0f4d0498-f414-4679-be5d-7d4d5a2535cd",
				Name = "Rotary Club of Buxton",
				LookupId = "8-10285778",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "27eec3bc-9c99-4b7e-8943-c91bd0c750d0",
				Name = "Inner Wheel Club of Penzance",
				LookupId = "8-10285779",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6dc9724c-3369-4af6-a6fc-a48b9c45763c",
				Name = "Rotary Club of Sturminster Newton",
				LookupId = "8-10285780",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9562f432-ff81-44e7-8b58-ea39c7aa3873",
				Name = "Rotary Club of Weighton Wolds",
				LookupId = "8-10285788",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "71b5bbd0-7bf5-4955-82e3-5bd9958692e7",
				Name = "Rotary Club of Lyme Regis",
				LookupId = "8-10285812",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fa5bf7e3-d118-4666-b902-3077b650a40d",
				Name = "Rotary Club of North Wirral",
				LookupId = "8-10285813",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9dc6ed82-efdc-47ed-88d8-8b5bb8cb0b4e",
				Name = "Rotary Club of Yelverton",
				LookupId = "8-10285820",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5bc6ba7f-e2c1-4dd6-b3c1-c756c227439a",
				Name = "Rotary Club of Ashbourne",
				LookupId = "8-10285821",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8f794519-1cc3-46ef-a895-83d79e5862ad",
				Name = "Rotary Club of Machynlleth",
				LookupId = "8-10285826",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8d4c61ef-886d-459d-8b41-ba58db75f47d",
				Name = "Inner Wheel Club of District 17 Overseas Zone Rally",
				LookupId = "8-10285829",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "59abcb95-a48b-4850-8f11-5ecb08145807",
				Name = "Inner Wheel Club of Ipswich Orwell",
				LookupId = "8-10285841",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cbef2aa6-8d06-4c9e-b20f-ae023cfb2499",
				Name = "Inner Wheel Club of Prestwich & Whitefield",
				LookupId = "8-10285850",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6ba344e3-73f7-4be1-82aa-52699fe69be8",
				Name = "Rotary Club of Calverley",
				LookupId = "8-10285869",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e478f7b1-5097-43c6-9c2a-57ef8904c6bf",
				Name = "Rotary Club of Whitby & District",
				LookupId = "8-10285870",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c2555074-0915-4912-a485-0bcb358bbda0",
				Name = "Rotary Club of South Sefton",
				LookupId = "8-10285871",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "640c1d0f-f6a3-4e9c-98f3-a2816192cbfe",
				Name = "Inner Wheel Club of Colchester",
				LookupId = "8-10285873",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b7dc2bf0-991e-4ed2-bb43-46f9030bfe16",
				Name = "Rotary Club of Langley Park",
				LookupId = "8-10285877",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "44095ed2-8a4c-4498-a782-b8a273a43df3",
				Name = "Rotary Club of Inverness Loch Ness",
				LookupId = "8-10285883",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7f488780-a705-4aa3-8340-c1a277b16b41",
				Name = "Rotary Club of Gillingham, Dorset",
				LookupId = "8-10285885",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b15d056c-da56-4784-a7ed-f2ad58c10e37",
				Name = "Rotary Club of Hitchin Tilehouse",
				LookupId = "8-10285888",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3231b21d-741d-447e-934f-917f6e8082cb",
				Name = "Rotary Club of Gerrards Cross & Chalfont St. Peter",
				LookupId = "8-10285890",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7b03d0f0-d8c2-4a4a-ab41-e96eeb40a709",
				Name = "Rotary Club of Ilfracombe Compass",
				LookupId = "8-10285895",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a9640b5e-33fb-4e25-bf8f-ab2b690f5dd1",
				Name = "Rotary Club of Barton-upon-Humber",
				LookupId = "8-10285899",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9966d775-a6f0-4832-9406-3fadfb13d213",
				Name = "Rotary Club of Bedford Park",
				LookupId = "8-10285901",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8154b47b-487b-4500-ab20-ed33e3b89091",
				Name = "Inner Wheel Club of Scarborough",
				LookupId = "8-10285912",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "24e4e483-ceb2-46b2-94e7-92addd886c53",
				Name = "Rotary Club of Oswestry Cambrian",
				LookupId = "8-10285915",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fb02b750-ee76-4ed9-bd52-32aff9d2577c",
				Name = "Rotary Club of Durham Bede",
				LookupId = "8-10285918",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1e5016a2-9170-4477-8ba1-a0e2d69ac3f8",
				Name = "Rotary Club of Smethwick",
				LookupId = "8-10285919",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "41542fd5-05ee-4b92-8641-ee36ada8d38c",
				Name = "Rotary Club of Southport Meols",
				LookupId = "8-10285920",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0f737e7c-bbe6-4434-b5e8-77d36e4a15b2",
				Name = "Inner Wheel Club of Pembroke",
				LookupId = "8-10285924",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "215e0f95-b6bd-4c9a-af66-f38b1714b785",
				Name = "Inner Wheel Club of Lanark",
				LookupId = "8-10285932",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8ec8492c-ef6d-4aca-91d2-5ff259eb636f",
				Name = "Rotary Club of Berkhamsted Bulbourne",
				LookupId = "8-10285940",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8fddb93f-d615-4a55-aa38-650c3edb2de4",
				Name = "Rotary Club of Billericay Mayflower",
				LookupId = "8-10285941",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5f374ccd-2852-41f4-bc37-6d7753c47a25",
				Name = "Rotary Club of Bilston & Wolverhampton West",
				LookupId = "8-10285942",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b5479eac-fde8-4b83-86e2-3af5442b83ec",
				Name = "Rotary Club of Greenock",
				LookupId = "8-10285943",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fdf95ef7-63b0-4dbc-ab1b-3031f15ee2a0",
				Name = "Rotary Club of Colchester",
				LookupId = "8-10285949",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8a84023a-12dd-419c-8e2d-6f521f190e11",
				Name = "Rotary Club of Whiteley",
				LookupId = "8-10285952",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "af076eec-e1e5-45d9-b718-49a3b294f8ba",
				Name = "Rotary Club of Newtown",
				LookupId = "8-10285953",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "da521b48-59c1-429b-9c64-676b10429530",
				Name = "Rotary Club of Poynton & District",
				LookupId = "8-10285958",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "959ff4e8-4a0f-4721-bae9-860d2a247d07",
				Name = "Rotary Club of Irvine Seagate",
				LookupId = "8-10285959",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f4d13126-8fd1-4762-ab7d-77f05c1484bc",
				Name = "Rotary Club of Haddenham and District",
				LookupId = "8-10285965",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "99f8d4fe-804c-4203-8620-10ea0abba0b2",
				Name = "Rotary Club of Ruthin",
				LookupId = "8-10285976",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "16abcbe0-1f16-475c-b682-42c69933ede8",
				Name = "Inner Wheel Club of Banbury",
				LookupId = "8-10286262",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6a003afa-c7bc-427f-a2e6-3246e2352ca0",
				Name = "Inner Wheel Club of Stafford",
				LookupId = "8-10286263",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b22f63cb-6fe0-4da4-876b-330ea3cee9f1",
				Name = "Rotary Club of Bathgate",
				LookupId = "8-10286269",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b085e3d7-c2af-4b88-b74a-d53ded2c4a23",
				Name = "Rotary Club of Hoddesdon",
				LookupId = "8-10286270",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9a7da55c-4b50-43ab-88ea-8449ec198250",
				Name = "Rotary Club of Maidstone Riverside",
				LookupId = "8-10286271",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "78a213ca-056a-493f-8888-b0d55aa2bbc6",
				Name = "Rotary Club of Tameside",
				LookupId = "8-10286280",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7e2083d4-0950-4140-b096-16a486bcaa6d",
				Name = "Rotary Club of Mid Wirral",
				LookupId = "8-10286281",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "01242c47-2656-4a3f-904d-d0c2922bba65",
				Name = "Inner Wheel Club of Inverness",
				LookupId = "8-10286282",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3136a61-933f-4c12-97ae-7b8e3c904e14",
				Name = "Rotary Club of Whitby Endeavour",
				LookupId = "8-10286286",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c92fb2c5-e19a-403b-b609-975ae948ee87",
				Name = "Inner Wheel Club of Truro",
				LookupId = "8-10286288",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f397363a-d231-4997-ba4e-b18e1a921762",
				Name = "Rotary Club of Wallington",
				LookupId = "8-10286289",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "136a87f6-0379-4a68-b083-c2e299e07f18",
				Name = "Inner Wheel Club of Okehampton",
				LookupId = "8-10286291",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6d4014bd-22a3-4cc8-9fe4-b4e8464e4c4d",
				Name = "Rotary Club of St. Annes-on-the-Sea",
				LookupId = "8-10286292",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ea20bb28-02db-4e30-af79-0fc7fceb4cec",
				Name = "Rotary Club of Greenwich",
				LookupId = "8-10286293",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ff82d2a3-6df7-4ca6-a174-0b637ed415ef",
				Name = "Rotary Club of Furness",
				LookupId = "8-10286294",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3cd9e1af-cd31-40ce-a49d-92a1d4adca4b",
				Name = "Inner Wheel Club of Elland",
				LookupId = "8-10286310",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c1627550-3595-41f0-a4ac-6cf47c45bc8c",
				Name = "Rotary Club of Sutton Coldfield Vesey",
				LookupId = "8-10286311",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dacdeaf3-b7f1-4a87-880c-75c051ca3fb7",
				Name = "Rotary Club of Rutland",
				LookupId = "8-10286312",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a3a4664d-8a77-4f29-9bfb-c8777e8e6b13",
				Name = "Rotary Club of Merthyr Tydfil",
				LookupId = "8-10286313",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6836515c-f97e-4c71-a4c8-a43f130f6aca",
				Name = "Rotary Club of Romford",
				LookupId = "8-10286316",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ff5da6db-8721-4056-af94-968e461f03f5",
				Name = "Rotary Club of Sovereign Harbour",
				LookupId = "8-10286325",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4cc10f2f-aeed-44ab-938d-bddb01632686",
				Name = "Rotary District 1260",
				LookupId = "8-10286337",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dbc83ba2-b292-412b-a583-9cd583984816",
				Name = "Inner Wheel Club of Brentwood",
				LookupId = "8-10286338",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c8e85485-a85f-4076-a3c0-24c19a768ab2",
				Name = "Rotary Club of Henllys",
				LookupId = "8-10286342",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8f328783-d152-4296-a695-b41ede28a275",
				Name = "Rotary Club of Hatherleigh",
				LookupId = "8-10286369",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "02e98302-59ad-4bc2-b23e-0f5602eb1bb7",
				Name = "Rotary Club of Highcliffe-On-Sea",
				LookupId = "8-10286370",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "be421745-b5fe-433e-a927-6c65821221c9",
				Name = "Inner Wheel Club of West Wirral",
				LookupId = "8-10286379",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "36434838-450a-4758-98d0-d858d5370692",
				Name = "Inner Wheel Club of Ulverston",
				LookupId = "8-10286383",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3380bf71-547a-49af-b924-7552ec790aba",
				Name = "Rotary Club of Luton Someries",
				LookupId = "8-10286387",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3a0c67ec-ba4f-488f-aa98-7476d112e711",
				Name = "Rotary Club of Luton",
				LookupId = "8-10286396",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6224198a-b52b-4506-b47f-65d9f8cf497e",
				Name = "Inner Wheel Club of Perranzabuloe",
				LookupId = "8-10286400",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cf62ba83-7d0b-4241-a647-f7dc14848197",
				Name = "Rotary Club of Port Talbot",
				LookupId = "8-10286401",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "57c40b5c-219c-4d06-b309-c077dd57cad4",
				Name = "Inner Wheel Club of High Wycombe",
				LookupId = "8-10286408",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dfcc8abb-ccb7-4286-ab4a-3701eaf0e5fa",
				Name = "Inner Wheel Club Of Romsey Test",
				LookupId = "8-10286409",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "03bc5213-3573-48da-97ba-959f65b38400",
				Name = "Rotary Club of Chorley Astley",
				LookupId = "8-10286415",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "94002574-90f8-47ad-adb3-7c719fa322a2",
				Name = "Rotary Club of Farnham",
				LookupId = "8-10286417",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2963a2c9-170e-4d97-9588-e6de8bfee4cf",
				Name = "Rotary Club of Maidenhead Thames",
				LookupId = "8-10286418",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8bef99ea-7a9a-4af3-bd37-571ff1fc777d",
				Name = "Rotary Club of Cookstown",
				LookupId = "8-10286419",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "11b6b67f-ea7a-437f-a68d-50ef3aa14a97",
				Name = "Rotary Club of The City & Shoreditch",
				LookupId = "8-10286421",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "acc05f11-cda5-4299-b874-02c81086832d",
				Name = "Rotary Club of Ellesmere",
				LookupId = "8-10286425",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e4e47769-2c5d-458a-af08-d92f2a5a1af8",
				Name = "Rotary Club of Osgoldcross & Elmet",
				LookupId = "8-10286431",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1c38649f-62e7-47f0-bcca-81c92bfcd483",
				Name = "Rotary Club of Royston",
				LookupId = "8-10286432",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7292b8ca-5fa9-4f63-8f1f-6938c798b928",
				Name = "Rotary Club of Oldmeldrum",
				LookupId = "8-10286433",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cff83956-34ad-4381-8b1a-9cad13b0cd8b",
				Name = "Rotary Club Of Cork Douglas",
				LookupId = "8-10286435",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1c83bd64-4036-43b2-ba29-666f5cd158b2",
				Name = "Rotary Club of Onchan",
				LookupId = "8-10286441",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c9cf14a4-d3d2-4b91-b7bd-08cbdc787deb",
				Name = "Rotary Club of Stockport-Lamplighter",
				LookupId = "8-10286442",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "49d655fd-8f58-4c38-95ef-450b29b49617",
				Name = "Rotary Club of Melrose",
				LookupId = "8-10286444",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "87be2551-e587-486f-b76a-9d354ff43a76",
				Name = "Rotary Club of Hornsea & East Riding",
				LookupId = "8-10286445",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "67d1b008-7028-4415-9adb-49c01f80e324",
				Name = "Rotary Club of Blythe Bridge & District",
				LookupId = "8-10286447",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fb28fc0a-482b-40f1-b6d3-a47f0d660834",
				Name = "Rotary Club of Eccleshall Mercia",
				LookupId = "8-10286450",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cf2fbcd7-9998-4cb0-9b15-237476485471",
				Name = "Rotary Club of Bourne",
				LookupId = "8-10286460",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2d24ba98-f799-4e40-aed7-6e236aa43a77",
				Name = "Rotary Club of Misbourne Matins",
				LookupId = "8-10286462",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fe7630b2-b4cf-466d-8a53-5394e019a0f6",
				Name = "Inner Wheel Club of Ashtead",
				LookupId = "8-10286465",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "544d6685-215a-4b0d-82a0-f54e895067fe",
				Name = "Rotary Club of Keith",
				LookupId = "8-10286477",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b4d63818-554f-4336-a7fd-d4ca11983bb5",
				Name = "Rotary Club of Cheadle & District",
				LookupId = "8-10286478",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0b1fc39b-7330-44e5-bb83-e94222fa7a25",
				Name = "Rotary Club of Paisley Callants",
				LookupId = "8-10286481",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c57eb3e9-4bf2-49ee-8ef2-daced6f0f1e0",
				Name = "Bridge Ladies",
				LookupId = "8-10286488",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "92c17309-f525-4b0a-9bc3-ea4e9b80612d",
				Name = "Inner Wheel District 1",
				LookupId = "8-10286489",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ef574937-29a0-4f45-bd17-86d86a5941fa",
				Name = "Rotary Club of Luton North",
				LookupId = "8-10286491",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b38d50c8-a4e2-4430-9127-9d33115c0470",
				Name = "Rotary Club of Kirkcudbright",
				LookupId = "8-10286495",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "935ed992-801b-4b43-9de7-8a0782d11a7c",
				Name = "Rotary Club of Bradford on Avon",
				LookupId = "8-10286498",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e85ad111-7c1f-48d8-bdb5-58e33a96d187",
				Name = "Rotary Club of Ulverston",
				LookupId = "8-10286499",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d9f17938-358b-47e4-a304-28b1e1c71768",
				Name = "Rotary Club of Rugby Saturday Breakfast",
				LookupId = "8-10286500",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e095f74e-a82b-4763-8ea1-3c47903b30fc",
				Name = "Rotary Club of Wrekin, The",
				LookupId = "8-10286527",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c0ce047b-6169-467a-80ab-08c72516dabe",
				Name = "Rotary Club of Clifton (Bristol)",
				LookupId = "8-10286530",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ac70e576-d160-4358-a52c-bdec63c9062a",
				Name = "Rotary Club of Newmarket",
				LookupId = "8-10286533",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5aa6480f-ea36-4e74-8087-d9bc10fc02b6",
				Name = "Rotary Club of Liverpool South",
				LookupId = "8-10286534",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "adfce7d2-c0ab-4098-a299-6fbce0537c41",
				Name = "Rotary Club of Newbury",
				LookupId = "8-10286536",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "02014023-a18d-457b-b80f-428dab4e0b69",
				Name = "Rotary Club of Newquay",
				LookupId = "8-10286537",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "820ca54d-62ec-4d48-a8fb-f91eea675741",
				Name = "Rotary Club of Appleby",
				LookupId = "8-10286540",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bbca9a69-9d56-4a00-9f40-a31348ab9d41",
				Name = "Inner Wheel Club of Oxted & Limpsfield",
				LookupId = "8-10286542",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "46e174f2-f280-4d60-85d9-5ccc448ce80d",
				Name = "Rotary Club of Windsor St. George",
				LookupId = "8-10286549",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b95283a8-390d-4fc7-9ed0-dab045b0e60a",
				Name = "Rotary Club of Humberside",
				LookupId = "8-10286551",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3950d246-590c-46eb-8a98-04b02bf5421a",
				Name = "Inner Wheel Club of Oadby",
				LookupId = "8-10286555",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ac538e6a-05c4-4c54-b5fe-4cdd8e0def5a",
				Name = "Birmingham Rotaract & Cadbury Dental Practice",
				LookupId = "8-10286561",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b981e04a-160c-4009-be15-5c63062e1702",
				Name = "Rotary Club of Tarporley",
				LookupId = "8-10286571",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c467ef79-ed0b-472f-91d0-8528b95da811",
				Name = "Rotary Club of Sanderstead & Selsdon",
				LookupId = "8-10286649",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1157eddf-81c8-4401-aea9-6acfca0a1b21",
				Name = "Rotary Club of Howden",
				LookupId = "8-10286650",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1490fcdd-2620-4ca0-97f5-18dd3d68f09a",
				Name = "Rotary Club of Brit Valley",
				LookupId = "8-10286651",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "67a6a363-e586-4dcd-b07d-de316eebaea7",
				Name = "Rotary Club of Fleetwood",
				LookupId = "8-10286652",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0022b424-2464-4164-84c7-5aa16183a938",
				Name = "Inner Wheel Club of Hunstanton & District",
				LookupId = "8-10286660",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a729bc4d-2a0e-45c2-b1d8-a551d63e95a5",
				Name = "Inner Wheel Club of Bishop Auckland",
				LookupId = "8-10286665",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7c98ef1e-8f81-4b73-8c85-264535dfb2fb",
				Name = "Rotary Club of Taunton Vale",
				LookupId = "8-10286670",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "87a108c0-9e02-4c81-8969-ee30caa175fa",
				Name = "Rotary Club of Corby",
				LookupId = "8-10286677",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a27f8e3d-0e7d-416f-af37-4c9cdc52f66f",
				Name = "Inner Wheel Club of Deepings",
				LookupId = "8-10286678",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2c8a3d17-34e0-46b1-8926-c8a7a5e0e44f",
				Name = "Inner Wheel Club of Retford",
				LookupId = "8-10286686",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "af160667-e4b9-40d0-888a-563d91a6b755",
				Name = "Inner Wheel Club of Nuneaton",
				LookupId = "8-10286697",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "66e15085-4ed2-4f99-ae90-4029672b030e",
				Name = "Rotary Club of Glenrothes",
				LookupId = "8-10286701",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f749cce7-1568-4afc-9a48-4953aec74c71",
				Name = "Rotary Club of Harwich & Dovercourt",
				LookupId = "8-10286702",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7aca3b4e-5bcc-428e-9321-50330d358b6e",
				Name = "Rotary Club of Haverfordwest",
				LookupId = "8-10286703",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "06829c7f-b2a2-42fd-b8ef-48ee0829206d",
				Name = "Inner Wheel Club of Nantwich",
				LookupId = "8-10286713",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "77fe1e90-ac88-42a5-8d86-88a88fad0b64",
				Name = "Rotary Club of Wellingborough",
				LookupId = "8-10286714",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c7cbadea-1ada-4792-896b-e8bc196f925b",
				Name = "Rotary Club of Narberth & Whitland",
				LookupId = "8-10286728",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c05f457b-228d-4b30-9cd0-f4fb3c21c93c",
				Name = "Rotary Club of Alfreton",
				LookupId = "8-10286729",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ce444cd6-505b-4f79-a6a7-66e3f93a7a48",
				Name = "Rotary Club of Bristol South",
				LookupId = "8-10286730",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1af5e58c-5c82-45c5-9884-16d26f20340e",
				Name = "Rotary Club of Redruth",
				LookupId = "8-10286732",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f767cc2c-5a22-4cac-910c-a902c8cd698c",
				Name = "Rotary Club of Torquay",
				LookupId = "8-10286733",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fb16a175-303b-438d-a00c-e2c3af661eeb",
				Name = "Rotary Club of Swindon Phoenix",
				LookupId = "8-10286771",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c17d92de-760e-476f-891b-a70838d6a587",
				Name = "Rotary Club of Boscombe & Southbourne",
				LookupId = "8-10286783",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0131ca87-ad17-45be-95bb-809b72825812",
				Name = "Rotary Club of Frome Selwood",
				LookupId = "8-10286784",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2d1c0b88-0c80-4307-b7c5-25b151eeea93",
				Name = "Rotary Club of Holmfirth",
				LookupId = "8-10286785",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e7e14a57-6d7f-4de9-bd51-3def45cce7df",
				Name = "Inner Wheel Club of Denby Dale",
				LookupId = "8-10286793",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7e00330c-ef6a-4dad-aa63-129fa03a08da",
				Name = "Rotary Club of Hunstanton & District",
				LookupId = "8-10286796",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3f20d2f6-8d80-4012-b3f7-71b5293a3395",
				Name = "Rotary Club of Amwell",
				LookupId = "8-10286797",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7c987f42-924c-462d-b99a-bdf6d05c35c2",
				Name = "Inner Wheel Club of Keswick",
				LookupId = "8-10286798",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3d6e0ccf-f393-4e9c-8154-450c18ffa7db",
				Name = "Rotary Club of Kibworth & Fleckney",
				LookupId = "8-10286799",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cabebc9e-67bc-46a3-810e-3fe31a84b05e",
				Name = "Rotary Club of Liverpool Exchange",
				LookupId = "8-10286804",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c2fb5bae-3637-47b8-9786-789c8292a38c",
				Name = "Rotary Club of Gants Hill",
				LookupId = "8-10286808",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "31267538-bad9-4f1f-ae38-3bb914018c84",
				Name = "Rotary Club of Stone & District",
				LookupId = "8-10286817",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "267cbf6f-6a00-408b-9fd5-d45aee60bac1",
				Name = "Rotary Club of Rossendale",
				LookupId = "8-10286825",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2ce7c322-7e9e-44be-a81e-eb60b154f054",
				Name = "Rotary Club of Rugby",
				LookupId = "8-10286826",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "29184c87-63b5-459e-9a35-a8ec6e003f19",
				Name = "Rotary Club of Southwell",
				LookupId = "8-10286827",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6d16a8ed-ede9-4e19-875f-d29acfadbee0",
				Name = "Rotary Club of Hartlepool",
				LookupId = "8-10286830",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "38d6ab1f-9f3e-400e-9238-8eedb3304b9f",
				Name = "Rotary Club of Warrington",
				LookupId = "8-10286832",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f2327526-5655-4118-8375-40607894b103",
				Name = "Inner Wheel Club of Harpenden Village",
				LookupId = "8-10286841",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cd6c1796-7f11-432b-813e-e72302b9ba95",
				Name = "Rotary Club of Furness Peninsula",
				LookupId = "8-10286842",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "75424c33-a840-4306-aeb7-869db752c4a0",
				Name = "Rotary Club of Chesham",
				LookupId = "8-10286845",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5fb1c2fc-7295-4fd5-82a8-242eac88ee6a",
				Name = "Rotary Club of Clevedon Yeo",
				LookupId = "8-10286847",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b3606acb-4321-44a8-9801-b366dcee77df",
				Name = "Rotary Club of Mansfield",
				LookupId = "8-10286849",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "abd9b648-e56c-48f6-abf4-85c0e917af5a",
				Name = "Rotary District 1180",
				LookupId = "8-10286850",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aa4296ae-7173-4eb4-96d6-a4adc8ce83e1",
				Name = "Rotary Club of Woodh",
				LookupId = "8-10286858",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "39647113-9eb4-46f5-8e5a-eaeee3d6cf71",
				Name = "Rotary Club of Silloth-On-Solway",
				LookupId = "8-10286859",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "69516fb4-5d5d-4fd3-ac4a-51bac4699af4",
				Name = "Rotary Club of Alloway",
				LookupId = "8-10286862",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "18090471-c315-467b-bf61-d21b1969cbb5",
				Name = "Rotary Club Of Kings Lynn",
				LookupId = "8-10286863",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6b05db99-0fad-4912-942c-4a1ac3b237ef",
				Name = "Rotary Club of Saughall",
				LookupId = "8-10286877",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ff7ba8a0-c282-4ed4-a3a5-0a2be0146521",
				Name = "Rotary Club of Elgin",
				LookupId = "8-10286878",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1cf09cc1-9183-4f3f-96d9-a83da419c1c4",
				Name = "Inner Wheel Club of Liverpool",
				LookupId = "8-10286879",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4a367fa0-7a35-4f6b-b18f-08e670b5274a",
				Name = "Rotary Club of Tywyn",
				LookupId = "8-10286885",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7303fd16-0d1b-4412-9885-ba28e32575aa",
				Name = "Inner Wheel Club of Braunton",
				LookupId = "8-10286906",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bb5e84e3-ff75-476a-b484-4bea6765bbab",
				Name = "Rotary Club of Sligo",
				LookupId = "8-10286907",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0131586d-8e03-495c-b70f-d48734ca054d",
				Name = "Rotary Club of Barkingside",
				LookupId = "8-10286913",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "948b7f0c-9e25-419f-a078-d771a045aefa",
				Name = "Rotary Club of Newent & District",
				LookupId = "8-10286915",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5e9c8765-cf11-4dd5-9c5c-21f10b1b8628",
				Name = "Rotary Club of Strabane/Lifford",
				LookupId = "8-10286916",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8c49f7fc-13b7-4c20-b683-4e7f97ad9053",
				Name = "Inner Wheel Club of Wokingham",
				LookupId = "8-10286920",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "beaaa280-dc86-4430-99e6-bad259e30896",
				Name = "Rotary Club of Kingsbury & Kenton",
				LookupId = "8-10286922",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "324f0bdd-7078-445f-ab86-d3057b584ed7",
				Name = "Rotary Club of Oundle",
				LookupId = "8-10286923",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "016070c0-3c2d-45aa-b09e-90cf58d7f185",
				Name = "Inner Wheel Club of Tunbridge Wells",
				LookupId = "8-10286930",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "aedb9821-89ea-4662-b8e9-65eccb434c03",
				Name = "Rotary Club of West Lakeland",
				LookupId = "8-10286931",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "bb2bd137-4f95-444b-a51f-d94ad62690f9",
				Name = "Rotary Club of Stockton-on-Tees",
				LookupId = "8-10286933",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "9fbe41f3-10d4-41b1-b7c5-0a3d3096c43e",
				Name = "Inner Wheel Club of Bude",
				LookupId = "8-10286940",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1fb0a6e7-f199-4fa4-8b9e-8d0666a63dfe",
				Name = "Rotary Club of Perth",
				LookupId = "8-10286942",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ff27a0b3-0dc8-4ef4-b7de-1112f2a58535",
				Name = "Rotary Club of Blackpool",
				LookupId = "8-10286949",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d8a34ffb-1de8-45d9-9b4b-bf6338b5f0bd",
				Name = "Rotary Club of Dumfries",
				LookupId = "8-10286950",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "070cb406-eb8f-4946-9628-6802125b14e2",
				Name = "Inner Wheel Club of Waterlooville",
				LookupId = "8-10286960",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "90b81130-a0bc-45a9-a340-0b931eb698e3",
				Name = "Rotary Club of Brentwood",
				LookupId = "8-10286973",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "57eea136-9639-4d2e-9a43-c2ab931482fa",
				Name = "Inner Wheel Club of Dundee",
				LookupId = "8-10286974",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8ca2504a-a554-4612-9571-be930ec742da",
				Name = "Rotary Club of Spey Valley",
				LookupId = "8-10287003",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "036969b5-c1ed-4e5f-a1c9-7dd1285c3a9a",
				Name = "Inner Wheel Club of Redditch",
				LookupId = "8-10287012",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "888d1b75-d1a9-4c58-8620-b819954058ae",
				Name = "Inner Wheel Club of Hinckley Ambion",
				LookupId = "8-10287014",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "42aa6054-a48c-45bf-be8a-9ec96e8410be",
				Name = "Interact Club James Calvert Spence School",
				LookupId = "8-10287021",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "370050b7-ee6e-4471-8102-06dc06675cd5",
				Name = "Inner Wheel Club of Aberdare",
				LookupId = "8-10287037",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ec4ddcb7-01fe-41b3-bba6-b2411f20a51c",
				Name = "Rotary Club of Royal Leamington Spa",
				LookupId = "8-10287048",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e8fbc89b-3402-4b62-9697-1270212ad620",
				Name = "Rotary Club of Reading",
				LookupId = "8-10287074",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1a9ccc48-756f-425f-b4cd-4360c68f13dd",
				Name = "Rotary Club of Thurso",
				LookupId = "8-10287076",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5c5c29e9-2160-4a1e-b5b0-f3316db8f158",
				Name = "Rotary Club of Wymondham",
				LookupId = "8-10287084",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a8fd8118-2f6a-4530-9aee-4740b5cf0e95",
				Name = "Rotary Club of Monmouth",
				LookupId = "8-10287085",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dbe6ea1c-0219-4c58-b0a9-2bc2ca863a0a",
				Name = "Rotary Club of Ascot",
				LookupId = "8-10287087",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "990e998a-9b36-487a-bfbe-897a4b442ade",
				Name = "Rotary Club of Altrincham",
				LookupId = "8-10287090",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4f06e4ed-b89a-446e-8546-27e216aca95a",
				Name = "Inner Wheel Club of Pershore",
				LookupId = "8-10287096",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a102eb29-8332-426d-ad0a-726508ec1a28",
				Name = "Rotary Club of Preston",
				LookupId = "8-10287098",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ce312fd4-157f-4171-9dec-72b7120daaab",
				Name = "Inner Wheel Club of Aberfeldy & District",
				LookupId = "8-10287100",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "262c35d8-fa38-4bab-98cb-b08e477ab852",
				Name = "Rotary E-Club of East Anglia",
				LookupId = "8-10287104",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "cfaf7954-d0d6-493e-ac30-2add2d0ad48b",
				Name = "Rotary Club of Langholm",
				LookupId = "8-10287111",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f2eb2780-dd9e-4462-9dab-4c937c06ec0f",
				Name = "Rotary District 1150",
				LookupId = "8-10287115",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "314d5661-cb2a-40e4-9428-5430ea738d93",
				Name = "Rotary Club of Perth St. Johns",
				LookupId = "8-10287116",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "24574c3f-4116-406e-b75e-58aa3a0eaa24",
				Name = "Rotary Club of Skegness",
				LookupId = "8-10287118",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e232526f-a1e5-46d4-9bd7-f5ae79dc397b",
				Name = "Rotary Club of Spilsby",
				LookupId = "8-10287126",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0f6c5b78-fe54-4fe1-a46e-5d364ea8f793",
				Name = "Rotary Club of Worthing",
				LookupId = "8-10287146",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "87a82512-049d-4215-953b-be8725ac39c8",
				Name = "Rotary Club of Barnsley",
				LookupId = "8-10287147",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3d3225be-7f5c-4434-b24b-2312af4cbea8",
				Name = "Rotary Club of Ossett",
				LookupId = "8-10287149",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fc6e4f51-6365-455c-9e9d-ef3132552acf",
				Name = "Rotary Club of Ballycastle",
				LookupId = "8-10287150",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "24e2fb23-6f6c-4ca8-aee3-ceab3c4df773",
				Name = "Inner Wheel Club of Ipswich East",
				LookupId = "8-10287160",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "4f71eb81-b798-45db-adc4-4fa70c0d21b3",
				Name = "Rotary Club of Loudoun",
				LookupId = "8-10287165",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c901c32f-bf85-4c1e-8e58-d6441ae2e679",
				Name = "Inner Wheel Club of East Ham",
				LookupId = "8-10287171",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0336d383-ba74-4231-b5ae-cf6d5bf707b0",
				Name = "Rotary Club of Dunfermline, Carnegie",
				LookupId = "8-10287172",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "50cde61e-3579-4876-81fa-1bedc34f00b3",
				Name = "Rotary Club of New Forest",
				LookupId = "8-10287200",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "65b24f6b-c1dc-4f19-890d-fbccc38451bd",
				Name = "Rotary Club of Paddington",
				LookupId = "8-10287215",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "7c049d28-35c1-4bc3-9b07-ae2ab1303959",
				Name = "Rotary Club of Rayleigh Mill",
				LookupId = "8-10287219",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5eaa0850-18bb-4f49-96ef-cdeef89a4688",
				Name = "Rotary Club of Rotherham",
				LookupId = "8-10287220",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "44e20246-4a1c-4dfe-9edf-75b05f3184d5",
				Name = "Rotary Club of Portishead",
				LookupId = "8-10287230",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "022e2465-c66d-462b-b272-495b610ede28",
				Name = "Rotary Club of Tottington & Bury West",
				LookupId = "8-10287234",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "54ac0f7b-e555-4dc4-b680-bedd292d0f57",
				Name = "Rotary Club of Ythan Valley",
				LookupId = "8-10291681",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3d1f1145-6e6d-4785-9a36-db860a5cfb25",
				Name = "Inner Wheel Club Of Musselburgh",
				LookupId = "8-10299819",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a837cfef-b243-4fd3-8816-f214775075bb",
				Name = "The Inner Wheel Club Of Newent & District",
				LookupId = "8-10300070",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "b1b857ac-71e4-43c6-a722-3145c2640e30",
				Name = "Inner Wheel Club Of Sandbach",
				LookupId = "8-10323247",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "80a4de03-61ed-4816-bd6a-a1bf3393a34d",
				Name = "Inner Wheel Club Of Crook",
				LookupId = "8-10323258",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2f52db0e-b486-43c3-8557-5e01db44ee49",
				Name = "Inner Wheel Club Of Normanton",
				LookupId = "8-10323260",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f0c94c37-f1ea-440a-ab2b-4f6533847d6b",
				Name = "Inner Wheel Club Of Wanstead & Woodford",
				LookupId = "8-10323621",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "035395d6-5107-4a4f-b3b0-93f6f6cd8976",
				Name = "Inner Wheel Club Of Barnsley",
				LookupId = "8-10324065",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "73acf83c-c5a5-4ac8-b8f9-1b9db71f8dfe",
				Name = "The Inner Wheel Club Of Alloway",
				LookupId = "8-10331154",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "07dbc5d1-6c09-422a-8244-c3d3c07efcdb",
				Name = "Inner Wheel Club Of Brampton And Longtown",
				LookupId = "8-10340998",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "377cbc1f-5fc0-4970-b2ad-46e8342550f8",
				Name = "Rotary Club Of Currie Balerno",
				LookupId = "8-10342581",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b2578b7-ef9f-484c-a284-3e0f6cbb7e8a",
				Name = "Rotary Club Of St Andrews",
				LookupId = "8-10345335",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d7537b3f-fc44-405f-abcf-4515a2ae17c3",
				Name = "Didcot Interact Club",
				LookupId = "8-10345337",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1b675f81-7716-4ffa-84df-7a3ad548e7ff",
				Name = "Rotary E-Club Of South West Peninsula",
				LookupId = "8-10348228",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ce5c3db5-8125-4379-9d88-85e0c6b95676",
				Name = "Rotary Club Of Woodhall Spa",
				LookupId = "8-10348842",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3820abcf-0b51-4986-b338-773748d482bd",
				Name = "Rotary Club Of Carnegie Dunfermline",
				LookupId = "8-10349059",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d3fd2744-30ad-498d-98f9-c8f54b88a761",
				Name = "Rotary Club Of Burford And Kingham",
				LookupId = "8-10349084",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "12d796a2-76d6-4cd9-8037-474d07eed970",
				Name = "Rotary E-Club Of Thames Valley",
				LookupId = "8-10349487",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3305f13a-52d0-49ce-8358-ad45d313a3c0",
				Name = "Rotary Club Of Malvern",
				LookupId = "8-10356776",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "792b69c3-19e3-457a-899c-58d48c6f9ac7",
				Name = "Rotary Club Of Sarum",
				LookupId = "8-10357697",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "c8868747-aa7f-4a32-b977-60d4dce38f77",
				Name = "Rotary Club Of Litchfield",
				LookupId = "8-10360444",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8f05eb59-19d3-4997-b531-b7478fd4d51b",
				Name = "Rotary Club Of Moors Gateway",
				LookupId = "8-10360556",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "dba41a9f-0ddf-4f09-904d-7ecdd4937329",
				Name = "Inner Wheel Of Chipping Norton",
				LookupId = "8-10361052",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "3b87bcab-2bc4-4c59-98ae-b472c32fd909",
				Name = "Rotary Club Of Billericay Town",
				LookupId = "8-10362162",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "0ba6ef64-062a-4df1-beca-eda6e23955af",
				Name = "Inner Wheel Club Of Beccles",
				LookupId = "8-10362798",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "a80a98c1-2415-41e7-a191-1b584f9624e5",
				Name = "Rotary Club Of Borderlands (Passport Group)",
				LookupId = "8-10366701",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "8a761d59-15cc-47ad-9e88-220711fee7fb",
				Name = "Rotary Club of Cuckfield Lindfield and Haywards Heath",
				LookupId = "8-10368036",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fad0f6de-9b28-492f-81c2-b93a9f3626b9",
				Name = "Rotary Club Of Hereford Elgar",
				LookupId = "8-10368767",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "e7f1dcd8-c3e8-4e0f-b40a-0a22a53a1418",
				Name = "Rotary Club Of Angmering South Downs",
				LookupId = "8-10368813",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "2a41ccc2-ab72-410c-b8f5-809e3433e7e0",
				Name = "Rotary Club Of Angus Glens",
				LookupId = "8-10369151",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "1745146a-823c-431b-bcff-e03ad2e41d93",
				Name = "Rotary Club Of Burnham On Sea District",
				LookupId = "8-10369318",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "33447b76-a62b-45d1-8e98-f88453f8ca4d",
				Name = "Rotary Club Of Danbury & Villages",
				LookupId = "8-10370057",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "f1cf8c89-d0c5-44b0-9873-e09e80bc8ac9",
				Name = "Rotary Club Of Canvey Coast Satellite",
				LookupId = "8-10371102",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "ccf4ba83-14eb-4108-bafa-5c89f9c55e02",
				Name = "Rotary Club Of Cheltenham Future",
				LookupId = "8-10372771",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "514031b5-9d82-4444-9c38-01ca8f705356",
				Name = "K W S Interact Club",
				LookupId = "8-10372833",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "45a93896-628b-4ac2-9de3-c2b326bf5ad7",
				Name = "Rotary Club Of Crowborough",
				LookupId = "8-10375193",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "32e2840f-f113-4857-87f0-c89a1f20a9dd",
				Name = "Inner Wheel Club Of Wilton",
				LookupId = "8-10376525",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "d31ae2ec-9e93-4ce1-8012-d0973f19704a",
				Name = "Inner Wheel Club Of Gosport",
				LookupId = "8-10380221",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "fb2288ee-0b61-4779-afa0-16238ac27290",
				Name = "Inner Wheel Club Of Llanfairfechan And Penmaenmawr",
				LookupId = "8-10380356",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "6feac267-8722-4cab-a409-c8cf6100e17c",
				Name = "Rotary Club Of Exmouth",
				LookupId = "8-10381280",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "130b7b93-197d-4b20-9137-970da4999376",
				Name = "Rotary Global Hub",
				LookupId = "8-10382051",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "5bd2d265-90f9-4ff2-9e30-bcacee72973b",
				Name = "Inner Wheel Club Of Rutland",
				LookupId = "8-10382545",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "828bd156-bb53-444f-8130-9a74c4fc7e94",
				Name = "Rotary Club Of Chinnor",
				LookupId = "8-10383898",
				Country = "United Kingdom"
			},
			new
			{
				OrganisationId = "09bb53f4-139a-42aa-895a-e41ca1f33d7f",
				Name = "Glenbogle Rotary",
				LookupId = "8-10386367",
				Country = "United Kingdom"
			}
		);

	}
}