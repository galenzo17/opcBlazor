// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\OpceClient.razor"
using Opc.Ua;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\OpceClient.razor"
using Opc.Ua.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\OpceClient.razor"
using Opc.Ua.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\OpceClient.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/OpcClient")]
    public partial class OpceClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\usuario\source\repos\OPCBlazor\OPCBlazor\Pages\OpceClient.razor"
       
    public string datovariable { get; set; }
    public string datoguardable{ get; set; }
    public string endpointOpcserver {get;set;}="opc.tcp://10.77.0.220:49320";
    public string direcciondevariablealeer{get;set;}="ns=2;s=Channel1.holandavo.arbitrario";
    public string direcciondevariableaescribir{get;set;}="ns=2;s=Channel1.holandavo.Palabra";
    public DataValue valoractua = new DataValue();
    public Session session;
    public MonitoredItem itemtosee;
    public bool boolvalue { get; set; }
    public record datorecord
    {
        public string Nombre { get; init; }
        public int valor { get; init; }
    }
    public List<datorecord> datorecords=new List<datorecord>();
    public datorecord variable {get;}
    protected override async Task OnInitializedAsync()
    {
        /*
        var adedrecord = new datorecord { Nombre = "", valor = 2 };
        var otherPerson = adedrecord with { Nombre = "Torgersen" };

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


        //step 2: creating session with the OPC server
        session = Session.Create(config,
            new ConfiguredEndpoint(null, new EndpointDescription("opc.tcp://10.77.0.220:49320")),
            true,
            "",
            60000,
            null,
            null).Result;  //EndpointDescription need to be changed according to your OPC server

        // Console.WriteLine("session created");


        ////step 3: Browsing the Server Name Space0
        ReferenceDescriptionCollection refs;
        byte[] cp;

        session.Browse(
            null,
            null,
            ObjectIds.ObjectsFolder,
            0u,
            BrowseDirection.Forward,
            ReferenceTypeIds.HierarchicalReferences,
            true,
            (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method,
            out cp,
            out refs);

        ////testing read of Scalar value
        var node = session.ReadValue(new NodeId("ns=2;s=Channel1.holandavo.arbitrario")).ToString();
        Console.WriteLine(".........................." + node + "...................................");

        datovariable = node;

        //  Console.WriteLine("DisplayName: BrowseName, NodeClass");
        foreach (var rd in refs)
        {
            Console.WriteLine("{0}: {1}, {2}", rd.DisplayName, rd.BrowseName, rd.NodeClass);
            ReferenceDescriptionCollection nextRefs;
            byte[] nextCp;
            session.Browse(
                    null,
                    null,
                    ExpandedNodeId.ToNodeId(rd.NodeId, session.NamespaceUris),
                    0u,
                    BrowseDirection.Forward,
                    ReferenceTypeIds.HierarchicalReferences,
                    true,
                    (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method,
                    out nextCp,
                    out nextRefs);

            foreach (var nextRd in nextRefs)
            {
                // Console.WriteLine("+ {0}: {1}, {2}:{3}", nextRd.DisplayName, nextRd.BrowseName, nextRd.NodeClass, nextRd.NodeId);
                //Console.WriteLine();

                //Nested browsing
                ReferenceDescriptionCollection nextRefs2;
                byte[] nextCp2;
                session.Browse(
                            null,
                            null,
                            ExpandedNodeId.ToNodeId(rd.NodeId, session.NamespaceUris),
                            0u,
                            BrowseDirection.Forward,
                            ReferenceTypeIds.HierarchicalReferences,
                            true,
                            (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method,
                            out nextCp2,
                            out nextRefs2);

                foreach (var nextRd2 in nextRefs2)
                {
                    
                }
            }
        }
        //step 4: create a subscription at an specific interval
        var subscription = new Subscription(session.DefaultSubscription)
        {
            PublishingInterval = 1000
        };
        //Console.WriteLine("subscription created");


        //adding items to moniter into the subscription
        var list = new List<MonitoredItem> {
                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "Channel1.holandavo.arbitrario",
                    StartNodeId = "i=2"
                }
            };

        Console.WriteLine("Moniterd Items are added to the list");

        foreach (var item in list)
        {
            // item.Notification += OnNotification;
            Console.WriteLine($"77777777777777 {item.LastValue}");
        }
        
        

        MonitoredItem stringMonitoredItem = new MonitoredItem(subscription.DefaultItem);
        
        stringMonitoredItem.StartNodeId = new NodeId("ns=2;s=Channel1.holandavo.arbitrario");
        stringMonitoredItem.AttributeId = Attributes.Value;
        stringMonitoredItem.DisplayName = "String Variable";
        stringMonitoredItem.SamplingInterval = 1000;
        stringMonitoredItem.Notification += OnNotification;
        list.Add(stringMonitoredItem);

        list.ForEach(i => i.Notification += OnNotification);
        subscription.AddItems(list);

        //adding subscription to the session
        session.AddSubscription(subscription);
        subscription.Create();
        subscription.ApplyChanges();
        Console.WriteLine(subscription.NotificationCount);


*/
    }
    public void WriteNodes()
    {


        try
        {
            // Write the configured nodes
            WriteValueCollection nodesToWrite = new WriteValueCollection();
            /*
            // Int32 Node - Objects\CTT\Scalar\Scalar_Static\Int32
            WriteValue intWriteVal = new WriteValue();
            intWriteVal.NodeId = new NodeId("ns=2;s=Scalar_Static_Int32");
            intWriteVal.AttributeId = Attributes.Value;
            intWriteVal.Value = new DataValue();
            intWriteVal.Value.Value = (int)100;
            nodesToWrite.Add(intWriteVal);

            // Float Node - Objects\CTT\Scalar\Scalar_Static\Float
            WriteValue floatWriteVal = new WriteValue();
            floatWriteVal.NodeId = new NodeId("ns=2;s=Scalar_Static_Float");
            floatWriteVal.AttributeId = Attributes.Value;
            floatWriteVal.Value = new DataValue();
            floatWriteVal.Value.Value = (float)100.5;
            nodesToWrite.Add(floatWriteVal);
            */
            // String Node - Objects\CTT\Scalar\Scalar_Static\String<<<<<<"ns=2;s=Channel1.holandavo.Palabra"
            WriteValue stringWriteVal = new WriteValue();
            stringWriteVal.NodeId = new NodeId(direcciondevariableaescribir);
            stringWriteVal.AttributeId = Attributes.Value;
            stringWriteVal.Value = new DataValue();
            stringWriteVal.Value.Value = datoguardable;
            nodesToWrite.Add(stringWriteVal);

            // Write the node attributes
            StatusCodeCollection results = null;
            DiagnosticInfoCollection diagnosticInfos;
            Console.WriteLine("Writing nodes...");

            // Call Write Service
            session.Write(null,
                            nodesToWrite,
                            out results,
                            out diagnosticInfos);

            // Validate the response
            ClientBase.ValidateResponse(results, nodesToWrite);

            // Display the results.
            Console.WriteLine("Write Results :");

            foreach (StatusCode writeResult in results)
            {
                Console.WriteLine("     {0}", writeResult);
            }
        }
        catch (Exception ex)
        {
            // Log Error
            string logMessage = String.Format("Write Nodes Error : {0}.", ex.Message);
            Console.WriteLine(logMessage);
        }
    }
    public async Task OnConectOpcServer()
    {
        var adedrecord = new datorecord { Nombre = "", valor = 2 };
        var otherPerson = adedrecord with { Nombre = "Torgersen" };

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
        session = Session.Create(config,
            new ConfiguredEndpoint(null, new EndpointDescription(endpointOpcserver)),
            true,
            "",
            60000,
            null,
            null).Result; 
        ReferenceDescriptionCollection refs;
        byte[] cp;
        session.Browse(
            null,
            null,
            ObjectIds.ObjectsFolder,
            0u,
            BrowseDirection.Forward,
            ReferenceTypeIds.HierarchicalReferences,
            true,
            (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method,
            out cp,
            out refs);
        ////testing read of Scalar value<<<<<<<<<<<<<<<"ns=2;s=Channel1.holandavo.arbitrario"
        var node = session.ReadValue(new NodeId(direcciondevariablealeer)).ToString();
        Console.WriteLine(".........................." + node + "...................................");
        datovariable = node;
        foreach (var rd in refs)
        {
            Console.WriteLine("{0}: {1}, {2}", rd.DisplayName, rd.BrowseName, rd.NodeClass);
            ReferenceDescriptionCollection nextRefs;
            byte[] nextCp;
            session.Browse(
                    null,
                    null,
                    ExpandedNodeId.ToNodeId(rd.NodeId, session.NamespaceUris),
                    0u,
                    BrowseDirection.Forward,
                    ReferenceTypeIds.HierarchicalReferences,
                    true,
                    (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method,
                    out nextCp,
                    out nextRefs);

            foreach (var nextRd in nextRefs)
            {
                ReferenceDescriptionCollection nextRefs2;
                byte[] nextCp2;
                session.Browse(
                            null,
                            null,
                            ExpandedNodeId.ToNodeId(rd.NodeId, session.NamespaceUris),
                            0u,
                            BrowseDirection.Forward,
                            ReferenceTypeIds.HierarchicalReferences,
                            true,
                            (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method,
                            out nextCp2,
                            out nextRefs2);
            }
        }
        var subscription = new Subscription(session.DefaultSubscription)
        {
            PublishingInterval = 1000
        };
        var list = new List<MonitoredItem> {
                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "Channel1.holandavo.arbitrario",
                    StartNodeId = "i=2"
                }
            };
        MonitoredItem stringMonitoredItem = new MonitoredItem(subscription.DefaultItem);
        stringMonitoredItem.StartNodeId = new NodeId("ns=2;s=Channel1.holandavo.arbitrario");
        stringMonitoredItem.AttributeId = Attributes.Value;
        stringMonitoredItem.DisplayName = "String Variable";
        stringMonitoredItem.SamplingInterval = 1000;
        stringMonitoredItem.Notification += OnNotification;
        list.Add(stringMonitoredItem);
        list.ForEach(i => i.Notification += OnNotification);
        subscription.AddItems(list);
        session.AddSubscription(subscription);
        subscription.Create();
        subscription.ApplyChanges();
        Console.WriteLine(subscription.NotificationCount);
    }
    public void getchangues(MonitoredItem item)
    {
        Console.WriteLine("data recieved");
        foreach (var value in item.DequeueValues())
        {

            Console.WriteLine("data recieved");
            //Console.WriteLine("{0}: {1}, {2}, {3}, {4}", item.DisplayName, value.Value, value.SourceTimestamp, value.StatusCode,value.StatusCode);
        }
    }
    public void OnNotification(MonitoredItem item, MonitoredItemNotificationEventArgs e)
    {
        MonitoredItemNotification notification = e.NotificationValue as MonitoredItemNotification;
        //Console.WriteLine("Notification Received for Variable \"{0}\" and Value = {1}.", item.DisplayName, notification.Value);
        if(item.DisplayName== "Buleano1")
        {
            boolvalue = (bool)notification.Value.Value;
            Console.WriteLine("boolvalue {0}.", boolvalue);
        }
        var recordtype = new datorecord { Nombre = notification.Value.ToString(), valor = 2 };
        datorecords.Add(recordtype);
        //variable = recordtype with { Nombre = "Torgersen" };
        datovariable = notification.Value.ToString();
        InvokeAsync(StateHasChanged);
        // StateHasChanged();
        /*
        datovariable = item.DequeueValues().ToString();
        foreach (var value in item.DequeueValues())
        {

            Console.WriteLine("data recieved");
            //Console.WriteLine("{0}: {1}, {2}, {3}, {4}", item.DisplayName, value.Value, value.SourceTimestamp, value.StatusCode,value.StatusCode);
        }
        */
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
