using System.Collections.Generic;
using CatalogoMaui.Models;

namespace CatalogoMaui.ViewModels;

public class CatalogoViewModel
{
    // Cada objeto de esta lista se convertirá en una tarjeta.
    public List<Producto> Productos { get; } = new()
    {
        new Producto
        {
            Nombre = "Audífonos inalámbricos",
            Descripcion = "Cancelación activa de ruido y batería de 30 horas.",
            Precio = 1299.00m,
            Detalle = "Audífonos con conexión Bluetooth 5.3, cancelación activa de ruido, micrófono integrado para llamadas y estuche rígido de transporte.",
            Foto = "audifonos.webp"
        },
        new Producto
        {
            Nombre = "Teclado mecánico RGB",
            Descripcion = "Switches táctiles e iluminación personalizable.",
            Precio = 950.00m,
            Detalle = "Teclado compacto con interruptores mecánicos de respuesta rápida, retroiluminación RGB por tecla, cable USB-C desmontable y base de aluminio.",
            Foto = "teclado.jpg"
        },
        new Producto
        {
            Nombre = "Mouse gamer ergonómico",
            Descripcion = "Sensor óptico de alta precisión hasta 16,000 DPI.",
            Precio = 649.00m,
            Detalle = "Ratón ultraligero con 6 botones, sensibilidad ajustable en tiempo real, deslizadores de baja fricción y cable trenzado flexible.",
            Foto = "mouse.jpg"
        },
        new Producto
        {
            Nombre = "Monitor LED 24 pulgadas",
            Descripcion = "Resolución Full HD con tasa de refresco de 144 Hz.",
            Precio = 3499.00m,
            Detalle = "Pantalla IPS de 24 pulgadas sin bordes con resolución 1920x1080, tiempo de respuesta de 1 ms, puertos HDMI y DisplayPort, y soporte inclinable.",
            Foto = "monitor.jpg"
        }
    };
}