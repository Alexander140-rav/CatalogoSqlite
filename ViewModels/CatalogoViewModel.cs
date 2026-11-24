using System.Collections.ObjectModel;
using CatalogoMaui.Models;
using CatalogoMaui.Services;

namespace CatalogoMaui.ViewModels;

public class CatalogoViewModel
{
    public ObservableCollection<Producto> Productos { get; } = new();

    public async Task CargarProductosAsync()
    {
        var lista = await ProductosSqlite.Instancia.Consultar();

        Productos.Clear();
        foreach (var item in lista)
        {
            Productos.Add(item);
        }
    }
}