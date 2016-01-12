using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartup("Desenv", typeof(KatanaOwinHost.DesenvolvimentoStartup))]
[assembly: OwinStartup("Teste", typeof(KatanaOwinHost.TesteStartup))]
[assembly: OwinStartup("Prod", typeof(KatanaOwinHost.Producaoptartup))]

namespace KatanaOwinHost
{
    public class DesenvolvimentoStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                context.Response.WriteAsync("");
                return context.Response.WriteAsync("Vamos começar a desenvolver o nosso projeto? :D");
            });
        }
    }

    public class TesteStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                context.Response.WriteAsync("");
                return context.Response.WriteAsync("Ok, agora estou pronto para receber uma bateria de testes ");
            });
        }
    }

    public class Producaoptartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}