using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SocorroDesk.Migrations
{
    /// <inheritdoc />
    public partial class BancoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CHAMADOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATA_ABERTURA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CHAPA_COLABORADOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DEPARTAMENTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ASSUNTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ULTIMA_ATUALIZAÇÃO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OBSERVACOES = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CHAMADOS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_CHAMADOS",
                columns: new[] { "Id", "ASSUNTO", "CHAPA_COLABORADOR", "DATA_ABERTURA", "DEPARTAMENTO", "OBSERVACOES", "STATUS", "ULTIMA_ATUALIZAÇÃO" },
                values: new object[,]
                {
                    { 1, "Suporte de Hardware", "38976", new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1052), "Gestão Imobiliária", null, "Aguardando Atendimento", new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1073) },
                    { 2, "Problemas com Login e Senha", "38976", new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1077), "Gestão Imobiliária", null, "Aguardando Atendimento", new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1078) },
                    { 3, "Outros", "38976", new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1079), "Gestão Imobiliária", null, "Aguardando Atendimento", new DateTime(2023, 8, 23, 15, 23, 16, 831, DateTimeKind.Local).AddTicks(1080) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ID_UNIQUE",
                table: "TB_CHAMADOS",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CHAMADOS");
        }
    }
}
