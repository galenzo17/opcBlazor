#pragma checksum "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356b295c5f748e9570b1e577a59bf6d3ed9feacb"
// <auto-generated/>
#pragma warning disable 1591
namespace OPCBlazor.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using OPCBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\_Imports.razor"
using OPCBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
using Opc.Ua;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
using Opc.Ua.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
using Opc.Ua.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
 if (listofchannels != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "ul");
#nullable restore
#line 11 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
         foreach (var detail in listofchannels)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "li");
            __builder.AddContent(2, 
#nullable restore
#line 13 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
             detail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
 if (subscribevalue != null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 19 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
     subscribevalue

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
                                     subscribevalue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => subscribevalue = __value, subscribevalue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<h1>Error subscribevalue...</h1>");
#nullable restore
#line 25 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
 if (m_subscription != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "ul");
            __builder.OpenElement(10, "li");
            __builder.AddContent(11, 
#nullable restore
#line 29 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
             m_subscription.Id.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<h1>Error subscription...</h1>");
#nullable restore
#line 36 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
 if (monitoredItem != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "ul");
            __builder.OpenElement(14, "li");
            __builder.AddContent(15, 
#nullable restore
#line 41 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
             monitoredItem.DisplayName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
    
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<h1>Error monitoritem...</h1>");
#nullable restore
#line 48 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\Index.razor"
      

    public List<string> listofchannels = new List<string>();
    public List<string> listofdetails = new List<string>();
    private Subscription m_subscription;
    private MonitoredItem monitoredItem;
    // private SubscriptionOutput outputWindow;
    public string subscribevalue { get; set; }
    public Session session;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {

        }
    }
    protected override async Task OnInitializedAsync()
    {
        System.Diagnostics.Debug.WriteLine("Configuring UA Client");
        var config = new ApplicationConfiguration()
        {
            ApplicationName = "BatchPlantClient",
            ApplicationUri = Utils.Format(@"urn:{0}:BatchPlantClient", System.Net.Dns.GetHostName()),
            ApplicationType = ApplicationType.Client,
            SecurityConfiguration = new SecurityConfiguration
            {
                ApplicationCertificate = new CertificateIdentifier { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\MachineDefault", SubjectName = "BatchPlantClient" },
                TrustedIssuerCertificates = new CertificateTrustList { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Certificate Authorities" },
                TrustedPeerCertificates = new CertificateTrustList { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Applications" },
                RejectedCertificateStore = new CertificateTrustList { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\RejectedCertificates" },
                AutoAcceptUntrustedCertificates = true
            },
            TransportConfigurations = new TransportConfigurationCollection(),
            TransportQuotas = new TransportQuotas { OperationTimeout = 15000 },
            ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 },
            TraceConfiguration = new TraceConfiguration()
        };
        config.Validate(ApplicationType.Client).GetAwaiter().GetResult();
        if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
        {
            config.CertificateValidator.CertificateValidation += (s, e) => { e.Accept = (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted); };
        }


        var application = new ApplicationInstance
        {
            ApplicationName = "BatchPlantClient",
            ApplicationType = ApplicationType.Client,
            ApplicationConfiguration = config
        };

        application.CheckApplicationInstanceCertificate(false, 2048).GetAwaiter().GetResult();

        var selectedEndpoint = CoreClientUtils.SelectEndpoint("opc.tcp://127.0.0.1:49320", useSecurity: true);


        session = Session
            .Create(config, new ConfiguredEndpoint(null, selectedEndpoint,
            EndpointConfiguration.Create(config)), false, "", 60000, null, null)
            .GetAwaiter()
            .GetResult();

        //System.Diagnostics.Debug.WriteLine("Step 3 - Browse the server namespace.");
        ReferenceDescriptionCollection refs;
        Byte[] cp;
        session.Browse(null, null, ObjectIds.ObjectsFolder, 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable |
            (uint)NodeClass.Object | (uint)NodeClass.Method, out cp, out refs);
        // Console.WriteLine("DisplayName: BrowseName, NodeClass");
        foreach (var rd in refs)
        {
            //System.Diagnostics.Debug.WriteLine("{0}: {1}, {2}", rd.DisplayName, rd.BrowseName, rd.NodeClass, rd.NodeId);
            listofchannels.Add(rd.DisplayName.ToString());

            ReferenceDescriptionCollection nextRefs;
            byte[] nextCp;
            session.Browse(null, null, ExpandedNodeId.ToNodeId(rd.NodeId, session.NamespaceUris), 0u, BrowseDirection.Forward,
                ReferenceTypeIds.HierarchicalReferences, true, (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out nextCp, out nextRefs);



            foreach (var nextRd in nextRefs)
            {
              //  System.Diagnostics.Debug.WriteLine("+ {0}: {1}, {2}", nextRd.DisplayName, nextRd.BrowseName, nextRd.NodeClass, nextRd.NodeId);

                try
                {
                    var _node = ExpandedNodeId.ToNodeId(nextRd.NodeId, session.NamespaceUris);
                    DataValue dv2 = session.ReadValue(_node);
                   // Console.WriteLine("acaaaaaaaaaaaaaaaa "+nextRd.NodeId);
                    listofdetails.Add(dv2.ToString());
                }
                catch(Exception ex)
                {

                }

            }
        }
        /*
        DataValue dv1 = session.ReadValue("ns=2;s=Channel1.halandavo.Tag1");
        listofdetails.Add("acaaaaaaa : "+dv1.ToString());
        */
        if (m_subscription == null)
        {
            m_subscription = new Subscription(session.DefaultSubscription);

            m_subscription.PublishingEnabled = true;
            m_subscription.PublishingInterval = 100;

            session.AddSubscription(m_subscription);
            m_subscription.Create();
        }
        if (monitoredItem == null)
        {
            monitoredItem = new MonitoredItem(m_subscription.DefaultItem);
            monitoredItem.StartNodeId =
            monitoredItem.AttributeId = Attributes.Value;
            monitoredItem.MonitoringMode = MonitoringMode.Reporting;
            monitoredItem.SamplingInterval = 1000;
            monitoredItem.QueueSize = 0;
            monitoredItem.DiscardOldest = true;
            // define event handler for this item, and then add to subscription
            // monitoredItem.Notification += new MonitoredItemNotificationEventHandler(monitoredItem_Notification);
            m_subscription.AddItem(monitoredItem);
            m_subscription.ApplyChanges();

        }

        
    }
    public void monitoredItem_Notification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
    {
        /*
        if (this.InvokeRequired)
        {
            this.BeginInvoke(new MonitoredItemNotificationEventHandler(monitoredItem_Notification), monitoredItem, e);
            return;
        }
        */


        MonitoredItemNotification notification = e.NotificationValue as MonitoredItemNotification;
        if (notification == null)
        {
            System.Diagnostics.Debug.WriteLine("notification null");
            return;
        }
        subscribevalue = "value: " + Utils.Format("{0}", notification.Value.WrappedValue.ToString()) +
          ";\nStatusCode: " + Utils.Format("{0}", notification.Value.StatusCode.ToString()) +
          ";\nSource timestamp: " + notification.Value.SourceTimestamp.ToString() +
          ";\nServer timestamp: " + notification.Value.ServerTimestamp.ToString();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
