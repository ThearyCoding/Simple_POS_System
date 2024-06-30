using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_POS_system
{
    // This class is for adding different pages to the main page 
    internal class RouteConfig
    {

        private List<UserControl> routes= new List<UserControl>();

        private Panel controlPanel;
        

        public RouteConfig(List<UserControl> routes,Panel controlPanel ) {
        
            this.routes = routes;
            this.controlPanel  =  controlPanel;       
            callRoutes();
        }

        // Add every route and filling the gap in the form
        private void callRoutes()
        {
            for(int i = 0; i < routes.Count; i++) {

                routes[i].Dock = DockStyle.Fill;
                controlPanel.Controls.Add(routes[i]);

            }
        }

        // display the active route page
        public void displayRoute(int index)
        {
            if( index  <  routes.Count )
            {
                routes[index].BringToFront();

            }
        }
    }
}
