using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.DataCad = DateTime.Now;
                Banco(cliente);
                return View("Resultado", cliente);
            }
            return View(cliente);
        }
        public void Banco(Cliente cliente)
        {
            SqlConnection minhaConexao = new SqlConnection(@"data source=DESKTOP-UVUVP4T\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=WebApplication5");
            minhaConexao.Open();
            string x = string.Format ("INSERT INTO CLIENTES (Nome, CPF, Nacionalidade, Naturalidade, DataCad, Ativo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",cliente.Nome,cliente.CPF,cliente.Nacionalidade,cliente.Naturalidade,cliente.DataCad,cliente.Ativo);
            SqlCommand cmd = new SqlCommand(x,minhaConexao);
            cmd.ExecuteNonQuery();
        }
    }
}