using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRead.API.Migrations
{
    public partial class removeEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VrstaPrijave",
                table: "KorisnikPrijave");

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.51041831705273055, "Molestias in tempora voluptatum perspiciatis magni sapiente dolorem.", @"Ut ullam temporibus officia.
A quidem facere suscipit ducimus dolor.
Sapiente ut maiores qui.
Ipsa voluptas sit sequi praesentium.
Aspernatur est sunt sunt eligendi quia reprehenderit voluptates beatae." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.39218971011796488, "Occaecati nihil ut et dolore repellendus voluptatum autem eum.", "est" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.89835436311473804, "Labore natus in et repellendus.", "Est qui est ut commodi et rerum harum earum ut. Tempore aut porro error praesentium unde quibusdam reiciendis. Dolor beatae est autem exercitationem dolorem at dolores. Omnis quia sunt architecto aut maxime ut culpa." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.9844243102634439, "Sint provident quod odio nam voluptatem porro sequi cupiditate asperiores.", "Consequatur minus consectetur optio et ipsam id sed aut vel. Dolorem esse laborum animi incidunt ut deserunt aut est repudiandae. Quia eaque quidem." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.71833201810639913, "In tempore sit eos dolor.", @"Laboriosam est ab.
Voluptatem nostrum nisi et." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.55758977008871258, "Ad dolore velit sed et omnis ea illo quam.", "rerum" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.69708623676425141, "Inventore illum sapiente doloremque.", "Magni blanditiis minima cupiditate quaerat perspiciatis et nihil. Ex sunt voluptatem blanditiis quia commodi id. Praesentium facere omnis id est nostrum veritatis qui dolor sed. Aliquid corporis voluptatem deleniti tempora quae cumque illum ut rerum. Vel harum reiciendis odio veritatis quas autem aut rerum." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.50064442423202304, "Sit sunt fugit.", "Dolorem numquam eum voluptatum consequatur non. Ipsam explicabo sunt. Velit molestias perspiciatis voluptas inventore animi quis ratione possimus quis. Natus ut soluta deserunt. Ut veniam eligendi consequatur quia. Ullam et facere." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.098203157586140163, "Quis cumque et quia delectus velit.", "Sequi ipsam sapiente ut quod possimus. Fugit itaque expedita eaque. Velit quidem aut doloremque ea est id nemo quia. Aut iste modi repellat dignissimos pariatur neque quaerat ratione deleniti. Sequi eos hic quia quisquam fuga error molestiae amet quo." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.17600990327820643, "Qui a et aspernatur explicabo error.", @"Incidunt voluptatem corporis ea maxime quod.
Sit hic cum molestias iste.
Quaerat dolores at impedit soluta aspernatur eaque vel voluptatem." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.80594278723278212, "Explicabo rerum ipsa vel facere quasi optio praesentium numquam est.", "Sint aut rerum aliquam mollitia ut aperiam deserunt. Dolor cumque sunt dolore iure aut deserunt tempora alias non. Reprehenderit enim odit. Recusandae culpa aut voluptatibus ab nisi adipisci suscipit. Non temporibus impedit numquam dolor repellendus temporibus. Quia amet eos laboriosam." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.56365548985249148, "Nobis illum accusamus doloribus est quo repellendus.", "Accusamus sit voluptatem sit ex illo ut." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.94791248298618591, "Commodi hic aperiam mollitia quia autem dignissimos.", "nihil" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.19739482235042138, "Quia dolore ea.", "quasi" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.28631264170925724, "Dolor aliquid officia fuga.", "Voluptas doloremque laudantium assumenda. Dicta dolor fuga ad reiciendis at. Dicta rerum quos perspiciatis reprehenderit nostrum. Amet deleniti dolorum dolorem adipisci rerum sequi necessitatibus ea. Repellat quod sed beatae. Suscipit ut voluptatibus ducimus doloribus eos." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.14430352912484831, "Aut eum ad animi aut cupiditate est.", "Asperiores assumenda nihil eius quia. Dolorem ad velit quam velit. Labore id reprehenderit cum nemo." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.76547029417262891, "Earum corporis reiciendis ut voluptatibus facilis odio.", "Commodi tempore ea. Voluptate quia enim impedit fugit eos quo fuga quo. Et dicta cumque ratione sed non et eius. Et magnam doloremque sit accusamus est sunt." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.033913814944174989, "Deleniti incidunt quo placeat aut.", "Laborum beatae ut consectetur alias pariatur voluptatem officia ipsam." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.98361241956409651, "Rerum exercitationem vel dolores laborum ratione consequuntur nesciunt omnis vel.", "dignissimos" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.9267899565989105, "Autem commodi qui deleniti dolorem sed beatae.", "ipsam" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.93811337507242032, "Laudantium accusantium ut reprehenderit.", "Fugiat eum fuga totam ut ut et est. At sint qui quas quidem maiores est. Corrupti quia aut corrupti sint illum porro voluptatibus. Alias ratione quia officia voluptas dolorum." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.34372265326963863, "Est sequi sint et reprehenderit quibusdam.", "Modi enim eos nihil quos deleniti. Repudiandae et possimus sit non sint. Voluptates corrupti sint." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.73186362615407619, "Similique aperiam dicta exercitationem excepturi explicabo.", "fugiat" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.67026712497243057, "Explicabo vel et aliquid quam deserunt ea sed.", "molestias" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.64409031516131499, "Tempore eos et est adipisci est qui aut.", "Blanditiis qui similique laudantium eos perferendis aliquid voluptas laudantium facilis." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.48548919683577924, "Consequatur vel dicta vero.", @"Quis atque fugiat quibusdam qui ea tempora.
Et eveniet nisi est est nemo.
Et pariatur repellendus tenetur.
Reprehenderit assumenda cumque quae voluptatem aut." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.50491010095221456, "Corrupti occaecati laboriosam.", "quisquam" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.60410846285713304, "Qui dolorum mollitia.", @"Qui dignissimos molestiae sed tenetur et aut mollitia blanditiis ut.
Unde delectus fugit." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.44038209991547378, "Temporibus est quisquam officiis dolor rerum iure natus nesciunt.", "Qui corporis aliquam eaque nulla. Aut quia ad molestiae et dolor id. Doloremque veniam voluptatem quidem possimus reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.10486396081040798, "Fugiat qui accusantium incidunt qui quidem inventore.", "Cumque dolorum est voluptatem voluptatibus aperiam cumque quam nemo minima. Eos nihil ut enim est repudiandae aut. Occaecati non eum qui quia. Et perferendis et illum dolorem ut. Delectus vitae deleniti voluptatibus soluta aut. Incidunt itaque laboriosam vitae neque." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.84906393096273014, "Fugit atque sapiente consequatur est a sunt odio omnis officiis.", "Unde voluptatem dicta animi eos aut aut saepe. Veritatis quis ipsa aperiam quibusdam et qui officiis. Distinctio aut et voluptatem non et consequatur dignissimos. Eum cupiditate nemo id amet. Sed facere quia." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.31957931039835297, "Rerum voluptatem alias beatae corrupti nihil cum delectus.", @"Vero ut magni eos laudantium dolor incidunt.
Iusto autem optio cumque ad quis." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.51021195785618012, "Aut molestiae eum quae vero id.", "et" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.89347933134691759, "Nihil eum odit.", "Sequi quia libero ea rem quae et accusantium cupiditate. Esse rerum dolore qui qui nihil ipsum sapiente. Eaque eos fugit est quia assumenda sit. Ea facere in eum praesentium hic earum unde. Cumque sint maiores illo enim aut cupiditate qui quia consectetur. Inventore autem porro distinctio qui ea aut." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.29473316590056436, "Tempore unde harum.", "quam" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.31030631545479703, "Quia sit tenetur repellat nemo.", "Magnam reiciendis occaecati. Illo deserunt molestias et culpa dolor similique maiores aperiam. Et inventore qui ab molestias minima sequi veniam. Harum reiciendis sed in vel consequatur adipisci et sequi. Quo voluptate dolorem aut ipsa voluptas ducimus. Maxime illo commodi at." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.51818642137487714, "Vel sunt eveniet at.", "Et pariatur ut dolores rerum temporibus." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.05971360069686249, "Eligendi iusto eum sed.", "Voluptatem sit architecto quia aspernatur quia." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.74133364006007729, "Voluptate tempora deleniti.", "Sit est totam laboriosam maiores. Aut et odio aperiam asperiores aliquam quia aliquam voluptatum. Libero eum odio molestiae sint. Perferendis est possimus. Laboriosam iure odio." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.13197483826986273, "Odit quia eius ipsum delectus delectus quae unde.", @"Saepe ipsa dolor nulla rerum et.
Aspernatur iste et nisi quod vel ut quo.
Qui recusandae quam quo molestiae optio vel necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.23512633295502808, "Dicta molestias ut.", @"Rerum laudantium sequi aut perspiciatis voluptates neque sed placeat.
Sit alias omnis vel quo.
Aliquam modi praesentium et." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.93217285253674387, "Accusantium adipisci nam quis quo repellendus porro.", "placeat" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.77025119344249893, "Iste aut sint illum id.", "cum" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.54883803778739559, "Delectus dicta excepturi autem consequuntur facere voluptatem rerum magnam quia.", "nam" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.25187727075623223, "Odio sapiente enim.", "Vel illum et deserunt." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.88044078921919722, "Sed ad et eum sint accusantium repellendus nulla.", "Itaque soluta quis nesciunt sapiente occaecati eum." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.47640374511312866, "Assumenda impedit aut aperiam voluptatum at molestiae itaque.", "Quasi ut quos voluptatem placeat molestiae." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.5001841678750627, "Quas minus explicabo autem qui.", "laudantium" });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.0059109097374188298, "Voluptatem aspernatur incidunt vero maiores.", @"Et adipisci et dignissimos non sunt.
Nemo blanditiis minima.
Dignissimos quam ut ut atque.
Voluptas ratione sed reprehenderit.
Consequatur similique reiciendis in voluptate voluptas dolore provident vitae est.
Omnis dolorem qui incidunt eveniet aut facilis." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.48397822281530978, "Commodi sint quia.", "vero" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 25, 39, 675, DateTimeKind.Local).AddTicks(2251), "XbPdXqww4PZKnQukaoRqp+DAebTuB3nyDrzHDqhfBU7gJ5JKwPQ0TDDdoErFVuFw9msyx1sm0/5202zT/0Pevw==", "bE4mXF4BCwRjSX05mYeU1A==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 25, 39, 681, DateTimeKind.Local).AddTicks(7809), "XbPdXqww4PZKnQukaoRqp+DAebTuB3nyDrzHDqhfBU7gJ5JKwPQ0TDDdoErFVuFw9msyx1sm0/5202zT/0Pevw==", "bE4mXF4BCwRjSX05mYeU1A==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 25, 39, 681, DateTimeKind.Local).AddTicks(8338), "XbPdXqww4PZKnQukaoRqp+DAebTuB3nyDrzHDqhfBU7gJ5JKwPQ0TDDdoErFVuFw9msyx1sm0/5202zT/0Pevw==", "bE4mXF4BCwRjSX05mYeU1A==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 25, 39, 681, DateTimeKind.Local).AddTicks(8400), "XbPdXqww4PZKnQukaoRqp+DAebTuB3nyDrzHDqhfBU7gJ5JKwPQ0TDDdoErFVuFw9msyx1sm0/5202zT/0Pevw==", "bE4mXF4BCwRjSX05mYeU1A==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 25, 39, 681, DateTimeKind.Local).AddTicks(8501), "XbPdXqww4PZKnQukaoRqp+DAebTuB3nyDrzHDqhfBU7gJ5JKwPQ0TDDdoErFVuFw9msyx1sm0/5202zT/0Pevw==", "bE4mXF4BCwRjSX05mYeU1A==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 25, 39, 681, DateTimeKind.Local).AddTicks(8538), "XbPdXqww4PZKnQukaoRqp+DAebTuB3nyDrzHDqhfBU7gJ5JKwPQ0TDDdoErFVuFw9msyx1sm0/5202zT/0Pevw==", "bE4mXF4BCwRjSX05mYeU1A==" });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 3 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 7 },
                column: "Ocjena",
                value: 2);

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
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 13 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 14 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 15 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 16 },
                column: "Ocjena",
                value: 2);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 19 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 20 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 22 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 23 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

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
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 34 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 37 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 40 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 41 },
                column: "Ocjena",
                value: 0);

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
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 48 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 50 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 3 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 10 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 12 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 13 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 16 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 21 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 29 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 30 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 31 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 35 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 36 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 37 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

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
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 43 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 44 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 45 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 46 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 48 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 2 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 8 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 13 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 19 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 20 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 23 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

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
                keyValues: new object[] { 3, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 31 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 32 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 33 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 35 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 36 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 37 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 42 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 43 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 45 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 48 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 5 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 8 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 9 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 10 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

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
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 18 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 19 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 23 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 24 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 26 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 29 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 30 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 33 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 37 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 41 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 42 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 43 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 47 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 48 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 3 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 5 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 10 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 11 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 13 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 14 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 16 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 17 },
                column: "BrojPosjeta",
                value: 4);

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
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 20 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 21 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 23 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 24 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 25 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 29 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 30 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 35 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 36 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 37 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 42 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 45 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 46 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 48 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 1 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 8 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 9 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 11 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 13 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 16 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 18 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 21 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 22 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 23 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 29 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 30 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 31 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 36 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 37 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 41 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 43 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 45 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 46 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 48 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 50 },
                column: "Ocjena",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VrstaPrijave",
                table: "KorisnikPrijave",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.32492764309278116, "Accusamus doloremque esse.", "Veritatis at eligendi eum consequatur maiores omnis. Magni adipisci dolorem. Adipisci unde sed. Sed ullam voluptas sint dolorem dolore." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.97966801281071636, "Consequuntur et et quisquam sunt itaque nihil magnam minima est.", "Harum praesentium qui." });

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
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.41182537396057761, "Harum unde rerum possimus fuga ut ex eos consequatur dolorum.", "Alias eos explicabo fuga." });

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
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.67975908549491271, "Minima aspernatur quis aut.", "illo" });

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
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 2, 0.40253218049301404, "Sed necessitatibus cupiditate qui quia ut aut neque ea sunt.", "Rerum molestias sit et similique. Laborum voluptatem nulla dolores molestias repellat dolores ea est. Culpa sit voluptas. Molestiae in eos. Ut quia et minima. Quasi qui quod iusto." });

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
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.28510562902554198, "Ratione rerum maxime fugit sunt optio.", "Nostrum consequatur est. Accusantium quos voluptatem reiciendis sint ratione blanditiis ad. Sint exercitationem magnam fugiat sed consectetur esse hic culpa. Animi ullam incidunt dolor et assumenda necessitatibus. Voluptatem totam eveniet atque explicabo sed pariatur. Nemo soluta adipisci." });

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
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 1, 0.049913404998329192, "Animi eum in provident praesentium vel molestiae officia consequuntur voluptatum.", @"Qui nemo corporis atque vel aut.
Minima vitae est.
Dignissimos aliquam magnam.
Adipisci molestias consectetur consectetur harum aliquid illum aut rerum." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 4, 0.72040242223087814, "Consequatur laudantium aut iste voluptates voluptas a quasi.", @"Sit dolorem eligendi ut cum sint.
Non sunt quia magni et qui dolorum veniam.
Et consequuntur voluptates suscipit nam.
Libero et ut in cupiditate quod." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.48811425757040933, "Sit quisquam dolore voluptas voluptas commodi.", "Tempore ullam et aut sapiente quas debitis nulla." });

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
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.0024442747246680198, "Quisquam ducimus labore.", "sit" });

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
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.30528730587348685, "Et pariatur architecto eaque distinctio omnis.", "Non sint perferendis accusantium quidem enim ullam qui voluptatem." });

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
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 5, 0.282129148152717, "Quisquam dolore eius.", @"Facere consequatur aut.
Vel et voluptatem commodi ex in omnis.
Dicta possimus doloremque sed distinctio dicta incidunt quae dolor.
Dolorem sit et.
Minus illum et velit velit." });

            migrationBuilder.UpdateData(
                table: "Clanci",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Cijena", "Naslov", "Text" },
                values: new object[] { 0.041670701020243901, "Dolores itaque fugit delectus impedit ut amet vitae fuga et.", "Est ad itaque." });

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
                columns: new[] { "AutorId", "Cijena", "Naslov", "Text" },
                values: new object[] { 3, 0.6913104158320047, "Quo hic qui sint similique hic.", "Sequi ut cumque a adipisci perferendis autem est dolore qui. Recusandae aliquid fugiat veniam ad. Non maxime corrupti in." });

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
                keyValues: new object[] { 1, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 3 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 5 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

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
                column: "Ocjena",
                value: 4);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 13 },
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 14 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 15 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 16 },
                column: "Ocjena",
                value: 0);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

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
                column: "BrojPosjeta",
                value: 3);

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
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 28 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

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
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 34 },
                column: "BrojPosjeta",
                value: 4);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 40 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 1, 41 },
                column: "Ocjena",
                value: 3);

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
                column: "BrojPosjeta",
                value: 0);

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
                keyValues: new object[] { 1, 47 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

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
                keyValues: new object[] { 1, 50 },
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

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
                column: "Ocjena",
                value: 4);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 9 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 10 },
                column: "Ocjena",
                value: 3);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 1 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 29 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 30 },
                column: "BrojPosjeta",
                value: 4);

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
                keyValues: new object[] { 2, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

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
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 36 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 37 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

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
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 40 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 42 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 43 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 44 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 45 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 46 },
                column: "Ocjena",
                value: 2);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 2, 50 },
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
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 7 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 8 },
                column: "BrojPosjeta",
                value: 3);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 13 },
                column: "BrojPosjeta",
                value: 4);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 17 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

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
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 20 },
                column: "Ocjena",
                value: 0);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 24 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 25 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

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
                keyValues: new object[] { 3, 30 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 31 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 32 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 33 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 35 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 36 },
                column: "BrojPosjeta",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 37 },
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

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
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 43 },
                column: "BrojPosjeta",
                value: 1);

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
                column: "BrojPosjeta",
                value: 0);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 48 },
                column: "BrojPosjeta",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 3, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 5 },
                column: "Ocjena",
                value: 2);

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
                column: "Ocjena",
                value: 0);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 9 },
                column: "BrojPosjeta",
                value: 4);

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
                keyValues: new object[] { 4, 12 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 18 },
                column: "BrojPosjeta",
                value: 0);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 24 },
                column: "BrojPosjeta",
                value: 1);

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
                column: "Ocjena",
                value: 2);

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
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 30 },
                column: "Ocjena",
                value: 3);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 33 },
                column: "BrojPosjeta",
                value: 1);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 37 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 38 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 39 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 3 });

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
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 42 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 43 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 44 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

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
                keyValues: new object[] { 4, 47 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 4, 48 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 3 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

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
                keyValues: new object[] { 5, 5 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 6 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 1 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 10 },
                column: "Ocjena",
                value: 3);

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
                column: "Ocjena",
                value: 2);

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
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 17 },
                column: "BrojPosjeta",
                value: 3);

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
                column: "BrojPosjeta",
                value: 1);

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
                column: "Ocjena",
                value: 1);

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
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 24 },
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 25 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 26 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 27 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 0 });

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
                column: "BrojPosjeta",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 30 },
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 31 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 3 });

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
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 36 },
                column: "BrojPosjeta",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 37 },
                column: "Ocjena",
                value: 0);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 42 },
                column: "Ocjena",
                value: 2);

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
                column: "Ocjena",
                value: 4);

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
                column: "Ocjena",
                value: 3);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 49 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 0 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 5, 50 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 1 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

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
                column: "Ocjena",
                value: 2);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 11 },
                column: "Ocjena",
                value: 3);

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
                column: "BrojPosjeta",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 14 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 15 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 2 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 2, 4 });

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
                column: "Ocjena",
                value: 0);

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 30 },
                column: "Ocjena",
                value: 4);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 31 },
                column: "Ocjena",
                value: 1);

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 32 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 33 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 34 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "KorisnikClanci",
                keyColumns: new[] { "KorisnikId", "ClanakId" },
                keyValues: new object[] { 6, 35 },
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 4 });

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
                column: "Ocjena",
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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 0, 3 });

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
                columns: new[] { "BrojPosjeta", "Ocjena" },
                values: new object[] { 4, 1 });

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
                column: "Ocjena",
                value: 1);
        }
    }
}
