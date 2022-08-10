using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Testing.Migrations
{
    public partial class myMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boton",
                columns: table => new
                {
                    IIDBOTON = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BOTON__90C2312F68927075", x => x.IIDBOTON);
                });

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    IIDESPECIALIDAD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEspecialidad", x => x.IIDESPECIALIDAD);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCita",
                columns: table => new
                {
                    IIDESTADO = table.Column<int>(type: "int", nullable: false),
                    VNOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VDESCRIPCION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ESTACITA__CB0F471FE45B7978", x => x.IIDESTADO);
                });

            migrationBuilder.CreateTable(
                name: "FormaFarmaceutica",
                columns: table => new
                {
                    IIDFORMAFARMACEUTICA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaFarmaceutica", x => x.IIDFORMAFARMACEUTICA);
                });

            migrationBuilder.CreateTable(
                name: "Pagina",
                columns: table => new
                {
                    IIDPAGINA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MENSAJE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ACCION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CONTROLADOR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pagina__8E759E4E24D07BF3", x => x.IIDPAGINA);
                });

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    IIDSEDE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECCION = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinica", x => x.IIDSEDE);
                });

            migrationBuilder.CreateTable(
                name: "Sexo",
                columns: table => new
                {
                    IIDSEXO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexo", x => x.IIDSEXO);
                });

            migrationBuilder.CreateTable(
                name: "TipoSangre",
                columns: table => new
                {
                    IIDTIPOSANGRE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSangre", x => x.IIDTIPOSANGRE);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    IIDTIPOUSUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.IIDTIPOUSUARIO);
                });

            migrationBuilder.CreateTable(
                name: "Medicamento",
                columns: table => new
                {
                    IIDMEDICAMENTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CONCENTRACION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IIDFORMAFARMACEUTICA = table.Column<int>(type: "int", nullable: true),
                    PRECIO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    STOCK = table.Column<int>(type: "int", nullable: true),
                    PRESENTACION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamento", x => x.IIDMEDICAMENTO);
                    table.ForeignKey(
                        name: "FK__Medicamen__IIDFO__36B12243",
                        column: x => x.IIDFORMAFARMACEUTICA,
                        principalTable: "FormaFarmaceutica",
                        principalColumn: "IIDFORMAFARMACEUTICA");
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    IIDPACIENTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IIDTIPOSANGRE = table.Column<int>(type: "int", nullable: true),
                    ALERGIAS = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ENFERMEDADESCRONICAS = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CUADROVACUNAS = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ANTECEDENTESQUIRURGICOS = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IIDPERSONA = table.Column<int>(type: "int", nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes_1", x => x.IIDPACIENTE);
                    table.ForeignKey(
                        name: "FK__Paciente__IIDTIP__17036CC0",
                        column: x => x.IIDTIPOSANGRE,
                        principalTable: "TipoSangre",
                        principalColumn: "IIDTIPOSANGRE");
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarioPagina",
                columns: table => new
                {
                    IIDTIPOUSUARIOPAGINA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IIDTIPOUSUARIO = table.Column<int>(type: "int", nullable: true),
                    IIDPAGINA = table.Column<int>(type: "int", nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true),
                    IIDVISTA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TipoUsua__59B815B9209568AC", x => x.IIDTIPOUSUARIOPAGINA);
                    table.ForeignKey(
                        name: "FK__TipoUsuar__IIDPA__75A278F5",
                        column: x => x.IIDPAGINA,
                        principalTable: "Pagina",
                        principalColumn: "IIDPAGINA");
                    table.ForeignKey(
                        name: "FK__TipoUsuar__IIDTI__74AE54BC",
                        column: x => x.IIDTIPOUSUARIO,
                        principalTable: "TipoUsuario",
                        principalColumn: "IIDTIPOUSUARIO");
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarioPaginaBoton",
                columns: table => new
                {
                    IIDTIPOUSUARIOPAGINABOTON = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IIDTIPOUSUARIOPAGINA = table.Column<int>(type: "int", nullable: true),
                    IIDBOTON = table.Column<int>(type: "int", nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TipoUsua__7882D20C06997AB0", x => x.IIDTIPOUSUARIOPAGINABOTON);
                    table.ForeignKey(
                        name: "FK__TipoUsuar__IIDBO__797309D9",
                        column: x => x.IIDBOTON,
                        principalTable: "Boton",
                        principalColumn: "IIDBOTON");
                    table.ForeignKey(
                        name: "FK__TipoUsuar__IIDTI__787EE5A0",
                        column: x => x.IIDTIPOUSUARIOPAGINA,
                        principalTable: "TipoUsuarioPagina",
                        principalColumn: "IIDTIPOUSUARIOPAGINA");
                });

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    IIDCITA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IIDUSUARIO = table.Column<int>(type: "int", nullable: true),
                    PESO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ESTATURA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EXAMENFISICO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EXAMENLABORATORIO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DIAGNOSTICO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DFECHACITA = table.Column<DateTime>(type: "datetime", nullable: true),
                    IIDESTADOCITA = table.Column<int>(type: "int", nullable: true),
                    IIDSEDE = table.Column<int>(type: "int", nullable: true),
                    PRECIOATENCION = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TOTALPAGAR = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DFECHAINICIOENFERMEDAD = table.Column<DateTime>(type: "datetime", nullable: true),
                    IIDDOCTORASIGNADO = table.Column<int>(type: "int", nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true),
                    IIDPERSONA = table.Column<int>(type: "int", nullable: true),
                    DESCRIPCIONENFERMEDAD = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.IIDCITA);
                    table.ForeignKey(
                        name: "FK__Cita__IIDESTADOC__7E37BEF6",
                        column: x => x.IIDESTADOCITA,
                        principalTable: "EstadoCita",
                        principalColumn: "IIDESTADO");
                    table.ForeignKey(
                        name: "FK__Cita__IIDSEDE__7F2BE32F",
                        column: x => x.IIDSEDE,
                        principalTable: "Sede",
                        principalColumn: "IIDSEDE");
                });

            migrationBuilder.CreateTable(
                name: "CitaMedicamento",
                columns: table => new
                {
                    IIDCITAMEDICAMENTO = table.Column<int>(type: "int", nullable: false),
                    IIDCITA = table.Column<int>(type: "int", nullable: true),
                    IIDMEDICAMENTO = table.Column<int>(type: "int", nullable: true),
                    CANTIDAD = table.Column<int>(type: "int", nullable: true),
                    PRECIO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__citamedi__E4CCE514844E03D5", x => x.IIDCITAMEDICAMENTO);
                    table.ForeignKey(
                        name: "FK__citamedic__IIDCI__03F0984C",
                        column: x => x.IIDCITA,
                        principalTable: "Cita",
                        principalColumn: "IIDCITA");
                    table.ForeignKey(
                        name: "FK__citamedic__IIDME__04E4BC85",
                        column: x => x.IIDMEDICAMENTO,
                        principalTable: "Medicamento",
                        principalColumn: "IIDMEDICAMENTO");
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    IIDDOCTOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IIDSEDE = table.Column<int>(type: "int", nullable: true),
                    IIDESPECIALIDAD = table.Column<int>(type: "int", nullable: true),
                    SUELDO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FECHACONTRATO = table.Column<DateTime>(type: "datetime", nullable: true),
                    IIDPERSONA = table.Column<int>(type: "int", nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.IIDDOCTOR);
                    table.ForeignKey(
                        name: "FK_Doctor_Clinica",
                        column: x => x.IIDSEDE,
                        principalTable: "Sede",
                        principalColumn: "IIDSEDE");
                    table.ForeignKey(
                        name: "FK_Doctor_Especialidad",
                        column: x => x.IIDESPECIALIDAD,
                        principalTable: "Especialidad",
                        principalColumn: "IIDESPECIALIDAD");
                });

            migrationBuilder.CreateTable(
                name: "HistorialCita",
                columns: table => new
                {
                    IIDHISTORIALCITA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IIDCITA = table.Column<int>(type: "int", nullable: true),
                    IIDESTADO = table.Column<int>(type: "int", nullable: true),
                    IIDUSUARIO = table.Column<int>(type: "int", nullable: true),
                    DFECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    VOBSERVACION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Historia__35A9F434FABE77C7", x => x.IIDHISTORIALCITA);
                    table.ForeignKey(
                        name: "FK__Historial__IIDCI__07C12930",
                        column: x => x.IIDCITA,
                        principalTable: "Cita",
                        principalColumn: "IIDCITA");
                    table.ForeignKey(
                        name: "FK__Historial__IIDES__08B54D69",
                        column: x => x.IIDESTADO,
                        principalTable: "EstadoCita",
                        principalColumn: "IIDESTADO");
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IIDPERSONA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    APPATERNO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    APMATERNO = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DIRECCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TELEFONOFIJO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TELEFONOCELULAR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FECHANACIMIENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    IIDSEXO = table.Column<int>(type: "int", nullable: true),
                    BDOCTOR = table.Column<int>(type: "int", nullable: true),
                    BPACIENTE = table.Column<int>(type: "int", nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true),
                    FOTO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BTIENEUSUARIO = table.Column<int>(type: "int", nullable: true),
                    IIDUSUARIO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.IIDPERSONA);
                    table.ForeignKey(
                        name: "FK_Paciente_Sexo",
                        column: x => x.IIDSEXO,
                        principalTable: "Sexo",
                        principalColumn: "IIDSEXO");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IIDUSUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IIDTIPOUSUARIO = table.Column<int>(type: "int", nullable: false),
                    NOMBREUSUARIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CONTRASEÑA = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BHABILITADO = table.Column<int>(type: "int", nullable: true),
                    IIDPERSONA = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IIDUSUARIO);
                    table.ForeignKey(
                        name: "FK__Usuario__IIDPERS__14270015",
                        column: x => x.IIDPERSONA,
                        principalTable: "Persona",
                        principalColumn: "IIDPERSONA");
                    table.ForeignKey(
                        name: "FK__Usuario__IIDTIPO__68487DD7",
                        column: x => x.IIDTIPOUSUARIO,
                        principalTable: "TipoUsuario",
                        principalColumn: "IIDTIPOUSUARIO");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cita_IIDDOCTORASIGNADO",
                table: "Cita",
                column: "IIDDOCTORASIGNADO");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_IIDESTADOCITA",
                table: "Cita",
                column: "IIDESTADOCITA");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_IIDPERSONA",
                table: "Cita",
                column: "IIDPERSONA");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_IIDSEDE",
                table: "Cita",
                column: "IIDSEDE");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_IIDUSUARIO",
                table: "Cita",
                column: "IIDUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_CitaMedicamento_IIDCITA",
                table: "CitaMedicamento",
                column: "IIDCITA");

            migrationBuilder.CreateIndex(
                name: "IX_CitaMedicamento_IIDMEDICAMENTO",
                table: "CitaMedicamento",
                column: "IIDMEDICAMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_IIDESPECIALIDAD",
                table: "Doctor",
                column: "IIDESPECIALIDAD");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_IIDPERSONA",
                table: "Doctor",
                column: "IIDPERSONA");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_IIDSEDE",
                table: "Doctor",
                column: "IIDSEDE");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCita_IIDCITA",
                table: "HistorialCita",
                column: "IIDCITA");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCita_IIDESTADO",
                table: "HistorialCita",
                column: "IIDESTADO");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCita_IIDUSUARIO",
                table: "HistorialCita",
                column: "IIDUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamento_IIDFORMAFARMACEUTICA",
                table: "Medicamento",
                column: "IIDFORMAFARMACEUTICA");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IIDTIPOSANGRE",
                table: "Paciente",
                column: "IIDTIPOSANGRE");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IIDSEXO",
                table: "Persona",
                column: "IIDSEXO");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IIDUSUARIO",
                table: "Persona",
                column: "IIDUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_TipoUsuarioPagina_IIDPAGINA",
                table: "TipoUsuarioPagina",
                column: "IIDPAGINA");

            migrationBuilder.CreateIndex(
                name: "IX_TipoUsuarioPagina_IIDTIPOUSUARIO",
                table: "TipoUsuarioPagina",
                column: "IIDTIPOUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_TipoUsuarioPaginaBoton_IIDBOTON",
                table: "TipoUsuarioPaginaBoton",
                column: "IIDBOTON");

            migrationBuilder.CreateIndex(
                name: "IX_TipoUsuarioPaginaBoton_IIDTIPOUSUARIOPAGINA",
                table: "TipoUsuarioPaginaBoton",
                column: "IIDTIPOUSUARIOPAGINA");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IIDPERSONA",
                table: "Usuario",
                column: "IIDPERSONA");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IIDTIPOUSUARIO",
                table: "Usuario",
                column: "IIDTIPOUSUARIO");

            migrationBuilder.AddForeignKey(
                name: "FK__Cita__IIDDOCTORA__01142BA1",
                table: "Cita",
                column: "IIDDOCTORASIGNADO",
                principalTable: "Doctor",
                principalColumn: "IIDDOCTOR");

            migrationBuilder.AddForeignKey(
                name: "FK__Cita__IIDPERSONA__2739D489",
                table: "Cita",
                column: "IIDPERSONA",
                principalTable: "Persona",
                principalColumn: "IIDPERSONA");

            migrationBuilder.AddForeignKey(
                name: "FK__Cita__IIDUSUARIO__7C4F7684",
                table: "Cita",
                column: "IIDUSUARIO",
                principalTable: "Usuario",
                principalColumn: "IIDUSUARIO");

            migrationBuilder.AddForeignKey(
                name: "FK__Doctor__IIDPERSO__693CA210",
                table: "Doctor",
                column: "IIDPERSONA",
                principalTable: "Persona",
                principalColumn: "IIDPERSONA");

            migrationBuilder.AddForeignKey(
                name: "FK__Historial__IIDUS__09A971A2",
                table: "HistorialCita",
                column: "IIDUSUARIO",
                principalTable: "Usuario",
                principalColumn: "IIDUSUARIO");

            migrationBuilder.AddForeignKey(
                name: "FK__Persona__IIDUSUA__282DF8C2",
                table: "Persona",
                column: "IIDUSUARIO",
                principalTable: "Usuario",
                principalColumn: "IIDUSUARIO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Usuario__IIDPERS__14270015",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "CitaMedicamento");

            migrationBuilder.DropTable(
                name: "HistorialCita");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "TipoUsuarioPaginaBoton");

            migrationBuilder.DropTable(
                name: "Medicamento");

            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "TipoSangre");

            migrationBuilder.DropTable(
                name: "Boton");

            migrationBuilder.DropTable(
                name: "TipoUsuarioPagina");

            migrationBuilder.DropTable(
                name: "FormaFarmaceutica");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "EstadoCita");

            migrationBuilder.DropTable(
                name: "Pagina");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Sexo");

            migrationBuilder.DropTable(
                name: "TipoUsuario");
        }
    }
}
