using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRead.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategorije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Obrisan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    DatumRegistracije = table.Column<DateTime>(nullable: false),
                    Kredit = table.Column<double>(nullable: false),
                    Obrisan = table.Column<bool>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    DrzavaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korisnici_Drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clanci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    Odobren = table.Column<bool>(nullable: false),
                    Obrisan = table.Column<bool>(nullable: false),
                    AutorId = table.Column<int>(nullable: false),
                    OdobravateljId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clanci_Korisnici_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clanci_Korisnici_OdobravateljId",
                        column: x => x.OdobravateljId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikKategorije",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: false),
                    Obrisan = table.Column<bool>(nullable: false),
                    DatumPretplate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikKategorije", x => new { x.KorisnikId, x.KategorijaId });
                    table.ForeignKey(
                        name: "FK_KorisnikKategorije_Kategorije_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikKategorije_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloge",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false),
                    UlogaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUloge", x => new { x.KorisnikId, x.UlogaId });
                    table.ForeignKey(
                        name: "FK_KorisnikUloge_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikUloge_Uloge_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iznos = table.Column<float>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uplate_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClanakKategorije",
                columns: table => new
                {
                    ClanakId = table.Column<int>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanakKategorije", x => new { x.ClanakId, x.KategorijaId });
                    table.ForeignKey(
                        name: "FK_ClanakKategorije_Clanci_ClanakId",
                        column: x => x.ClanakId,
                        principalTable: "Clanci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClanakKategorije_Kategorije_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikClanci",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false),
                    ClanakId = table.Column<int>(nullable: false),
                    BrojPosjeta = table.Column<int>(nullable: false),
                    Kupljen = table.Column<bool>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikClanci", x => new { x.KorisnikId, x.ClanakId });
                    table.ForeignKey(
                        name: "FK_KorisnikClanci_Clanci_ClanakId",
                        column: x => x.ClanakId,
                        principalTable: "Clanci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikClanci_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikPrijave",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrstaPrijave = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    VrijemePrijave = table.Column<DateTime>(nullable: false),
                    Pregledano = table.Column<bool>(nullable: false),
                    Uvazeno = table.Column<bool>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    ClanakId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikPrijave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KorisnikPrijave_Clanci_ClanakId",
                        column: x => x.ClanakId,
                        principalTable: "Clanci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikPrijave_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false),
                    ClanakId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.KorisnikId, x.ClanakId });
                    table.ForeignKey(
                        name: "FK_Likes_Clanci_ClanakId",
                        column: x => x.ClanakId,
                        principalTable: "Clanci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Drzave",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Bosna i Hercegovina" },
                    { 2, "Hrvatska" }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "BasicUser" }
                });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "Id", "DatumRegistracije", "DatumRodjenja", "DrzavaId", "Ime", "Kredit", "Mail", "Obrisan", "PasswordHash", "PasswordSalt", "Prezime", "Slika", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 10, 16, 58, 54, 403, DateTimeKind.Local).AddTicks(1890), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Maid", 0.0, "maid.beslagic@edu.fit.ba", false, "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==", "Bešlagić", null, "maid" },
                    { 2, new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6179), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Desktop", 0.0, "desktop@edu.fit.ba", false, "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==", "Admin", null, "desktop" },
                    { 3, new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6732), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobile", 0.0, "mobile@edu.fit.ba", false, "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==", "User", null, "mobile" },
                    { 4, new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6798), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobile", 0.0, "mobile1@edu.fit.ba", false, "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==", "User", null, "mobile1" },
                    { 5, new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6842), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobile", 0.0, "mobile2@edu.fit.ba", false, "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==", "User", null, "mobile2" },
                    { 6, new DateTime(2021, 7, 10, 16, 58, 54, 409, DateTimeKind.Local).AddTicks(6881), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobile", 0.0, "mobile3@edu.fit.ba", false, "XZWQQ52vGBABh8K7lqv6IjVBfq39JgGM+rItfUBuTAErL5mFOoqo9g+rDcAaVyBsyRMHvcI+8TBTCyYxQC1ByQ==", "3/4JKbfsJQkmoxEHXYkjVQ==", "User", null, "mobile3" }
                });

            migrationBuilder.InsertData(
                table: "Clanci",
                columns: new[] { "Id", "AutorId", "Cijena", "Naslov", "Obrisan", "OdobravateljId", "Odobren", "Slika", "Text" },
                values: new object[,]
                {
                    { 6, 1, 0.92689276716061531, "Qui praesentium consequatur velit impedit atque id.", false, 1, true, null, @"Quam vel quia reiciendis dolorem quidem aut commodi.
                Nam ut nihil voluptas accusamus explicabo maiores eaque.
                Voluptatem fugit odio voluptatem.
                Ex facilis blanditiis possimus sit magni.
                Nisi animi deserunt id quidem.
                Sed enim dolore suscipit." },
                    { 16, 4, 0.64217864938181757, "Velit assumenda enim molestias voluptatem.", false, 1, true, null, "Quaerat laboriosam ut. Nesciunt occaecati alias esse enim voluptatem libero quae quia. Quas nam rerum quia aperiam accusantium omnis quis expedita. Porro placeat vel. Enim quo sequi. Et iusto minima quis tempora." },
                    { 26, 4, 0.68111956710048005, "Voluptas similique qui omnis in.", false, 1, true, null, "Harum ut ratione dolor non eos modi assumenda eos illo." },
                    { 28, 4, 0.63460828812541825, "Ut in magnam recusandae ad possimus eum sit nostrum.", false, 1, true, null, "Modi iure voluptates ad ea possimus fugit dolores. Tempora soluta vero pariatur asperiores quia. Similique labore magnam voluptatibus delectus molestiae. Quia sapiente quia hic aut nemo officiis. Placeat tenetur eum fuga inventore suscipit. Omnis suscipit dolorem ipsum vel ipsam saepe qui dicta veniam." },
                    { 37, 4, 0.006612216125527497, "Natus modi reprehenderit sunt aspernatur aut nisi.", false, 1, true, null, "Odio quis minima incidunt. Nihil rerum laborum libero est suscipit aut voluptas animi ex. Est illum ab impedit quasi quia debitis temporibus illo qui. Velit quia ex ullam occaecati animi eos." },
                    { 49, 4, 0.49104450945325406, "Maiores sit maiores est quam.", false, 1, true, null, "Ut optio iste suscipit et non sed velit aut consequatur." },
                    { 50, 4, 0.58780001736609266, "Quis veniam laboriosam nihil beatae tempora aspernatur qui perspiciatis.", false, 1, true, null, "Doloremque labore sed culpa ducimus fugit." },
                    { 1, 5, 0.77183610143691117, "Ea magnam corrupti in aut quia quis voluptatem.", false, 1, true, null, "Earum ea ut delectus itaque. Maxime quibusdam sunt doloremque ratione quisquam eaque incidunt. Veniam autem rerum saepe quo sequi non praesentium. Rerum ex consequatur quo unde repudiandae eaque consequatur. Velit ullam distinctio eum deserunt quibusdam non." },
                    { 2, 5, 0.80539895026264663, "Voluptates expedita aliquam.", false, 1, true, null, @"Consequuntur ipsa dolores cum.
                Officiis aut aut.
                Molestias quia qui ex aperiam dolore dolor asperiores qui sed.
                Non perferendis qui velit nulla delectus et sunt voluptatem." },
                    { 3, 5, 0.73088052763178968, "Fugit et adipisci qui molestias quam.", false, 1, true, null, "Facilis explicabo quis quisquam quia enim numquam sunt id vel." },
                    { 4, 5, 0.012871898251060349, "Fugit quia est labore fugit deserunt exercitationem eum.", false, 1, true, null, "consequatur" },
                    { 9, 5, 0.49787941551668541, "Praesentium sequi voluptatem tempore aut quas consequatur eum ut ipsum.", false, 1, true, null, "In est aliquid esse quo maxime aut. Dolorum perspiciatis dolorem praesentium quas non qui. Doloribus est et placeat beatae cupiditate doloremque sunt nemo. Animi cupiditate qui doloribus illo. Consectetur labore qui doloremque sit qui." },
                    { 14, 5, 0.58112237582966797, "Fuga nam ipsa molestias reprehenderit tenetur et aut.", false, 1, true, null, "Molestias vero qui deserunt numquam sit veniam fuga eum quaerat. Aspernatur qui tenetur expedita. Sint vitae facilis nisi consequuntur. Ut error animi dolore. Accusantium quis aperiam odio voluptatem." },
                    { 22, 5, 0.10504900855247351, "Exercitationem laborum maxime aut quisquam nobis occaecati ut velit voluptatibus.", false, 1, true, null, "Non dolores et aliquam sunt consectetur autem. Nulla eligendi numquam cumque similique consequuntur voluptatem voluptatem quam commodi. Modi aperiam numquam unde dolores sit animi. Dolorum hic omnis et iste illum nulla consequatur. Qui eos vero sit et. Ducimus sint provident." },
                    { 27, 5, 0.66762774608453168, "Possimus atque pariatur ducimus dolore non neque.", false, 1, true, null, "itaque" },
                    { 29, 5, 0.74553449998867438, "Et illo unde qui est.", false, 1, true, null, "Enim velit consequatur aut amet officia quo non. Sit consequatur veritatis qui harum voluptatum repudiandae nesciunt autem ab. Enim similique sed nam autem. Aliquam sit sed dolores qui fugiat ad harum fuga error. Est maiores autem deleniti sapiente dolores quasi. Sunt quia maiores culpa quidem nam saepe maxime quos qui." },
                    { 30, 5, 0.91380104977348864, "Qui est tempora.", false, 1, true, null, "Qui voluptas debitis provident repellendus excepturi consequatur." },
                    { 35, 5, 0.043419701067460563, "Maiores beatae nostrum reprehenderit modi quasi.", false, 1, true, null, "Earum repellendus quam pariatur ut labore quibusdam." },
                    { 38, 5, 0.29888778845727804, "Harum accusantium vel qui iure laboriosam excepturi odit veniam.", false, 1, true, null, "Id ipsum incidunt cupiditate officiis perspiciatis ratione voluptatem velit. Dolor veritatis voluptates nobis nostrum enim. Vel sed ut deserunt non exercitationem. Iusto mollitia voluptatem minus nam assumenda molestias." },
                    { 39, 5, 0.19676444968058004, "Est laudantium voluptatem quia est.", false, 1, true, null, @"Quod esse qui pariatur voluptatem perspiciatis cumque ab.
                Harum totam unde natus." },
                    { 41, 5, 0.1834975905639574, "Voluptatibus debitis cumque amet modi eos amet cumque.", false, 1, true, null, "voluptatem" },
                    { 44, 5, 0.82960187868662261, "Dolorum ea deleniti voluptates aut non corporis in autem nisi.", false, 1, true, null, "est" },
                    { 45, 5, 0.84029913965626579, "Eius est qui magni molestias earum magni eveniet expedita delectus.", false, 1, true, null, "Autem voluptatem aut. Nisi doloribus consequatur et optio eos est blanditiis. Id ut molestiae sit. Unde est porro voluptatem. Sunt perferendis voluptatem eius." },
                    { 48, 5, 0.38008775020953628, "Qui perspiciatis non ratione quia possimus.", false, 1, true, null, "Laboriosam et incidunt autem voluptas et distinctio nihil dolores. Iusto exercitationem sunt quia quisquam commodi et rem officia temporibus. Aut sint est dolore sit quia harum laudantium." },
                    { 10, 4, 0.46450467569031972, "Ipsum laboriosam quo est dolores non autem.", false, 1, true, null, "Minima ducimus molestias ut dolores officiis expedita. Aut ea qui minima dicta harum quos ex enim. Nihil consequatur at dolorem tempora. In quod nobis quam architecto explicabo reiciendis dolorum repudiandae. Impedit id a eius quod rerum quis ut quo eos." },
                    { 7, 4, 0.52893207479684246, "Ipsa velit magnam sed dolorum et odit.", false, 1, true, null, @"Vel debitis labore in rerum pariatur suscipit.
                Debitis assumenda incidunt consequatur voluptatem.
                Aut ut incidunt recusandae dolor est a voluptatibus.
                Necessitatibus voluptatibus ut odit." },
                    { 5, 4, 0.86400530993193636, "Dolores aperiam non cum neque ducimus quod possimus harum sed.", false, 1, true, null, @"Nostrum magni non harum qui voluptas minima nostrum.
                Ex temporibus exercitationem tenetur.
                Sint quia provident quo quo vitae.
                Qui quis inventore sed voluptate.
                Architecto aut doloremque repudiandae voluptas." },
                    { 18, 2, 0.48309389431173627, "Soluta ullam odit voluptate eos hic ratione rem repellat esse.", false, 1, true, null, "Numquam odio et nulla maiores aut rerum. Dolor qui eaque nobis maiores repellendus nam non aliquam. Quia numquam nemo id molestiae. Officiis voluptates enim asperiores tenetur deleniti ut. Ullam accusamus ab ipsum vel illo ut eos. Aut quas sunt et est voluptatem neque." },
                    { 43, 1, 0.16244651617596229, "Aliquam ad sint nobis quis eum corporis.", false, 1, true, null, "assumenda" },
                    { 31, 1, 0.80464841975115631, "Et aut quaerat consequatur ut architecto.", false, 1, true, null, "placeat" },
                    { 25, 1, 0.61344529437527306, "Autem eligendi deleniti.", false, 1, true, null, "Itaque eligendi nihil architecto qui ullam ex ducimus consequatur eos. Fugit quia iste a eligendi. Est quis corrupti provident. Atque perspiciatis voluptatibus aut harum sint et incidunt." },
                    { 12, 2, 0.74653068638710807, "Consectetur ut nihil perferendis vel occaecati consequatur ratione et.", false, 1, true, null, "Cupiditate omnis asperiores. Qui dicta ex nobis atque deleniti corporis. Sequi officiis aliquid libero veniam mollitia vel enim eum maiores. Dolores provident optio possimus earum cupiditate aut veniam incidunt." },
                    { 13, 2, 0.95926893593709406, "Culpa excepturi magnam ipsa distinctio dolores sit nihil enim impedit.", false, 1, true, null, "Molestias ipsum cumque eos quia molestias quia modi sed. Vero dicta facere. Esse neque autem velit architecto. Ut nostrum quo esse. Itaque dolore earum quia. Ab sed omnis quo magnam assumenda qui dolore." },
                    { 17, 2, 0.22273922023490966, "Quae modi eos molestiae deleniti.", false, 1, true, null, "Et qui ut est fuga eveniet a earum." },
                    { 47, 3, 0.63685927895682826, "Quo est ea et.", false, 1, true, null, "Earum nam delectus illo. Non voluptas modi iste perferendis reiciendis sint sed. Eum quas ipsam ab sit ut eligendi ex quia possimus. Occaecati assumenda sint aut omnis tempore commodi veniam maxime id. Nulla laborum omnis aspernatur repudiandae qui dolor rerum aperiam. Quisquam exercitationem voluptas eius ipsa error nulla." },
                    { 19, 2, 0.89316612383963823, "Quod quia eos iste eius.", false, 1, true, null, @"Ut beatae provident est et optio eum nisi.
                Sed id quos fugiat sed quia.
                Harum adipisci aut ex totam ratione possimus aut molestias eligendi.
                Dolor fugiat maxime est odio expedita tempore vitae." },
                    { 20, 2, 0.32006834881383384, "Recusandae sed aut quod est laboriosam aperiam.", false, 1, true, null, "Molestiae ut quibusdam debitis et accusantium molestias nesciunt labore dolorem." },
                    { 40, 1, 0.59860779652307172, "Debitis est dicta ad.", false, 1, true, null, "esse" },
                    { 21, 2, 0.69865364846710754, "Eos numquam a ab excepturi rerum.", false, 1, true, null, "Quo neque sed et quis." },
                    { 32, 2, 0.19290894139227874, "Ut facere error rem dolore sunt dolor labore debitis.", false, 1, true, null, "Repellat omnis blanditiis aut ut qui." },
                    { 36, 2, 0.8793686772134941, "Nulla non voluptas dolor aperiam ut velit omnis.", false, 1, true, null, @"Rem voluptas et.
                Molestiae voluptatibus voluptatem.
                Possimus voluptate et quae et.
                Quam ut rerum dignissimos at.
                Ducimus fugit repudiandae.
                Voluptatem debitis ad hic dolor." },
                    { 15, 1, 0.72477531047760291, "Ut nisi quia dolore aperiam odio sed fuga in.", false, 1, true, null, "Error modi omnis id et doloribus." },
                    { 8, 3, 0.97677748462966529, "Quaerat tempora voluptate voluptates vel eius porro consequatur labore.", false, 1, true, null, "aliquid" },
                    { 23, 3, 0.10803365898692685, "Natus consequatur alias omnis.", false, 1, true, null, @"Deserunt porro hic itaque labore aut blanditiis.
                Ipsa dicta fuga expedita.
                Est omnis consequatur sed iste molestias quia voluptatem aperiam assumenda.
                Delectus repudiandae dignissimos quia magnam rerum maiores ducimus." },
                    { 34, 3, 0.20500046769389904, "Tempore aperiam qui.", false, 1, true, null, "Placeat neque nostrum. Dignissimos alias enim magni et consequatur iusto quae. Quo fugit nisi at commodi sit veritatis nostrum sunt. Et nesciunt animi aspernatur adipisci." },
                    { 42, 3, 0.80307805435875335, "Fugit voluptatem omnis sed illo et nobis totam dolores.", false, 1, true, null, "placeat" },
                    { 46, 3, 0.25539902749257115, "Cumque excepturi ipsa laboriosam repudiandae molestias vitae dolores.", false, 1, true, null, @"Voluptatem totam cupiditate totam tenetur tempore corporis quia.
                Totam voluptatum et voluptatem voluptatibus ullam facilis aspernatur nemo.
                Vitae assumenda delectus omnis asperiores et minus sed.
                Tempora ut recusandae perspiciatis quam.
                Nam dolore et facere et laboriosam a perferendis inventore." },
                    { 11, 1, 0.39156110416704842, "Aliquam quia sed qui earum odit enim dolore expedita aut.", false, 1, true, null, "est" },
                    { 24, 1, 0.69257434210394242, "Aliquam et reprehenderit autem.", false, 1, true, null, @"Qui a commodi nostrum officiis modi et et.
                Laudantium eius aut consequuntur minima natus rerum.
                Aut quia non veniam et.
                Aspernatur dolor unde.
                Rem odit esse quod recusandae dolorum deserunt officia.
                Ea laboriosam sunt." },
                    { 33, 1, 0.68249121386673828, "Repellendus eligendi reiciendis nam dolore incidunt.", false, 1, true, null, "corrupti" }
                });

            migrationBuilder.InsertData(
                table: "KorisnikUloge",
                columns: new[] { "KorisnikId", "UlogaId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 1, 2 },
                    { 4, 2 },
                    { 2, 1 },
                    { 5, 2 },
                    { 1, 1 },
                    { 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "KorisnikClanci",
                columns: new[] { "KorisnikId", "ClanakId", "BrojPosjeta", "Kupljen", "Ocjena" },
                values: new object[,]
                {
                    { 1, 6, 4, false, 2 },
                    { 6, 1, 4, false, 3 },
                    { 5, 1, 3, false, 4 },
                    { 4, 1, 0, false, 3 },
                    { 3, 1, 0, false, 3 },
                    { 2, 1, 3, false, 3 },
                    { 1, 1, 3, false, 1 },
                    { 1, 2, 1, false, 3 },
                    { 6, 50, 1, false, 4 },
                    { 4, 50, 2, false, 0 },
                    { 3, 50, 1, false, 1 },
                    { 2, 50, 0, false, 1 },
                    { 1, 50, 3, false, 3 },
                    { 6, 49, 2, false, 1 },
                    { 5, 49, 3, false, 4 },
                    { 5, 50, 0, false, 2 },
                    { 2, 2, 0, false, 2 },
                    { 3, 2, 4, false, 2 },
                    { 4, 2, 4, false, 2 },
                    { 1, 9, 0, false, 2 },
                    { 6, 4, 0, false, 0 },
                    { 5, 4, 0, false, 4 },
                    { 4, 4, 4, false, 4 },
                    { 3, 4, 4, false, 3 },
                    { 2, 4, 0, false, 3 },
                    { 1, 4, 2, false, 0 },
                    { 6, 3, 4, false, 2 },
                    { 5, 3, 2, false, 4 },
                    { 4, 3, 4, false, 4 },
                    { 3, 3, 4, false, 1 },
                    { 2, 3, 3, false, 1 },
                    { 1, 3, 0, false, 2 },
                    { 6, 2, 0, false, 3 },
                    { 5, 2, 4, false, 0 },
                    { 4, 49, 0, false, 2 },
                    { 3, 49, 2, false, 2 },
                    { 2, 49, 4, false, 4 },
                    { 1, 49, 4, false, 0 },
                    { 5, 16, 4, false, 3 },
                    { 4, 16, 2, false, 1 },
                    { 3, 16, 0, false, 4 },
                    { 2, 16, 2, false, 3 },
                    { 1, 16, 1, false, 1 },
                    { 6, 10, 0, false, 1 },
                    { 5, 10, 3, false, 2 },
                    { 4, 10, 0, false, 2 },
                    { 3, 10, 4, false, 0 },
                    { 2, 10, 4, false, 3 },
                    { 1, 10, 2, false, 2 },
                    { 6, 7, 2, false, 3 },
                    { 5, 7, 0, false, 1 },
                    { 4, 7, 2, false, 0 },
                    { 3, 7, 4, false, 0 },
                    { 6, 16, 3, false, 3 },
                    { 2, 9, 4, false, 4 },
                    { 1, 26, 3, false, 4 },
                    { 3, 26, 4, false, 1 },
                    { 6, 37, 0, false, 2 },
                    { 5, 37, 1, false, 1 },
                    { 4, 37, 1, false, 3 },
                    { 3, 37, 0, false, 0 },
                    { 2, 37, 1, false, 1 },
                    { 1, 37, 2, false, 4 },
                    { 6, 28, 3, false, 4 },
                    { 5, 28, 3, false, 3 },
                    { 4, 28, 2, false, 1 },
                    { 3, 28, 1, false, 4 },
                    { 2, 28, 4, false, 0 },
                    { 1, 28, 4, false, 2 },
                    { 6, 26, 4, false, 0 },
                    { 5, 26, 1, false, 2 },
                    { 4, 26, 4, false, 2 },
                    { 2, 26, 2, false, 3 },
                    { 2, 7, 1, false, 4 },
                    { 3, 9, 3, false, 4 },
                    { 5, 9, 4, false, 2 },
                    { 3, 41, 2, false, 4 },
                    { 2, 41, 4, false, 2 },
                    { 1, 41, 2, false, 2 },
                    { 6, 39, 2, false, 1 },
                    { 5, 39, 2, false, 0 },
                    { 4, 39, 3, false, 0 },
                    { 4, 41, 2, false, 0 },
                    { 3, 39, 3, false, 2 },
                    { 1, 39, 3, false, 4 },
                    { 6, 38, 4, false, 2 },
                    { 5, 38, 0, false, 0 },
                    { 4, 38, 3, false, 0 },
                    { 3, 38, 0, false, 2 },
                    { 2, 38, 3, false, 0 },
                    { 2, 39, 4, false, 0 },
                    { 5, 41, 3, false, 1 },
                    { 6, 41, 1, false, 0 },
                    { 1, 44, 0, false, 4 },
                    { 4, 48, 2, false, 3 },
                    { 3, 48, 3, false, 0 },
                    { 2, 48, 3, false, 3 },
                    { 1, 48, 0, false, 4 },
                    { 6, 45, 1, false, 1 },
                    { 5, 45, 0, false, 0 },
                    { 4, 45, 1, false, 0 },
                    { 3, 45, 3, false, 2 },
                    { 2, 45, 1, false, 0 },
                    { 1, 45, 1, false, 0 },
                    { 6, 44, 0, false, 3 },
                    { 5, 44, 3, false, 4 },
                    { 4, 44, 0, false, 0 },
                    { 3, 44, 0, false, 0 },
                    { 2, 44, 1, false, 2 },
                    { 1, 38, 1, false, 2 },
                    { 6, 35, 0, false, 3 },
                    { 5, 35, 3, false, 1 },
                    { 4, 35, 4, false, 3 },
                    { 2, 27, 3, false, 4 },
                    { 1, 27, 3, false, 3 },
                    { 6, 22, 4, false, 2 },
                    { 5, 22, 3, false, 1 },
                    { 4, 22, 2, false, 0 },
                    { 3, 22, 0, false, 1 },
                    { 2, 22, 1, false, 2 },
                    { 1, 22, 2, false, 2 },
                    { 6, 14, 2, false, 2 },
                    { 5, 14, 3, false, 2 },
                    { 4, 14, 1, false, 2 },
                    { 3, 14, 2, false, 1 },
                    { 2, 14, 4, false, 3 },
                    { 1, 14, 4, false, 2 },
                    { 6, 9, 0, false, 3 },
                    { 3, 27, 2, false, 4 },
                    { 4, 9, 2, false, 4 },
                    { 4, 27, 4, false, 0 },
                    { 6, 27, 0, false, 4 },
                    { 3, 35, 2, false, 1 },
                    { 2, 35, 1, false, 1 },
                    { 1, 35, 3, false, 0 },
                    { 6, 30, 2, false, 0 },
                    { 5, 30, 2, false, 1 },
                    { 4, 30, 2, false, 2 },
                    { 3, 30, 2, false, 1 },
                    { 2, 30, 4, false, 2 },
                    { 1, 30, 0, false, 4 },
                    { 6, 29, 1, false, 3 },
                    { 5, 29, 4, false, 3 },
                    { 4, 29, 4, false, 0 },
                    { 3, 29, 2, false, 4 },
                    { 2, 29, 3, false, 3 },
                    { 1, 29, 4, false, 2 },
                    { 5, 27, 2, false, 0 },
                    { 1, 7, 1, false, 4 },
                    { 6, 5, 1, false, 2 },
                    { 5, 5, 4, false, 3 },
                    { 5, 43, 3, false, 1 },
                    { 4, 43, 0, false, 3 },
                    { 3, 43, 3, false, 3 },
                    { 2, 43, 0, false, 3 },
                    { 1, 43, 4, false, 4 },
                    { 6, 40, 4, false, 1 },
                    { 6, 43, 2, false, 4 },
                    { 5, 40, 0, false, 3 },
                    { 3, 40, 3, false, 0 },
                    { 2, 40, 1, false, 1 },
                    { 1, 40, 4, false, 1 },
                    { 6, 33, 2, false, 3 },
                    { 5, 33, 3, false, 1 },
                    { 4, 33, 1, false, 1 },
                    { 4, 40, 0, false, 4 },
                    { 1, 12, 4, false, 0 },
                    { 2, 12, 0, false, 4 },
                    { 3, 12, 2, false, 1 },
                    { 6, 17, 1, false, 3 },
                    { 5, 17, 3, false, 3 },
                    { 4, 17, 1, false, 1 },
                    { 3, 17, 1, false, 3 },
                    { 2, 17, 1, false, 0 },
                    { 1, 17, 0, false, 2 },
                    { 6, 13, 0, false, 0 },
                    { 5, 13, 1, false, 1 },
                    { 4, 13, 1, false, 1 },
                    { 3, 13, 4, false, 4 },
                    { 2, 13, 1, false, 1 },
                    { 1, 13, 1, false, 2 },
                    { 6, 12, 2, false, 1 },
                    { 5, 12, 3, false, 4 },
                    { 4, 12, 2, false, 0 },
                    { 3, 33, 4, false, 4 },
                    { 2, 33, 3, false, 0 },
                    { 1, 33, 3, false, 3 },
                    { 6, 31, 4, false, 4 },
                    { 4, 15, 1, false, 2 },
                    { 3, 15, 3, false, 3 },
                    { 2, 15, 3, false, 0 },
                    { 1, 15, 3, false, 4 },
                    { 6, 11, 2, false, 0 },
                    { 5, 11, 4, false, 3 },
                    { 4, 11, 3, false, 3 },
                    { 3, 11, 3, false, 0 },
                    { 2, 11, 3, false, 3 },
                    { 1, 11, 3, false, 1 },
                    { 6, 6, 4, false, 2 },
                    { 5, 6, 2, false, 1 },
                    { 4, 6, 4, false, 4 },
                    { 3, 6, 3, false, 3 },
                    { 2, 6, 1, false, 0 },
                    { 5, 15, 2, false, 0 },
                    { 1, 18, 4, false, 4 },
                    { 6, 15, 0, false, 0 },
                    { 2, 24, 1, false, 3 },
                    { 5, 31, 3, false, 3 },
                    { 4, 31, 0, false, 3 },
                    { 3, 31, 3, false, 1 },
                    { 2, 31, 4, false, 0 },
                    { 1, 31, 0, false, 3 },
                    { 6, 25, 3, false, 1 },
                    { 5, 25, 3, false, 3 },
                    { 4, 25, 0, false, 3 },
                    { 3, 25, 2, false, 1 },
                    { 2, 25, 0, false, 1 },
                    { 1, 25, 4, false, 1 },
                    { 6, 24, 3, false, 2 },
                    { 5, 24, 1, false, 4 },
                    { 4, 24, 1, false, 3 },
                    { 3, 24, 4, false, 2 },
                    { 1, 24, 1, false, 3 },
                    { 2, 18, 1, false, 1 },
                    { 3, 18, 3, false, 1 },
                    { 4, 18, 1, false, 2 },
                    { 3, 42, 1, false, 4 },
                    { 2, 42, 3, false, 3 },
                    { 1, 42, 4, false, 4 },
                    { 6, 34, 0, false, 1 },
                    { 5, 34, 3, false, 4 },
                    { 4, 34, 3, false, 1 },
                    { 3, 34, 2, false, 1 },
                    { 2, 34, 0, false, 2 },
                    { 1, 34, 3, false, 2 },
                    { 6, 23, 4, false, 2 },
                    { 5, 23, 2, false, 3 },
                    { 4, 23, 4, false, 4 },
                    { 3, 23, 1, false, 1 },
                    { 2, 23, 4, false, 1 },
                    { 1, 23, 1, false, 2 },
                    { 4, 42, 3, false, 0 },
                    { 6, 8, 2, false, 1 },
                    { 5, 42, 3, false, 0 },
                    { 1, 46, 2, false, 2 },
                    { 4, 5, 3, false, 1 },
                    { 3, 5, 3, false, 0 },
                    { 2, 5, 1, false, 2 },
                    { 1, 5, 2, false, 0 },
                    { 6, 47, 1, false, 1 },
                    { 5, 47, 2, false, 0 },
                    { 4, 47, 2, false, 3 },
                    { 3, 47, 3, false, 2 },
                    { 2, 47, 3, false, 1 },
                    { 1, 47, 1, false, 0 },
                    { 6, 46, 1, false, 0 },
                    { 5, 46, 1, false, 2 },
                    { 4, 46, 0, false, 2 },
                    { 3, 46, 4, false, 2 },
                    { 2, 46, 0, false, 3 },
                    { 6, 42, 0, false, 2 },
                    { 5, 48, 1, false, 3 },
                    { 5, 8, 2, false, 1 },
                    { 3, 8, 0, false, 2 },
                    { 1, 21, 1, false, 4 },
                    { 6, 20, 2, false, 0 },
                    { 5, 20, 3, false, 2 },
                    { 4, 20, 0, false, 2 },
                    { 3, 20, 2, false, 2 },
                    { 2, 20, 4, false, 2 },
                    { 1, 20, 0, false, 4 },
                    { 6, 19, 4, false, 4 },
                    { 5, 19, 4, false, 3 },
                    { 4, 19, 1, false, 3 },
                    { 3, 19, 3, false, 4 },
                    { 2, 19, 0, false, 2 },
                    { 1, 19, 2, false, 1 },
                    { 6, 18, 0, false, 4 },
                    { 5, 18, 0, false, 3 },
                    { 2, 21, 1, false, 1 },
                    { 4, 8, 1, false, 2 },
                    { 3, 21, 0, false, 4 },
                    { 5, 21, 1, false, 0 },
                    { 2, 8, 4, false, 1 },
                    { 1, 8, 3, false, 0 },
                    { 6, 36, 1, false, 0 },
                    { 5, 36, 1, false, 1 },
                    { 4, 36, 4, false, 2 },
                    { 3, 36, 0, false, 1 },
                    { 2, 36, 2, false, 2 },
                    { 1, 36, 1, false, 2 },
                    { 6, 32, 3, false, 1 },
                    { 5, 32, 4, false, 0 },
                    { 4, 32, 2, false, 4 },
                    { 3, 32, 4, false, 3 },
                    { 2, 32, 1, false, 1 },
                    { 1, 32, 0, false, 4 },
                    { 6, 21, 1, false, 3 },
                    { 4, 21, 1, false, 0 },
                    { 6, 48, 3, false, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClanakKategorije_KategorijaId",
                table: "ClanakKategorije",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanci_AutorId",
                table: "Clanci",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanci_OdobravateljId",
                table: "Clanci",
                column: "OdobravateljId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_DrzavaId",
                table: "Korisnici",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikClanci_ClanakId",
                table: "KorisnikClanci",
                column: "ClanakId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikKategorije_KategorijaId",
                table: "KorisnikKategorije",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikPrijave_ClanakId",
                table: "KorisnikPrijave",
                column: "ClanakId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikPrijave_KorisnikId",
                table: "KorisnikPrijave",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloge_UlogaId",
                table: "KorisnikUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_ClanakId",
                table: "Likes",
                column: "ClanakId");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_KorisnikId",
                table: "Uplate",
                column: "KorisnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClanakKategorije");

            migrationBuilder.DropTable(
                name: "KorisnikClanci");

            migrationBuilder.DropTable(
                name: "KorisnikKategorije");

            migrationBuilder.DropTable(
                name: "KorisnikPrijave");

            migrationBuilder.DropTable(
                name: "KorisnikUloge");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Uplate");

            migrationBuilder.DropTable(
                name: "Kategorije");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Clanci");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
