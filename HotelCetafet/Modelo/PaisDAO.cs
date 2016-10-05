using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCetafet.Modelo
{
    public class PaisDAO
    {
        bdHotelCetafestConexao conexao;
        public PaisDAO()
        {
             conexao = new bdHotelCetafestConexao();
        }

        public List<Pais> getPaises()
        {
          
            return conexao.Pais.ToList();
        }

        public void x(Pais novoPais)
        {
            conexao.Pais.Add(novoPais);
            conexao.SaveChanges();
        }

        public List<Pais> getPaisLetraInicial(string iniciais)
        {

            return conexao.Pais.Where(x => x.nome.StartsWith(iniciais)).ToList();
        }


        public void setAtualizar(Pais pais) {
           
            conexao.Entry(pais).State = EntityState.Modified;
            conexao.SaveChanges();


        }

        public Pais getPais(int codigo)
        {
            return conexao.Pais.Where(x => x.codigo == codigo).First();

        }

        public void setApagar(Pais pais)
        {
           // conexao.Pais.Attach(pais);
            conexao.Pais.Remove(pais);
            conexao.SaveChanges();

        }


    }

   
}
