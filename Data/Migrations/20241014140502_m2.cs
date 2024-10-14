using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LookupFunction.Data.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Organisations",
                columns: new[] { "OrganisationId", "Country", "LookupId", "Name" },
                values: new object[,]
                {
                    { "0022b424-2464-4164-84c7-5aa16183a938", "United Kingdom", "8-10286660", "Inner Wheel Club of Hunstanton & District" },
                    { "003f7f27-020d-4391-9f35-7d6890a1f1a2", "United Kingdom", "8-10284018", "Rotary Club of Bournemouth East Cliff" },
                    { "0046c3df-dc9e-4f33-a2c5-839fa5a92e07", "United Kingdom", "8-10282633", "Rotary Club of Woking" },
                    { "007b7035-cea3-41ed-b082-6b143dd68622", "United Kingdom", "8-10243672", "Inner Wheel Club of Mendip" },
                    { "008155f1-0ecc-49ae-bf9c-033bae5f30e5", "United Kingdom", "8-10250382", "Rotary Club of Northallerton" },
                    { "008a049a-6dea-4135-ba80-9430eb1e782b", "United Kingdom", "8-10277308", "Rotary Club of Saltram Plympton" },
                    { "00f256a4-321e-43bf-ba80-d8a2f4e7784a", "United Kingdom", "8-10250915", "Rotary Club of Doncaster" },
                    { "0114f0c9-881b-4ac3-866e-88d30b22f1f3", "United Kingdom", "8-10242534", "Rotary Club of North Fife" },
                    { "0122ea03-c82a-45c9-8505-93309ba4f8ec", "United Kingdom", "8-10281511", "Rotary Club of Bletchley" },
                    { "01242c47-2656-4a3f-904d-d0c2922bba65", "United Kingdom", "8-10286282", "Inner Wheel Club of Inverness" },
                    { "0131586d-8e03-495c-b70f-d48734ca054d", "United Kingdom", "8-10286913", "Rotary Club of Barkingside" },
                    { "0131ca87-ad17-45be-95bb-809b72825812", "United Kingdom", "8-10286784", "Rotary Club of Frome Selwood" },
                    { "013a0a73-1a16-42ee-be0f-2e644f91f269", "United Kingdom", "8-10283816", "Inner Wheel Club of Colwyn Bay" },
                    { "014fbab9-0583-493d-8251-3d1fded8076c", "United Kingdom", "8-10283425", "Inner Wheel Club of Denbigh" },
                    { "016070c0-3c2d-45aa-b09e-90cf58d7f185", "United Kingdom", "8-10286930", "Inner Wheel Club of Tunbridge Wells" },
                    { "018ff252-494b-493f-8128-ac991ede573e", "United Kingdom", "8-10282714", "Rotary Club of Parkstone" },
                    { "019d50cd-755f-45b1-95f7-6bf1aa90c11c", "United Kingdom", "8-10277218", "Interact Club of St Matthew's Academy, Saltcoats" },
                    { "01b56ef6-15eb-454c-bb6a-4388538aaaa2", "United Kingdom", "8-10244572", "Inner Wheel Club of Cosham" },
                    { "01f88ff4-0848-4edd-b191-7751bf6efab4", "United Kingdom", "8-10251551", "Rotary Club of Eastleigh" },
                    { "02014023-a18d-457b-b80f-428dab4e0b69", "United Kingdom", "8-10286537", "Rotary Club of Newquay" },
                    { "0207b410-6ab7-49cb-845e-9a85cecc9b27", "United Kingdom", "8-10282913", "Rotary Club of Batley" },
                    { "022e2465-c66d-462b-b272-495b610ede28", "United Kingdom", "8-10287234", "Rotary Club of Tottington & Bury West" },
                    { "02afd97c-9b72-40a2-83cb-55d6b2a9c7cc", "United Kingdom", "8-10277377", "Rotary Club of Folkestone" },
                    { "02c5b112-f033-451e-865a-2a96d05800e9", "United Kingdom", "8-10277057", "Rotary Club of Blaby" },
                    { "02e98302-59ad-4bc2-b23e-0f5602eb1bb7", "United Kingdom", "8-10286370", "Rotary Club of Highcliffe-On-Sea" },
                    { "03090044-4eb4-4a83-b11e-62a4e5eb5c03", "United Kingdom", "8-10242802", "Rotary Club of Wigan" },
                    { "031bcd64-a03a-4a0d-b967-6eb4096790ea", "United Kingdom", "8-10250587", "Rotary Club of Ellon" },
                    { "0336d383-ba74-4231-b5ae-cf6d5bf707b0", "United Kingdom", "8-10287172", "Rotary Club of Dunfermline, Carnegie" },
                    { "0342244b-2b5e-4578-8add-6aa987874a45", "United Kingdom", "8-10277736", "Inner Wheel Club of Bodmin" },
                    { "035395d6-5107-4a4f-b3b0-93f6f6cd8976", "United Kingdom", "8-10324065", "Inner Wheel Club Of Barnsley" },
                    { "036969b5-c1ed-4e5f-a1c9-7dd1285c3a9a", "United Kingdom", "8-10287012", "Inner Wheel Club of Redditch" },
                    { "03743a60-da99-464b-baf0-9bf6fd8598e7", "United Kingdom", "8-10277451", "Rotary Club of Bridgend" },
                    { "037e7a5d-eceb-4624-aa3c-3a3ea3aa0c2d", "United Kingdom", "8-10281469", "Rotary Club of Rhondda" },
                    { "03940c2d-101f-4096-9bac-b07981a70ce3", "United Kingdom", "8-10252066", "Rotary Club of St. Ives, Cambridgeshire" },
                    { "03bc5213-3573-48da-97ba-959f65b38400", "United Kingdom", "8-10286415", "Rotary Club of Chorley Astley" },
                    { "03d97648-0d95-4f23-b5c4-7f1e2a6c1387", "United Kingdom", "8-10249103", "Rotary Club of Hungerford" },
                    { "03fcf947-d165-4926-9882-9266b4c7bb44", "United Kingdom", "8-10284077", "Rotary Club of Medway Sunlight" },
                    { "042f945b-8849-4539-a09c-ed2448db9427", "United Kingdom", "8-10276692", "Rotary Club of Knowle & Dorridge" },
                    { "045aba1e-6ad4-4287-a713-614eb08faff7", "United Kingdom", "8-10270794", "Rotary Club of Watton" },
                    { "0485734c-7fbf-4754-bd45-e2dab3951144", "United Kingdom", "8-10282639", "Rotary Club of Derby" },
                    { "04a273d7-1b7d-4d71-971c-724d82445e07", "United Kingdom", "8-10281217", "Rotary Club of Lagan Valley" },
                    { "04c0dbc4-8707-4b80-8eca-8e0ae08ff503", "United Kingdom", "8-10277625", "Inner Wheel Club of Ashton-Under-Lyne" },
                    { "04c6a878-6850-4451-8b6a-1a9a7f40665c", "United Kingdom", "8-10278758", "Inner Wheel Club of Matlock" },
                    { "04c719a9-eff2-42a5-b6fd-6e9f71765efa", "United Kingdom", "8-10283710", "Rotary Club Of Swindon North And Thamesdown" },
                    { "04fe1542-e3b6-4e8c-95df-07cfdceff8c9", "United Kingdom", "8-10283452", "Rotary Club of Skipton Craven" },
                    { "05130510-97b0-4c28-b9fa-81fde4172c4f", "United Kingdom", "8-10282836", "Rotary Club of Forfar" },
                    { "052bffbb-adac-4b3c-bf66-f1623d38eab5", "United Kingdom", "8-10281141", "Rotary Club Of Cheam & Sutton" },
                    { "058bd33b-f0f4-4245-969d-1dec71d2d2c4", "United Kingdom", "8-10279415", "Inner Wheel Club of The Soar Valley" },
                    { "05935aa1-0039-4bdc-93fb-addef29ddd4a", "United Kingdom", "8-10242265", "Rotary District 1110" },
                    { "0596ead7-475b-4952-9b81-b579f5702a0d", "United Kingdom", "8-10280240", "Rotary Club of Guildford Chantries" },
                    { "061cdbd2-6d9a-4b61-89cb-da20c24f64ac", "United Kingdom", "8-10278981", "Inner Wheel Club of Marlborough" },
                    { "065cf40a-964b-4a7d-9a63-be1df76dccb0", "United Kingdom", "8-10280109", "Rotary Club of Hertford Shires" },
                    { "0666a329-c339-4a93-92cb-b1ccbb885f03", "United Kingdom", "8-10265060", "Rotary Club of Glossop" },
                    { "06829c7f-b2a2-42fd-b8ef-48ee0829206d", "United Kingdom", "8-10286713", "Inner Wheel Club of Nantwich" },
                    { "0690fe2d-e1e3-475c-87a8-d3f50f144ed2", "United Kingdom", "8-10276691", "Rotary Club of Jersey" },
                    { "069fa75d-8d48-47c3-b1d3-5571571f8b86", "United Kingdom", "8-10282950", "Rotary District 1145" },
                    { "06a1dd91-7807-4df5-85c4-6023fdf23dd4", "United Kingdom", "8-10278235", "Rotary Club of Westgate & Birchington" },
                    { "06b7c446-9dd8-4e6c-b1e9-b66439a6f1f8", "United Kingdom", "8-10280006", "Rotary Club of Longridge and North Preston" },
                    { "06ef1e65-838f-4a74-a2ba-c22f4adca871", "United Kingdom", "8-10283840", "Rotary Club of Gorleston-On-Sea" },
                    { "06f73052-8c01-455e-a2b5-0d132b720574", "United Kingdom", "8-10252078", "Rotary Club of Southend-on-Sea" },
                    { "070cb406-eb8f-4946-9628-6802125b14e2", "United Kingdom", "8-10286960", "Inner Wheel Club of Waterlooville" },
                    { "0716858e-a4e6-4c36-90f2-986eb66c0033", "United Kingdom", "8-10283603", "Rotary Club of Bramhall & Woodford" },
                    { "07256be2-5fb1-435f-a519-b91682e81e7e", "United Kingdom", "8-10283966", "Rotary Club of Stort Valley" },
                    { "074ec71d-8761-4fe6-8fdf-8905c5faf9c0", "United Kingdom", "8-10283803", "Rotary Club of Lindum Lincoln" },
                    { "07706f76-7d10-4448-9669-465c33b6642d", "United Kingdom", "8-10283990", "Rotary Club of Welwyn Garden City" },
                    { "07bbd7c1-f8e0-4e60-91c3-5912276176f4", "United Kingdom", "8-10283901", "Rotary Club of Seaburn" },
                    { "07cc0360-657a-475a-a2ef-49a69a7581b8", "United Kingdom", "8-10282749", "Rotary Club of North Norfolk" },
                    { "07cd6da2-34b7-463f-97ac-a8bd506db9f5", "United Kingdom", "8-10250094", "Rotary Club of Ilminster" },
                    { "07d1ebe6-d784-4b2c-9492-0774e66ab1d5", "United Kingdom", "8-10278140", "Inner Wheel Club of Ware" },
                    { "07dbc5d1-6c09-422a-8244-c3d3c07efcdb", "United Kingdom", "8-10340998", "Inner Wheel Club Of Brampton And Longtown" },
                    { "08483643-f5d6-4440-b8a2-63412d788d96", "United Kingdom", "8-10257179", "Rotary Club of Nottingham" },
                    { "0862e8c6-74d8-4a95-b5f5-94d65d419f40", "United Kingdom", "8-10278190", "Rotary Club of Limavady" },
                    { "0874eb8c-5b65-4f2d-a2c5-3b569b66d926", "United Kingdom", "8-10243129", "Rotary Club of Stratford-upon-Avon" },
                    { "08755e4b-b802-44d4-81cc-95dbd463d590", "United Kingdom", "8-10249101", "Rotary Club of Bishops Waltham" },
                    { "08b1ba4b-2470-4b51-af9a-592e33e1535b", "United Kingdom", "8-10282702", "Inner Wheel Club of Tyldesley" },
                    { "08cdaaa2-27ea-4671-9ea1-32f0340d777b", "United Kingdom", "8-10281535", "Rotary Club of Bala & Penllyn" },
                    { "08f52352-1fa7-412a-b48c-5ee8d9c77820", "United Kingdom", "8-10257167", "Rotary Club of Orpington Crofton" },
                    { "0919f6dc-0ed5-4c7e-b583-0e37cee6b1b2", "United Kingdom", "8-10251531", "Rotary Club of Chard" },
                    { "09471209-c83e-40f1-bf8f-744903c98d97", "United Kingdom", "8-10284027", "Rotary Club of Barrow Meridian" },
                    { "09bb53f4-139a-42aa-895a-e41ca1f33d7f", "United Kingdom", "8-10386367", "Glenbogle Rotary" },
                    { "09c145cd-e313-44d0-b09e-7841a09b36a9", "United Kingdom", "8-10280295", "Rotary Club of Ferndown" },
                    { "09c95de1-e1f4-45a0-8982-730912fd3682", "United Kingdom", "8-10249875", "Rotary Club of Heywood" },
                    { "09ec2708-6e88-4b23-9dc5-f31453178a8f", "United Kingdom", "8-10280683", "Rotary Club of Shanklin" },
                    { "0a1eac04-3115-4edc-8a55-ebfc1460c601", "United Kingdom", "8-10282018", "Inner Wheel Club of Stroud" },
                    { "0a2b10e6-bc4a-47ff-a008-5aacb9dbeac3", "United Kingdom", "8-10247062", "Rotary Club of Peterborough Minster" },
                    { "0a2c1ad3-7c8b-4b36-93c6-1e6401d06916", "United Kingdom", "8-10280784", "Inner Wheel Club of Wrexham Erddig" },
                    { "0a57e493-df34-4589-bb02-5a82a0458416", "United Kingdom", "8-10281364", "Rotary Club of Godalming Woolsack" },
                    { "0a58aa4a-0641-4e21-bad7-7356899e6051", "United Kingdom", "8-10278418", "Rotary Club of Newry" },
                    { "0a87d44b-3975-44a4-9771-7799000c410d", "United Kingdom", "8-10246652", "Inner Wheel Club of Aberdeen" },
                    { "0a967cb0-e3b5-47ad-b5b7-d3cf2eaef897", "United Kingdom", "8-10278080", "Rotary Club of Montrose" },
                    { "0ab8c932-cced-4c82-9d2e-e488d442458b", "United Kingdom", "8-10277310", "Rotary Club of Tiverton" },
                    { "0abbeea5-570b-4844-8cd5-ad008693c6a0", "United Kingdom", "8-10243222", "Rotary Club of Reading Abbey" },
                    { "0abcd325-e0b8-453f-8221-b54385740275", "United Kingdom", "8-10280836", "Rotary Club of Longniddry & District" },
                    { "0adbda02-3349-48b4-905d-169d30be33cf", "United Kingdom", "8-10282717", "Inner Wheel Club Of Clacton On Sea" },
                    { "0b0d44dd-1a76-48a0-9588-b845627a3644", "United Kingdom", "8-10238739", "Rotary Club of Gainsborough" },
                    { "0b16597a-a438-463d-886f-cac48b441382", "United Kingdom", "8-10279670", "Rotary Club of Tooting" },
                    { "0b17da67-9037-4e2c-bec8-423a5cd27e12", "United Kingdom", "8-10283699", "Rotary Club of Arbury" },
                    { "0b1fc39b-7330-44e5-bb83-e94222fa7a25", "United Kingdom", "8-10286481", "Rotary Club of Paisley Callants" },
                    { "0b650d35-d891-486b-afcd-dcc855c80e95", "United Kingdom", "8-10275997", "Rotary Club of Newport, Shropshire" },
                    { "0ba1622d-1811-4f90-a4cd-1238da398ee1", "United Kingdom", "8-10240828", "Inner Wheel Club of Seaton" },
                    { "0ba6ef64-062a-4df1-beca-eda6e23955af", "United Kingdom", "8-10362798", "Inner Wheel Club Of Beccles" },
                    { "0bbd654b-5669-4b91-a9db-873212c33ac2", "United Kingdom", "8-10278400", "Rotary Club of Chelmsford Phoenix" },
                    { "0bc52f18-df7f-41f6-bc78-5cbb56d0ebe7", "United Kingdom", "8-10275247", "Rotary Club of Ormskirk Clocktower" },
                    { "0bef81a6-99e3-4687-bccd-5d28d990f546", "United Kingdom", "8-10265054", "Rotary Club of Bournemouth North" },
                    { "0c009390-3b5a-48d2-b7b6-fb38b65996c5", "United Kingdom", "8-10284123", "Rotary Club of Jersey-de La Manche" },
                    { "0c16acec-b435-4584-bc2a-770fa3897be6", "United Kingdom", "8-10283929", "Rotary Club of Caterham Harestone" },
                    { "0c44f26d-a0cc-4a02-90f8-d1c8e83260b1", "United Kingdom", "8-10280293", "Rotary Club of Beckenham" },
                    { "0c48c9c2-e7e2-43e6-8e88-d1d6b24e3766", "United Kingdom", "8-10248106", "Rotary Club of Mexborough & District" },
                    { "0c92af99-d4dc-4e64-a745-b7c536933232", "United Kingdom", "8-10278919", "Rotary Club of Guisborough & Great Ayton" },
                    { "0c9d112c-1f32-483d-baee-2d124ed703cf", "United Kingdom", "8-10250712", "Inner Wheel Club of Flitwick Vale" },
                    { "0cbb1d2f-6d70-4ad7-a9e8-005dbab2137f", "United Kingdom", "8-10252211", "Rotary Club of Aylesbury Hundreds" },
                    { "0cd99ba3-b8cb-49ef-9e06-0b470458e38d", "United Kingdom", "8-10239017", "Rotary Club of Market Drayton" },
                    { "0cdb6561-cab9-4f2a-b31a-42721e402568", "United Kingdom", "8-10241411", "Inner Wheel Club of Cardiff" },
                    { "0cec2be9-9c98-4855-ab47-ed103385b919", "United Kingdom", "8-10251123", "Rotary Club of St. Helens" },
                    { "0cf24239-a379-440c-88a4-2e543c271cc9", "United Kingdom", "8-10260414", "Inner Wheel Club of Herford" },
                    { "0cf4d397-6474-486a-b4ab-7b003bffb691", "United Kingdom", "8-10283636", "Rotary Club of Omagh" },
                    { "0d25c162-39b3-4161-9208-1f67df08dc6d", "United Kingdom", "8-10282131", "Interact Club of Ramsbottom" },
                    { "0d37be34-bbff-45f2-a6ea-45daa4d23888", "United Kingdom", "8-10282750", "Inner Wheel Club of Hitchin" },
                    { "0d626674-2c4e-4d18-9c29-030ac349da97", "United Kingdom", "8-10281114", "Rotary Club of Falkirk" },
                    { "0d66b507-08d0-4ba4-8fa8-a7385a6e6da2", "United Kingdom", "8-10284156", "Inner Wheel Club of Carrickfergus" },
                    { "0d69919d-d52b-4b2a-b40f-0ae0abc82d20", "United Kingdom", "8-10239589", "Rotaract Club of West Berkshire" },
                    { "0d885433-c6e8-4e06-bd90-8ec68d4ee0d8", "United Kingdom", "8-10280597", "Rotary Club of Launceston" },
                    { "0db3ae0e-aaaf-45c1-8e79-41c85679ad27", "United Kingdom", "8-10243606", "Rotary Club of Aylesbury" },
                    { "0dc03fba-30a4-41ca-828c-983dc626a442", "United Kingdom", "8-10281128", "Rotary Club of Cookham Bridge" },
                    { "0ddd53f1-17b2-4987-aa43-37f8af7fc5bc", "United Kingdom", "8-10278195", "Rotary Club of Barnard Castle" },
                    { "0e28c640-6f98-4b83-aa50-77bc173ae65c", "United Kingdom", "8-10278869", "Rotary Club of Sandy" },
                    { "0e2b6c4b-a1c5-4749-9805-e029d420bf80", "United Kingdom", "8-10242164", "Rotary Club of Brewood & District" },
                    { "0e5017d9-ed65-44d1-ad6b-f124f8650cf5", "United Kingdom", "8-10246954", "Inner Wheel Club of Welshpool" },
                    { "0e958c60-1656-4d6e-8336-65472df9fc38", "United Kingdom", "8-10260822", "Rotary Club of Wroxham Bure Valley" },
                    { "0ead1ff8-55cd-4223-b0bc-cb3c69849f58", "United Kingdom", "8-10248862", "Inner Wheel Club of Dumbarton" },
                    { "0ec42651-2f21-489c-ba7b-1342ee699df8", "United Kingdom", "8-10250683", "Inner Wheel Club of Falkirk" },
                    { "0ee9b38b-fe4e-438f-9c68-de15faa0d47c", "United Kingdom", "8-10278583", "Rotary Club of Poulton-Le-Fylde" },
                    { "0ef0464a-0e0d-4bbb-9a5f-f1935da51c91", "United Kingdom", "8-10283451", "Rotary Club of Inverurie" },
                    { "0f4d0498-f414-4679-be5d-7d4d5a2535cd", "United Kingdom", "8-10285778", "Rotary Club of Buxton" },
                    { "0f508b2e-9693-4ecd-a800-3523e24c7d79", "United Kingdom", "8-10279362", "Rotary Club of Bransgore & District" },
                    { "0f6c5b78-fe54-4fe1-a46e-5d364ea8f793", "United Kingdom", "8-10287146", "Rotary Club of Worthing" },
                    { "0f737e7c-bbe6-4434-b5e8-77d36e4a15b2", "United Kingdom", "8-10285924", "Inner Wheel Club of Pembroke" },
                    { "0f749734-c38b-45a6-af01-cf94cdd51592", "United Kingdom", "8-10253322", "Rotary Club of Thorpe Bay" },
                    { "0f9fe087-098c-451c-970a-cc1957200bac", "United Kingdom", "8-10280605", "Rotary Club of Witney" },
                    { "1010b60d-61d9-4c11-90ae-6471dd2c09bd", "United Kingdom", "8-10251550", "Inner Wheel Club of Dunstable" },
                    { "104daea8-fdb1-40bf-972b-b254434e7efa", "United Kingdom", "8-10282806", "Rotary Club of Eckington & District" },
                    { "1079f03f-31fa-4623-b7cc-a283e386412a", "United Kingdom", "8-10250812", "Rotary Club of Bloxwich Phoenix" },
                    { "10bea18c-9e9d-4d70-aba1-e3c3de2b75ac", "United Kingdom", "8-10278920", "Rotary Club of Harpenden Village" },
                    { "11554fd0-bcca-40f4-9be2-2f73bbb7a36a", "United Kingdom", "8-10248761", "Rotary Club of Maidenhead" },
                    { "1157eddf-81c8-4401-aea9-6acfca0a1b21", "United Kingdom", "8-10286650", "Rotary Club of Howden" },
                    { "11923155-7e0d-485f-a471-322e13109ca4", "United Kingdom", "8-10249396", "Inner Wheel Club of Crayford" },
                    { "11ac270e-473d-42c7-bf78-9e7ee31015a8", "United Kingdom", "8-10281512", "Rotary Club of Chippenham Wiltshire Vale" },
                    { "11b6b67f-ea7a-437f-a68d-50ef3aa14a97", "United Kingdom", "8-10286421", "Rotary Club of The City & Shoreditch" },
                    { "11f04fea-c60e-47eb-a341-0931da1944e7", "United Kingdom", "8-10280613", "Rotary Club of Llanidloes" },
                    { "12597235-c152-4cbb-8b14-c375863cde3f", "United Kingdom", "8-10281413", "Rotary Club of Mumbles" },
                    { "126d2576-f766-4de9-915e-021c3d628b1d", "United Kingdom", "8-10277396", "Rotary Club of Pontllanfraith" },
                    { "12757299-c47e-485a-9764-ccb6beb2936a", "United Kingdom", "8-10282952", "Rotary Club of Dinas Powys" },
                    { "12a7ed40-aa7b-4bfc-b499-86643d6e9b0e", "United Kingdom", "8-10279349", "Rotary Club of Watton & District" },
                    { "12d796a2-76d6-4cd9-8037-474d07eed970", "United Kingdom", "8-10349487", "Rotary E-Club Of Thames Valley" },
                    { "12da9be1-8690-4cd8-89cb-d3e718d89b9c", "United Kingdom", "8-10247279", "Rotary Club of Haworth & Worth Valley" },
                    { "130b7b93-197d-4b20-9137-970da4999376", "United Kingdom", "8-10382051", "Rotary Global Hub" },
                    { "134b67ac-095f-4e81-b290-bdef262ff7ae", "United Kingdom", "8-10241744", "Rotary Club of Crowthorne and Sandhurst" },
                    { "136a87f6-0379-4a68-b083-c2e299e07f18", "United Kingdom", "8-10286291", "Inner Wheel Club of Okehampton" },
                    { "13b98da5-b3ba-4186-85bc-0c0168dd0503", "United Kingdom", "8-10282369", "Rotary Club of Pwllheli" },
                    { "13ed8359-e00f-4a0b-9e3e-78f6ce21735a", "United Kingdom", "8-10249025", "Inner Wheel Club of Keyworth & Ruddington" },
                    { "1414cb7c-08cc-4a69-a0cf-8ed9c12ec605", "United Kingdom", "8-10239867", "Rotary Club of Ilfracombe" },
                    { "143f9efd-b9ad-4fc2-81db-fab78cdd7468", "United Kingdom", "8-10282349", "Rotary District 1200" },
                    { "1490fcdd-2620-4ca0-97f5-18dd3d68f09a", "United Kingdom", "8-10286651", "Rotary Club of Brit Valley" },
                    { "14be6ac6-c3ab-4db4-94c6-0317f21eb89f", "United Kingdom", "8-10239023", "Inner Wheel District 7" },
                    { "14c2ac12-7208-4114-a2c7-f1abdd1c4549", "United Kingdom", "8-10277781", "Rotary Club of Portsmouth North" },
                    { "14c3b6ab-f0ce-44c5-8d98-6dc08778c876", "United Kingdom", "8-10279705", "Inner Wheel Club of Gatley & District" },
                    { "14c41b6a-7c20-4a58-ad78-ee1f082c23d4", "United Kingdom", "8-10243919", "Rotary Club of Hillside (Finchley)" },
                    { "14ca57fc-f894-409b-9369-950e99d68c52", "United Kingdom", "8-10278926", "Rotary Club of Norwich St. Edmund" },
                    { "14e34a7a-a36b-4c18-b90d-0d122fa9942c", "United Kingdom", "8-10243231", "Interact Club of Lytham St Annes" },
                    { "14ea65fd-d0f0-4b4a-8e84-812f3be9b853", "United Kingdom", "8-10258999", "Rotary Club of Coventry" },
                    { "14f4a35f-fbe4-42de-9e27-59e314a77c7f", "United Kingdom", "8-10279572", "Rotary Club of Ilkley Wharfedale" },
                    { "15fb2ad3-5a45-46b2-9a29-a2287af9bd8a", "United Kingdom", "8-10281899", "Inner Wheel Club of Droitwich Spa" },
                    { "16018880-3fa9-416e-88fe-2935350e4b0f", "United Kingdom", "8-10282110", "Rotary Club of Eastbourne" },
                    { "1607f87b-14b0-4955-8e95-2f9a1f9976bc", "United Kingdom", "8-10243629", "Rotary Club of Aboyne & Upper Deeside" },
                    { "16140842-624c-4eaf-8c0e-926c96db7a30", "United Kingdom", "8-10277104", "Rotary Club of Leicester" },
                    { "1630b07a-6403-480e-86b4-39b45ede820a", "United Kingdom", "8-10283507", "Rotary Club of Chelmsford Mildmay" },
                    { "16589ddd-182c-4ddd-83b2-081907c567c1", "United Kingdom", "8-10278577", "Rotary Club of Wellington, Shropshire" },
                    { "16abcbe0-1f16-475c-b682-42c69933ede8", "United Kingdom", "8-10286262", "Inner Wheel Club of Banbury" },
                    { "1703f67b-3030-420e-849d-a73343c002cc", "United Kingdom", "8-10245053", "Rotary Club of Poole" },
                    { "1745146a-823c-431b-bcff-e03ad2e41d93", "United Kingdom", "8-10369318", "Rotary Club Of Burnham On Sea District" },
                    { "178db39b-00f7-4b77-84a7-614809b9ae77", "United Kingdom", "8-10280194", "Inner Wheel Club of Tavistock" },
                    { "17f5cd89-49a0-43b9-b571-df769b393a22", "United Kingdom", "8-10281533", "Rotary Club of Peterborough" },
                    { "18090471-c315-467b-bf61-d21b1969cbb5", "United Kingdom", "8-10286863", "Rotary Club Of Kings Lynn" },
                    { "184dfe23-bbe4-4d4f-8d37-acf81c57130f", "United Kingdom", "8-10281211", "Rotary Club of Verwood" },
                    { "18b12b0a-2199-4560-941b-fb5fbabf5793", "United Kingdom", "8-10282397", "Inner Wheel Club of Belfast" },
                    { "18ca1591-b5b8-46ee-8678-e9da9204d603", "United Kingdom", "8-10283617", "Inner Wheel Club of Woking District" },
                    { "18d77d3b-7e9e-4802-8593-a1fae64ebbca", "United Kingdom", "8-10279815", "Rotary Club of Twickenham-Upon-Thames" },
                    { "19059315-d6a4-4976-af6f-53920822f081", "United Kingdom", "8-10248901", "Rotary Club of Woodford Green" },
                    { "190c77ae-1129-47f2-9647-c18a4e99498a", "United Kingdom", "8-10278014", "Rotary Club of Epping" },
                    { "191882f4-a20b-4149-b26a-887e48b24a98", "United Kingdom", "8-10280444", "Rotary Club of Winslow" },
                    { "1920305f-97ce-466a-a7f4-6c34931eabb5", "United Kingdom", "8-10278773", "Inner Wheel Club of Ramsey" },
                    { "192a2934-6133-4af0-8ab0-180f6c6fffc7", "United Kingdom", "8-10279569", "Rotary Club of Keynsham" },
                    { "194da208-4fdc-42b6-a521-b5a0248955da", "United Kingdom", "8-10280737", "Rotary Club of Laurencekirk & District" },
                    { "1953cdef-e909-4c36-a345-5e28c4bf1dae", "United Kingdom", "8-10263913", "Inner Wheel Club of Carshalton" },
                    { "195f6822-d1f5-4588-8268-2b9538619a47", "United Kingdom", "8-10282262", "Rotary Club of Bishop Auckland" },
                    { "197a9c8d-03cb-4ce2-91a1-15a31939aacb", "United Kingdom", "8-10260520", "Rotary Club of Lowestoft" },
                    { "1997c2a4-9bf5-4d52-b69a-3b5b72b46b05", "United Kingdom", "8-10283440", "Rotary Club of Doncaster St. Leger" },
                    { "19dc8e3e-f7a5-49f7-96e4-3dff1d07b1fa", "United Kingdom", "8-10255842", "Rotary Club of Chislehurst" },
                    { "19e8e33c-5a12-40cf-a502-b860c992ad20", "United Kingdom", "8-10276688", "Rotary Club of Bedworth" },
                    { "1a1370c6-a39d-47da-948d-f5477679ebb0", "United Kingdom", "8-10282727", "Inner Wheel Club of Prestatyn" },
                    { "1a3f93a7-582f-40c3-80ef-8502023f0395", "United Kingdom", "8-10280930", "Inner Wheel Club of Auchterarder & District" },
                    { "1a79a502-77bf-45f2-88f3-1cea935ecb76", "United Kingdom", "8-10280366", "Rotary Club of Walton-on-Thames" },
                    { "1a9ccc48-756f-425f-b4cd-4360c68f13dd", "United Kingdom", "8-10287076", "Rotary Club of Thurso" },
                    { "1ac4c99c-9753-47f0-a1de-f035db051068", "United Kingdom", "8-10250580", "Rotary Club of Newcastle-under-Lyme" },
                    { "1ad143b3-ff99-4bbe-bbed-31ad298e4f55", "United Kingdom", "8-10281133", "Rotary Club of Ramsey, Cambridgeshire" },
                    { "1af5e58c-5c82-45c5-9884-16d26f20340e", "United Kingdom", "8-10286732", "Rotary Club of Redruth" },
                    { "1b0ed810-2ea9-4ee2-8e2b-18dcb7fbe0a3", "United Kingdom", "8-10239475", "Rotary Club of Bristol (Breakfast)" },
                    { "1b14f859-61be-49c3-96dd-2d0f9a934fab", "United Kingdom", "8-10249822", "Rotary Club of Maesteg" },
                    { "1b2578b7-ef9f-484c-a284-3e0f6cbb7e8a", "United Kingdom", "8-10345335", "Rotary Club Of St Andrews" },
                    { "1b2d7b8c-8fc1-4a14-93ba-e5ce777168cb", "United Kingdom", "8-10280380", "Inner Wheel Club of Henley-in-Arden" },
                    { "1b40354f-2bf6-49ad-982d-3270a81893d7", "United Kingdom", "8-10283705", "Rotary Club of Northampton West" },
                    { "1b4d0d9f-0676-45b5-bee3-184814fe114c", "United Kingdom", "8-10249264", "Rotary Club of Banbridge" },
                    { "1b597f58-5951-4d18-8020-faa14da2d05d", "United Kingdom", "8-10280334", "Rotary Club of Dorchester Poundbury" },
                    { "1b675f81-7716-4ffa-84df-7a3ad548e7ff", "United Kingdom", "8-10348228", "Rotary E-Club Of South West Peninsula" },
                    { "1b789784-f131-4a56-9a18-feb6c89048c7", "United Kingdom", "8-10283442", "Rotary Club of Golborne Lightshaw, Warrington" },
                    { "1b917f20-bb5a-47d4-a70b-d5642b0ba31c", "United Kingdom", "8-10282810", "Rotary Club of Royal Forest Of Dean" },
                    { "1bc5ae1e-52d8-4347-a073-ebbd23912d5b", "United Kingdom", "8-10277202", "Rotary Club of Putney" },
                    { "1bd2115b-57f7-404d-9b37-d07b19441704", "United Kingdom", "8-10280179", "Rotary Club of Halifax" },
                    { "1bd37802-267d-426f-84e1-0a3243bdf32c", "United Kingdom", "8-10283714", "Inner Wheel District 128" },
                    { "1bd7623f-7f67-4df5-86d4-95f3afcd8c27", "United Kingdom", "8-10249874", "Rotary Club of Workington Derwent" },
                    { "1bdcd12c-547c-4ad5-bcf5-8aa15890c5b8", "United Kingdom", "8-10241880", "Inner Wheel Club of Uckfield" },
                    { "1c38649f-62e7-47f0-bcca-81c92bfcd483", "United Kingdom", "8-10286432", "Rotary Club of Royston" },
                    { "1c508604-3775-423e-a9ff-2cd630beaa6c", "United Kingdom", "8-10259920", "Rotary Club of Crewe & Nantwich Weaver" },
                    { "1c53f3b1-1383-423c-8d06-e760f1369e61", "United Kingdom", "8-10284153", "Rotary Club of Ripley & Send" },
                    { "1c6c3d4b-b00b-47dd-87e5-59c711e5f14d", "United Kingdom", "8-10247916", "Rotary Club of Penzance" },
                    { "1c70e442-2600-439e-b14a-c7ff9545d91b", "United Kingdom", "8-10281209", "Rotary Club of Pontypool" },
                    { "1c83bd64-4036-43b2-ba29-666f5cd158b2", "United Kingdom", "8-10286441", "Rotary Club of Onchan" },
                    { "1cd93c1a-74e7-4366-915c-d1821b9663ea", "United Kingdom", "8-10253307", "Rotary Club of Romsey" },
                    { "1cf09cc1-9183-4f3f-96d9-a83da419c1c4", "United Kingdom", "8-10286879", "Inner Wheel Club of Liverpool" },
                    { "1d0ff62e-3475-4764-a65f-a1bab5e5e80f", "United Kingdom", "8-10278313", "Rotary Club of Roding" },
                    { "1d15b9bc-0ee6-46d9-811a-9ef2168426ec", "United Kingdom", "8-10277265", "Rotary Club of Dorking" },
                    { "1da2778d-1155-4704-996c-8843df4445e1", "United Kingdom", "8-10278502", "Rotary Club of Barnet" },
                    { "1dbfd66a-afa7-4b26-a81a-779becc66400", "United Kingdom", "8-10277558", "Inner Wheel Club of Dorking" },
                    { "1dd8117f-299a-4626-a8c0-3f3350b06293", "United Kingdom", "8-10250232", "Inner Wheel Club of Rothwell" },
                    { "1de69474-8b6d-4f9a-9c7c-00e70eeee72b", "United Kingdom", "8-10281132", "Inner Wheel Club of Penryn" },
                    { "1e2ce961-7918-4ba4-a28b-4f4ee6b01bc8", "United Kingdom", "8-10277837", "Rotary Club of Streatham" },
                    { "1e4ce563-fd8d-4ec6-8618-fe988f9bd624", "United Kingdom", "8-10239507", "Rotary Club of Larne" },
                    { "1e5016a2-9170-4477-8ba1-a0e2d69ac3f8", "United Kingdom", "8-10285919", "Rotary Club of Smethwick" },
                    { "1e55b88e-9660-4c20-8c05-871e163418e9", "United Kingdom", "8-10277470", "Rotary Club of South Holland" },
                    { "1e929c08-7009-4548-a6e6-87715fcba61b", "United Kingdom", "8-10245729", "Inner Wheel Club of Porthmadog" },
                    { "1ee44713-fff9-4d61-9ef1-a2def9aa9b11", "United Kingdom", "8-10247892", "Interact Club Stratton Upper School" },
                    { "1f032b63-7ed6-42a1-9669-86cf143a9d30", "United Kingdom", "8-10242435", "Rotary Club Of Kingston upon Thames" },
                    { "1f15c545-2ae9-4162-8892-2b1eb4acb9af", "United Kingdom", "8-10284805", "Rotary Club of St. Andrews Kilrymont" },
                    { "1f25c99a-895e-4d9b-a508-128b633281fb", "United Kingdom", "8-10252621", "Rotary Club of Sale" },
                    { "1f2a28c7-5592-46d3-98f9-27097725ffc0", "United Kingdom", "8-10264358", "Inner Wheel Club of St Ives, Cambridgeshire" },
                    { "1f3daeaf-f0e5-4b82-a5c3-879f7d96aa82", "United Kingdom", "8-10249076", "Rotary Club Of Lichfield St Chad" },
                    { "1f3e0e3d-5e45-49cc-8463-9f1b47a5ed45", "United Kingdom", "8-10246934", "Rotary Club of Carluke" },
                    { "1f7e0ee8-3e6d-4734-b29e-27727976bb39", "United Kingdom", "8-10239657", "Inner Wheel Club of Wylde Green" },
                    { "1fb0a6e7-f199-4fa4-8b9e-8d0666a63dfe", "United Kingdom", "8-10286942", "Rotary Club of Perth" },
                    { "1fd6995c-43f0-4473-9db5-367fa585ed9c", "United Kingdom", "8-10281490", "Rotary Club of Preston South" },
                    { "1fdc192d-cff6-4cb4-b75a-9f0cf46a6ef5", "United Kingdom", "8-10241629", "Inner Wheel Club of Wimbledon" },
                    { "1fe6a283-f960-445c-8827-58c300f46ee3", "United Kingdom", "8-10250817", "Rotary Club of Maryport" },
                    { "1fface71-ae6f-44f3-8106-5bc7d30b0959", "United Kingdom", "8-10248886", "Rotary Club of Rugeley" },
                    { "201ba82a-86d2-4ab5-b954-b47b6eb08402", "United Kingdom", "8-10279698", "Rotary Club of Leek" },
                    { "201fb942-44aa-4b61-8b7c-aba32358d968", "United Kingdom", "8-10280472", "Rotary Club of Soham Staploe" },
                    { "2025bcf3-933f-4326-acf0-63e1b9f2b2c4", "United Kingdom", "8-10247255", "Rotary Club of Carse of Stirling, Central" },
                    { "203c03b3-b901-424d-821b-d14555a82b2c", "United Kingdom", "8-10277270", "Rotary Club of Heathfield & Waldron" },
                    { "20a3cff4-46a3-452a-be22-ee3079f953ca", "United Kingdom", "8-10277845", "Rotary Club of Howe of Fife" },
                    { "20ae1ba0-9d1e-4c3f-94a7-d5d3ae7bbeb9", "United Kingdom", "8-10252627", "Rotary Club of Pall Mall" },
                    { "20ae93ba-43ca-42e6-88df-98fc0bcf5f9d", "United Kingdom", "8-10249088", "Inner Wheel Club of Sedgemoor" },
                    { "20b22d8b-d47f-4953-acd9-07b5fd480760", "United Kingdom", "8-10253300", "Inner Wheel Club of Hawarden & District" },
                    { "20c7ba22-a80a-4d00-a9c4-5ef041f9e53c", "United Kingdom", "8-10280343", "Rotary Club of Melton Mowbray" },
                    { "20d3570a-01a7-477c-9c57-618fc984a169", "United Kingdom", "8-10278623", "Rotary Club of Scarborough" },
                    { "20fb7d58-8982-4ef0-99af-dc7317c5a3e8", "United Kingdom", "8-10248900", "Rotary Club of Crompton & Royton" },
                    { "2114c0f1-5d7f-417e-b021-b0bfe48b98f0", "United Kingdom", "8-10278286", "Inner Wheel Club of Thornbury" },
                    { "2131c1b9-74c9-4835-88c0-c36dd5be5c80", "United Kingdom", "8-10279810", "Rotary Club of Gordano Breakfast" },
                    { "215e0f95-b6bd-4c9a-af66-f38b1714b785", "United Kingdom", "8-10285932", "Inner Wheel Club of Lanark" },
                    { "2179ea27-c2c2-4a75-a304-cdfe402c3649", "United Kingdom", "8-10241098", "Inner Wheel Club of Glossop" },
                    { "21a7c427-cbdf-4833-a50b-9acfae30f7ee", "United Kingdom", "8-10281129", "Rotary Club of Oswestry Borderland" },
                    { "21b63238-801b-406e-bdbd-30bf4a4bc261", "United Kingdom", "8-10280782", "Inner Wheel Club of Reading Maiden Erlegh" },
                    { "21bb3539-e442-4521-ad6a-996e56f59656", "United Kingdom", "8-10277960", "Inner Wheel Club of Oldham" },
                    { "21cab790-bdda-4fec-8c59-7a70fe146e0f", "United Kingdom", "8-10279125", "Rotary Club of Severn Vale" },
                    { "2202bc94-7f84-4d0b-9d2f-65c47db2ce9b", "United Kingdom", "8-10253113", "Interact Club of Bulmershe Rotary" },
                    { "223dec77-ac6a-4269-9ef4-6e4d0c603404", "United Kingdom", "8-10249442", "Inner Wheel Club of Exmouth" },
                    { "22472575-3a9b-4369-aaac-4907d45ba0ec", "United Kingdom", "8-10278071", "Rotary Club of Eastbourne Am" },
                    { "225833d4-fd92-4fb0-b9fe-5363a1f77c54", "United Kingdom", "8-10283838", "Rotary Club of Aberystwyth" },
                    { "227d1e6b-64bf-4721-bb4e-2b08e9adbcf5", "United Kingdom", "8-10281054", "Rotary Club of Wreake Valley" },
                    { "22823b69-ed5f-4fbf-a9d6-57de97b21d4a", "United Kingdom", "8-10252663", "Rotary E-Club of District 1070" },
                    { "22851689-1ad0-4c54-a2f3-5653fd1aa01d", "United Kingdom", "8-10282646", "Rotary Club of Babbacombe & St. Marychurch" },
                    { "228905ec-3e18-4361-909f-887eefd447fe", "United Kingdom", "8-10250818", "Rotary Club of Newport, Gwent" },
                    { "22938188-c217-4ff8-8ca3-225c686e45e4", "United Kingdom", "8-10284144", "Rotary Club of Derby Daybreak" },
                    { "2296822e-0f1b-49b1-8a20-7e8141459086", "United Kingdom", "8-10282900", "Rotary Club of Burslem" },
                    { "22cc3e0d-250d-40e5-802a-29d963e7a432", "United Kingdom", "8-10250619", "Inner Wheel Club of Renfrew & Govan" },
                    { "22f8d5a9-17f2-44c0-a780-8eba37cdc2dc", "United Kingdom", "8-10246658", "Interact Club of Rhyddings" },
                    { "230866f4-a409-41cf-80ec-0837e83aedde", "United Kingdom", "8-10252622", "Rotary Club of Basingstoke Loddon" },
                    { "230d1983-c19e-463e-b9a9-a9a4df6b00ed", "United Kingdom", "8-10278459", "Rotary Club of Millom" },
                    { "231ab69c-1c00-4faa-87c3-043795661eef", "United Kingdom", "8-10282914", "Inner Wheel Club of Southport" },
                    { "232a41e8-87b0-4a1d-a032-32f8c35a3b1c", "United Kingdom", "8-10243243", "Inner Wheel Club of Wednesfield" },
                    { "232eac94-613d-4335-930b-2cbbfe7b9116", "United Kingdom", "8-10278801", "Rotaract Club of Peterborough" },
                    { "23363333-4f06-44e5-b59c-beabd534fec7", "United Kingdom", "8-10284100", "Rotary Club of Towcester" },
                    { "2350cb7e-cade-45a8-8933-4388a4b53e01", "United Kingdom", "8-10282417", "Rotary Club of Oxford Isis" },
                    { "235c46b0-3248-437b-b429-52ae2c67c595", "United Kingdom", "8-10264270", "Rotary Club of Leyland" },
                    { "2375c884-f769-4968-b0b4-e074d683deeb", "United Kingdom", "8-10248762", "Rotary Club of Newcastle-upon-Tyne" },
                    { "2383dcfe-0a31-44a5-b193-cff6697e8f87", "United Kingdom", "8-10283775", "Interact Club of Friary School" },
                    { "238a07be-95e7-4774-a4db-ab177d5031e8", "United Kingdom", "8-10239993", "Rotary Club of Motherwell & Wishaw" },
                    { "2410ca27-d4e2-4916-8b49-97e631d282aa", "United Kingdom", "8-10285653", "Inner Wheel Club of Taunton" },
                    { "2438f8bb-6896-48f7-b48a-f5357e5e21cd", "United Kingdom", "8-10250030", "Rotary Club of West Wirral" },
                    { "243985d6-74cc-46e8-b115-d17f3a3cda0f", "United Kingdom", "8-10246239", "Inner Wheel Club of Clay Cross" },
                    { "24574c3f-4116-406e-b75e-58aa3a0eaa24", "United Kingdom", "8-10287118", "Rotary Club of Skegness" },
                    { "24b62f01-5937-4bd8-acbe-0f753e4ea4a2", "United Kingdom", "8-10277754", "Rotary Club of Wisbech" },
                    { "24e2fb23-6f6c-4ca8-aee3-ceab3c4df773", "United Kingdom", "8-10287160", "Inner Wheel Club of Ipswich East" },
                    { "24e4e483-ceb2-46b2-94e7-92addd886c53", "United Kingdom", "8-10285915", "Rotary Club of Oswestry Cambrian" },
                    { "24f207d7-e580-426f-bd58-aee0d0551e01", "United Kingdom", "8-10277014", "Rotary Club of Livingston" },
                    { "250d5dda-60c2-4941-a4fa-6fe6574d127f", "United Kingdom", "8-10281945", "Inner Wheel Club of Walsall" },
                    { "25134de4-9f2c-4a04-8cfa-61e6f3a23dbc", "United Kingdom", "8-10247054", "Rotary Club of Sandbach" },
                    { "2552d96e-e781-4e3d-8c7e-7bd50fef8a7a", "United Kingdom", "8-10277362", "Rotary Club of Dudley" },
                    { "255642a7-8a39-42c9-9665-b8cfad325fe8", "United Kingdom", "8-10279263", "Rotary Club of Thorne" },
                    { "256083d3-48d8-4159-9ac9-cf4f0d539dee", "United Kingdom", "8-10249292", "Rotary Club of Denton & Audenshaw" },
                    { "25745420-7601-4c10-9978-7e9542ddda1a", "United Kingdom", "8-10280598", "Rotary Club of Maidstone" },
                    { "25855c80-04d0-4927-be9e-a113a66847b3", "United Kingdom", "8-10262594", "Inner Wheel Club of Plymouth" },
                    { "25a21e10-26f9-4ae1-a728-0a0c633f0da0", "United Kingdom", "8-10281794", "Inner Wheel Club of Newtown" },
                    { "25ff7999-73b9-4cc4-ae8d-73b4670e574d", "United Kingdom", "8-10284770", "Rotary Club of Shepton Mallet" },
                    { "26131fbb-c6ba-42a7-b4b8-181eea1b371b", "United Kingdom", "8-10242800", "Rotary Club of Exeter" },
                    { "262c35d8-fa38-4bab-98cb-b08e477ab852", "United Kingdom", "8-10287104", "Rotary E-Club of East Anglia" },
                    { "265391dd-d2c0-496c-8300-a09e621ae073", "United Kingdom", "8-10249391", "Rotary Club of Cupar" },
                    { "266fe61f-a8a2-48e7-9301-826a4a493c8c", "United Kingdom", "8-10280765", "Rotary Club of Exe Valley (Tiverton)" },
                    { "267cbf6f-6a00-408b-9fd5-d45aee60bac1", "United Kingdom", "8-10286825", "Rotary Club of Rossendale" },
                    { "2686affb-b44b-414e-a0a2-5a5f56a3dcd3", "United Kingdom", "8-10276601", "Rotary Club of Shepperton Aurora" },
                    { "26b4c7eb-5a62-4311-8afb-2355e30680d7", "United Kingdom", "8-10277429", "Rotary Club of Aberdeen Deeside" },
                    { "26ca4cf1-0ba8-4fd8-b5c3-0e41b45ec1ea", "United Kingdom", "8-10282961", "Rotary Club of Glasgow" },
                    { "26d22936-0849-4514-b89f-154b5c4d03ac", "United Kingdom", "8-10279555", "Rotary Club of Bungay" },
                    { "276bd0f7-dd36-44a3-8be9-48a66a48e98f", "United Kingdom", "8-10250813", "Inner Wheel Club of Bourne End & Cookham" },
                    { "27b28831-79c9-4b97-8072-9c36a4837ed3", "United Kingdom", "8-10279720", "Inner Wheel Club of Teignmouth" },
                    { "27eec3bc-9c99-4b7e-8943-c91bd0c750d0", "United Kingdom", "8-10285779", "Inner Wheel Club of Penzance" },
                    { "281a6d2c-a087-4476-97e5-02f16bc90080", "United Kingdom", "8-10280410", "Rotary Club of Orpington" },
                    { "28208746-d121-4e5f-834b-1d0ee1acc3ad", "United Kingdom", "8-10278472", "Rotary Club of Loddon Vale" },
                    { "284ef210-a435-4d4d-9cca-850cb79f1b32", "United Kingdom", "8-10246964", "Inner Wheel Club of Lisburn" },
                    { "285cc6ce-306e-4342-bca4-43f6220595b1", "United Kingdom", "8-10284674", "Rotary Club of Maldon" },
                    { "287e16b6-d959-4ecc-ae12-f20735ab84bc", "United Kingdom", "8-10243628", "Rotary Club of Chelwood Bridge" },
                    { "2886a9f9-563f-4400-98bf-484e98c5002d", "United Kingdom", "8-10279663", "Inner Wheel Club of Blyth" },
                    { "28a5ce7a-54bc-43d5-b6c8-fcb777456850", "United Kingdom", "8-10278145", "Rotary Club of Senlac" },
                    { "2906d56a-b168-44b5-a819-1b3fd60aece8", "United Kingdom", "8-10281399", "Rotary Club of Leven" },
                    { "290b10d2-a8bd-4737-af11-038beb95dfdf", "United Kingdom", "8-10252048", "Rotary Club of Loughborough" },
                    { "29184c87-63b5-459e-9a35-a8ec6e003f19", "United Kingdom", "8-10286827", "Rotary Club of Southwell" },
                    { "2929ca73-d645-45d4-aeb7-083239dd4f37", "United Kingdom", "8-10280823", "Inner Wheel Club of Godalming" },
                    { "29486fc9-6d47-46f8-93c9-53c77aacbe15", "United Kingdom", "8-10283914", "Rotary Club of Pangbourne" },
                    { "2963a2c9-170e-4d97-9588-e6de8bfee4cf", "United Kingdom", "8-10286418", "Rotary Club of Maidenhead Thames" },
                    { "298a0ba2-25a0-4b4a-bc65-cb385f8e8f35", "United Kingdom", "8-10246972", "Rotary Club of Kelvedon & District" },
                    { "298aaf3e-2538-4f31-b7c0-dcd49811e246", "United Kingdom", "8-10246597", "Rotary Club of Cheltenham" },
                    { "299646d4-75e7-4961-8ed2-ea76d5418280", "United Kingdom", "8-10277966", "Inner Wheel Club of Huntingdon" },
                    { "29ad1db3-9644-495d-9547-53e6866c2560", "United Kingdom", "8-10241414", "Rotary Club of Northallerton Mowbray" },
                    { "29dc114f-92f9-4ecf-9f8e-4365fa10d6f1", "United Kingdom", "8-10249261", "Rotary Club of Dawlish Water" },
                    { "2a41ccc2-ab72-410c-b8f5-809e3433e7e0", "United Kingdom", "8-10369151", "Rotary Club Of Angus Glens" },
                    { "2a43f28a-c03e-450b-b1ba-2f45ef669b8f", "United Kingdom", "8-10239324", "Rotary Club of Sherwood Sunrisers" },
                    { "2a5bc149-a562-46e6-b425-2919c782df08", "United Kingdom", "8-10281044", "Rotary Club of Hadleigh" },
                    { "2a64693e-a036-4e81-89c2-d52ca0a7dd05", "United Kingdom", "8-10278497", "Rotary Club of Ayr" },
                    { "2a6e95b2-24eb-4751-9852-0d425fcd1586", "United Kingdom", "8-10245594", "Rotaract Club of Langley and Iver" },
                    { "2abc4c6b-fd90-4fab-ae00-403847ab622b", "United Kingdom", "8-10243592", "Inner Wheel Club of Glastonbury & Street" },
                    { "2aeb65dc-6a27-460e-be76-d96704033ca9", "United Kingdom", "8-10250104", "Inner Wheel Club of Bebington" },
                    { "2b0cc2f4-399d-4d96-8c79-a6da4b1e08bb", "United Kingdom", "8-10250900", "Rotary Club of Kingsbridge Estuary" },
                    { "2b10c80d-7aec-46b5-a551-47e1ad7232e3", "United Kingdom", "8-10279382", "Rotary Club of Bodmin" },
                    { "2b11bfb1-3239-485f-8dbe-bb6355c1a312", "United Kingdom", "8-10244912", "Rotary Club of Fermoy & District" },
                    { "2b5eb55b-539a-43bc-9ad4-cef3913e9c67", "United Kingdom", "8-10248317", "Rotary Club of Portlaoise" },
                    { "2b5f2914-f5c6-44cd-afa3-4ef43ef0f0d9", "United Kingdom", "8-10281757", "Rotary Club of Ashtead" },
                    { "2b6121dc-c5c4-4eeb-a8aa-d6969da3fda7", "United Kingdom", "8-10280645", "Rotary Club of Romsey Test" },
                    { "2bd8c042-e5de-45cc-aad0-5bc9b849ab9a", "United Kingdom", "8-10242166", "Rotary Club of Lunesdale" },
                    { "2be797ac-8af4-4836-a468-aaf1687e227d", "United Kingdom", "8-10247909", "Rotary Club of Alnwick" },
                    { "2bead99d-c657-4029-8815-97fd2d142136", "United Kingdom", "8-10283436", "Rotary Club of Gourock" },
                    { "2c385341-1d9e-440a-bdf4-ae399774be80", "United Kingdom", "8-10278470", "Rotary Club of Lincoln" },
                    { "2c5d4817-298b-442a-81ce-5c1308223045", "United Kingdom", "8-10281151", "Rotary Club of Aberdare" },
                    { "2c8a3d17-34e0-46b1-8926-c8a7a5e0e44f", "United Kingdom", "8-10286686", "Inner Wheel Club of Retford" },
                    { "2c8a4ddc-4181-4fd2-b1a2-0e0e908bdec2", "United Kingdom", "8-10243447", "Inner Wheel Club of Pontefract" },
                    { "2c9170f7-c385-4354-9779-9cf94f9ee3d6", "United Kingdom", "8-10244738", "Inner Wheel Club of Kingsbridge" },
                    { "2ce33ce9-aeaa-4a8c-b9d1-36a4b8e9fcb1", "United Kingdom", "8-10250663", "Rotary Club of Anstruther" },
                    { "2ce7c322-7e9e-44be-a81e-eb60b154f054", "United Kingdom", "8-10286826", "Rotary Club of Rugby" },
                    { "2cfbbb04-ee4b-4de8-80f9-684b8fbdf9a5", "United Kingdom", "8-10280571", "Rotary Club of Belfast West" },
                    { "2d1c0b88-0c80-4307-b7c5-25b151eeea93", "United Kingdom", "8-10286785", "Rotary Club of Holmfirth" },
                    { "2d24ba98-f799-4e40-aed7-6e236aa43a77", "United Kingdom", "8-10286462", "Rotary Club of Misbourne Matins" },
                    { "2d2dda3a-4c36-4c19-98f1-bf6f75a07f9a", "United Kingdom", "8-10280604", "Rotary Club of Ullapool" },
                    { "2d940db7-777a-4240-ab3e-ac2b691813ed", "United Kingdom", "8-10279332", "Rotary Club of Gosport" },
                    { "2d95de99-fedf-44bb-8d3f-49eaff060b26", "United Kingdom", "8-10280741", "Rotary Club of Aberdeen Balgownie" },
                    { "2da9b8c4-6ba7-4922-b671-8805b16b330a", "United Kingdom", "8-10243943", "Inner Wheel Club of Saxmundham & District" },
                    { "2dc3cfb1-ff9e-4476-a872-4e79259c226b", "United Kingdom", "8-10283831", "Rotary Club of Malton & Norton" },
                    { "2dc5f550-800c-4290-b6d3-9426823e5816", "United Kingdom", "8-10278370", "Inner Wheel Clubs of District 16 North & South of Ireland" },
                    { "2e01b348-385e-4db3-b7b0-6d5b70a017ad", "United Kingdom", "8-10282740", "Rotary Club of Blandford" },
                    { "2e45a496-fbdc-479d-8391-6d4d04920b08", "United Kingdom", "8-10281517", "Inner Wheel Club of Omagh" },
                    { "2e8ae043-fd1e-47cf-ae77-c50b347b27d5", "United Kingdom", "8-10281103", "Rotary Club of Grantham Kesteven" },
                    { "2e8e678c-7bdb-4ef9-a7c0-684c5f1c9bfc", "United Kingdom", "8-10283634", "Rotary Club of Norwich Blackfriars Breakfast" },
                    { "2eb6592d-8b0e-413c-b82b-c153abe1594c", "United Kingdom", "8-10243706", "Rotary Club of Inverness Riverside" },
                    { "2ebce6c5-9f17-4e4d-90d9-b69c3605be5d", "United Kingdom", "8-10243632", "Rotary Club of Whitehaven Castle" },
                    { "2ecefaff-5e16-4529-9fbf-7a7a0ea0e6c5", "United Kingdom", "8-10281510", "Rotary District 1130" },
                    { "2f138e11-d19b-4b9a-a473-acdab51e3ee4", "United Kingdom", "8-10244596", "Rotary Club of Sowerby Bridge" },
                    { "2f141c01-3da3-497d-a9d9-5c31acb070d7", "United Kingdom", "8-10280416", "Inner Wheel Club of Ripon" },
                    { "2f1464d2-0f49-492a-8691-497c03c1195f", "United Kingdom", "8-10262579", "Rotary Club of Ventnor" },
                    { "2f52db0e-b486-43c3-8557-5e01db44ee49", "United Kingdom", "8-10323260", "Inner Wheel Club Of Normanton" },
                    { "2f777c99-b90e-4d0d-989f-7cb072fb1457", "United Kingdom", "8-10251529", "Inner Wheel Club of Blackburn" },
                    { "2f8d29e0-9002-40d5-973b-1da77c687ad2", "United Kingdom", "8-10277272", "Rotary Club of Willenhall" },
                    { "2f9455da-b131-436b-8c7f-bd1acb1a8d91", "United Kingdom", "8-10276693", "Rotary Club of Llanishen (Cardiff)" },
                    { "2f9e2747-084a-4baa-a82e-0648dffe7199", "United Kingdom", "8-10256282", "Rotary Club of Wem & District" },
                    { "2f9ecdb5-fced-41d3-b9a7-45b94bae17ca", "United Kingdom", "8-10280137", "Inner Wheel Club of Cockermouth" },
                    { "2fc96e10-ad06-4fd4-8479-ad9f95d8b65d", "United Kingdom", "8-10248141", "Rotary Club of Stafford" },
                    { "30050b1c-f879-4b40-a824-0c257911bc51", "United Kingdom", "8-10239002", "Rotary Club of Brigg" },
                    { "3007f99e-b8cd-44e1-a5e7-4123b876efb1", "United Kingdom", "8-10281953", "Rotary Club of Kenilworth" },
                    { "3008b262-842e-4f74-899a-edba1eb575c1", "United Kingdom", "8-10249589", "Inner Wheel Club of Witney" },
                    { "3022133e-d18f-4102-9106-dfa16b25d493", "United Kingdom", "8-10249300", "Rotary Club of Crawley" },
                    { "30385ff5-795c-421f-8acc-2f2d6d3ffa21", "United Kingdom", "8-10283633", "Rotary Club of Helston-Lizard" },
                    { "309c1787-059d-488d-ab86-85b187426836", "United Kingdom", "8-10277141", "Rotary Club of Stamford St Martin's" },
                    { "30a70715-1b25-4213-8424-eb23ed2951cc", "United Kingdom", "8-10249154", "Inner Wheel Club of Hoddesdon" },
                    { "30cd5f73-8cf4-46bc-872f-025fe0966846", "United Kingdom", "8-10258985", "Rotary Club of Hornchurch and Upminster" },
                    { "31267538-bad9-4f1f-ae38-3bb914018c84", "United Kingdom", "8-10286817", "Rotary Club of Stone & District" },
                    { "3133c6e8-d33c-4b2b-b7f7-3a73a89d70a0", "United Kingdom", "8-10280025", "Rotary Club of Soar Valley" },
                    { "3148cb3f-605e-40a5-be2c-467e27d3f7ad", "United Kingdom", "8-10248874", "Inner Wheel Club of Guernsey" },
                    { "314d5661-cb2a-40e4-9428-5430ea738d93", "United Kingdom", "8-10287116", "Rotary Club of Perth St. Johns" },
                    { "315746ef-93d1-454e-9bd8-e59eb6badedc", "United Kingdom", "8-10278051", "Rotary Club of Canary Wharf" },
                    { "3173329a-1666-402c-b345-91becdc3b081", "United Kingdom", "8-10278186", "Inner Wheel Club of Farnborough" },
                    { "31928b80-b1db-440c-921d-878421f82d0c", "United Kingdom", "8-10279694", "Rotary Club of Barnstaple Link" },
                    { "31a172ff-32cb-47c2-a94b-3db5c71f211a", "United Kingdom", "8-10246932", "Rotary Club of Bath" },
                    { "31b0513e-a9e2-498a-a425-7b708d231295", "United Kingdom", "8-10241763", "Inner Wheel Club of Dawlish" },
                    { "31c9edad-1402-45bb-bc89-f628022f816b", "United Kingdom", "8-10280833", "Rotary Club of Bromley" },
                    { "31d9ecb6-0b0c-4d54-beb9-0e3619676ea4", "United Kingdom", "8-10255750", "Rotary Club of Winsford & Middlewich" },
                    { "31da566c-7f01-446d-ab92-4227c885f400", "United Kingdom", "8-10280429", "Inner Wheel Club of Gateshead East" },
                    { "31e70b9b-5a54-4bd6-92d3-221dccec4c16", "United Kingdom", "8-10278622", "Inner Wheel Club of Shepton Mallet" },
                    { "320c0037-dbf4-43cb-9f24-e60c6a8e9c9d", "United Kingdom", "8-10283599", "Rotary Club of Castle Douglas" },
                    { "32136bef-4ef1-4482-bd8d-3b23eca328a2", "United Kingdom", "8-10250910", "Rotary Club of Wallasey" },
                    { "32318a04-abd8-4fc5-9087-93116c661825", "United Kingdom", "8-10277847", "Rotary Club of Newton Aycliffe" },
                    { "3231b21d-741d-447e-934f-917f6e8082cb", "United Kingdom", "8-10285890", "Rotary Club of Gerrards Cross & Chalfont St. Peter" },
                    { "3241c8fb-2497-47c3-837c-126a6ebb11f7", "United Kingdom", "8-10283911", "Rotary Club of Chepstow" },
                    { "324f0bdd-7078-445f-ab86-d3057b584ed7", "United Kingdom", "8-10286923", "Rotary Club of Oundle" },
                    { "327b9232-ca69-4132-a40f-1927b46d7e64", "United Kingdom", "8-10278250", "Rotary Club of Oxford" },
                    { "32963abc-1d58-4bcf-b1e1-00e8527bedb7", "United Kingdom", "8-10280505", "Rotary Club of Sandbach Crosses" },
                    { "32a31a18-8063-48a3-975b-23c51b89ef7f", "United Kingdom", "8-10285702", "Rotary Club of Malvern" },
                    { "32d66586-0a47-4013-9b7b-cfe457406f58", "United Kingdom", "8-10265967", "Rotary Club of Tonbridge" },
                    { "32dabd95-06b5-462b-b2fb-2bcc2961da07", "United Kingdom", "8-10256243", "Rotary Club of Workington" },
                    { "32e2840f-f113-4857-87f0-c89a1f20a9dd", "United Kingdom", "8-10376525", "Inner Wheel Club Of Wilton" },
                    { "3305f13a-52d0-49ce-8358-ad45d313a3c0", "United Kingdom", "8-10356776", "Rotary Club Of Malvern" },
                    { "333ec214-4ec4-4ad2-8313-66139c0287fb", "United Kingdom", "8-10279261", "Rotary Club of Stainborough" },
                    { "33447b76-a62b-45d1-8e98-f88453f8ca4d", "United Kingdom", "8-10370057", "Rotary Club Of Danbury & Villages" },
                    { "33527ea1-5701-4ea8-8e30-715085174628", "United Kingdom", "8-10244346", "Rotary Club of Stokesley" },
                    { "335e426a-b6c6-432a-bbfa-99b48be9f00b", "United Kingdom", "8-10256247", "Inner Wheel Club of Rushmoor" },
                    { "33630044-3651-43a0-ad63-ae47b7f91a07", "United Kingdom", "8-10264677", "Interact Club of Faringdon" },
                    { "3380bf71-547a-49af-b924-7552ec790aba", "United Kingdom", "8-10286387", "Rotary Club of Luton Someries" },
                    { "33b8989d-ccab-42af-b1a9-3a840a688473", "United Kingdom", "8-10277858", "Rotary Club of Wendover & District" },
                    { "33dcc2c3-225f-4d24-bf25-6c30d714360a", "United Kingdom", "8-10252072", "Rotary Club of Athlone" },
                    { "33e24882-dd1f-41cd-ae51-f021d3ba78c5", "United Kingdom", "8-10279876", "Rotary Club of Perth Kinnoull" },
                    { "33efd93b-7109-461d-8eb8-f76fb18ac33e", "United Kingdom", "8-10282398", "Rotary Club of Billericay" },
                    { "33f1ca05-6607-48eb-bd0b-46adbcd8fc06", "United Kingdom", "8-10282419", "Inner Wheel Club of Loughborough" },
                    { "340d70ef-3d8f-4d7b-8d47-04c519c6a837", "United Kingdom", "8-10278510", "Rotary Club of Alresford" },
                    { "341b2c75-d254-4fb8-af77-7d49ba7cfdc0", "United Kingdom", "8-10280556", "Inner Wheel Club of Edgbaston Convention" },
                    { "349c4b36-e7af-49c6-9f64-430b0027556f", "United Kingdom", "8-10273343", "Rotary Club of Bourne End & Cookham" },
                    { "34f79166-1885-4316-a6f0-d38fc8096bc5", "United Kingdom", "8-10249121", "Rotary Club of Peterhead" },
                    { "350d4bf0-9226-44a1-8003-a09a0ffac90e", "United Kingdom", "8-10281330", "Rotary Club of Wylde Green" },
                    { "35101ede-290b-4f7f-989e-61cb5f42d441", "United Kingdom", "8-10277076", "Rotary Club of Hyde" },
                    { "35345727-bf86-488e-8007-e1c1918321ce", "United Kingdom", "8-10280430", "Rotary Club of Hamble Valley" },
                    { "354d5fca-fef4-4046-9432-3359db9d77df", "United Kingdom", "8-10279878", "Rotary Club of St. Albans" },
                    { "3558adbc-71eb-4b80-a53b-3716bcf49c6b", "United Kingdom", "8-10279404", "Rotary Club of Oxted & Limpsfield" },
                    { "358837dd-b643-4094-a3b8-9ac3f1c55c0a", "United Kingdom", "8-10238481", "Inner Wheel Club of Uxbridge" },
                    { "358d6b6c-8cd0-4b95-826c-3665ef12939f", "United Kingdom", "8-10283621", "Rotary Club of Letterkenny" },
                    { "35906d85-1ad6-441f-8c69-22726a35736e", "United Kingdom", "8-10280748", "Rotary Club of South Foreland" },
                    { "35db176e-0273-4690-8292-e7ce1b40d69a", "United Kingdom", "8-10278480", "Inner Wheel Club of Blaby" },
                    { "3624d097-b341-42b0-ad21-754ce67935de", "United Kingdom", "8-10282802", "Rotary Club of Bakewell" },
                    { "36372172-2207-4055-8faf-fec41d9d6f36", "United Kingdom", "8-10278306", "Rotary Club of Mersea Island" },
                    { "36434838-450a-4758-98d0-d858d5370692", "United Kingdom", "8-10286383", "Inner Wheel Club of Ulverston" },
                    { "36694382-e7fa-48ca-a8bf-b5f5bb754141", "United Kingdom", "8-10265761", "Rotary Club of Rye & Winchelsea" },
                    { "3670edf8-8c71-4145-9f7d-9773cb17342c", "United Kingdom", "8-10277117", "Rotary Club of Elthorne-Hillingdon" },
                    { "36b38ab6-e703-4670-b5eb-7a0a5a6d9e95", "United Kingdom", "8-10249430", "Inner Wheel Club of Cwmbran" },
                    { "36d505bf-436e-48f8-8e6a-dc9f936f073e", "United Kingdom", "8-10247889", "Rotary Club of Tyldesley with Atherton" },
                    { "370050b7-ee6e-4471-8102-06dc06675cd5", "United Kingdom", "8-10287037", "Inner Wheel Club of Aberdare" },
                    { "3707b275-4ca0-4717-a953-05a40e8401c6", "United Kingdom", "8-10279368", "Rotary Club of Broughty Ferry" },
                    { "37597013-6f8a-4584-985d-362fd8d47261", "United Kingdom", "8-10282916", "Inner Wheel Club of Letchworth Garden City" },
                    { "375d3300-cc31-477e-ac6c-cd53161689e5", "United Kingdom", "8-10280733", "Rotary Club of Bingley Airedale" },
                    { "377cbc1f-5fc0-4970-b2ad-46e8342550f8", "United Kingdom", "8-10342581", "Rotary Club Of Currie Balerno" },
                    { "37930d52-27e6-4644-a276-3cce545af5b6", "United Kingdom", "8-10242793", "Rotary Club of Conwy Valley" },
                    { "37a5b60f-9f24-407f-8a10-a5e457fdcdb2", "United Kingdom", "8-10283431", "Inner Wheel Club of Kirriemuir" },
                    { "3804b0d4-e262-48f3-b45c-e9b97f54d3ba", "United Kingdom", "8-10277432", "Rotary Club of Swadlincote" },
                    { "3820abcf-0b51-4986-b338-773748d482bd", "United Kingdom", "8-10349059", "Rotary Club Of Carnegie Dunfermline" },
                    { "38294b1e-8aa2-405d-b8cc-43b5784c0129", "United Kingdom", "8-10240323", "Rotary Club of Frome" },
                    { "38312dcb-a666-42ec-bac8-e0b68adb987e", "United Kingdom", "8-10278594", "Rotary Club of Coventry Phoenix" },
                    { "383736a1-56aa-4d70-b42d-8f0e654e383a", "United Kingdom", "8-10282629", "Rotary Club of Golders Green" },
                    { "383d1056-869d-4e2d-a691-9e31dbe6d31b", "United Kingdom", "8-10250997", "Rotaract Club of Wallingford" },
                    { "38616ad6-d204-44a7-969e-5de587d7893e", "United Kingdom", "8-10249186", "Inner Wheel Club of Larne" },
                    { "3887aad0-2817-496f-8a0f-b2d058c9c152", "United Kingdom", "8-10246952", "Rotary Club of Llandeilo" },
                    { "38b6f05e-18fd-4748-8978-68f70bdc3494", "United Kingdom", "8-10284696", "Rotary Club of Sedgefield" },
                    { "38d6ab1f-9f3e-400e-9238-8eedb3304b9f", "United Kingdom", "8-10286832", "Rotary Club of Warrington" },
                    { "38e81183-7187-4aab-8778-4972bd4a39b9", "United Kingdom", "8-10240275", "Inner Wheel Club of Farnham Weyside" },
                    { "38f99ad8-db2b-4e9a-a6fd-bf69a4faf818", "United Kingdom", "8-10278466", "Rotary Club of Beccles" },
                    { "3950d246-590c-46eb-8a98-04b02bf5421a", "United Kingdom", "8-10286555", "Inner Wheel Club of Oadby" },
                    { "39589967-8127-4e59-9685-2cc7642db4c7", "United Kingdom", "8-10277044", "Rotary Club of Navan" },
                    { "39647113-9eb4-46f5-8e5a-eaeee3d6cf71", "United Kingdom", "8-10286859", "Rotary Club of Silloth-On-Solway" },
                    { "3975b5d0-513a-479e-99d2-a979bb1359ba", "United Kingdom", "8-10282971", "Rotary Club of Blackpool Palatine" },
                    { "397ac9d4-7c7d-4614-b525-27d74da0b088", "United Kingdom", "8-10249437", "Rotary Club of Oldham" },
                    { "3998b80b-ca7c-4d61-92aa-e4a9f1a0b45e", "United Kingdom", "8-10281261", "Rotary Club of Ravensbourne" },
                    { "399ae181-80b6-42c0-aede-79f77164add9", "United Kingdom", "8-10255830", "Rotary Club of Bedford De Parys" },
                    { "39a2359a-4f16-4251-9045-0f9dc1024e91", "United Kingdom", "8-10279163", "Rotary Club of Dagenham" },
                    { "39b76998-0180-43d7-b225-990cc8ea4248", "United Kingdom", "8-10249467", "Rotary Club of Barnoldswick & Earby" },
                    { "39dfc149-46d1-4355-9dd0-733959f4cca4", "United Kingdom", "8-10256250", "Inner Wheel Club of Canterbury" },
                    { "39f1c3e3-72ff-4887-a6ac-2f3139b51df3", "United Kingdom", "8-10280389", "Inner Wheel Club of Locks Heath" },
                    { "3a0c67ec-ba4f-488f-aa98-7476d112e711", "United Kingdom", "8-10286396", "Rotary Club of Luton" },
                    { "3a22aa5b-d7b9-428b-96d0-a926286e5208", "United Kingdom", "8-10238434", "Rotary Club of Whitburn" },
                    { "3a456544-88bd-40bb-9921-803e0f4359fa", "United Kingdom", "8-10257166", "Rotary Club of Clacton-on-Sea" },
                    { "3a665763-23c8-4e6f-acaf-a9c8c63076b1", "United Kingdom", "8-10249105", "Rotary Club of Loanhead & Roslin" },
                    { "3abd31d6-6d30-46a7-9fb7-5dcd0b5ef6a7", "United Kingdom", "8-10279117", "Rotary Club of Tower Hamlets" },
                    { "3ac7ae95-89fe-4d15-be96-43643f1e1d79", "United Kingdom", "8-10260540", "Rotary Club of Brighton" },
                    { "3acdc321-62ac-482c-a0da-88901ba8c508", "United Kingdom", "8-10240060", "Rotary Club of Donaghadee" },
                    { "3ae5177e-c947-4896-b953-9e068380e20f", "United Kingdom", "8-10243482", "Rotary Club of Erith" },
                    { "3ae6f68a-8458-4e53-8c7c-27ccd2a7131e", "United Kingdom", "8-10252648", "Rotary Club of Elstree & Boreham Wood" },
                    { "3b2d2c4e-f936-4369-8a92-6e99cb2658e0", "United Kingdom", "8-10251034", "Inner Wheel Club of Leighton Buzzard" },
                    { "3b38b0ee-8dd5-4e2a-8631-4f4a2478111b", "United Kingdom", "8-10248073", "Rotary Club of Brackley" },
                    { "3b537283-f4a8-47b9-8446-44f97fd1da42", "United Kingdom", "8-10284714", "Rotary Club of Doncaster St. George's" },
                    { "3b73a663-f45f-4c78-9f41-dd1eeae61292", "United Kingdom", "8-10250913", "Rotary Club of Oban" },
                    { "3b87bcab-2bc4-4c59-98ae-b472c32fd909", "United Kingdom", "8-10362162", "Rotary Club Of Billericay Town" },
                    { "3b9c87de-3d87-4bf1-8e1c-00949b629d4f", "United Kingdom", "8-10281372", "Rotary Club of Limerick Shannon" },
                    { "3ba99fd3-9e72-428c-9268-b8a1c60437fc", "United Kingdom", "8-10278861", "Rotary Club of Louth" },
                    { "3bed4a6f-b978-4a92-9e94-9fb6aaa5f985", "United Kingdom", "8-10279331", "Rotary Club of Banff" },
                    { "3c3e4c78-1b9b-48fb-9cb7-fa412a8c8260", "United Kingdom", "8-10276696", "Rotary Club of North Downs" },
                    { "3cb86610-b9f7-42cb-81e8-e49019c3bbb4", "United Kingdom", "8-10249271", "Rotary Club of Fraserburgh" },
                    { "3cd9e1af-cd31-40ce-a49d-92a1d4adca4b", "United Kingdom", "8-10286310", "Inner Wheel Club of Elland" },
                    { "3cf3230b-c66b-40f7-a059-0ca93c50e0c7", "United Kingdom", "8-10250833", "Rotary Club of Yeovil" },
                    { "3d1f1145-6e6d-4785-9a36-db860a5cfb25", "United Kingdom", "8-10299819", "Inner Wheel Club Of Musselburgh" },
                    { "3d3225be-7f5c-4434-b24b-2312af4cbea8", "United Kingdom", "8-10287149", "Rotary Club of Ossett" },
                    { "3d4ab283-ec9e-4a56-b967-f4f21830428b", "United Kingdom", "8-10279213", "Rotary Club of St. Columb" },
                    { "3d6e0ccf-f393-4e9c-8154-450c18ffa7db", "United Kingdom", "8-10286799", "Rotary Club of Kibworth & Fleckney" },
                    { "3d78184a-2ca6-4f93-b63c-48a3d29d6dbd", "United Kingdom", "8-10281771", "Rotary Club of Sherborne Castles" },
                    { "3d913543-2bf4-4cb2-a792-aeb4873e48d3", "United Kingdom", "8-10280593", "Rotary Club of Wilton" },
                    { "3da1f8fa-7015-47e9-abfb-5836793cfc90", "United Kingdom", "8-10282007", "Inner Wheel Club of Motherwell & Wishaw" },
                    { "3dac799f-8d78-4f4f-8b2b-4a76286ba849", "United Kingdom", "8-10278002", "Rotary Club of Galashiels and District" },
                    { "3dbce246-a9e9-48b9-897a-b10333b1977e", "United Kingdom", "8-10278475", "Rotary Club of Milton Keynes" },
                    { "3dcdcde9-e52c-4b0c-82a8-4074eb39ff03", "United Kingdom", "8-10281167", "Rotary Club of Epping Forest" },
                    { "3ddd6f53-3eb5-4ce1-a3ac-4a10544f42db", "United Kingdom", "8-10285560", "Rotary Club of Bromsgrove" },
                    { "3de64d56-e30c-41f2-8f85-ba5982cd6d29", "United Kingdom", "8-10248792", "Rotary Club of Wellingborough Hatton" },
                    { "3df31a98-5806-409a-9d1d-7cca3aae1692", "United Kingdom", "8-10282105", "Rotary Club of Watford" },
                    { "3e1a79e3-037d-45fc-bb4e-ead822d45e04", "United Kingdom", "8-10259942", "Rotary Club of Shetland" },
                    { "3e2b0f9c-d70b-4582-a626-5559223cd8cb", "United Kingdom", "8-10278205", "Rotary Club of Warsop, Shirebrook & District" },
                    { "3e5b3cd7-056a-41f5-b14c-5ecf8adddfba", "United Kingdom", "8-10284130", "Rotary Club of Cosham" },
                    { "3e7ea99c-15b1-47d7-ae30-389249c81606", "United Kingdom", "8-10248799", "Inner Wheel Club of Wellingborough Hatton" },
                    { "3e8070e0-e73d-48d1-93a8-1567097ff5f4", "United Kingdom", "8-10279366", "Rotary Club of Saffron Walden" },
                    { "3eb7b47a-1402-4ee0-82bb-164952bc1b2d", "United Kingdom", "8-10248102", "Rotary Club of Bush Hill Park" },
                    { "3eddcfd4-6e93-4fa7-9ba8-8c1bb7e5b3e0", "United Kingdom", "8-10238568", "Rotaract Club of Dublin" },
                    { "3efa9591-7021-4d22-8045-95a135a24f24", "United Kingdom", "8-10281447", "Rotary Club of Bretby" },
                    { "3efd1a45-914f-4f80-9b11-be407b69ede6", "United Kingdom", "8-10243160", "Rotary Club of Bridport" },
                    { "3f20d2f6-8d80-4012-b3f7-71b5293a3395", "United Kingdom", "8-10286797", "Rotary Club of Amwell" },
                    { "3f4e985e-564b-46bd-b5a0-5a06d3c87408", "United Kingdom", "8-10264307", "Rotary Club Of Chestfield" },
                    { "3f73c0b0-113c-4d81-a85d-1daf837b4b60", "United Kingdom", "8-10281486", "Inner Wheel Club of Chester" },
                    { "3fb89121-52ae-4b20-a326-d0f2810f3a10", "United Kingdom", "8-10284766", "Rotary Club of Lickey Hills, Birmingham" },
                    { "3fc67332-d2f0-4f63-99b7-589ba711a9a8", "United Kingdom", "8-10280832", "Rotary Club of Berwick-Upon-Tweed" },
                    { "402bf932-ba0b-4c44-8a95-75058b0f4ae7", "United Kingdom", "8-10242252", "Rotary Club of West Ashfield" },
                    { "40600268-8021-41ff-a852-a48e315107b0", "United Kingdom", "8-10281813", "Inner Wheel Club of Chester: Chapter & Verse" },
                    { "40c7520f-eea7-47ad-bd31-58f42a92e1d8", "United Kingdom", "8-10264267", "Inner Wheel Club of Haverfordwest" },
                    { "410e74a1-ce72-426e-8a2f-c0e8001976fc", "United Kingdom", "8-10281067", "Rotary Club of Stevenage" },
                    { "41177474-e229-4bf4-9cac-8c3614614b93", "United Kingdom", "8-10283684", "Rotary Club of Burnley" },
                    { "41542fd5-05ee-4b92-8641-ee36ada8d38c", "United Kingdom", "8-10285920", "Rotary Club of Southport Meols" },
                    { "416f6050-80e4-452d-a56a-ed1761754533", "United Kingdom", "8-10284694", "Rotary Club of Lauderdale" },
                    { "418df8b8-1f0e-4dcb-ad20-b49e16bbade6", "United Kingdom", "8-10278125", "Rotary Club of Knighton & District" },
                    { "41a3bcb4-42b1-446a-96f6-b79d3d62e1a3", "United Kingdom", "8-10243757", "Rotary Club of York" },
                    { "41d6759b-d888-461c-9cbb-76a5e4f5b2c3", "United Kingdom", "8-10281721", "Rotary Club of Hitchin" },
                    { "42154dd3-25a6-4293-b1a9-66648c17e330", "United Kingdom", "8-10278124", "Rotary Club of Cambridge Rutherford" },
                    { "42aa6054-a48c-45bf-be8a-9ec96e8410be", "United Kingdom", "8-10287021", "Interact Club James Calvert Spence School" },
                    { "42e3fef5-4f04-4ac5-852d-927fbf31ec41", "United Kingdom", "8-10251658", "Inner Wheel Club of Newark" },
                    { "435a4d3e-b369-49a8-abad-d8e4b988383c", "United Kingdom", "8-10278276", "Rotary Club of Manningtree Stour Valley" },
                    { "436a5122-6452-43e6-ba9e-b9080becfcd2", "United Kingdom", "8-10278531", "Inner Wheel District 23" },
                    { "43735fad-4148-4393-97ca-b0f44782d29e", "United Kingdom", "8-10260526", "Rotary Club of Hunterston" },
                    { "4381f701-3562-4db2-99dd-c041447528df", "United Kingdom", "8-10248793", "Rotary Club of Hadrian's Wall (Tynedale)" },
                    { "43a895fd-1727-4c96-9c7c-bdb013899287", "United Kingdom", "8-10282660", "Rotary Club of Shipley" },
                    { "43b8b960-6be2-443c-b746-0da2e4b1822c", "United Kingdom", "8-10278148", "Rotary Club of Pershore" },
                    { "43bb7b15-e07a-43df-80eb-ac7251d35911", "United Kingdom", "8-10242436", "Rotary Club of Hull Paragon" },
                    { "43d08b6e-b46b-4b43-adfa-7028b44d670b", "United Kingdom", "8-10282848", "Inner Wheel Club of North Wilts" },
                    { "43f08160-2e89-4619-bad4-67c2ad3354ce", "United Kingdom", "8-10242515", "Rotary Club of Birtley" },
                    { "44095ed2-8a4c-4498-a782-b8a273a43df3", "United Kingdom", "8-10285883", "Rotary Club of Inverness Loch Ness" },
                    { "44123501-1370-4fc7-9374-ac8fa83f77eb", "United Kingdom", "8-10249794", "Rotary Club of Torrington" },
                    { "442808bc-eb8b-406e-a650-12a37a8f4ced", "United Kingdom", "8-10251535", "Rotary Club of Crickhowell" },
                    { "4440cc3d-5183-4797-9db0-3bc7ae654573", "United Kingdom", "8-10281645", "Rotary Club of Loughborough Beacon" },
                    { "4454fa3d-75fd-4bad-bb4e-ab285a170c66", "United Kingdom", "8-10278155", "Rotary Club of Bognor Hotham" },
                    { "447fc587-1c8e-42c3-8689-59854ce8e10e", "United Kingdom", "8-10277353", "Rotary Club of Manchester Breakfast" },
                    { "44e20246-4a1c-4dfe-9edf-75b05f3184d5", "United Kingdom", "8-10287230", "Rotary Club of Portishead" },
                    { "4504e342-65f5-4cba-84f7-007564cf3a3b", "United Kingdom", "8-10249234", "Rotary Club of Cork" },
                    { "45721272-51d2-42c1-a725-93447de97de9", "United Kingdom", "8-10280226", "Rotary Club of Newcastle Gosforth" },
                    { "45a93896-628b-4ac2-9de3-c2b326bf5ad7", "United Kingdom", "8-10375193", "Rotary Club Of Crowborough" },
                    { "45b28ff8-2fbb-4781-8988-110f8b25057e", "United Kingdom", "8-10239841", "Rotary Club of Orkney" },
                    { "45b70606-8471-4b98-8f48-7bfcc2fc928e", "United Kingdom", "8-10252085", "Inner Wheel Club of Tamworth Anker" },
                    { "45c4248f-7314-4162-b814-dfe4c3ce0a55", "United Kingdom", "8-10285667", "Rotary Club of Cardiff West" },
                    { "463a2d56-de7b-43cb-96d3-a9a175dcaeba", "United Kingdom", "8-10279168", "Rotary Club of Llanelli" },
                    { "46a326e2-2b91-4913-b088-6c91b955e3f6", "United Kingdom", "8-10278006", "Inner Wheel Club of Hinckley" },
                    { "46ac8a96-e07f-4899-88ab-1f2bdeea12f6", "United Kingdom", "8-10281404", "Rotary Club of Exeter Southernhay" },
                    { "46bdf38d-68f8-4574-a52b-9e6b25399a05", "United Kingdom", "8-10279754", "Rotary Club of Southport" },
                    { "46e174f2-f280-4d60-85d9-5ccc448ce80d", "United Kingdom", "8-10286549", "Rotary Club of Windsor St. George" },
                    { "4708184c-93a9-4798-a61b-ad2c15fac103", "United Kingdom", "8-10285731", "Rotary Club of Central Buchan" },
                    { "471f61bc-6666-4fb4-86de-58228a3a1a23", "United Kingdom", "8-10279386", "Rotary Club of Solihull St. Alphege" },
                    { "4755a3f5-b03d-4a65-bdf8-725c8bfb5769", "United Kingdom", "8-10278073", "Rotary Club of Antrim" },
                    { "47576fa2-e7d2-44a1-8b00-e4e029a90dde", "United Kingdom", "8-10252077", "Rotary Club of Andover" },
                    { "47605104-4156-4afc-87b8-63f085594b3b", "United Kingdom", "8-10240266", "Inner Wheel District 9" },
                    { "476cd009-2316-4466-b869-49e24010a886", "United Kingdom", "8-10280728", "Inner Wheel Club of Hart" },
                    { "476d3363-399b-4ddd-9f10-5e94fd70b195", "United Kingdom", "8-10243666", "Rotary Club of Oldbury" },
                    { "4776dbb7-3e32-400c-8506-53c2ee810004", "United Kingdom", "8-10247322", "Rotary Club of Drogheda" },
                    { "47954005-102c-4af9-84c8-1dfe56e410b7", "United Kingdom", "8-10284719", "Rotary Club of Reigate" },
                    { "47a37303-8f8c-43a6-be6c-455357902cdb", "United Kingdom", "8-10247149", "Rotary Club of Tullamore" },
                    { "47c5f955-6ff8-44e9-ac38-5e281cca0845", "United Kingdom", "8-10249443", "Inner Wheel Club of Abergele" },
                    { "47e28fd6-ab75-4074-9c2a-2ba8bf20e114", "United Kingdom", "8-10284029", "Rotary Club of Wallingford & Didcot District" },
                    { "484556f6-c860-4560-80ba-f81c9cd4f41c", "United Kingdom", "8-10282636", "Rotary Club of Sunderland" },
                    { "484a6dd1-0096-47bf-8cff-c056c883974b", "United Kingdom", "8-10265063", "Rotary Club of Dalkeith" },
                    { "487dc810-20be-4f75-8e7a-31d9932db41d", "United Kingdom", "8-10250367", "Rotary Club of Biggleswade" },
                    { "489af716-41b1-46c7-964f-42c9758b7caa", "United Kingdom", "8-10278797", "Rotary Club of Rotary@Kingsholm, Gloucester" },
                    { "48c1dce2-8522-40d0-b56e-d58d1c6f31fd", "United Kingdom", "8-10280766", "Rotary Club of Enniskillen" },
                    { "48c2793d-fefc-4342-a35e-f1a028142c28", "United Kingdom", "8-10248157", "Rotary Club of Carmarthen Tywi" },
                    { "48f38a3a-dca4-4f06-aadb-55dc4111642a", "United Kingdom", "8-10284645", "Rotary Club of Addiscombe and Shirley" },
                    { "491dd9a1-d698-4c57-a937-9b2190d4362d", "United Kingdom", "8-10280512", "Inner Wheel Club of Coventry" },
                    { "491f7044-8c01-4060-862b-aef3bfed3772", "United Kingdom", "8-10282346", "Inner Wheel Club of Dublin/Limerick & Shannon/Waterford" },
                    { "4929e58a-247f-4cbc-bc43-0d5669908064", "United Kingdom", "8-10252051", "Rotary Club of Basingstoke Deane" },
                    { "4935d76e-afa3-442d-a04f-5e3535f8c0b2", "United Kingdom", "8-10283997", "Rotary Club Of Herne Bay" },
                    { "494f5229-af13-4ec0-93cc-e1190559db2a", "United Kingdom", "8-10242870", "Rotary Club of Haslemere" },
                    { "49553da3-33f4-47e2-9727-b15d23d5d0a5", "United Kingdom", "8-10252068", "Rotary Club of Aireborough" },
                    { "49c478ed-e043-4d0d-8b82-1fa3f1d80543", "United Kingdom", "8-10238878", "Rotary Club of Cowbridge /Interact Club of Cowbridge School" },
                    { "49d3bbe2-d2a9-41f9-97a0-20118e223432", "United Kingdom", "8-10277572", "Rotary Club of Southampton" },
                    { "49d655fd-8f58-4c38-95ef-450b29b49617", "United Kingdom", "8-10286444", "Rotary Club of Melrose" },
                    { "4a367fa0-7a35-4f6b-b18f-08e670b5274a", "United Kingdom", "8-10286885", "Rotary Club of Tywyn" },
                    { "4a6dfc7b-add6-4fae-b103-6685fcc66257", "United Kingdom", "8-10282970", "Rotary Club of Rochdale East" },
                    { "4a7cedb8-861a-4117-8154-dbd0dbdfe8da", "United Kingdom", "8-10277796", "Rotary Club of Burntwood & District" },
                    { "4af40177-ae23-48cb-9700-acc59af1a18a", "United Kingdom", "8-10256249", "Rotary Club of Thornhill & District" },
                    { "4b095e54-0670-41bf-8c8b-73a98921e7fd", "United Kingdom", "8-10251436", "Rotary Club of Paignton" },
                    { "4b64e0ba-cb9f-4a50-98fa-054381291d01", "United Kingdom", "8-10284129", "Rotary Club of Chingford" },
                    { "4b93c53c-6734-4aa7-8b93-21171cae6437", "United Kingdom", "8-10278277", "Rotary Club of Warwick" },
                    { "4ba9a5fc-f36d-485d-9234-18c4b1d0f897", "United Kingdom", "8-10278525", "Rotary Club of Coventry Jubilee" },
                    { "4c30064f-9e50-4b59-9a8a-806bda8e40af", "United Kingdom", "8-10279358", "Rotary Club of Leicester Novus" },
                    { "4c7ce98a-3bec-42f4-a7e8-20917b41714f", "United Kingdom", "8-10281746", "Inner Wheel Club of Winchester" },
                    { "4c900da7-4f77-47fd-8962-eab0b8876171", "United Kingdom", "8-10282626", "Inner Wheel Club of Pitlochry" },
                    { "4c977180-c444-4522-b6fa-a6f498091ed0", "United Kingdom", "8-10282670", "Rotary Club of Newport Uskmouth" },
                    { "4cbf7930-c3a6-4842-babf-44a2f6c8ca0f", "United Kingdom", "8-10280819", "Rotary Club of Biddulph" },
                    { "4cc10f2f-aeed-44ab-938d-bddb01632686", "United Kingdom", "8-10286337", "Rotary District 1260" },
                    { "4cee3f99-c658-4f26-b5ad-04f06b576ce6", "United Kingdom", "8-10278292", "Inner Wheel Club of Woodhall Spa Charity" },
                    { "4d2d1d17-a2dd-4c37-a024-5d39e9203bb2", "United Kingdom", "8-10278129", "Rotary Club of Inverness Culloden" },
                    { "4d4bb79d-b580-4112-8b6a-6f6b192d2313", "United Kingdom", "8-10258974", "Rotary Club of Blyth" },
                    { "4d5f2094-d07c-4aa5-8f9f-c5ed26b5b566", "United Kingdom", "8-10283637", "Rotary Club of Devizes" },
                    { "4d8c92b6-780e-4182-ba83-5e3c87a36819", "United Kingdom", "8-10265981", "Inner Wheel Club of Bangor (NI)" },
                    { "4d9f553a-3e4c-4962-9a14-261499077126", "United Kingdom", "8-10278576", "Rotary Club of Wednesfield" },
                    { "4da9807f-caac-45ea-89cf-4cacaa9796da", "United Kingdom", "8-10279353", "Rotary Club of Portsmouth & Southsea" },
                    { "4dac74bb-76a2-4f28-a946-a2d8607da8ef", "United Kingdom", "8-10248724", "Inner Wheel Club of Tranent" },
                    { "4db3b115-45e1-4c66-889e-1367434e23cc", "United Kingdom", "8-10285739", "Rotary Club of Saxmundham & District" },
                    { "4dbd4eca-207b-4faf-bdaf-4fb749140d96", "United Kingdom", "8-10240068", "Rotary Club of Kingsbridge" },
                    { "4ddd58a1-689e-4890-99e0-ed5ad08be87d", "United Kingdom", "8-10243620", "Rotary Club of Worcester Vigornia" },
                    { "4de19e1a-147f-45c7-8fed-38e2fc268d4c", "United Kingdom", "8-10280504", "Rotary Club of Retford" },
                    { "4e00dfa7-d96b-49b9-ab3f-60135034e2ee", "United Kingdom", "8-10247256", "Rotary Club of Formby" },
                    { "4e2f0811-9f03-4724-ad14-9f1dd6fa0c7b", "United Kingdom", "8-10242747", "Inner Wheel Club of Southampton" },
                    { "4e4f955a-862d-4699-b424-66ab593a754a", "United Kingdom", "8-10246928", "Inner Wheel Club of West Wickham" },
                    { "4e508866-4a4d-472b-920c-1b1c7d01a6f6", "United Kingdom", "8-10279338", "Rotary Club of Bargoed" },
                    { "4e576e81-507e-41bb-9843-a67bd9d3673d", "United Kingdom", "8-10273361", "Inner Wheel Club of Kirkcudbright" },
                    { "4e95e0e3-9111-446b-a52e-af1ddc3e2e09", "United Kingdom", "8-10284684", "Rotary Club of Harleston & District" },
                    { "4ea89424-7e31-4b5a-8fda-3482a54849bc", "United Kingdom", "8-10280460", "Rotary Club of Callington" },
                    { "4eb90b26-2e6b-432d-8773-e6a2b5f77441", "United Kingdom", "8-10281962", "Rotary Club Of St Austell Bay" },
                    { "4edbc80d-1b59-4284-878f-9e98ed31c806", "United Kingdom", "8-10278352", "Rotary Club of Southport Sunrise" },
                    { "4ee308bd-6d74-41e5-b511-27d58371c5ec", "United Kingdom", "8-10285703", "Rotary Club of Preston Amounderness" },
                    { "4f06e4ed-b89a-446e-8546-27e216aca95a", "United Kingdom", "8-10287096", "Inner Wheel Club of Pershore" },
                    { "4f21a28b-6a59-495a-ba36-a4f7ee256863", "United Kingdom", "8-10282861", "Rotary Club of Oswestry" },
                    { "4f36b75d-ebad-47cb-b325-f4bcd18e9ed4", "United Kingdom", "8-10258995", "Rotary Club of Aberdeen Bon Accord" },
                    { "4f71eb81-b798-45db-adc4-4fa70c0d21b3", "United Kingdom", "8-10287165", "Rotary Club of Loudoun" },
                    { "4f9819f0-11ca-487c-a0da-fab7eadc1243", "United Kingdom", "8-10252651", "Rotary Club of Kelvin (Glasgow)" },
                    { "4f9f4466-7aef-4199-812b-afb9bab41fc7", "United Kingdom", "8-10243333", "Rotary Club of Wolverton and Stony Stratford" },
                    { "4fc9be93-233a-4143-a42b-89f0efeac19d", "United Kingdom", "8-10241429", "Rotary Club of Whitchurch" },
                    { "4ff8c218-83ad-4250-90d9-6cd2848fd209", "United Kingdom", "8-10281104", "Rotary Club of Morley" },
                    { "50211f85-0299-453f-ac7a-5ee64e2adc62", "United Kingdom", "8-10281231", "Rotary Club of Alloa" },
                    { "50318632-d4c6-4cbb-9d17-7827d8df69f3", "United Kingdom", "8-10282957", "Rotary Club of Bridgnorth" },
                    { "50335c48-72c9-48c6-af9b-ff0277344a67", "United Kingdom", "8-10254220", "Rotary Club of Salisbury" },
                    { "504aa48e-1d73-4a7c-94e7-4dd9650daac8", "United Kingdom", "8-10285545", "Rotary Club of Whitstable" },
                    { "504e3432-bba1-4eda-9b1d-685136a4e643", "United Kingdom", "8-10239985", "Rotary Club of Great Missenden and District" },
                    { "50659eb3-79c7-4385-a555-b48eb174c2cc", "United Kingdom", "8-10249143", "Inner Wheel Club of Lutterworth" },
                    { "50855a90-8b9c-411a-bad0-5fa71e5f4400", "United Kingdom", "8-10282915", "Rotary Club of Melton Aurora" },
                    { "50bdb103-ee00-47d5-a967-00746449b7f8", "United Kingdom", "8-10285569", "Rotary District 1160" },
                    { "50cde61e-3579-4876-81fa-1bedc34f00b3", "United Kingdom", "8-10287200", "Rotary Club of New Forest" },
                    { "50d89a83-f54f-416f-910e-710a245569ff", "United Kingdom", "8-10259013", "Inner Wheel Club of Wigston" },
                    { "510ba59f-33df-4207-a711-3965f7b314a8", "United Kingdom", "8-10283818", "Rotary Club of Dumbarton" },
                    { "511bbbae-c384-4db8-8e14-bcc879278b1c", "United Kingdom", "8-10241164", "Rotary Club of Derwentside" },
                    { "514031b5-9d82-4444-9c38-01ca8f705356", "United Kingdom", "8-10372833", "K W S Interact Club" },
                    { "5144fab3-c419-4486-9e73-ef20762695c3", "United Kingdom", "8-10242136", "Rotary Club of Coulsdon Manor" },
                    { "518845ea-de30-4549-b889-d0d12589572c", "United Kingdom", "8-10250377", "Rotary Club of Caterham" },
                    { "51cb7efa-be30-4dee-b4de-842c9cbca237", "United Kingdom", "8-10279248", "Rotary Club of Southampton Magna" },
                    { "51cc41a2-3de6-402e-b13b-e8b88a1effcf", "United Kingdom", "8-10278762", "Rotary Club of Milford Haven" },
                    { "51dea00b-e10d-4b62-ae68-a7ea01cb1028", "United Kingdom", "8-10278447", "Rotary Club of Thanet" },
                    { "51f7c47a-a588-4969-aa5e-7c21a289c67d", "United Kingdom", "8-10280842", "Interact Club of Tendring Technology College" },
                    { "523331ed-8150-4e7d-8100-75f909532042", "United Kingdom", "8-10278060", "Inner Wheel Club of Luton Chiltern" },
                    { "52b38626-79aa-4157-add2-7d47102b5e5d", "United Kingdom", "8-10243341", "Inner Wheel Club of Babbacombe & St Mary Church" },
                    { "52b7957a-6090-466e-a4b9-d13f4dbbe118", "United Kingdom", "8-10249258", "Rotary Club of Long Eaton Dawnbreakers" },
                    { "52bbfefd-36f8-410c-a239-63f2adf9c749", "United Kingdom", "8-10282103", "Rotary Club Of Nene Valley" },
                    { "52bf04b3-67c7-4fa9-bc03-ec428abf7d00", "United Kingdom", "8-10248696", "Rotary Club of Padiham" },
                    { "5344aa24-14ab-4c94-a3ef-2c5a167c7a3e", "United Kingdom", "8-10263883", "Rotary Club of Prescot" },
                    { "536eaa58-42aa-49c7-9508-13973120ca2d", "United Kingdom", "8-10280446", "Rotary Club of Hull Kingston" },
                    { "5371fd9d-4843-4810-8791-c866733be891", "United Kingdom", "8-10280213", "Inner Wheel Club of Bretby" },
                    { "53925fc8-5a25-4e39-b318-d1912754c8f5", "United Kingdom", "8-10250254", "Inner Wheel Club of Morecambe & Heysham" },
                    { "53ae1b46-5b6d-42c7-bad1-a5ced3783803", "United Kingdom", "8-10279427", "Rotary Club of Ripon" },
                    { "53e1950e-a06b-4511-8c82-c79e3c404c24", "United Kingdom", "8-10244764", "Rotary Club of Todmorden" },
                    { "53ea49ae-2cdd-4c35-98f5-b47cc5fa29e5", "United Kingdom", "8-10285539", "Rotary Club of Aberdeen (St. Fittick)" },
                    { "544d6685-215a-4b0d-82a0-f54e895067fe", "United Kingdom", "8-10286477", "Rotary Club of Keith" },
                    { "5482eb74-4902-4842-8b05-f9d68f23c141", "United Kingdom", "8-10280224", "Rotary Club of Bradford West" },
                    { "54aa6481-338d-4e6f-a437-01f06a2d62ac", "United Kingdom", "8-10277844", "Rotary Club of Havant" },
                    { "54ac0f7b-e555-4dc4-b680-bedd292d0f57", "United Kingdom", "8-10291681", "Rotary Club of Ythan Valley" },
                    { "54adb467-d34c-4704-a9f0-3da122776a20", "United Kingdom", "8-10279486", "Rotary Club of Shepshed" },
                    { "557b2bc9-0a65-4497-a451-fc9bc5393714", "United Kingdom", "8-10250918", "Rotary Club of Settle" },
                    { "55bd2b86-d4a6-401a-ad6e-d72c39664535", "United Kingdom", "8-10280743", "Rotary Club of Aldridge" },
                    { "5643a3e2-933b-4119-833a-220f7b484d17", "United Kingdom", "8-10280077", "Inner Wheel Club of Halesowen" },
                    { "56483f6c-2069-4e6b-9e44-0fa9e80d1a37", "United Kingdom", "8-10281986", "Inner Wheel Club of Ruthin" },
                    { "567db46d-e424-4b5d-84d9-e290ce21cd7e", "United Kingdom", "8-10250931", "Inner Wheel Club of Thame" },
                    { "56aa268a-7586-4f41-a63e-1b88b1052871", "United Kingdom", "8-10282002", "Inner Wheel Club of Gloucester" },
                    { "56d5e3b1-adf9-404e-b8c4-4398f65aec05", "United Kingdom", "8-10243609", "Rotary Club of Camelford" },
                    { "57702f4e-da9f-4215-9da6-99387691b704", "United Kingdom", "8-10264210", "Rotary Club of Willaston & South Wirral" },
                    { "579c48f9-a34b-4f90-ab0a-8055a647c609", "United Kingdom", "8-10243633", "Rotary Club of Yeo Vale" },
                    { "579eee23-6c79-444c-b7df-d74b75a2f759", "United Kingdom", "8-10279660", "Rotary Club of Kinver" },
                    { "57a3e08e-bea7-4950-8418-18bc338e527c", "United Kingdom", "8-10281398", "Rotary Club of Rutherglen" },
                    { "57a885e7-d832-41fb-8d41-a5264aaf406e", "United Kingdom", "8-10284744", "Inner Wheel Club of Havant" },
                    { "57b8e2eb-9207-4d40-a9ec-d4b3f1be00ca", "United Kingdom", "8-10282877", "Rotary Club of Sittingbourne Invicta" },
                    { "57c40b5c-219c-4d06-b309-c077dd57cad4", "United Kingdom", "8-10286408", "Inner Wheel Club of High Wycombe" },
                    { "57cac9f4-58ac-4b24-9943-ccc353065f40", "United Kingdom", "8-10276569", "Rotary Club of Croydon Whitgift" },
                    { "57cf46f7-23c4-43a2-86e4-547ac6eae5c8", "United Kingdom", "8-10283651", "Rotary Club of St. Andrews" },
                    { "57eea136-9639-4d2e-9a43-c2ab931482fa", "United Kingdom", "8-10286974", "Inner Wheel Club of Dundee" },
                    { "58196c9e-cb5b-4790-9780-daa93ec1138b", "United Kingdom", "8-10276727", "Rotary Club of Portobello" },
                    { "583a00f7-bb1b-4386-b7a5-dde1dc2de439", "United Kingdom", "8-10278271", "Rotary Club of Carlisle Castle" },
                    { "58600458-e4e2-41b3-af5d-962721ce868c", "United Kingdom", "8-10278118", "Inner Wheel Club of Ammanford" },
                    { "586d070f-3007-4a18-9751-c6313c86b200", "United Kingdom", "8-10247926", "Rotary Club of Saltash" },
                    { "58c42ede-4093-429f-82ce-0440ba68f1f5", "United Kingdom", "8-10279779", "Rotary Club of Chester Deva" },
                    { "58dcf3c9-b637-4792-bab1-fec21cd6bcd8", "United Kingdom", "8-10254936", "Rotary Club of Stornoway" },
                    { "58df790f-77a7-40d6-9140-0a7b3645c907", "United Kingdom", "8-10281817", "Inner Wheel Club of Portadown" },
                    { "58e04ed0-c899-43ad-8264-0befffb98efb", "United Kingdom", "8-10282343", "Rotary Club of Denby Dale & District" },
                    { "590c55ba-1f97-4302-8cdd-43f4cd6a5ed9", "United Kingdom", "8-10276600", "Rotary Club of Shaftesbury" },
                    { "5928329a-7437-4890-8400-2763dfd14c70", "United Kingdom", "8-10277059", "Rotary Club of Long Eaton" },
                    { "59348e62-5a13-4aa0-810a-f29f4fc3b4d6", "United Kingdom", "8-10239990", "Rotary Club of Melksham" },
                    { "59875603-fb1e-4bde-9018-f526ac9c711d", "United Kingdom", "8-10284032", "Rotary Club of Bexley" },
                    { "599b11a9-c9fb-4d78-96fc-bf064da19425", "United Kingdom", "8-10249432", "Rotary Club of Dorchester Casterbridge" },
                    { "59a133fb-0a61-4103-be7b-2e4b6549114c", "United Kingdom", "8-10283735", "Rotary Club of Horley" },
                    { "59abcb95-a48b-4850-8f11-5ecb08145807", "United Kingdom", "8-10285841", "Inner Wheel Club of Ipswich Orwell" },
                    { "5a0619bb-0afe-4b20-9538-e4f0f2ccd0e2", "United Kingdom", "8-10279316", "Rotary Club of Rotherham Sitwell" },
                    { "5a0e44db-5494-4edd-a2a8-c987491c94c7", "United Kingdom", "8-10280317", "Rotary Club Of Charing Cross Glasgow" },
                    { "5a1bccdc-f64f-408b-84a6-ede35b4a6b66", "United Kingdom", "8-10279401", "Rotary Club of Dublin North" },
                    { "5a21bed7-5e4b-475f-9c3b-da5997b58808", "United Kingdom", "8-10250911", "Rotary Club of Royal Wootton Bassett & District" },
                    { "5a31cb09-3dea-40d1-99a0-53388554ba1f", "United Kingdom", "8-10265168", "Inner Wheel Club of Ellon" },
                    { "5a6ee400-94f1-46a4-a082-2f46aa1cb12b", "United Kingdom", "8-10283729", "Rotary Club of Widnes" },
                    { "5a8251df-448d-4395-a2f6-b97fabb7da6e", "United Kingdom", "8-10278409", "Rotary Club of Brue Valley" },
                    { "5aa6480f-ea36-4e74-8087-d9bc10fc02b6", "United Kingdom", "8-10286534", "Rotary Club of Liverpool South" },
                    { "5ae24a3a-9113-4a13-9c94-3495c91b0a95", "United Kingdom", "8-10277351", "Rotary Club of Hounslow" },
                    { "5b56e78b-a2fd-4d86-bf33-a7e6f10c4734", "United Kingdom", "8-10277628", "Rotary Club of Lutterworth Wycliffe" },
                    { "5b60a81a-d589-4ba7-a1a1-bd42f491c891", "United Kingdom", "8-10260518", "Rotary Club of Brentwood A Becket" },
                    { "5b66ffed-2793-4789-a1ca-c22999ec44df", "United Kingdom", "8-10246617", "Inner Wheel Club of Dunfermline" },
                    { "5bc6ba7f-e2c1-4dd6-b3c1-c756c227439a", "United Kingdom", "8-10285821", "Rotary Club of Ashbourne" },
                    { "5bd2d265-90f9-4ff2-9e30-bcacee72973b", "United Kingdom", "8-10382545", "Inner Wheel Club Of Rutland" },
                    { "5bf635a8-abb5-4cec-ba46-550087ff270c", "United Kingdom", "8-10283829", "Rotary Club of Letchworth Howard" },
                    { "5bff1b84-7895-4ca4-be4e-d85cae7f4311", "United Kingdom", "8-10280434", "Inner Wheel Club of Beccles" },
                    { "5c236a3a-9d5d-4ff0-a3de-60518e3746db", "United Kingdom", "8-10251536", "Rotary Club of Penicuik" },
                    { "5c4be556-33e8-4cda-a732-81076812c6de", "United Kingdom", "8-10279794", "Rotary Club of Horsham" },
                    { "5c5c29e9-2160-4a1e-b5b0-f3316db8f158", "United Kingdom", "8-10287084", "Rotary Club of Wymondham" },
                    { "5c8c87c6-819f-4b5b-a423-732368a51f3a", "United Kingdom", "8-10281842", "Rotary Club of Crediton Boniface" },
                    { "5c931468-9cc3-48c3-a019-be780ec00806", "United Kingdom", "8-10281397", "Inner Wheel Club of Rhyl" },
                    { "5cac14ac-fbff-4d2e-a6a7-3ef5ef994b07", "United Kingdom", "8-10283748", "Rotary Club of Rushmoor" },
                    { "5cd841cd-301e-4c18-9580-8219f215e8b2", "United Kingdom", "8-10278590", "Inner Wheel Club of Aberdeen St Fittick" },
                    { "5cf79034-3cd7-411b-b4cc-69739a8098e8", "United Kingdom", "8-10278261", "Rotary Club of Hebden Bridge" },
                    { "5d0c9d1f-579c-465c-9be3-094f72748dbe", "United Kingdom", "8-10280686", "Inner Wheel Club of Ventnor" },
                    { "5d2a3ef4-e3ed-4c9f-878a-fe03c8f3f22c", "United Kingdom", "8-10280596", "Rotary Club of Buckingham" },
                    { "5dec01dc-14e8-49ff-97df-50ad894990bb", "United Kingdom", "8-10279258", "Inner Wheel Club of Blaby Meridian" },
                    { "5e082d50-ff10-4259-ab9f-d82efd94b791", "United Kingdom", "8-10245036", "Inner Wheel Club of Lowestoft" },
                    { "5e484f47-1ac3-4ca9-a148-010ffee4a388", "United Kingdom", "8-10281513", "Rotary Club of Tewkesbury" },
                    { "5e929cc3-99ff-4bdc-b9a3-88b96f7c710d", "United Kingdom", "8-10278780", "Interact Club of Port Talbot" },
                    { "5e9c8765-cf11-4dd5-9c5c-21f10b1b8628", "United Kingdom", "8-10286916", "Rotary Club of Strabane/Lifford" },
                    { "5eaa0850-18bb-4f49-96ef-cdeef89a4688", "United Kingdom", "8-10287220", "Rotary Club of Rotherham" },
                    { "5ead6ea4-901b-4948-95db-aaeef558088a", "United Kingdom", "8-10283643", "Inner Wheel Club of Northampton" },
                    { "5f27259d-62b4-4076-855f-7359a9e03d90", "United Kingdom", "8-10283474", "Inner Wheel Club of Seaburn" },
                    { "5f374ccd-2852-41f4-bc37-6d7753c47a25", "United Kingdom", "8-10285942", "Rotary Club of Bilston & Wolverhampton West" },
                    { "5fa8fe7c-7112-404b-aa3d-b4622d6fcee6", "United Kingdom", "8-10277299", "Rotary Club of Sandwich" },
                    { "5fb1c2fc-7295-4fd5-82a8-242eac88ee6a", "United Kingdom", "8-10286847", "Rotary Club of Clevedon Yeo" },
                    { "5ff397e3-fe1c-4ed6-bebc-8fec08b83d1b", "United Kingdom", "8-10282685", "Rotary Club of Lanark" },
                    { "6039bb9b-be56-49f3-9f6c-21d9c0291995", "United Kingdom", "8-10248760", "Rotary Club of Chelmer Bridge" },
                    { "604471a8-5811-454b-8777-ac60664d5048", "United Kingdom", "8-10281270", "Rotary Club of Knaresborough" },
                    { "60a99978-18c5-4085-bfd7-009b819f381a", "United Kingdom", "8-10283946", "Rotary Club Of Ringwood" },
                    { "60b204a6-5ae0-403a-8869-efeffd1f2042", "United Kingdom", "8-10264312", "Inner Wheel Club of Llangefni" },
                    { "61264ccb-f17a-4809-a564-19de4a99c6ba", "United Kingdom", "8-10281108", "Rotary Club of Chester" },
                    { "6132967d-2bf8-48ee-a7da-94b69aa1f7de", "United Kingdom", "8-10277024", "Inner Wheel Club of Ballymoney" },
                    { "61c1eb3b-92e7-4b81-a2f1-1eda8cd51a8d", "United Kingdom", "8-10282959", "Rotary Club of Cardiff" },
                    { "61d24355-18c7-4277-8ad7-18104fa448be", "United Kingdom", "8-10249312", "Rotary Club of Bailgate Lincoln" },
                    { "6222f29c-25f4-4059-bdaf-d40901e695b3", "United Kingdom", "8-10255898", "Rotary Club of Ripley" },
                    { "6224198a-b52b-4506-b47f-65d9f8cf497e", "United Kingdom", "8-10286400", "Inner Wheel Club of Perranzabuloe" },
                    { "62576241-5a40-4aa0-b04c-e4c044ca7f4e", "United Kingdom", "8-10249282", "Inner Wheel Club of Chard" },
                    { "626254d9-3d0e-4c1d-a0e5-27fe09af0daa", "United Kingdom", "8-10280186", "Rotary Club of Elland" },
                    { "62a5888a-e95b-49c2-9a19-d85755706b61", "United Kingdom", "8-10280299", "Rotary Club of South Ribble" },
                    { "62cf5bab-28ed-46ec-8b21-3660b92f9ba0", "United Kingdom", "8-10248169", "Rotary Club of Barton-le-Clay" },
                    { "62f0e495-d4e2-498b-895a-f292a50ed3e5", "United Kingdom", "8-10284793", "Rotary Club of Dingwall" },
                    { "62fe1ae6-0706-46b7-b7de-1c7b5a5663b3", "United Kingdom", "8-10243439", "Inner Wheel Club of Wallasey" },
                    { "63296bd8-c67a-404e-8d1c-1653c598eea2", "United Kingdom", "8-10282180", "Rotary Club of Wednesbury" },
                    { "6337f0ce-82b3-40d4-9c25-ab43061a8d05", "United Kingdom", "8-10282415", "Inner Wheel District 20" },
                    { "63702245-7216-4979-990d-9b88faa69e3c", "United Kingdom", "8-10252075", "Rotary Club of Clydebank" },
                    { "6389ba45-df3c-45b2-9081-dbc7c542acbf", "United Kingdom", "8-10256362", "Rotary Club of Lewes Barbican" },
                    { "639e48cd-cf8d-4a04-8007-99562e1ef922", "United Kingdom", "8-10280258", "Interact Club of Dyffryn" },
                    { "63aad25c-aac1-4644-89ea-7983b4b64d3c", "United Kingdom", "8-10277433", "Interact Club of Crosby" },
                    { "63b3dbb9-494f-4894-9283-37cd156d42f4", "United Kingdom", "8-10285617", "Rotary Club of Skipton" },
                    { "63bae896-cea1-42bc-88a4-be12acc1a074", "United Kingdom", "8-10281814", "Rotary Club of Burton Upon Trent" },
                    { "640c1d0f-f6a3-4e9c-98f3-a2816192cbfe", "United Kingdom", "8-10285873", "Inner Wheel Club of Colchester" },
                    { "644ad96c-7253-4a6e-8f24-5bc06c0ece57", "United Kingdom", "8-10282661", "Inner Wheel Club of Tiverton" },
                    { "648c7816-2ee2-4a83-85aa-79431ae01b64", "United Kingdom", "8-10279781", "Rotary Club of Garstang & Over Wyre" },
                    { "64baa4f9-8baa-46fa-98fe-c31e458c564f", "United Kingdom", "8-10239885", "Inner Wheel Club of Blandford" },
                    { "653b4a3e-6d9a-4b83-a646-ace60d096c98", "United Kingdom", "8-10251525", "Rotaract Club of Camberley" },
                    { "6565a868-8448-47e6-918c-618d09f6469c", "United Kingdom", "8-10279302", "Inner Wheel Club of Southport Meols" },
                    { "659e89df-5126-4c11-8838-7f1b70c2036d", "United Kingdom", "8-10283806", "Inner Wheel Club of Witham" },
                    { "65b24f6b-c1dc-4f19-890d-fbccc38451bd", "United Kingdom", "8-10287215", "Rotary Club of Paddington" },
                    { "65d461d9-1fe2-43dc-9351-362e0b6dbae6", "United Kingdom", "8-10278278", "Rotary Club of Carrickfergus" },
                    { "65de7212-bd87-4e94-ac78-1cc879a59992", "United Kingdom", "8-10278504", "Rotary Club of Callander & West Perthshire" },
                    { "66266d9e-7f3a-4b93-bb18-b7c399eb035e", "United Kingdom", "8-10247917", "Rotary Club of Pitlochry" },
                    { "6657f112-eb8c-43c1-b418-20d05977011e", "United Kingdom", "8-10249419", "Rotary Club of Burnley Pendleside" },
                    { "666c9a4e-c9d6-4d86-aa3e-3071cdd43d32", "United Kingdom", "8-10284796", "Rotary Club of Crewkerne District" },
                    { "667f3beb-b090-43eb-a981-f7e010b276a7", "United Kingdom", "8-10280725", "Rotary Club of Church Wilne" },
                    { "66a13778-0996-424e-a8cb-20ede0deebb3", "United Kingdom", "8-10240056", "Rotary Club of Cotswold Tyndale" },
                    { "66cbf64c-70d9-4ad8-8b69-16e281a7589a", "United Kingdom", "8-10284782", "Inner Wheel Club of Battle" },
                    { "66e15085-4ed2-4f99-ae90-4029672b030e", "United Kingdom", "8-10286701", "Rotary Club of Glenrothes" },
                    { "670b2381-677b-4210-8134-0f6bafe26b83", "United Kingdom", "8-10280122", "Rotary Club of Slough" },
                    { "67243634-ddd9-49ae-94f3-9500a8a2b851", "United Kingdom", "8-10285661", "Inner Wheel Club of St Ives, Cornwall" },
                    { "6731e020-e23d-4131-ae73-7791115b685e", "United Kingdom", "8-10281449", "Rotary Club of Lochaber" },
                    { "6732a9fa-6e8a-463f-b380-ef4aa9881b82", "United Kingdom", "8-10249902", "Inner Wheel Club of Southend Estuary" },
                    { "6740684e-b6f6-4ed1-a447-91844e4d4040", "United Kingdom", "8-10242429", "Rotary Club Of Blandford & Stour" },
                    { "676394cd-9921-4da3-9460-62ec9383d5c4", "United Kingdom", "8-10264288", "Rotary Club of Maidenhead Bridge" },
                    { "67726cad-a4d1-410a-880c-0a1dd93311ea", "United Kingdom", "8-10273377", "Inner Wheel Club of Torquay" },
                    { "6788b5ed-e65c-40c3-a2cd-e843e8998fe3", "United Kingdom", "8-10279554", "Rotary Club of Astley" },
                    { "67a4b375-bcc9-4abf-98c4-c885e804fcbc", "United Kingdom", "8-10280443", "Inner Wheel Club of Weymouth" },
                    { "67a6a363-e586-4dcd-b07d-de316eebaea7", "United Kingdom", "8-10286652", "Rotary Club of Fleetwood" },
                    { "67d11c0e-74aa-4107-872a-18fe949909fc", "United Kingdom", "8-10283922", "Inner Wheel Club of Havering" },
                    { "67d1b008-7028-4415-9adb-49c01f80e324", "United Kingdom", "8-10286447", "Rotary Club of Blythe Bridge & District" },
                    { "67f06bff-fb9a-40a6-9404-e433ce4eb309", "United Kingdom", "8-10279160", "Inner Wheel District 14" },
                    { "6836515c-f97e-4c71-a4c8-a43f130f6aca", "United Kingdom", "8-10286316", "Rotary Club of Romford" },
                    { "6852c113-8bf4-4efe-8c9d-2bea9027c854", "United Kingdom", "8-10243484", "Rotary Club of Birstall Luddites" },
                    { "688e6c77-2303-4c19-a04c-f257b410417f", "United Kingdom", "8-10249444", "Inner Wheel Club of Kibworth & Fleckney" },
                    { "68c28643-4f99-4562-a66d-c0b395f594e0", "United Kingdom", "8-10242433", "Rotary Club of Nairn" },
                    { "68cada47-37c6-4764-bad9-dc9e044161be", "United Kingdom", "8-10277060", "Rotary Club of Harrow" },
                    { "68faf6de-c85e-4de1-8834-7ec68a0522b0", "United Kingdom", "8-10275238", "Inner Wheel Club of Kettering and Members" },
                    { "691f8e21-d3fb-402d-928d-ab7e317edcb0", "United Kingdom", "8-10279553", "Inner Wheel Club of Tarporley" },
                    { "692250c0-3218-4045-873e-1394f1c178ae", "United Kingdom", "8-10246948", "Rotary Club of Sherwood Forest" },
                    { "69516fb4-5d5d-4fd3-ac4a-51bac4699af4", "United Kingdom", "8-10286862", "Rotary Club of Alloway" },
                    { "6952ceb2-20b1-4cd7-a808-ff318dd2d44c", "United Kingdom", "8-10281357", "Interact Club of Maesydderwen School" },
                    { "697ab91c-f28d-46c1-8f8b-123aaca5ab6c", "United Kingdom", "8-10280739", "Inner Wheel Club of Crompton & Royton" },
                    { "69ace961-899b-496b-bcfd-c888449e3a6b", "United Kingdom", "8-10276581", "Rotary Club of Tormohun (Torquay)" },
                    { "69ce8722-fed0-4014-8ab6-347dc2954d03", "United Kingdom", "8-10283887", "Inner Wheel Club of Thirsk" },
                    { "69f019d3-8de7-4300-9dc5-798e2ac235ac", "United Kingdom", "8-10281877", "Rotary Club of Thornbury" },
                    { "6a003afa-c7bc-427f-a2e6-3246e2352ca0", "United Kingdom", "8-10286263", "Inner Wheel Club of Stafford" },
                    { "6a16c818-622e-4215-af57-bcc4d778d249", "United Kingdom", "8-10279402", "Rotary Club of Marlborough & District" },
                    { "6a1d2a55-e7d2-4aec-928d-f77d277edd00", "United Kingdom", "8-10265763", "Rotary Club of Somer Valley" },
                    { "6a4d6ebd-70e5-4ea2-ba49-d0b1e1a91baf", "United Kingdom", "8-10277780", "Rotary Club of Frodsham & Helsby" },
                    { "6a758e7c-1bcd-4b70-bc65-3d58e558a8de", "United Kingdom", "8-10256254", "Inner Wheel Club of Church Stretton" },
                    { "6a7e073b-cea0-4ef0-9d26-065b4dddbc0a", "United Kingdom", "8-10281213", "Rotary Club of Tyneside" },
                    { "6a9e0e9f-fdab-41b2-8fa6-34d0e5b7ef54", "United Kingdom", "8-10249091", "Inner Wheel Club of Maidstone" },
                    { "6ac7236a-4172-4b88-974a-6d457b3ceaf7", "United Kingdom", "8-10283486", "Rotary Club of Ingatestone" },
                    { "6ad6bcf1-6feb-410f-9e66-c24aa7e581f4", "United Kingdom", "8-10239353", "Rotary Club of Duns" },
                    { "6b05db99-0fad-4912-942c-4a1ac3b237ef", "United Kingdom", "8-10286877", "Rotary Club of Saughall" },
                    { "6b0abad9-b4c3-48af-925e-e4a9083a2a04", "United Kingdom", "8-10277290", "Inner Wheel Club of Bangor (N. Wales)" },
                    { "6b312dcd-75ac-4085-bc4c-b8b67358b4f5", "United Kingdom", "8-10269416", "Rotary Club of Kensington & Chelsea" },
                    { "6b97c540-b1df-451e-9971-dd921bfc8b81", "United Kingdom", "8-10280652", "Inner Wheel Club of Thornaby & Yarm" },
                    { "6ba344e3-73f7-4be1-82aa-52699fe69be8", "United Kingdom", "8-10285869", "Rotary Club of Calverley" },
                    { "6bac968e-a1fa-4bd1-83d2-c1f8f36b5e18", "United Kingdom", "8-10243168", "Rotary Club of Westcliff-On-Sea" },
                    { "6bdd7450-c448-443d-b9f3-268a0edbefcc", "United Kingdom", "8-10242434", "Rotary Club of Newhaven" },
                    { "6bde3fcc-a0d8-4dc5-8c36-2097168574dd", "United Kingdom", "8-10278634", "Rotary Club of Corby Phoenix" },
                    { "6bf541e7-b3f1-4635-b09f-3cb082b6c849", "United Kingdom", "8-10285738", "Rotary Club of Rushden Chichele" },
                    { "6bfa4ffc-0598-47d2-99e5-af6445b70982", "United Kingdom", "8-10248671", "Inner Wheel Club of Barrow-in-Furness" },
                    { "6c03fc84-2fe8-47a7-80a9-e0ec200b0841", "United Kingdom", "8-10258969", "Rotary Club of Tralee" },
                    { "6c7bfad4-17f4-4728-be97-6679062d50a1", "United Kingdom", "8-10283483", "Rotary Club of Shrewsbury Severn" },
                    { "6c83797d-84ec-4a16-a9b2-64617761a9e1", "United Kingdom", "8-10278123", "Rotary Club of Croydon" },
                    { "6cddd617-1e25-40bb-bb09-747b58e73927", "United Kingdom", "8-10281220", "Rotary Club of Chesterfield Scarsdale" },
                    { "6cf9599e-047c-4251-b6ee-69a313c95940", "United Kingdom", "8-10277738", "Rotary Club of Farnham Weyside" },
                    { "6d0e6c95-c4e5-4e34-94a4-01638dabae83", "United Kingdom", "8-10281105", "Rotary Club of Northwick Park" },
                    { "6d16a8ed-ede9-4e19-875f-d29acfadbee0", "United Kingdom", "8-10286830", "Rotary Club of Hartlepool" },
                    { "6d3b4b70-6816-4cd7-8dbc-bb626e1eac15", "United Kingdom", "8-10246936", "Rotary Club of Huntingdon Cromwell" },
                    { "6d4014bd-22a3-4cc8-9fe4-b4e8464e4c4d", "United Kingdom", "8-10286292", "Rotary Club of St. Annes-on-the-Sea" },
                    { "6d5ee335-1cd9-443b-bd33-bb6ef9850507", "United Kingdom", "8-10278815", "Rotary Club of Southgate" },
                    { "6d7105a4-ad81-424a-bdc0-c194b6e6b768", "United Kingdom", "8-10256242", "Rotary Club of Warwick Avon" },
                    { "6d7ec561-d89b-4955-b84f-5565787ce273", "United Kingdom", "8-10277061", "Rotary Club of Comber" },
                    { "6dad00cf-bf79-4b12-aa1d-00ee5188c21f", "United Kingdom", "8-10255825", "Rotary Club of Etruria" },
                    { "6dc9724c-3369-4af6-a6fc-a48b9c45763c", "United Kingdom", "8-10285780", "Rotary Club of Sturminster Newton" },
                    { "6dd3008f-60eb-4adf-a544-79f1b550adf6", "United Kingdom", "8-10279832", "Rotary Club of Bournemouth" },
                    { "6de459fb-5763-49a7-9ca2-e08604ba479a", "United Kingdom", "8-10283488", "Inner Wheel Club of Guildford" },
                    { "6dfbec91-d61f-4e79-b23e-9f51959b48ef", "United Kingdom", "8-10249454", "Interact Club of Bexley At Bexleyheath School" },
                    { "6dffd7f1-b016-4bfa-a028-57b80bf8f8ab", "United Kingdom", "8-10239487", "Inner Wheel District 24" },
                    { "6e28ea63-9282-441f-a78d-25123e080cb3", "United Kingdom", "8-10282120", "Rotary Club of Dundee" },
                    { "6e329024-0753-46f8-8a65-c04e30d3a27e", "United Kingdom", "8-10278055", "Rotary Club Of Lomond" },
                    { "6e600b3b-262c-4d53-8ad2-75f3f48d1a19", "United Kingdom", "8-10284142", "Inner Wheel Club of Appleby" },
                    { "6ed180a9-2ef6-449b-a8eb-e72b30448475", "United Kingdom", "8-10260544", "Rotary Club of Benfleet" },
                    { "6f1ef1b4-30b6-4827-8f9c-512da973943b", "United Kingdom", "8-10247945", "Rotary Club of Govan (Glasgow)" },
                    { "6f2906af-494a-444f-a792-1f8fe7c4f72c", "United Kingdom", "8-10281642", "Rotary Club of Rhyl" },
                    { "6f750772-8c03-420c-a817-4517dbf4599a", "United Kingdom", "8-10284050", "Rotary Club of Tenby" },
                    { "6faa899c-78f2-4bfa-b846-42530ac8d7f5", "United Kingdom", "8-10281203", "Rotary Club of London" },
                    { "6feac267-8722-4cab-a409-c8cf6100e17c", "United Kingdom", "8-10381280", "Rotary Club Of Exmouth" },
                    { "7005eeec-eabf-41ea-a3f1-d7e09a8fd328", "United Kingdom", "8-10250103", "Rotary District 1190" },
                    { "700bc735-333d-4c3a-9df5-08ef247e9d5f", "United Kingdom", "8-10279377", "Interact Club of Davis College Mallow" },
                    { "702a35fe-b371-4dc2-97cd-95ac6c918fb5", "United Kingdom", "8-10248746", "Rotary Club of Lurgan" },
                    { "7040d484-6c6c-4dfc-a1bb-f17d5e0f8c5d", "United Kingdom", "8-10256246", "Rotary Club of North Cotswolds" },
                    { "705e5003-9cb9-48ae-a84c-ed85346e827e", "United Kingdom", "8-10283805", "Rotary Club of Island & Royal Manor Of Portland" },
                    { "70619649-7a7a-454d-ab4b-1b354f3b95f4", "United Kingdom", "8-10279175", "Rotary Club of Wick" },
                    { "7065b224-b609-48e3-8b36-5209ae838875", "United Kingdom", "8-10279593", "Inner Wheel Club of Ferndown" },
                    { "706766ca-af24-4745-8856-64166381dc3d", "United Kingdom", "8-10240241", "Rotary Club Of Bexhill-On-Sea" },
                    { "707634f9-add6-46bf-adec-9f09160144d8", "United Kingdom", "8-10246966", "Rotary Club of Pickering" },
                    { "707f5ec1-5b5b-4295-a0cb-9a6ca9a5864f", "United Kingdom", "8-10249107", "Rotary Club of Rushcliffe" },
                    { "709037f8-6fea-4975-854c-eefd40dbd617", "United Kingdom", "8-10242787", "Rotary District 1090" },
                    { "70ade993-e466-4c61-a3ac-108874055f7a", "United Kingdom", "8-10247129", "Inner Wheel Club of Wells" },
                    { "71064c7f-f8fd-4e8d-a9e6-9a59c337ef60", "United Kingdom", "8-10256088", "Inner Wheel Club of Bedford" },
                    { "711c6541-53da-4fe4-b398-6355a94c1e8f", "United Kingdom", "8-10278282", "Rotary Club of The City of St. Asaph" },
                    { "711e0a89-d419-4fa2-9ef1-3515d02589b0", "United Kingdom", "8-10279676", "Rotary District 1070" },
                    { "71359dca-3cbb-4d0f-8901-47084c256203", "United Kingdom", "8-10260543", "Rotary Club of Brighouse" },
                    { "716f3040-a6c6-4cc0-8c63-32907239fa5c", "United Kingdom", "8-10281212", "Rotary Club of Clacton Jubilee" },
                    { "7195ff8a-a1f9-435f-93eb-50e771229d73", "United Kingdom", "8-10242869", "Rotary Club of Leeds Elmete" },
                    { "71b5bbd0-7bf5-4955-82e3-5bd9958692e7", "United Kingdom", "8-10285812", "Rotary Club of Lyme Regis" },
                    { "71c0f848-5bc9-4125-9980-a6cd3e12f1b9", "United Kingdom", "8-10243611", "Rotary Club of Midhurst & Petworth" },
                    { "71d26e91-ac15-4406-90aa-9a313496a8aa", "United Kingdom", "8-10273378", "Rotary Club of Leicester De Montfort" },
                    { "720a8b0e-34b4-4511-95e7-7f492aa5d925", "United Kingdom", "8-10283811", "Rotary Club of Shepshed Charnwood" },
                    { "7213125b-b48b-4070-832e-d32fdfd8898c", "United Kingdom", "8-10277040", "Inner Wheel Club of Faversham" },
                    { "7267736f-4023-417c-9d48-3d30e1e5d21c", "United Kingdom", "8-10282981", "Rotary Club of Dolgellau" },
                    { "7292b8ca-5fa9-4f63-8f1f-6938c798b928", "United Kingdom", "8-10286433", "Rotary Club of Oldmeldrum" },
                    { "72ac41ae-7aae-411c-9420-f557c846212d", "United Kingdom", "8-10279874", "Rotary Club of Newtownabbey" },
                    { "72be5425-5cd7-4ee0-a6fa-38d55c51789b", "United Kingdom", "8-10282713", "Rotary Club of Oldham Metro" },
                    { "72dd1bef-8351-491b-ac1a-5810cb79cee0", "United Kingdom", "8-10277995", "Inner Wheel Club of Eastern Borders" },
                    { "72e7307f-6f19-48f0-b707-fe3de6a0acf2", "United Kingdom", "8-10277732", "Inner Wheel Club of Stamford Burghley" },
                    { "72fba48c-0fbb-4931-951c-032c9327e762", "United Kingdom", "8-10242428", "Rotary Club of Blairgowrie" },
                    { "72fc4685-3de3-459e-a86d-e9c6a86a645d", "United Kingdom", "8-10280178", "Rotary Club of Bassenthwaite" },
                    { "7303fd16-0d1b-4412-9885-ba28e32575aa", "United Kingdom", "8-10286906", "Inner Wheel Club of Braunton" },
                    { "7313f512-ec09-4349-a823-1dc4d47919bb", "United Kingdom", "8-10278859", "Inner Wheel Club of St. Austell" },
                    { "731eb402-2c35-4454-9937-609edf2e0c9a", "United Kingdom", "8-10282760", "Inner Wheel Club of Bathavon" },
                    { "734e880a-b25d-477b-884e-179c367bb47b", "United Kingdom", "8-10282814", "Inner Wheel Club of Holmfirth" },
                    { "7367eefd-6834-4a91-bd23-e55f5087c4f4", "United Kingdom", "8-10279685", "Interact Club of St Andrews R C High School" },
                    { "739ebba0-ee4a-4849-ab6e-2c8bbade3afb", "United Kingdom", "8-10247294", "Inner Wheel Club of Heswall" },
                    { "73acf83c-c5a5-4ac8-b8f9-1b9db71f8dfe", "United Kingdom", "8-10331154", "The Inner Wheel Club Of Alloway" },
                    { "73c55aec-b4c3-41bd-babe-a0ce758aab35", "United Kingdom", "8-10277399", "Rotary Club of Sleaford" },
                    { "743ef2da-50c7-4174-99e0-0df9a48ed8f4", "United Kingdom", "8-10284098", "Rotary Club of Plymouth" },
                    { "7450dacb-c8fa-4798-bb90-968688d398ad", "United Kingdom", "8-10243197", "Rotary Club of Uppingham" },
                    { "7451244e-d553-4d92-8061-7388861e60f9", "United Kingdom", "8-10276705", "Rotary Club of Kinross & District" },
                    { "74b95255-503a-40bd-a983-f98a6a44cd75", "United Kingdom", "8-10278870", "Rotary Club of Blackburn" },
                    { "74d937f9-d0fd-4ad8-9dfc-ec03f498d1dd", "United Kingdom", "8-10281845", "Rotary Club of South Queensferry" },
                    { "74fba896-59b2-4b88-810a-5f4c5f1cfc17", "United Kingdom", "8-10240648", "Rotary Club of Oxford Spires" },
                    { "75110bf6-df66-41be-847d-9ec87263aabd", "United Kingdom", "8-10279421", "Rotary Club of Cambridge South" },
                    { "751470e0-e49c-42c6-87d8-a70d4f4feb49", "United Kingdom", "8-10278980", "Rotary Club of York Vikings" },
                    { "7535ff5d-d8ac-4d28-9ae1-96d5977507dc", "United Kingdom", "8-10250425", "Inner Wheel Club of Alfreton" },
                    { "75424c33-a840-4306-aeb7-869db752c4a0", "United Kingdom", "8-10286845", "Rotary Club of Chesham" },
                    { "75c6f43d-0991-48e0-b285-adbc3f9a634a", "United Kingdom", "8-10275237", "Rotary Club of Newark Castle" },
                    { "75f1d18d-449b-4de3-b658-e08bb9465f9b", "United Kingdom", "8-10280829", "Inner Wheel Club of Frodsham & Helsby" },
                    { "7627c920-75c2-4578-9c87-34a856bbaf56", "United Kingdom", "8-10283717", "Rotary Club of Romney Marsh" },
                    { "7638d81c-3916-474c-9c60-2be6ea9d5644", "United Kingdom", "8-10242432", "Rotary Club of Worcester" },
                    { "76714758-dbb2-46fe-9018-36815f4b1374", "United Kingdom", "8-10250028", "Rotary Club of Uckfield" },
                    { "76c929a8-a67d-4dc4-a61a-2ac863877670", "United Kingdom", "8-10278149", "Rotary Club of Stroud" },
                    { "76d0653f-ac16-4a55-bef5-35d2636207dc", "United Kingdom", "8-10251534", "Rotary Club of Lymington" },
                    { "76e76fd6-259f-4c08-aa5d-b6be67cb9930", "United Kingdom", "8-10284132", "Rotary Club of Wells" },
                    { "76f600ff-e927-4252-b064-2205c06ee26b", "United Kingdom", "8-10278962", "Rotary Club of Llandovery" },
                    { "7716241a-c7a7-4c8d-85c2-7fac1fb8fe32", "United Kingdom", "8-10277806", "Rotary Club of Langley & Iver" },
                    { "77329784-278d-4123-9ae4-abf415082468", "United Kingdom", "8-10284804", "Rotary Club of Hailsham" },
                    { "773c6347-11b5-4413-bc3c-9d95b92b4dbc", "United Kingdom", "8-10273344", "Rotary Club of Canvey Island" },
                    { "774b4d54-31c9-4ce2-9bab-0f4933afce5d", "United Kingdom", "8-10281279", "Rotary Club of Walsall" },
                    { "7761e4e1-875e-48b8-92de-2859b4db0996", "United Kingdom", "8-10280481", "Rotary Club of Aston" },
                    { "77972257-b0e0-4322-b509-478c39c86938", "United Kingdom", "8-10279558", "Rotary Club of Westhoughton" },
                    { "77fe1e90-ac88-42a5-8d86-88a88fad0b64", "United Kingdom", "8-10286714", "Rotary Club of Wellingborough" },
                    { "782622ac-52fc-4b30-8d5b-8e5baa935b86", "United Kingdom", "8-10278251", "Rotary Club of Builth Wells" },
                    { "782a05a0-ddad-4d6a-8c39-521fb9c4911c", "United Kingdom", "8-10243717", "Inner Wheel Club of Langport & Somerton" },
                    { "7847d28a-257e-4962-8308-787862939728", "United Kingdom", "8-10277745", "Rotary Club of Evesham" },
                    { "78487a50-5648-4b46-b4ac-b3a99f73a301", "United Kingdom", "8-10258993", "Rotary Club of Trent Bridge" },
                    { "78525094-2625-4f14-a15c-08bcd9985651", "United Kingdom", "8-10281168", "Inner Wheel Club of Gravesend" },
                    { "78594b62-67de-4e82-b916-1db0f14906fa", "United Kingdom", "8-10250027", "Rotary Club of Leatherhead" },
                    { "785bfc07-8883-4772-be5b-ed82cbea7265", "United Kingdom", "8-10285736", "Rotary Club of Uxbridge" },
                    { "788816df-50e5-414a-a4f6-a43df0837565", "United Kingdom", "8-10250032", "Rotary Club of Amble & Warkworth" },
                    { "78926f1b-37e6-430d-b0f9-0f4a0df7e859", "United Kingdom", "8-10249829", "Rotary Club of Kidderminster" },
                    { "78a213ca-056a-493f-8888-b0d55aa2bbc6", "United Kingdom", "8-10286280", "Rotary Club of Tameside" },
                    { "78c4eeb0-0e4b-4e76-a9f6-cebab95790a2", "United Kingdom", "8-10255866", "Interact Club St Edmunds School Canterbury" },
                    { "78d87273-e3c5-4b40-979c-1e36afeeffdf", "United Kingdom", "8-10250662", "Rotary Club of Greenford" },
                    { "791087b1-2d8e-4671-be8c-383770b75ad0", "United Kingdom", "8-10277426", "Rotary Club of Denbigh" },
                    { "791849c2-4396-4099-87eb-48f6c72fdc9d", "United Kingdom", "8-10284099", "Rotary Club of St. Albans-Verulamium" },
                    { "791d7f1c-606a-4167-a3e0-9800f24211e6", "United Kingdom", "8-10249830", "Inner Wheel Club Of North Fife" },
                    { "792b69c3-19e3-457a-899c-58d48c6f9ac7", "United Kingdom", "8-10357697", "Rotary Club Of Sarum" },
                    { "7948bf91-ca42-4b95-a2cc-4c8947cd155b", "United Kingdom", "8-10243441", "Interact Club Archbishop Blanch School" },
                    { "795bf99d-57b3-4036-9f74-7c708a08109d", "United Kingdom", "8-10241359", "Rotary Club of Alderney" },
                    { "795fb9c5-b8ee-4158-b364-c288e407151f", "United Kingdom", "8-10281278", "Rotary Club of Truro Boscawen" },
                    { "79707752-2116-4a4a-83a4-b8c0c5989061", "United Kingdom", "8-10281547", "Inner Wheel Club of Rutherglen" },
                    { "79f2cb94-93fd-4cf8-8f14-4175333dbfda", "United Kingdom", "8-10281505", "Inner Wheel Club of Kingston-Upon-Thames" },
                    { "79f697a8-4e13-4ea0-a8fd-734d667f9bd6", "United Kingdom", "8-10278943", "Rotary Club of Sheppey, The Isle of" },
                    { "7a18779c-c210-4085-a5d2-7c3d08acf1be", "United Kingdom", "8-10276687", "Rotary Club of Cumnock" },
                    { "7a245e0f-4bfb-4b2d-a49a-537cea020043", "United Kingdom", "8-10282785", "Rotary Club of Linlithgow Grange" },
                    { "7a3601c4-6b2b-42c7-ac64-1374be01cb6a", "United Kingdom", "8-10278067", "Rotary Club of Scunthorpe" },
                    { "7a69561d-a527-4104-a177-0defe0dc0ebd", "United Kingdom", "8-10278252", "Rotary Club of Newton Abbot" },
                    { "7a79bdb8-cfba-4eb0-86d0-08b39dfe8b4e", "United Kingdom", "8-10278403", "Rotary Club of Porthcawl" },
                    { "7aaf561e-6295-4ad1-8b00-f890a1ac4a7a", "United Kingdom", "8-10264226", "Rotary Club of Aberaeron A'R Cylch" },
                    { "7ac79105-e467-4312-a83c-81533fbba2e7", "United Kingdom", "8-10251563", "Rotary Club of Alton" },
                    { "7aca3b4e-5bcc-428e-9321-50330d358b6e", "United Kingdom", "8-10286703", "Rotary Club of Haverfordwest" },
                    { "7ae56436-cf64-4ab1-8427-84dd0fcb541d", "United Kingdom", "8-10279575", "Inner Wheel Club of Rushen & Western Mann" },
                    { "7af73f97-b3e6-436b-b543-0457a8e0ce37", "United Kingdom", "8-10246961", "Rotary Club of Turriff & District" },
                    { "7b03d0f0-d8c2-4a4a-ab41-e96eeb40a709", "United Kingdom", "8-10285895", "Rotary Club of Ilfracombe Compass" },
                    { "7b3617ec-e472-4cf9-bd7b-c3d072cc7efd", "United Kingdom", "8-10244909", "Interact Club of St Patrick's Academy Dungannon" },
                    { "7b871f88-b595-43fd-adba-32c880cbc731", "United Kingdom", "8-10278923", "Rotary Club of Loughton, Buckhurst Hill & Chigwell" },
                    { "7ba538d7-2467-495d-9caf-8608474e3858", "United Kingdom", "8-10279787", "Inner Wheel Club of Cleethorpes" },
                    { "7bf80cb8-05eb-436a-a017-e4aa66f47fe1", "United Kingdom", "8-10239482", "Rotary Club of Halstead" },
                    { "7c049d28-35c1-4bc3-9b07-ae2ab1303959", "United Kingdom", "8-10287219", "Rotary Club of Rayleigh Mill" },
                    { "7c625622-ce8a-4eb1-923d-58bf1979d668", "United Kingdom", "8-10279334", "Rotary Club of Billingshurst and District" },
                    { "7c7eec25-5ad6-4091-aeca-71c15318563a", "United Kingdom", "8-10281311", "Inner Wheel Club of Wednesbury" },
                    { "7c987f42-924c-462d-b99a-bdf6d05c35c2", "United Kingdom", "8-10286798", "Inner Wheel Club of Keswick" },
                    { "7c98ef1e-8f81-4b73-8c85-264535dfb2fb", "United Kingdom", "8-10286670", "Rotary Club of Taunton Vale" },
                    { "7cbdeb32-216f-4a66-80cd-bd37d0d20c3d", "United Kingdom", "8-10239868", "Rotary Club of Jordans & District" },
                    { "7cf1574d-0bab-432c-945a-d972730c89cc", "United Kingdom", "8-10279722", "Rotary Club of Cowes" },
                    { "7cf96bf5-4272-4bec-a88c-7957777fa596", "United Kingdom", "8-10238668", "Rotary Club of Basildon" },
                    { "7d1c169e-77a6-4704-9c59-763ee3f5d282", "United Kingdom", "8-10281047", "Rotary Club of Glasgow North & Bishopbriggs" },
                    { "7d1da5f3-ec98-4e48-9a2f-26d0c3201526", "United Kingdom", "8-10281491", "Rotary Club of Rugby Dunsmore" },
                    { "7d28f448-ffe3-482c-82de-85019fcbc3dd", "United Kingdom", "8-10239358", "Inner Wheel Club of Bolsover" },
                    { "7d3a2ab2-41f4-4d25-8263-548e4925d6f7", "United Kingdom", "8-10250876", "Rotary Club of Edenbridge and Westerham" },
                    { "7dbd3a6a-1d1c-4b76-8204-0b17c9864456", "United Kingdom", "8-10258986", "Rotary Club of City of Liverpool" },
                    { "7dfa1ce7-50fe-4db8-ade4-9141d5036123", "United Kingdom", "8-10279346", "Rotary Club of Corstorphine" },
                    { "7dfb6baa-0a75-4e5f-82ba-44067a23afb4", "United Kingdom", "8-10278188", "Rotary Club of Basildon Concord" },
                    { "7e00330c-ef6a-4dad-aa63-129fa03a08da", "United Kingdom", "8-10286796", "Rotary Club of Hunstanton & District" },
                    { "7e2083d4-0950-4140-b096-16a486bcaa6d", "United Kingdom", "8-10286281", "Rotary Club of Mid Wirral" },
                    { "7e21567a-3a41-4c7e-85ed-647eb7e2a5d8", "United Kingdom", "8-10281843", "Rotary Club of Worsley" },
                    { "7e25dc90-a59d-4cb5-ae02-4a44b40acfe4", "United Kingdom", "8-10281225", "Rotary Club of Thame and District" },
                    { "7e339537-4f34-4ed3-ba49-bf9ed7b92701", "United Kingdom", "8-10279245", "Rotary Club of Southport Links" },
                    { "7e4b5680-98cf-473d-9a1e-2023d3d4a291", "United Kingdom", "8-10283622", "Rotary Club of Monaghan" },
                    { "7e4c89bd-3ad4-4f59-a987-bd1900b1254a", "United Kingdom", "8-10279671", "Rotary Club of Wellington, Somerset" },
                    { "7e68227d-da14-4119-bf20-ccd4f94c6938", "United Kingdom", "8-10277741", "Rotary Club of Market Harborough" },
                    { "7e791045-fcbf-4ad0-a76c-96eaa3fada26", "United Kingdom", "8-10284765", "Rotary Club of Claverhouse" },
                    { "7ec056b4-667f-4577-a514-b76a7f2c3728", "United Kingdom", "8-10281534", "Rotary Club Of Potters Bar" },
                    { "7f1e34bd-1087-4db6-9237-885ff826c7f8", "United Kingdom", "8-10280102", "Rotary Club of Clitheroe" },
                    { "7f39636c-7f31-414a-92d3-cc9966244bf7", "United Kingdom", "8-10244232", "Rotary Club of Canterbury Sunrise" },
                    { "7f41471c-098b-4e32-8b60-e23d7ac8ad51", "United Kingdom", "8-10283884", "Rotary Club of Wortley" },
                    { "7f488780-a705-4aa3-8340-c1a277b16b41", "United Kingdom", "8-10285885", "Rotary Club of Gillingham, Dorset" },
                    { "7f5a1214-d6f0-4710-b502-082c4a92b90d", "United Kingdom", "8-10246935", "Rotary Club of Guildford" },
                    { "7fab0c59-5ac0-41dc-a90c-0efe359ddc15", "United Kingdom", "8-10281165", "Inner Wheel Club of Rayleigh Mill" },
                    { "7fd141d6-5bd2-42b0-aa17-878b8e52bbdc", "United Kingdom", "8-10259593", "Inner Wheel Club of Ayr" },
                    { "803bddf8-df0b-429d-ae51-7d481951dd98", "United Kingdom", "8-10277737", "Rotary Club of Broadstairs" },
                    { "80493690-d12c-4ecb-826d-e193d0627f98", "United Kingdom", "8-10250898", "Rotary Club of Brookmans Park" },
                    { "8068778e-839d-4e74-843c-f84658d186b7", "United Kingdom", "8-10283715", "Rotary Club of Crook" },
                    { "80a4de03-61ed-4816-bd6a-a1bf3393a34d", "United Kingdom", "8-10323258", "Inner Wheel Club Of Crook" },
                    { "80a954df-8572-485b-926e-828f3af54de1", "United Kingdom", "8-10279210", "Rotary Club of Spalding and Welland" },
                    { "80b9227d-cead-4b2f-88e9-4a41a84485c1", "United Kingdom", "8-10273373", "Rotary Club of Redhill Redstone" },
                    { "80c5d966-843f-478e-8618-ad513f23b607", "United Kingdom", "8-10281383", "Inner Wheel Club of Montrose" },
                    { "80c80e16-5250-4f97-b778-f6ff3bd834db", "United Kingdom", "8-10280341", "Rotary Club of Northampton" },
                    { "8154b47b-487b-4500-ab20-ed33e3b89091", "United Kingdom", "8-10285912", "Inner Wheel Club of Scarborough" },
                    { "815f5372-e405-41be-a436-7c386c00a329", "United Kingdom", "8-10283837", "Rotary Club of Ely Hereward" },
                    { "81626b8b-1b80-478e-b659-51db4bc6a709", "United Kingdom", "8-10260591", "Interact Club of Frome Community College" },
                    { "81792a88-46ae-40f4-95fb-291fa8f1f575", "United Kingdom", "8-10277364", "Rotary Club of Middlesbrough Erimus" },
                    { "8179358e-fc88-42a2-b645-91813d37f375", "United Kingdom", "8-10284727", "Inner Wheel Club of Llangollen" },
                    { "817cf1d9-fa5c-4dd4-8070-632428a2e5f9", "United Kingdom", "8-10250901", "Rotary Club of Lewes Castle" },
                    { "8188fc18-ceed-4ea2-8ebe-f4a62e0daa56", "United Kingdom", "8-10283974", "Rotary Club of Cambridge" },
                    { "81b2c8b2-523e-4bdd-a428-881241b30af7", "United Kingdom", "8-10255717", "Inner Wheel Club of Wollaton Park" },
                    { "81d9c59f-4517-40c2-98ac-44a24860655d", "United Kingdom", "8-10281263", "Inner Wheel Club of York" },
                    { "81eacc2c-83ae-4b91-a409-53c2cb797f41", "United Kingdom", "8-10280785", "Rotary Club of Eastwood" },
                    { "820ca54d-62ec-4d48-a8fb-f91eea675741", "United Kingdom", "8-10286540", "Rotary Club of Appleby" },
                    { "821a6c0b-279c-40a9-ac84-cb7fd563fc0f", "United Kingdom", "8-10242780", "Rotary Club of Campbeltown" },
                    { "822a2bd1-bbac-42dd-9681-8acd050e842b", "United Kingdom", "8-10278518", "Rotary Club of Wolverhampton" },
                    { "828bd156-bb53-444f-8130-9a74c4fc7e94", "United Kingdom", "8-10383898", "Rotary Club Of Chinnor" },
                    { "829ff184-eb3b-4e82-b61c-57ba44cfe8b9", "United Kingdom", "8-10280233", "Rotary Club of Bury St. Edmunds Abbey" },
                    { "82dbdab5-0c81-443b-9285-4e63a6952803", "United Kingdom", "8-10277559", "Rotaract Club of Dover" },
                    { "82ebeb14-8b85-4714-9ec9-3da070bb8129", "United Kingdom", "8-10285540", "Rotary Club of Crosby" },
                    { "82f8640f-fa8b-4c73-8c1b-6eb0a3522ebc", "United Kingdom", "8-10281960", "Rotary Club of Stoke-on-Trent" },
                    { "836bf73c-d5b3-461a-8f6a-ddf217a2a9f6", "United Kingdom", "8-10281463", "Rotary District 1320" },
                    { "83a0b118-011e-4b65-8800-ee797367fc8a", "United Kingdom", "8-10277123", "Interact Club of Castle Community Coll" },
                    { "83c66b95-c7a2-4bf6-91c3-903799436531", "United Kingdom", "8-10239009", "Rotary Club of Great Harwood & Rishton" },
                    { "83d5abeb-7e16-4e2e-9fc8-251c5e832708", "United Kingdom", "8-10279015", "Inner Wheel Club of Basingstoke Deane" },
                    { "83dbc3aa-923b-49dc-902a-7c419f8c5383", "United Kingdom", "8-10278153", "Interact Club of Kennet School" },
                    { "83e0d399-1c61-474d-9f6b-70ca06c1176f", "United Kingdom", "8-10283706", "Rotary Club Of Annan And District" },
                    { "83e8c8e5-35c9-4353-bfb4-37e82d01da2b", "United Kingdom", "8-10285542", "Rotary Club of Dunstable" },
                    { "83f7f87b-cc27-43ea-9d0c-bc1220ae7366", "United Kingdom", "8-10284121", "Rotary Club of Bebington" },
                    { "84051aec-19be-452a-b0ed-9b0a147d2f73", "United Kingdom", "8-10283081", "Rotary Club of Flint & Holywell" },
                    { "84b0bacf-176a-473f-a0a8-e01ed7333885", "United Kingdom", "8-10258979", "Rotary Club of Kettering" },
                    { "84bdbeb7-0662-418d-98f7-130c2e519f31", "United Kingdom", "8-10276580", "Rotary Club of Etwall & Hilton" },
                    { "84d22f15-c9c6-45d3-9a54-af945b31ddf6", "United Kingdom", "8-10244594", "Rotary Club of Redditch" },
                    { "85016b36-d3f4-47dc-85c2-7ee5fe895bd5", "United Kingdom", "8-10280070", "Rotary Club of Norwich Centenary" },
                    { "8549e462-6f8a-4064-9f9f-a3a5733c9783", "United Kingdom", "8-10265169", "Inner Wheel Club of Alton" },
                    { "855bc56c-32cf-4560-b270-21b15d527c78", "United Kingdom", "8-10281157", "Rotary Club of Tunbridge Wells" },
                    { "85614743-2f0b-47fc-ba40-002700894cad", "United Kingdom", "8-10241231", "Inner Wheel Club of Gillingham (Kent)" },
                    { "8573258e-9f0e-4d49-b5c3-33a31a35b8bf", "United Kingdom", "8-10279854", "Rotary Club of March" },
                    { "859490e7-76c7-413d-be3b-4ff45ca3e60b", "United Kingdom", "8-10278159", "Rotary Club of Basingstoke" },
                    { "85a402f0-9d6f-433a-941b-a8d893c97fb3", "United Kingdom", "8-10238325", "Rotary Club of Eyemouth & District" },
                    { "85a8e18e-5819-4c79-baa1-f66dfedd84c6", "United Kingdom", "8-10277031", "Inner Wheel Club of Tywyn" },
                    { "85b02163-53b4-4a56-9058-81a48f65ed3b", "United Kingdom", "8-10280820", "Rotary Club of Totnes" },
                    { "85b2d4ad-32c1-4652-92db-e9e7aeeae307", "United Kingdom", "8-10249182", "Rotary Club of Hull" },
                    { "85b584fa-aec9-4a65-b4a4-7651c32373db", "United Kingdom", "8-10280013", "Interact Club of Llanidloes" },
                    { "85b593bf-14c1-47cd-a964-0367478ee89d", "United Kingdom", "8-10242743", "Rotary Club of Manchester" },
                    { "85d25207-ba45-446b-8ade-9cacf95130b9", "United Kingdom", "8-10280298", "Rotary Club of Matlock" },
                    { "85e338c7-bc84-424d-a913-3b4b57eb416a", "United Kingdom", "8-10281283", "Inner Wheel Club of Colchester Forum" },
                    { "85f1dcf8-97fb-486f-8127-ad1464ab0156", "United Kingdom", "8-10281081", "Rotary Club of Walsall Saddlers" },
                    { "85ffa178-1259-4c0d-ae76-c6a1fb56d694", "United Kingdom", "8-10250881", "Rotary Club of Westminster West" },
                    { "86244ed5-85f7-4d92-bb51-ed19eba7fc3a", "United Kingdom", "8-10247281", "Rotary Club of Douglas, IOM" },
                    { "86c6721f-a17b-4183-bf61-595f427affd1", "United Kingdom", "8-10278003", "Rotary Club of Larbert" },
                    { "8705d2e1-988b-4b6a-996e-a13125c97620", "United Kingdom", "8-10244739", "Rotary Club of Ellesmere Port, Wirral" },
                    { "8759d867-ba24-4bc8-87f7-618bfc67352d", "United Kingdom", "8-10279573", "Inner Wheel Club of Atherstone" },
                    { "8790f47d-842a-456c-b209-541ca4fde397", "United Kingdom", "8-10249808", "Rotary Club of St. Neots St. Marys" },
                    { "87a108c0-9e02-4c81-8969-ee30caa175fa", "United Kingdom", "8-10286677", "Rotary Club of Corby" },
                    { "87a6dff5-56f3-4f34-8220-672f39c43d2f", "United Kingdom", "8-10243664", "Inner Wheel Club of Durham" },
                    { "87a82512-049d-4215-953b-be8725ac39c8", "United Kingdom", "8-10287147", "Rotary Club of Barnsley" },
                    { "87be2551-e587-486f-b76a-9d354ff43a76", "United Kingdom", "8-10286445", "Rotary Club of Hornsea & East Riding" },
                    { "8804303a-d24d-492b-8fed-e6c55d30ad05", "United Kingdom", "8-10279739", "Rotary Club of Burgess Hill & District" },
                    { "88092189-d7ed-44e2-b79d-7ecc0b8fb331", "United Kingdom", "8-10283653", "Rotary Club of Youghal" },
                    { "880a6e55-0f1c-49c6-ada0-46127d320a87", "United Kingdom", "8-10247701", "Rotary Club Of St Albans Priory" },
                    { "8850f205-d8e8-42dc-9e87-03f38fa8a923", "United Kingdom", "8-10281896", "Inner Wheel Club of Kettering Huxloe" },
                    { "8864028f-5c57-48e8-8e3a-dcea93590bc7", "United Kingdom", "8-10282373", "Rotary Club of Stourbridge" },
                    { "8874fdd1-de57-4afa-8624-106907d042ed", "United Kingdom", "8-10252063", "Rotary Club of Abergele" },
                    { "888d1b75-d1a9-4c58-8620-b819954058ae", "United Kingdom", "8-10287014", "Inner Wheel Club of Hinckley Ambion" },
                    { "8895b756-0a6a-469e-aa59-34bc9cafa616", "United Kingdom", "8-10243490", "Interact Club of Wilmington Grammar School For Boys" },
                    { "88983746-1092-4628-9a3e-c2adc7e1b50a", "United Kingdom", "8-10263928", "Inner Wheel Club of Coleshill" },
                    { "88b22ca6-b371-412a-9a90-ba93ae7efc09", "United Kingdom", "8-10278381", "Rotary Club of Cardiff Bay" },
                    { "89101a6b-8d79-4cf9-a785-60829933535a", "United Kingdom", "8-10247138", "Inner Wheel Club of Humberside" },
                    { "89b948fd-ccc5-448d-8d23-157ae0702296", "United Kingdom", "8-10280680", "Rotary Club of Cumbernauld" },
                    { "89c0efd8-387a-4098-8484-08a78e6dda29", "United Kingdom", "8-10251562", "Rotary Club of Sidcup" },
                    { "89c66114-0977-4c4a-b43a-e0504a78cf34", "United Kingdom", "8-10284118", "Rotary Club of Lincoln Colonia" },
                    { "8a00213d-c364-4fe9-8c34-b8e68263c2e5", "United Kingdom", "8-10264093", "Upottery Village" },
                    { "8a2275e6-ee94-4f17-aa6c-9f8998bd08a2", "United Kingdom", "8-10256365", "Rotary Club of Easthampstead" },
                    { "8a4ab805-5913-4593-b16d-e143fb451966", "United Kingdom", "8-10241439", "Rotary Club of Bangor Co. Down" },
                    { "8a6a4c47-eda5-49b9-b61e-158e7441c4cb", "United Kingdom", "8-10279817", "Rotary Club of Stafford Castle" },
                    { "8a761d59-15cc-47ad-9e88-220711fee7fb", "United Kingdom", "8-10368036", "Rotary Club of Cuckfield Lindfield and Haywards Heath" },
                    { "8a7b0609-f226-4e09-9dfc-ba63ffcfec2a", "United Kingdom", "8-10250917", "Inner Wheel Club of Seaford" },
                    { "8a84023a-12dd-419c-8e2d-6f521f190e11", "United Kingdom", "8-10285952", "Rotary Club of Whiteley" },
                    { "8a9b7870-273b-4fd4-a561-217e9092b214", "United Kingdom", "8-10281068", "Rotary Club of Killarney" },
                    { "8ab82a78-bd8d-49f8-8aae-040ef3d456fa", "United Kingdom", "8-10280730", "Rotary Club of Lockerbie and District" },
                    { "8ac34fae-385a-4cbf-a7d3-8fb9efe4637a", "United Kingdom", "8-10278893", "Rotary Club of Hawick" },
                    { "8ae59605-9327-4794-9341-b34d320523f3", "United Kingdom", "8-10249441", "Inner Wheel Club of Dursley" },
                    { "8b336435-cab1-4e1e-bae2-929b39850cc1", "United Kingdom", "8-10278434", "Rotary Club of Kilkenny" },
                    { "8b5e1d1b-9bb9-4b79-81ca-1911071e5a4d", "United Kingdom", "8-10260566", "Rotary Club of Chesterfield" },
                    { "8b6f1eb0-52c8-484f-a82e-3bad0bbf0199", "United Kingdom", "8-10283709", "Rotary Club of Inverkeithing & Dalgety Bay" },
                    { "8b93136f-5bbb-419b-a636-0105d079e9dd", "United Kingdom", "8-10278522", "Rotary Club of Bingley" },
                    { "8bcfdc05-d5f7-4939-811e-b077bfd45a69", "United Kingdom", "8-10239146", "Rotary Club of Becton and District" },
                    { "8bef99ea-7a9a-4af3-bd37-571ff1fc777d", "United Kingdom", "8-10286419", "Rotary Club of Cookstown" },
                    { "8bf619e9-8204-43f9-8e29-7e3353f7f9dc", "United Kingdom", "8-10281308", "Rotary Club of Locks Heath" },
                    { "8c27bf4f-7015-4da2-aab6-dd15985e02be", "United Kingdom", "8-10280729", "Rotary Club of Ipswich East" },
                    { "8c293b95-431b-4b90-9610-d5494e83dcf0", "United Kingdom", "8-10239877", "Inner Wheel Club of Porthcawl" },
                    { "8c3ae15e-5caa-415d-90de-94a791b0a928", "United Kingdom", "8-10280685", "Inner Wheel Club of Gosport" },
                    { "8c49f7fc-13b7-4c20-b683-4e7f97ad9053", "United Kingdom", "8-10286920", "Inner Wheel Club of Wokingham" },
                    { "8c502019-e150-42f4-8305-5f39937608cf", "United Kingdom", "8-10282938", "Rotary Club of Rochford" },
                    { "8c52c610-4bb4-45a0-9329-1d0a88319aee", "United Kingdom", "8-10282960", "Rotary Club of Carnforth" },
                    { "8c5695ae-fe48-4973-8a19-7620531adce7", "United Kingdom", "8-10281639", "Inner Wheel Club of Barnstaple" },
                    { "8c9f94e7-dd24-4134-8cf5-c5b7611ba236", "United Kingdom", "8-10278922", "Rotary Club of Littleport" },
                    { "8ca2504a-a554-4612-9571-be930ec742da", "United Kingdom", "8-10287003", "Rotary Club of Spey Valley" },
                    { "8cad7133-14b5-43e1-97d2-898a6d0bd8c3", "United Kingdom", "8-10250073", "Rotary Club of Andover Anton" },
                    { "8cc4f4ce-42a3-4e14-a3d0-ad410c9d39c9", "United Kingdom", "8-10278144", "Rotary Club of Otter Valley" },
                    { "8cd30713-8051-447c-b8f6-207f27da8529", "United Kingdom", "8-10283701", "Rotary Club of Brandon & District" },
                    { "8d06f48a-5004-4e32-9d17-6cbb90dfdf86", "United Kingdom", "8-10285575", "Rotary Club of Swindon Old Town" },
                    { "8d33833c-9855-46b1-846f-bf455d44271b", "United Kingdom", "8-10250025", "Rotary Club of Beeston" },
                    { "8d39292f-2edb-406e-981e-1b23564cf6a4", "United Kingdom", "8-10276572", "Inner Wheel Club of Knutsford" },
                    { "8d4c61ef-886d-459d-8b41-ba58db75f47d", "United Kingdom", "8-10285829", "Inner Wheel Club of District 17 Overseas Zone Rally" },
                    { "8e0ae00c-f088-4398-bdd8-2111e7edc581", "United Kingdom", "8-10285701", "Rotary Club of Langport & Somerton" },
                    { "8e661d43-a207-4c40-9d7a-66e34731b32e", "United Kingdom", "8-10278474", "Inner Wheel Club of Anstruther" },
                    { "8e763fcb-fd06-4c05-8242-858f4b3f7d4e", "United Kingdom", "8-10280237", "Rotary Club of Hendon" },
                    { "8e8fd02d-447f-4a35-98a8-847f6c2c05fb", "United Kingdom", "8-10282784", "Rotary Club of Leighton Linslade" },
                    { "8e9ca9be-2411-442d-a968-25dc7dff887e", "United Kingdom", "8-10243207", "Rotary Club of Radlett" },
                    { "8ec8492c-ef6d-4aca-91d2-5ff259eb636f", "United Kingdom", "8-10285940", "Rotary Club of Berkhamsted Bulbourne" },
                    { "8ee64b1c-030a-46b7-982c-ed304fb0d776", "United Kingdom", "8-10283703", "Rotary Club of Grangemouth" },
                    { "8f05eb59-19d3-4997-b531-b7478fd4d51b", "United Kingdom", "8-10360556", "Rotary Club Of Moors Gateway" },
                    { "8f274448-920e-49bd-886d-4f7821c0607e", "United Kingdom", "8-10279315", "Rotary Club of Redcar" },
                    { "8f328783-d152-4296-a695-b41ede28a275", "United Kingdom", "8-10286369", "Rotary Club of Hatherleigh" },
                    { "8f794519-1cc3-46ef-a895-83d79e5862ad", "United Kingdom", "8-10285826", "Rotary Club of Machynlleth" },
                    { "8f92deea-9bc8-4c50-b45e-be37eddd59fb", "United Kingdom", "8-10278545", "Rotary Club of Titsey & District" },
                    { "8fb9e0e3-1f42-431f-a5cf-3624c64419b6", "United Kingdom", "8-10281050", "Rotary Club of Kings Hill Kent" },
                    { "8fd2fe18-6d39-450c-a92f-ebd04068e0ad", "United Kingdom", "8-10280401", "Rotary Club of Leeds" },
                    { "8fddb93f-d615-4a55-aa38-650c3edb2de4", "United Kingdom", "8-10285941", "Rotary Club of Billericay Mayflower" },
                    { "8fe11a70-04bc-4ca3-9b87-c3a674647b6d", "United Kingdom", "8-10276726", "Inner Wheel Club of Harpenden" },
                    { "8ff65797-383f-4437-b079-8878afde5041", "United Kingdom", "8-10238433", "Inner Wheel Club of Bacup" },
                    { "901e1d48-86f3-4a85-ba8f-e9df0fe1937a", "United Kingdom", "8-10241638", "Rotary Club of Cramlington" },
                    { "907b2ce4-616b-47d0-90ab-1074ec9a712d", "United Kingdom", "8-10278413", "Rotary Club of Grimsby" },
                    { "9087582f-21ba-42e9-8081-055e848b4bb0", "United Kingdom", "8-10282116", "Rotary Club of Bradford Bronte" },
                    { "90881ff4-8ad9-45c4-9f7f-286492fea7dd", "United Kingdom", "8-10242758", "Rotary Club of Richmond, Surrey" },
                    { "908cbce3-6a44-4ea2-80db-6123a6f127c0", "United Kingdom", "8-10284085", "Rotary Club of Deal" },
                    { "90a77529-43a7-45e9-b4f9-690bf373e088", "United Kingdom", "8-10284699", "Rotary Club of Medway" },
                    { "90b81130-a0bc-45a9-a340-0b931eb698e3", "United Kingdom", "8-10286973", "Rotary Club of Brentwood" },
                    { "90d69fc6-0603-4414-b843-bd8d3bfa7232", "United Kingdom", "8-10239513", "Rotary Club of Aberdeen St. Machar" },
                    { "90fc1a9a-7fed-4029-95c5-28e13c0d1efc", "United Kingdom", "8-10254458", "Bosham Bridge Monday Evening" },
                    { "914dd14d-1bdc-45b6-87d1-690838367c71", "United Kingdom", "8-10256283", "Rotary Club of Saddleworth, W. Yorks." },
                    { "916103e0-65fd-4e17-b074-164643a25928", "United Kingdom", "8-10241432", "Inner Wheel Club of Weybridge & Byfleet" },
                    { "9171d7fd-21eb-4e86-bffe-dc5a1e2895bc", "United Kingdom", "8-10278473", "Rotary Club of Londonderry" },
                    { "9175d5cf-2863-4ca5-8a39-e36eb8fc386e", "United Kingdom", "8-10248145", "Rotary Club of Guildford District" },
                    { "91841af7-797f-4b5e-adfd-d804cbac3f61", "United Kingdom", "8-10279393", "Inner Wheel Club of Horwich" },
                    { "91a9f6e5-3f06-4e5b-ad39-9b267175b851", "United Kingdom", "8-10238627", "Rotary Club of Ponteland" },
                    { "91b8e8b6-5255-4b2f-8d3a-c70675b7eb78", "United Kingdom", "8-10279594", "Rotary Club of Torbay Sunrise" },
                    { "91bcad0f-a6d1-43f3-9a64-f39038939353", "United Kingdom", "8-10283744", "Inner Wheel District 16" },
                    { "91e04afd-d694-4672-9c6c-d6a12bb90ea0", "United Kingdom", "8-10244230", "Inner Wheel Club of Armagh" },
                    { "9269f4b3-0b67-4556-913e-d31342c457d0", "United Kingdom", "8-10279162", "Inner Wheel Club of Chipping Sodbury" },
                    { "927420f7-a2fc-4b5b-afd0-61f85855eb1c", "United Kingdom", "8-10249445", "Rotary Club of Portlethen & District" },
                    { "92762d1f-d92d-44b4-a42f-716359d405db", "United Kingdom", "8-10283880", "Rotary Club of Washington Forge" },
                    { "92c17309-f525-4b0a-9bc3-ea4e9b80612d", "United Kingdom", "8-10286489", "Inner Wheel District 1" },
                    { "92f229c8-3fb5-408b-ba7d-0ee388d5a10e", "United Kingdom", "8-10256364", "Inner Wheel Club of Newquay" },
                    { "935ed992-801b-4b43-9de7-8a0782d11a7c", "United Kingdom", "8-10286498", "Rotary Club of Bradford on Avon" },
                    { "9366fbf9-1f31-40c2-bf4e-0b85d1e47753", "United Kingdom", "8-10281366", "Inner Wheel Club of Wellington (Somerset)" },
                    { "94002574-90f8-47ad-adb3-7c719fa322a2", "United Kingdom", "8-10286417", "Rotary Club of Farnham" },
                    { "9409c247-5c5f-478a-83c6-af4e39f6329e", "United Kingdom", "8-10279831", "Rotary Club of Bewdley" },
                    { "9430537d-e5c9-4d60-9f10-f3a8c197dd63", "United Kingdom", "8-10252071", "Rotary Club of St. Woolos Newport" },
                    { "944d41d0-3bd9-43f0-b2f2-c715c3e3e78d", "United Kingdom", "8-10283798", "Inner Wheel Club of Buxton" },
                    { "9472dc88-1a6d-4dce-b96e-4ff49ed4804f", "United Kingdom", "8-10276729", "Rotary Club of Tenterden" },
                    { "948b7f0c-9e25-419f-a078-d771a045aefa", "United Kingdom", "8-10286915", "Rotary Club of Newent & District" },
                    { "94b7ab41-2df9-4585-a2dd-77de9606672a", "United Kingdom", "8-10283623", "Inner Wheel Club of New Malden" },
                    { "94c1ba88-b63e-4055-8a10-78a4360773b1", "United Kingdom", "8-10241410", "Rotary Club of Camberley" },
                    { "94dfe016-23d4-4524-9717-0044ce8c85ce", "United Kingdom", "8-10280554", "Rotary Club of Dartmouth" },
                    { "95077bff-de1a-4f02-9d2b-eecef7deeb2a", "United Kingdom", "8-10281643", "Rotary Club of Braunton Caen" },
                    { "954955fe-2c08-4a22-abf4-cb0fffb3fb94", "United Kingdom", "8-10239876", "Rotary Club of Dunbar" },
                    { "9562f432-ff81-44e7-8b58-ea39c7aa3873", "United Kingdom", "8-10285788", "Rotary Club of Weighton Wolds" },
                    { "95704f16-9c69-41a9-9d11-1057395af15a", "United Kingdom", "8-10249562", "Rotary Club of Prestwick" },
                    { "957dfe2d-1eb4-48f0-bd16-940851cf6a9e", "United Kingdom", "8-10249133", "Rotary Club of Flitwick Vale" },
                    { "959ff4e8-4a0f-4721-bae9-860d2a247d07", "United Kingdom", "8-10285959", "Rotary Club of Irvine Seagate" },
                    { "95a64f44-52a6-4941-9e48-a54593f65b63", "United Kingdom", "8-10285548", "Rotary Club of Huntly" },
                    { "95d24ce2-6f6a-41bf-830e-ff950118cd9f", "United Kingdom", "8-10242676", "Inner Wheel Club of Southgate" },
                    { "95f868bc-ddcf-449c-a6d3-7a864a85dd95", "United Kingdom", "8-10280180", "Rotary Club of Hertford" },
                    { "960b12a9-e081-44e2-bba4-cccc4f7f93de", "United Kingdom", "8-10279174", "Rotary Club of St. Leonards-on-Sea" },
                    { "9611da4a-80eb-474f-ab54-ad01f413403d", "United Kingdom", "8-10276690", "Rotary Club of Heswall, Wirral" },
                    { "9612c3e0-ad88-43a8-a95e-3bfb177f74b0", "United Kingdom", "8-10281742", "Rotary Club of Swindon" },
                    { "965ee575-3558-4b19-bc32-cc631b947905", "United Kingdom", "8-10281042", "Rotary Club of Belfast East" },
                    { "96bc401c-6b18-4c9d-b482-15b6bc13ae39", "United Kingdom", "8-10242742", "Rotary Club Of Dunmow" },
                    { "96dbcb92-23f8-4e78-a144-be43767df73c", "United Kingdom", "8-10238998", "Rotary Club of Banbury" },
                    { "970176d5-78a6-4db8-afeb-9f9689325780", "United Kingdom", "8-10282937", "Rotary District 1100" },
                    { "972759bc-5ca0-48c8-be16-d12c6d1eb740", "United Kingdom", "8-10282671", "Rotary Club of Sawbridgeworth & District" },
                    { "97313118-0025-49cf-9f08-0a3895c176ac", "United Kingdom", "8-10264269", "Rotary Club of Lancaster Loyne" },
                    { "9792794f-43c9-401b-a507-3e9e1cc1e7a2", "United Kingdom", "8-10283505", "Rotary Club of Eynsham" },
                    { "98060c08-9066-426d-8e4f-271e305b5bec", "United Kingdom", "8-10280727", "Rotary Club of Carlton" },
                    { "981a8fc1-5c6e-409a-a20c-76bb3c0e0c22", "United Kingdom", "8-10244324", "Interact Club of Hockerill Anglo-European College" },
                    { "9829d4f6-c052-46ee-bb0e-55f7e3c25479", "United Kingdom", "8-10283509", "Rotary Club of Islington, Highgate and Muswell Hill" },
                    { "98453ab5-9c53-45c9-a05d-ade5606253e3", "United Kingdom", "8-10280746", "Inner Wheel Club of Burnham" },
                    { "98b62911-2e40-4b5e-893d-aec138248179", "United Kingdom", "8-10277981", "Inner Wheel Club of Roborough" },
                    { "98f1c4e3-b742-4b38-9642-d24925705d6e", "United Kingdom", "8-10279695", "Rotary Club of Burnham Beeches" },
                    { "990e998a-9b36-487a-bfbe-897a4b442ade", "United Kingdom", "8-10287090", "Rotary Club of Altrincham" },
                    { "991e3235-d2cf-49fc-b30b-ca1ec03d5738", "United Kingdom", "8-10249571", "Rotary Club of Nuneaton" },
                    { "994109c8-759a-4cb3-83d1-303e709579cf", "United Kingdom", "8-10279237", "Inner Wheel Club of Wolverhampton" },
                    { "9966d775-a6f0-4832-9406-3fadfb13d213", "United Kingdom", "8-10285901", "Rotary Club of Bedford Park" },
                    { "996e00dc-bd67-404b-8d8e-d8ce009f0b36", "United Kingdom", "8-10281245", "Rotary Club of Ross-On-Wye" },
                    { "9983687d-6366-4da8-8076-b95f6f24c5e1", "United Kingdom", "8-10282691", "Rotary Club of Fordingbridge" },
                    { "99ae43e9-700e-4c7f-9085-db682b7c39bf", "United Kingdom", "8-10242779", "Rotary Club of Beaconsfield" },
                    { "99b510a1-0ec7-4fb7-aef8-cc747d629823", "United Kingdom", "8-10280602", "Rotary Club Of Helston Cober Valley" },
                    { "99f2ac42-a6a7-4693-a403-5f27bfa76b98", "United Kingdom", "8-10283853", "Rotary Club of Baldock" },
                    { "99f8d4fe-804c-4203-8620-10ea0abba0b2", "United Kingdom", "8-10285976", "Rotary Club of Ruthin" },
                    { "9a11ff57-2f88-4b3b-93f4-86e9052789d4", "United Kingdom", "8-10284750", "Inner Wheel Club of Windermere" },
                    { "9a1478d5-0edd-4425-a1a8-bb3820c30917", "United Kingdom", "8-10247288", "Inner Wheel Club of Lymm" },
                    { "9a740bda-8a5b-4350-aa89-5aec7891002b", "United Kingdom", "8-10257193", "Rotary Club of Rushden" },
                    { "9a7da55c-4b50-43ab-88ea-8449ec198250", "United Kingdom", "8-10286271", "Rotary Club of Maidstone Riverside" },
                    { "9a913f05-2c11-497c-9965-2479b03a6a06", "United Kingdom", "8-10277742", "Inner Wheel Club of Midsomer Norton & Radstock" },
                    { "9aa3d69e-9aea-400c-bb23-57fd95909ad8", "United Kingdom", "8-10250372", "Rotary Club of Wetherby & District" },
                    { "9acfdad5-39a7-42fc-824e-db69ce5ae2f4", "United Kingdom", "8-10279308", "Inner Wheel District 12" },
                    { "9b5155ad-4088-4a9b-95f1-1f7f6cb9b093", "United Kingdom", "8-10273380", "Rotary Club of Aylsham" },
                    { "9b53318c-fcb1-453c-a049-6ce08f8401af", "United Kingdom", "8-10282347", "Rotary Club of Belper and Duffield" },
                    { "9b57dae5-e9e4-41f6-9599-e5a39bde25b1", "United Kingdom", "8-10239638", "Rotary Club of Forres" },
                    { "9b69601d-d687-43a4-8103-6f82e4bb79b2", "United Kingdom", "8-10280588", "Inner Wheel Club of Midhurst & Petworth" },
                    { "9b8d28eb-43e5-4b38-bb9c-af970464a2be", "United Kingdom", "8-10279403", "Rotary Club of Galway-Salthill" },
                    { "9ba34e0a-a1fa-4114-ab9b-894ce74fa6fc", "United Kingdom", "8-10281503", "Rotary Club of Melton Mowbray Belvoir" },
                    { "9ba842cb-9d11-43d3-8128-3dfc9fb2a3c9", "United Kingdom", "8-10249573", "Inner Wheel District 26" },
                    { "9baf0c1b-7417-4f0a-897a-94053e9c27dc", "United Kingdom", "8-10244334", "Rotary Club of Mill Hill" },
                    { "9bb374a4-eec0-4819-bc05-e4c0b288fb1e", "United Kingdom", "8-10255089", "Inner Wheel Club Of North Wirral" },
                    { "9be5883e-ecd0-4d5e-8f89-88af04314e72", "United Kingdom", "8-10279699", "Rotary Club of Littlehampton" },
                    { "9be83dda-4abd-42c8-a35e-630c0f7d8d83", "United Kingdom", "8-10247128", "Rotaract Club of Chichester" },
                    { "9bf024e2-7c4c-489b-a06f-8b072e5a1a29", "United Kingdom", "8-10241435", "Rotary Club of East Grinstead Meridian" },
                    { "9c2aec1a-6e6b-4ce5-8d98-c244e9d3a74b", "United Kingdom", "8-10239018", "Rotary Club of Melcombe Regis" },
                    { "9c390483-e115-445b-bddd-7341ef597e9a", "United Kingdom", "8-10270509", "Interact Club of Oldershaw Academy" },
                    { "9c3b86e1-7f57-4012-9448-38e8711ea7c8", "United Kingdom", "8-10257164", "Rotary Club of Rochester" },
                    { "9c6325f9-b906-4fb6-b991-516b93ee9ba5", "United Kingdom", "8-10278503", "Inner Wheel Club of Basingstoke" },
                    { "9c704352-b8a0-49b8-8c87-20b05bde2f6f", "United Kingdom", "8-10280236", "Inner Wheel Club of Otley Chevin" },
                    { "9c748a4d-3c51-4786-92fa-cdf1d7bd7c88", "United Kingdom", "8-10278498", "Rotary Club of Barking" },
                    { "9c85554e-5958-4eda-858d-dc59e3b3b1ed", "United Kingdom", "8-10249313", "Rotary Club of Bude" },
                    { "9c9da46e-26e5-40bf-a404-245d9bdc57c5", "United Kingdom", "8-10281805", "Rotary Club of Abingdon" },
                    { "9cb22cfe-8990-4555-9a89-b6fa726dc7d3", "United Kingdom", "8-10240283", "Rotary Club of Windsor & Eton" },
                    { "9cb86ecb-e20a-405d-9f71-cde8273c719f", "United Kingdom", "8-10280625", "Inner Wheel Club of Wadebridge" },
                    { "9cbc5134-0ca5-4bdd-8cec-ba1b4bfd7566", "United Kingdom", "8-10282350", "Rotary Club of Frinton-On-Sea" },
                    { "9cc65640-1d45-4baa-ad8a-69dfc07c4ed6", "United Kingdom", "8-10281377", "Rotary Club of Troon" },
                    { "9d02e00d-d3c2-40fd-ab45-fbab6ccc20a7", "United Kingdom", "8-10279076", "Rotary Club of Aberfeldy & District" },
                    { "9d0417e2-3e2d-43b2-b8f3-ba09991bb2e8", "United Kingdom", "8-10250660", "Rotary E-Club of Aviation" },
                    { "9d0c8ade-e057-4356-9e8d-66c5c34ffb14", "United Kingdom", "8-10242266", "Rotary Club of East Kilbride" },
                    { "9d4dc71c-7de8-47a7-ae48-ad33f0f4b205", "United Kingdom", "8-10277357", "Rotary Club of Mar Dyke Valley" },
                    { "9dc6ed82-efdc-47ed-88d8-8b5bb8cb0b4e", "United Kingdom", "8-10285820", "Rotary Club of Yelverton" },
                    { "9dcbdbae-4add-416e-928e-524445264f35", "United Kingdom", "8-10279775", "Rotary Club of Swanage & Purbeck" },
                    { "9de4785e-7329-40f6-ba98-94aa50e707f9", "United Kingdom", "8-10239773", "Rotary Club of Erdington" },
                    { "9de9ad2c-76ca-4e0d-949c-9c8562aae07d", "United Kingdom", "8-10277307", "Rotary Club of Plympton" },
                    { "9e61fefe-db34-468e-8290-be545e027999", "United Kingdom", "8-10281135", "Rotary Club of Blackburn & District" },
                    { "9e7e173f-991e-45dc-8050-bfd2532811b1", "United Kingdom", "8-10281450", "Rotary Club of Lytham" },
                    { "9e88039b-00f1-4cdf-a611-8b6fb63de0fa", "United Kingdom", "8-10278909", "Inner Wheel Club of Kettering" },
                    { "9ee6f6a3-a035-45cf-9a26-7be31706b37b", "United Kingdom", "8-10242698", "Inner Wheel Club of Newton Aycliffe" },
                    { "9f5d212f-39bc-45e4-8560-faa334fbe4c4", "United Kingdom", "8-10282694", "Rotary Club of Kings Lynn Trinity" },
                    { "9f8e7a5e-ef29-4dc6-95ad-4a5eb673f603", "United Kingdom", "8-10281153", "Inner Wheel Club of Wantage" },
                    { "9f9f7bc8-0079-4ce4-a8c1-0048f7e8421c", "United Kingdom", "8-10248891", "Rotary Club of Folkestone Channel" },
                    { "9fbe41f3-10d4-41b1-b7c5-0a3d3096c43e", "United Kingdom", "8-10286940", "Inner Wheel Club of Bude" },
                    { "9fdd136a-6b6e-4798-b800-bbbf4ac0c0d1", "United Kingdom", "8-10255833", "Rotary Club of Lancaster" },
                    { "a00e1bb6-8e66-4935-be3a-5c559947075d", "United Kingdom", "8-10259924", "Rotary Club of Chatham" },
                    { "a0407f61-1469-4c5f-a2d0-1762ecce10b3", "United Kingdom", "8-10239667", "Inner Wheel Club of Billericay" },
                    { "a085e987-0849-4381-aa8c-81961f79a4b1", "United Kingdom", "8-10280536", "Rotary Club of Cleveland" },
                    { "a0b9cee4-135f-44b0-94c4-677f91bec03b", "United Kingdom", "8-10258977", "Rotary Club of Ivybridge" },
                    { "a0e94a47-cc5d-412b-9852-1aff5095232c", "United Kingdom", "8-10246965", "Inner Wheel Club of Newtownards" },
                    { "a0f36c79-71ca-4f9c-9042-4979287b6858", "United Kingdom", "8-10284091", "Rotary Club of Hadleigh Castle" },
                    { "a102eb29-8332-426d-ad0a-726508ec1a28", "United Kingdom", "8-10287098", "Rotary Club of Preston" },
                    { "a10ffef6-f727-4bc6-91b2-4b87811c768e", "United Kingdom", "8-10244231", "Rotary Club of Cricklade & District" },
                    { "a1207a34-a3ed-492f-b118-96edea039108", "United Kingdom", "8-10277350", "Rotary Club of Hereford Wye Valley" },
                    { "a12e1f4e-4567-476e-94e8-a4b45bec5868", "United Kingdom", "8-10277750", "Rotary Club of Croydon Jubilee" },
                    { "a13d4831-3d58-40d6-8601-c5d79d9cab31", "United Kingdom", "8-10240902", "Inner Wheel Club of Padiham" },
                    { "a1405bc4-787d-4cf7-bfda-d72c096ad3d8", "United Kingdom", "8-10249565", "Inner Wheel Club of Mumbles" },
                    { "a158f8d4-c824-4c6a-a22d-490da59d1108", "United Kingdom", "8-10241657", "Interact Club of Darrick Wood" },
                    { "a1706275-3a70-4d39-8ae3-1ab95cb0ab14", "United Kingdom", "8-10281797", "Rotary Club of Headingley (Leeds)" },
                    { "a179d257-2728-467b-ba2e-be09909638d3", "United Kingdom", "8-10278054", "Rotary Club of Mendip" },
                    { "a1823879-9df6-4676-89b4-742fe4baee10", "United Kingdom", "8-10278280", "Rotary Club of Barnsley (Rockley)" },
                    { "a18d05bb-0118-4377-970b-4970227988f8", "United Kingdom", "8-10279862", "Rotary Club of Gloucester Quays" },
                    { "a1aee30f-fcef-47ad-ad14-e62cebce4a27", "United Kingdom", "8-10285594", "Inner Wheel Club of Swanage & Purbeck" },
                    { "a1d9f16a-2429-41ff-885d-a4d2b77b7a93", "United Kingdom", "8-10279786", "Inner Wheel Club of Chipping Norton" },
                    { "a1e889fd-a458-4904-af47-d0effe7fc1ca", "United Kingdom", "8-10252619", "Rotary Club of Thrapston & Raunds" },
                    { "a1e964b8-d36f-4621-aeca-caa7a4e900b9", "United Kingdom", "8-10279829", "Inner Wheel Club of Clifton" },
                    { "a21164ff-c0f1-4152-948d-d5847efc30c1", "United Kingdom", "8-10278070", "Rotary Club of Chadderton & Failsworth" },
                    { "a27f8e3d-0e7d-416f-af37-4c9cdc52f66f", "United Kingdom", "8-10286678", "Inner Wheel Club of Deepings" },
                    { "a295c3ab-852c-40bd-a804-17740cdcff8c", "United Kingdom", "8-10281367", "Rotary Club of Ipswich" },
                    { "a2a4395f-8506-4594-8e22-3ac687167725", "United Kingdom", "8-10244573", "Interact Club of Ash Manor School" },
                    { "a2d14fa2-78bb-40b9-9632-25d669c7a45d", "United Kingdom", "8-10279852", "Rotary Club of Alford and District" },
                    { "a2dffb56-735f-496f-890e-baa7ab8dde27", "United Kingdom", "8-10278139", "Rotary Club of Allander" },
                    { "a3274188-7d18-4bab-b616-c4ea96fc743a", "United Kingdom", "8-10279773", "Rotary Club of Hythe & Waterside" },
                    { "a32b1c2f-c5b9-4041-a1cc-c2bc60083560", "United Kingdom", "8-10273372", "Rotary Club of North Fylde" },
                    { "a35703af-c475-470a-a284-236ada576afb", "United Kingdom", "8-10285713", "Rotary Club of Washington" },
                    { "a384dcf7-0b5f-425e-b825-2110bdc53df5", "United Kingdom", "8-10249823", "Rotary Club of Strathaven" },
                    { "a3a4664d-8a77-4f29-9bfb-c8777e8e6b13", "United Kingdom", "8-10286313", "Rotary Club of Merthyr Tydfil" },
                    { "a3d74bdf-7b45-431d-a280-2b6070195f3b", "United Kingdom", "8-10279397", "Inner Wheel Club of Farnham" },
                    { "a3f01a23-9f14-479d-9c46-38d64b4a5f3c", "United Kingdom", "8-10264290", "Rotary Club of Dursley" },
                    { "a3f595b3-1ad3-42d4-afe8-bff29e6b305a", "United Kingdom", "8-10278446", "Rotary Club of Tain & Easter Ross" },
                    { "a402ac88-fe20-4b38-9a59-f1bb32f15c4d", "United Kingdom", "8-10277799", "Inner Wheel Club of Woodhall Spa" },
                    { "a47072f4-3745-4070-954c-82c2fc326a1e", "United Kingdom", "8-10264311", "Rotary Club of Banchory-Ternan" },
                    { "a48b6194-9d3a-4441-87f8-6706732a7d6a", "United Kingdom", "8-10249911", "Rotary Club of Thatcham & District" },
                    { "a492029e-da45-4989-933a-7ecd548e011f", "United Kingdom", "8-10279351", "Rotary Club of Lewisham and Penge" },
                    { "a4a5eafd-b3de-4a5f-9d98-5bdcceacc34e", "United Kingdom", "8-10278894", "Inner Wheel District 25" },
                    { "a4c9a731-ad90-445c-b1a1-563d6bd28edf", "United Kingdom", "8-10248146", "Rotary Club of The Weald of Kent" },
                    { "a5032591-fe42-459e-9d2b-1bd4cf1a3941", "United Kingdom", "8-10280595", "Rotary Club of Banstead" },
                    { "a5032fed-dec7-4b27-86e2-8bcba8239f42", "United Kingdom", "8-10279849", "Rotary Club of Buckie" },
                    { "a54a81f6-9b58-4471-9118-1af3f3b7ffb9", "United Kingdom", "8-10246351", "Rotary Club of Amersham" },
                    { "a54a9c22-bc79-4da9-b349-49b7d2fede3a", "United Kingdom", "8-10285552", "Rotary Club of Wrexham Erddig" },
                    { "a568cd3f-5e9a-4962-8c99-ed0a8bf4667b", "United Kingdom", "8-10247266", "Inner Wheel Club of Rushden" },
                    { "a58df0cb-75ae-4430-a9f8-8764d97d568d", "United Kingdom", "8-10282878", "Rotary Club of Sidmouth" },
                    { "a5b9a965-8541-4a47-8484-223ffce1ae6d", "United Kingdom", "8-10257196", "Inner Wheel Club of Neston" },
                    { "a5cd1b8e-8c51-42b7-8da2-b8a2a53ae22a", "United Kingdom", "8-10279233", "Inner Wheel Club of Lincoln District 127" },
                    { "a6014d66-06d9-4b37-9d64-495feff02f22", "United Kingdom", "8-10283660", "Inner Wheel Club of Kenilworth" },
                    { "a61a5190-054f-4434-963b-90e417f261b1", "United Kingdom", "8-10249246", "Rotary Club of Neath" },
                    { "a65914fd-a57c-405f-b0ee-3c1f9861c6e9", "United Kingdom", "8-10284048", "Rotary Club of Ballymena" },
                    { "a65aaae8-5756-43ce-9593-cfed617d6c24", "United Kingdom", "8-10282795", "Inner Wheel Club of Louth" },
                    { "a68055fa-bf77-49a3-9bf7-7739691e9d6d", "United Kingdom", "8-10285668", "Rotary Club of Ravenshead & Blidworth" },
                    { "a6f2c7ef-ac8d-4bd4-aa02-237c51cda426", "United Kingdom", "8-10258998", "Inner Wheel Club of Uttoxeter" },
                    { "a6faba6f-1605-46c2-958a-3bdb4f6ac980", "United Kingdom", "8-10249463", "Inner Wheel Club of Warsop" },
                    { "a70fea63-d9d9-46e3-80dc-23d44f20f28d", "United Kingdom", "8-10244724", "Inner Wheel Club of Henley Bridge" },
                    { "a729bc4d-2a0e-45c2-b1d8-a551d63e95a5", "United Kingdom", "8-10286665", "Inner Wheel Club of Bishop Auckland" },
                    { "a75e2743-d6d3-4ac1-966b-115547c29cb3", "United Kingdom", "8-10245827", "Interact Club of Wheatley Park School" },
                    { "a777b8ef-9eec-4004-a1a4-47a73072d7a8", "United Kingdom", "8-10278619", "Inner Wheel Club of Salisbury" },
                    { "a781dea0-343b-4282-a5dd-03c7fe625389", "United Kingdom", "8-10278817", "Inner Wheel Club of Stirling" },
                    { "a7e99c1f-7731-457d-821c-20d5f24ca44b", "United Kingdom", "8-10245065", "Rotary Club of Stafford Knot" },
                    { "a7f70320-02e0-4f98-aab7-6d07e7d12a8e", "United Kingdom", "8-10283688", "Rotary Club of Shrewsbury Darwin" },
                    { "a80a98c1-2415-41e7-a191-1b584f9624e5", "United Kingdom", "8-10366701", "Rotary Club Of Borderlands (Passport Group)" },
                    { "a80efdd6-ce9f-444f-b645-39327dd9ab85", "United Kingdom", "8-10278402", "Rotary Club of Cleckheaton & District" },
                    { "a81769d9-2fa3-417f-a0e0-ca0dfefde4d9", "United Kingdom", "8-10279818", "Rotary Club of Teignmouth" },
                    { "a837cfef-b243-4fd3-8816-f214775075bb", "United Kingdom", "8-10300070", "The Inner Wheel Club Of Newent & District" },
                    { "a8454861-b4a4-46be-aabe-4d242f4dc42e", "United Kingdom", "8-10238618", "Rotary Club of Looe Valley" },
                    { "a85a49d2-52b8-424d-ba8f-540eb761efc0", "United Kingdom", "8-10246978", "Inner Wheel Club of Formby" },
                    { "a85bc163-b603-4476-b924-b0eef1016bdf", "United Kingdom", "8-10282157", "Rotary Club of Guernsey" },
                    { "a86d9bc0-09eb-45d1-95fe-9c6ff06c9962", "United Kingdom", "8-10282840", "Rotary Club of Newton & District Jubilee" },
                    { "a878cba3-5965-4110-8f5a-ecf47916ae1f", "United Kingdom", "8-10246240", "Rotary Club of Congleton" },
                    { "a8eb7cb2-64bf-4cbc-ac7e-9535b55677bf", "United Kingdom", "8-10285553", "Inner Wheel Club of Shanklin" },
                    { "a8f44462-eb5d-4a25-bf34-a0b246dc7cb7", "United Kingdom", "8-10277311", "Rotary Club of Tranent" },
                    { "a8fd8118-2f6a-4530-9aee-4740b5cf0e95", "United Kingdom", "8-10287085", "Rotary Club of Monmouth" },
                    { "a914a682-d6f5-423a-9b3e-d553e7171a44", "United Kingdom", "8-10279783", "Rotary Club of Durham Elvet" },
                    { "a925cbe2-3ed0-4fe0-a79d-4225a387f7bb", "United Kingdom", "8-10277375", "Rotary Club of Wollaton Park" },
                    { "a93181e6-f70b-4c91-87e5-81f2b00ede97", "United Kingdom", "8-10280574", "Inner Wheel Club of Tottington & Bury West" },
                    { "a9640b5e-33fb-4e25-bf8f-ab2b690f5dd1", "United Kingdom", "8-10285899", "Rotary Club of Barton-upon-Humber" },
                    { "a96e5ec3-e4f8-491f-9619-7a8f959eac4f", "United Kingdom", "8-10245068", "Inner Wheel Club of Thorne" },
                    { "a9998a35-2a6c-48fc-877d-5d609c15eecf", "United Kingdom", "8-10280108", "Rotary Club of Selkirk" },
                    { "a9a3ec34-077d-4c5d-98e6-26b40af9083a", "United Kingdom", "8-10278196", "Rotary Club of Kirkcaldy" },
                    { "a9b3ad7d-a4d0-42b0-a480-95acaeed5075", "United Kingdom", "8-10279182", "Rotary Club of Canterbury" },
                    { "a9bb8832-63a0-4a33-9a5a-4c283f9a347e", "United Kingdom", "8-10280468", "Rotary Club of Chichester Harbour" },
                    { "a9c19386-0ab0-42e8-89ba-c02ed1cc56ee", "United Kingdom", "8-10278132", "Rotary Club of Pontefract" },
                    { "a9d27212-537e-449b-bb52-ea5f2d3b01cc", "United Kingdom", "8-10281448", "Rotary Club of Kingswood (Bristol)" },
                    { "a9d30380-c3b1-4e8b-bc7a-5658a61eab02", "United Kingdom", "8-10283943", "Interact Club of The Prendergast Hilly Fields" },
                    { "a9f4be71-6221-476b-a49a-5365ec31fd00", "United Kingdom", "8-10281230", "Rotary Club of Didcot" },
                    { "aa3426ab-3325-49c8-8a1c-cc9b502f91e7", "United Kingdom", "8-10282640", "Rotary Club of Worksop" },
                    { "aa3bd8a9-d464-4734-b6bc-94504bf87a41", "United Kingdom", "8-10281804", "Inner Wheel Club of Crossgates" },
                    { "aa4296ae-7173-4eb4-96d6-a4adc8ce83e1", "United Kingdom", "8-10286858", "Rotary Club of Woodh" },
                    { "aa567af5-4d4e-4313-bcf2-4e238abccc7c", "United Kingdom", "8-10265073", "Rotary Club of Bury St. Edmunds" },
                    { "aa731649-ce0e-4fa2-b9c8-476bba047a42", "United Kingdom", "8-10283785", "Rotary Club of Wickford" },
                    { "aaa772f9-25c4-480d-b4a0-a0843282e62b", "United Kingdom", "8-10243127", "Rotary Club of Bradgate" },
                    { "aab0f5ed-71ae-4fa7-850e-b873185606a9", "United Kingdom", "8-10278346", "Inner Wheel Club of Llandrindod Wells" },
                    { "aab7edaa-4c8a-46e7-9199-4debe99c06dc", "United Kingdom", "8-10247277", "Rotary Club of South Woodham Ferrers" },
                    { "aabbce6c-cdde-4cab-96ab-cf94f5feb118", "United Kingdom", "8-10240560", "Rotary Club of Halifax Calder" },
                    { "aacb550f-b8f4-42a1-b3ac-cb5d89ed6d65", "United Kingdom", "8-10239585", "Rotary Club of Hagley" },
                    { "aad12af3-2739-455d-9df3-d0fdca1fd508", "United Kingdom", "8-10279333", "Rotary Club of Llandudno" },
                    { "aad990b6-cdd4-424d-9cf7-345a191b983f", "United Kingdom", "8-10240008", "Rotary Club of Bracknell" },
                    { "aae87368-87de-4bac-8a9d-7bd4d0bb8576", "United Kingdom", "8-10241375", "Rotary Club of Northwich" },
                    { "ab4c92fe-a507-49ad-b03c-81f907f9ef3c", "United Kingdom", "8-10280342", "Inner Wheel District 18" },
                    { "ab5b2242-dc87-4662-a183-9f8a37fb80c3", "United Kingdom", "8-10276004", "Rotary Club of Fakenham & District" },
                    { "abd9b648-e56c-48f6-abf4-85c0e917af5a", "United Kingdom", "8-10286850", "Rotary District 1180" },
                    { "abf3a639-8920-4032-8fa3-3b6517653ccb", "United Kingdom", "8-10282739", "Rotary Club of Esk Valley" },
                    { "ac0f7d1d-bd24-4809-9053-8b60581ba18f", "United Kingdom", "8-10279622", "Inner Wheel Club of Warwick" },
                    { "ac26e03d-6c61-4288-9590-2ccb82395066", "United Kingdom", "8-10239494", "Rotary Club of Morriston" },
                    { "ac34a5b2-a640-4c7e-a5cf-e27c29d2587c", "United Kingdom", "8-10281119", "Rotary Club of Jedburgh" },
                    { "ac4214bc-6e6e-43b1-b98f-87c00e1f6a4d", "United Kingdom", "8-10284648", "Rotary Club of Vectis Sunrise (Newport I.O.W.)" },
                    { "ac538e6a-05c4-4c54-b5fe-4cdd8e0def5a", "United Kingdom", "8-10286561", "Birmingham Rotaract & Cadbury Dental Practice" },
                    { "ac61ca45-8526-44a0-ba40-bb62f3af8f9a", "United Kingdom", "8-10258978", "Rotary Club of Ludlow" },
                    { "ac70e576-d160-4358-a52c-bdec63c9062a", "United Kingdom", "8-10286533", "Rotary Club of Newmarket" },
                    { "ac8f9ddd-1a37-4de2-82df-ea86bfd0e87d", "United Kingdom", "8-10238994", "Inner Wheel Club of Arundel" },
                    { "aca179e8-ed98-49e3-9c08-e83588c30cb0", "United Kingdom", "8-10240900", "Rotary Club of New Mills, Marple & District" },
                    { "acb909e0-459f-45e0-a416-623f3230fb99", "United Kingdom", "8-10241412", "Rotary Club of Inverness" },
                    { "acc05f11-cda5-4299-b874-02c81086832d", "United Kingdom", "8-10286425", "Rotary Club of Ellesmere" },
                    { "acc06af1-a276-4824-a9af-9414a9890988", "United Kingdom", "8-10278633", "Rotary Club of Chertsey" },
                    { "acc3f6e8-4d9e-41ff-8cd5-68fbe84053c1", "United Kingdom", "8-10281446", "Rotary District 1030" },
                    { "acc69aef-33ce-4387-a937-f7a9bd81c112", "United Kingdom", "8-10283801", "Rotary Club of Barrow-In-Furness" },
                    { "acefce26-04c6-42c6-bf92-184d46ebb13c", "United Kingdom", "8-10284764", "Inner Wheel Club of Ironbridge" },
                    { "ad596b6a-45aa-4208-b9cb-bd91c18c6115", "United Kingdom", "8-10283086", "Rotary Club of Sudbury" },
                    { "ada7acba-1c44-4979-9c35-448cc24abd84", "United Kingdom", "8-10254236", "Rotary Club of Salcombe" },
                    { "adc6e847-0f68-47c7-8ad6-5c666dbffcb3", "United Kingdom", "8-10249192", "Inner Wheel Club of Hall Green" },
                    { "add1b4b9-1f60-484b-9899-e57b9ef6422e", "United Kingdom", "8-10249130", "Rotary Club of High Wycombe" },
                    { "adfce7d2-c0ab-4098-a299-6fbce0537c41", "United Kingdom", "8-10286536", "Rotary Club of Newbury" },
                    { "ae16c97d-c918-496d-8673-2b1d39ea300a", "United Kingdom", "8-10278821", "Rotary Club of Ashby De La Zouch Castle" },
                    { "ae306dc2-01be-4931-b5c1-be1677be00c4", "United Kingdom", "8-10250060", "Rotary Club of North Berwick" },
                    { "ae5f318a-4caa-42aa-8d74-2add9573ced8", "United Kingdom", "8-10255844", "Rotary Club of Crewe" },
                    { "ae6950d9-0fc4-4735-a4f8-edcceac0ca34", "United Kingdom", "8-10279675", "Rotary Club of Purley" },
                    { "ae8c5a30-9d6f-47b1-9039-10463f82fcc0", "United Kingdom", "8-10278944", "Rotary Club of Hastings" },
                    { "aedb9821-89ea-4662-b8e9-65eccb434c03", "United Kingdom", "8-10286931", "Rotary Club of West Lakeland" },
                    { "af076eec-e1e5-45d9-b718-49a3b294f8ba", "United Kingdom", "8-10285953", "Rotary Club of Newtown" },
                    { "af160667-e4b9-40d0-888a-563d91a6b755", "United Kingdom", "8-10286697", "Inner Wheel Club of Nuneaton" },
                    { "af4348f8-2e7a-4f24-b733-fe45a12a660e", "United Kingdom", "8-10238614", "Rotary Club of Ipswich Wolsey" },
                    { "af773880-1762-493b-9a01-e70ad725933d", "United Kingdom", "8-10281395", "Rotary Club of Cambridge Sawston" },
                    { "afae9357-799e-4582-befd-f7ccb280c9d7", "United Kingdom", "8-10277105", "Rotary Club of Marlow" },
                    { "afdd3f84-60b8-4551-aae0-458a284001cc", "United Kingdom", "8-10282712", "Rotary Club of Wensleydale" },
                    { "afe25402-bc1e-465d-9b7c-d4ae4f3b92ec", "United Kingdom", "8-10278630", "Rotary Club of Knutsford" },
                    { "afe7d278-17f4-4195-a65b-bc46d701b9a6", "United Kingdom", "8-10256240", "Rotary Club of Padstow" },
                    { "b0173354-a398-43a6-898e-f543bcf9b638", "United Kingdom", "8-10264264", "Rotary Club of Audley" },
                    { "b01c6d74-b6ee-4fbb-813d-9c009b9823e0", "United Kingdom", "8-10249948", "Inner Wheel Club of Milford Haven" },
                    { "b0353319-8af0-4877-8545-7bf0061ba46f", "United Kingdom", "8-10277751", "Rotary Club of Kendal" },
                    { "b085e3d7-c2af-4b88-b74a-d53ded2c4a23", "United Kingdom", "8-10286270", "Rotary Club of Hoddesdon" },
                    { "b0ac39ac-8655-4ca8-809c-b835ccd0bf49", "United Kingdom", "8-10280843", "Inner Wheel Club of Wakefield" },
                    { "b0adce17-320b-4f8c-b253-894a15f6ed7a", "United Kingdom", "8-10283745", "Rotary Club of Swaffham" },
                    { "b0b71bbf-7daf-4e76-91e4-6d2bff0162ca", "United Kingdom", "8-10282608", "Rotary Club of Wembley" },
                    { "b0dc3c24-1bf9-4c62-9056-5867e8471a26", "United Kingdom", "8-10283725", "Rotary Club of Church Stretton" },
                    { "b12034bb-5f81-4e8f-8f6d-58f394bda34f", "United Kingdom", "8-10277567", "Inner Wheel Club of Royal Forest Of Dean" },
                    { "b15d056c-da56-4784-a7ed-f2ad58c10e37", "United Kingdom", "8-10285888", "Rotary Club of Hitchin Tilehouse" },
                    { "b1695e73-25ab-47a3-a65f-266da662d7c2", "United Kingdom", "8-10252098", "Inner Wheel Club of Parkstone & Poole District" },
                    { "b17dd5ec-1a72-4732-9ca5-2feb1b44efbf", "United Kingdom", "8-10256241", "Rotary Club of Wadebridge" },
                    { "b19d8bbd-9ca9-405f-9b8c-40e1cf520804", "United Kingdom", "8-10250815", "Inner Wheel District 4" },
                    { "b1a232b6-99ce-407b-b5a2-00bcfe308c1f", "United Kingdom", "8-10242452", "Inner Wheel Club of Thetford" },
                    { "b1b857ac-71e4-43c6-a722-3145c2640e30", "United Kingdom", "8-10323247", "Inner Wheel Club Of Sandbach" },
                    { "b1c32b30-e130-49ba-b461-8670f7121e42", "United Kingdom", "8-10276005", "Inner Wheel Club of Morpeth" },
                    { "b1cdeca3-9275-490e-ab70-8c417feb1fb3", "United Kingdom", "8-10282946", "Rotary Club of Grantham Sunrise" },
                    { "b208689c-ba49-4514-b564-f387b0ef5526", "United Kingdom", "8-10278096", "Rotary Club of Alsager" },
                    { "b20f2a86-e3b4-4980-9122-b647e42e7130", "United Kingdom", "8-10249263", "Rotary Club of Sherbourne Castles" },
                    { "b223c6e9-385f-48ab-a649-ae37ccbd66a5", "United Kingdom", "8-10238635", "Inner Wheel Club of Minehead & the Quantocks" },
                    { "b22f63cb-6fe0-4da4-876b-330ea3cee9f1", "United Kingdom", "8-10286269", "Rotary Club of Bathgate" },
                    { "b239c39b-7487-4dc9-951d-06e09ef41a27", "United Kingdom", "8-10279140", "Rotary Club of Kettering Huxloe" },
                    { "b23f6bb8-982e-488f-9a55-3ca245116370", "United Kingdom", "8-10279793", "Rotary Club of Crieff" },
                    { "b245cb82-9481-44e0-a898-c5d6ad0ce927", "United Kingdom", "8-10248860", "Rotary Club of Monifieth & District" },
                    { "b2896709-9f95-4746-8f8f-d58fca9bba9a", "United Kingdom", "8-10277114", "Inner Wheel Club of Chichester" },
                    { "b29a031c-288e-4596-bfd9-6a80958378f1", "United Kingdom", "8-10245624", "Rotary Club of Scarborough Cavaliers" },
                    { "b2e54eb9-f623-4f96-a232-3d7a7a486aeb", "United Kingdom", "8-10284653", "Rotary Club of Southampton Clausentum" },
                    { "b30bb6a3-b613-4d20-be54-095daea8198c", "United Kingdom", "8-10281963", "Rotary Club of Lostwithiel" },
                    { "b3606acb-4321-44a8-9801-b366dcee77df", "United Kingdom", "8-10286849", "Rotary Club of Mansfield" },
                    { "b379ec57-8151-4710-af93-9686b2be3461", "United Kingdom", "8-10241430", "Rotary Club of Felixstowe Landguard" },
                    { "b38d50c8-a4e2-4430-9127-9d33115c0470", "United Kingdom", "8-10286495", "Rotary Club of Kirkcudbright" },
                    { "b3da4255-1fab-447d-a9aa-55bf92adedfe", "United Kingdom", "8-10248890", "Rotary Club of Cowdenbeath" },
                    { "b3f205a8-684a-4c4d-8015-88c27f1bf672", "United Kingdom", "8-10281222", "Rotary Club of Huntingdon" },
                    { "b3fc9d80-514d-4b1c-ac00-4e22465cd5c4", "United Kingdom", "8-10249570", "Rotary Club of Bradford Blaize" },
                    { "b414b01e-5394-4c3b-91f8-c9fc7a136757", "United Kingdom", "8-10278256", "Inner Wheel Club of Newport" },
                    { "b43a2089-c094-4f07-90e7-899bc67e52b8", "United Kingdom", "8-10281282", "Rotary Club of Abingdon Vesper" },
                    { "b450e537-48aa-4926-bf95-f2d24ebb774e", "United Kingdom", "8-10279136", "Rotaract Club of Glasgow" },
                    { "b4574171-45b7-4a37-b1be-76cec0bc8523", "United Kingdom", "8-10242556", "Rotary District 1220" },
                    { "b4893d8e-139c-44ad-b10d-3832f78ac8e9", "United Kingdom", "8-10279556", "Rotary Club of Great Yarmouth Haven" },
                    { "b49cb06e-b915-421e-a864-15cee4f5e6fc", "United Kingdom", "8-10279842", "Inner Wheel Club of Llanfairfechan & Penmaenmawr" },
                    { "b4d63818-554f-4336-a7fd-d4ca11983bb5", "United Kingdom", "8-10286478", "Rotary Club of Cheadle & District" },
                    { "b5375899-f14d-475f-8aa3-437d50162cd7", "United Kingdom", "8-10279287", "Rotary Club of South Cotswolds" },
                    { "b53daf1d-8cc6-4a37-90d9-0f2babaa6484", "United Kingdom", "8-10279713", "Rotary Club of Westbourne" },
                    { "b5479eac-fde8-4b83-86e2-3af5442b83ec", "United Kingdom", "8-10285943", "Rotary Club of Greenock" },
                    { "b55981b2-796d-4319-b3ef-369d69d35616", "United Kingdom", "8-10279618", "Inner Wheel Club of Windsor & Eton" },
                    { "b572d09b-5ed7-48b6-962c-e84478af35d8", "United Kingdom", "8-10277227", "Rotary Club of Derby South" },
                    { "b59d1584-e6e6-454d-baf5-d3c33030e8ef", "United Kingdom", "8-10284673", "Rotary Club of Fareham" },
                    { "b5a9b770-d11f-4b33-bcd1-37ffe52b8417", "United Kingdom", "8-10247507", "Rotary Club of Rhos-On-Sea" },
                    { "b5c36d1a-30b3-4b3f-80fb-47824e46612e", "United Kingdom", "8-10276560", "Rotary Club of Felixstowe" },
                    { "b61b1a60-4e8d-4c25-b00b-f2716d5e6c7e", "United Kingdom", "8-10281961", "Rotary Club of Staines" },
                    { "b62260fc-231a-4775-bfef-aaac8c6134d7", "United Kingdom", "8-10276710", "Rotary Club of Bishops Stortford" },
                    { "b6323b48-39e3-4a23-b152-41515325dce2", "United Kingdom", "8-10256373", "Rotary Club of Hetton-Le-Hole" },
                    { "b6392c0c-84c7-4618-87e2-4f86e8d671bc", "United Kingdom", "8-10283638", "Rotary Club of Ashford, Middlesex" },
                    { "b6980d6c-f23c-4ee9-a4f2-04dd1f8b42d9", "United Kingdom", "8-10281046", "Rotary Club of Bolton Daybreak" },
                    { "b6a4f116-fae4-4a13-8bbf-d7b1c7e70003", "United Kingdom", "8-10240263", "Interact Club of Sandwich" },
                    { "b6c8a7cb-a241-47fb-a944-fcf933891804", "United Kingdom", "8-10246768", "Inner Wheel Club of Evesham" },
                    { "b6df78ad-458d-4d29-9604-4c2f4ee5a205", "United Kingdom", "8-10253932", "Rotaract Club of Thurles" },
                    { "b6f52c24-db75-4055-99fb-efcb20ec261e", "United Kingdom", "8-10277609", "Rotary Club of Brechin" },
                    { "b706e388-45e1-436c-ab13-399bb3ac5ef9", "United Kingdom", "8-10278263", "Rotary Club of Boston St. Botolph" },
                    { "b71811f6-6d9f-4060-9a47-3dcd15b1076e", "United Kingdom", "8-10238742", "Rotary Club of Hampstead" },
                    { "b731621f-52f7-4ecf-8f22-37833fa55a09", "United Kingdom", "8-10284692", "Inner Wheel Club of Hove" },
                    { "b73a95fc-ab4d-48d8-8a09-7e9418697337", "United Kingdom", "8-10265965", "Inner Wheel Club of Birkenhead" },
                    { "b741f013-6adb-486b-aacd-367b92f9a327", "United Kingdom", "8-10283823", "Rotary Club of Cardiff St. Davids" },
                    { "b76092de-989e-4643-aa04-8ddd59e310d4", "United Kingdom", "8-10281870", "Rotary Club of Ribblesdale" },
                    { "b76794ae-bc63-4ec2-9b57-634fc156e9a4", "United Kingdom", "8-10281143", "Rotary Club of Morden" },
                    { "b76cede4-04cb-4873-abad-b38c1ac5fa0b", "United Kingdom", "8-10249819", "Rotaract Club of Tottington & Bury West" },
                    { "b7720d5e-ca60-4189-a300-51ed4701a9ef", "United Kingdom", "8-10281934", "Rotary Club of Stevenage Grange" },
                    { "b7795b5e-e531-4c7a-854e-fb26b10c8d97", "United Kingdom", "8-10284722", "Rotary Club of Danetre Daventry" },
                    { "b78a11ef-d8aa-4fcb-a24e-036dad85a204", "United Kingdom", "8-10281509", "Rotary Club of Yatton" },
                    { "b791bb65-72dd-4bfa-923f-6a68b499b86b", "United Kingdom", "8-10248151", "Rotary Club of Newham" },
                    { "b7b79143-cd6f-4d43-87a3-933fda88c922", "United Kingdom", "8-10280078", "Rotary Club of Lewes" },
                    { "b7dc2bf0-991e-4ed2-bb43-46f9030bfe16", "United Kingdom", "8-10285877", "Rotary Club of Langley Park" },
                    { "b7ed42a7-ea59-4a47-bc11-f0e7555cd0ce", "United Kingdom", "8-10241751", "Rotary Club of York Ainsty" },
                    { "b855a78a-a055-4e52-bca4-935c0b8df9e7", "United Kingdom", "8-10240016", "Rotary Club of Caerleon" },
                    { "b89a12b5-20c3-4fe3-a9fd-62a32cf85e6d", "United Kingdom", "8-10249181", "Rotary Club of Great Yarmouth" },
                    { "b8a0b00f-c9ca-4f6e-8886-a0b5e53f550a", "United Kingdom", "8-10277373", "Rotary Club of Twickenham" },
                    { "b8ab4a8c-68f7-4167-b94b-a09dc45a1b3c", "United Kingdom", "8-10280311", "Rotary Club of Mapperley & Arnold" },
                    { "b8c0b422-9579-4ea1-b9af-f3dbab9a59c4", "United Kingdom", "8-10264683", "Rotary Club of Moseley & Sparkbrook" },
                    { "b8ffae06-c6e9-4704-b245-57b8cb6ec653", "United Kingdom", "8-10256384", "Rotary Club of West Derby-Liverpool" },
                    { "b95283a8-390d-4fc7-9ed0-dab045b0e60a", "United Kingdom", "8-10286551", "Rotary Club of Humberside" },
                    { "b981e04a-160c-4009-be15-5c63062e1702", "United Kingdom", "8-10286571", "Rotary Club of Tarporley" },
                    { "b99687c4-16f6-4eda-bfd9-b81a932bdf11", "United Kingdom", "8-10284698", "Rotary Club of Houghton-le-Spring" },
                    { "b9db45cb-3900-49b3-bb25-2c3bb6367d3d", "United Kingdom", "8-10244347", "Rotary Club of Dungannon" },
                    { "b9e28b10-4cb4-404e-b651-4ad97f1b7c54", "United Kingdom", "8-10283517", "Rotary Club of Banbury Cherwell" },
                    { "ba26b338-3637-413a-bc71-1bbab387ada5", "United Kingdom", "8-10240313", "Rotary Club of Axminster" },
                    { "ba2b8d2c-2cdc-436e-859c-e48be9dc5f6a", "United Kingdom", "8-10281040", "Inner Wheel Club of Port Talbot" },
                    { "ba52e194-096f-4d48-9ecc-a4447302f46e", "United Kingdom", "8-10280791", "Rotary Club of Wiveliscombe & District" },
                    { "ba557905-081f-4ce7-b2fa-f7174057d416", "United Kingdom", "8-10278843", "Rotary Club of Diss Waveney" },
                    { "ba8c6e24-bf2c-4c5b-bcb3-f00fa9ef858f", "United Kingdom", "8-10281807", "Rotary Club of Westbury" },
                    { "bb008d5f-3ee9-42f6-8509-75abca3a2318", "United Kingdom", "8-10279800", "Rotary Club of Handsworth" },
                    { "bb2951d5-7068-4b45-b56a-9f998851f03b", "United Kingdom", "8-10258976", "Rotary Club of Henley-On-Thames" },
                    { "bb2bd137-4f95-444b-a51f-d94ad62690f9", "United Kingdom", "8-10286933", "Rotary Club of Stockton-on-Tees" },
                    { "bb2f88a2-15fe-47d7-aaca-722a888f3b84", "United Kingdom", "8-10242798", "Rotary Club of Cockermouth" },
                    { "bb5e84e3-ff75-476a-b484-4bea6765bbab", "United Kingdom", "8-10286907", "Rotary Club of Sligo" },
                    { "bb9997c3-c7c2-4322-ae4a-fd758eae77aa", "United Kingdom", "8-10281980", "Rotary Club of Brighton & Hove Soiree" },
                    { "bb9ea0e6-2b26-470d-8c69-50c5280264fa", "United Kingdom", "8-10254284", "Rotary Club of Westminster International" },
                    { "bbbcd0e3-5635-40a3-b524-8a20e64c2368", "United Kingdom", "8-10279808", "Inner Wheel Club of Arbury" },
                    { "bbca9a69-9d56-4a00-9f40-a31348ab9d41", "United Kingdom", "8-10286542", "Inner Wheel Club of Oxted & Limpsfield" },
                    { "bc33713e-b8dc-4392-b481-9dc1f5b1a366", "United Kingdom", "8-10278514", "Rotary Club of Saundersfoot" },
                    { "bc3bcb94-2f13-40c3-a2b8-915222d0bd29", "United Kingdom", "8-10283742", "Rotaract Club of Burnham" },
                    { "bc52055e-48b6-4bc2-821c-b35836d8b0f4", "United Kingdom", "8-10250960", "Rotary Club of Shrewsbury" },
                    { "bc54206c-998a-4644-85ab-b7f8da454c25", "United Kingdom", "8-10264302", "Rotary Club of Shipston-on-Stour" },
                    { "bc5a871e-f4ee-4236-a0a4-76abc4b0f4ae", "United Kingdom", "8-10242650", "Rotary Club of Lowestoft East Point" },
                    { "bc913cd7-428f-425b-812a-67c2074418d8", "United Kingdom", "8-10265062", "Rotary Club of St. Neots" },
                    { "bcba62c2-67a3-4a7b-af76-3e27974a8aa5", "United Kingdom", "8-10248806", "Rotary Club Of Burnham On Crouch & Dengie Hundred" },
                    { "bccd7158-bc9d-4205-87e3-992c83270fcc", "United Kingdom", "8-10283902", "Rotary Club of Pinner" },
                    { "bce2dcd1-0e12-4a83-8393-bd4a1ab9739e", "United Kingdom", "8-10285558", "Interact Club of Waingels College" },
                    { "bd2137f0-b4e5-4d13-906e-2c028a3e10f0", "United Kingdom", "8-10280431", "Rotary Club of Hinckley Ambion" },
                    { "bd3242c7-3695-481b-a3e7-2af8e0ef31b4", "United Kingdom", "8-10285609", "Rotary Club of Sevenoaks" },
                    { "bd62c6e7-2886-4ac9-82cc-f725f6dc34fa", "United Kingdom", "8-10248705", "Rotary Club of Truro" },
                    { "bd73f497-236a-4761-af7e-20dd270cb74f", "United Kingdom", "8-10282775", "Inner Wheel Club of Swinton & Pendlebury" },
                    { "bd74c087-f944-49b3-adc8-7306416f6fc1", "United Kingdom", "8-10246591", "Rotary Club of Taunton" },
                    { "bd8e86ed-e9ae-48f7-b9ca-f4009018c0d0", "United Kingdom", "8-10239873", "Rotary Club of Nantwich" },
                    { "bdb4fa85-b28b-4024-b735-0de7379976af", "United Kingdom", "8-10242789", "Rotary Club of Stowmarket Gipping Valley" },
                    { "bdd2aca5-c930-44d2-9067-192e89bb8180", "United Kingdom", "8-10256361", "Rotary Club of Kirkintilloch" },
                    { "bdd63589-17ef-48b6-a64b-de31089fd037", "United Kingdom", "8-10283707", "Rotary Club of Cardiff East" },
                    { "bdde7496-d8df-4994-b0cf-23b7f098c4fd", "United Kingdom", "8-10276694", "Rotary Club of Hemel Hempstead" },
                    { "be421745-b5fe-433e-a927-6c65821221c9", "United Kingdom", "8-10286379", "Inner Wheel Club of West Wirral" },
                    { "be76901c-502a-4d8e-a418-2d1e163691a5", "United Kingdom", "8-10245912", "Rotary Club of Irlam" },
                    { "be7b19d7-aa27-43ac-a990-65080a78a03c", "United Kingdom", "8-10276558", "Rotary Club of Braintree Rivers" },
                    { "be8e6daa-2fe7-4763-bf19-ede12926d84a", "United Kingdom", "8-10284789", "Rotary Club of Innerleithen, Walkerburn & Traquair" },
                    { "be9361e8-1a59-415c-b3dd-90fac6cae28b", "United Kingdom", "8-10240236", "Inner Wheel Club of Sidcup" },
                    { "beaaa280-dc86-4430-99e6-bad259e30896", "United Kingdom", "8-10286922", "Rotary Club of Kingsbury & Kenton" },
                    { "bef698df-9070-4087-824f-25cc544f4538", "United Kingdom", "8-10248879", "Rotary Club of Llanfairfechan & Penmaenmawr" },
                    { "befd3e06-a829-4c72-b957-1bca7698687b", "United Kingdom", "8-10285534", "Rotary Club of Northwich Vale Royal" },
                    { "bf68d9e9-7435-45d8-8c1f-7adc2ee725d0", "United Kingdom", "8-10281981", "Rotary Club of Hart" },
                    { "bf78bbbc-3df9-4f71-bb92-9ac2955caca5", "United Kingdom", "8-10248899", "Rotary Club of Royden Revolve" },
                    { "bf9ddfea-4952-4c3a-a269-0e664f08b06e", "United Kingdom", "8-10278416", "Rotary Club of Stamford" },
                    { "bfa09b51-dfa3-49a0-9745-062cb354a48b", "United Kingdom", "8-10249439", "Rotary Club of Oxford North" },
                    { "bfad95e9-9051-4d3c-882a-bb738295708e", "United Kingdom", "8-10282917", "Inner Wheel Club of Bridport" },
                    { "c044ea3c-dbe1-4503-ba51-b625dd1b6a06", "United Kingdom", "8-10277805", "Rotary Club of Grays Thurrock" },
                    { "c05f457b-228d-4b30-9cd0-f4fb3c21c93c", "United Kingdom", "8-10286729", "Rotary Club of Alfreton" },
                    { "c0885830-37d5-4de6-9e97-79b364b85505", "United Kingdom", "8-10278444", "Rotary Club of South Cave & Wolds" },
                    { "c0a10ea7-e8d4-49ca-9e91-29033347d484", "United Kingdom", "8-10279278", "Rotary Club of Holsworthy" },
                    { "c0b29937-8de3-4e37-a290-1ebdeaa0bb0e", "United Kingdom", "8-10279814", "Rotary Club of North Down" },
                    { "c0bab878-a0c0-46dc-a76d-77a48e25cf73", "United Kingdom", "8-10246329", "Interact Club of Wye Valley Bourne" },
                    { "c0ce047b-6169-467a-80ab-08c72516dabe", "United Kingdom", "8-10286530", "Rotary Club of Clifton (Bristol)" },
                    { "c0d7daa0-404e-4cf5-af5e-e37c9c9338dc", "United Kingdom", "8-10284049", "Rotary Club of Newton-Le-Willows" },
                    { "c0eb3c2a-8b61-449f-8aa4-c3e26861b571", "United Kingdom", "8-10280461", "Rotary Club of Godalming" },
                    { "c109a393-a82b-4fdd-b002-80b721531bc4", "United Kingdom", "8-10252641", "Rotary Club of Chichester" },
                    { "c10f427c-8f40-4a77-8f95-4958ff6e69aa", "United Kingdom", "8-10282860", "Rotary District 1210" },
                    { "c1284998-e51e-46ea-ab4d-067bc88ed056", "United Kingdom", "8-10243154", "Inner Wheel Club of Littlehampton" },
                    { "c1627550-3595-41f0-a4ac-6cf47c45bc8c", "United Kingdom", "8-10286311", "Rotary Club of Sutton Coldfield Vesey" },
                    { "c170cac3-514b-4ded-b1ce-894c25588fb4", "United Kingdom", "8-10241082", "Rotary Club of Ilkeston" },
                    { "c1735ff5-31ae-4ca3-a476-8d8221fce2c8", "United Kingdom", "8-10249420", "Rotary Club of Henley-In-Arden" },
                    { "c17d92de-760e-476f-891b-a70838d6a587", "United Kingdom", "8-10286783", "Rotary Club of Boscombe & Southbourne" },
                    { "c19f734f-1341-421f-8020-b12e80015dc4", "United Kingdom", "8-10257177", "Inner Wheel Club of Penkridge" },
                    { "c1bb5b25-60e7-40ab-9bca-84fc3ab07505", "United Kingdom", "8-10281806", "Rotary Club of Wareham" },
                    { "c20b3dea-4370-4e8f-a355-8ea392838ee0", "United Kingdom", "8-10278424", "Rotary Club of Middleton" },
                    { "c2526cc2-fe93-440e-9a0e-f30f67827f78", "United Kingdom", "8-10279765", "Rotary Club of Redhill, Reigate & District" },
                    { "c2555074-0915-4912-a485-0bcb358bbda0", "United Kingdom", "8-10285871", "Rotary Club of South Sefton" },
                    { "c275df6a-2b7b-4a05-baf9-e978662b6339", "United Kingdom", "8-10249575", "Rotary Club of Grimsby Havelok" },
                    { "c2a78419-7f43-40c7-ae2e-4fba71066436", "United Kingdom", "8-10285700", "Rotary Club of Chatteris" },
                    { "c2db3d87-08e3-4960-ba34-5169c706454f", "United Kingdom", "8-10281739", "Rotary Club of Penrith" },
                    { "c2e0ea30-46ab-4f75-9eb9-d1b1a1c88eb8", "United Kingdom", "8-10281376", "Rotary Club of Colchester Forum" },
                    { "c2e2b54c-f120-4bb9-80a4-bd877a071cdc", "United Kingdom", "8-10279107", "Ladies Social Group" },
                    { "c2edc22d-64be-443f-acf9-01f91c4cbbf4", "United Kingdom", "8-10282628", "Rotary Club of Sutton Nonsuch" },
                    { "c2fb5bae-3637-47b8-9786-789c8292a38c", "United Kingdom", "8-10286808", "Rotary Club of Gants Hill" },
                    { "c3143baa-4164-4dc7-9b67-d294734dfb0e", "United Kingdom", "8-10281045", "Rotary Club Of Backwell And Nailsea" },
                    { "c32ce419-71a3-406a-b9c1-1884c20c9636", "United Kingdom", "8-10252639", "Rotary Club of Enfield Chase" },
                    { "c3411649-a0ef-43b3-81f3-c01f3820a7e3", "United Kingdom", "8-10278317", "Inner Wheel Club of Chelmsford Mildmay" },
                    { "c3d6fdc1-1bff-4684-b24f-a578bd3dc23d", "United Kingdom", "8-10279317", "Rotary Club of Tavistock" },
                    { "c3e82d80-4190-423a-a4ea-901c51cdcf1c", "United Kingdom", "8-10277026", "Rotary Club of Chiswick & Brentford" },
                    { "c3f1c85b-c496-417d-aea2-b3d365798fcf", "United Kingdom", "8-10250670", "Rotary Club of Horbury & Ossett Phoenix" },
                    { "c3fd329f-0160-452f-a8ee-0123885930ff", "United Kingdom", "8-10243608", "Rotary Club of Brentwood Breakfast" },
                    { "c429ead6-2a90-4e5f-8a78-496613c48527", "United Kingdom", "8-10278414", "Inner Wheel Club of Boscombe & Southbourne" },
                    { "c43cac69-5f79-489b-b45e-682c432c6fa5", "United Kingdom", "8-10240262", "Rotary Club of Midsomer Norton & Radstock" },
                    { "c451e947-bdd9-4f93-b16c-0502175a129f", "United Kingdom", "8-10279262", "Rotary Club of Stourport-on-Severn" },
                    { "c45e2682-5ef5-4138-82f0-6aecdf0cd02d", "United Kingdom", "8-10284119", "Rotary Club of Mold" },
                    { "c467ef79-ed0b-472f-91d0-8528b95da811", "United Kingdom", "8-10286649", "Rotary Club of Sanderstead & Selsdon" },
                    { "c49a755e-8b31-4fbc-b1ad-2dff882b4c02", "United Kingdom", "8-10264208", "Rotary Club of Kirkham & Rural Fylde" },
                    { "c4fc966c-c7b8-4686-95cf-fda76cd307fb", "United Kingdom", "8-10277397", "Rotary Club of Princes Risborough" },
                    { "c50506ed-7e2e-46bb-982a-ff3901eadb0a", "United Kingdom", "8-10283975", "Rotary Club of Fareham Meon" },
                    { "c525fa12-f823-46b5-b749-1c9f378f9b6c", "United Kingdom", "8-10249314", "Rotary Club of Carshalton Park" },
                    { "c533fdbe-7701-4ef7-8743-e2893c85529e", "United Kingdom", "8-10276570", "Rotary Club of Abertillery & Blaina" },
                    { "c57dae48-dae4-43aa-a46c-734581f6f883", "United Kingdom", "8-10281457", "Rotary Club of Cwmbran Vale" },
                    { "c57e8acf-cce2-4ea2-88c7-c5731e227536", "United Kingdom", "8-10250978", "Rotary Club of The Deepings" },
                    { "c57eb3e9-4bf2-49ee-8ef2-daced6f0f1e0", "United Kingdom", "8-10286488", "Bridge Ladies" },
                    { "c587f2a2-706c-4b35-b988-9ca23746fc65", "United Kingdom", "8-10245278", "Interact Club of King Edward VI Five Ways School" },
                    { "c631ef15-e0ba-4ee9-88ad-002eef7642a3", "United Kingdom", "8-10282748", "Rotary Club of Marlow Thames" },
                    { "c63fb226-72fc-4a0b-a68f-ae4ab1650ebb", "United Kingdom", "8-10241415", "Rotary Club of Reading Matins" },
                    { "c643f903-daea-4e91-94f9-3f679bed182a", "United Kingdom", "8-10238918", "Inner Wheel Club of Worsley" },
                    { "c64b6cab-de7e-467e-a009-33bdd6f3ce9f", "United Kingdom", "8-10280111", "Rotary Club of Exmoor" },
                    { "c65fa26e-babe-433d-8aed-913b424ecc1f", "United Kingdom", "8-10239486", "Rotary Club of Holt" },
                    { "c687d8cd-8042-4aa6-a3e0-b4caefa1a5cf", "United Kingdom", "8-10256274", "Inner Wheel Club of Bailgate (Lincoln)" },
                    { "c6db22a0-0cbc-4235-b28a-653d9a4ba18d", "United Kingdom", "8-10249471", "Interact Club of The Royal School" },
                    { "c72e9d3e-b8e5-4bbb-a6a4-6cbb27ea2913", "United Kingdom", "8-10277058", "Rotary Club of Leith" },
                    { "c7592b55-d773-4fa9-8e87-9d6a532203f9", "United Kingdom", "8-10277071", "Rotary Club of Paisley" },
                    { "c762525d-4799-4201-a627-f2f5e0f35809", "United Kingdom", "8-10243167", "Inner Wheel Club of Strathaven" },
                    { "c7919643-035c-4cbe-b2b4-2172a2dc74f7", "United Kingdom", "8-10246982", "Inner Wheel District 3" },
                    { "c7934ab0-7f70-49b2-afa9-245629009cc2", "United Kingdom", "8-10273382", "Inner Wheel Club of Berkhamsted Bulbourne" },
                    { "c7a5cb67-7761-4548-85e5-fb92f676e928", "United Kingdom", "8-10278754", "Rotary Club of Battersea, Brixton & Clapham" },
                    { "c7cbadea-1ada-4792-896b-e8bc196f925b", "United Kingdom", "8-10286728", "Rotary Club of Narberth & Whitland" },
                    { "c7fd4ea6-d500-46ee-a559-eaf1d4652954", "United Kingdom", "8-10278279", "Rotary Club of Peebles" },
                    { "c83cca4b-3b8c-43d4-abd3-7ef0e6543923", "United Kingdom", "8-10249074", "Rotary Club of Hove" },
                    { "c840528f-9928-4ba6-8900-f3eeef44f5b9", "United Kingdom", "8-10281996", "Rotary Club of Whittlesey" },
                    { "c86403b1-ff64-4f35-ae65-42cc7d7b0433", "United Kingdom", "8-10276712", "Inner Wheel Club of Dartmouth" },
                    { "c86b8922-afa9-4342-a89d-76782a093722", "United Kingdom", "8-10279856", "Rotary Club of Chichester Priory" },
                    { "c8868747-aa7f-4a32-b977-60d4dce38f77", "United Kingdom", "8-10360444", "Rotary Club Of Litchfield" },
                    { "c8954f83-15dc-4c87-b950-4361bfbb4cdb", "United Kingdom", "8-10249115", "Rotaract Club of Newton Aycliffe" },
                    { "c89786d0-4844-4086-a37e-3b18c2b3fb7e", "United Kingdom", "8-10244282", "Rotary Club of Strood" },
                    { "c8b66e89-5f5e-4a4d-af9c-f362198ed5a0", "United Kingdom", "8-10262584", "Inner Wheel Club of Lancaster Loyne" },
                    { "c8c0d8f3-2453-4106-9c94-1845353e0e76", "United Kingdom", "8-10278069", "Rotary Club of Gravesend" },
                    { "c8e85485-a85f-4076-a3c0-24c19a768ab2", "United Kingdom", "8-10286342", "Rotary Club of Henllys" },
                    { "c8f042f4-1196-4fa8-87df-432265137149", "United Kingdom", "8-10250369", "Rotary Club of North Worcestershire" },
                    { "c8f26776-1f09-4287-87b0-2a8f905d8217", "United Kingdom", "8-10282179", "Rotary Club of Wakefield" },
                    { "c901c32f-bf85-4c1e-8e58-d6441ae2e679", "United Kingdom", "8-10287171", "Inner Wheel Club of East Ham" },
                    { "c9293655-be95-4446-bf3e-e625b4d477c1", "United Kingdom", "8-10281405", "Rotary Club of Sheffield" },
                    { "c92fb2c5-e19a-403b-b609-975ae948ee87", "United Kingdom", "8-10286288", "Inner Wheel Club of Truro" },
                    { "c93a49ee-249c-4f96-94f6-b5ed895145a3", "United Kingdom", "8-10277032", "Rotary Club of Woodbridge Deben" },
                    { "c9451cc4-252b-456e-832b-229c51e65521", "United Kingdom", "8-10247369", "Rotaract Club of Kintore" },
                    { "c97a618c-66c0-4f23-9b59-d6e0a219166c", "United Kingdom", "8-10278814", "Rotary Club of Ryde" },
                    { "c9a31e18-60a4-4993-9d66-2f64c872702e", "United Kingdom", "8-10279124", "Inner Wheel Club of Southam" },
                    { "c9bbc886-b582-4ab0-93e3-838dd85c679f", "United Kingdom", "8-10279361", "Rotary Club of Aberdeen-St. Nicholas" },
                    { "c9cf14a4-d3d2-4b91-b7bd-08cbdc787deb", "United Kingdom", "8-10286442", "Rotary Club of Stockport-Lamplighter" },
                    { "c9d283e6-bb1c-49ca-9934-915beff18d4a", "United Kingdom", "8-10280787", "Rotary Club of Gloucester Severn" },
                    { "c9dddb34-06f0-40cf-bebc-9c063701ae56", "United Kingdom", "8-10279784", "Rotary Club of Battersea Park" },
                    { "ca27df8f-dd69-4e80-98d6-8f7737e9ffb8", "United Kingdom", "8-10277131", "Rotary Club of Alford & Mablethorpe" },
                    { "ca36753a-f7fd-4d6e-b522-c12d201691a9", "United Kingdom", "8-10281365", "Rotary Club of Harrogate" },
                    { "ca87de2a-8e99-4393-af0b-883ab019fca5", "United Kingdom", "8-10244737", "Inner Wheel Club of Bookham & Horsley" },
                    { "ca89f1a0-eb41-400b-acd4-92340554f121", "United Kingdom", "8-10246949", "Inner Wheel Club of Yeovil" },
                    { "ca9ced2a-efdd-48ff-b87e-901ec5a160ae", "United Kingdom", "8-10278924", "Rotary Club of Market Rasen" },
                    { "cabebc9e-67bc-46a3-810e-3fe31a84b05e", "United Kingdom", "8-10286804", "Rotary Club of Liverpool Exchange" },
                    { "cad218eb-0a64-4c19-8dd0-cacb51f9c732", "United Kingdom", "8-10279352", "Inner Wheel Club of Coleraine" },
                    { "cad2b468-5d75-45fa-902a-93cd2d7b81a7", "United Kingdom", "8-10283727", "Rotary Club of Enfield" },
                    { "cb4e639c-6b1f-4d34-9776-73d536815d8a", "United Kingdom", "8-10240872", "Interact Club of Thurso High School" },
                    { "cb79219e-6b49-4992-97e0-db259673d48e", "United Kingdom", "8-10250576", "Rotary Club of Dalbeattie" },
                    { "cb8cb494-5504-45fd-997c-942fa478522e", "United Kingdom", "8-10246502", "Interact Club of Carterton Community College" },
                    { "cb8fc276-7113-47d4-b6c9-fc345f2f24be", "United Kingdom", "8-10284151", "Inner Wheel District 129" },
                    { "cb948d59-310b-45e6-bc18-ba8a5e4c4dbf", "United Kingdom", "8-10246486", "Inner Wheel Club of Whitley Bay" },
                    { "cbef2aa6-8d06-4c9e-b20f-ae023cfb2499", "United Kingdom", "8-10285850", "Inner Wheel Club of Prestwich & Whitefield" },
                    { "cc58d9c4-1502-48b1-a4cd-2a1740c344c6", "United Kingdom", "8-10246971", "Rotary Club of Ely" },
                    { "cc590939-ec08-46f5-a671-a265debd6da8", "United Kingdom", "8-10283947", "Rotary Club of Ripon Rowels" },
                    { "ccdc0da0-2673-4d2d-ae3b-2c8f6bd61c7b", "United Kingdom", "8-10284148", "Rotary Club of Redbridge" },
                    { "ccf4ba83-14eb-4108-bafa-5c89f9c55e02", "United Kingdom", "8-10372771", "Rotary Club Of Cheltenham Future" },
                    { "cd1cd658-6c4c-4a4e-a80c-492c82a2eed6", "United Kingdom", "8-10284792", "Rotary Club of Minster on Sea" },
                    { "cd456abb-482d-4161-ab16-bf6076dd5229", "United Kingdom", "8-10246245", "Rotary Club of Egham" },
                    { "cd6c1796-7f11-432b-813e-e72302b9ba95", "United Kingdom", "8-10286842", "Rotary Club of Furness Peninsula" },
                    { "cd7f26a4-de74-4936-8ced-d7b2a0649994", "United Kingdom", "8-10278259", "Rotary Club of Barrhead" },
                    { "cd85f842-ba05-4ab7-b8c8-d3d80558c9ef", "United Kingdom", "8-10258420", "Interact Club of Cumnock Academy" },
                    { "cdc0aaef-45a8-4ce4-953b-18ed76131790", "United Kingdom", "8-10246968", "Inner Wheel Club of Sligo" },
                    { "cde03e36-e5db-4ad5-8e5c-ba3912c02ca3", "United Kingdom", "8-10283912", "Rotary Club of Colwyn Bay" },
                    { "cdef7a4c-83b0-4d72-9788-5b1f17ef53ed", "United Kingdom", "8-10279354", "Rotary Club of Brampton & Longtown" },
                    { "cdf03904-c374-4f71-9d84-8eb0b01f7aa8", "United Kingdom", "8-10248164", "Rotary Club of Gloucester" },
                    { "ce312fd4-157f-4171-9dec-72b7120daaab", "United Kingdom", "8-10287100", "Inner Wheel Club of Aberfeldy & District" },
                    { "ce444cd6-505b-4f79-a6a7-66e3f93a7a48", "United Kingdom", "8-10286730", "Rotary Club of Bristol South" },
                    { "ce5614ae-2905-47c5-aa11-8568feecc37f", "United Kingdom", "8-10284748", "Rotary Club of Cannock" },
                    { "ce5c3db5-8125-4379-9d88-85e0c6b95676", "United Kingdom", "8-10348842", "Rotary Club Of Woodhall Spa" },
                    { "ce66682f-8759-48f3-91e8-bad93e8573c2", "United Kingdom", "8-10280083", "Rotary Club of Wokingham" },
                    { "ce6ca4d1-d56f-4046-8fb1-1e8a65880e64", "United Kingdom", "8-10280153", "Rotary Club of Abergavenny" },
                    { "ce7f9bd8-6466-4370-ac52-c2a30d830cec", "United Kingdom", "8-10278356", "Rotary Club of Renfrew" },
                    { "cea43b01-f298-4eb0-b0e3-ae249fa54b54", "United Kingdom", "8-10282997", "Rotary Club of Tamworth" },
                    { "cec8e193-f2c3-4418-a34a-fa9093ee35fd", "United Kingdom", "8-10285610", "Rotary Club of Sheffield Vulcan" },
                    { "cef3eb54-752b-4a98-aa8d-2d7c92524b63", "United Kingdom", "8-10280749", "Rotary Club of Mid Argyll" },
                    { "cef53ab4-906a-401a-a8e4-4ecdde61c0de", "United Kingdom", "8-10282886", "Inner Wheel Club of Corringham Thameside" },
                    { "cf2fbcd7-9998-4cb0-9b15-237476485471", "United Kingdom", "8-10286460", "Rotary Club of Bourne" },
                    { "cf577096-de74-487a-8a4b-21b6eec0c789", "United Kingdom", "8-10276575", "Rotary Club of Newport Pagnell" },
                    { "cf62ba83-7d0b-4241-a647-f7dc14848197", "United Kingdom", "8-10286401", "Rotary Club of Port Talbot" },
                    { "cf70be28-ad85-4d83-aadf-d846274dead2", "United Kingdom", "8-10278543", "Inner Wheel Club of Saltash" },
                    { "cf7645c7-467c-4f03-a990-517aceccd415", "United Kingdom", "8-10249212", "Rotary Club of Swansea Valley" },
                    { "cf9015e8-c35d-49d4-8dd9-4d7af2d683bb", "United Kingdom", "8-10282862", "Rotary Club of Portadown" },
                    { "cf925e74-04e9-4c91-be79-6cf19b78ec44", "United Kingdom", "8-10283995", "Inner Wheel Club of Millom" },
                    { "cf9e2424-084c-42f8-b16d-7a74e33be07a", "United Kingdom", "8-10279539", "Rotary Club of Formby Squirrels" },
                    { "cfaf7954-d0d6-493e-ac30-2add2d0ad48b", "United Kingdom", "8-10287111", "Rotary Club of Langholm" },
                    { "cfb96410-46fe-4d7b-982a-f7b7993f73f5", "United Kingdom", "8-10242748", "Inner Wheel Club of Feltham" },
                    { "cfd5c492-8699-4f66-8ec2-c043d468e8c9", "United Kingdom", "8-10283864", "Rotary Club of West Wickham" },
                    { "cfdd6464-a0e7-464f-a625-7f3e3d5c8172", "United Kingdom", "8-10243130", "Inner Wheel Club of Babbacombe" },
                    { "cff83956-34ad-4381-8b1a-9cad13b0cd8b", "United Kingdom", "8-10286435", "Rotary Club Of Cork Douglas" },
                    { "d030d350-f32c-44bc-b00f-d6d9c6d97095", "United Kingdom", "8-10284760", "Rotary Club of Norwich Marchesi" },
                    { "d068da3d-8e78-4ae4-a5fc-b1081dd3ede0", "United Kingdom", "8-10280316", "Rotary Club of Westhill & District" },
                    { "d0713099-e64e-4526-91c7-df0b138847c1", "United Kingdom", "8-10247797", "Inner Wheel Club of Mold" },
                    { "d0873997-54dd-43bf-a18b-62869e403bfc", "United Kingdom", "8-10278603", "Rotary Club of Rainhill" },
                    { "d0b25a11-7a2b-4131-b4d7-d3e3a40cef6b", "United Kingdom", "8-10250679", "Inner Wheel Club of Cupar" },
                    { "d0b9acc0-b09e-4053-9ac7-d1a2666eca16", "United Kingdom", "8-10249200", "Rotary Club of Cork Bishopstown" },
                    { "d0f52848-7cbb-4c35-ba0d-77be418a2a83", "United Kingdom", "8-10282170", "Rotary Club of Leigh On Sea" },
                    { "d0fb9fd7-2d34-4c00-acf4-6169ea7b1992", "United Kingdom", "8-10251567", "Rotary Club of Coalville" },
                    { "d13ee3c4-2954-4912-bf13-fccafa4666cb", "United Kingdom", "8-10280732", "Rotary Club of Cardiff Breakfast" },
                    { "d19e89e3-404b-4bac-8192-42a2688baedd", "United Kingdom", "8-10280223", "Rotary Club of Biggar" },
                    { "d1c6cb05-f37c-4e7a-a231-8d70f2c0364d", "United Kingdom", "8-10240011", "Rotary Club of Meriden" },
                    { "d1dc0cb3-d43a-4d7d-87a0-9eb062b56696", "United Kingdom", "8-10279707", "Rotary Club of Stamford Burghley" },
                    { "d1fb2d99-bf2a-4231-a005-0ed22fcbff66", "United Kingdom", "8-10279791", "Rotary Club of Dronfield" },
                    { "d225cc73-394c-47bb-9ad0-a620143d5f6a", "United Kingdom", "8-10279424", "Rotary Club of Plymouth Mayflower" },
                    { "d26f05ba-7eff-484a-9f99-99a765f15f09", "United Kingdom", "8-10249576", "Rotary District 1240" },
                    { "d278d75f-7dd9-49a3-a84b-19f59d066b21", "United Kingdom", "8-10249256", "Rotary Club of Hucknall" },
                    { "d29e5af9-244d-4f85-b985-57c07ccc91fe", "United Kingdom", "8-10285595", "Rotary Club of Southwold and District" },
                    { "d29fc27b-15f0-4ecb-8df2-16db014dbb81", "United Kingdom", "8-10278783", "Rotary Club of Okehampton" },
                    { "d2a4d590-3845-45ac-bd86-65de0a556def", "United Kingdom", "8-10249127", "Rotary District 1080" },
                    { "d2deeb04-95e4-4673-a987-8c32040ebe80", "United Kingdom", "8-10278626", "Inner Wheel Clubs of District 4" },
                    { "d3055abf-fb77-42d7-bee1-d6d0671b1b8f", "United Kingdom", "8-10245094", "Interact Club of Canterbury Interact @ Simon Langton Girls Grammer" },
                    { "d3136a61-933f-4c12-97ae-7b8e3c904e14", "United Kingdom", "8-10286286", "Rotary Club of Whitby Endeavour" },
                    { "d317eb82-9e3a-47d7-bc47-0e9c2dc454dd", "United Kingdom", "8-10278604", "Rotary Club of Shoreham & Southwick" },
                    { "d31ae2ec-9e93-4ce1-8012-d0973f19704a", "United Kingdom", "8-10380221", "Inner Wheel Club Of Gosport" },
                    { "d31bb7ff-217b-4a7a-af2b-b4f52830618f", "United Kingdom", "8-10248285", "Inner Wheel Club of Workington Derwent" },
                    { "d3249d5e-a04a-4f71-ae3f-ded77563d6c6", "United Kingdom", "8-10251543", "Rotary Club Of Ashburton & Buckfastleigh" },
                    { "d3414cee-50e8-4cf6-8263-d29c3987a479", "United Kingdom", "8-10275236", "Rotary Club of Musselburgh" },
                    { "d3552890-079d-4ff2-8fe3-3b2276d28378", "United Kingdom", "8-10250381", "Rotary Club of East Sutherland" },
                    { "d35f12d9-1cc1-4c1c-aef4-2d3f396e4619", "United Kingdom", "8-10283731", "The Association of Inner Wheel Clubs in GB & I" },
                    { "d372c461-b620-42ba-bf72-a892440badc9", "United Kingdom", "8-10277148", "Rotary E-Club of Southern Scotland" },
                    { "d37f40df-2925-4775-a68a-8a3f2a185285", "United Kingdom", "8-10282650", "Rotary Club of Conwy" },
                    { "d387a2d4-ffef-4d62-928b-3954aac425ac", "United Kingdom", "8-10246610", "Rotary Club of Llangefni" },
                    { "d3b0c12d-aeba-4316-9734-e2855813dbdc", "United Kingdom", "8-10240062", "Rotary Club of Downham Market" },
                    { "d3b29fe4-b2d2-4332-b227-f4756d513cc2", "United Kingdom", "8-10259938", "Inner Wheel Club of Cambridge" },
                    { "d3c5ea1b-879c-4ff5-9e3b-e49d2271c0e6", "United Kingdom", "8-10279743", "Rotary Club of Llangollen Dee Valley" },
                    { "d3f1de82-1e87-43f7-9b35-e822cde44d4f", "United Kingdom", "8-10282962", "Rotary Club of Llantwit Major" },
                    { "d3fd2744-30ad-498d-98f9-c8f54b88a761", "United Kingdom", "8-10349084", "Rotary Club Of Burford And Kingham" },
                    { "d4049880-d8a5-42de-bd9a-e688ecb0dda0", "United Kingdom", "8-10251160", "Rotary Club of Whickham" },
                    { "d43fd956-60f7-4efa-85d7-651ac78e7abb", "United Kingdom", "8-10285724", "Rotary Club of Northampton Becket" },
                    { "d4415cba-660b-457e-838a-02d86982f087", "United Kingdom", "8-10238760", "Rotary Club of Coatbridge, Airdrie and Monklands" },
                    { "d455352e-742c-481d-b5b1-0075346b0c52", "United Kingdom", "8-10280248", "Rotary Club of Kimbolton Castle" },
                    { "d455450c-f620-4cd4-8697-5c944eb8f152", "United Kingdom", "8-10282851", "Rotary Club of Abbeydale" },
                    { "d45f2d70-5c29-4908-85c1-561972399b1d", "United Kingdom", "8-10278197", "Rotary Club of Durham" },
                    { "d480bc53-c57d-4091-af11-950d0bd72fb1", "United Kingdom", "8-10277352", "Rotary Club of Leigh" },
                    { "d495b9c2-1e3a-4ccf-b8af-62c61d3c7401", "United Kingdom", "8-10279350", "Rotary Club of Royal Wootton Bassett Town" },
                    { "d4968982-ca70-462d-80c6-c1f87b710fdd", "United Kingdom", "8-10281144", "Inner Wheel Club of Stratford-Upon-Avon" },
                    { "d4f63ab0-9d67-4504-9bb6-9541e543ef70", "United Kingdom", "8-10277103", "Rotary Club of Boston" },
                    { "d51b5874-6bdb-4218-9e36-816426b6a00c", "United Kingdom", "8-10243198", "Rotary Club of Hexham" },
                    { "d53aad5c-1a49-4819-a9b1-4e67b33186ea", "United Kingdom", "8-10280363", "Inner Wheel Club of Alsager" },
                    { "d5495854-3f8d-4440-976c-623f37d739f4", "United Kingdom", "8-10273510", "Interact Club of Blackwood Comprehensive School" },
                    { "d60b2108-39f7-4679-b431-e8bd62e6b077", "United Kingdom", "8-10282406", "Inner Wheel Club of Shirley" },
                    { "d634081f-103d-461c-8dd7-31303b076003", "United Kingdom", "8-10280612", "Rotary Club of Birmingham" },
                    { "d65aea96-2e67-45fe-83e8-eb60119eddd8", "United Kingdom", "8-10283610", "Rotary Club of Stonehouse" },
                    { "d67a89ea-9f29-49b3-86f7-1988c63dfb76", "United Kingdom", "8-10245282", "Rotary Club of Brynmawr" },
                    { "d67b86b9-43d5-4f28-bb8e-5b290a1e737e", "United Kingdom", "8-10249077", "Rotary Club of Liskeard & Looe" },
                    { "d67c2e05-eea6-42da-8be3-264ee269b272", "United Kingdom", "8-10278499", "Rotary Club of Bookham & Horsley" },
                    { "d6914658-c856-4bf2-b191-4d32418c73d0", "United Kingdom", "8-10273385", "Rotary Club of Cowbridge" },
                    { "d6961ed5-4964-45af-af80-f6243a058fb9", "United Kingdom", "8-10280082", "Rotary Club of Welshpool" },
                    { "d6b5726c-b07c-4234-9bf3-fdf2fe76672c", "United Kingdom", "8-10278270", "Rotary Club of Crewkerne" },
                    { "d6c96dc9-ee01-4573-94f5-134c88e0a0c5", "United Kingdom", "8-10284691", "Rotary Club of Scunthorpe Pentagon" },
                    { "d6cb97a4-2863-43c6-936f-76ac4a95aa56", "United Kingdom", "8-10283598", "Rotary Club of Brecon" },
                    { "d6e8ca8f-89cb-48f1-a2e5-004ee1194789", "United Kingdom", "8-10279749", "Inner Wheel Club of Thurso" },
                    { "d715c6c6-9b17-4ef8-aab9-f3095424522c", "United Kingdom", "8-10282911", "Rotary Club of Ambleside Kirkstone" },
                    { "d71a0c82-260e-409e-961b-eae7c39b4fef", "United Kingdom", "8-10283649", "Rotary Club Of Faringdon & The White Horse" },
                    { "d7257427-3700-458f-97b3-10c59a116075", "United Kingdom", "8-10243161", "Rotary Club of Gryffe Valley" },
                    { "d729f514-95f1-4a1d-b6ab-6c3a46154927", "United Kingdom", "8-10284754", "Rotary Club of Witham" },
                    { "d7378ca5-739a-4bd6-a766-210cbc57162a", "United Kingdom", "8-10242807", "Rotary Club of Naas" },
                    { "d748bd61-cf9d-4c5a-8024-aec10589ca86", "United Kingdom", "8-10282605", "Inner Wheel Club of Long Eaton" },
                    { "d7537b3f-fc44-405f-abcf-4515a2ae17c3", "United Kingdom", "8-10345337", "Didcot Interact Club" },
                    { "d757ba2c-bfcf-40ac-84af-b404b62ed297", "United Kingdom", "8-10258994", "Rotary Club of Seaford Martello" },
                    { "d759f8fc-de28-4f93-9fcb-1c67f016be3e", "United Kingdom", "8-10278053", "Rotary Club of Lichfield" },
                    { "d77c2d47-9654-42ba-9096-545a1ea74fd7", "United Kingdom", "8-10279277", "Inner Wheel Club of Helston-Lizard" },
                    { "d79b4dac-9bd8-48eb-adb5-5867e75392e8", "United Kingdom", "8-10248754", "Rotary Club of Carlisle" },
                    { "d7ae4505-5aa5-4929-9522-7f8bac927db0", "United Kingdom", "8-10238603", "Rotary Club of Burnham-on-Sea" },
                    { "d7db8448-3cd1-45ec-a920-5e946b40d46b", "United Kingdom", "8-10277309", "Rotary Club of Sutton-in-Ashfield" },
                    { "d7f37e03-f6c0-430a-b50c-f3e0c25ede83", "United Kingdom", "8-10283802", "Rotary Club of Halesowen & Rowley Regis" },
                    { "d808f832-89a0-4e66-a278-c3b7398ca597", "United Kingdom", "8-10283808", "Rotary Club of Gillingham, Kent" },
                    { "d885e297-7587-47d5-bcec-c4bbf354e2eb", "United Kingdom", "8-10281378", "Rotary Club of Upper Eden" },
                    { "d8876af6-2454-45b9-a3f4-139bc13b5862", "United Kingdom", "8-10279094", "Rotary Club of Edinburgh" },
                    { "d889d6cd-91c0-4ddd-97cd-d9f62fd24f96", "United Kingdom", "8-10264289", "Rotary Club of Cirencester" },
                    { "d88bb5ed-c616-47b2-a4ef-5c0c0f037f77", "United Kingdom", "8-10282841", "Rotary Club of Milton Keynes Grand Union" },
                    { "d8a34ffb-1de8-45d9-9b4b-bf6338b5f0bd", "United Kingdom", "8-10286950", "Rotary Club of Dumfries" },
                    { "d8fd41b3-bee3-476e-a8bf-ddf0af96365b", "United Kingdom", "8-10282838", "Rotary Club of New Malden" },
                    { "d90af66c-4e9e-490d-90e8-15dc4f66fb21", "United Kingdom", "8-10282659", "Rotary Club of Radcliffe" },
                    { "d915b28b-0817-45a3-bec5-63c5ce02f310", "United Kingdom", "8-10239322", "Inner Wheel Club of Isleworth" },
                    { "d9165228-c796-4ca3-9f4f-59781d6ffd81", "United Kingdom", "8-10265067", "Rotary Club of Derby Mercia" },
                    { "d91c3fad-b8b6-4dad-9600-f6cc38318c57", "United Kingdom", "8-10278507", "Rotary District 1040" },
                    { "d97064f7-5ecd-4e70-a7df-ef7accc492b6", "United Kingdom", "8-10241437", "Rotary Club of Otley" },
                    { "d9b4bdc9-e051-439d-900c-5cdf098a7117", "United Kingdom", "8-10277560", "Rotary Club of Hythe" },
                    { "d9f0c26c-89df-4bac-a70b-5e6eea95e0f7", "United Kingdom", "8-10281273", "Rotary Club of Sussex Vale" },
                    { "d9f17938-358b-47e4-a304-28b1e1c71768", "United Kingdom", "8-10286500", "Rotary Club of Rugby Saturday Breakfast" },
                    { "d9f6f0f7-6488-4b7d-b48b-17782cb679fe", "United Kingdom", "8-10282768", "Rotary Club of Rochdale" },
                    { "da33b831-16b4-439d-ac88-e0fb4db866ee", "United Kingdom", "8-10281269", "Rotary Club of Brixham" },
                    { "da472dac-b12e-46c0-b147-3ca3afe7cc20", "United Kingdom", "8-10278542", "Rotary Club Of Rushen & Western Mann" },
                    { "da521b48-59c1-429b-9c64-676b10429530", "United Kingdom", "8-10285958", "Rotary Club of Poynton & District" },
                    { "da91f0ce-92e5-41f9-8066-7cb19b0e66e8", "United Kingdom", "8-10277033", "Inner Wheel Club of Bideford" },
                    { "dacdeaf3-b7f1-4a87-880c-75c051ca3fb7", "United Kingdom", "8-10286312", "Rotary Club of Rutland" },
                    { "dadf3a7e-b0c6-4082-8234-22d175765d5a", "United Kingdom", "8-10281204", "Rotary Club of Mirfield" },
                    { "daeeadc3-9acd-4a33-ab29-65315349075a", "United Kingdom", "8-10283687", "Rotary Club of Ramsbottom" },
                    { "db02452a-a6fd-428c-bb82-6d8945727933", "United Kingdom", "8-10251421", "Inner Wheel District 10" },
                    { "db9bf11f-080d-41ce-9bf4-8d4b54b43e2a", "United Kingdom", "8-10249417", "Inner Wheel Club of Wrexham" },
                    { "db9e3472-cac3-4adb-955a-a01f7bd5ab5d", "United Kingdom", "8-10285570", "Rotary Club of Sleaford Kesteven" },
                    { "dba41a9f-0ddf-4f09-904d-7ecdd4937329", "United Kingdom", "8-10361052", "Inner Wheel Of Chipping Norton" },
                    { "dbaa7af2-72a5-4bb5-816e-17e9437ee21a", "United Kingdom", "8-10284051", "Inner Wheel Club of Dorchester" },
                    { "dbc83ba2-b292-412b-a583-9cd583984816", "United Kingdom", "8-10286338", "Inner Wheel Club of Brentwood" },
                    { "dbe6ea1c-0219-4c58-b0a9-2bc2ca863a0a", "United Kingdom", "8-10287087", "Rotary Club of Ascot" },
                    { "dc25fbe9-15ab-4971-ad20-0b70bdb0517c", "United Kingdom", "8-10278519", "Inner Wheel Club of Padstow" },
                    { "dccb06ac-ca1f-4bdb-a82e-5981a841ce3f", "United Kingdom", "8-10242782", "Rotary Club of Maghull & Aughton" },
                    { "dcdf91a1-e7ec-4ace-b235-345f71fac1cf", "United Kingdom", "8-10278181", "Interact Club of Barnard Case (Teesdale School)" },
                    { "dd0a7472-d11b-4f6c-8675-6b9beca36c74", "United Kingdom", "8-10282627", "Rotary Club of Chippenham" },
                    { "dd25b0cd-c6b8-44e4-abd1-125442a1ad40", "United Kingdom", "8-10249438", "Rotary Club of Preston Guild" },
                    { "dd3364ba-8b14-40c1-a23a-d7f8d879c63e", "United Kingdom", "8-10248140", "Rotary Club of Whitley Bay" },
                    { "dd9118ff-0ba8-49a6-b31d-f65bfc15217f", "United Kingdom", "8-10264194", "Rotary Club of West Bromwich" },
                    { "dda0f4c5-b273-4ad8-aa7e-ad2856abfb29", "United Kingdom", "8-10282634", "Inner Wheel Club of Falmouth" },
                    { "ddfe7fad-5f64-4ec1-a10a-7e41e73ae7f8", "United Kingdom", "8-10239491", "Rotary Club of Lowestoft South" },
                    { "de251fdf-ad8f-48b8-9c75-182b4c706c8b", "United Kingdom", "8-10249603", "Inner Wheel Club of Wickford" },
                    { "de9a84a6-dd30-4aa7-b5ea-3c47beb707b4", "United Kingdom", "8-10278921", "Rotary Club of Linlithgow & Bo'Ness" },
                    { "dec2013b-ceb5-462a-8967-6147a91a51cc", "United Kingdom", "8-10283702", "Inner Wheel Club of Felixstowe" },
                    { "ded6f0a2-937c-437b-b459-fcbdf42403ab", "United Kingdom", "8-10277110", "Rotary Club of Isle of Thanet Sunrise" },
                    { "df301082-1f2b-4c44-8574-0e2b4937126a", "United Kingdom", "8-10238790", "Rotary Club of Highdown" },
                    { "df5afdcb-2def-4265-9fe8-4f8c2b96b5a7", "United Kingdom", "8-10248877", "Rotary Club of Birmingham Breakfast" },
                    { "df687c73-9b24-4019-80f3-d52fe4ed8111", "United Kingdom", "8-10249448", "Inner Wheel Club of Ballymena" },
                    { "df701b3e-84bd-4de5-9eab-026e2643cdd8", "United Kingdom", "8-10280273", "Rotary Club of Glanmire & District" },
                    { "dfb33959-c20a-4170-a91a-0f643b530a6d", "United Kingdom", "8-10285541", "Rotary District 1010" },
                    { "dfb38a5f-a9ac-4049-a785-47060d8f0754", "United Kingdom", "8-10258975", "Rotary Club of Blackpool Sunrise" },
                    { "dfcc8abb-ccb7-4286-ab4a-3701eaf0e5fa", "United Kingdom", "8-10286409", "Inner Wheel Club Of Romsey Test" },
                    { "dfd788ae-0a0a-4775-ac6d-403a92df257e", "United Kingdom", "8-10249128", "Rotary Club of Dunoon" },
                    { "e05d3ca5-d9ab-4c8c-838c-957444b6a3ce", "United Kingdom", "8-10243221", "Inner Wheel Club of Dereham" },
                    { "e095f74e-a82b-4763-8ea1-3c47903b30fc", "United Kingdom", "8-10286527", "Rotary Club of Wrekin, The" },
                    { "e0a8fba2-844d-46f5-9d2e-18445a46ee86", "United Kingdom", "8-10278421", "Rotary Club of Wilmslow Dean" },
                    { "e0b2538f-dfdc-4072-92ac-8bf900aecddd", "United Kingdom", "8-10239010", "Rotary Club Of Havering" },
                    { "e0c32299-3d48-4de0-a8c4-d0c29bd68326", "United Kingdom", "8-10283435", "Rotary Club of Braunton" },
                    { "e0d7d4e5-3b88-46fc-aaa6-30e94ced88fb", "United Kingdom", "8-10282416", "Rotary Club of Edmonton" },
                    { "e0dbdfc2-720c-4637-ae2a-63c3b4275d9d", "United Kingdom", "8-10280235", "Inner Wheel District 22" },
                    { "e11477c0-27bd-4a0b-aa04-fc6d078c3e72", "United Kingdom", "8-10277776", "Rotary Club of Bridge of Allan & Dunblane" },
                    { "e12671ca-1799-4216-a130-6c9d011bf997", "United Kingdom", "8-10284690", "Rotary Club of Keighley" },
                    { "e1896525-79f7-43dc-88bb-246078582b2c", "United Kingdom", "8-10252097", "Inner Wheel Club of Carnforth" },
                    { "e1906019-1f5e-4073-a1de-dff003d10acc", "United Kingdom", "8-10276015", "Rotary Club of Gravesend & Meopham" },
                    { "e1924a37-99c4-4e44-b76b-b291878d8a75", "United Kingdom", "8-10283749", "Rotary Club of Stonehaven" },
                    { "e1b0ff6a-5369-42f1-818d-84f926e4889c", "United Kingdom", "8-10245066", "Rotary Club of Stirling" },
                    { "e1c338bf-0c8c-409f-a321-3a4a8f08f3ad", "United Kingdom", "8-10277142", "Rotary Club of Thirsk" },
                    { "e1fa5896-3167-4c9d-bda5-c7222cc27607", "United Kingdom", "8-10277758", "Rotary Club of Cheltenham North" },
                    { "e2242acb-0578-4bd8-bdae-4e2922cbd190", "United Kingdom", "8-10243131", "Rotary Club of South Molton" },
                    { "e232526f-a1e5-46d4-9bd7-f5ae79dc397b", "United Kingdom", "8-10287126", "Rotary Club of Spilsby" },
                    { "e2626684-22fb-4cd6-9e0e-f94a1fef6b15", "United Kingdom", "8-10281798", "Inner Wheel Club of Watton" },
                    { "e26d7701-094f-4891-9b9b-89b31d1a130b", "United Kingdom", "8-10280092", "Rotary Club of Faversham" },
                    { "e28321f3-66b4-4450-981c-cb56f8a3f612", "United Kingdom", "8-10281246", "Rotary Club of Sandown" },
                    { "e29d0fd2-8c7c-44c5-bfed-1949ab920a8f", "United Kingdom", "8-10281051", "Rotary Club of Fishponds & Downend, Bristol" },
                    { "e2a506e6-514c-4364-80d7-f72819051b9f", "United Kingdom", "8-10250831", "Inner Wheel Club of Worksop" },
                    { "e2ab8365-5faa-424e-a7e5-719d863919d8", "United Kingdom", "8-10249104", "Rotary Club of Leytonstone and Woodford" },
                    { "e2e13f83-78e4-45fd-90f2-285916d5cee4", "United Kingdom", "8-10276014", "Rotary Club of Dukinfield & Stalybridge" },
                    { "e312ba51-895a-4bb6-a37d-e8539e0c9744", "United Kingdom", "8-10279770", "Rotary Club of Ashford, Kent" },
                    { "e34a1d8d-1ab4-45a4-8b42-2f2616957fb7", "United Kingdom", "8-10239368", "Rotary Club of Coleraine" },
                    { "e380b34b-768f-4aef-8a2e-2456e881296d", "United Kingdom", "8-10278095", "Inner Wheel Club of Newton & District" },
                    { "e3881523-0362-4399-ab00-25595ad14909", "United Kingdom", "8-10278171", "Rotary Club of Keswick" },
                    { "e388d1a1-3370-4676-a674-e9cefc827bad", "United Kingdom", "8-10249299", "Rotary Club of Framlingham" },
                    { "e39fc506-8696-44ee-a515-f0a0caddd7c0", "United Kingdom", "8-10280378", "Rotary Club of Wolstanton" },
                    { "e3b69f00-bf36-4fcd-a61e-e3aaf6b7ddd1", "United Kingdom", "8-10277072", "Rotary Club of Seaford" },
                    { "e418f96a-9fb0-47f8-a06e-a2abc768d33a", "United Kingdom", "8-10279384", "Rotary Club of Horwich" },
                    { "e432cd36-812a-429e-9cae-4498456fa976", "United Kingdom", "8-10246977", "Rotary Club of Leeds White Rose" },
                    { "e441ce3e-eb54-4967-89d3-0c87542139df", "United Kingdom", "8-10283659", "Inner Wheel Club of Kinross & District" },
                    { "e44b66b7-f7ce-4620-949c-cf90a3541124", "United Kingdom", "8-10285608", "Rotary Club of Sedgley & Wombourne" },
                    { "e468ccdc-897a-4d30-bb87-5f216fd1a973", "United Kingdom", "8-10285737", "Rotary Club of Edgware & Stanmore" },
                    { "e469b1b9-6fa8-42b9-b726-bbf8280aa3f9", "United Kingdom", "8-10268914", "Rotary Club of Mallow" },
                    { "e4740a39-7f70-4132-a9a4-79d45ce44c0e", "United Kingdom", "8-10281983", "Rotary Club of Hinckley" },
                    { "e478f7b1-5097-43c6-9c2a-57ef8904c6bf", "United Kingdom", "8-10285870", "Rotary Club of Whitby & District" },
                    { "e4896c43-d9cb-4421-a934-7f3469e7a38a", "United Kingdom", "8-10282744", "Rotary Club of Wakefield Chantry" },
                    { "e499e7c7-19c8-40e6-bdac-68c1f6396e9f", "United Kingdom", "8-10279211", "Rotary Club of Grantham" },
                    { "e4bd56cb-f866-47f7-a43d-041abb89a614", "United Kingdom", "8-10283728", "Rotary Club of Kew Gardens" },
                    { "e4e47769-2c5d-458a-af08-d92f2a5a1af8", "United Kingdom", "8-10286431", "Rotary Club of Osgoldcross & Elmet" },
                    { "e4eafba6-7f4e-4160-9fb7-50e191131e40", "United Kingdom", "8-10285544", "Rotary Club of West Fife" },
                    { "e4eccd88-b433-4a17-81c2-7cdd657e8895", "United Kingdom", "8-10283449", "Inner Wheel Club of West Woodspring" },
                    { "e51b2d97-c013-4560-afeb-bac5bb91e795", "United Kingdom", "8-10279752", "Rotary Club of Darlington" },
                    { "e57604a9-b99b-4c7d-8d89-845800409170", "United Kingdom", "8-10275235", "Rotary Club of Ipswich Orwell" },
                    { "e59de6cf-04f1-40f5-bd00-38e0904b7e6c", "United Kingdom", "8-10244727", "Inner Wheel Club of Camborne" },
                    { "e5af8c51-cde6-487f-a2ff-c2f98210c073", "United Kingdom", "8-10243546", "Interact Club of Wirral Grammar School For Girls" },
                    { "e5c381b4-4153-439b-a138-b5c1c02389ee", "United Kingdom", "8-10252049", "Rotary Club of Malling" },
                    { "e5dce8ba-f6f6-480b-b86d-021a845976fe", "United Kingdom", "8-10240934", "Rotary Club of Alcester & Bidford" },
                    { "e62881dc-a0ac-4c29-843d-79662993d2bd", "United Kingdom", "8-10283608", "Rotary Club of Brightlingsea & District" },
                    { "e641c78a-9644-4275-9b16-a5051d6bc0b6", "United Kingdom", "8-10280795", "Rotary Club of Redditch Kingfisher" },
                    { "e64ccf07-37a1-424b-b574-b7ba00ef86f8", "United Kingdom", "8-10280407", "Inner Wheel Club of Tettenhall" },
                    { "e659f46c-7bfc-4a87-9bfe-a0554b245758", "United Kingdom", "8-10277473", "Inner Wheel Club of Bourne" },
                    { "e661f0a7-4114-4e9b-a8b9-822a070623bb", "United Kingdom", "8-10280253", "Rotary Club of Holderness" },
                    { "e662dda2-caa7-42e8-a03d-277c5730da8a", "United Kingdom", "8-10280447", "Rotary Club of Normanton" },
                    { "e6641c18-ce7b-4e1f-9295-b1c0c48ed39b", "United Kingdom", "8-10277863", "Rotary Club of Solihull" },
                    { "e6b98c67-81cd-4ec8-a707-34cc902de6e0", "United Kingdom", "8-10281138", "Interact Club of Bexley" },
                    { "e6c6bf3d-a165-435f-8fbb-c13950e07764", "United Kingdom", "8-10281867", "Rotary Club of Ealing, Hanwell and Northfields" },
                    { "e6ce2a9d-afb6-485e-a128-41c923715a1f", "United Kingdom", "8-10280516", "Inner Wheel Club of Stowmarket" },
                    { "e6d19ed3-1283-4ca6-a6f4-276285aa19ff", "United Kingdom", "8-10251564", "Rotary Club of Dumfries Devorgilla" },
                    { "e6f4b8ad-e733-40ad-a23c-b5e873c2ac6f", "United Kingdom", "8-10282682", "Rotary Club of Chelmsford" },
                    { "e70252d7-d776-4cda-a3f8-1239c1a9606f", "United Kingdom", "8-10285711", "Rotary Club of Bacup" },
                    { "e73bc942-d183-4aad-ab0b-f4b8f2b8f390", "United Kingdom", "8-10284749", "Rotary Club of Hamilton" },
                    { "e75b9c59-9510-41d5-a084-8cf65fe7ceca", "United Kingdom", "8-10252070", "Inner Wheel Club of Croydon" },
                    { "e77eb645-19f1-470e-a3d9-b469ab030416", "United Kingdom", "8-10252105", "Inner Wheel Club of Abbeydale" },
                    { "e7a1bc5c-d9b4-4554-a033-a530f1ff8de7", "United Kingdom", "8-10248798", "Interact Club of Towers School" },
                    { "e7b0a763-2d8a-4695-a96b-012b7fd83984", "United Kingdom", "8-10247143", "Rotary Club of Bristol" },
                    { "e7e14a57-6d7f-4de9-bd51-3def45cce7df", "United Kingdom", "8-10286793", "Inner Wheel Club of Denby Dale" },
                    { "e7e21963-d66b-421b-abb5-edb76c7cc549", "United Kingdom", "8-10278348", "Rotary Club of Huddersfield" },
                    { "e7f1dcd8-c3e8-4e0f-b40a-0a22a53a1418", "United Kingdom", "8-10368813", "Rotary Club Of Angmering South Downs" },
                    { "e7f74674-716c-45ca-ab82-fc72c13099d8", "United Kingdom", "8-10277626", "Rotary Club of Barry" },
                    { "e806bbff-0b12-495f-8e14-67ad22402c16", "United Kingdom", "8-10256358", "Rotary Club of Burntisland & Kinghorn" },
                    { "e81883dd-d23a-45a1-8f75-d2e6e26cc58d", "United Kingdom", "8-10258996", "Rotary Club of Cheltenham Cleeve Vale" },
                    { "e81c04e4-47be-43f7-bf78-c0e076059b21", "United Kingdom", "8-10277403", "Inner Wheel Club of Brixham" },
                    { "e841a5cf-5603-49ab-9a37-9a05e55a5fd8", "United Kingdom", "8-10281214", "Inner Wheel Club of Doncaster St Leger" },
                    { "e85103ed-4d8a-4316-b2d6-77907c6357ed", "United Kingdom", "8-10278509", "Rotary Club of Accrington" },
                    { "e85ad111-7c1f-48d8-bdb5-58e33a96d187", "United Kingdom", "8-10286499", "Rotary Club of Ulverston" },
                    { "e87c3f75-d1fd-442e-828d-a852358e72db", "United Kingdom", "8-10279430", "Rotary Club of Lisburn" },
                    { "e8865c45-152d-45be-96dc-c0d59b847ed3", "United Kingdom", "8-10279197", "Inner Wheel Club of Grantham" },
                    { "e88b9e40-fd8b-47e3-a81e-6f56335d6d01", "United Kingdom", "8-10246027", "Rotary Club of Perranzabuloe" },
                    { "e8c18b5a-8a0e-462f-ab5d-f9302710be86", "United Kingdom", "8-10275239", "Rotary Club of Epworth & Isle Of Axholme" },
                    { "e8c96be0-70d9-4d2b-bb95-f06df0a099da", "United Kingdom", "8-10277116", "Inner Wheel Club of Slough" },
                    { "e8f6c333-98da-4a7d-9850-ed09413ddccd", "United Kingdom", "8-10243443", "Rotary Club of Lymm" },
                    { "e8fbc89b-3402-4b62-9697-1270212ad620", "United Kingdom", "8-10287074", "Rotary Club of Reading" },
                    { "e931a81f-1d10-4144-8c6a-65d72981a2b8", "United Kingdom", "8-10278078", "Rotary Club Of Hereford City" },
                    { "e96f244f-28f4-4dfc-817d-81d782623c4f", "United Kingdom", "8-10281158", "Rotary Club Of Wrexham Yale" },
                    { "e970e200-53fe-4712-93fa-edb484f8739b", "United Kingdom", "8-10280098", "Rotary Club of Chelmsford Rivermead" },
                    { "e97f0810-a355-46e8-892f-dab528666a48", "United Kingdom", "8-10281348", "Rotary Club Of Preston Torbay" },
                    { "e98bdd2f-bc15-4303-bcdf-922566913791", "United Kingdom", "8-10278575", "Rotary Club Of Maidstone Dawn Patrol" },
                    { "e9a505c7-77c8-4c83-914a-15104425fb32", "United Kingdom", "8-10250031", "Rotary Club of Chipping Campden" },
                    { "e9d993ac-03fa-423d-ad71-242a57930bfd", "United Kingdom", "8-10282901", "Rotary Club of Mounts Bay" },
                    { "ea1b682a-0760-472e-aebc-5427f50d66d5", "United Kingdom", "8-10282850", "Inner Wheel Club of Kendal South Westmorland" },
                    { "ea1c0ffa-c861-4259-a1e6-fd00013a426f", "United Kingdom", "8-10264193", "Rotary Club of Trowbridge Wessex Mead" },
                    { "ea20bb28-02db-4e30-af79-0fc7fceb4cec", "United Kingdom", "8-10286293", "Rotary Club of Greenwich" },
                    { "ea30fd93-c200-45d3-88fa-3826ae71cfeb", "United Kingdom", "8-10260530", "Rotaract Club of Previous Members of Edgbaston" },
                    { "ea39e1fe-90da-43c9-abc4-2d67ef0c0818", "United Kingdom", "8-10241420", "Rotary Club of Reepham & District" },
                    { "ea3f8dc2-c1b4-4c45-9b4e-8354c1a8682e", "United Kingdom", "8-10282875", "Rotary Club Of Ashby Hastings" },
                    { "ea4cd30c-9f3b-48fd-ad41-63829200a442", "United Kingdom", "8-10283648", "Inner Wheel Club of Market Drayton" },
                    { "ea509bd9-5bfc-4bc0-b68b-b2dbd45e3a27", "United Kingdom", "8-10250921", "Inner Wheel Club of Thornton-Cleveleys" },
                    { "ea599d09-9695-460a-9ea3-d547ffd7a450", "United Kingdom", "8-10280243", "Rotary Club of Cleadon & District" },
                    { "ea74c4c7-6841-42f1-af96-5a688769b003", "United Kingdom", "8-10249253", "Rotary Club of Pantiles Tunbridge Wells" },
                    { "ea7bda02-9a4d-40d0-b860-413746f59087", "United Kingdom", "8-10284069", "Rotaract Club of Tyneside" },
                    { "ea8ded98-9f58-455e-834c-a5a2971b978f", "United Kingdom", "8-10278492", "Rotary Club of Southsea Castle" },
                    { "ea9d0ff9-e19e-435a-aa63-542a5bad5d0d", "United Kingdom", "8-10265966", "Rotary Club of Teesside West" },
                    { "eaa5e1d2-b3dd-4f95-bf89-df471086bb1d", "United Kingdom", "8-10282118", "Inner Wheel Club of Dover" },
                    { "eac85aa0-5fc8-4ed6-bba0-517f76fa4473", "United Kingdom", "8-10249247", "Rotary Club of Kennington" },
                    { "eaf423f1-6a66-4d0f-a0b2-a9f440bef592", "United Kingdom", "8-10252652", "Rotary Club of Saltburn-by-the-Sea" },
                    { "eb27556c-1be2-4bf7-b2ca-4c51a040e4a6", "United Kingdom", "8-10282656", "Inner Wheel Club of Reading" },
                    { "eb27618d-dcb5-4bbc-a315-159f7359d7b9", "United Kingdom", "8-10279171", "Rotary District 1060" },
                    { "eb2d1e93-0c6c-48b1-8311-bf482a00172f", "United Kingdom", "8-10252046", "Rotary Club of Helensburgh" },
                    { "eb436f4d-3cb9-4eda-9c07-1f4147104369", "United Kingdom", "8-10278334", "Rotary Club of St Agnes & St Piran" },
                    { "eb499eb9-7fcb-4aa1-862c-74fd0c51e1a1", "United Kingdom", "8-10282910", "Rotary Club of Epsom" },
                    { "eb8de256-99fd-48d6-8c29-a8ca49d38aaf", "United Kingdom", "8-10283913", "Rotary Club of Kidsgrove" },
                    { "ebae9590-7e1a-40f4-b3b0-e7c0771868ea", "United Kingdom", "8-10278380", "Rotary Club of Braids" },
                    { "ebde1a11-88cd-4f70-9db2-251c457b575a", "United Kingdom", "8-10249178", "Rotary Club of Bideford" },
                    { "ebe19a2c-63c1-4707-86c0-cefff15e15cc", "United Kingdom", "8-10280572", "Rotary Club of Prestatyn" },
                    { "ebe9f481-d037-4ca9-bb50-7361da5cdcb4", "United Kingdom", "8-10252649", "Rotary Club of Ewell" },
                    { "ec1170ca-4f2f-4f2a-9995-44d37bdc0079", "United Kingdom", "8-10281488", "Rotary Club of Stranraer" },
                    { "ec17b14a-353b-435f-91ec-24df5d62d834", "United Kingdom", "8-10280780", "Rotary Club of Guernesiais" },
                    { "ec21c3df-ed1d-4ab0-8269-8f4b083576aa", "United Kingdom", "8-10281268", "Rotary Club Of Bolsover" },
                    { "ec374478-a067-4020-8fe1-e2f3e8fb9193", "United Kingdom", "8-10243699", "Rotary Club of Ormskirk" },
                    { "ec48045b-ba23-4f52-9751-ae110b1c629c", "United Kingdom", "8-10278420", "Rotary Club of Waterford" },
                    { "ec4ddcb7-01fe-41b3-bba6-b2411f20a51c", "United Kingdom", "8-10287048", "Rotary Club of Royal Leamington Spa" },
                    { "ec84c9fa-c87a-4f4f-8294-011abe6ed98b", "United Kingdom", "8-10238450", "Inner Wheel Club of Hereford Wye Valley" },
                    { "ec985db3-f315-4f20-99f8-e7956d3e6e84", "United Kingdom", "8-10281430", "Inner Wheel Club of Totnes" },
                    { "ec99f4a4-db74-4580-bb77-0d1b40eb61d2", "United Kingdom", "8-10241409", "Rotary Club of Birkenhead" },
                    { "ec9f9441-99fb-4eca-9e7c-f808a94f1a3b", "United Kingdom", "8-10250682", "Rotary Club of Christchurch" },
                    { "ecb5366a-e435-46f8-ac27-91aa8cc26a8e", "United Kingdom", "8-10249195", "Rotary Club of Woking District" },
                    { "ecb9884a-0713-450f-be3d-3b1dd8356f1e", "United Kingdom", "8-10250685", "Rotary Club of Blackwood" },
                    { "ed053540-e5fa-4689-aef4-c00cd008d620", "United Kingdom", "8-10279087", "Rotary Club of Weymouth" },
                    { "ed29b4d1-57bb-432b-97b0-ad727d9797a3", "United Kingdom", "8-10278241", "Rotary Club of Harrogate Brigantes" },
                    { "ed37e052-1df9-4b39-b54d-c41ca8d37cd4", "United Kingdom", "8-10240520", "Rotaract Club of Ealing" },
                    { "ed3b6083-34f5-4075-8a8e-95acbe72c9c9", "United Kingdom", "8-10278094", "Inner Wheel Club of Knowle & Dorridge" },
                    { "ed4f1a23-ecf8-4efa-9daa-501f68ef70df", "United Kingdom", "8-10285726", "Inner Wheel Club of St. Helens" },
                    { "ed77c8d5-3697-4d79-a59e-f8f41dc1eaa2", "United Kingdom", "8-10282630", "Rotary Club of Lutterworth" },
                    { "ed849b06-ad21-4924-a453-15c7ab30bdad", "United Kingdom", "8-10280773", "Rotary Club of Bangor Gwynedd" },
                    { "ed976a77-66a8-477b-bf31-b94ce832cb6a", "United Kingdom", "8-10283521", "Rotary Club of Surbiton" },
                    { "edaccb8e-4cd2-4f57-acc9-bd729429ffef", "United Kingdom", "8-10279244", "Rotary Club Of Winchester" },
                    { "edd55afd-cba1-49db-ad93-0954da93c9e8", "United Kingdom", "8-10282745", "Rotary Club of Woodbridge" },
                    { "edebc8e9-8a66-4865-bdb9-0444035177b5", "United Kingdom", "8-10250364", "Rotary Club of Edgbaston Convention" },
                    { "edf1be8f-98e2-41e3-bab7-d187ee260706", "United Kingdom", "8-10276725", "Rotary Club of Oadby" },
                    { "ee0672af-86c2-471a-9d15-c70092d1c083", "United Kingdom", "8-10282352", "Rotary Club of Blaby Meridian" },
                    { "ee12cd5d-af19-4f88-a1d2-964d7f779693", "United Kingdom", "8-10282796", "Inner Wheel Club of Colne Noyna" },
                    { "ee1a5f6e-0353-40d0-8300-ea0ec9841ecd", "United Kingdom", "8-10247257", "Rotary Club of Gateshead-Upon-Tyne" },
                    { "ee39774f-037e-471a-b887-7c76c0161417", "United Kingdom", "8-10279782", "Rotary Club of Telford Centre" },
                    { "ee65864b-5ba3-4695-809f-6910bde8a7b0", "United Kingdom", "8-10239326", "Inner Wheel District 11" },
                    { "ee7b70bc-7a4d-4f03-a5fa-803a686503ac", "United Kingdom", "8-10283883", "Rotary Club of Cranleigh" },
                    { "eeb7e98b-d678-4729-bd8b-f42948727e84", "United Kingdom", "8-10242329", "Rotary Club of Haverhill & District" },
                    { "eee2f078-da23-43bd-b4d3-6e5bd4a38c07", "United Kingdom", "8-10277427", "Rotary Club of Hatfield" },
                    { "eefc2640-c372-4743-a2d6-edf64c11f975", "United Kingdom", "8-10280724", "Rotary Club of Teddington & The Hamptons" },
                    { "ef18c6cd-a1c4-47e4-99bc-88fd6fc40397", "United Kingdom", "8-10242677", "Inner Wheel Club of Kendal" },
                    { "ef574937-29a0-4f45-bd17-86d86a5941fa", "United Kingdom", "8-10286491", "Rotary Club of Luton North" },
                    { "ef617524-c6ee-4902-a024-1f9fa652af76", "United Kingdom", "8-10283652", "Rotary Club of Odiham & Hook" },
                    { "ef6369e1-8878-41e4-8d4f-a7624e82fcf7", "United Kingdom", "8-10281224", "Rotary Club of St. Marylebone" },
                    { "ef84e55d-c21b-4513-95f1-5f59043fe5b5", "United Kingdom", "8-10246598", "Rotary Club of Leominster" },
                    { "ef95d7cc-8474-4f8c-a5d2-ebf465f88cb8", "United Kingdom", "8-10281933", "Rotary Club Of St Austell" },
                    { "efad04c0-d632-4453-acac-c435fbb86d9f", "United Kingdom", "8-10281718", "Rotary Club of Heybridge Blackwater" },
                    { "f01f5901-a7b6-49a2-b29a-338841e41455", "United Kingdom", "8-10282016", "Rotary Club of Ilkley" },
                    { "f0234ea1-cda0-402a-9e60-50fa4bb8a272", "United Kingdom", "8-10281118", "Inner Wheel Club of Wolverton" },
                    { "f02de341-15b2-45dd-ac8e-1dfb82a62dc8", "United Kingdom", "8-10252058", "Rotary Club of Dublin Central" },
                    { "f0377d55-15bc-4930-9e2f-7bd7b794fdda", "United Kingdom", "8-10277201", "Rotary Club of Pembroke" },
                    { "f0548bfb-0a89-4b25-9277-114d8fc22dcf", "United Kingdom", "8-10280026", "Rotary Club of St. Ives, Cornwall" },
                    { "f0766e19-3f60-46c4-98e9-fc68e6529ed6", "United Kingdom", "8-10238997", "Rotary Club of Auchterarder & District" },
                    { "f0932eca-a43b-426f-8064-f513fac1af74", "United Kingdom", "8-10278891", "Rotary Club of Chipping Sodbury" },
                    { "f0bbf6ae-30e7-46bb-97ce-927dbe52e4a5", "United Kingdom", "8-10256237", "Rotary Club of Darwen" },
                    { "f0c94c37-f1ea-440a-ab2b-4f6533847d6b", "United Kingdom", "8-10323621", "Inner Wheel Club Of Wanstead & Woodford" },
                    { "f115aeae-6d78-4f0d-90a4-2a1827430731", "United Kingdom", "8-10282403", "Rotary Club of Newark" },
                    { "f153f415-a589-4a2d-b2e8-f222f0fbc1a5", "United Kingdom", "8-10278337", "Rotary Club of Harlow Tye" },
                    { "f16ea8d9-9ddf-4172-aabb-f67b83d7a6bb", "United Kingdom", "8-10243607", "Rotary Club of Bognor Regis" },
                    { "f17c9875-7c17-4181-b669-1f9bf7d3a3a8", "United Kingdom", "8-10249796", "Rotaract In Great Britain and Ireland" },
                    { "f180460b-6955-4ffa-869c-7194035494a2", "United Kingdom", "8-10249316", "Rotary Club of Norwich" },
                    { "f1899ee8-e9b1-46ab-b8bc-b562b78d109b", "United Kingdom", "8-10278934", "Rotary Club of Richmond, Yorks" },
                    { "f1cf8c89-d0c5-44b0-9873-e09e80bc8ac9", "United Kingdom", "8-10371102", "Rotary Club Of Canvey Coast Satellite" },
                    { "f20727fe-7993-4433-bd3a-c37c35c7df5c", "United Kingdom", "8-10262597", "Rotary Club of Wimborne" },
                    { "f20d66bf-fbf7-4ba3-8120-95ebccccb97f", "United Kingdom", "8-10243944", "Inner Wheel Club of Wellingborough" },
                    { "f21aad4f-0eba-4e5a-a7e7-e1c0fe3e9535", "United Kingdom", "8-10249434", "Rotary Club of Ware" },
                    { "f21b2667-fcc4-41a9-b7ce-c67fb3f7de41", "United Kingdom", "8-10242504", "Rotary Club of Colwall" },
                    { "f21e2051-4621-4835-97ca-2208d5ddd7e9", "United Kingdom", "8-10251552", "Rotary Club of Falmouth" },
                    { "f22e1df7-82ae-4f2c-8161-942c0b34fcaa", "United Kingdom", "8-10283973", "Rotary Club of Ashby-De-La-Zouch" },
                    { "f2327526-5655-4118-8375-40607894b103", "United Kingdom", "8-10286841", "Inner Wheel Club of Harpenden Village" },
                    { "f2380a1f-0186-4740-9df8-326e528c2869", "United Kingdom", "8-10265077", "Rotary Club of Dunfermline" },
                    { "f241e6e3-574f-4d16-9588-321f54ecd09a", "United Kingdom", "8-10250059", "Rotaract Club of Swale" },
                    { "f257d21c-812b-4205-bc84-c5f1e4da1c55", "United Kingdom", "8-10277043", "Rotary Club of Bray" },
                    { "f279af98-4d39-492a-9e5c-4f94a699d05e", "United Kingdom", "8-10238615", "Rotary Club of Kirriemuir" },
                    { "f2836734-6d97-4ecc-82e8-99de5f38013c", "United Kingdom", "8-10241436", "Rotary Club of Amber Valley" },
                    { "f2bf2185-1f1a-4ef7-85b9-41cd578aa7a0", "United Kingdom", "8-10284081", "Rotary Club Of Truro Evolution" },
                    { "f2e99acc-8dc4-4378-8a45-669a80d7e54d", "United Kingdom", "8-10283646", "Tabernacle Chapel, Pontardawe and Interact Club of Maesydderwen School" },
                    { "f2eb2780-dd9e-4462-9dab-4c937c06ec0f", "United Kingdom", "8-10287115", "Rotary District 1150" },
                    { "f2f1ff2f-4857-4b42-946c-a24a74d9b7c7", "United Kingdom", "8-10282112", "Rotary Club of Roundhay (Leeds)" },
                    { "f311c666-883f-4afd-ab57-16cbd778976c", "United Kingdom", "8-10243922", "Rotary Club of Aberdeen" },
                    { "f31304af-ccd2-47b2-a36c-1ef35e144c2a", "United Kingdom", "8-10249872", "Rotary Club of Uttoxeter" },
                    { "f35d0ea4-8ea8-4170-8096-16c5cca37d53", "United Kingdom", "8-10256382", "Rotary Club of Diss & District" },
                    { "f36d9d4f-103c-4570-9153-dd3743f8b929", "United Kingdom", "8-10283860", "Inner Wheel Club of Spalding" },
                    { "f371440a-62e5-41e2-8fab-9c3208b4e9f6", "United Kingdom", "8-10240256", "Rotary Club of Holyhead" },
                    { "f37f331b-d6a9-4607-8544-1d2fdc26b8ee", "United Kingdom", "8-10264684", "Inner Wheel Club of Lurgan" },
                    { "f39717ff-f98e-490d-b8f5-969151a18dab", "United Kingdom", "8-10284149", "Rotary Club of Usk" },
                    { "f397363a-d231-4997-ba4e-b18e1a921762", "United Kingdom", "8-10286289", "Rotary Club of Wallington" },
                    { "f3d543c8-3cf4-4c79-8f4a-a9b6cb8755ef", "United Kingdom", "8-10277108", "Rotaract Club of Christchurch" },
                    { "f3e60e4b-1ffa-413c-ab97-f6b8fe16dea8", "United Kingdom", "8-10279400", "Rotary Club of Belfast" },
                    { "f4157e7c-bfab-41e0-a7c8-098f9f57d55c", "United Kingdom", "8-10247699", "Inner Wheel Club of Sandy & District" },
                    { "f4193040-b47f-426c-b7b8-939c9e99469b", "United Kingdom", "8-10281221", "Rotary Club of Vale Of Belvoir" },
                    { "f4b4603f-ac73-4daf-88a4-bcdc65b9cac4", "United Kingdom", "8-10280803", "Rotary Club of Clent Hills" },
                    { "f4cdd8a1-349f-4570-9554-708844d605c7", "United Kingdom", "8-10283915", "Rotary Club of Peterborough Ortons" },
                    { "f4d13126-8fd1-4762-ab7d-77f05c1484bc", "United Kingdom", "8-10285965", "Rotary Club of Haddenham and District" },
                    { "f4f94f33-6dd3-49d0-b4d6-602decebe7df", "United Kingdom", "8-10250606", "Inner Wheel Club of Stone" },
                    { "f520caf3-ac0d-4197-b06c-4710ef03f6aa", "United Kingdom", "8-10279343", "Inner Wheel Club of Perth" },
                    { "f559fbe8-ad9f-4e72-b3aa-8273dcf6d286", "United Kingdom", "8-10248868", "Rotary Club of Church & Oswaldtwistle" },
                    { "f55e79cb-da04-489a-94b1-75a847586bf6", "United Kingdom", "8-10243631", "Rotary Club of Weston-Super-Mare" },
                    { "f58aacd6-f3d7-4275-b631-70697d25254b", "United Kingdom", "8-10259000", "Rotary Club of Hedge End Breakfast" },
                    { "f58ac017-d008-40c8-b21d-83503c3d9379", "United Kingdom", "8-10277028", "Rotary Club of Southam 2000" },
                    { "f5a62bc9-9de2-4baa-a89f-46125098978d", "United Kingdom", "8-10280634", "Inner Wheel Club of Chorley Astley" },
                    { "f5a8ba17-01be-4ecb-a64c-85b6c7cf7de3", "United Kingdom", "8-10239937", "Rotary Club of Whitehaven" },
                    { "f5e81856-1220-4377-ad1b-bf57d3aac83e", "United Kingdom", "8-10284143", "Rotary Club of Bradley Stoke" },
                    { "f61f9d9a-f21f-44c7-a708-72ec1339ba99", "United Kingdom", "8-10278471", "Inner Wheel Club of Liskeard & Looe" },
                    { "f6278fcf-f47d-474d-ae1d-2e2eef65e3f9", "United Kingdom", "8-10284802", "Rotary Club of Llangollen" },
                    { "f6369080-5936-45d9-a0cf-2a650524e493", "United Kingdom", "8-10250816", "Rotary Club of Ironbridge" },
                    { "f658df0a-defc-4b4e-9055-f7932eb81442", "United Kingdom", "8-10252060", "Inner Wheel Club of Lancaster" },
                    { "f6cc2c3d-d0c0-44a7-b8d3-36486df5c0f2", "United Kingdom", "8-10278878", "Rotary Club of Kilmarnock" },
                    { "f6cd10bb-0266-494b-9548-a2ab57c44bd0", "United Kingdom", "8-10282666", "Rotary Club of Bideford Bridge" },
                    { "f6cd5c5a-b86b-4ba8-a9ee-08b98d2a4c1c", "United Kingdom", "8-10279247", "Rotary Club of Dyce" },
                    { "f6e00951-c837-4256-92db-8f4620d7a20c", "United Kingdom", "8-10251548", "Rotary Club of Cleethorpes" },
                    { "f70e9530-23e8-45d4-9444-4c7b41cef8ff", "United Kingdom", "8-10282787", "Rotary Club of Canterbury, Forest Of Blean" },
                    { "f74697fc-bf24-4574-af1a-28d8d7cbfe8e", "United Kingdom", "8-10246960", "Rotary Club of Dartford" },
                    { "f749cce7-1568-4afc-9a48-4953aec74c71", "United Kingdom", "8-10286702", "Rotary Club of Harwich & Dovercourt" },
                    { "f75e1f73-8511-46b0-9476-a148f780cc09", "United Kingdom", "8-10280544", "Rotary Club of Turton" },
                    { "f762aae3-d7a7-4482-bfc0-1ffc221f5c71", "United Kingdom", "8-10249177", "Rotary Club of Bathavon" },
                    { "f767cc2c-5a22-4cac-910c-a902c8cd698c", "United Kingdom", "8-10286733", "Rotary Club of Torquay" },
                    { "f7a9b219-5af4-4edb-ba21-abde8fb22f7e", "United Kingdom", "8-10283897", "Rotary Club of Bolton Lever" },
                    { "f7e527d2-f6c8-4fce-9987-8c05fad867a3", "United Kingdom", "8-10243153", "Inner Wheel Club of Market Bosworth" },
                    { "f8c1e80e-5432-46d3-a4f6-0c3ed82e277d", "United Kingdom", "8-10276579", "Rotary Club of Wolverhampton St. Georges" },
                    { "f8df775a-6e3d-42aa-91bb-1ff3e45b38d7", "United Kingdom", "8-10280442", "Rotary Club of West Wight" },
                    { "f90cef23-809c-4451-a8bf-45c140cb1c61", "United Kingdom", "8-10278857", "Inner Wheel Club of Camelford" },
                    { "f92e8ef6-bc6b-4740-be35-836166839fbd", "United Kingdom", "8-10248129", "Rotary Club of Kilsyth" },
                    { "f9455138-d9e5-445b-8c0a-7473925c213b", "United Kingdom", "8-10240502", "Inner Wheel Club of The Quantocks" },
                    { "f97738e2-4e92-4577-9c77-a77d808e4cc4", "United Kingdom", "8-10252074", "Inner Wheel Club of Leicester" },
                    { "f9a1ddf1-75f5-4564-af34-022202259d9e", "United Kingdom", "8-10279166", "Rotary Club of Farnborough" },
                    { "f9ae88e5-456a-4cfd-b000-87491247db8a", "United Kingdom", "8-10243478", "Rotary Club of Storrington & Pulborough District" },
                    { "fa232d0a-c203-453f-8a5a-af0839c5e066", "United Kingdom", "8-10277798", "Rotary Club of Colne Noyna" },
                    { "fa35d13b-6bb9-450e-844b-71a1e8d35485", "United Kingdom", "8-10250096", "Rotary Club of Margate" },
                    { "fa5bf7e3-d118-4666-b902-3077b650a40d", "United Kingdom", "8-10285813", "Rotary Club of North Wirral" },
                    { "fa5daab4-aca4-40b4-926a-b71bc7740771", "United Kingdom", "8-10282897", "Inner Wheel Club of Dronfield" },
                    { "fa6803da-c4e3-47ad-9f20-d0ca7dd14dfc", "United Kingdom", "8-10282106", "Rotary Club of Wrexham" },
                    { "faa859e6-567c-49ba-b98b-56db129dab74", "United Kingdom", "8-10280627", "Rotary Club of Bedford Castle" },
                    { "fad0f6de-9b28-492f-81c2-b93a9f3626b9", "United Kingdom", "8-10368767", "Rotary Club Of Hereford Elgar" },
                    { "fad55c20-2117-460d-bfc5-6c0bf30d4db2", "United Kingdom", "8-10242517", "Rotary Club of Bradford" },
                    { "fb02b750-ee76-4ed9-bd52-32aff9d2577c", "United Kingdom", "8-10285918", "Rotary Club of Durham Bede" },
                    { "fb16a175-303b-438d-a00c-e2c3af661eeb", "United Kingdom", "8-10286771", "Rotary Club of Swindon Phoenix" },
                    { "fb2288ee-0b61-4779-afa0-16238ac27290", "United Kingdom", "8-10380356", "Inner Wheel Club Of Llanfairfechan And Penmaenmawr" },
                    { "fb28fc0a-482b-40f1-b6d3-a47f0d660834", "United Kingdom", "8-10286450", "Rotary Club of Eccleshall Mercia" },
                    { "fb301a4d-6011-47c1-8ff5-617d6ccc7560", "United Kingdom", "8-10280297", "Rotary Club Of Reading Maiden Erlegh" },
                    { "fb8246e2-dbf0-4817-a4e9-1e7d081ba30a", "United Kingdom", "8-10280626", "Rotary Club of Wrington Vale" },
                    { "fbd660bf-10e8-4454-b9fc-77c0b84fd292", "United Kingdom", "8-10248695", "Rotary Club of Ampthill & District" },
                    { "fc2f8b59-dd1c-4ad6-993e-7ee1eb5812e3", "United Kingdom", "8-10255832", "Rotary Club of Huddersfield Pennine" },
                    { "fc660abb-9a67-49f3-841d-17c2d758c67b", "United Kingdom", "8-10278979", "Rotary Club of Nailsworth" },
                    { "fc6e4f51-6365-455c-9e9d-ef3132552acf", "United Kingdom", "8-10287150", "Rotary Club of Ballycastle" },
                    { "fc74cfed-809f-4b1b-9851-f88392d71f6d", "United Kingdom", "8-10283511", "Rotary Club of Ballymoney" },
                    { "fc87f664-8987-4cfd-a67f-4212bff46d2c", "United Kingdom", "8-10241076", "Inner Wheel Club of Sherborne" },
                    { "fcab5133-64d6-4954-b136-9ca7a80346b6", "United Kingdom", "8-10278750", "Inner Wheel Club of Taunton Vale" },
                    { "fceb6f93-57ea-4ca6-9a1f-6a30a95ef863", "United Kingdom", "8-10242456", "Rotary Club of Erskine & District" },
                    { "fd14c7ec-5b97-461b-8813-15de4fed2680", "United Kingdom", "8-10282695", "Rotary Club of Colchester Centurion" },
                    { "fd25ba79-e102-4f09-92c0-47098f203835", "United Kingdom", "8-10249795", "Rotary Club of Chester-Le-Street" },
                    { "fd51f57a-fcfd-4251-b4d4-f74e38c1f45b", "United Kingdom", "8-10277293", "Rotary Club of Morpeth" },
                    { "fd87a781-43b3-4857-9b5e-8dbbb307d981", "United Kingdom", "8-10256266", "Inner Wheel Club of Rochdale" },
                    { "fdae035e-c965-455c-a1a5-f9a0c714b4aa", "United Kingdom", "8-10240244", "Rotary Club of Brownhills" },
                    { "fdcced67-200e-462a-a257-6d8a54176ea3", "United Kingdom", "8-10265974", "Rotary District 1120" },
                    { "fdda3f1a-dac8-4f24-877a-f7f5f36ac7e6", "United Kingdom", "8-10278769", "Interact Club of E-ACT Burnham Park Academy" },
                    { "fdefbd47-8622-4671-8ab6-5be7411ffa9e", "United Kingdom", "8-10280682", "Rotary Club of Dulwich, Peckham & Crystal Palace" },
                    { "fdf95ef7-63b0-4dbc-ab1b-3031f15ee2a0", "United Kingdom", "8-10285949", "Rotary Club of Colchester" },
                    { "fdfbcc8c-4b59-4460-b4bc-55e96e08887b", "United Kingdom", "8-10250890", "Inner Wheel Club of Chelsea & Westminster" },
                    { "fdfc34cb-4a55-4092-b1b1-d406ab106a74", "United Kingdom", "8-10243506", "Rotary E-Club of London Centenary" },
                    { "fe09eab7-e2f3-447c-be69-33b197241685", "United Kingdom", "8-10265776", "Rotary Club of Tettenhall" },
                    { "fe6c370d-6a17-4afe-a3b6-627b3dd4fa73", "United Kingdom", "8-10246238", "Rotary Club of Clay Cross" },
                    { "fe74c716-a02b-45c9-94d8-7b530a8d5890", "United Kingdom", "8-10281740", "Inner Wheel Club of Redruth" },
                    { "fe7630b2-b4cf-466d-8a53-5394e019a0f6", "United Kingdom", "8-10286465", "Inner Wheel Club of Ashtead" },
                    { "fe8dee5e-a1d4-4122-8b8a-e73edaf4ab19", "United Kingdom", "8-10283497", "Inner Wheel Club of Camberley" },
                    { "fe9e421e-38cc-41c2-9c32-3e1b5b0819f8", "United Kingdom", "8-10246032", "Rotary Club of Roborough" },
                    { "feaedb31-91f1-4d76-8dbb-e4ab76287958", "United Kingdom", "8-10276557", "Rotary Club of Arbroath" },
                    { "fed89395-5eb5-4626-8aba-1d43cee89f54", "United Kingdom", "8-10280337", "Rotary Club of Dunstable Downs" },
                    { "fefbd7ce-cfe1-4312-930b-aa938e3b0011", "United Kingdom", "8-10285723", "Rotary Club of Macclesfield Castle" },
                    { "ff27a0b3-0dc8-4ef4-b7de-1112f2a58535", "United Kingdom", "8-10286949", "Rotary Club of Blackpool" },
                    { "ff412258-3a26-4c45-9d75-34770deaf43c", "United Kingdom", "8-10250832", "Rotary Club of Droitwich Spa" },
                    { "ff51ec3e-200c-43d2-984b-49d1243b2ee1", "United Kingdom", "8-10244784", "Inner Wheel Club of Hamble Valley" },
                    { "ff5da6db-8721-4056-af94-968e461f03f5", "United Kingdom", "8-10286325", "Rotary Club of Sovereign Harbour" },
                    { "ff5edbe8-ae33-482b-9cd9-3a6bb964d058", "United Kingdom", "8-10282975", "Rotary Club of Beverley" },
                    { "ff7ba8a0-c282-4ed4-a3a5-0a2be0146521", "United Kingdom", "8-10286878", "Rotary Club of Elgin" },
                    { "ff82d2a3-6df7-4ca6-a174-0b637ed415ef", "United Kingdom", "8-10286294", "Rotary Club of Furness" },
                    { "ff8cee52-2991-4467-a7c1-055a903ff4a2", "United Kingdom", "8-10284688", "Rotary Club of Consett" },
                    { "ffd1e0a3-08fa-4dc0-83fc-cd1e9e236657", "United Kingdom", "8-10238621", "Inner Wheel Club of Mansfield" },
                    { "ffd33fde-fad1-49bf-a9e4-310dc5fbfbd6", "United Kingdom", "8-10249129", "Rotary Club of Tynedale" },
                    { "ffe27fd6-a061-4a4c-b42d-75f7518cbe76", "United Kingdom", "8-10282736", "Rotary Club of Bedford" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0022b424-2464-4164-84c7-5aa16183a938");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "003f7f27-020d-4391-9f35-7d6890a1f1a2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0046c3df-dc9e-4f33-a2c5-839fa5a92e07");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "007b7035-cea3-41ed-b082-6b143dd68622");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "008155f1-0ecc-49ae-bf9c-033bae5f30e5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "008a049a-6dea-4135-ba80-9430eb1e782b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "00f256a4-321e-43bf-ba80-d8a2f4e7784a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0114f0c9-881b-4ac3-866e-88d30b22f1f3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0122ea03-c82a-45c9-8505-93309ba4f8ec");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "01242c47-2656-4a3f-904d-d0c2922bba65");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0131586d-8e03-495c-b70f-d48734ca054d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0131ca87-ad17-45be-95bb-809b72825812");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "013a0a73-1a16-42ee-be0f-2e644f91f269");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "014fbab9-0583-493d-8251-3d1fded8076c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "016070c0-3c2d-45aa-b09e-90cf58d7f185");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "018ff252-494b-493f-8128-ac991ede573e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "019d50cd-755f-45b1-95f7-6bf1aa90c11c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "01b56ef6-15eb-454c-bb6a-4388538aaaa2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "01f88ff4-0848-4edd-b191-7751bf6efab4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "02014023-a18d-457b-b80f-428dab4e0b69");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0207b410-6ab7-49cb-845e-9a85cecc9b27");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "022e2465-c66d-462b-b272-495b610ede28");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "02afd97c-9b72-40a2-83cb-55d6b2a9c7cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "02c5b112-f033-451e-865a-2a96d05800e9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "02e98302-59ad-4bc2-b23e-0f5602eb1bb7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "03090044-4eb4-4a83-b11e-62a4e5eb5c03");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "031bcd64-a03a-4a0d-b967-6eb4096790ea");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0336d383-ba74-4231-b5ae-cf6d5bf707b0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0342244b-2b5e-4578-8add-6aa987874a45");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "035395d6-5107-4a4f-b3b0-93f6f6cd8976");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "036969b5-c1ed-4e5f-a1c9-7dd1285c3a9a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "03743a60-da99-464b-baf0-9bf6fd8598e7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "037e7a5d-eceb-4624-aa3c-3a3ea3aa0c2d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "03940c2d-101f-4096-9bac-b07981a70ce3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "03bc5213-3573-48da-97ba-959f65b38400");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "03d97648-0d95-4f23-b5c4-7f1e2a6c1387");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "03fcf947-d165-4926-9882-9266b4c7bb44");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "042f945b-8849-4539-a09c-ed2448db9427");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "045aba1e-6ad4-4287-a713-614eb08faff7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0485734c-7fbf-4754-bd45-e2dab3951144");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "04a273d7-1b7d-4d71-971c-724d82445e07");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "04c0dbc4-8707-4b80-8eca-8e0ae08ff503");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "04c6a878-6850-4451-8b6a-1a9a7f40665c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "04c719a9-eff2-42a5-b6fd-6e9f71765efa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "04fe1542-e3b6-4e8c-95df-07cfdceff8c9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "05130510-97b0-4c28-b9fa-81fde4172c4f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "052bffbb-adac-4b3c-bf66-f1623d38eab5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "058bd33b-f0f4-4245-969d-1dec71d2d2c4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "05935aa1-0039-4bdc-93fb-addef29ddd4a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0596ead7-475b-4952-9b81-b579f5702a0d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "061cdbd2-6d9a-4b61-89cb-da20c24f64ac");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "065cf40a-964b-4a7d-9a63-be1df76dccb0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0666a329-c339-4a93-92cb-b1ccbb885f03");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "06829c7f-b2a2-42fd-b8ef-48ee0829206d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0690fe2d-e1e3-475c-87a8-d3f50f144ed2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "069fa75d-8d48-47c3-b1d3-5571571f8b86");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "06a1dd91-7807-4df5-85c4-6023fdf23dd4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "06b7c446-9dd8-4e6c-b1e9-b66439a6f1f8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "06ef1e65-838f-4a74-a2ba-c22f4adca871");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "06f73052-8c01-455e-a2b5-0d132b720574");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "070cb406-eb8f-4946-9628-6802125b14e2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0716858e-a4e6-4c36-90f2-986eb66c0033");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "07256be2-5fb1-435f-a519-b91682e81e7e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "074ec71d-8761-4fe6-8fdf-8905c5faf9c0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "07706f76-7d10-4448-9669-465c33b6642d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "07bbd7c1-f8e0-4e60-91c3-5912276176f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "07cc0360-657a-475a-a2ef-49a69a7581b8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "07cd6da2-34b7-463f-97ac-a8bd506db9f5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "07d1ebe6-d784-4b2c-9492-0774e66ab1d5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "07dbc5d1-6c09-422a-8244-c3d3c07efcdb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "08483643-f5d6-4440-b8a2-63412d788d96");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0862e8c6-74d8-4a95-b5f5-94d65d419f40");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0874eb8c-5b65-4f2d-a2c5-3b569b66d926");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "08755e4b-b802-44d4-81cc-95dbd463d590");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "08b1ba4b-2470-4b51-af9a-592e33e1535b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "08cdaaa2-27ea-4671-9ea1-32f0340d777b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "08f52352-1fa7-412a-b48c-5ee8d9c77820");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0919f6dc-0ed5-4c7e-b583-0e37cee6b1b2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "09471209-c83e-40f1-bf8f-744903c98d97");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "09bb53f4-139a-42aa-895a-e41ca1f33d7f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "09c145cd-e313-44d0-b09e-7841a09b36a9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "09c95de1-e1f4-45a0-8982-730912fd3682");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "09ec2708-6e88-4b23-9dc5-f31453178a8f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0a1eac04-3115-4edc-8a55-ebfc1460c601");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0a2b10e6-bc4a-47ff-a008-5aacb9dbeac3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0a2c1ad3-7c8b-4b36-93c6-1e6401d06916");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0a57e493-df34-4589-bb02-5a82a0458416");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0a58aa4a-0641-4e21-bad7-7356899e6051");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0a87d44b-3975-44a4-9771-7799000c410d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0a967cb0-e3b5-47ad-b5b7-d3cf2eaef897");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0ab8c932-cced-4c82-9d2e-e488d442458b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0abbeea5-570b-4844-8cd5-ad008693c6a0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0abcd325-e0b8-453f-8221-b54385740275");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0adbda02-3349-48b4-905d-169d30be33cf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0b0d44dd-1a76-48a0-9588-b845627a3644");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0b16597a-a438-463d-886f-cac48b441382");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0b17da67-9037-4e2c-bec8-423a5cd27e12");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0b1fc39b-7330-44e5-bb83-e94222fa7a25");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0b650d35-d891-486b-afcd-dcc855c80e95");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0ba1622d-1811-4f90-a4cd-1238da398ee1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0ba6ef64-062a-4df1-beca-eda6e23955af");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0bbd654b-5669-4b91-a9db-873212c33ac2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0bc52f18-df7f-41f6-bc78-5cbb56d0ebe7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0bef81a6-99e3-4687-bccd-5d28d990f546");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0c009390-3b5a-48d2-b7b6-fb38b65996c5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0c16acec-b435-4584-bc2a-770fa3897be6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0c44f26d-a0cc-4a02-90f8-d1c8e83260b1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0c48c9c2-e7e2-43e6-8e88-d1d6b24e3766");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0c92af99-d4dc-4e64-a745-b7c536933232");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0c9d112c-1f32-483d-baee-2d124ed703cf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0cbb1d2f-6d70-4ad7-a9e8-005dbab2137f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0cd99ba3-b8cb-49ef-9e06-0b470458e38d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0cdb6561-cab9-4f2a-b31a-42721e402568");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0cec2be9-9c98-4855-ab47-ed103385b919");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0cf24239-a379-440c-88a4-2e543c271cc9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0cf4d397-6474-486a-b4ab-7b003bffb691");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0d25c162-39b3-4161-9208-1f67df08dc6d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0d37be34-bbff-45f2-a6ea-45daa4d23888");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0d626674-2c4e-4d18-9c29-030ac349da97");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0d66b507-08d0-4ba4-8fa8-a7385a6e6da2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0d69919d-d52b-4b2a-b40f-0ae0abc82d20");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0d885433-c6e8-4e06-bd90-8ec68d4ee0d8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0db3ae0e-aaaf-45c1-8e79-41c85679ad27");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0dc03fba-30a4-41ca-828c-983dc626a442");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0ddd53f1-17b2-4987-aa43-37f8af7fc5bc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0e28c640-6f98-4b83-aa50-77bc173ae65c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0e2b6c4b-a1c5-4749-9805-e029d420bf80");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0e5017d9-ed65-44d1-ad6b-f124f8650cf5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0e958c60-1656-4d6e-8336-65472df9fc38");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0ead1ff8-55cd-4223-b0bc-cb3c69849f58");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0ec42651-2f21-489c-ba7b-1342ee699df8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0ee9b38b-fe4e-438f-9c68-de15faa0d47c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0ef0464a-0e0d-4bbb-9a5f-f1935da51c91");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0f4d0498-f414-4679-be5d-7d4d5a2535cd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0f508b2e-9693-4ecd-a800-3523e24c7d79");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0f6c5b78-fe54-4fe1-a46e-5d364ea8f793");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0f737e7c-bbe6-4434-b5e8-77d36e4a15b2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0f749734-c38b-45a6-af01-cf94cdd51592");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "0f9fe087-098c-451c-970a-cc1957200bac");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1010b60d-61d9-4c11-90ae-6471dd2c09bd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "104daea8-fdb1-40bf-972b-b254434e7efa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1079f03f-31fa-4623-b7cc-a283e386412a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "10bea18c-9e9d-4d70-aba1-e3c3de2b75ac");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "11554fd0-bcca-40f4-9be2-2f73bbb7a36a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1157eddf-81c8-4401-aea9-6acfca0a1b21");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "11923155-7e0d-485f-a471-322e13109ca4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "11ac270e-473d-42c7-bf78-9e7ee31015a8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "11b6b67f-ea7a-437f-a68d-50ef3aa14a97");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "11f04fea-c60e-47eb-a341-0931da1944e7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "12597235-c152-4cbb-8b14-c375863cde3f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "126d2576-f766-4de9-915e-021c3d628b1d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "12757299-c47e-485a-9764-ccb6beb2936a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "12a7ed40-aa7b-4bfc-b499-86643d6e9b0e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "12d796a2-76d6-4cd9-8037-474d07eed970");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "12da9be1-8690-4cd8-89cb-d3e718d89b9c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "130b7b93-197d-4b20-9137-970da4999376");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "134b67ac-095f-4e81-b290-bdef262ff7ae");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "136a87f6-0379-4a68-b083-c2e299e07f18");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "13b98da5-b3ba-4186-85bc-0c0168dd0503");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "13ed8359-e00f-4a0b-9e3e-78f6ce21735a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1414cb7c-08cc-4a69-a0cf-8ed9c12ec605");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "143f9efd-b9ad-4fc2-81db-fab78cdd7468");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1490fcdd-2620-4ca0-97f5-18dd3d68f09a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "14be6ac6-c3ab-4db4-94c6-0317f21eb89f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "14c2ac12-7208-4114-a2c7-f1abdd1c4549");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "14c3b6ab-f0ce-44c5-8d98-6dc08778c876");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "14c41b6a-7c20-4a58-ad78-ee1f082c23d4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "14ca57fc-f894-409b-9369-950e99d68c52");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "14e34a7a-a36b-4c18-b90d-0d122fa9942c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "14ea65fd-d0f0-4b4a-8e84-812f3be9b853");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "14f4a35f-fbe4-42de-9e27-59e314a77c7f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "15fb2ad3-5a45-46b2-9a29-a2287af9bd8a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "16018880-3fa9-416e-88fe-2935350e4b0f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1607f87b-14b0-4955-8e95-2f9a1f9976bc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "16140842-624c-4eaf-8c0e-926c96db7a30");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1630b07a-6403-480e-86b4-39b45ede820a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "16589ddd-182c-4ddd-83b2-081907c567c1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "16abcbe0-1f16-475c-b682-42c69933ede8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1703f67b-3030-420e-849d-a73343c002cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1745146a-823c-431b-bcff-e03ad2e41d93");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "178db39b-00f7-4b77-84a7-614809b9ae77");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "17f5cd89-49a0-43b9-b571-df769b393a22");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "18090471-c315-467b-bf61-d21b1969cbb5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "184dfe23-bbe4-4d4f-8d37-acf81c57130f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "18b12b0a-2199-4560-941b-fb5fbabf5793");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "18ca1591-b5b8-46ee-8678-e9da9204d603");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "18d77d3b-7e9e-4802-8593-a1fae64ebbca");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "19059315-d6a4-4976-af6f-53920822f081");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "190c77ae-1129-47f2-9647-c18a4e99498a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "191882f4-a20b-4149-b26a-887e48b24a98");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1920305f-97ce-466a-a7f4-6c34931eabb5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "192a2934-6133-4af0-8ab0-180f6c6fffc7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "194da208-4fdc-42b6-a521-b5a0248955da");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1953cdef-e909-4c36-a345-5e28c4bf1dae");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "195f6822-d1f5-4588-8268-2b9538619a47");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "197a9c8d-03cb-4ce2-91a1-15a31939aacb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1997c2a4-9bf5-4d52-b69a-3b5b72b46b05");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "19dc8e3e-f7a5-49f7-96e4-3dff1d07b1fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "19e8e33c-5a12-40cf-a502-b860c992ad20");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1a1370c6-a39d-47da-948d-f5477679ebb0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1a3f93a7-582f-40c3-80ef-8502023f0395");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1a79a502-77bf-45f2-88f3-1cea935ecb76");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1a9ccc48-756f-425f-b4cd-4360c68f13dd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1ac4c99c-9753-47f0-a1de-f035db051068");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1ad143b3-ff99-4bbe-bbed-31ad298e4f55");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1af5e58c-5c82-45c5-9884-16d26f20340e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b0ed810-2ea9-4ee2-8e2b-18dcb7fbe0a3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b14f859-61be-49c3-96dd-2d0f9a934fab");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b2578b7-ef9f-484c-a284-3e0f6cbb7e8a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b2d7b8c-8fc1-4a14-93ba-e5ce777168cb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b40354f-2bf6-49ad-982d-3270a81893d7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b4d0d9f-0676-45b5-bee3-184814fe114c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b597f58-5951-4d18-8020-faa14da2d05d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b675f81-7716-4ffa-84df-7a3ad548e7ff");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b789784-f131-4a56-9a18-feb6c89048c7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1b917f20-bb5a-47d4-a70b-d5642b0ba31c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1bc5ae1e-52d8-4347-a073-ebbd23912d5b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1bd2115b-57f7-404d-9b37-d07b19441704");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1bd37802-267d-426f-84e1-0a3243bdf32c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1bd7623f-7f67-4df5-86d4-95f3afcd8c27");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1bdcd12c-547c-4ad5-bcf5-8aa15890c5b8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1c38649f-62e7-47f0-bcca-81c92bfcd483");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1c508604-3775-423e-a9ff-2cd630beaa6c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1c53f3b1-1383-423c-8d06-e760f1369e61");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1c6c3d4b-b00b-47dd-87e5-59c711e5f14d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1c70e442-2600-439e-b14a-c7ff9545d91b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1c83bd64-4036-43b2-ba29-666f5cd158b2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1cd93c1a-74e7-4366-915c-d1821b9663ea");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1cf09cc1-9183-4f3f-96d9-a83da419c1c4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1d0ff62e-3475-4764-a65f-a1bab5e5e80f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1d15b9bc-0ee6-46d9-811a-9ef2168426ec");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1da2778d-1155-4704-996c-8843df4445e1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1dbfd66a-afa7-4b26-a81a-779becc66400");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1dd8117f-299a-4626-a8c0-3f3350b06293");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1de69474-8b6d-4f9a-9c7c-00e70eeee72b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1e2ce961-7918-4ba4-a28b-4f4ee6b01bc8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1e4ce563-fd8d-4ec6-8618-fe988f9bd624");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1e5016a2-9170-4477-8ba1-a0e2d69ac3f8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1e55b88e-9660-4c20-8c05-871e163418e9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1e929c08-7009-4548-a6e6-87715fcba61b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1ee44713-fff9-4d61-9ef1-a2def9aa9b11");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1f032b63-7ed6-42a1-9669-86cf143a9d30");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1f15c545-2ae9-4162-8892-2b1eb4acb9af");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1f25c99a-895e-4d9b-a508-128b633281fb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1f2a28c7-5592-46d3-98f9-27097725ffc0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1f3daeaf-f0e5-4b82-a5c3-879f7d96aa82");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1f3e0e3d-5e45-49cc-8463-9f1b47a5ed45");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1f7e0ee8-3e6d-4734-b29e-27727976bb39");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1fb0a6e7-f199-4fa4-8b9e-8d0666a63dfe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1fd6995c-43f0-4473-9db5-367fa585ed9c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1fdc192d-cff6-4cb4-b75a-9f0cf46a6ef5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1fe6a283-f960-445c-8827-58c300f46ee3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "1fface71-ae6f-44f3-8106-5bc7d30b0959");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "201ba82a-86d2-4ab5-b954-b47b6eb08402");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "201fb942-44aa-4b61-8b7c-aba32358d968");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2025bcf3-933f-4326-acf0-63e1b9f2b2c4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "203c03b3-b901-424d-821b-d14555a82b2c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "20a3cff4-46a3-452a-be22-ee3079f953ca");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "20ae1ba0-9d1e-4c3f-94a7-d5d3ae7bbeb9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "20ae93ba-43ca-42e6-88df-98fc0bcf5f9d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "20b22d8b-d47f-4953-acd9-07b5fd480760");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "20c7ba22-a80a-4d00-a9c4-5ef041f9e53c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "20d3570a-01a7-477c-9c57-618fc984a169");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "20fb7d58-8982-4ef0-99af-dc7317c5a3e8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2114c0f1-5d7f-417e-b021-b0bfe48b98f0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2131c1b9-74c9-4835-88c0-c36dd5be5c80");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "215e0f95-b6bd-4c9a-af66-f38b1714b785");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2179ea27-c2c2-4a75-a304-cdfe402c3649");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "21a7c427-cbdf-4833-a50b-9acfae30f7ee");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "21b63238-801b-406e-bdbd-30bf4a4bc261");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "21bb3539-e442-4521-ad6a-996e56f59656");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "21cab790-bdda-4fec-8c59-7a70fe146e0f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2202bc94-7f84-4d0b-9d2f-65c47db2ce9b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "223dec77-ac6a-4269-9ef4-6e4d0c603404");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "22472575-3a9b-4369-aaac-4907d45ba0ec");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "225833d4-fd92-4fb0-b9fe-5363a1f77c54");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "227d1e6b-64bf-4721-bb4e-2b08e9adbcf5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "22823b69-ed5f-4fbf-a9d6-57de97b21d4a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "22851689-1ad0-4c54-a2f3-5653fd1aa01d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "228905ec-3e18-4361-909f-887eefd447fe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "22938188-c217-4ff8-8ca3-225c686e45e4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2296822e-0f1b-49b1-8a20-7e8141459086");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "22cc3e0d-250d-40e5-802a-29d963e7a432");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "22f8d5a9-17f2-44c0-a780-8eba37cdc2dc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "230866f4-a409-41cf-80ec-0837e83aedde");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "230d1983-c19e-463e-b9a9-a9a4df6b00ed");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "231ab69c-1c00-4faa-87c3-043795661eef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "232a41e8-87b0-4a1d-a032-32f8c35a3b1c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "232eac94-613d-4335-930b-2cbbfe7b9116");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "23363333-4f06-44e5-b59c-beabd534fec7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2350cb7e-cade-45a8-8933-4388a4b53e01");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "235c46b0-3248-437b-b429-52ae2c67c595");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2375c884-f769-4968-b0b4-e074d683deeb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2383dcfe-0a31-44a5-b193-cff6697e8f87");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "238a07be-95e7-4774-a4db-ab177d5031e8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2410ca27-d4e2-4916-8b49-97e631d282aa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2438f8bb-6896-48f7-b48a-f5357e5e21cd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "243985d6-74cc-46e8-b115-d17f3a3cda0f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "24574c3f-4116-406e-b75e-58aa3a0eaa24");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "24b62f01-5937-4bd8-acbe-0f753e4ea4a2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "24e2fb23-6f6c-4ca8-aee3-ceab3c4df773");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "24e4e483-ceb2-46b2-94e7-92addd886c53");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "24f207d7-e580-426f-bd58-aee0d0551e01");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "250d5dda-60c2-4941-a4fa-6fe6574d127f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "25134de4-9f2c-4a04-8cfa-61e6f3a23dbc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2552d96e-e781-4e3d-8c7e-7bd50fef8a7a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "255642a7-8a39-42c9-9665-b8cfad325fe8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "256083d3-48d8-4159-9ac9-cf4f0d539dee");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "25745420-7601-4c10-9978-7e9542ddda1a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "25855c80-04d0-4927-be9e-a113a66847b3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "25a21e10-26f9-4ae1-a728-0a0c633f0da0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "25ff7999-73b9-4cc4-ae8d-73b4670e574d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "26131fbb-c6ba-42a7-b4b8-181eea1b371b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "262c35d8-fa38-4bab-98cb-b08e477ab852");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "265391dd-d2c0-496c-8300-a09e621ae073");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "266fe61f-a8a2-48e7-9301-826a4a493c8c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "267cbf6f-6a00-408b-9fd5-d45aee60bac1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2686affb-b44b-414e-a0a2-5a5f56a3dcd3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "26b4c7eb-5a62-4311-8afb-2355e30680d7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "26ca4cf1-0ba8-4fd8-b5c3-0e41b45ec1ea");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "26d22936-0849-4514-b89f-154b5c4d03ac");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "276bd0f7-dd36-44a3-8be9-48a66a48e98f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "27b28831-79c9-4b97-8072-9c36a4837ed3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "27eec3bc-9c99-4b7e-8943-c91bd0c750d0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "281a6d2c-a087-4476-97e5-02f16bc90080");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "28208746-d121-4e5f-834b-1d0ee1acc3ad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "284ef210-a435-4d4d-9cca-850cb79f1b32");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "285cc6ce-306e-4342-bca4-43f6220595b1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "287e16b6-d959-4ecc-ae12-f20735ab84bc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2886a9f9-563f-4400-98bf-484e98c5002d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "28a5ce7a-54bc-43d5-b6c8-fcb777456850");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2906d56a-b168-44b5-a819-1b3fd60aece8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "290b10d2-a8bd-4737-af11-038beb95dfdf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "29184c87-63b5-459e-9a35-a8ec6e003f19");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2929ca73-d645-45d4-aeb7-083239dd4f37");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "29486fc9-6d47-46f8-93c9-53c77aacbe15");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2963a2c9-170e-4d97-9588-e6de8bfee4cf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "298a0ba2-25a0-4b4a-bc65-cb385f8e8f35");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "298aaf3e-2538-4f31-b7c0-dcd49811e246");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "299646d4-75e7-4961-8ed2-ea76d5418280");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "29ad1db3-9644-495d-9547-53e6866c2560");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "29dc114f-92f9-4ecf-9f8e-4365fa10d6f1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2a41ccc2-ab72-410c-b8f5-809e3433e7e0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2a43f28a-c03e-450b-b1ba-2f45ef669b8f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2a5bc149-a562-46e6-b425-2919c782df08");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2a64693e-a036-4e81-89c2-d52ca0a7dd05");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2a6e95b2-24eb-4751-9852-0d425fcd1586");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2abc4c6b-fd90-4fab-ae00-403847ab622b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2aeb65dc-6a27-460e-be76-d96704033ca9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2b0cc2f4-399d-4d96-8c79-a6da4b1e08bb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2b10c80d-7aec-46b5-a551-47e1ad7232e3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2b11bfb1-3239-485f-8dbe-bb6355c1a312");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2b5eb55b-539a-43bc-9ad4-cef3913e9c67");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2b5f2914-f5c6-44cd-afa3-4ef43ef0f0d9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2b6121dc-c5c4-4eeb-a8aa-d6969da3fda7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2bd8c042-e5de-45cc-aad0-5bc9b849ab9a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2be797ac-8af4-4836-a468-aaf1687e227d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2bead99d-c657-4029-8815-97fd2d142136");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2c385341-1d9e-440a-bdf4-ae399774be80");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2c5d4817-298b-442a-81ce-5c1308223045");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2c8a3d17-34e0-46b1-8926-c8a7a5e0e44f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2c8a4ddc-4181-4fd2-b1a2-0e0e908bdec2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2c9170f7-c385-4354-9779-9cf94f9ee3d6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2ce33ce9-aeaa-4a8c-b9d1-36a4b8e9fcb1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2ce7c322-7e9e-44be-a81e-eb60b154f054");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2cfbbb04-ee4b-4de8-80f9-684b8fbdf9a5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2d1c0b88-0c80-4307-b7c5-25b151eeea93");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2d24ba98-f799-4e40-aed7-6e236aa43a77");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2d2dda3a-4c36-4c19-98f1-bf6f75a07f9a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2d940db7-777a-4240-ab3e-ac2b691813ed");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2d95de99-fedf-44bb-8d3f-49eaff060b26");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2da9b8c4-6ba7-4922-b671-8805b16b330a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2dc3cfb1-ff9e-4476-a872-4e79259c226b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2dc5f550-800c-4290-b6d3-9426823e5816");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2e01b348-385e-4db3-b7b0-6d5b70a017ad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2e45a496-fbdc-479d-8391-6d4d04920b08");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2e8ae043-fd1e-47cf-ae77-c50b347b27d5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2e8e678c-7bdb-4ef9-a7c0-684c5f1c9bfc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2eb6592d-8b0e-413c-b82b-c153abe1594c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2ebce6c5-9f17-4e4d-90d9-b69c3605be5d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2ecefaff-5e16-4529-9fbf-7a7a0ea0e6c5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2f138e11-d19b-4b9a-a473-acdab51e3ee4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2f141c01-3da3-497d-a9d9-5c31acb070d7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2f1464d2-0f49-492a-8691-497c03c1195f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2f52db0e-b486-43c3-8557-5e01db44ee49");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2f777c99-b90e-4d0d-989f-7cb072fb1457");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2f8d29e0-9002-40d5-973b-1da77c687ad2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2f9455da-b131-436b-8c7f-bd1acb1a8d91");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2f9e2747-084a-4baa-a82e-0648dffe7199");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2f9ecdb5-fced-41d3-b9a7-45b94bae17ca");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "2fc96e10-ad06-4fd4-8479-ad9f95d8b65d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "30050b1c-f879-4b40-a824-0c257911bc51");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3007f99e-b8cd-44e1-a5e7-4123b876efb1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3008b262-842e-4f74-899a-edba1eb575c1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3022133e-d18f-4102-9106-dfa16b25d493");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "30385ff5-795c-421f-8acc-2f2d6d3ffa21");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "309c1787-059d-488d-ab86-85b187426836");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "30a70715-1b25-4213-8424-eb23ed2951cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "30cd5f73-8cf4-46bc-872f-025fe0966846");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "31267538-bad9-4f1f-ae38-3bb914018c84");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3133c6e8-d33c-4b2b-b7f7-3a73a89d70a0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3148cb3f-605e-40a5-be2c-467e27d3f7ad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "314d5661-cb2a-40e4-9428-5430ea738d93");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "315746ef-93d1-454e-9bd8-e59eb6badedc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3173329a-1666-402c-b345-91becdc3b081");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "31928b80-b1db-440c-921d-878421f82d0c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "31a172ff-32cb-47c2-a94b-3db5c71f211a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "31b0513e-a9e2-498a-a425-7b708d231295");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "31c9edad-1402-45bb-bc89-f628022f816b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "31d9ecb6-0b0c-4d54-beb9-0e3619676ea4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "31da566c-7f01-446d-ab92-4227c885f400");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "31e70b9b-5a54-4bd6-92d3-221dccec4c16");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "320c0037-dbf4-43cb-9f24-e60c6a8e9c9d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "32136bef-4ef1-4482-bd8d-3b23eca328a2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "32318a04-abd8-4fc5-9087-93116c661825");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3231b21d-741d-447e-934f-917f6e8082cb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3241c8fb-2497-47c3-837c-126a6ebb11f7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "324f0bdd-7078-445f-ab86-d3057b584ed7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "327b9232-ca69-4132-a40f-1927b46d7e64");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "32963abc-1d58-4bcf-b1e1-00e8527bedb7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "32a31a18-8063-48a3-975b-23c51b89ef7f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "32d66586-0a47-4013-9b7b-cfe457406f58");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "32dabd95-06b5-462b-b2fb-2bcc2961da07");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "32e2840f-f113-4857-87f0-c89a1f20a9dd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3305f13a-52d0-49ce-8358-ad45d313a3c0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "333ec214-4ec4-4ad2-8313-66139c0287fb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "33447b76-a62b-45d1-8e98-f88453f8ca4d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "33527ea1-5701-4ea8-8e30-715085174628");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "335e426a-b6c6-432a-bbfa-99b48be9f00b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "33630044-3651-43a0-ad63-ae47b7f91a07");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3380bf71-547a-49af-b924-7552ec790aba");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "33b8989d-ccab-42af-b1a9-3a840a688473");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "33dcc2c3-225f-4d24-bf25-6c30d714360a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "33e24882-dd1f-41cd-ae51-f021d3ba78c5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "33efd93b-7109-461d-8eb8-f76fb18ac33e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "33f1ca05-6607-48eb-bd0b-46adbcd8fc06");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "340d70ef-3d8f-4d7b-8d47-04c519c6a837");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "341b2c75-d254-4fb8-af77-7d49ba7cfdc0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "349c4b36-e7af-49c6-9f64-430b0027556f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "34f79166-1885-4316-a6f0-d38fc8096bc5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "350d4bf0-9226-44a1-8003-a09a0ffac90e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "35101ede-290b-4f7f-989e-61cb5f42d441");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "35345727-bf86-488e-8007-e1c1918321ce");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "354d5fca-fef4-4046-9432-3359db9d77df");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3558adbc-71eb-4b80-a53b-3716bcf49c6b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "358837dd-b643-4094-a3b8-9ac3f1c55c0a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "358d6b6c-8cd0-4b95-826c-3665ef12939f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "35906d85-1ad6-441f-8c69-22726a35736e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "35db176e-0273-4690-8292-e7ce1b40d69a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3624d097-b341-42b0-ad21-754ce67935de");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "36372172-2207-4055-8faf-fec41d9d6f36");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "36434838-450a-4758-98d0-d858d5370692");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "36694382-e7fa-48ca-a8bf-b5f5bb754141");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3670edf8-8c71-4145-9f7d-9773cb17342c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "36b38ab6-e703-4670-b5eb-7a0a5a6d9e95");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "36d505bf-436e-48f8-8e6a-dc9f936f073e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "370050b7-ee6e-4471-8102-06dc06675cd5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3707b275-4ca0-4717-a953-05a40e8401c6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "37597013-6f8a-4584-985d-362fd8d47261");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "375d3300-cc31-477e-ac6c-cd53161689e5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "377cbc1f-5fc0-4970-b2ad-46e8342550f8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "37930d52-27e6-4644-a276-3cce545af5b6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "37a5b60f-9f24-407f-8a10-a5e457fdcdb2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3804b0d4-e262-48f3-b45c-e9b97f54d3ba");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3820abcf-0b51-4986-b338-773748d482bd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "38294b1e-8aa2-405d-b8cc-43b5784c0129");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "38312dcb-a666-42ec-bac8-e0b68adb987e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "383736a1-56aa-4d70-b42d-8f0e654e383a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "383d1056-869d-4e2d-a691-9e31dbe6d31b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "38616ad6-d204-44a7-969e-5de587d7893e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3887aad0-2817-496f-8a0f-b2d058c9c152");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "38b6f05e-18fd-4748-8978-68f70bdc3494");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "38d6ab1f-9f3e-400e-9238-8eedb3304b9f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "38e81183-7187-4aab-8778-4972bd4a39b9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "38f99ad8-db2b-4e9a-a6fd-bf69a4faf818");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3950d246-590c-46eb-8a98-04b02bf5421a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "39589967-8127-4e59-9685-2cc7642db4c7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "39647113-9eb4-46f5-8e5a-eaeee3d6cf71");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3975b5d0-513a-479e-99d2-a979bb1359ba");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "397ac9d4-7c7d-4614-b525-27d74da0b088");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3998b80b-ca7c-4d61-92aa-e4a9f1a0b45e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "399ae181-80b6-42c0-aede-79f77164add9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "39a2359a-4f16-4251-9045-0f9dc1024e91");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "39b76998-0180-43d7-b225-990cc8ea4248");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "39dfc149-46d1-4355-9dd0-733959f4cca4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "39f1c3e3-72ff-4887-a6ac-2f3139b51df3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3a0c67ec-ba4f-488f-aa98-7476d112e711");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3a22aa5b-d7b9-428b-96d0-a926286e5208");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3a456544-88bd-40bb-9921-803e0f4359fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3a665763-23c8-4e6f-acaf-a9c8c63076b1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3abd31d6-6d30-46a7-9fb7-5dcd0b5ef6a7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3ac7ae95-89fe-4d15-be96-43643f1e1d79");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3acdc321-62ac-482c-a0da-88901ba8c508");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3ae5177e-c947-4896-b953-9e068380e20f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3ae6f68a-8458-4e53-8c7c-27ccd2a7131e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3b2d2c4e-f936-4369-8a92-6e99cb2658e0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3b38b0ee-8dd5-4e2a-8631-4f4a2478111b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3b537283-f4a8-47b9-8446-44f97fd1da42");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3b73a663-f45f-4c78-9f41-dd1eeae61292");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3b87bcab-2bc4-4c59-98ae-b472c32fd909");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3b9c87de-3d87-4bf1-8e1c-00949b629d4f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3ba99fd3-9e72-428c-9268-b8a1c60437fc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3bed4a6f-b978-4a92-9e94-9fb6aaa5f985");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3c3e4c78-1b9b-48fb-9cb7-fa412a8c8260");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3cb86610-b9f7-42cb-81e8-e49019c3bbb4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3cd9e1af-cd31-40ce-a49d-92a1d4adca4b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3cf3230b-c66b-40f7-a059-0ca93c50e0c7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3d1f1145-6e6d-4785-9a36-db860a5cfb25");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3d3225be-7f5c-4434-b24b-2312af4cbea8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3d4ab283-ec9e-4a56-b967-f4f21830428b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3d6e0ccf-f393-4e9c-8154-450c18ffa7db");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3d78184a-2ca6-4f93-b63c-48a3d29d6dbd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3d913543-2bf4-4cb2-a792-aeb4873e48d3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3da1f8fa-7015-47e9-abfb-5836793cfc90");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3dac799f-8d78-4f4f-8b2b-4a76286ba849");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3dbce246-a9e9-48b9-897a-b10333b1977e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3dcdcde9-e52c-4b0c-82a8-4074eb39ff03");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3ddd6f53-3eb5-4ce1-a3ac-4a10544f42db");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3de64d56-e30c-41f2-8f85-ba5982cd6d29");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3df31a98-5806-409a-9d1d-7cca3aae1692");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3e1a79e3-037d-45fc-bb4e-ead822d45e04");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3e2b0f9c-d70b-4582-a626-5559223cd8cb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3e5b3cd7-056a-41f5-b14c-5ecf8adddfba");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3e7ea99c-15b1-47d7-ae30-389249c81606");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3e8070e0-e73d-48d1-93a8-1567097ff5f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3eb7b47a-1402-4ee0-82bb-164952bc1b2d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3eddcfd4-6e93-4fa7-9ba8-8c1bb7e5b3e0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3efa9591-7021-4d22-8045-95a135a24f24");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3efd1a45-914f-4f80-9b11-be407b69ede6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3f20d2f6-8d80-4012-b3f7-71b5293a3395");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3f4e985e-564b-46bd-b5a0-5a06d3c87408");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3f73c0b0-113c-4d81-a85d-1daf837b4b60");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3fb89121-52ae-4b20-a326-d0f2810f3a10");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "3fc67332-d2f0-4f63-99b7-589ba711a9a8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "402bf932-ba0b-4c44-8a95-75058b0f4ae7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "40600268-8021-41ff-a852-a48e315107b0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "40c7520f-eea7-47ad-bd31-58f42a92e1d8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "410e74a1-ce72-426e-8a2f-c0e8001976fc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "41177474-e229-4bf4-9cac-8c3614614b93");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "41542fd5-05ee-4b92-8641-ee36ada8d38c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "416f6050-80e4-452d-a56a-ed1761754533");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "418df8b8-1f0e-4dcb-ad20-b49e16bbade6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "41a3bcb4-42b1-446a-96f6-b79d3d62e1a3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "41d6759b-d888-461c-9cbb-76a5e4f5b2c3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "42154dd3-25a6-4293-b1a9-66648c17e330");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "42aa6054-a48c-45bf-be8a-9ec96e8410be");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "42e3fef5-4f04-4ac5-852d-927fbf31ec41");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "435a4d3e-b369-49a8-abad-d8e4b988383c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "436a5122-6452-43e6-ba9e-b9080becfcd2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "43735fad-4148-4393-97ca-b0f44782d29e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4381f701-3562-4db2-99dd-c041447528df");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "43a895fd-1727-4c96-9c7c-bdb013899287");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "43b8b960-6be2-443c-b746-0da2e4b1822c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "43bb7b15-e07a-43df-80eb-ac7251d35911");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "43d08b6e-b46b-4b43-adfa-7028b44d670b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "43f08160-2e89-4619-bad4-67c2ad3354ce");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "44095ed2-8a4c-4498-a782-b8a273a43df3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "44123501-1370-4fc7-9374-ac8fa83f77eb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "442808bc-eb8b-406e-a650-12a37a8f4ced");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4440cc3d-5183-4797-9db0-3bc7ae654573");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4454fa3d-75fd-4bad-bb4e-ab285a170c66");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "447fc587-1c8e-42c3-8689-59854ce8e10e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "44e20246-4a1c-4dfe-9edf-75b05f3184d5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4504e342-65f5-4cba-84f7-007564cf3a3b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "45721272-51d2-42c1-a725-93447de97de9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "45a93896-628b-4ac2-9de3-c2b326bf5ad7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "45b28ff8-2fbb-4781-8988-110f8b25057e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "45b70606-8471-4b98-8f48-7bfcc2fc928e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "45c4248f-7314-4162-b814-dfe4c3ce0a55");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "463a2d56-de7b-43cb-96d3-a9a175dcaeba");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "46a326e2-2b91-4913-b088-6c91b955e3f6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "46ac8a96-e07f-4899-88ab-1f2bdeea12f6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "46bdf38d-68f8-4574-a52b-9e6b25399a05");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "46e174f2-f280-4d60-85d9-5ccc448ce80d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4708184c-93a9-4798-a61b-ad2c15fac103");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "471f61bc-6666-4fb4-86de-58228a3a1a23");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4755a3f5-b03d-4a65-bdf8-725c8bfb5769");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "47576fa2-e7d2-44a1-8b00-e4e029a90dde");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "47605104-4156-4afc-87b8-63f085594b3b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "476cd009-2316-4466-b869-49e24010a886");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "476d3363-399b-4ddd-9f10-5e94fd70b195");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4776dbb7-3e32-400c-8506-53c2ee810004");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "47954005-102c-4af9-84c8-1dfe56e410b7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "47a37303-8f8c-43a6-be6c-455357902cdb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "47c5f955-6ff8-44e9-ac38-5e281cca0845");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "47e28fd6-ab75-4074-9c2a-2ba8bf20e114");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "484556f6-c860-4560-80ba-f81c9cd4f41c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "484a6dd1-0096-47bf-8cff-c056c883974b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "487dc810-20be-4f75-8e7a-31d9932db41d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "489af716-41b1-46c7-964f-42c9758b7caa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "48c1dce2-8522-40d0-b56e-d58d1c6f31fd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "48c2793d-fefc-4342-a35e-f1a028142c28");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "48f38a3a-dca4-4f06-aadb-55dc4111642a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "491dd9a1-d698-4c57-a937-9b2190d4362d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "491f7044-8c01-4060-862b-aef3bfed3772");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4929e58a-247f-4cbc-bc43-0d5669908064");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4935d76e-afa3-442d-a04f-5e3535f8c0b2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "494f5229-af13-4ec0-93cc-e1190559db2a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "49553da3-33f4-47e2-9727-b15d23d5d0a5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "49c478ed-e043-4d0d-8b82-1fa3f1d80543");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "49d3bbe2-d2a9-41f9-97a0-20118e223432");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "49d655fd-8f58-4c38-95ef-450b29b49617");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4a367fa0-7a35-4f6b-b18f-08e670b5274a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4a6dfc7b-add6-4fae-b103-6685fcc66257");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4a7cedb8-861a-4117-8154-dbd0dbdfe8da");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4af40177-ae23-48cb-9700-acc59af1a18a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4b095e54-0670-41bf-8c8b-73a98921e7fd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4b64e0ba-cb9f-4a50-98fa-054381291d01");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4b93c53c-6734-4aa7-8b93-21171cae6437");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4ba9a5fc-f36d-485d-9234-18c4b1d0f897");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4c30064f-9e50-4b59-9a8a-806bda8e40af");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4c7ce98a-3bec-42f4-a7e8-20917b41714f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4c900da7-4f77-47fd-8962-eab0b8876171");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4c977180-c444-4522-b6fa-a6f498091ed0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4cbf7930-c3a6-4842-babf-44a2f6c8ca0f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4cc10f2f-aeed-44ab-938d-bddb01632686");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4cee3f99-c658-4f26-b5ad-04f06b576ce6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4d2d1d17-a2dd-4c37-a024-5d39e9203bb2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4d4bb79d-b580-4112-8b6a-6f6b192d2313");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4d5f2094-d07c-4aa5-8f9f-c5ed26b5b566");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4d8c92b6-780e-4182-ba83-5e3c87a36819");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4d9f553a-3e4c-4962-9a14-261499077126");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4da9807f-caac-45ea-89cf-4cacaa9796da");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4dac74bb-76a2-4f28-a946-a2d8607da8ef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4db3b115-45e1-4c66-889e-1367434e23cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4dbd4eca-207b-4faf-bdaf-4fb749140d96");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4ddd58a1-689e-4890-99e0-ed5ad08be87d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4de19e1a-147f-45c7-8fed-38e2fc268d4c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4e00dfa7-d96b-49b9-ab3f-60135034e2ee");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4e2f0811-9f03-4724-ad14-9f1dd6fa0c7b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4e4f955a-862d-4699-b424-66ab593a754a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4e508866-4a4d-472b-920c-1b1c7d01a6f6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4e576e81-507e-41bb-9843-a67bd9d3673d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4e95e0e3-9111-446b-a52e-af1ddc3e2e09");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4ea89424-7e31-4b5a-8fda-3482a54849bc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4eb90b26-2e6b-432d-8773-e6a2b5f77441");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4edbc80d-1b59-4284-878f-9e98ed31c806");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4ee308bd-6d74-41e5-b511-27d58371c5ec");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4f06e4ed-b89a-446e-8546-27e216aca95a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4f21a28b-6a59-495a-ba36-a4f7ee256863");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4f36b75d-ebad-47cb-b325-f4bcd18e9ed4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4f71eb81-b798-45db-adc4-4fa70c0d21b3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4f9819f0-11ca-487c-a0da-fab7eadc1243");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4f9f4466-7aef-4199-812b-afb9bab41fc7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4fc9be93-233a-4143-a42b-89f0efeac19d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "4ff8c218-83ad-4250-90d9-6cd2848fd209");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "50211f85-0299-453f-ac7a-5ee64e2adc62");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "50318632-d4c6-4cbb-9d17-7827d8df69f3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "50335c48-72c9-48c6-af9b-ff0277344a67");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "504aa48e-1d73-4a7c-94e7-4dd9650daac8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "504e3432-bba1-4eda-9b1d-685136a4e643");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "50659eb3-79c7-4385-a555-b48eb174c2cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "50855a90-8b9c-411a-bad0-5fa71e5f4400");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "50bdb103-ee00-47d5-a967-00746449b7f8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "50cde61e-3579-4876-81fa-1bedc34f00b3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "50d89a83-f54f-416f-910e-710a245569ff");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "510ba59f-33df-4207-a711-3965f7b314a8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "511bbbae-c384-4db8-8e14-bcc879278b1c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "514031b5-9d82-4444-9c38-01ca8f705356");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5144fab3-c419-4486-9e73-ef20762695c3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "518845ea-de30-4549-b889-d0d12589572c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "51cb7efa-be30-4dee-b4de-842c9cbca237");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "51cc41a2-3de6-402e-b13b-e8b88a1effcf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "51dea00b-e10d-4b62-ae68-a7ea01cb1028");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "51f7c47a-a588-4969-aa5e-7c21a289c67d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "523331ed-8150-4e7d-8100-75f909532042");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "52b38626-79aa-4157-add2-7d47102b5e5d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "52b7957a-6090-466e-a4b9-d13f4dbbe118");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "52bbfefd-36f8-410c-a239-63f2adf9c749");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "52bf04b3-67c7-4fa9-bc03-ec428abf7d00");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5344aa24-14ab-4c94-a3ef-2c5a167c7a3e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "536eaa58-42aa-49c7-9508-13973120ca2d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5371fd9d-4843-4810-8791-c866733be891");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "53925fc8-5a25-4e39-b318-d1912754c8f5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "53ae1b46-5b6d-42c7-bad1-a5ced3783803");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "53e1950e-a06b-4511-8c82-c79e3c404c24");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "53ea49ae-2cdd-4c35-98f5-b47cc5fa29e5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "544d6685-215a-4b0d-82a0-f54e895067fe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5482eb74-4902-4842-8b05-f9d68f23c141");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "54aa6481-338d-4e6f-a437-01f06a2d62ac");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "54ac0f7b-e555-4dc4-b680-bedd292d0f57");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "54adb467-d34c-4704-a9f0-3da122776a20");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "557b2bc9-0a65-4497-a451-fc9bc5393714");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "55bd2b86-d4a6-401a-ad6e-d72c39664535");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5643a3e2-933b-4119-833a-220f7b484d17");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "56483f6c-2069-4e6b-9e44-0fa9e80d1a37");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "567db46d-e424-4b5d-84d9-e290ce21cd7e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "56aa268a-7586-4f41-a63e-1b88b1052871");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "56d5e3b1-adf9-404e-b8c4-4398f65aec05");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "57702f4e-da9f-4215-9da6-99387691b704");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "579c48f9-a34b-4f90-ab0a-8055a647c609");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "579eee23-6c79-444c-b7df-d74b75a2f759");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "57a3e08e-bea7-4950-8418-18bc338e527c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "57a885e7-d832-41fb-8d41-a5264aaf406e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "57b8e2eb-9207-4d40-a9ec-d4b3f1be00ca");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "57c40b5c-219c-4d06-b309-c077dd57cad4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "57cac9f4-58ac-4b24-9943-ccc353065f40");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "57cf46f7-23c4-43a2-86e4-547ac6eae5c8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "57eea136-9639-4d2e-9a43-c2ab931482fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "58196c9e-cb5b-4790-9780-daa93ec1138b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "583a00f7-bb1b-4386-b7a5-dde1dc2de439");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "58600458-e4e2-41b3-af5d-962721ce868c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "586d070f-3007-4a18-9751-c6313c86b200");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "58c42ede-4093-429f-82ce-0440ba68f1f5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "58dcf3c9-b637-4792-bab1-fec21cd6bcd8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "58df790f-77a7-40d6-9140-0a7b3645c907");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "58e04ed0-c899-43ad-8264-0befffb98efb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "590c55ba-1f97-4302-8cdd-43f4cd6a5ed9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5928329a-7437-4890-8400-2763dfd14c70");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "59348e62-5a13-4aa0-810a-f29f4fc3b4d6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "59875603-fb1e-4bde-9018-f526ac9c711d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "599b11a9-c9fb-4d78-96fc-bf064da19425");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "59a133fb-0a61-4103-be7b-2e4b6549114c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "59abcb95-a48b-4850-8f11-5ecb08145807");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5a0619bb-0afe-4b20-9538-e4f0f2ccd0e2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5a0e44db-5494-4edd-a2a8-c987491c94c7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5a1bccdc-f64f-408b-84a6-ede35b4a6b66");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5a21bed7-5e4b-475f-9c3b-da5997b58808");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5a31cb09-3dea-40d1-99a0-53388554ba1f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5a6ee400-94f1-46a4-a082-2f46aa1cb12b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5a8251df-448d-4395-a2f6-b97fabb7da6e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5aa6480f-ea36-4e74-8087-d9bc10fc02b6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5ae24a3a-9113-4a13-9c94-3495c91b0a95");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5b56e78b-a2fd-4d86-bf33-a7e6f10c4734");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5b60a81a-d589-4ba7-a1a1-bd42f491c891");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5b66ffed-2793-4789-a1ca-c22999ec44df");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5bc6ba7f-e2c1-4dd6-b3c1-c756c227439a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5bd2d265-90f9-4ff2-9e30-bcacee72973b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5bf635a8-abb5-4cec-ba46-550087ff270c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5bff1b84-7895-4ca4-be4e-d85cae7f4311");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5c236a3a-9d5d-4ff0-a3de-60518e3746db");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5c4be556-33e8-4cda-a732-81076812c6de");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5c5c29e9-2160-4a1e-b5b0-f3316db8f158");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5c8c87c6-819f-4b5b-a423-732368a51f3a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5c931468-9cc3-48c3-a019-be780ec00806");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5cac14ac-fbff-4d2e-a6a7-3ef5ef994b07");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5cd841cd-301e-4c18-9580-8219f215e8b2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5cf79034-3cd7-411b-b4cc-69739a8098e8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5d0c9d1f-579c-465c-9be3-094f72748dbe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5d2a3ef4-e3ed-4c9f-878a-fe03c8f3f22c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5dec01dc-14e8-49ff-97df-50ad894990bb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5e082d50-ff10-4259-ab9f-d82efd94b791");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5e484f47-1ac3-4ca9-a148-010ffee4a388");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5e929cc3-99ff-4bdc-b9a3-88b96f7c710d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5e9c8765-cf11-4dd5-9c5c-21f10b1b8628");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5eaa0850-18bb-4f49-96ef-cdeef89a4688");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5ead6ea4-901b-4948-95db-aaeef558088a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5f27259d-62b4-4076-855f-7359a9e03d90");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5f374ccd-2852-41f4-bc37-6d7753c47a25");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5fa8fe7c-7112-404b-aa3d-b4622d6fcee6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5fb1c2fc-7295-4fd5-82a8-242eac88ee6a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "5ff397e3-fe1c-4ed6-bebc-8fec08b83d1b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6039bb9b-be56-49f3-9f6c-21d9c0291995");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "604471a8-5811-454b-8777-ac60664d5048");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "60a99978-18c5-4085-bfd7-009b819f381a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "60b204a6-5ae0-403a-8869-efeffd1f2042");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "61264ccb-f17a-4809-a564-19de4a99c6ba");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6132967d-2bf8-48ee-a7da-94b69aa1f7de");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "61c1eb3b-92e7-4b81-a2f1-1eda8cd51a8d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "61d24355-18c7-4277-8ad7-18104fa448be");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6222f29c-25f4-4059-bdaf-d40901e695b3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6224198a-b52b-4506-b47f-65d9f8cf497e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "62576241-5a40-4aa0-b04c-e4c044ca7f4e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "626254d9-3d0e-4c1d-a0e5-27fe09af0daa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "62a5888a-e95b-49c2-9a19-d85755706b61");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "62cf5bab-28ed-46ec-8b21-3660b92f9ba0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "62f0e495-d4e2-498b-895a-f292a50ed3e5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "62fe1ae6-0706-46b7-b7de-1c7b5a5663b3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "63296bd8-c67a-404e-8d1c-1653c598eea2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6337f0ce-82b3-40d4-9c25-ab43061a8d05");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "63702245-7216-4979-990d-9b88faa69e3c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6389ba45-df3c-45b2-9081-dbc7c542acbf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "639e48cd-cf8d-4a04-8007-99562e1ef922");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "63aad25c-aac1-4644-89ea-7983b4b64d3c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "63b3dbb9-494f-4894-9283-37cd156d42f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "63bae896-cea1-42bc-88a4-be12acc1a074");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "640c1d0f-f6a3-4e9c-98f3-a2816192cbfe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "644ad96c-7253-4a6e-8f24-5bc06c0ece57");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "648c7816-2ee2-4a83-85aa-79431ae01b64");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "64baa4f9-8baa-46fa-98fe-c31e458c564f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "653b4a3e-6d9a-4b83-a646-ace60d096c98");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6565a868-8448-47e6-918c-618d09f6469c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "659e89df-5126-4c11-8838-7f1b70c2036d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "65b24f6b-c1dc-4f19-890d-fbccc38451bd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "65d461d9-1fe2-43dc-9351-362e0b6dbae6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "65de7212-bd87-4e94-ac78-1cc879a59992");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "66266d9e-7f3a-4b93-bb18-b7c399eb035e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6657f112-eb8c-43c1-b418-20d05977011e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "666c9a4e-c9d6-4d86-aa3e-3071cdd43d32");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "667f3beb-b090-43eb-a981-f7e010b276a7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "66a13778-0996-424e-a8cb-20ede0deebb3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "66cbf64c-70d9-4ad8-8b69-16e281a7589a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "66e15085-4ed2-4f99-ae90-4029672b030e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "670b2381-677b-4210-8134-0f6bafe26b83");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "67243634-ddd9-49ae-94f3-9500a8a2b851");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6731e020-e23d-4131-ae73-7791115b685e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6732a9fa-6e8a-463f-b380-ef4aa9881b82");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6740684e-b6f6-4ed1-a447-91844e4d4040");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "676394cd-9921-4da3-9460-62ec9383d5c4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "67726cad-a4d1-410a-880c-0a1dd93311ea");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6788b5ed-e65c-40c3-a2cd-e843e8998fe3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "67a4b375-bcc9-4abf-98c4-c885e804fcbc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "67a6a363-e586-4dcd-b07d-de316eebaea7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "67d11c0e-74aa-4107-872a-18fe949909fc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "67d1b008-7028-4415-9adb-49c01f80e324");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "67f06bff-fb9a-40a6-9404-e433ce4eb309");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6836515c-f97e-4c71-a4c8-a43f130f6aca");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6852c113-8bf4-4efe-8c9d-2bea9027c854");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "688e6c77-2303-4c19-a04c-f257b410417f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "68c28643-4f99-4562-a66d-c0b395f594e0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "68cada47-37c6-4764-bad9-dc9e044161be");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "68faf6de-c85e-4de1-8834-7ec68a0522b0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "691f8e21-d3fb-402d-928d-ab7e317edcb0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "692250c0-3218-4045-873e-1394f1c178ae");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "69516fb4-5d5d-4fd3-ac4a-51bac4699af4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6952ceb2-20b1-4cd7-a808-ff318dd2d44c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "697ab91c-f28d-46c1-8f8b-123aaca5ab6c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "69ace961-899b-496b-bcfd-c888449e3a6b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "69ce8722-fed0-4014-8ab6-347dc2954d03");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "69f019d3-8de7-4300-9dc5-798e2ac235ac");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6a003afa-c7bc-427f-a2e6-3246e2352ca0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6a16c818-622e-4215-af57-bcc4d778d249");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6a1d2a55-e7d2-4aec-928d-f77d277edd00");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6a4d6ebd-70e5-4ea2-ba49-d0b1e1a91baf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6a758e7c-1bcd-4b70-bc65-3d58e558a8de");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6a7e073b-cea0-4ef0-9d26-065b4dddbc0a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6a9e0e9f-fdab-41b2-8fa6-34d0e5b7ef54");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6ac7236a-4172-4b88-974a-6d457b3ceaf7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6ad6bcf1-6feb-410f-9e66-c24aa7e581f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6b05db99-0fad-4912-942c-4a1ac3b237ef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6b0abad9-b4c3-48af-925e-e4a9083a2a04");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6b312dcd-75ac-4085-bc4c-b8b67358b4f5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6b97c540-b1df-451e-9971-dd921bfc8b81");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6ba344e3-73f7-4be1-82aa-52699fe69be8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6bac968e-a1fa-4bd1-83d2-c1f8f36b5e18");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6bdd7450-c448-443d-b9f3-268a0edbefcc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6bde3fcc-a0d8-4dc5-8c36-2097168574dd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6bf541e7-b3f1-4635-b09f-3cb082b6c849");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6bfa4ffc-0598-47d2-99e5-af6445b70982");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6c03fc84-2fe8-47a7-80a9-e0ec200b0841");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6c7bfad4-17f4-4728-be97-6679062d50a1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6c83797d-84ec-4a16-a9b2-64617761a9e1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6cddd617-1e25-40bb-bb09-747b58e73927");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6cf9599e-047c-4251-b6ee-69a313c95940");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6d0e6c95-c4e5-4e34-94a4-01638dabae83");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6d16a8ed-ede9-4e19-875f-d29acfadbee0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6d3b4b70-6816-4cd7-8dbc-bb626e1eac15");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6d4014bd-22a3-4cc8-9fe4-b4e8464e4c4d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6d5ee335-1cd9-443b-bd33-bb6ef9850507");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6d7105a4-ad81-424a-bdc0-c194b6e6b768");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6d7ec561-d89b-4955-b84f-5565787ce273");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6dad00cf-bf79-4b12-aa1d-00ee5188c21f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6dc9724c-3369-4af6-a6fc-a48b9c45763c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6dd3008f-60eb-4adf-a544-79f1b550adf6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6de459fb-5763-49a7-9ca2-e08604ba479a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6dfbec91-d61f-4e79-b23e-9f51959b48ef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6dffd7f1-b016-4bfa-a028-57b80bf8f8ab");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6e28ea63-9282-441f-a78d-25123e080cb3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6e329024-0753-46f8-8a65-c04e30d3a27e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6e600b3b-262c-4d53-8ad2-75f3f48d1a19");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6ed180a9-2ef6-449b-a8eb-e72b30448475");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6f1ef1b4-30b6-4827-8f9c-512da973943b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6f2906af-494a-444f-a792-1f8fe7c4f72c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6f750772-8c03-420c-a817-4517dbf4599a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6faa899c-78f2-4bfa-b846-42530ac8d7f5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "6feac267-8722-4cab-a409-c8cf6100e17c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7005eeec-eabf-41ea-a3f1-d7e09a8fd328");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "700bc735-333d-4c3a-9df5-08ef247e9d5f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "702a35fe-b371-4dc2-97cd-95ac6c918fb5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7040d484-6c6c-4dfc-a1bb-f17d5e0f8c5d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "705e5003-9cb9-48ae-a84c-ed85346e827e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "70619649-7a7a-454d-ab4b-1b354f3b95f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7065b224-b609-48e3-8b36-5209ae838875");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "706766ca-af24-4745-8856-64166381dc3d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "707634f9-add6-46bf-adec-9f09160144d8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "707f5ec1-5b5b-4295-a0cb-9a6ca9a5864f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "709037f8-6fea-4975-854c-eefd40dbd617");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "70ade993-e466-4c61-a3ac-108874055f7a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "71064c7f-f8fd-4e8d-a9e6-9a59c337ef60");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "711c6541-53da-4fe4-b398-6355a94c1e8f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "711e0a89-d419-4fa2-9ef1-3515d02589b0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "71359dca-3cbb-4d0f-8901-47084c256203");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "716f3040-a6c6-4cc0-8c63-32907239fa5c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7195ff8a-a1f9-435f-93eb-50e771229d73");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "71b5bbd0-7bf5-4955-82e3-5bd9958692e7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "71c0f848-5bc9-4125-9980-a6cd3e12f1b9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "71d26e91-ac15-4406-90aa-9a313496a8aa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "720a8b0e-34b4-4511-95e7-7f492aa5d925");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7213125b-b48b-4070-832e-d32fdfd8898c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7267736f-4023-417c-9d48-3d30e1e5d21c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7292b8ca-5fa9-4f63-8f1f-6938c798b928");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "72ac41ae-7aae-411c-9420-f557c846212d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "72be5425-5cd7-4ee0-a6fa-38d55c51789b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "72dd1bef-8351-491b-ac1a-5810cb79cee0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "72e7307f-6f19-48f0-b707-fe3de6a0acf2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "72fba48c-0fbb-4931-951c-032c9327e762");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "72fc4685-3de3-459e-a86d-e9c6a86a645d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7303fd16-0d1b-4412-9885-ba28e32575aa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7313f512-ec09-4349-a823-1dc4d47919bb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "731eb402-2c35-4454-9937-609edf2e0c9a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "734e880a-b25d-477b-884e-179c367bb47b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7367eefd-6834-4a91-bd23-e55f5087c4f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "739ebba0-ee4a-4849-ab6e-2c8bbade3afb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "73acf83c-c5a5-4ac8-b8f9-1b9db71f8dfe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "73c55aec-b4c3-41bd-babe-a0ce758aab35");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "743ef2da-50c7-4174-99e0-0df9a48ed8f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7450dacb-c8fa-4798-bb90-968688d398ad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7451244e-d553-4d92-8061-7388861e60f9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "74b95255-503a-40bd-a983-f98a6a44cd75");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "74d937f9-d0fd-4ad8-9dfc-ec03f498d1dd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "74fba896-59b2-4b88-810a-5f4c5f1cfc17");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "75110bf6-df66-41be-847d-9ec87263aabd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "751470e0-e49c-42c6-87d8-a70d4f4feb49");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7535ff5d-d8ac-4d28-9ae1-96d5977507dc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "75424c33-a840-4306-aeb7-869db752c4a0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "75c6f43d-0991-48e0-b285-adbc3f9a634a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "75f1d18d-449b-4de3-b658-e08bb9465f9b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7627c920-75c2-4578-9c87-34a856bbaf56");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7638d81c-3916-474c-9c60-2be6ea9d5644");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "76714758-dbb2-46fe-9018-36815f4b1374");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "76c929a8-a67d-4dc4-a61a-2ac863877670");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "76d0653f-ac16-4a55-bef5-35d2636207dc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "76e76fd6-259f-4c08-aa5d-b6be67cb9930");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "76f600ff-e927-4252-b064-2205c06ee26b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7716241a-c7a7-4c8d-85c2-7fac1fb8fe32");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "77329784-278d-4123-9ae4-abf415082468");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "773c6347-11b5-4413-bc3c-9d95b92b4dbc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "774b4d54-31c9-4ce2-9bab-0f4933afce5d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7761e4e1-875e-48b8-92de-2859b4db0996");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "77972257-b0e0-4322-b509-478c39c86938");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "77fe1e90-ac88-42a5-8d86-88a88fad0b64");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "782622ac-52fc-4b30-8d5b-8e5baa935b86");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "782a05a0-ddad-4d6a-8c39-521fb9c4911c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7847d28a-257e-4962-8308-787862939728");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "78487a50-5648-4b46-b4ac-b3a99f73a301");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "78525094-2625-4f14-a15c-08bcd9985651");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "78594b62-67de-4e82-b916-1db0f14906fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "785bfc07-8883-4772-be5b-ed82cbea7265");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "788816df-50e5-414a-a4f6-a43df0837565");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "78926f1b-37e6-430d-b0f9-0f4a0df7e859");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "78a213ca-056a-493f-8888-b0d55aa2bbc6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "78c4eeb0-0e4b-4e76-a9f6-cebab95790a2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "78d87273-e3c5-4b40-979c-1e36afeeffdf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "791087b1-2d8e-4671-be8c-383770b75ad0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "791849c2-4396-4099-87eb-48f6c72fdc9d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "791d7f1c-606a-4167-a3e0-9800f24211e6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "792b69c3-19e3-457a-899c-58d48c6f9ac7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7948bf91-ca42-4b95-a2cc-4c8947cd155b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "795bf99d-57b3-4036-9f74-7c708a08109d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "795fb9c5-b8ee-4158-b364-c288e407151f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "79707752-2116-4a4a-83a4-b8c0c5989061");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "79f2cb94-93fd-4cf8-8f14-4175333dbfda");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "79f697a8-4e13-4ea0-a8fd-734d667f9bd6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7a18779c-c210-4085-a5d2-7c3d08acf1be");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7a245e0f-4bfb-4b2d-a49a-537cea020043");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7a3601c4-6b2b-42c7-ac64-1374be01cb6a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7a69561d-a527-4104-a177-0defe0dc0ebd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7a79bdb8-cfba-4eb0-86d0-08b39dfe8b4e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7aaf561e-6295-4ad1-8b00-f890a1ac4a7a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7ac79105-e467-4312-a83c-81533fbba2e7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7aca3b4e-5bcc-428e-9321-50330d358b6e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7ae56436-cf64-4ab1-8427-84dd0fcb541d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7af73f97-b3e6-436b-b543-0457a8e0ce37");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7b03d0f0-d8c2-4a4a-ab41-e96eeb40a709");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7b3617ec-e472-4cf9-bd7b-c3d072cc7efd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7b871f88-b595-43fd-adba-32c880cbc731");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7ba538d7-2467-495d-9caf-8608474e3858");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7bf80cb8-05eb-436a-a017-e4aa66f47fe1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7c049d28-35c1-4bc3-9b07-ae2ab1303959");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7c625622-ce8a-4eb1-923d-58bf1979d668");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7c7eec25-5ad6-4091-aeca-71c15318563a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7c987f42-924c-462d-b99a-bdf6d05c35c2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7c98ef1e-8f81-4b73-8c85-264535dfb2fb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7cbdeb32-216f-4a66-80cd-bd37d0d20c3d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7cf1574d-0bab-432c-945a-d972730c89cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7cf96bf5-4272-4bec-a88c-7957777fa596");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7d1c169e-77a6-4704-9c59-763ee3f5d282");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7d1da5f3-ec98-4e48-9a2f-26d0c3201526");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7d28f448-ffe3-482c-82de-85019fcbc3dd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7d3a2ab2-41f4-4d25-8263-548e4925d6f7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7dbd3a6a-1d1c-4b76-8204-0b17c9864456");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7dfa1ce7-50fe-4db8-ade4-9141d5036123");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7dfb6baa-0a75-4e5f-82ba-44067a23afb4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7e00330c-ef6a-4dad-aa63-129fa03a08da");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7e2083d4-0950-4140-b096-16a486bcaa6d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7e21567a-3a41-4c7e-85ed-647eb7e2a5d8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7e25dc90-a59d-4cb5-ae02-4a44b40acfe4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7e339537-4f34-4ed3-ba49-bf9ed7b92701");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7e4b5680-98cf-473d-9a1e-2023d3d4a291");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7e4c89bd-3ad4-4f59-a987-bd1900b1254a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7e68227d-da14-4119-bf20-ccd4f94c6938");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7e791045-fcbf-4ad0-a76c-96eaa3fada26");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7ec056b4-667f-4577-a514-b76a7f2c3728");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7f1e34bd-1087-4db6-9237-885ff826c7f8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7f39636c-7f31-414a-92d3-cc9966244bf7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7f41471c-098b-4e32-8b60-e23d7ac8ad51");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7f488780-a705-4aa3-8340-c1a277b16b41");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7f5a1214-d6f0-4710-b502-082c4a92b90d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7fab0c59-5ac0-41dc-a90c-0efe359ddc15");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "7fd141d6-5bd2-42b0-aa17-878b8e52bbdc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "803bddf8-df0b-429d-ae51-7d481951dd98");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "80493690-d12c-4ecb-826d-e193d0627f98");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8068778e-839d-4e74-843c-f84658d186b7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "80a4de03-61ed-4816-bd6a-a1bf3393a34d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "80a954df-8572-485b-926e-828f3af54de1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "80b9227d-cead-4b2f-88e9-4a41a84485c1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "80c5d966-843f-478e-8618-ad513f23b607");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "80c80e16-5250-4f97-b778-f6ff3bd834db");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8154b47b-487b-4500-ab20-ed33e3b89091");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "815f5372-e405-41be-a436-7c386c00a329");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "81626b8b-1b80-478e-b659-51db4bc6a709");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "81792a88-46ae-40f4-95fb-291fa8f1f575");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8179358e-fc88-42a2-b645-91813d37f375");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "817cf1d9-fa5c-4dd4-8070-632428a2e5f9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8188fc18-ceed-4ea2-8ebe-f4a62e0daa56");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "81b2c8b2-523e-4bdd-a428-881241b30af7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "81d9c59f-4517-40c2-98ac-44a24860655d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "81eacc2c-83ae-4b91-a409-53c2cb797f41");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "820ca54d-62ec-4d48-a8fb-f91eea675741");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "821a6c0b-279c-40a9-ac84-cb7fd563fc0f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "822a2bd1-bbac-42dd-9681-8acd050e842b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "828bd156-bb53-444f-8130-9a74c4fc7e94");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "829ff184-eb3b-4e82-b61c-57ba44cfe8b9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "82dbdab5-0c81-443b-9285-4e63a6952803");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "82ebeb14-8b85-4714-9ec9-3da070bb8129");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "82f8640f-fa8b-4c73-8c1b-6eb0a3522ebc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "836bf73c-d5b3-461a-8f6a-ddf217a2a9f6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "83a0b118-011e-4b65-8800-ee797367fc8a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "83c66b95-c7a2-4bf6-91c3-903799436531");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "83d5abeb-7e16-4e2e-9fc8-251c5e832708");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "83dbc3aa-923b-49dc-902a-7c419f8c5383");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "83e0d399-1c61-474d-9f6b-70ca06c1176f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "83e8c8e5-35c9-4353-bfb4-37e82d01da2b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "83f7f87b-cc27-43ea-9d0c-bc1220ae7366");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "84051aec-19be-452a-b0ed-9b0a147d2f73");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "84b0bacf-176a-473f-a0a8-e01ed7333885");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "84bdbeb7-0662-418d-98f7-130c2e519f31");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "84d22f15-c9c6-45d3-9a54-af945b31ddf6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85016b36-d3f4-47dc-85c2-7ee5fe895bd5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8549e462-6f8a-4064-9f9f-a3a5733c9783");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "855bc56c-32cf-4560-b270-21b15d527c78");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85614743-2f0b-47fc-ba40-002700894cad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8573258e-9f0e-4d49-b5c3-33a31a35b8bf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "859490e7-76c7-413d-be3b-4ff45ca3e60b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85a402f0-9d6f-433a-941b-a8d893c97fb3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85a8e18e-5819-4c79-baa1-f66dfedd84c6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85b02163-53b4-4a56-9058-81a48f65ed3b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85b2d4ad-32c1-4652-92db-e9e7aeeae307");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85b584fa-aec9-4a65-b4a4-7651c32373db");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85b593bf-14c1-47cd-a964-0367478ee89d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85d25207-ba45-446b-8ade-9cacf95130b9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85e338c7-bc84-424d-a913-3b4b57eb416a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85f1dcf8-97fb-486f-8127-ad1464ab0156");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "85ffa178-1259-4c0d-ae76-c6a1fb56d694");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "86244ed5-85f7-4d92-bb51-ed19eba7fc3a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "86c6721f-a17b-4183-bf61-595f427affd1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8705d2e1-988b-4b6a-996e-a13125c97620");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8759d867-ba24-4bc8-87f7-618bfc67352d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8790f47d-842a-456c-b209-541ca4fde397");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "87a108c0-9e02-4c81-8969-ee30caa175fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "87a6dff5-56f3-4f34-8220-672f39c43d2f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "87a82512-049d-4215-953b-be8725ac39c8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "87be2551-e587-486f-b76a-9d354ff43a76");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8804303a-d24d-492b-8fed-e6c55d30ad05");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "88092189-d7ed-44e2-b79d-7ecc0b8fb331");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "880a6e55-0f1c-49c6-ada0-46127d320a87");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8850f205-d8e8-42dc-9e87-03f38fa8a923");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8864028f-5c57-48e8-8e3a-dcea93590bc7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8874fdd1-de57-4afa-8624-106907d042ed");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "888d1b75-d1a9-4c58-8620-b819954058ae");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8895b756-0a6a-469e-aa59-34bc9cafa616");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "88983746-1092-4628-9a3e-c2adc7e1b50a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "88b22ca6-b371-412a-9a90-ba93ae7efc09");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "89101a6b-8d79-4cf9-a785-60829933535a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "89b948fd-ccc5-448d-8d23-157ae0702296");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "89c0efd8-387a-4098-8484-08a78e6dda29");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "89c66114-0977-4c4a-b43a-e0504a78cf34");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8a00213d-c364-4fe9-8c34-b8e68263c2e5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8a2275e6-ee94-4f17-aa6c-9f8998bd08a2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8a4ab805-5913-4593-b16d-e143fb451966");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8a6a4c47-eda5-49b9-b61e-158e7441c4cb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8a761d59-15cc-47ad-9e88-220711fee7fb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8a7b0609-f226-4e09-9dfc-ba63ffcfec2a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8a84023a-12dd-419c-8e2d-6f521f190e11");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8a9b7870-273b-4fd4-a561-217e9092b214");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8ab82a78-bd8d-49f8-8aae-040ef3d456fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8ac34fae-385a-4cbf-a7d3-8fb9efe4637a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8ae59605-9327-4794-9341-b34d320523f3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8b336435-cab1-4e1e-bae2-929b39850cc1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8b5e1d1b-9bb9-4b79-81ca-1911071e5a4d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8b6f1eb0-52c8-484f-a82e-3bad0bbf0199");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8b93136f-5bbb-419b-a636-0105d079e9dd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8bcfdc05-d5f7-4939-811e-b077bfd45a69");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8bef99ea-7a9a-4af3-bd37-571ff1fc777d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8bf619e9-8204-43f9-8e29-7e3353f7f9dc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8c27bf4f-7015-4da2-aab6-dd15985e02be");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8c293b95-431b-4b90-9610-d5494e83dcf0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8c3ae15e-5caa-415d-90de-94a791b0a928");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8c49f7fc-13b7-4c20-b683-4e7f97ad9053");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8c502019-e150-42f4-8305-5f39937608cf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8c52c610-4bb4-45a0-9329-1d0a88319aee");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8c5695ae-fe48-4973-8a19-7620531adce7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8c9f94e7-dd24-4134-8cf5-c5b7611ba236");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8ca2504a-a554-4612-9571-be930ec742da");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8cad7133-14b5-43e1-97d2-898a6d0bd8c3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8cc4f4ce-42a3-4e14-a3d0-ad410c9d39c9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8cd30713-8051-447c-b8f6-207f27da8529");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8d06f48a-5004-4e32-9d17-6cbb90dfdf86");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8d33833c-9855-46b1-846f-bf455d44271b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8d39292f-2edb-406e-981e-1b23564cf6a4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8d4c61ef-886d-459d-8b41-ba58db75f47d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8e0ae00c-f088-4398-bdd8-2111e7edc581");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8e661d43-a207-4c40-9d7a-66e34731b32e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8e763fcb-fd06-4c05-8242-858f4b3f7d4e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8e8fd02d-447f-4a35-98a8-847f6c2c05fb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8e9ca9be-2411-442d-a968-25dc7dff887e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8ec8492c-ef6d-4aca-91d2-5ff259eb636f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8ee64b1c-030a-46b7-982c-ed304fb0d776");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8f05eb59-19d3-4997-b531-b7478fd4d51b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8f274448-920e-49bd-886d-4f7821c0607e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8f328783-d152-4296-a695-b41ede28a275");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8f794519-1cc3-46ef-a895-83d79e5862ad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8f92deea-9bc8-4c50-b45e-be37eddd59fb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8fb9e0e3-1f42-431f-a5cf-3624c64419b6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8fd2fe18-6d39-450c-a92f-ebd04068e0ad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8fddb93f-d615-4a55-aa38-650c3edb2de4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8fe11a70-04bc-4ca3-9b87-c3a674647b6d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "8ff65797-383f-4437-b079-8878afde5041");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "901e1d48-86f3-4a85-ba8f-e9df0fe1937a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "907b2ce4-616b-47d0-90ab-1074ec9a712d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9087582f-21ba-42e9-8081-055e848b4bb0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "90881ff4-8ad9-45c4-9f7f-286492fea7dd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "908cbce3-6a44-4ea2-80db-6123a6f127c0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "90a77529-43a7-45e9-b4f9-690bf373e088");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "90b81130-a0bc-45a9-a340-0b931eb698e3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "90d69fc6-0603-4414-b843-bd8d3bfa7232");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "90fc1a9a-7fed-4029-95c5-28e13c0d1efc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "914dd14d-1bdc-45b6-87d1-690838367c71");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "916103e0-65fd-4e17-b074-164643a25928");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9171d7fd-21eb-4e86-bffe-dc5a1e2895bc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9175d5cf-2863-4ca5-8a39-e36eb8fc386e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "91841af7-797f-4b5e-adfd-d804cbac3f61");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "91a9f6e5-3f06-4e5b-ad39-9b267175b851");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "91b8e8b6-5255-4b2f-8d3a-c70675b7eb78");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "91bcad0f-a6d1-43f3-9a64-f39038939353");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "91e04afd-d694-4672-9c6c-d6a12bb90ea0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9269f4b3-0b67-4556-913e-d31342c457d0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "927420f7-a2fc-4b5b-afd0-61f85855eb1c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "92762d1f-d92d-44b4-a42f-716359d405db");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "92c17309-f525-4b0a-9bc3-ea4e9b80612d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "92f229c8-3fb5-408b-ba7d-0ee388d5a10e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "935ed992-801b-4b43-9de7-8a0782d11a7c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9366fbf9-1f31-40c2-bf4e-0b85d1e47753");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "94002574-90f8-47ad-adb3-7c719fa322a2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9409c247-5c5f-478a-83c6-af4e39f6329e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9430537d-e5c9-4d60-9f10-f3a8c197dd63");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "944d41d0-3bd9-43f0-b2f2-c715c3e3e78d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9472dc88-1a6d-4dce-b96e-4ff49ed4804f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "948b7f0c-9e25-419f-a078-d771a045aefa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "94b7ab41-2df9-4585-a2dd-77de9606672a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "94c1ba88-b63e-4055-8a10-78a4360773b1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "94dfe016-23d4-4524-9717-0044ce8c85ce");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "95077bff-de1a-4f02-9d2b-eecef7deeb2a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "954955fe-2c08-4a22-abf4-cb0fffb3fb94");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9562f432-ff81-44e7-8b58-ea39c7aa3873");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "95704f16-9c69-41a9-9d11-1057395af15a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "957dfe2d-1eb4-48f0-bd16-940851cf6a9e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "959ff4e8-4a0f-4721-bae9-860d2a247d07");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "95a64f44-52a6-4941-9e48-a54593f65b63");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "95d24ce2-6f6a-41bf-830e-ff950118cd9f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "95f868bc-ddcf-449c-a6d3-7a864a85dd95");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "960b12a9-e081-44e2-bba4-cccc4f7f93de");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9611da4a-80eb-474f-ab54-ad01f413403d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9612c3e0-ad88-43a8-a95e-3bfb177f74b0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "965ee575-3558-4b19-bc32-cc631b947905");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "96bc401c-6b18-4c9d-b482-15b6bc13ae39");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "96dbcb92-23f8-4e78-a144-be43767df73c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "970176d5-78a6-4db8-afeb-9f9689325780");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "972759bc-5ca0-48c8-be16-d12c6d1eb740");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "97313118-0025-49cf-9f08-0a3895c176ac");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9792794f-43c9-401b-a507-3e9e1cc1e7a2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "98060c08-9066-426d-8e4f-271e305b5bec");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "981a8fc1-5c6e-409a-a20c-76bb3c0e0c22");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9829d4f6-c052-46ee-bb0e-55f7e3c25479");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "98453ab5-9c53-45c9-a05d-ade5606253e3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "98b62911-2e40-4b5e-893d-aec138248179");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "98f1c4e3-b742-4b38-9642-d24925705d6e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "990e998a-9b36-487a-bfbe-897a4b442ade");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "991e3235-d2cf-49fc-b30b-ca1ec03d5738");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "994109c8-759a-4cb3-83d1-303e709579cf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9966d775-a6f0-4832-9406-3fadfb13d213");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "996e00dc-bd67-404b-8d8e-d8ce009f0b36");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9983687d-6366-4da8-8076-b95f6f24c5e1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "99ae43e9-700e-4c7f-9085-db682b7c39bf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "99b510a1-0ec7-4fb7-aef8-cc747d629823");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "99f2ac42-a6a7-4693-a403-5f27bfa76b98");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "99f8d4fe-804c-4203-8620-10ea0abba0b2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9a11ff57-2f88-4b3b-93f4-86e9052789d4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9a1478d5-0edd-4425-a1a8-bb3820c30917");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9a740bda-8a5b-4350-aa89-5aec7891002b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9a7da55c-4b50-43ab-88ea-8449ec198250");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9a913f05-2c11-497c-9965-2479b03a6a06");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9aa3d69e-9aea-400c-bb23-57fd95909ad8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9acfdad5-39a7-42fc-824e-db69ce5ae2f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9b5155ad-4088-4a9b-95f1-1f7f6cb9b093");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9b53318c-fcb1-453c-a049-6ce08f8401af");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9b57dae5-e9e4-41f6-9599-e5a39bde25b1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9b69601d-d687-43a4-8103-6f82e4bb79b2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9b8d28eb-43e5-4b38-bb9c-af970464a2be");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9ba34e0a-a1fa-4114-ab9b-894ce74fa6fc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9ba842cb-9d11-43d3-8128-3dfc9fb2a3c9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9baf0c1b-7417-4f0a-897a-94053e9c27dc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9bb374a4-eec0-4819-bc05-e4c0b288fb1e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9be5883e-ecd0-4d5e-8f89-88af04314e72");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9be83dda-4abd-42c8-a35e-630c0f7d8d83");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9bf024e2-7c4c-489b-a06f-8b072e5a1a29");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9c2aec1a-6e6b-4ce5-8d98-c244e9d3a74b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9c390483-e115-445b-bddd-7341ef597e9a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9c3b86e1-7f57-4012-9448-38e8711ea7c8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9c6325f9-b906-4fb6-b991-516b93ee9ba5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9c704352-b8a0-49b8-8c87-20b05bde2f6f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9c748a4d-3c51-4786-92fa-cdf1d7bd7c88");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9c85554e-5958-4eda-858d-dc59e3b3b1ed");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9c9da46e-26e5-40bf-a404-245d9bdc57c5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9cb22cfe-8990-4555-9a89-b6fa726dc7d3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9cb86ecb-e20a-405d-9f71-cde8273c719f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9cbc5134-0ca5-4bdd-8cec-ba1b4bfd7566");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9cc65640-1d45-4baa-ad8a-69dfc07c4ed6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9d02e00d-d3c2-40fd-ab45-fbab6ccc20a7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9d0417e2-3e2d-43b2-b8f3-ba09991bb2e8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9d0c8ade-e057-4356-9e8d-66c5c34ffb14");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9d4dc71c-7de8-47a7-ae48-ad33f0f4b205");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9dc6ed82-efdc-47ed-88d8-8b5bb8cb0b4e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9dcbdbae-4add-416e-928e-524445264f35");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9de4785e-7329-40f6-ba98-94aa50e707f9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9de9ad2c-76ca-4e0d-949c-9c8562aae07d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9e61fefe-db34-468e-8290-be545e027999");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9e7e173f-991e-45dc-8050-bfd2532811b1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9e88039b-00f1-4cdf-a611-8b6fb63de0fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9ee6f6a3-a035-45cf-9a26-7be31706b37b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9f5d212f-39bc-45e4-8560-faa334fbe4c4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9f8e7a5e-ef29-4dc6-95ad-4a5eb673f603");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9f9f7bc8-0079-4ce4-a8c1-0048f7e8421c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9fbe41f3-10d4-41b1-b7c5-0a3d3096c43e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "9fdd136a-6b6e-4798-b800-bbbf4ac0c0d1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a00e1bb6-8e66-4935-be3a-5c559947075d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a0407f61-1469-4c5f-a2d0-1762ecce10b3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a085e987-0849-4381-aa8c-81961f79a4b1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a0b9cee4-135f-44b0-94c4-677f91bec03b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a0e94a47-cc5d-412b-9852-1aff5095232c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a0f36c79-71ca-4f9c-9042-4979287b6858");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a102eb29-8332-426d-ad0a-726508ec1a28");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a10ffef6-f727-4bc6-91b2-4b87811c768e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a1207a34-a3ed-492f-b118-96edea039108");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a12e1f4e-4567-476e-94e8-a4b45bec5868");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a13d4831-3d58-40d6-8601-c5d79d9cab31");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a1405bc4-787d-4cf7-bfda-d72c096ad3d8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a158f8d4-c824-4c6a-a22d-490da59d1108");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a1706275-3a70-4d39-8ae3-1ab95cb0ab14");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a179d257-2728-467b-ba2e-be09909638d3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a1823879-9df6-4676-89b4-742fe4baee10");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a18d05bb-0118-4377-970b-4970227988f8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a1aee30f-fcef-47ad-ad14-e62cebce4a27");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a1d9f16a-2429-41ff-885d-a4d2b77b7a93");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a1e889fd-a458-4904-af47-d0effe7fc1ca");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a1e964b8-d36f-4621-aeca-caa7a4e900b9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a21164ff-c0f1-4152-948d-d5847efc30c1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a27f8e3d-0e7d-416f-af37-4c9cdc52f66f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a295c3ab-852c-40bd-a804-17740cdcff8c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a2a4395f-8506-4594-8e22-3ac687167725");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a2d14fa2-78bb-40b9-9632-25d669c7a45d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a2dffb56-735f-496f-890e-baa7ab8dde27");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a3274188-7d18-4bab-b616-c4ea96fc743a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a32b1c2f-c5b9-4041-a1cc-c2bc60083560");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a35703af-c475-470a-a284-236ada576afb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a384dcf7-0b5f-425e-b825-2110bdc53df5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a3a4664d-8a77-4f29-9bfb-c8777e8e6b13");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a3d74bdf-7b45-431d-a280-2b6070195f3b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a3f01a23-9f14-479d-9c46-38d64b4a5f3c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a3f595b3-1ad3-42d4-afe8-bff29e6b305a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a402ac88-fe20-4b38-9a59-f1bb32f15c4d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a47072f4-3745-4070-954c-82c2fc326a1e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a48b6194-9d3a-4441-87f8-6706732a7d6a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a492029e-da45-4989-933a-7ecd548e011f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a4a5eafd-b3de-4a5f-9d98-5bdcceacc34e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a4c9a731-ad90-445c-b1a1-563d6bd28edf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a5032591-fe42-459e-9d2b-1bd4cf1a3941");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a5032fed-dec7-4b27-86e2-8bcba8239f42");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a54a81f6-9b58-4471-9118-1af3f3b7ffb9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a54a9c22-bc79-4da9-b349-49b7d2fede3a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a568cd3f-5e9a-4962-8c99-ed0a8bf4667b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a58df0cb-75ae-4430-a9f8-8764d97d568d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a5b9a965-8541-4a47-8484-223ffce1ae6d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a5cd1b8e-8c51-42b7-8da2-b8a2a53ae22a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a6014d66-06d9-4b37-9d64-495feff02f22");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a61a5190-054f-4434-963b-90e417f261b1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a65914fd-a57c-405f-b0ee-3c1f9861c6e9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a65aaae8-5756-43ce-9593-cfed617d6c24");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a68055fa-bf77-49a3-9bf7-7739691e9d6d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a6f2c7ef-ac8d-4bd4-aa02-237c51cda426");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a6faba6f-1605-46c2-958a-3bdb4f6ac980");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a70fea63-d9d9-46e3-80dc-23d44f20f28d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a729bc4d-2a0e-45c2-b1d8-a551d63e95a5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a75e2743-d6d3-4ac1-966b-115547c29cb3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a777b8ef-9eec-4004-a1a4-47a73072d7a8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a781dea0-343b-4282-a5dd-03c7fe625389");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a7e99c1f-7731-457d-821c-20d5f24ca44b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a7f70320-02e0-4f98-aab7-6d07e7d12a8e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a80a98c1-2415-41e7-a191-1b584f9624e5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a80efdd6-ce9f-444f-b645-39327dd9ab85");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a81769d9-2fa3-417f-a0e0-ca0dfefde4d9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a837cfef-b243-4fd3-8816-f214775075bb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a8454861-b4a4-46be-aabe-4d242f4dc42e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a85a49d2-52b8-424d-ba8f-540eb761efc0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a85bc163-b603-4476-b924-b0eef1016bdf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a86d9bc0-09eb-45d1-95fe-9c6ff06c9962");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a878cba3-5965-4110-8f5a-ecf47916ae1f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a8eb7cb2-64bf-4cbc-ac7e-9535b55677bf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a8f44462-eb5d-4a25-bf34-a0b246dc7cb7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a8fd8118-2f6a-4530-9aee-4740b5cf0e95");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a914a682-d6f5-423a-9b3e-d553e7171a44");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a925cbe2-3ed0-4fe0-a79d-4225a387f7bb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a93181e6-f70b-4c91-87e5-81f2b00ede97");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a9640b5e-33fb-4e25-bf8f-ab2b690f5dd1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a96e5ec3-e4f8-491f-9619-7a8f959eac4f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a9998a35-2a6c-48fc-877d-5d609c15eecf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a9a3ec34-077d-4c5d-98e6-26b40af9083a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a9b3ad7d-a4d0-42b0-a480-95acaeed5075");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a9bb8832-63a0-4a33-9a5a-4c283f9a347e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a9c19386-0ab0-42e8-89ba-c02ed1cc56ee");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a9d27212-537e-449b-bb52-ea5f2d3b01cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a9d30380-c3b1-4e8b-bc7a-5658a61eab02");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "a9f4be71-6221-476b-a49a-5365ec31fd00");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aa3426ab-3325-49c8-8a1c-cc9b502f91e7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aa3bd8a9-d464-4734-b6bc-94504bf87a41");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aa4296ae-7173-4eb4-96d6-a4adc8ce83e1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aa567af5-4d4e-4313-bcf2-4e238abccc7c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aa731649-ce0e-4fa2-b9c8-476bba047a42");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aaa772f9-25c4-480d-b4a0-a0843282e62b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aab0f5ed-71ae-4fa7-850e-b873185606a9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aab7edaa-4c8a-46e7-9199-4debe99c06dc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aabbce6c-cdde-4cab-96ab-cf94f5feb118");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aacb550f-b8f4-42a1-b3ac-cb5d89ed6d65");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aad12af3-2739-455d-9df3-d0fdca1fd508");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aad990b6-cdd4-424d-9cf7-345a191b983f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aae87368-87de-4bac-8a9d-7bd4d0bb8576");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ab4c92fe-a507-49ad-b03c-81f907f9ef3c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ab5b2242-dc87-4662-a183-9f8a37fb80c3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "abd9b648-e56c-48f6-abf4-85c0e917af5a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "abf3a639-8920-4032-8fa3-3b6517653ccb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ac0f7d1d-bd24-4809-9053-8b60581ba18f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ac26e03d-6c61-4288-9590-2ccb82395066");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ac34a5b2-a640-4c7e-a5cf-e27c29d2587c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ac4214bc-6e6e-43b1-b98f-87c00e1f6a4d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ac538e6a-05c4-4c54-b5fe-4cdd8e0def5a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ac61ca45-8526-44a0-ba40-bb62f3af8f9a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ac70e576-d160-4358-a52c-bdec63c9062a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ac8f9ddd-1a37-4de2-82df-ea86bfd0e87d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aca179e8-ed98-49e3-9c08-e83588c30cb0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "acb909e0-459f-45e0-a416-623f3230fb99");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "acc05f11-cda5-4299-b874-02c81086832d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "acc06af1-a276-4824-a9af-9414a9890988");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "acc3f6e8-4d9e-41ff-8cd5-68fbe84053c1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "acc69aef-33ce-4387-a937-f7a9bd81c112");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "acefce26-04c6-42c6-bf92-184d46ebb13c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ad596b6a-45aa-4208-b9cb-bd91c18c6115");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ada7acba-1c44-4979-9c35-448cc24abd84");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "adc6e847-0f68-47c7-8ad6-5c666dbffcb3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "add1b4b9-1f60-484b-9899-e57b9ef6422e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "adfce7d2-c0ab-4098-a299-6fbce0537c41");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ae16c97d-c918-496d-8673-2b1d39ea300a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ae306dc2-01be-4931-b5c1-be1677be00c4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ae5f318a-4caa-42aa-8d74-2add9573ced8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ae6950d9-0fc4-4735-a4f8-edcceac0ca34");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ae8c5a30-9d6f-47b1-9039-10463f82fcc0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "aedb9821-89ea-4662-b8e9-65eccb434c03");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "af076eec-e1e5-45d9-b718-49a3b294f8ba");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "af160667-e4b9-40d0-888a-563d91a6b755");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "af4348f8-2e7a-4f24-b733-fe45a12a660e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "af773880-1762-493b-9a01-e70ad725933d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "afae9357-799e-4582-befd-f7ccb280c9d7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "afdd3f84-60b8-4551-aae0-458a284001cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "afe25402-bc1e-465d-9b7c-d4ae4f3b92ec");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "afe7d278-17f4-4195-a65b-bc46d701b9a6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b0173354-a398-43a6-898e-f543bcf9b638");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b01c6d74-b6ee-4fbb-813d-9c009b9823e0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b0353319-8af0-4877-8545-7bf0061ba46f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b085e3d7-c2af-4b88-b74a-d53ded2c4a23");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b0ac39ac-8655-4ca8-809c-b835ccd0bf49");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b0adce17-320b-4f8c-b253-894a15f6ed7a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b0b71bbf-7daf-4e76-91e4-6d2bff0162ca");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b0dc3c24-1bf9-4c62-9056-5867e8471a26");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b12034bb-5f81-4e8f-8f6d-58f394bda34f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b15d056c-da56-4784-a7ed-f2ad58c10e37");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b1695e73-25ab-47a3-a65f-266da662d7c2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b17dd5ec-1a72-4732-9ca5-2feb1b44efbf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b19d8bbd-9ca9-405f-9b8c-40e1cf520804");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b1a232b6-99ce-407b-b5a2-00bcfe308c1f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b1b857ac-71e4-43c6-a722-3145c2640e30");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b1c32b30-e130-49ba-b461-8670f7121e42");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b1cdeca3-9275-490e-ab70-8c417feb1fb3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b208689c-ba49-4514-b564-f387b0ef5526");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b20f2a86-e3b4-4980-9122-b647e42e7130");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b223c6e9-385f-48ab-a649-ae37ccbd66a5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b22f63cb-6fe0-4da4-876b-330ea3cee9f1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b239c39b-7487-4dc9-951d-06e09ef41a27");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b23f6bb8-982e-488f-9a55-3ca245116370");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b245cb82-9481-44e0-a898-c5d6ad0ce927");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b2896709-9f95-4746-8f8f-d58fca9bba9a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b29a031c-288e-4596-bfd9-6a80958378f1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b2e54eb9-f623-4f96-a232-3d7a7a486aeb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b30bb6a3-b613-4d20-be54-095daea8198c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b3606acb-4321-44a8-9801-b366dcee77df");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b379ec57-8151-4710-af93-9686b2be3461");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b38d50c8-a4e2-4430-9127-9d33115c0470");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b3da4255-1fab-447d-a9aa-55bf92adedfe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b3f205a8-684a-4c4d-8015-88c27f1bf672");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b3fc9d80-514d-4b1c-ac00-4e22465cd5c4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b414b01e-5394-4c3b-91f8-c9fc7a136757");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b43a2089-c094-4f07-90e7-899bc67e52b8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b450e537-48aa-4926-bf95-f2d24ebb774e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b4574171-45b7-4a37-b1be-76cec0bc8523");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b4893d8e-139c-44ad-b10d-3832f78ac8e9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b49cb06e-b915-421e-a864-15cee4f5e6fc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b4d63818-554f-4336-a7fd-d4ca11983bb5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b5375899-f14d-475f-8aa3-437d50162cd7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b53daf1d-8cc6-4a37-90d9-0f2babaa6484");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b5479eac-fde8-4b83-86e2-3af5442b83ec");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b55981b2-796d-4319-b3ef-369d69d35616");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b572d09b-5ed7-48b6-962c-e84478af35d8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b59d1584-e6e6-454d-baf5-d3c33030e8ef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b5a9b770-d11f-4b33-bcd1-37ffe52b8417");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b5c36d1a-30b3-4b3f-80fb-47824e46612e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b61b1a60-4e8d-4c25-b00b-f2716d5e6c7e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b62260fc-231a-4775-bfef-aaac8c6134d7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b6323b48-39e3-4a23-b152-41515325dce2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b6392c0c-84c7-4618-87e2-4f86e8d671bc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b6980d6c-f23c-4ee9-a4f2-04dd1f8b42d9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b6a4f116-fae4-4a13-8bbf-d7b1c7e70003");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b6c8a7cb-a241-47fb-a944-fcf933891804");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b6df78ad-458d-4d29-9604-4c2f4ee5a205");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b6f52c24-db75-4055-99fb-efcb20ec261e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b706e388-45e1-436c-ab13-399bb3ac5ef9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b71811f6-6d9f-4060-9a47-3dcd15b1076e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b731621f-52f7-4ecf-8f22-37833fa55a09");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b73a95fc-ab4d-48d8-8a09-7e9418697337");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b741f013-6adb-486b-aacd-367b92f9a327");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b76092de-989e-4643-aa04-8ddd59e310d4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b76794ae-bc63-4ec2-9b57-634fc156e9a4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b76cede4-04cb-4873-abad-b38c1ac5fa0b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b7720d5e-ca60-4189-a300-51ed4701a9ef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b7795b5e-e531-4c7a-854e-fb26b10c8d97");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b78a11ef-d8aa-4fcb-a24e-036dad85a204");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b791bb65-72dd-4bfa-923f-6a68b499b86b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b7b79143-cd6f-4d43-87a3-933fda88c922");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b7dc2bf0-991e-4ed2-bb43-46f9030bfe16");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b7ed42a7-ea59-4a47-bc11-f0e7555cd0ce");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b855a78a-a055-4e52-bca4-935c0b8df9e7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b89a12b5-20c3-4fe3-a9fd-62a32cf85e6d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b8a0b00f-c9ca-4f6e-8886-a0b5e53f550a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b8ab4a8c-68f7-4167-b94b-a09dc45a1b3c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b8c0b422-9579-4ea1-b9af-f3dbab9a59c4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b8ffae06-c6e9-4704-b245-57b8cb6ec653");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b95283a8-390d-4fc7-9ed0-dab045b0e60a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b981e04a-160c-4009-be15-5c63062e1702");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b99687c4-16f6-4eda-bfd9-b81a932bdf11");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b9db45cb-3900-49b3-bb25-2c3bb6367d3d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "b9e28b10-4cb4-404e-b651-4ad97f1b7c54");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ba26b338-3637-413a-bc71-1bbab387ada5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ba2b8d2c-2cdc-436e-859c-e48be9dc5f6a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ba52e194-096f-4d48-9ecc-a4447302f46e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ba557905-081f-4ce7-b2fa-f7174057d416");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ba8c6e24-bf2c-4c5b-bcb3-f00fa9ef858f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bb008d5f-3ee9-42f6-8509-75abca3a2318");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bb2951d5-7068-4b45-b56a-9f998851f03b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bb2bd137-4f95-444b-a51f-d94ad62690f9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bb2f88a2-15fe-47d7-aaca-722a888f3b84");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bb5e84e3-ff75-476a-b484-4bea6765bbab");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bb9997c3-c7c2-4322-ae4a-fd758eae77aa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bb9ea0e6-2b26-470d-8c69-50c5280264fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bbbcd0e3-5635-40a3-b524-8a20e64c2368");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bbca9a69-9d56-4a00-9f40-a31348ab9d41");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bc33713e-b8dc-4392-b481-9dc1f5b1a366");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bc3bcb94-2f13-40c3-a2b8-915222d0bd29");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bc52055e-48b6-4bc2-821c-b35836d8b0f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bc54206c-998a-4644-85ab-b7f8da454c25");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bc5a871e-f4ee-4236-a0a4-76abc4b0f4ae");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bc913cd7-428f-425b-812a-67c2074418d8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bcba62c2-67a3-4a7b-af76-3e27974a8aa5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bccd7158-bc9d-4205-87e3-992c83270fcc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bce2dcd1-0e12-4a83-8393-bd4a1ab9739e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bd2137f0-b4e5-4d13-906e-2c028a3e10f0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bd3242c7-3695-481b-a3e7-2af8e0ef31b4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bd62c6e7-2886-4ac9-82cc-f725f6dc34fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bd73f497-236a-4761-af7e-20dd270cb74f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bd74c087-f944-49b3-adc8-7306416f6fc1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bd8e86ed-e9ae-48f7-b9ca-f4009018c0d0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bdb4fa85-b28b-4024-b735-0de7379976af");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bdd2aca5-c930-44d2-9067-192e89bb8180");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bdd63589-17ef-48b6-a64b-de31089fd037");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bdde7496-d8df-4994-b0cf-23b7f098c4fd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "be421745-b5fe-433e-a927-6c65821221c9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "be76901c-502a-4d8e-a418-2d1e163691a5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "be7b19d7-aa27-43ac-a990-65080a78a03c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "be8e6daa-2fe7-4763-bf19-ede12926d84a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "be9361e8-1a59-415c-b3dd-90fac6cae28b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "beaaa280-dc86-4430-99e6-bad259e30896");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bef698df-9070-4087-824f-25cc544f4538");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "befd3e06-a829-4c72-b957-1bca7698687b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bf68d9e9-7435-45d8-8c1f-7adc2ee725d0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bf78bbbc-3df9-4f71-bb92-9ac2955caca5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bf9ddfea-4952-4c3a-a269-0e664f08b06e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bfa09b51-dfa3-49a0-9745-062cb354a48b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "bfad95e9-9051-4d3c-882a-bb738295708e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c044ea3c-dbe1-4503-ba51-b625dd1b6a06");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c05f457b-228d-4b30-9cd0-f4fb3c21c93c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c0885830-37d5-4de6-9e97-79b364b85505");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c0a10ea7-e8d4-49ca-9e91-29033347d484");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c0b29937-8de3-4e37-a290-1ebdeaa0bb0e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c0bab878-a0c0-46dc-a76d-77a48e25cf73");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c0ce047b-6169-467a-80ab-08c72516dabe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c0d7daa0-404e-4cf5-af5e-e37c9c9338dc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c0eb3c2a-8b61-449f-8aa4-c3e26861b571");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c109a393-a82b-4fdd-b002-80b721531bc4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c10f427c-8f40-4a77-8f95-4958ff6e69aa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c1284998-e51e-46ea-ab4d-067bc88ed056");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c1627550-3595-41f0-a4ac-6cf47c45bc8c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c170cac3-514b-4ded-b1ce-894c25588fb4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c1735ff5-31ae-4ca3-a476-8d8221fce2c8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c17d92de-760e-476f-891b-a70838d6a587");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c19f734f-1341-421f-8020-b12e80015dc4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c1bb5b25-60e7-40ab-9bca-84fc3ab07505");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c20b3dea-4370-4e8f-a355-8ea392838ee0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c2526cc2-fe93-440e-9a0e-f30f67827f78");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c2555074-0915-4912-a485-0bcb358bbda0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c275df6a-2b7b-4a05-baf9-e978662b6339");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c2a78419-7f43-40c7-ae2e-4fba71066436");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c2db3d87-08e3-4960-ba34-5169c706454f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c2e0ea30-46ab-4f75-9eb9-d1b1a1c88eb8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c2e2b54c-f120-4bb9-80a4-bd877a071cdc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c2edc22d-64be-443f-acf9-01f91c4cbbf4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c2fb5bae-3637-47b8-9786-789c8292a38c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c3143baa-4164-4dc7-9b67-d294734dfb0e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c32ce419-71a3-406a-b9c1-1884c20c9636");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c3411649-a0ef-43b3-81f3-c01f3820a7e3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c3d6fdc1-1bff-4684-b24f-a578bd3dc23d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c3e82d80-4190-423a-a4ea-901c51cdcf1c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c3f1c85b-c496-417d-aea2-b3d365798fcf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c3fd329f-0160-452f-a8ee-0123885930ff");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c429ead6-2a90-4e5f-8a78-496613c48527");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c43cac69-5f79-489b-b45e-682c432c6fa5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c451e947-bdd9-4f93-b16c-0502175a129f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c45e2682-5ef5-4138-82f0-6aecdf0cd02d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c467ef79-ed0b-472f-91d0-8528b95da811");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c49a755e-8b31-4fbc-b1ad-2dff882b4c02");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c4fc966c-c7b8-4686-95cf-fda76cd307fb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c50506ed-7e2e-46bb-982a-ff3901eadb0a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c525fa12-f823-46b5-b749-1c9f378f9b6c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c533fdbe-7701-4ef7-8743-e2893c85529e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c57dae48-dae4-43aa-a46c-734581f6f883");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c57e8acf-cce2-4ea2-88c7-c5731e227536");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c57eb3e9-4bf2-49ee-8ef2-daced6f0f1e0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c587f2a2-706c-4b35-b988-9ca23746fc65");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c631ef15-e0ba-4ee9-88ad-002eef7642a3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c63fb226-72fc-4a0b-a68f-ae4ab1650ebb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c643f903-daea-4e91-94f9-3f679bed182a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c64b6cab-de7e-467e-a009-33bdd6f3ce9f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c65fa26e-babe-433d-8aed-913b424ecc1f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c687d8cd-8042-4aa6-a3e0-b4caefa1a5cf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c6db22a0-0cbc-4235-b28a-653d9a4ba18d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c72e9d3e-b8e5-4bbb-a6a4-6cbb27ea2913");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c7592b55-d773-4fa9-8e87-9d6a532203f9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c762525d-4799-4201-a627-f2f5e0f35809");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c7919643-035c-4cbe-b2b4-2172a2dc74f7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c7934ab0-7f70-49b2-afa9-245629009cc2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c7a5cb67-7761-4548-85e5-fb92f676e928");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c7cbadea-1ada-4792-896b-e8bc196f925b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c7fd4ea6-d500-46ee-a559-eaf1d4652954");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c83cca4b-3b8c-43d4-abd3-7ef0e6543923");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c840528f-9928-4ba6-8900-f3eeef44f5b9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c86403b1-ff64-4f35-ae65-42cc7d7b0433");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c86b8922-afa9-4342-a89d-76782a093722");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c8868747-aa7f-4a32-b977-60d4dce38f77");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c8954f83-15dc-4c87-b950-4361bfbb4cdb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c89786d0-4844-4086-a37e-3b18c2b3fb7e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c8b66e89-5f5e-4a4d-af9c-f362198ed5a0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c8c0d8f3-2453-4106-9c94-1845353e0e76");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c8e85485-a85f-4076-a3c0-24c19a768ab2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c8f042f4-1196-4fa8-87df-432265137149");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c8f26776-1f09-4287-87b0-2a8f905d8217");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c901c32f-bf85-4c1e-8e58-d6441ae2e679");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c9293655-be95-4446-bf3e-e625b4d477c1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c92fb2c5-e19a-403b-b609-975ae948ee87");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c93a49ee-249c-4f96-94f6-b5ed895145a3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c9451cc4-252b-456e-832b-229c51e65521");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c97a618c-66c0-4f23-9b59-d6e0a219166c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c9a31e18-60a4-4993-9d66-2f64c872702e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c9bbc886-b582-4ab0-93e3-838dd85c679f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c9cf14a4-d3d2-4b91-b7bd-08cbdc787deb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c9d283e6-bb1c-49ca-9934-915beff18d4a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "c9dddb34-06f0-40cf-bebc-9c063701ae56");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ca27df8f-dd69-4e80-98d6-8f7737e9ffb8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ca36753a-f7fd-4d6e-b522-c12d201691a9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ca87de2a-8e99-4393-af0b-883ab019fca5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ca89f1a0-eb41-400b-acd4-92340554f121");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ca9ced2a-efdd-48ff-b87e-901ec5a160ae");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cabebc9e-67bc-46a3-810e-3fe31a84b05e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cad218eb-0a64-4c19-8dd0-cacb51f9c732");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cad2b468-5d75-45fa-902a-93cd2d7b81a7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cb4e639c-6b1f-4d34-9776-73d536815d8a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cb79219e-6b49-4992-97e0-db259673d48e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cb8cb494-5504-45fd-997c-942fa478522e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cb8fc276-7113-47d4-b6c9-fc345f2f24be");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cb948d59-310b-45e6-bc18-ba8a5e4c4dbf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cbef2aa6-8d06-4c9e-b20f-ae023cfb2499");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cc58d9c4-1502-48b1-a4cd-2a1740c344c6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cc590939-ec08-46f5-a671-a265debd6da8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ccdc0da0-2673-4d2d-ae3b-2c8f6bd61c7b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ccf4ba83-14eb-4108-bafa-5c89f9c55e02");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cd1cd658-6c4c-4a4e-a80c-492c82a2eed6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cd456abb-482d-4161-ab16-bf6076dd5229");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cd6c1796-7f11-432b-813e-e72302b9ba95");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cd7f26a4-de74-4936-8ced-d7b2a0649994");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cd85f842-ba05-4ab7-b8c8-d3d80558c9ef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cdc0aaef-45a8-4ce4-953b-18ed76131790");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cde03e36-e5db-4ad5-8e5c-ba3912c02ca3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cdef7a4c-83b0-4d72-9788-5b1f17ef53ed");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cdf03904-c374-4f71-9d84-8eb0b01f7aa8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ce312fd4-157f-4171-9dec-72b7120daaab");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ce444cd6-505b-4f79-a6a7-66e3f93a7a48");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ce5614ae-2905-47c5-aa11-8568feecc37f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ce5c3db5-8125-4379-9d88-85e0c6b95676");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ce66682f-8759-48f3-91e8-bad93e8573c2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ce6ca4d1-d56f-4046-8fb1-1e8a65880e64");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ce7f9bd8-6466-4370-ac52-c2a30d830cec");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cea43b01-f298-4eb0-b0e3-ae249fa54b54");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cec8e193-f2c3-4418-a34a-fa9093ee35fd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cef3eb54-752b-4a98-aa8d-2d7c92524b63");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cef53ab4-906a-401a-a8e4-4ecdde61c0de");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cf2fbcd7-9998-4cb0-9b15-237476485471");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cf577096-de74-487a-8a4b-21b6eec0c789");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cf62ba83-7d0b-4241-a647-f7dc14848197");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cf70be28-ad85-4d83-aadf-d846274dead2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cf7645c7-467c-4f03-a990-517aceccd415");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cf9015e8-c35d-49d4-8dd9-4d7af2d683bb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cf925e74-04e9-4c91-be79-6cf19b78ec44");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cf9e2424-084c-42f8-b16d-7a74e33be07a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cfaf7954-d0d6-493e-ac30-2add2d0ad48b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cfb96410-46fe-4d7b-982a-f7b7993f73f5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cfd5c492-8699-4f66-8ec2-c043d468e8c9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cfdd6464-a0e7-464f-a625-7f3e3d5c8172");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "cff83956-34ad-4381-8b1a-9cad13b0cd8b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d030d350-f32c-44bc-b00f-d6d9c6d97095");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d068da3d-8e78-4ae4-a5fc-b1081dd3ede0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d0713099-e64e-4526-91c7-df0b138847c1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d0873997-54dd-43bf-a18b-62869e403bfc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d0b25a11-7a2b-4131-b4d7-d3e3a40cef6b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d0b9acc0-b09e-4053-9ac7-d1a2666eca16");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d0f52848-7cbb-4c35-ba0d-77be418a2a83");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d0fb9fd7-2d34-4c00-acf4-6169ea7b1992");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d13ee3c4-2954-4912-bf13-fccafa4666cb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d19e89e3-404b-4bac-8192-42a2688baedd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d1c6cb05-f37c-4e7a-a231-8d70f2c0364d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d1dc0cb3-d43a-4d7d-87a0-9eb062b56696");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d1fb2d99-bf2a-4231-a005-0ed22fcbff66");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d225cc73-394c-47bb-9ad0-a620143d5f6a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d26f05ba-7eff-484a-9f99-99a765f15f09");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d278d75f-7dd9-49a3-a84b-19f59d066b21");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d29e5af9-244d-4f85-b985-57c07ccc91fe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d29fc27b-15f0-4ecb-8df2-16db014dbb81");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d2a4d590-3845-45ac-bd86-65de0a556def");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d2deeb04-95e4-4673-a987-8c32040ebe80");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3055abf-fb77-42d7-bee1-d6d0671b1b8f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3136a61-933f-4c12-97ae-7b8e3c904e14");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d317eb82-9e3a-47d7-bc47-0e9c2dc454dd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d31ae2ec-9e93-4ce1-8012-d0973f19704a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d31bb7ff-217b-4a7a-af2b-b4f52830618f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3249d5e-a04a-4f71-ae3f-ded77563d6c6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3414cee-50e8-4cf6-8263-d29c3987a479");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3552890-079d-4ff2-8fe3-3b2276d28378");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d35f12d9-1cc1-4c1c-aef4-2d3f396e4619");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d372c461-b620-42ba-bf72-a892440badc9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d37f40df-2925-4775-a68a-8a3f2a185285");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d387a2d4-ffef-4d62-928b-3954aac425ac");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3b0c12d-aeba-4316-9734-e2855813dbdc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3b29fe4-b2d2-4332-b227-f4756d513cc2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3c5ea1b-879c-4ff5-9e3b-e49d2271c0e6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3f1de82-1e87-43f7-9b35-e822cde44d4f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d3fd2744-30ad-498d-98f9-c8f54b88a761");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d4049880-d8a5-42de-bd9a-e688ecb0dda0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d43fd956-60f7-4efa-85d7-651ac78e7abb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d4415cba-660b-457e-838a-02d86982f087");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d455352e-742c-481d-b5b1-0075346b0c52");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d455450c-f620-4cd4-8697-5c944eb8f152");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d45f2d70-5c29-4908-85c1-561972399b1d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d480bc53-c57d-4091-af11-950d0bd72fb1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d495b9c2-1e3a-4ccf-b8af-62c61d3c7401");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d4968982-ca70-462d-80c6-c1f87b710fdd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d4f63ab0-9d67-4504-9bb6-9541e543ef70");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d51b5874-6bdb-4218-9e36-816426b6a00c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d53aad5c-1a49-4819-a9b1-4e67b33186ea");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d5495854-3f8d-4440-976c-623f37d739f4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d60b2108-39f7-4679-b431-e8bd62e6b077");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d634081f-103d-461c-8dd7-31303b076003");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d65aea96-2e67-45fe-83e8-eb60119eddd8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d67a89ea-9f29-49b3-86f7-1988c63dfb76");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d67b86b9-43d5-4f28-bb8e-5b290a1e737e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d67c2e05-eea6-42da-8be3-264ee269b272");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d6914658-c856-4bf2-b191-4d32418c73d0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d6961ed5-4964-45af-af80-f6243a058fb9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d6b5726c-b07c-4234-9bf3-fdf2fe76672c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d6c96dc9-ee01-4573-94f5-134c88e0a0c5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d6cb97a4-2863-43c6-936f-76ac4a95aa56");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d6e8ca8f-89cb-48f1-a2e5-004ee1194789");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d715c6c6-9b17-4ef8-aab9-f3095424522c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d71a0c82-260e-409e-961b-eae7c39b4fef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d7257427-3700-458f-97b3-10c59a116075");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d729f514-95f1-4a1d-b6ab-6c3a46154927");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d7378ca5-739a-4bd6-a766-210cbc57162a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d748bd61-cf9d-4c5a-8024-aec10589ca86");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d7537b3f-fc44-405f-abcf-4515a2ae17c3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d757ba2c-bfcf-40ac-84af-b404b62ed297");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d759f8fc-de28-4f93-9fcb-1c67f016be3e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d77c2d47-9654-42ba-9096-545a1ea74fd7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d79b4dac-9bd8-48eb-adb5-5867e75392e8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d7ae4505-5aa5-4929-9522-7f8bac927db0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d7db8448-3cd1-45ec-a920-5e946b40d46b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d7f37e03-f6c0-430a-b50c-f3e0c25ede83");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d808f832-89a0-4e66-a278-c3b7398ca597");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d885e297-7587-47d5-bcec-c4bbf354e2eb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d8876af6-2454-45b9-a3f4-139bc13b5862");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d889d6cd-91c0-4ddd-97cd-d9f62fd24f96");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d88bb5ed-c616-47b2-a4ef-5c0c0f037f77");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d8a34ffb-1de8-45d9-9b4b-bf6338b5f0bd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d8fd41b3-bee3-476e-a8bf-ddf0af96365b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d90af66c-4e9e-490d-90e8-15dc4f66fb21");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d915b28b-0817-45a3-bec5-63c5ce02f310");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d9165228-c796-4ca3-9f4f-59781d6ffd81");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d91c3fad-b8b6-4dad-9600-f6cc38318c57");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d97064f7-5ecd-4e70-a7df-ef7accc492b6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d9b4bdc9-e051-439d-900c-5cdf098a7117");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d9f0c26c-89df-4bac-a70b-5e6eea95e0f7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d9f17938-358b-47e4-a304-28b1e1c71768");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "d9f6f0f7-6488-4b7d-b48b-17782cb679fe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "da33b831-16b4-439d-ac88-e0fb4db866ee");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "da472dac-b12e-46c0-b147-3ca3afe7cc20");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "da521b48-59c1-429b-9c64-676b10429530");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "da91f0ce-92e5-41f9-8066-7cb19b0e66e8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dacdeaf3-b7f1-4a87-880c-75c051ca3fb7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dadf3a7e-b0c6-4082-8234-22d175765d5a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "daeeadc3-9acd-4a33-ab29-65315349075a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "db02452a-a6fd-428c-bb82-6d8945727933");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "db9bf11f-080d-41ce-9bf4-8d4b54b43e2a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "db9e3472-cac3-4adb-955a-a01f7bd5ab5d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dba41a9f-0ddf-4f09-904d-7ecdd4937329");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dbaa7af2-72a5-4bb5-816e-17e9437ee21a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dbc83ba2-b292-412b-a583-9cd583984816");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dbe6ea1c-0219-4c58-b0a9-2bc2ca863a0a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dc25fbe9-15ab-4971-ad20-0b70bdb0517c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dccb06ac-ca1f-4bdb-a82e-5981a841ce3f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dcdf91a1-e7ec-4ace-b235-345f71fac1cf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dd0a7472-d11b-4f6c-8675-6b9beca36c74");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dd25b0cd-c6b8-44e4-abd1-125442a1ad40");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dd3364ba-8b14-40c1-a23a-d7f8d879c63e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dd9118ff-0ba8-49a6-b31d-f65bfc15217f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dda0f4c5-b273-4ad8-aa7e-ad2856abfb29");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ddfe7fad-5f64-4ec1-a10a-7e41e73ae7f8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "de251fdf-ad8f-48b8-9c75-182b4c706c8b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "de9a84a6-dd30-4aa7-b5ea-3c47beb707b4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dec2013b-ceb5-462a-8967-6147a91a51cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ded6f0a2-937c-437b-b459-fcbdf42403ab");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "df301082-1f2b-4c44-8574-0e2b4937126a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "df5afdcb-2def-4265-9fe8-4f8c2b96b5a7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "df687c73-9b24-4019-80f3-d52fe4ed8111");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "df701b3e-84bd-4de5-9eab-026e2643cdd8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dfb33959-c20a-4170-a91a-0f643b530a6d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dfb38a5f-a9ac-4049-a785-47060d8f0754");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dfcc8abb-ccb7-4286-ab4a-3701eaf0e5fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "dfd788ae-0a0a-4775-ac6d-403a92df257e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e05d3ca5-d9ab-4c8c-838c-957444b6a3ce");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e095f74e-a82b-4763-8ea1-3c47903b30fc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e0a8fba2-844d-46f5-9d2e-18445a46ee86");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e0b2538f-dfdc-4072-92ac-8bf900aecddd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e0c32299-3d48-4de0-a8c4-d0c29bd68326");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e0d7d4e5-3b88-46fc-aaa6-30e94ced88fb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e0dbdfc2-720c-4637-ae2a-63c3b4275d9d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e11477c0-27bd-4a0b-aa04-fc6d078c3e72");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e12671ca-1799-4216-a130-6c9d011bf997");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e1896525-79f7-43dc-88bb-246078582b2c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e1906019-1f5e-4073-a1de-dff003d10acc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e1924a37-99c4-4e44-b76b-b291878d8a75");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e1b0ff6a-5369-42f1-818d-84f926e4889c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e1c338bf-0c8c-409f-a321-3a4a8f08f3ad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e1fa5896-3167-4c9d-bda5-c7222cc27607");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e2242acb-0578-4bd8-bdae-4e2922cbd190");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e232526f-a1e5-46d4-9bd7-f5ae79dc397b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e2626684-22fb-4cd6-9e0e-f94a1fef6b15");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e26d7701-094f-4891-9b9b-89b31d1a130b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e28321f3-66b4-4450-981c-cb56f8a3f612");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e29d0fd2-8c7c-44c5-bfed-1949ab920a8f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e2a506e6-514c-4364-80d7-f72819051b9f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e2ab8365-5faa-424e-a7e5-719d863919d8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e2e13f83-78e4-45fd-90f2-285916d5cee4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e312ba51-895a-4bb6-a37d-e8539e0c9744");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e34a1d8d-1ab4-45a4-8b42-2f2616957fb7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e380b34b-768f-4aef-8a2e-2456e881296d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e3881523-0362-4399-ab00-25595ad14909");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e388d1a1-3370-4676-a674-e9cefc827bad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e39fc506-8696-44ee-a515-f0a0caddd7c0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e3b69f00-bf36-4fcd-a61e-e3aaf6b7ddd1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e418f96a-9fb0-47f8-a06e-a2abc768d33a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e432cd36-812a-429e-9cae-4498456fa976");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e441ce3e-eb54-4967-89d3-0c87542139df");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e44b66b7-f7ce-4620-949c-cf90a3541124");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e468ccdc-897a-4d30-bb87-5f216fd1a973");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e469b1b9-6fa8-42b9-b726-bbf8280aa3f9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e4740a39-7f70-4132-a9a4-79d45ce44c0e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e478f7b1-5097-43c6-9c2a-57ef8904c6bf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e4896c43-d9cb-4421-a934-7f3469e7a38a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e499e7c7-19c8-40e6-bdac-68c1f6396e9f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e4bd56cb-f866-47f7-a43d-041abb89a614");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e4e47769-2c5d-458a-af08-d92f2a5a1af8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e4eafba6-7f4e-4160-9fb7-50e191131e40");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e4eccd88-b433-4a17-81c2-7cdd657e8895");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e51b2d97-c013-4560-afeb-bac5bb91e795");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e57604a9-b99b-4c7d-8d89-845800409170");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e59de6cf-04f1-40f5-bd00-38e0904b7e6c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e5af8c51-cde6-487f-a2ff-c2f98210c073");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e5c381b4-4153-439b-a138-b5c1c02389ee");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e5dce8ba-f6f6-480b-b86d-021a845976fe");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e62881dc-a0ac-4c29-843d-79662993d2bd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e641c78a-9644-4275-9b16-a5051d6bc0b6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e64ccf07-37a1-424b-b574-b7ba00ef86f8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e659f46c-7bfc-4a87-9bfe-a0554b245758");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e661f0a7-4114-4e9b-a8b9-822a070623bb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e662dda2-caa7-42e8-a03d-277c5730da8a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e6641c18-ce7b-4e1f-9295-b1c0c48ed39b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e6b98c67-81cd-4ec8-a707-34cc902de6e0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e6c6bf3d-a165-435f-8fbb-c13950e07764");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e6ce2a9d-afb6-485e-a128-41c923715a1f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e6d19ed3-1283-4ca6-a6f4-276285aa19ff");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e6f4b8ad-e733-40ad-a23c-b5e873c2ac6f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e70252d7-d776-4cda-a3f8-1239c1a9606f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e73bc942-d183-4aad-ab0b-f4b8f2b8f390");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e75b9c59-9510-41d5-a084-8cf65fe7ceca");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e77eb645-19f1-470e-a3d9-b469ab030416");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e7a1bc5c-d9b4-4554-a033-a530f1ff8de7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e7b0a763-2d8a-4695-a96b-012b7fd83984");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e7e14a57-6d7f-4de9-bd51-3def45cce7df");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e7e21963-d66b-421b-abb5-edb76c7cc549");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e7f1dcd8-c3e8-4e0f-b40a-0a22a53a1418");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e7f74674-716c-45ca-ab82-fc72c13099d8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e806bbff-0b12-495f-8e14-67ad22402c16");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e81883dd-d23a-45a1-8f75-d2e6e26cc58d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e81c04e4-47be-43f7-bf78-c0e076059b21");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e841a5cf-5603-49ab-9a37-9a05e55a5fd8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e85103ed-4d8a-4316-b2d6-77907c6357ed");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e85ad111-7c1f-48d8-bdb5-58e33a96d187");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e87c3f75-d1fd-442e-828d-a852358e72db");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e8865c45-152d-45be-96dc-c0d59b847ed3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e88b9e40-fd8b-47e3-a81e-6f56335d6d01");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e8c18b5a-8a0e-462f-ab5d-f9302710be86");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e8c96be0-70d9-4d2b-bb95-f06df0a099da");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e8f6c333-98da-4a7d-9850-ed09413ddccd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e8fbc89b-3402-4b62-9697-1270212ad620");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e931a81f-1d10-4144-8c6a-65d72981a2b8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e96f244f-28f4-4dfc-817d-81d782623c4f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e970e200-53fe-4712-93fa-edb484f8739b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e97f0810-a355-46e8-892f-dab528666a48");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e98bdd2f-bc15-4303-bcdf-922566913791");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e9a505c7-77c8-4c83-914a-15104425fb32");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "e9d993ac-03fa-423d-ad71-242a57930bfd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea1b682a-0760-472e-aebc-5427f50d66d5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea1c0ffa-c861-4259-a1e6-fd00013a426f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea20bb28-02db-4e30-af79-0fc7fceb4cec");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea30fd93-c200-45d3-88fa-3826ae71cfeb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea39e1fe-90da-43c9-abc4-2d67ef0c0818");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea3f8dc2-c1b4-4c45-9b4e-8354c1a8682e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea4cd30c-9f3b-48fd-ad41-63829200a442");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea509bd9-5bfc-4bc0-b68b-b2dbd45e3a27");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea599d09-9695-460a-9ea3-d547ffd7a450");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea74c4c7-6841-42f1-af96-5a688769b003");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea7bda02-9a4d-40d0-b860-413746f59087");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea8ded98-9f58-455e-834c-a5a2971b978f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ea9d0ff9-e19e-435a-aa63-542a5bad5d0d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eaa5e1d2-b3dd-4f95-bf89-df471086bb1d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eac85aa0-5fc8-4ed6-bba0-517f76fa4473");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eaf423f1-6a66-4d0f-a0b2-a9f440bef592");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eb27556c-1be2-4bf7-b2ca-4c51a040e4a6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eb27618d-dcb5-4bbc-a315-159f7359d7b9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eb2d1e93-0c6c-48b1-8311-bf482a00172f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eb436f4d-3cb9-4eda-9c07-1f4147104369");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eb499eb9-7fcb-4aa1-862c-74fd0c51e1a1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eb8de256-99fd-48d6-8c29-a8ca49d38aaf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ebae9590-7e1a-40f4-b3b0-e7c0771868ea");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ebde1a11-88cd-4f70-9db2-251c457b575a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ebe19a2c-63c1-4707-86c0-cefff15e15cc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ebe9f481-d037-4ca9-bb50-7361da5cdcb4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec1170ca-4f2f-4f2a-9995-44d37bdc0079");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec17b14a-353b-435f-91ec-24df5d62d834");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec21c3df-ed1d-4ab0-8269-8f4b083576aa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec374478-a067-4020-8fe1-e2f3e8fb9193");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec48045b-ba23-4f52-9751-ae110b1c629c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec4ddcb7-01fe-41b3-bba6-b2411f20a51c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec84c9fa-c87a-4f4f-8294-011abe6ed98b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec985db3-f315-4f20-99f8-e7956d3e6e84");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec99f4a4-db74-4580-bb77-0d1b40eb61d2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ec9f9441-99fb-4eca-9e7c-f808a94f1a3b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ecb5366a-e435-46f8-ac27-91aa8cc26a8e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ecb9884a-0713-450f-be3d-3b1dd8356f1e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ed053540-e5fa-4689-aef4-c00cd008d620");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ed29b4d1-57bb-432b-97b0-ad727d9797a3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ed37e052-1df9-4b39-b54d-c41ca8d37cd4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ed3b6083-34f5-4075-8a8e-95acbe72c9c9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ed4f1a23-ecf8-4efa-9daa-501f68ef70df");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ed77c8d5-3697-4d79-a59e-f8f41dc1eaa2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ed849b06-ad21-4924-a453-15c7ab30bdad");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ed976a77-66a8-477b-bf31-b94ce832cb6a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "edaccb8e-4cd2-4f57-acc9-bd729429ffef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "edd55afd-cba1-49db-ad93-0954da93c9e8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "edebc8e9-8a66-4865-bdb9-0444035177b5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "edf1be8f-98e2-41e3-bab7-d187ee260706");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ee0672af-86c2-471a-9d15-c70092d1c083");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ee12cd5d-af19-4f88-a1d2-964d7f779693");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ee1a5f6e-0353-40d0-8300-ea0ec9841ecd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ee39774f-037e-471a-b887-7c76c0161417");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ee65864b-5ba3-4695-809f-6910bde8a7b0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ee7b70bc-7a4d-4f03-a5fa-803a686503ac");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eeb7e98b-d678-4729-bd8b-f42948727e84");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eee2f078-da23-43bd-b4d3-6e5bd4a38c07");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "eefc2640-c372-4743-a2d6-edf64c11f975");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ef18c6cd-a1c4-47e4-99bc-88fd6fc40397");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ef574937-29a0-4f45-bd17-86d86a5941fa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ef617524-c6ee-4902-a024-1f9fa652af76");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ef6369e1-8878-41e4-8d4f-a7624e82fcf7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ef84e55d-c21b-4513-95f1-5f59043fe5b5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ef95d7cc-8474-4f8c-a5d2-ebf465f88cb8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "efad04c0-d632-4453-acac-c435fbb86d9f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f01f5901-a7b6-49a2-b29a-338841e41455");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f0234ea1-cda0-402a-9e60-50fa4bb8a272");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f02de341-15b2-45dd-ac8e-1dfb82a62dc8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f0377d55-15bc-4930-9e2f-7bd7b794fdda");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f0548bfb-0a89-4b25-9277-114d8fc22dcf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f0766e19-3f60-46c4-98e9-fc68e6529ed6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f0932eca-a43b-426f-8064-f513fac1af74");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f0bbf6ae-30e7-46bb-97ce-927dbe52e4a5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f0c94c37-f1ea-440a-ab2b-4f6533847d6b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f115aeae-6d78-4f0d-90a4-2a1827430731");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f153f415-a589-4a2d-b2e8-f222f0fbc1a5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f16ea8d9-9ddf-4172-aabb-f67b83d7a6bb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f17c9875-7c17-4181-b669-1f9bf7d3a3a8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f180460b-6955-4ffa-869c-7194035494a2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f1899ee8-e9b1-46ab-b8bc-b562b78d109b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f1cf8c89-d0c5-44b0-9873-e09e80bc8ac9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f20727fe-7993-4433-bd3a-c37c35c7df5c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f20d66bf-fbf7-4ba3-8120-95ebccccb97f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f21aad4f-0eba-4e5a-a7e7-e1c0fe3e9535");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f21b2667-fcc4-41a9-b7ce-c67fb3f7de41");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f21e2051-4621-4835-97ca-2208d5ddd7e9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f22e1df7-82ae-4f2c-8161-942c0b34fcaa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f2327526-5655-4118-8375-40607894b103");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f2380a1f-0186-4740-9df8-326e528c2869");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f241e6e3-574f-4d16-9588-321f54ecd09a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f257d21c-812b-4205-bc84-c5f1e4da1c55");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f279af98-4d39-492a-9e5c-4f94a699d05e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f2836734-6d97-4ecc-82e8-99de5f38013c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f2bf2185-1f1a-4ef7-85b9-41cd578aa7a0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f2e99acc-8dc4-4378-8a45-669a80d7e54d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f2eb2780-dd9e-4462-9dab-4c937c06ec0f");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f2f1ff2f-4857-4b42-946c-a24a74d9b7c7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f311c666-883f-4afd-ab57-16cbd778976c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f31304af-ccd2-47b2-a36c-1ef35e144c2a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f35d0ea4-8ea8-4170-8096-16c5cca37d53");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f36d9d4f-103c-4570-9153-dd3743f8b929");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f371440a-62e5-41e2-8fab-9c3208b4e9f6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f37f331b-d6a9-4607-8544-1d2fdc26b8ee");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f39717ff-f98e-490d-b8f5-969151a18dab");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f397363a-d231-4997-ba4e-b18e1a921762");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f3d543c8-3cf4-4c79-8f4a-a9b6cb8755ef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f3e60e4b-1ffa-413c-ab97-f6b8fe16dea8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f4157e7c-bfab-41e0-a7c8-098f9f57d55c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f4193040-b47f-426c-b7b8-939c9e99469b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f4b4603f-ac73-4daf-88a4-bcdc65b9cac4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f4cdd8a1-349f-4570-9554-708844d605c7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f4d13126-8fd1-4762-ab7d-77f05c1484bc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f4f94f33-6dd3-49d0-b4d6-602decebe7df");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f520caf3-ac0d-4197-b06c-4710ef03f6aa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f559fbe8-ad9f-4e72-b3aa-8273dcf6d286");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f55e79cb-da04-489a-94b1-75a847586bf6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f58aacd6-f3d7-4275-b631-70697d25254b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f58ac017-d008-40c8-b21d-83503c3d9379");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f5a62bc9-9de2-4baa-a89f-46125098978d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f5a8ba17-01be-4ecb-a64c-85b6c7cf7de3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f5e81856-1220-4377-ad1b-bf57d3aac83e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f61f9d9a-f21f-44c7-a708-72ec1339ba99");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f6278fcf-f47d-474d-ae1d-2e2eef65e3f9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f6369080-5936-45d9-a0cf-2a650524e493");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f658df0a-defc-4b4e-9055-f7932eb81442");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f6cc2c3d-d0c0-44a7-b8d3-36486df5c0f2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f6cd10bb-0266-494b-9548-a2ab57c44bd0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f6cd5c5a-b86b-4ba8-a9ee-08b98d2a4c1c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f6e00951-c837-4256-92db-8f4620d7a20c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f70e9530-23e8-45d4-9444-4c7b41cef8ff");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f74697fc-bf24-4574-af1a-28d8d7cbfe8e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f749cce7-1568-4afc-9a48-4953aec74c71");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f75e1f73-8511-46b0-9476-a148f780cc09");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f762aae3-d7a7-4482-bfc0-1ffc221f5c71");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f767cc2c-5a22-4cac-910c-a902c8cd698c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f7a9b219-5af4-4edb-ba21-abde8fb22f7e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f7e527d2-f6c8-4fce-9987-8c05fad867a3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f8c1e80e-5432-46d3-a4f6-0c3ed82e277d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f8df775a-6e3d-42aa-91bb-1ff3e45b38d7");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f90cef23-809c-4451-a8bf-45c140cb1c61");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f92e8ef6-bc6b-4740-be35-836166839fbd");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f9455138-d9e5-445b-8c0a-7473925c213b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f97738e2-4e92-4577-9c77-a77d808e4cc4");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f9a1ddf1-75f5-4564-af34-022202259d9e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "f9ae88e5-456a-4cfd-b000-87491247db8a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fa232d0a-c203-453f-8a5a-af0839c5e066");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fa35d13b-6bb9-450e-844b-71a1e8d35485");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fa5bf7e3-d118-4666-b902-3077b650a40d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fa5daab4-aca4-40b4-926a-b71bc7740771");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fa6803da-c4e3-47ad-9f20-d0ca7dd14dfc");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "faa859e6-567c-49ba-b98b-56db129dab74");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fad0f6de-9b28-492f-81c2-b93a9f3626b9");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fad55c20-2117-460d-bfc5-6c0bf30d4db2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fb02b750-ee76-4ed9-bd52-32aff9d2577c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fb16a175-303b-438d-a00c-e2c3af661eeb");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fb2288ee-0b61-4779-afa0-16238ac27290");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fb28fc0a-482b-40f1-b6d3-a47f0d660834");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fb301a4d-6011-47c1-8ff5-617d6ccc7560");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fb8246e2-dbf0-4817-a4e9-1e7d081ba30a");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fbd660bf-10e8-4454-b9fc-77c0b84fd292");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fc2f8b59-dd1c-4ad6-993e-7ee1eb5812e3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fc660abb-9a67-49f3-841d-17c2d758c67b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fc6e4f51-6365-455c-9e9d-ef3132552acf");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fc74cfed-809f-4b1b-9851-f88392d71f6d");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fc87f664-8987-4cfd-a67f-4212bff46d2c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fcab5133-64d6-4954-b136-9ca7a80346b6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fceb6f93-57ea-4ca6-9a1f-6a30a95ef863");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fd14c7ec-5b97-461b-8813-15de4fed2680");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fd25ba79-e102-4f09-92c0-47098f203835");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fd51f57a-fcfd-4251-b4d4-f74e38c1f45b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fd87a781-43b3-4857-9b5e-8dbbb307d981");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fdae035e-c965-455c-a1a5-f9a0c714b4aa");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fdcced67-200e-462a-a257-6d8a54176ea3");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fdda3f1a-dac8-4f24-877a-f7f5f36ac7e6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fdefbd47-8622-4671-8ab6-5be7411ffa9e");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fdf95ef7-63b0-4dbc-ab1b-3031f15ee2a0");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fdfbcc8c-4b59-4460-b4bc-55e96e08887b");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fdfc34cb-4a55-4092-b1b1-d406ab106a74");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fe09eab7-e2f3-447c-be69-33b197241685");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fe6c370d-6a17-4afe-a3b6-627b3dd4fa73");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fe74c716-a02b-45c9-94d8-7b530a8d5890");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fe7630b2-b4cf-466d-8a53-5394e019a0f6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fe8dee5e-a1d4-4122-8b8a-e73edaf4ab19");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fe9e421e-38cc-41c2-9c32-3e1b5b0819f8");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "feaedb31-91f1-4d76-8dbb-e4ab76287958");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fed89395-5eb5-4626-8aba-1d43cee89f54");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "fefbd7ce-cfe1-4312-930b-aa938e3b0011");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ff27a0b3-0dc8-4ef4-b7de-1112f2a58535");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ff412258-3a26-4c45-9d75-34770deaf43c");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ff51ec3e-200c-43d2-984b-49d1243b2ee1");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ff5da6db-8721-4056-af94-968e461f03f5");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ff5edbe8-ae33-482b-9cd9-3a6bb964d058");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ff7ba8a0-c282-4ed4-a3a5-0a2be0146521");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ff82d2a3-6df7-4ca6-a174-0b637ed415ef");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ff8cee52-2991-4467-a7c1-055a903ff4a2");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ffd1e0a3-08fa-4dc0-83fc-cd1e9e236657");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ffd33fde-fad1-49bf-a9e4-310dc5fbfbd6");

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: "ffe27fd6-a061-4a4c-b42d-75f7518cbe76");
        }
    }
}
