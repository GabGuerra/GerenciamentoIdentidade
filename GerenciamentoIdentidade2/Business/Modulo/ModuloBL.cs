using GerenciamentoIdentidade2.DataAcess;
using GerenciamentoIdentidade2.DataAcess.Modulo;
using GerenciamentoIdentidade2.Models.Modulo;
using GerenciamentoIdentidade2.Models.Shared;
using System;

namespace GerenciamentoIdentidade2.Business.Modulo
{
    public class ModuloBL
    {
        //TODO: implementar Idisposable
        private ModuloDAO dao;
        public ModuloBL()
        {
            dao = new ModuloDAO();
        }

        public ResultadoVD InserirModulo(ModuloVD modulo)
        {
            ResultadoVD resultado = new ResultadoVD(true);

            try
            {                
                dao.InserirModulo(modulo);
            }
            catch (Exception ex)
            {
                resultado.Sucesso = false;
                resultado.Mensagem = $"Não foi possível criar a conta. {Environment.NewLine} {ex.Message}";
            }

            return resultado;
        }

    }
}