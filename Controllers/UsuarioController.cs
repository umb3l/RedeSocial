using System;
using System.Web.Mvc;
using RedeSocial.Models;
using RedeSocial.Controllers.Data.DAO;
using System.Data;
using System.Windows.Forms;

namespace RedeSocial.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO usuarioDAO = new UsuarioDAO();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nick, string nome, string senha, string bio, Boolean privacidade)
        {
            try
            {
                Usuario u = new Usuario();
                u.Nome = nome;
                u.Nick = nick;
                u.Senha = senha;
                u.Bio = bio;
                u.Privacidade = privacidade;
                usuarioDAO.Registrar(u);

            }
            catch (Exception e){

                MessageBox.Show("Preencha os dados corretamente!");
                return View();
            }

            MessageBox.Show("Registrado com sucesso!");
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        public ActionResult Login(string nickLogin, string senhaLogin)
        {
            try
            {
                Usuario usuarioLogado = new Usuario();
                usuarioLogado = usuarioDAO.Login(nickLogin, senhaLogin);
                ViewBag.UsuarioLogado = usuarioLogado;
            }
            catch (Exception e)
            {
                MessageBox.Show("Usuário ou senha incorretos");
                return View("Login");
            }

            return View("Home");
        }

        public ActionResult Home()
        {
            return View("Home");
        }
    }
}