using AlphaLib.Models;
using System.Collections.Generic;

namespace AlphaLib.Interfaces
{
    public interface IFabrica
    {
        Carro Carro { get; set; }
        int Entregues { get; set; }
        List<string> ListaCarrosEntregues { get; set; }
        void CriarCarro();
        void PintarCarro(string color);
        void MudarMarca(string marca);
        void MudarModelo(string modelo);
        void MudarAno(int ano);
        void EntregarCarro();
    }
}
