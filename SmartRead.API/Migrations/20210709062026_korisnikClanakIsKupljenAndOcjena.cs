using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRead.API.Migrations
{
    public partial class korisnikClanakIsKupljenAndOcjena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Kupljen",
                table: "KorisnikClanci",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Ocjena",
                table: "KorisnikClanci",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 9, 8, 20, 26, 327, DateTimeKind.Local).AddTicks(6085), "as+iQUHLZf5YVKsjqdDEGANu19YOPoXGRW1/Uh8n1vXJNM27pt7YlHTPaXnHSc3vUxczoViJNw9TdEyozGpIgQ==", "7xfsmnn3ZiDRS7uYJkuIoQ==" });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "Id", "DatumRegistracije", "DatumRodjenja", "DrzavaId", "Ime", "Kredit", "Mail", "Obrisan", "PasswordHash", "PasswordSalt", "Prezime", "Slika", "Username" },
                values: new object[] { 3, new DateTime(2021, 7, 9, 8, 20, 26, 337, DateTimeKind.Local).AddTicks(4854), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobile", 0.0, "mobile@edu.fit.ba", false, "as+iQUHLZf5YVKsjqdDEGANu19YOPoXGRW1/Uh8n1vXJNM27pt7YlHTPaXnHSc3vUxczoViJNw9TdEyozGpIgQ==", "7xfsmnn3ZiDRS7uYJkuIoQ==", "User", null, "mobile" });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "Id", "DatumRegistracije", "DatumRodjenja", "DrzavaId", "Ime", "Kredit", "Mail", "Obrisan", "PasswordHash", "PasswordSalt", "Prezime", "Slika", "Username" },
                values: new object[] { 2, new DateTime(2021, 7, 9, 8, 20, 26, 337, DateTimeKind.Local).AddTicks(4037), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Desktop", 0.0, "desktop@edu.fit.ba", false, "as+iQUHLZf5YVKsjqdDEGANu19YOPoXGRW1/Uh8n1vXJNM27pt7YlHTPaXnHSc3vUxczoViJNw9TdEyozGpIgQ==", "7xfsmnn3ZiDRS7uYJkuIoQ==", "Admin", null, "desktop" });

            migrationBuilder.InsertData(
                table: "Clanci",
                columns: new[] { "Id", "AutorId", "Cijena", "Naslov", "Obrisan", "OdobravateljId", "Odobren", "Slika", "Text" },
                values: new object[,]
                {
                    { 1, 2, 0.12163977470325296, "At totam quos asperiores qui reiciendis autem omnis modi.", false, 1, true, null, @"Eius assumenda velit eveniet amet.
                Est consequatur nisi vitae quo soluta." },
                    { 29, 2, 0.12406041106398237, "Et qui ut aut eius similique eos minus dicta.", false, 1, true, null, @"Non consequatur quia.
                Dolorem voluptatibus aut." },
                    { 30, 2, 0.34713382196944853, "Ut velit nostrum ad ipsam magnam aspernatur et.", false, 1, true, null, @"Omnis provident harum laudantium provident alias omnis accusamus est ullam.
                Dignissimos quasi officia omnis.
                Nemo vel eligendi.
                Distinctio minus fugit quam eaque earum.
                Ut ipsam omnis vel occaecati placeat quaerat suscipit in.
                Distinctio et neque quia aut sint." },
                    { 31, 2, 0.17497457199495964, "Ut modi est.", false, 1, true, null, "Odit officiis blanditiis minima doloremque esse non molestiae officia. Officiis iste pariatur corrupti. Eligendi consequatur aliquam sequi optio facilis ipsam provident." },
                    { 32, 2, 0.70585453496587203, "Eius voluptas suscipit quasi quisquam ratione qui.", false, 1, true, null, "delectus" },
                    { 33, 2, 0.48295105317744941, "Exercitationem voluptatibus nemo voluptatibus neque ut voluptates asperiores.", false, 1, true, null, "Libero eos blanditiis ad velit iusto est." },
                    { 34, 2, 0.58119213654715207, "Autem nisi minima quisquam.", false, 1, true, null, "Ex accusamus voluptatem minus quam aut dolor voluptatibus in eum. Ipsum provident velit ea sed voluptas perferendis omnis et debitis. Enim quo provident et qui repudiandae corporis perferendis quaerat. Sit quis debitis ipsa aut animi. Repellendus vitae voluptatum debitis." },
                    { 35, 2, 0.91588870432036407, "Odio hic minus reprehenderit aut odio.", false, 1, true, null, @"Repellat error iste nemo sed voluptas veritatis accusamus.
                Iure similique qui quo dolore sed ea error.
                Aut voluptas dolorem ea." },
                    { 36, 2, 0.28746139830325795, "Tempora sunt nihil dicta occaecati et in omnis.", false, 1, true, null, "officia" },
                    { 37, 2, 0.49074393533670524, "Atque nam in commodi est.", false, 1, true, null, "et" },
                    { 38, 2, 0.2421865119795252, "Aperiam id cumque.", false, 1, true, null, "aperiam" },
                    { 28, 2, 0.85853580285726849, "Qui dignissimos quia.", false, 1, true, null, "Sit ut iure. Excepturi temporibus est porro modi nostrum ipsa. Minima reiciendis esse deserunt soluta rem odio natus sapiente. Sit non assumenda nihil sed in dolorum nostrum veniam. Voluptas fugit asperiores odio totam aperiam ut accusantium ut nobis. Beatae molestiae nulla vero consequatur quidem." },
                    { 39, 2, 0.996635091955138, "Dolorem corrupti sint mollitia.", false, 1, true, null, @"Aut veritatis aut.
                Dolor vel perferendis non dolore.
                Modi officiis eveniet voluptas occaecati ipsa laborum id nihil porro.
                Corrupti alias necessitatibus corrupti.
                Autem qui facere libero eligendi.
                Expedita officia nostrum corporis facere eos fuga soluta." },
                    { 41, 2, 0.91541020707944887, "Numquam nostrum placeat voluptatibus maxime quisquam autem.", false, 1, true, null, "voluptatem" },
                    { 42, 2, 0.15688205797080046, "Repudiandae perferendis molestiae corporis commodi.", false, 1, true, null, @"Nihil tempore dolore libero alias nihil et.
                Ea est rem esse earum aperiam vel dicta.
                Iste aut voluptatum reprehenderit.
                Atque quibusdam ipsum sed aut quam vero." },
                    { 43, 2, 0.52661795566166658, "Error fugit cum id.", false, 1, true, null, "Placeat minima quas consequatur perferendis ea temporibus. Eum debitis sed laboriosam ratione consequatur. Delectus voluptatem velit amet ducimus dolores totam eligendi. At sed natus voluptates ullam ut et recusandae sed. Aut minus aut iure quos quia aut. Voluptatem magni eius occaecati aut voluptate officiis voluptatem." },
                    { 44, 2, 0.80182833215306903, "Est occaecati consequuntur veniam qui soluta.", false, 1, true, null, "vel" },
                    { 45, 2, 0.24601385427918931, "Velit sed dignissimos ut modi laborum consequatur a doloribus voluptas.", false, 1, true, null, @"Eum ipsam error id suscipit consectetur.
                Aperiam voluptatem quod doloremque." },
                    { 46, 2, 0.033406760093479773, "Voluptate occaecati voluptatem exercitationem incidunt cum quia.", false, 1, true, null, "rem" },
                    { 47, 2, 0.81039635595418347, "Hic ullam in ea repudiandae nesciunt voluptas eligendi.", false, 1, true, null, @"Ut voluptatem architecto qui dolorum.
                Nulla quae autem esse voluptatem fuga sed atque." },
                    { 48, 2, 0.75007895368620703, "Provident doloremque quod enim ex veniam officiis expedita.", false, 1, true, null, "autem" },
                    { 49, 2, 0.079993265718218534, "Asperiores reiciendis suscipit.", false, 1, true, null, @"Omnis consequuntur modi.
                Inventore tempore veniam nihil expedita ad.
                Tempore velit sint aut praesentium incidunt nam rerum assumenda earum.
                Ratione esse repellendus eum eveniet est illo in." },
                    { 50, 2, 0.37203705002182957, "Aut sunt non soluta voluptatum quia.", false, 1, true, null, "Non fuga animi. Ea deserunt eum perferendis provident maxime tempore id. Ipsum et voluptatibus aut fuga incidunt est iste." },
                    { 40, 2, 0.30926423720515528, "Ex quod aut nesciunt nisi ea corporis ducimus nemo.", false, 1, true, null, "Aut dolorum inventore. Eos et iusto. Praesentium culpa ut iste eius." },
                    { 27, 2, 0.34439847261849721, "Commodi quas cumque repellat velit natus unde.", false, 1, true, null, @"Ea aut natus amet aut laboriosam vero sed.
                Illum ipsa in nihil quis totam facilis eos." },
                    { 26, 2, 0.25749879109556728, "Ipsam esse ipsum aut molestiae aut qui maxime tenetur.", false, 1, true, null, "Earum et qui qui sequi iusto consectetur. Et ipsam alias est sit aut ut distinctio. Ratione reprehenderit iusto occaecati animi. Repudiandae architecto laboriosam qui temporibus a. Nulla ea totam doloribus facere qui eius eius." },
                    { 25, 2, 0.1664131368354024, "Enim iusto qui accusamus.", false, 1, true, null, @"Est quia sint vel est eius enim.
                Dolor veritatis autem voluptatem a perferendis quas sed enim cumque.
                Et mollitia sit autem natus molestiae maiores est consequatur.
                Voluptas et eius dolorem voluptas aliquid odio et.
                Sunt occaecati optio optio libero.
                Velit eaque omnis." },
                    { 2, 2, 0.14441501821596875, "Et molestiae distinctio voluptatem consequatur possimus quidem.", false, 1, true, null, "Corporis ipsa illo doloribus sunt qui distinctio rerum. Et ut eveniet maxime voluptates quia deleniti quae culpa dignissimos. Possimus consequatur officiis consectetur quia hic sed quasi quia. Eligendi commodi veniam assumenda mollitia." },
                    { 3, 2, 0.37681011686884336, "Minus repudiandae velit nihil architecto.", false, 1, true, null, "Facere soluta placeat rerum rerum. Illo esse porro rerum dolores ipsum eos libero. Voluptatem officia iusto iste." },
                    { 4, 2, 0.91848535925079389, "Laborum aut ipsam veritatis aut ipsam libero et ut soluta.", false, 1, true, null, "qui" },
                    { 5, 2, 0.14310940361726535, "Enim quis consequuntur voluptatem quidem quidem rerum.", false, 1, true, null, @"Aut quas veritatis.
                Quia fugiat quidem tempora cum consequatur qui nihil et.
                Omnis qui iure ipsum consequatur sed laudantium ut rerum aspernatur.
                Et praesentium sed sint id a quae sunt numquam.
                Est magnam saepe.
                Sint ipsa aut." },
                    { 6, 2, 0.67232556579277181, "Molestiae error earum et perspiciatis et magnam.", false, 1, true, null, "Quidem et natus sapiente ut cupiditate quis occaecati. Itaque voluptate explicabo et numquam. Dolorem qui quos aut at neque distinctio quia reprehenderit." },
                    { 7, 2, 0.40996548412831757, "Quo numquam in cum corrupti.", false, 1, true, null, "nulla" },
                    { 8, 2, 0.44688997764461208, "Praesentium quae quis doloribus perspiciatis qui cupiditate.", false, 1, true, null, "Qui sit hic est." },
                    { 9, 2, 0.99817851511676725, "Aspernatur omnis tempore ut occaecati.", false, 1, true, null, "Nostrum mollitia consequatur nesciunt. Et qui tempora magnam sed harum laboriosam quia at quas. Quo rerum dolorem alias magnam laboriosam ex. Assumenda sed culpa qui molestias dolores necessitatibus est eaque aut." },
                    { 10, 2, 0.090240596835613529, "Id maiores in et facere sint.", false, 1, true, null, "maxime" },
                    { 11, 2, 0.88017939398073564, "Magnam et aliquam.", false, 1, true, null, "quidem" },
                    { 12, 2, 0.58544304807923875, "Quam sint hic labore qui iure maxime ab est.", false, 1, true, null, @"Accusantium ullam labore vero aut.
                Qui veritatis ullam dolore sit quaerat laborum eveniet distinctio.
                Suscipit rem reprehenderit vero aut et et sapiente quae sequi.
                Mollitia fugiat illum accusantium sed quia et et aut aut.
                Qui exercitationem voluptates illum molestias ipsum." },
                    { 13, 2, 0.90800641333125831, "Et molestiae est quibusdam quo magnam quia eveniet.", false, 1, true, null, "Nobis minima consequatur a." },
                    { 14, 2, 0.77834051744003807, "Incidunt deleniti modi consequuntur.", false, 1, true, null, "At itaque hic sit explicabo hic consectetur nostrum ducimus. Ex cupiditate doloribus accusamus aperiam aut. Aut nihil magni voluptas quia minus in sit iure." },
                    { 15, 2, 0.88800029544532311, "Accusantium hic blanditiis facere ducimus sunt officiis.", false, 1, true, null, "Tempora hic aut recusandae ut eveniet qui et sint voluptatem. Vel ducimus dolore excepturi. Asperiores qui sed. Ratione impedit ipsum id voluptatem. Et animi beatae eveniet repellat quia. At et rem sit voluptates." },
                    { 16, 2, 0.77669637360456234, "Consequuntur placeat totam sint qui est et quia et.", false, 1, true, null, "Qui distinctio qui." },
                    { 17, 2, 0.017964642037621065, "Dolor molestias libero id reiciendis pariatur ex.", false, 1, true, null, "ut" },
                    { 18, 2, 0.8419773964406817, "Mollitia mollitia eaque.", false, 1, true, null, "vitae" },
                    { 19, 2, 0.46191982341088345, "Et qui labore et quia.", false, 1, true, null, @"Ea soluta et at sint itaque architecto dolores.
                Excepturi labore voluptatem vero ad qui ducimus magnam.
                Id et laborum sed consequatur perferendis.
                Exercitationem voluptatem vel minima consequuntur.
                Ab maxime voluptatem quos tempore.
                Velit et odit occaecati." },
                    { 20, 2, 0.60813400503626747, "Occaecati nulla eligendi molestias delectus.", false, 1, true, null, "Eum perferendis sunt aspernatur sequi ipsam. Omnis modi temporibus eligendi at error non consectetur voluptate. Repellendus quisquam tempora voluptas debitis et eum. Vero nulla ipsum est. Amet eum corrupti est totam eaque et dolorem suscipit. Iusto vero minima voluptatem eum." },
                    { 21, 2, 0.48563799564057869, "Nemo expedita quis repudiandae sit ad error natus tenetur.", false, 1, true, null, @"Exercitationem totam laborum rerum iusto id enim commodi quo quod.
                Facere molestiae qui commodi.
                Voluptatibus mollitia sit iste perspiciatis beatae ut sint quia.
                Alias odit molestiae neque sint cupiditate hic numquam eaque.
                Dolorem repudiandae voluptas quo sint et earum error quas sed." },
                    { 22, 2, 0.27249658073880551, "Repudiandae omnis culpa ex suscipit ratione voluptate eius.", false, 1, true, null, "Error animi quia odio tempore tempora et. Non velit rem delectus quasi possimus totam eaque ullam. Reiciendis perferendis repellendus iure." },
                    { 23, 2, 0.86613755061576958, "Ratione qui neque amet.", false, 1, true, null, "Sapiente est quis minima fugit enim et ut suscipit. Qui ad voluptatem odio consequatur molestias animi accusamus aut odit. Hic dicta quo. Voluptas perferendis nostrum sunt. Odio alias ea. Excepturi labore dolor deleniti aliquid qui dolores." },
                    { 24, 2, 0.50940551259992906, "Eos inventore fugit hic facere suscipit beatae natus.", false, 1, true, null, "Cumque id aut rerum qui aut temporibus ullam." }
                });

            migrationBuilder.InsertData(
                table: "KorisnikUloge",
                columns: new[] { "KorisnikId", "UlogaId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "KorisnikUloge",
                keyColumns: new[] { "KorisnikId", "UlogaId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "KorisnikUloge",
                keyColumns: new[] { "KorisnikId", "UlogaId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Kupljen",
                table: "KorisnikClanci");

            migrationBuilder.DropColumn(
                name: "Ocjena",
                table: "KorisnikClanci");

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 4, 22, 9, 13, 237, DateTimeKind.Local).AddTicks(7415), "V3Y6sIgV5t4Zvvke9PgezpL7sYTL7eczSzvDqgbp147jVydKgnJntDhYQY7mEIL50ide2+UOzj7owa4+vogQxw==", "mERDDn6zsDGUZOwGOgrhOw==" });
        }
    }
}
