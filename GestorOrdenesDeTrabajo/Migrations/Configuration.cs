namespace GestorOrdenesDeTrabajo.Migrations
{
    using GestorOrdenesDeTrabajo.DB;
    using GestorOrdenesDeTrabajo.Enums;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GestorOrdenesDeTrabajo.DB.Entities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Entities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            if (!context.Database.Exists())
                return;

            if (context.Usuario.Any())
                return;

            InitUsuario(context);
            InitPermiso(context);
            InitClientes(context);
            InitMecanico(context);
            InitRefaccion(context);
            InitOrden(context);
            InitOrdenMecanico(context);
            InitOrdenRefaccion(context);
            InitOrdenRefaccionGarantia(context);
        }

        private void InitUsuario(Entities db)
        {
            var usuarios = new Usuario[]
            {
                new Usuario
                {
                    Usuario1="Alberto",
                    Password="123",
                },
                new Usuario
                {
                    Usuario1="Admin",
                    Password="123",
                },
                new Usuario
                {
                    Usuario1="Ramiro",
                    Password="123",
                },
                new Usuario
                {
                    Usuario1="Usuario",
                    Password="123",
                },
            };
            foreach (var item in usuarios)
            {
                db.Usuario.Add(item);
                db.SaveChanges();
            }
        }

        private void InitPermiso(Entities db)
        {
            var permisos = new Permiso[]
            {
                new Permiso
                {
                    Descripcion="Ejemplo",
                    IsEnabled=true,
                },
            };

            foreach (var item in permisos)
            {
                db.Permiso.Add(item);
                db.SaveChanges();
            }
        }

        private void InitClientes(Entities db)
        {
            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nombre = "Juan Espinoza ramirez",
                    Direccion = "Periban de ramos",
                    Telefono = "3541022372",
                },
                new Cliente
                {
                    Nombre = "Andrea Ayala Galvan",
                    Direccion = "Periban de ramos",
                    Telefono = "3541022372",
                },
                new Cliente
                {
                    Nombre = "Francisco Cisneros Lopez",
                    Direccion = "Los reyes de salgado",
                    Telefono = "3541022372",
                },
            };

            foreach (var item in clientes)
            {
                db.Cliente.Add(item);
                db.SaveChanges();
            }
        }

        private void InitMecanico(Entities db)
        {
            var mecanicos = new Mecanico[]
            {
                new Mecanico
                {
                    Nombre="Juanito"
                },
                new Mecanico
                {
                    Nombre="Termy"
                },
                new Mecanico
                {
                    Nombre="Mecanico"
                }
            };
            foreach (var item in mecanicos)
            {
                db.Mecanico.Add(item);
                db.SaveChanges();
            }
        }
        private void InitRefaccion(Entities db)
        {
            var refacciones = new Refaccion[]
            {
               new Refaccion
               {
                   Codigo="1",
                   Descripcion="Tijeras",
                   IsDeleted=false,
                   PrecioMinimo=12.00M,
               },
                new Refaccion
               {
                   Codigo="1",
                   Descripcion="Rodillo",
                   IsDeleted=false,
                   PrecioMinimo=12.00M,
               },
                new Refaccion
               {
                   Codigo="1",
                   Descripcion="Desarmadores",
                   IsDeleted=false,
                   PrecioMinimo=12.00M,
               },
                new Refaccion
               {
                   Codigo="1",
                   Descripcion="Eliminado",
                   IsDeleted=true,
                   PrecioMinimo=12.00M,
               },
            };
            foreach (var item in refacciones)
            {
                db.Refaccion.Add(item);
                db.SaveChanges();
            }
        }

        private void InitOrden(Entities db)
        {
            var ordenes = new Orden[]
            {
                new Orden
                {
                   Folio=123,
                   FechaRecepcion=DateTime.Now,
                   Equipo="Parihuela",
                   Observaciones="Falla en piston",
                   Status=(int)OrdenStatus.ESPERA,
                   IdCliente=1,
                },
            };

            foreach (var item in ordenes)
            {
                db.Orden.Add(item);
                db.SaveChanges();
            }
        }

        private void InitOrdenRefaccion(Entities db)
        {
            var ordenRefacciones = new OrdenRefaccion[]
            {
                new OrdenRefaccion
                {
                    IdOrden=1,
                    IdRefaccion=1
                },
                new OrdenRefaccion
                {
                    IdOrden=1,
                    IdRefaccion=2
                },
                new OrdenRefaccion
                {
                    IdOrden=1,
                    IdRefaccion=3
                },
                new OrdenRefaccion
                {
                    IdOrden=1,
                    IdRefaccion=4
                },
            };
            foreach (var item in ordenRefacciones)
            {
                db.OrdenRefaccion.Add(item);
                db.SaveChanges();
            }
        }
        private void InitOrdenRefaccionGarantia(Entities db)
        {
            var ordenRefacciones = new OrdenRefaccionGarantia[]
            {
                new OrdenRefaccionGarantia
                {
                    IdOrden=1,
                    IdRefaccion=4
                }
            };
            foreach (var item in ordenRefacciones)
            {
                db.OrdenRefaccionGarantia.Add(item);
                db.SaveChanges();
            }
        }

        private void InitOrdenMecanico(Entities db)
        {
            var ordenMecanico = new OrdenMecanico[]
            {
               new OrdenMecanico
               {
                   IdOrden=1,
                   IdMecanico=1
               },
            };

            foreach (var item in ordenMecanico)
            {
                db.OrdenMecanico.Add(item);
                db.SaveChanges();
            }
        }

        private void InitPermisoUsuaro(Entities db)
        {
            var permisoUsuario = new UsuarioPermiso[]
            {
                new UsuarioPermiso
                {
                    IdPermiso=1,
                    IdUsuario=1
                },
            };
            foreach (var item in permisoUsuario)
            {
                db.UsuarioPermiso.Add(item);
                db.SaveChanges();
            }
        }
    }
}