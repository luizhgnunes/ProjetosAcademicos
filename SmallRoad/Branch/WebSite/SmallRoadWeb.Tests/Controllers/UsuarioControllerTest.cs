using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallRoadWeb.Models.Entities;
using SmallRoadWeb.Controllers;

namespace SmallRoadWeb.Tests.Controllers
{
    [TestClass]
    public class UsuarioControllerTest
    {
        [TestMethod]
        public void Logar()
        {
            Usuario usuario = new Usuario();
            usuario.Login = "luizhgnunes";
            usuario.Senha = "123456";

            UsuarioController uc = new UsuarioController();
            Assert.IsTrue(uc.Logar(usuario));
        }

        [TestMethod]
        public void LogarSenhaErrada()
        {
            Usuario usuario = new Usuario();
            usuario.Login = "luizhgnunes";
            usuario.Senha = "1234567";

            UsuarioController uc = new UsuarioController();
            Assert.IsFalse(uc.Logar(usuario));
        }
    }
}
