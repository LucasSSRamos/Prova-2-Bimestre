using Revisao.Application.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface IMegaSenaServices
    {
        Task<IEnumerable<MegaSenaViewModel>> ObterTodosOsJogos(MegaSenaViewModel megaSena);

        void RegistrarJogo(NovoRegistroMegaSenaViewModel megasena);
    }
}
