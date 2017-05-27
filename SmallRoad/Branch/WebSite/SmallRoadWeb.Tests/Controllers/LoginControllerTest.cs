using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallRoadWeb;
using SmallRoadWeb.Controllers;
using SmallRoadWeb.Models.Entities;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace SmallRoadWeb.Tests.Controllers
{
    [TestClass]
    public class LoginControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            LoginController controller = new LoginController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        //[WebMethod(EnableSession = true)]
        public void Logar()
        {
            Usuario usuario = new Usuario();
            usuario.Login = "luizhgnunes";
            usuario.Senha = "123456";

            LoginController lc = new LoginController();
            JObject o = JObject.Parse(JsonConvert.SerializeObject(lc.Logar(usuario)));
            Usuario usu = o["Data"].ToObject<Usuario>();

            Assert.IsTrue(usu.Login.Equals(usuario.Login));
        }

        [TestMethod]
        //[WebMethod(EnableSession = true)]
        public void LogarSenhaErrada()
        {
            Usuario usuario = new Usuario();
            usuario.Login = "luizhgnunes";
            usuario.Senha = "1234567";

            UsuarioController uc = new UsuarioController();
            //Assert.IsFalse(uc.Logar(usuario));
        }
    }
}
