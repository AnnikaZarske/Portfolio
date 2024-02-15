using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Components.Layout
{
    public class PortfolioTheme
    {
        public static MudTheme theme = new MudTheme()
        {
            Palette = new PaletteLight()
            {
                Primary = "#F5DD89",
                Secondary = "#ADA0C9",
            },
            PaletteDark = new PaletteDark()
            {
                //Primary = Colors.Blue.Lighten1
            },
            Typography = new Typography()
            {
                
            },
            LayoutProperties = new LayoutProperties()
            {
                //DrawerWidthLeft = "260px",
                //DrawerWidthRight = "300px"
            }
        };
    }
}
