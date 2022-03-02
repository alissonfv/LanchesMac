﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" + 
                "VALUES ('Normal', 'Lanche padrão, sem ingredientes especiais.')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
               "VALUES ('Natural', 'Lanche natural, com ingredientes naturais e integrais.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
