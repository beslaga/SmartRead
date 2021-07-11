using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRead.API.Migrations
{
    public partial class addNotifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifikacije",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false),
                    ClanakId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacije", x => new { x.KorisnikId, x.ClanakId });
                    table.ForeignKey(
                        name: "FK_Notifikacije_Clanci_ClanakId",
                        column: x => x.ClanakId,
                        principalTable: "Clanci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifikacije_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.86878434236570468, "Perferendis omnis error labore rerum eos doloribus voluptatem sed.", "Porro libero ratione voluptate repudiandae cumque ut at molestiae. Recusandae aut blanditiis iusto adipisci eaque id qui nobis est. Rerum fuga et dolor veritatis odit aliquam aut officiis ullam. Possimus repellendus rem. Animi aliquam quis est corrupti." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.39555138973312054, "Beatae dolorem laudantium dolor excepturi.", "Sed magnam fugiat voluptatibus assumenda ipsa. Fuga at mollitia sunt. Omnis quidem vero nisi libero delectus eum odio atque. Sapiente sed perferendis qui. Aspernatur voluptatem minima mollitia enim inventore laudantium. Eum molestiae aut cumque quia autem harum occaecati magni." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.5450020113703804, "Consequatur dignissimos ut.", "fugit" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.78351094749919648, "Excepturi non quia.", "Delectus amet dolores consequuntur nemo in alias dolor." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.32492764309278116, "Accusamus doloremque esse.", "Veritatis at eligendi eum consequatur maiores omnis. Magni adipisci dolorem. Adipisci unde sed. Sed ullam voluptas sint dolorem dolore." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.97966801281071636, "Consequuntur et et quisquam sunt itaque nihil magnam minima est.", "Harum praesentium qui." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.4300561353704222, "Reprehenderit repellat aut voluptate tenetur qui.", "omnis" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.52903407045129414, "Sed voluptatem placeat cum illum non.", @"Maxime illo provident consectetur.
Repudiandae assumenda qui aspernatur praesentium consequatur.
Deleniti eos odit.
Magnam numquam sed quia doloremque consequatur.
Qui ducimus officia tempora." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.41182537396057761, "Harum unde rerum possimus fuga ut ex eos consequatur dolorum.", "Alias eos explicabo fuga." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.34814411091997477, "Neque facilis et similique enim non non dolorem.", @"Quod ut est et et totam.
Et quia at fuga placeat sunt odio mollitia ipsa asperiores.
Accusamus architecto occaecati.
Hic et rerum.
Et ut tempore tempora praesentium dolores totam voluptatum.
Porro consequatur earum." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.39219979680711392, "Sit cumque sunt repellendus sed saepe tempore consequuntur.", @"Eos accusamus vel et nihil tenetur dolorum.
Delectus in tempore dolore explicabo." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.67975908549491271, "Minima aspernatur quis aut.", "illo" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.0038757203164863029, "Saepe qui hic dolorem.", @"Earum occaecati quas.
Quia fuga expedita est consequatur omnis amet qui.
Enim molestias qui asperiores reprehenderit voluptate.
In possimus fugiat itaque atque blanditiis cum.
Quae facere temporibus explicabo consequatur rerum praesentium sequi maxime ea.
Quas fuga corrupti." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.013760483364463078, "Quae totam exercitationem.", "Tenetur est sed autem dignissimos. Est error non et. Id error laborum aut sunt numquam iusto vel ex impedit. Quia et doloribus dicta facere porro necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.99488789494842655, "Facere sed soluta et.", "reiciendis" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.21970879762419909, "Ad totam sit adipisci sed iste rerum.", "A aliquam vero aut. Distinctio consequatur ducimus. Eum ex et ut. Adipisci nihil velit velit rerum vel a fugit." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.40253218049301404, "Sed necessitatibus cupiditate qui quia ut aut neque ea sunt.", "Rerum molestias sit et similique. Laborum voluptatem nulla dolores molestias repellat dolores ea est. Culpa sit voluptas. Molestiae in eos. Ut quia et minima. Quasi qui quod iusto." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.24500959750498161, "Est et vel reprehenderit aliquid est dolor.", @"Qui et doloribus.
Consequuntur dolor iure sunt est autem.
Quis rerum laudantium." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.49152145837038824, "Sit sapiente est aspernatur voluptas natus explicabo et repellat quia.", "autem" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.28510562902554198, "Ratione rerum maxime fugit sunt optio.", "Nostrum consequatur est. Accusantium quos voluptatem reiciendis sint ratione blanditiis ad. Sint exercitationem magnam fugiat sed consectetur esse hic culpa. Animi ullam incidunt dolor et assumenda necessitatibus. Voluptatem totam eveniet atque explicabo sed pariatur. Nemo soluta adipisci." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.14727939066816093, "Eaque voluptatem quia ut qui et id neque.", @"Quo velit ab.
Autem ipsam eligendi non accusantium mollitia.
Consequatur molestiae iusto velit dolores maiores.
Rerum id facere exercitationem rerum natus." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.27322765359339662, "Non quia et voluptatem iure laboriosam sit dolor est soluta.", "iusto" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.4713001118373592, "Maiores maiores quaerat illo id nisi in provident magnam qui.", "Impedit commodi esse totam corrupti ut rerum aut sint. Officiis non explicabo temporibus qui. Occaecati et unde adipisci saepe facere voluptas aperiam. A aut molestias cum molestiae quia in eligendi ut enim. Ex numquam culpa ipsum iure necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.9071677755132167, "Eum nulla excepturi omnis aliquam accusamus minus nam.", "et" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.049913404998329192, "Animi eum in provident praesentium vel molestiae officia consequuntur voluptatum.", @"Qui nemo corporis atque vel aut.
Minima vitae est.
Dignissimos aliquam magnam.
Adipisci molestias consectetur consectetur harum aliquid illum aut rerum." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.72040242223087814, "Consequatur laudantium aut iste voluptates voluptas a quasi.", @"Sit dolorem eligendi ut cum sint.
Non sunt quia magni et qui dolorum veniam.
Et consequuntur voluptates suscipit nam.
Libero et ut in cupiditate quod." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.48811425757040933, "Sit quisquam dolore voluptas voluptas commodi.", "Tempore ullam et aut sapiente quas debitis nulla." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.40626521241211577, "Fuga repellat eaque rerum et tempora voluptas placeat nesciunt saepe.", "Asperiores doloribus consequatur id accusantium." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.58922183308248488, "Et nostrum sint fugiat adipisci.", "Explicabo omnis rem dolorem et optio voluptates." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.0024442747246680198, "Quisquam ducimus labore.", "sit" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.84401003403775865, "Quia animi consequatur qui nemo magnam corporis.", "Rem rem eos facilis nihil neque." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.9438813356421335, "Consequatur magni non ad doloribus aut.", @"Officiis dicta nesciunt repellendus corporis ex.
Quo quo ut dolorem inventore corporis voluptas.
Fugit est qui tempora ab." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.37988221895875512, "Natus animi maxime aspernatur rerum autem.", "Et cumque accusantium et." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.9949789806245728, "Velit eligendi ipsum sed.", "recusandae" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.40740260826768476, "Sit et nihil nostrum a nesciunt corporis occaecati odio voluptatem.", "Non iste ipsa quia totam fugiat." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.72617346547831474, "Id quia aperiam in praesentium aperiam.", "Odit vel aut esse et. Ipsam reprehenderit mollitia fugiat qui repudiandae odit. Nihil ducimus sint est rerum. Delectus et ea non et voluptas saepe qui. Eum molestiae et corporis et. Molestias ducimus quae eveniet ut." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.91660903949132611, "Accusamus alias voluptatem qui dolores eos sit tenetur perspiciatis.", "Ut ipsam blanditiis velit atque." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.97601054514572516, "Est sint dicta voluptas et.", "Recusandae adipisci repellat officiis temporibus libero molestiae voluptatem dolor. Voluptatem sint eum aperiam et ex. Culpa delectus a molestiae officiis. Delectus magni mollitia. Consequatur est odit explicabo commodi." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.74322127911412217, "Non dolores tenetur tempore iste id nihil neque.", @"Alias rem expedita pariatur.
Deleniti voluptas recusandae est itaque inventore aspernatur doloremque." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.19905016720250723, "Iure fugit molestiae cum.", "Earum velit odit non in et voluptatem commodi provident omnis." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.38223612000338553, "Maxime consequuntur consequuntur.", @"Fuga voluptas molestiae voluptas eligendi officiis eaque et molestiae commodi.
Nemo id alias nihil.
Veritatis ad omnis et sit.
Nemo sunt fugit dolor vero aut quis et et.
Nesciunt et ab ut rem laborum quas ut necessitatibus.
Est expedita ratione tempora accusantium velit." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.30528730587348685, "Et pariatur architecto eaque distinctio omnis.", "Non sint perferendis accusantium quidem enim ullam qui voluptatem." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.69486713488347229, "Dolorem nulla ducimus assumenda voluptatem doloremque vero dolor est molestiae.", "Et eos unde numquam eligendi sed assumenda nostrum. Et ea doloribus. Et quo autem ea." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.282129148152717, "Quisquam dolore eius.", @"Facere consequatur aut.
Vel et voluptatem commodi ex in omnis.
Dicta possimus doloremque sed distinctio dicta incidunt quae dolor.
Dolorem sit et.
Minus illum et velit velit." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.041670701020243901, "Dolores itaque fugit delectus impedit ut amet vitae fuga et.", "Est ad itaque." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.98593732108638499, "Officia magni ut in.", "Voluptas repellendus omnis cupiditate cumque quas recusandae earum." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.6913104158320047, "Quo hic qui sint similique hic.", "Sequi ut cumque a adipisci perferendis autem est dolore qui. Recusandae aliquid fugiat veniam ad. Non maxime corrupti in." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.019052124125441595, "Deleniti similique assumenda quia fugit quia et rerum enim nemo.", @"Eos eum qui molestias et qui.
Quia nihil natus corrupti sed sed facilis iure." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.65105913190686104, "Iste eum laudantium.", "Iure nihil eligendi soluta." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.7750677241827677, "Sit ut fuga id eligendi eos dolores aliquid.", "Qui pariatur alias et." });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 14, 42, 678, DateTimeKind.Local).AddTicks(4634), "eaDBRKgnufXXDbhU5meI0oFYkEsVoLDfFSny7O77eSvYMMGEcpke54b5n8i4Hhhdp68VaRSeBJn5HdQZq6y4Mw==", "INPbfEQVOCdQkXsGVK3d8Q==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 14, 42, 684, DateTimeKind.Local).AddTicks(9056), "eaDBRKgnufXXDbhU5meI0oFYkEsVoLDfFSny7O77eSvYMMGEcpke54b5n8i4Hhhdp68VaRSeBJn5HdQZq6y4Mw==", "INPbfEQVOCdQkXsGVK3d8Q==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 14, 42, 684, DateTimeKind.Local).AddTicks(9588), "eaDBRKgnufXXDbhU5meI0oFYkEsVoLDfFSny7O77eSvYMMGEcpke54b5n8i4Hhhdp68VaRSeBJn5HdQZq6y4Mw==", "INPbfEQVOCdQkXsGVK3d8Q==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 14, 42, 684, DateTimeKind.Local).AddTicks(9647), "eaDBRKgnufXXDbhU5meI0oFYkEsVoLDfFSny7O77eSvYMMGEcpke54b5n8i4Hhhdp68VaRSeBJn5HdQZq6y4Mw==", "INPbfEQVOCdQkXsGVK3d8Q==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 14, 42, 684, DateTimeKind.Local).AddTicks(9685), "eaDBRKgnufXXDbhU5meI0oFYkEsVoLDfFSny7O77eSvYMMGEcpke54b5n8i4Hhhdp68VaRSeBJn5HdQZq6y4Mw==", "INPbfEQVOCdQkXsGVK3d8Q==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 14, 42, 684, DateTimeKind.Local).AddTicks(9722), "eaDBRKgnufXXDbhU5meI0oFYkEsVoLDfFSny7O77eSvYMMGEcpke54b5n8i4Hhhdp68VaRSeBJn5HdQZq6y4Mw==", "INPbfEQVOCdQkXsGVK3d8Q==" });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 2 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 3 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 4 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 5 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 7 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 10 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 12 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 13 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 14 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 18 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 19 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 22 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 23 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 24 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 25 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 27 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 28 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 33 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 37 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 39 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 48 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 1 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 8 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 9 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 10 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 12 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 13 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 16 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 21 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 23 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 26 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 28 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 29 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 30 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 31 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 38 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 42 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 43 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 48 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 3 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 4 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 5 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 12 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 13 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 16 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 17 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 19 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 23 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 24 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 25 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 27 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 30 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 34 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 36 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 38 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 47 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 48 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 49 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 3 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 4 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 13 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 17 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 22 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 23 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 24 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 26 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 32 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 33 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 36 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 37 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 38 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 39 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 44 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 48 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 50 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 3 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 5 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 6 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 9 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 13 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 14 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 17 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 23 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 26 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 27 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 31 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 37 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 41 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 45 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 48 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 49 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 50 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 6 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 13 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 15 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 18 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 20 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 23 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 29 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 32 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 35 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 37 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 42 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 48 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacije_ClanakId",
                table: "Notifikacije",
                column: "ClanakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifikacije");

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.77183610143691117, "Ea magnam corrupti in aut quia quis voluptatem.", "Earum ea ut delectus itaque. Maxime quibusdam sunt doloremque ratione quisquam eaque incidunt. Veniam autem rerum saepe quo sequi non praesentium. Rerum ex consequatur quo unde repudiandae eaque consequatur. Velit ullam distinctio eum deserunt quibusdam non." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.80539895026264663, "Voluptates expedita aliquam.", @"Consequuntur ipsa dolores cum.
Officiis aut aut.
Molestias quia qui ex aperiam dolore dolor asperiores qui sed.
Non perferendis qui velit nulla delectus et sunt voluptatem." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.73088052763178968, "Fugit et adipisci qui molestias quam.", "Facilis explicabo quis quisquam quia enim numquam sunt id vel." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.012871898251060349, "Fugit quia est labore fugit deserunt exercitationem eum.", "consequatur" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.86400530993193636, "Dolores aperiam non cum neque ducimus quod possimus harum sed.", @"Nostrum magni non harum qui voluptas minima nostrum.
Ex temporibus exercitationem tenetur.
Sint quia provident quo quo vitae.
Qui quis inventore sed voluptate.
Architecto aut doloremque repudiandae voluptas." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.92689276716061531, "Qui praesentium consequatur velit impedit atque id.", @"Quam vel quia reiciendis dolorem quidem aut commodi.
Nam ut nihil voluptas accusamus explicabo maiores eaque.
Voluptatem fugit odio voluptatem.
Ex facilis blanditiis possimus sit magni.
Nisi animi deserunt id quidem.
Sed enim dolore suscipit." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.52893207479684246, "Ipsa velit magnam sed dolorum et odit.", @"Vel debitis labore in rerum pariatur suscipit.
Debitis assumenda incidunt consequatur voluptatem.
Aut ut incidunt recusandae dolor est a voluptatibus.
Necessitatibus voluptatibus ut odit." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.97677748462966529, "Quaerat tempora voluptate voluptates vel eius porro consequatur labore.", "aliquid" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.49787941551668541, "Praesentium sequi voluptatem tempore aut quas consequatur eum ut ipsum.", "In est aliquid esse quo maxime aut. Dolorum perspiciatis dolorem praesentium quas non qui. Doloribus est et placeat beatae cupiditate doloremque sunt nemo. Animi cupiditate qui doloribus illo. Consectetur labore qui doloremque sit qui." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.46450467569031972, "Ipsum laboriosam quo est dolores non autem.", "Minima ducimus molestias ut dolores officiis expedita. Aut ea qui minima dicta harum quos ex enim. Nihil consequatur at dolorem tempora. In quod nobis quam architecto explicabo reiciendis dolorum repudiandae. Impedit id a eius quod rerum quis ut quo eos." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.39156110416704842, "Aliquam quia sed qui earum odit enim dolore expedita aut.", "est" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.74653068638710807, "Consectetur ut nihil perferendis vel occaecati consequatur ratione et.", "Cupiditate omnis asperiores. Qui dicta ex nobis atque deleniti corporis. Sequi officiis aliquid libero veniam mollitia vel enim eum maiores. Dolores provident optio possimus earum cupiditate aut veniam incidunt." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.95926893593709406, "Culpa excepturi magnam ipsa distinctio dolores sit nihil enim impedit.", "Molestias ipsum cumque eos quia molestias quia modi sed. Vero dicta facere. Esse neque autem velit architecto. Ut nostrum quo esse. Itaque dolore earum quia. Ab sed omnis quo magnam assumenda qui dolore." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.58112237582966797, "Fuga nam ipsa molestias reprehenderit tenetur et aut.", "Molestias vero qui deserunt numquam sit veniam fuga eum quaerat. Aspernatur qui tenetur expedita. Sint vitae facilis nisi consequuntur. Ut error animi dolore. Accusantium quis aperiam odio voluptatem." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.72477531047760291, "Ut nisi quia dolore aperiam odio sed fuga in.", "Error modi omnis id et doloribus." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.64217864938181757, "Velit assumenda enim molestias voluptatem.", "Quaerat laboriosam ut. Nesciunt occaecati alias esse enim voluptatem libero quae quia. Quas nam rerum quia aperiam accusantium omnis quis expedita. Porro placeat vel. Enim quo sequi. Et iusto minima quis tempora." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.22273922023490966, "Quae modi eos molestiae deleniti.", "Et qui ut est fuga eveniet a earum." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.48309389431173627, "Soluta ullam odit voluptate eos hic ratione rem repellat esse.", "Numquam odio et nulla maiores aut rerum. Dolor qui eaque nobis maiores repellendus nam non aliquam. Quia numquam nemo id molestiae. Officiis voluptates enim asperiores tenetur deleniti ut. Ullam accusamus ab ipsum vel illo ut eos. Aut quas sunt et est voluptatem neque." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.89316612383963823, "Quod quia eos iste eius.", @"Ut beatae provident est et optio eum nisi.
Sed id quos fugiat sed quia.
Harum adipisci aut ex totam ratione possimus aut molestias eligendi.
Dolor fugiat maxime est odio expedita tempore vitae." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.32006834881383384, "Recusandae sed aut quod est laboriosam aperiam.", "Molestiae ut quibusdam debitis et accusantium molestias nesciunt labore dolorem." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.69865364846710754, "Eos numquam a ab excepturi rerum.", "Quo neque sed et quis." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.10504900855247351, "Exercitationem laborum maxime aut quisquam nobis occaecati ut velit voluptatibus.", "Non dolores et aliquam sunt consectetur autem. Nulla eligendi numquam cumque similique consequuntur voluptatem voluptatem quam commodi. Modi aperiam numquam unde dolores sit animi. Dolorum hic omnis et iste illum nulla consequatur. Qui eos vero sit et. Ducimus sint provident." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.10803365898692685, "Natus consequatur alias omnis.", @"Deserunt porro hic itaque labore aut blanditiis.
Ipsa dicta fuga expedita.
Est omnis consequatur sed iste molestias quia voluptatem aperiam assumenda.
Delectus repudiandae dignissimos quia magnam rerum maiores ducimus." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.69257434210394242, "Aliquam et reprehenderit autem.", @"Qui a commodi nostrum officiis modi et et.
Laudantium eius aut consequuntur minima natus rerum.
Aut quia non veniam et.
Aspernatur dolor unde.
Rem odit esse quod recusandae dolorum deserunt officia.
Ea laboriosam sunt." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.61344529437527306, "Autem eligendi deleniti.", "Itaque eligendi nihil architecto qui ullam ex ducimus consequatur eos. Fugit quia iste a eligendi. Est quis corrupti provident. Atque perspiciatis voluptatibus aut harum sint et incidunt." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.68111956710048005, "Voluptas similique qui omnis in.", "Harum ut ratione dolor non eos modi assumenda eos illo." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.66762774608453168, "Possimus atque pariatur ducimus dolore non neque.", "itaque" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.63460828812541825, "Ut in magnam recusandae ad possimus eum sit nostrum.", "Modi iure voluptates ad ea possimus fugit dolores. Tempora soluta vero pariatur asperiores quia. Similique labore magnam voluptatibus delectus molestiae. Quia sapiente quia hic aut nemo officiis. Placeat tenetur eum fuga inventore suscipit. Omnis suscipit dolorem ipsum vel ipsam saepe qui dicta veniam." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.74553449998867438, "Et illo unde qui est.", "Enim velit consequatur aut amet officia quo non. Sit consequatur veritatis qui harum voluptatum repudiandae nesciunt autem ab. Enim similique sed nam autem. Aliquam sit sed dolores qui fugiat ad harum fuga error. Est maiores autem deleniti sapiente dolores quasi. Sunt quia maiores culpa quidem nam saepe maxime quos qui." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.91380104977348864, "Qui est tempora.", "Qui voluptas debitis provident repellendus excepturi consequatur." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.80464841975115631, "Et aut quaerat consequatur ut architecto.", "placeat" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.19290894139227874, "Ut facere error rem dolore sunt dolor labore debitis.", "Repellat omnis blanditiis aut ut qui." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.68249121386673828, "Repellendus eligendi reiciendis nam dolore incidunt.", "corrupti" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.20500046769389904, "Tempore aperiam qui.", "Placeat neque nostrum. Dignissimos alias enim magni et consequatur iusto quae. Quo fugit nisi at commodi sit veritatis nostrum sunt. Et nesciunt animi aspernatur adipisci." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.043419701067460563, "Maiores beatae nostrum reprehenderit modi quasi.", "Earum repellendus quam pariatur ut labore quibusdam." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.8793686772134941, "Nulla non voluptas dolor aperiam ut velit omnis.", @"Rem voluptas et.
Molestiae voluptatibus voluptatem.
Possimus voluptate et quae et.
Quam ut rerum dignissimos at.
Ducimus fugit repudiandae.
Voluptatem debitis ad hic dolor." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.006612216125527497, "Natus modi reprehenderit sunt aspernatur aut nisi.", "Odio quis minima incidunt. Nihil rerum laborum libero est suscipit aut voluptas animi ex. Est illum ab impedit quasi quia debitis temporibus illo qui. Velit quia ex ullam occaecati animi eos." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.29888778845727804, "Harum accusantium vel qui iure laboriosam excepturi odit veniam.", "Id ipsum incidunt cupiditate officiis perspiciatis ratione voluptatem velit. Dolor veritatis voluptates nobis nostrum enim. Vel sed ut deserunt non exercitationem. Iusto mollitia voluptatem minus nam assumenda molestias." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.19676444968058004, "Est laudantium voluptatem quia est.", @"Quod esse qui pariatur voluptatem perspiciatis cumque ab.
Harum totam unde natus." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.59860779652307172, "Debitis est dicta ad.", "esse" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.1834975905639574, "Voluptatibus debitis cumque amet modi eos amet cumque.", "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.80307805435875335, "Fugit voluptatem omnis sed illo et nobis totam dolores.", "placeat" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.16244651617596229, "Aliquam ad sint nobis quis eum corporis.", "assumenda" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.82960187868662261, "Dolorum ea deleniti voluptates aut non corporis in autem nisi.", "est" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.84029913965626579, "Eius est qui magni molestias earum magni eveniet expedita delectus.", "Autem voluptatem aut. Nisi doloribus consequatur et optio eos est blanditiis. Id ut molestiae sit. Unde est porro voluptatem. Sunt perferendis voluptatem eius." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.25539902749257115, "Cumque excepturi ipsa laboriosam repudiandae molestias vitae dolores.", @"Voluptatem totam cupiditate totam tenetur tempore corporis quia.
Totam voluptatum et voluptatem voluptatibus ullam facilis aspernatur nemo.
Vitae assumenda delectus omnis asperiores et minus sed.
Tempora ut recusandae perspiciatis quam.
Nam dolore et facere et laboriosam a perferendis inventore." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.63685927895682826, "Quo est ea et.", "Earum nam delectus illo. Non voluptas modi iste perferendis reiciendis sint sed. Eum quas ipsam ab sit ut eligendi ex quia possimus. Occaecati assumenda sint aut omnis tempore commodi veniam maxime id. Nulla laborum omnis aspernatur repudiandae qui dolor rerum aperiam. Quisquam exercitationem voluptas eius ipsa error nulla." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.38008775020953628, "Qui perspiciatis non ratione quia possimus.", "Laboriosam et incidunt autem voluptas et distinctio nihil dolores. Iusto exercitationem sunt quia quisquam commodi et rem officia temporibus. Aut sint est dolore sit quia harum laudantium." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.49104450945325406, "Maiores sit maiores est quam.", "Ut optio iste suscipit et non sed velit aut consequatur." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.58780001736609266, "Quis veniam laboriosam nihil beatae tempora aspernatur qui perspiciatis.", "Doloremque labore sed culpa ducimus fugit." });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 10, 16, 58, 54, 403, DateTimeKind.Local).AddTicks(1890), "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6179), "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6732), "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6798), "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6842), "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6881), "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==" });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 2 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 3 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 4 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 5 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 7 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 10 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 12 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 13 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 14 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 18 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 19 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 22 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 23 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 24 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 25 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 27 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 28 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 33 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 37 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 39 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 48 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 1 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 8 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 9 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 10 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 12 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 13 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 16 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 21 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 23 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 26 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 28 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 29 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 30 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 31 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 38 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 42 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 43 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 48 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 3 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 4 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 5 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 12 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 13 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 16 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 17 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 19 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 23 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 24 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 25 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 27 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 30 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 34 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 36 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 38 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 47 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 48 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 49 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 3 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 4 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 13 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 17 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 22 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 23 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 24 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 26 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 32 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 33 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 36 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 37 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 38 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 39 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 44 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 48 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 50 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 3 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 5 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 6 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 9 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 13 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 14 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 17 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 23 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 26 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 27 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 31 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 37 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 41 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 45 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 48 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 49 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 50 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 6 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 13 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 15 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 18 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 20 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 23 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 29 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 32 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 35 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 37 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 42 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 48 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });
        }
    }
}
