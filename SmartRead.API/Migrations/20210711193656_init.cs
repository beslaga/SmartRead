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
                    { 1, new DateTime(2021, 7, 11, 21, 36, 55, 992, DateTimeKind.Local).AddTicks(2149), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Maid", 0.0, "maid.beslagic@edu.fit.ba", false, "3jS1cgro+Oyfz3RMeB5Kv8fM1QjxXtIWbQGjJv/LRL2dXBgw5BgxoSEzsHH4F91XkySuk0ygjvZ4JGxTKdtSrA==", "JroOw5CyefsJpFEja+4WeQ==", "Bešlagić", null, "maid" },
                    { 2, new DateTime(2021, 7, 11, 21, 36, 55, 998, DateTimeKind.Local).AddTicks(7978), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Desktop", 0.0, "desktop@edu.fit.ba", false, "3jS1cgro+Oyfz3RMeB5Kv8fM1QjxXtIWbQGjJv/LRL2dXBgw5BgxoSEzsHH4F91XkySuk0ygjvZ4JGxTKdtSrA==", "JroOw5CyefsJpFEja+4WeQ==", "Admin", null, "desktop" },
                    { 3, new DateTime(2021, 7, 11, 21, 36, 55, 998, DateTimeKind.Local).AddTicks(8504), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobile", 0.0, "mobile@edu.fit.ba", false, "3jS1cgro+Oyfz3RMeB5Kv8fM1QjxXtIWbQGjJv/LRL2dXBgw5BgxoSEzsHH4F91XkySuk0ygjvZ4JGxTKdtSrA==", "JroOw5CyefsJpFEja+4WeQ==", "User", null, "mobile" },
                    { 4, new DateTime(2021, 7, 11, 21, 36, 55, 998, DateTimeKind.Local).AddTicks(8564), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobile", 0.0, "mobile1@edu.fit.ba", false, "3jS1cgro+Oyfz3RMeB5Kv8fM1QjxXtIWbQGjJv/LRL2dXBgw5BgxoSEzsHH4F91XkySuk0ygjvZ4JGxTKdtSrA==", "JroOw5CyefsJpFEja+4WeQ==", "User", null, "mobile1" },
                    { 5, new DateTime(2021, 7, 11, 21, 36, 55, 998, DateTimeKind.Local).AddTicks(8605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobile", 0.0, "mobile2@edu.fit.ba", false, "3jS1cgro+Oyfz3RMeB5Kv8fM1QjxXtIWbQGjJv/LRL2dXBgw5BgxoSEzsHH4F91XkySuk0ygjvZ4JGxTKdtSrA==", "JroOw5CyefsJpFEja+4WeQ==", "User", null, "mobile2" },
                    { 6, new DateTime(2021, 7, 11, 21, 36, 55, 998, DateTimeKind.Local).AddTicks(8643), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobile", 0.0, "mobile3@edu.fit.ba", false, "3jS1cgro+Oyfz3RMeB5Kv8fM1QjxXtIWbQGjJv/LRL2dXBgw5BgxoSEzsHH4F91XkySuk0ygjvZ4JGxTKdtSrA==", "JroOw5CyefsJpFEja+4WeQ==", "User", null, "mobile3" }
                });

            migrationBuilder.InsertData(
                table: "Clanci",
                columns: new[] { "Id", "AutorId", "Cijena", "Naslov", "Obrisan", "OdobravateljId", "Odobren", "Slika", "Text" },
                values: new object[,]
                {
                    { 2, 1, 0.0, "Dolores accusantium et et dolorum soluta voluptatibus doloribus.", false, 1, true, null, "Quis necessitatibus officia explicabo." },
                    { 24, 3, 0.0, "Sint possimus non et.", false, 1, true, null, "Alias enim aut. Iure harum et. Deleniti autem aperiam." },
                    { 29, 3, 0.0, "Recusandae illo aut dolorum ut quod quia omnis dolore.", false, 1, true, null, "Sed ut quos." },
                    { 35, 3, 0.0, "Id aperiam nobis.", false, 1, true, null, @"Exercitationem at animi eius distinctio natus.
                Ab ipsa repellendus et numquam alias rerum est libero ad.
                Iure fugit ut et fugit quis iure libero et ipsam.
                Adipisci consequuntur ex." },
                    { 41, 3, 0.0, "Ipsam assumenda explicabo nulla sint cumque dolor.", false, 1, true, null, "Delectus rerum esse non odit consequatur sit expedita. Nihil excepturi consequatur ratione accusantium fugiat quisquam. Dolore consequatur corrupti tempore ullam ut iure ullam ad quo." },
                    { 44, 3, 0.0, "Ipsam doloribus et est odio.", false, 1, true, null, "asperiores" },
                    { 14, 4, 0.0, "Quaerat adipisci voluptas velit.", false, 1, true, null, "quisquam" },
                    { 15, 4, 0.0, "Consequatur placeat placeat recusandae et ratione vel et.", false, 1, true, null, "Sint et consequatur hic. Consequuntur est ea quaerat sapiente libero nobis. Porro rerum id adipisci. Quod aut blanditiis." },
                    { 19, 4, 0.0, "Minus ab tempore illum iure tenetur sit explicabo vel aspernatur.", false, 1, true, null, @"Incidunt maxime ullam.
                Omnis beatae perferendis dolorem.
                Atque eum consequatur quisquam voluptatem et nam veniam ut aut.
                Ut rerum maxime numquam.
                Voluptatem autem nihil aliquid velit quia qui." },
                    { 20, 4, 0.0, "Ipsa numquam nihil voluptate sint.", false, 1, true, null, "Assumenda est error quis aut libero et. Molestiae aspernatur velit porro excepturi vel. Repellat vitae tempore ea nihil deserunt illum. Enim et quas cum recusandae numquam quaerat commodi aut. Soluta totam accusamus sit." },
                    { 30, 4, 0.0, "Et neque nesciunt sint.", false, 1, true, null, @"Ut id minus impedit repellat voluptatem voluptatem nesciunt porro.
                Eveniet facilis esse soluta.
                Quis ut odio dolore accusantium vel saepe aut.
                Non pariatur fuga officia ex est corrupti.
                Dolor dolores sint ad rerum." },
                    { 31, 4, 0.0, "Maxime necessitatibus excepturi dicta qui sint eius aliquam.", false, 1, true, null, "praesentium" },
                    { 34, 4, 0.0, "Sed quasi consequuntur deleniti quae pariatur.", false, 1, true, null, @"Ad quia est incidunt vel debitis sunt.
                Aut optio amet aut neque.
                Perferendis molestias laborum minus ipsum maiores et expedita." },
                    { 38, 4, 0.0, "Et rerum eum quisquam nisi rerum explicabo quidem.", false, 1, true, null, "eos" },
                    { 40, 4, 0.0, "Eum vero consequatur magnam saepe sed ullam dicta.", false, 1, true, null, "autem" },
                    { 43, 4, 0.0, "Nulla praesentium inventore autem.", false, 1, true, null, "voluptas" },
                    { 48, 4, 0.0, "Et voluptas corporis rerum voluptatem occaecati ut quibusdam.", false, 1, true, null, "a" },
                    { 49, 4, 0.0, "Dolorum et dolorum est iste ipsa.", false, 1, true, null, "Quia quaerat non repellendus eum consequuntur quis rerum aut culpa." },
                    { 50, 4, 0.0, "Libero dolores voluptatem ipsa fugiat dolorem ea consequatur.", false, 1, true, null, "omnis" },
                    { 3, 5, 0.0, "Nam magnam quia ullam quia quis libero qui excepturi.", false, 1, true, null, "Aut dolorem perferendis eum eaque enim et ut nihil totam." },
                    { 9, 5, 0.0, "Eos natus magnam assumenda itaque accusamus quos quo.", false, 1, true, null, "molestiae" },
                    { 21, 5, 0.0, "Dolores deleniti sunt perferendis et aut reiciendis perferendis autem incidunt.", false, 1, true, null, @"Dolore iure tenetur ut hic.
                Aliquam harum quas.
                Accusamus adipisci ipsum minus dicta similique eum nisi quisquam illum.
                Dolor et dolores culpa.
                Expedita sit rerum quo ducimus nemo molestias recusandae sed est." },
                    { 39, 5, 0.0, "Reprehenderit beatae ipsa esse est eius et quia ex aspernatur.", false, 1, true, null, @"Et fugiat quia fugiat vero odio enim.
                Iure dolorem ratione.
                Voluptatum dolores voluptatem voluptas est.
                Consequatur vero est qui dolores qui molestiae repellendus possimus.
                Qui ut et ipsa recusandae.
                Voluptatum molestias fuga quaerat omnis." },
                    { 47, 5, 0.0, "Eum quaerat itaque porro aspernatur magnam ut quia non aliquam.", false, 1, true, null, "Rerum voluptatibus necessitatibus alias voluptatem. Optio optio voluptatem asperiores tempore minima porro sint. Consequatur voluptates nemo vel suscipit ea voluptatem itaque. Sunt ea est beatae consequatur nihil hic voluptas exercitationem ut. Quibusdam culpa vitae dolor odio. Corporis similique ut voluptatem odio eum." },
                    { 23, 3, 0.0, "Ipsum et laudantium illum reprehenderit inventore aliquid et doloribus temporibus.", false, 1, true, null, @"Ut laborum commodi autem quia eum et necessitatibus.
                Amet molestiae et omnis eos quis odio velit facere.
                Ea et voluptas ab quaerat autem ipsam.
                Quas alias nemo sed hic qui." },
                    { 12, 3, 0.0, "Iure dolore nostrum.", false, 1, true, null, "enim" },
                    { 22, 3, 0.0, "Impedit sint vero molestiae.", false, 1, true, null, "Quos cumque illum facere consequatur necessitatibus dignissimos sapiente rerum et." },
                    { 6, 3, 0.0, "Iusto molestias molestias voluptatem rem amet accusantium quibusdam neque quia.", false, 1, true, null, @"Iure et nostrum fuga repudiandae nemo adipisci incidunt animi rerum.
                Nesciunt aut animi quia voluptas et culpa est et nam.
                Recusandae distinctio dolor dolorem." },
                    { 26, 1, 0.0, "Consequatur aperiam illum molestias corporis in in nisi quos et.", false, 1, true, null, "Et eligendi enim nam necessitatibus est labore voluptates. Vero quae dolores adipisci animi doloremque quibusdam ut inventore sint. Possimus placeat est vitae quae quibusdam nihil est amet. Mollitia et distinctio. A quia consequuntur. Sed et deserunt perferendis." },
                    { 33, 1, 0.0, "Nihil qui mollitia adipisci quo.", false, 1, true, null, "Ad animi repellendus temporibus exercitationem maxime rem vero." },
                    { 36, 1, 0.0, "Ut consequatur voluptas officia aut et sed inventore praesentium similique.", false, 1, true, null, "Eos sit ut recusandae omnis qui dolores rem quam. Id tempora fugiat asperiores earum rerum quae nulla distinctio. Incidunt aspernatur fugiat non vitae reprehenderit blanditiis. Illo excepturi et dolorem odit." },
                    { 37, 1, 0.0, "Aut animi beatae quasi iusto qui modi.", false, 1, true, null, @"Aut commodi ab molestias quia quam velit est quis quo.
                Voluptas sit corporis at consequatur ad et.
                Et repellat similique sed numquam amet.
                Natus aut velit voluptatem voluptas." },
                    { 45, 1, 0.0, "Magnam quia ut adipisci et error consequuntur.", false, 1, true, null, "Minus eum fugiat voluptates aut blanditiis. Ratione nam ut rem eaque quia voluptas ut veniam quo. Dolor possimus exercitationem non impedit maxime voluptates dolor adipisci delectus." },
                    { 17, 1, 0.0, "Ut consequatur nemo nobis sed omnis cumque.", false, 1, true, null, "Laboriosam veritatis culpa eius id ut amet dolores sunt." },
                    { 8, 3, 0.0, "Rerum laborum accusantium temporibus.", false, 1, true, null, @"Accusamus iste doloribus libero qui qui doloremque minus ut.
                Omnis sit dolore error harum voluptas dicta et inventore doloribus.
                Earum est nostrum assumenda eius beatae aut illum iste.
                Aut sapiente nemo et aut temporibus nesciunt et ipsam non.
                Nesciunt ad sunt." },
                    { 1, 2, 0.0, "Aperiam quo exercitationem aut esse iure quibusdam ad explicabo.", false, 1, true, null, "repellendus" },
                    { 7, 2, 0.0, "Eos labore dolor cumque modi accusamus.", false, 1, true, null, "eum" },
                    { 25, 1, 0.0, "Sequi architecto rem error odit repellat aut quis ea rerum.", false, 1, true, null, @"Quis harum dolorum provident repudiandae magni.
                Quas commodi et qui dolorem modi doloribus nobis sed odio.
                Sint dolorem ut maiores inventore quae consectetur.
                Et aperiam est soluta fugit omnis.
                Iste aspernatur repellat ullam provident similique distinctio quia voluptatum autem.
                Sit qui aut aut sed fugiat." },
                    { 10, 2, 0.0, "Cumque eveniet consequatur quod ratione repudiandae maiores perferendis eveniet.", false, 1, true, null, "Et provident illo non sed quod dolor est dolor qui." },
                    { 16, 2, 0.0, "Sit est ipsam rerum enim ab doloribus necessitatibus officia et.", false, 1, true, null, "ut" },
                    { 13, 1, 0.0, "Quaerat et sunt.", false, 1, true, null, "dolores" },
                    { 27, 2, 0.0, "Dolor est perferendis odit reiciendis perspiciatis.", false, 1, true, null, @"Sapiente sapiente molestiae.
                Ut consectetur dolorum explicabo voluptatem sint quisquam debitis quaerat.
                Fugiat dicta rerum nihil tempore quia itaque corrupti voluptatem.
                Suscipit perspiciatis nemo aperiam est ducimus dolor rerum.
                Officia minima cumque.
                Quia ex recusandae mollitia." },
                    { 28, 2, 0.0, "Dolorem beatae nostrum.", false, 1, true, null, @"Sit voluptatem suscipit voluptas debitis et quasi voluptatum optio dolor.
                Nihil aut officia ea illum suscipit.
                Possimus tempore cupiditate.
                Ut iusto ut id.
                Voluptates voluptatem sit blanditiis aut fuga laboriosam pariatur.
                Aut laboriosam voluptas quos sint aut alias alias." },
                    { 32, 2, 0.0, "Officiis amet architecto voluptatum.", false, 1, true, null, @"Recusandae sit et voluptatem optio cum aut quasi.
                Dolorum totam veniam neque dignissimos in voluptas optio.
                Sint exercitationem dolorem rerum suscipit.
                Omnis neque in deleniti praesentium velit aut deserunt quo accusamus." },
                    { 42, 2, 0.0, "Sapiente consequatur dignissimos aliquid nihil reiciendis.", false, 1, true, null, "Eaque temporibus facere fugit molestiae provident sunt. Enim dolorum et. Autem vel non. Culpa aut libero. Accusantium repudiandae fugiat non minus optio cumque. Neque ullam dolorem neque eos." },
                    { 46, 2, 0.0, "Error quisquam quas fugiat asperiores excepturi.", false, 1, true, null, "Voluptatibus velit et nostrum quas accusantium. Non sint sed. Voluptatem pariatur sed omnis totam. Sed quia sunt." },
                    { 5, 1, 0.0, "Ea voluptatem ut praesentium nulla labore quo quis eum rerum.", false, 1, true, null, @"Quia animi in odio dolorem recusandae ullam in dolorem.
                Earum qui eveniet.
                Aperiam assumenda fuga.
                Labore earum explicabo maxime." },
                    { 4, 1, 0.0, "Reprehenderit culpa totam.", false, 1, true, null, @"Quibusdam omnis voluptate occaecati quia.
                Dolores voluptatem est est laudantium reprehenderit laudantium.
                Minus error quidem quibusdam nesciunt reiciendis odit velit.
                Delectus ex reprehenderit enim natus vero quod eum facilis quos.
                Mollitia sapiente itaque praesentium natus numquam." },
                    { 11, 2, 0.0, "Quasi beatae sint et.", false, 1, true, null, "et" },
                    { 18, 1, 0.0, "Assumenda laborum sed possimus quidem accusamus.", false, 1, true, null, "Quis autem labore ut qui. Quis quibusdam rerum voluptatem. Voluptas facere dignissimos in enim magnam inventore. Ducimus ducimus nihil. Laboriosam id in." }
                });

            migrationBuilder.InsertData(
                table: "KorisnikUloge",
                columns: new[] { "KorisnikId", "UlogaId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 1 },
                    { 3, 2 },
                    { 2, 1 },
                    { 5, 2 },
                    { 4, 2 },
                    { 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "KorisnikClanci",
                columns: new[] { "KorisnikId", "ClanakId", "BrojPosjeta", "Kupljen", "Ocjena" },
                values: new object[,]
                {
                    { 1, 2, 3, false, 4 },
                    { 6, 15, 0, false, 1 },
                    { 5, 15, 0, false, 4 },
                    { 4, 15, 0, false, 1 },
                    { 3, 15, 1, false, 2 },
                    { 2, 15, 3, false, 1 },
                    { 1, 15, 3, false, 3 },
                    { 1, 19, 1, false, 0 },
                    { 6, 14, 2, false, 1 },
                    { 4, 14, 0, false, 3 },
                    { 3, 14, 0, false, 0 },
                    { 2, 14, 1, false, 1 },
                    { 1, 14, 0, false, 3 },
                    { 6, 44, 4, false, 1 },
                    { 5, 44, 0, false, 3 },
                    { 5, 14, 1, false, 0 },
                    { 2, 19, 0, false, 4 },
                    { 3, 19, 1, false, 2 },
                    { 4, 19, 4, false, 3 },
                    { 1, 31, 0, false, 1 },
                    { 6, 30, 2, false, 0 },
                    { 5, 30, 3, false, 4 },
                    { 4, 30, 0, false, 3 },
                    { 3, 30, 2, false, 3 },
                    { 2, 30, 3, false, 1 },
                    { 1, 30, 4, false, 0 },
                    { 6, 20, 4, false, 4 },
                    { 5, 20, 4, false, 2 },
                    { 4, 20, 4, false, 0 },
                    { 3, 20, 3, false, 1 },
                    { 2, 20, 4, false, 2 },
                    { 1, 20, 4, false, 2 },
                    { 6, 19, 3, false, 3 },
                    { 5, 19, 3, false, 2 },
                    { 4, 44, 4, false, 4 },
                    { 3, 44, 1, false, 4 },
                    { 2, 44, 0, false, 0 },
                    { 1, 44, 2, false, 0 },
                    { 5, 24, 1, false, 4 },
                    { 4, 24, 2, false, 0 },
                    { 3, 24, 4, false, 0 },
                    { 2, 24, 3, false, 2 },
                    { 1, 24, 4, false, 4 },
                    { 6, 23, 1, false, 4 },
                    { 5, 23, 4, false, 0 },
                    { 4, 23, 1, false, 2 },
                    { 3, 23, 3, false, 4 },
                    { 2, 23, 3, false, 3 },
                    { 1, 23, 1, false, 4 },
                    { 6, 22, 3, false, 2 },
                    { 5, 22, 1, false, 2 },
                    { 4, 22, 4, false, 3 },
                    { 3, 22, 1, false, 2 },
                    { 6, 24, 1, false, 3 },
                    { 2, 31, 4, false, 3 },
                    { 1, 29, 2, false, 3 },
                    { 3, 29, 0, false, 2 },
                    { 6, 41, 4, false, 4 },
                    { 5, 41, 1, false, 4 },
                    { 4, 41, 0, false, 3 },
                    { 3, 41, 4, false, 2 },
                    { 2, 41, 1, false, 1 },
                    { 1, 41, 0, false, 2 },
                    { 6, 35, 0, false, 0 },
                    { 5, 35, 2, false, 3 },
                    { 4, 35, 1, false, 2 },
                    { 3, 35, 2, false, 3 },
                    { 2, 35, 1, false, 2 },
                    { 1, 35, 3, false, 1 },
                    { 6, 29, 1, false, 0 },
                    { 5, 29, 4, false, 1 },
                    { 4, 29, 1, false, 4 },
                    { 2, 29, 2, false, 3 },
                    { 2, 22, 4, false, 1 },
                    { 3, 31, 0, false, 3 },
                    { 5, 31, 0, false, 1 },
                    { 3, 9, 0, false, 0 },
                    { 2, 9, 0, false, 1 },
                    { 1, 9, 2, false, 1 },
                    { 6, 3, 3, false, 2 },
                    { 5, 3, 2, false, 2 },
                    { 4, 3, 4, false, 1 },
                    { 4, 9, 2, false, 0 },
                    { 3, 3, 1, false, 2 },
                    { 1, 3, 4, false, 1 },
                    { 6, 50, 1, false, 4 },
                    { 5, 50, 0, false, 2 },
                    { 4, 50, 1, false, 4 },
                    { 3, 50, 1, false, 1 },
                    { 2, 50, 4, false, 1 },
                    { 2, 3, 2, false, 3 },
                    { 5, 9, 4, false, 2 },
                    { 6, 9, 4, false, 4 },
                    { 1, 21, 2, false, 1 },
                    { 4, 47, 2, false, 1 },
                    { 3, 47, 3, false, 0 },
                    { 2, 47, 1, false, 4 },
                    { 1, 47, 3, false, 1 },
                    { 6, 39, 4, false, 1 },
                    { 5, 39, 4, false, 3 },
                    { 4, 39, 3, false, 1 },
                    { 3, 39, 4, false, 4 },
                    { 2, 39, 1, false, 2 },
                    { 1, 39, 2, false, 0 },
                    { 6, 21, 4, false, 3 },
                    { 5, 21, 3, false, 3 },
                    { 4, 21, 1, false, 1 },
                    { 3, 21, 3, false, 4 },
                    { 2, 21, 1, false, 3 },
                    { 1, 50, 2, false, 1 },
                    { 6, 49, 4, false, 1 },
                    { 5, 49, 0, false, 2 },
                    { 4, 49, 0, false, 0 },
                    { 2, 40, 4, false, 1 },
                    { 1, 40, 0, false, 2 },
                    { 6, 38, 1, false, 1 },
                    { 5, 38, 4, false, 1 },
                    { 4, 38, 3, false, 1 },
                    { 3, 38, 3, false, 2 },
                    { 2, 38, 2, false, 4 },
                    { 1, 38, 4, false, 2 },
                    { 6, 34, 2, false, 1 },
                    { 5, 34, 2, false, 3 },
                    { 4, 34, 3, false, 2 },
                    { 3, 34, 3, false, 2 },
                    { 2, 34, 2, false, 4 },
                    { 1, 34, 0, false, 2 },
                    { 6, 31, 1, false, 3 },
                    { 3, 40, 0, false, 3 },
                    { 4, 31, 0, false, 2 },
                    { 4, 40, 3, false, 0 },
                    { 6, 40, 1, false, 0 },
                    { 3, 49, 1, false, 3 },
                    { 2, 49, 4, false, 3 },
                    { 1, 49, 2, false, 2 },
                    { 6, 48, 2, false, 0 },
                    { 5, 48, 0, false, 1 },
                    { 4, 48, 4, false, 0 },
                    { 3, 48, 1, false, 4 },
                    { 2, 48, 1, false, 0 },
                    { 1, 48, 2, false, 3 },
                    { 6, 43, 0, false, 4 },
                    { 5, 43, 2, false, 0 },
                    { 4, 43, 3, false, 1 },
                    { 3, 43, 1, false, 4 },
                    { 2, 43, 4, false, 0 },
                    { 1, 43, 1, false, 0 },
                    { 5, 40, 1, false, 3 },
                    { 1, 22, 4, false, 3 },
                    { 6, 12, 1, false, 2 },
                    { 5, 12, 4, false, 3 },
                    { 5, 33, 4, false, 1 },
                    { 4, 33, 0, false, 1 },
                    { 3, 33, 1, false, 2 },
                    { 2, 33, 1, false, 3 },
                    { 1, 33, 1, false, 3 },
                    { 6, 26, 0, false, 0 },
                    { 6, 33, 1, false, 2 },
                    { 5, 26, 0, false, 4 },
                    { 3, 26, 0, false, 0 },
                    { 2, 26, 1, false, 3 },
                    { 1, 26, 3, false, 1 },
                    { 6, 25, 0, false, 3 },
                    { 5, 25, 0, false, 3 },
                    { 4, 25, 1, false, 3 },
                    { 4, 26, 2, false, 3 },
                    { 1, 36, 1, false, 1 },
                    { 2, 36, 4, false, 1 },
                    { 3, 36, 3, false, 3 },
                    { 6, 45, 3, false, 2 },
                    { 5, 45, 4, false, 0 },
                    { 4, 45, 2, false, 4 },
                    { 3, 45, 4, false, 0 },
                    { 2, 45, 0, false, 4 },
                    { 1, 45, 1, false, 2 },
                    { 6, 37, 3, false, 4 },
                    { 5, 37, 0, false, 3 },
                    { 4, 37, 1, false, 1 },
                    { 3, 37, 1, false, 4 },
                    { 2, 37, 1, false, 3 },
                    { 1, 37, 1, false, 4 },
                    { 6, 36, 0, false, 2 },
                    { 5, 36, 1, false, 4 },
                    { 4, 36, 3, false, 0 },
                    { 3, 25, 2, false, 4 },
                    { 2, 25, 2, false, 0 },
                    { 1, 25, 0, false, 1 },
                    { 6, 18, 1, false, 1 },
                    { 4, 5, 2, false, 1 },
                    { 3, 5, 1, false, 0 },
                    { 2, 5, 3, false, 2 },
                    { 1, 5, 4, false, 4 },
                    { 6, 4, 1, false, 2 },
                    { 5, 4, 3, false, 2 },
                    { 4, 4, 3, false, 4 },
                    { 3, 4, 2, false, 2 },
                    { 2, 4, 3, false, 2 },
                    { 1, 4, 3, false, 0 },
                    { 6, 2, 0, false, 3 },
                    { 5, 2, 0, false, 0 },
                    { 4, 2, 0, false, 1 },
                    { 3, 2, 1, false, 1 },
                    { 2, 2, 1, false, 4 },
                    { 5, 5, 2, false, 0 },
                    { 1, 1, 3, false, 4 },
                    { 6, 5, 1, false, 0 },
                    { 2, 13, 0, false, 1 },
                    { 5, 18, 1, false, 4 },
                    { 4, 18, 3, false, 4 },
                    { 3, 18, 0, false, 1 },
                    { 2, 18, 2, false, 0 },
                    { 1, 18, 2, false, 0 },
                    { 6, 17, 2, false, 3 },
                    { 5, 17, 0, false, 2 },
                    { 4, 17, 4, false, 2 },
                    { 3, 17, 0, false, 1 },
                    { 2, 17, 1, false, 2 },
                    { 1, 17, 2, false, 1 },
                    { 6, 13, 4, false, 0 },
                    { 5, 13, 3, false, 2 },
                    { 4, 13, 4, false, 4 },
                    { 3, 13, 4, false, 2 },
                    { 1, 13, 4, false, 0 },
                    { 2, 1, 0, false, 3 },
                    { 3, 1, 3, false, 2 },
                    { 4, 1, 1, false, 1 },
                    { 3, 46, 4, false, 1 },
                    { 2, 46, 0, false, 0 },
                    { 1, 46, 1, false, 4 },
                    { 6, 42, 2, false, 4 },
                    { 5, 42, 1, false, 4 },
                    { 4, 42, 3, false, 4 },
                    { 3, 42, 3, false, 0 },
                    { 2, 42, 0, false, 4 },
                    { 1, 42, 1, false, 2 },
                    { 6, 32, 3, false, 0 },
                    { 5, 32, 1, false, 1 },
                    { 4, 32, 0, false, 2 },
                    { 3, 32, 0, false, 0 },
                    { 2, 32, 3, false, 2 },
                    { 1, 32, 3, false, 4 },
                    { 4, 46, 0, false, 4 },
                    { 6, 28, 2, false, 0 },
                    { 5, 46, 0, false, 4 },
                    { 1, 6, 3, false, 2 },
                    { 4, 12, 4, false, 3 },
                    { 3, 12, 4, false, 0 },
                    { 2, 12, 4, false, 0 },
                    { 1, 12, 2, false, 1 },
                    { 6, 8, 2, false, 3 },
                    { 5, 8, 2, false, 1 },
                    { 4, 8, 3, false, 1 },
                    { 3, 8, 4, false, 0 },
                    { 2, 8, 3, false, 0 },
                    { 1, 8, 2, false, 0 },
                    { 6, 6, 4, false, 4 },
                    { 5, 6, 4, false, 2 },
                    { 4, 6, 0, false, 4 },
                    { 3, 6, 2, false, 0 },
                    { 2, 6, 3, false, 0 },
                    { 6, 46, 0, false, 1 },
                    { 5, 47, 0, false, 1 },
                    { 5, 28, 2, false, 3 },
                    { 3, 28, 2, false, 1 },
                    { 1, 11, 0, false, 3 },
                    { 6, 10, 1, false, 1 },
                    { 5, 10, 3, false, 2 },
                    { 4, 10, 1, false, 4 },
                    { 3, 10, 0, false, 4 },
                    { 2, 10, 4, false, 2 },
                    { 1, 10, 1, false, 4 },
                    { 6, 7, 2, false, 0 },
                    { 5, 7, 2, false, 3 },
                    { 4, 7, 4, false, 1 },
                    { 3, 7, 0, false, 4 },
                    { 2, 7, 2, false, 0 },
                    { 1, 7, 1, false, 1 },
                    { 6, 1, 4, false, 3 },
                    { 5, 1, 3, false, 3 },
                    { 2, 11, 4, false, 2 },
                    { 4, 28, 2, false, 0 },
                    { 3, 11, 2, false, 0 },
                    { 5, 11, 2, false, 1 },
                    { 2, 28, 3, false, 4 },
                    { 1, 28, 4, false, 4 },
                    { 6, 27, 1, false, 1 },
                    { 5, 27, 1, false, 3 },
                    { 4, 27, 4, false, 0 },
                    { 3, 27, 3, false, 2 },
                    { 2, 27, 3, false, 4 },
                    { 1, 27, 2, false, 4 },
                    { 6, 16, 4, false, 4 },
                    { 5, 16, 1, false, 3 },
                    { 4, 16, 2, false, 3 },
                    { 3, 16, 1, false, 0 },
                    { 2, 16, 2, false, 3 },
                    { 1, 16, 4, false, 2 },
                    { 6, 11, 1, false, 2 },
                    { 4, 11, 0, false, 3 },
                    { 6, 47, 2, false, 2 }
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
                name: "IX_Notifikacije_ClanakId",
                table: "Notifikacije",
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
                name: "Notifikacije");

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
