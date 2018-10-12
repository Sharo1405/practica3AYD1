<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="diagrama_mod.aspx.cs" Inherits="diagrama.app.diagrama_mod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     
    <title>Hello World</title>

    <!-- required modeler styles -->
    <link rel="stylesheet" href="https://unpkg.com/bpmn-js@0.27.6/dist/assets/diagram-js.css">
    <link rel="stylesheet" href="https://unpkg.com/bpmn-js@0.27.6/dist/assets/bpmn-font/css/bpmn.css">

    <!-- modeler distro -->
    <script src="https://unpkg.com/bpmn-js@0.27.6/dist/bpmn-modeler.development.js"></script>

    <!-- needed for this example only -->
    <script src="https://unpkg.com/jquery@3.3.1/dist/jquery.js"></script>

    <!-- example styles -->
      <style>
          #canvas {
        height:500px;
        width: 1600px;
        padding: 0;
        margin: 0;
             
          }

      .diagram-note {
        background-color: rgba(66, 180, 21, 0.7);
        color: White;
        border-radius: 5px;
        font-family: Arial;
        font-size: 12px;
        padding: 5px;
        min-height: 16px;
        width: 150px;
        height: 20px;
        text-align: center;
      }

      .needs-discussion:not(.djs-connection) .djs-visual > :nth-child(1) {
        stroke: rgba(66, 180, 21, 0.7) !important; /* color elements as red */
      }

      #save-button {
        position: fixed;
        bottom: 20px;
        left: 20px;
      }
    </style>


<!-- estido div -------------------------------------------------------------------------------------------------->
     	<meta name="viewport" content="width=device-width, initial-scale=1"/>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css/">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css"/>
	<link rel="stylesheet" type="text/css" href="css/main.css"/>
</head>
<body>
    <form id="form1" runat="server">
   
           <div class="limiter">
		<div class="container-login100" style="background-image: url('images/bg-01.jpg');">
			<div class="wrap-login100_diagrama p-l-25 p-r-25 p-t-25 p-b-24">
			
					<span class="login100-form-title p-b-49">
						Crear proceso
					
					</span>

                	<div class="col-md-2" >
						 <div id="canvas">
        
                             </div>
					</div>
					
               
  
    <script>

     var diagramUrl = 'https://cdn.rawgit.com/bpmn-io/bpmn-js-examples/dfceecba/starter/diagram.bpmn';
     var diagramUrl = 'diagrama/diagrama_mod.txt';

   //  window.open('app3/diagram1.txt');
      // modeler instance
      var bpmnModeler = new BpmnJS({
        container: '#canvas',
        keyboard: {
          bindTo: window
        }
      });

      /**
       * Save diagram contents and print them to the console.
       */
      function exportDiagram() {

        bpmnModeler.saveXML({ format: true }, function(err, xml) {

          if (err) {
            return console.error('could not save BPMN 2.0 diagram', err);
          }

          alert('Diagrama generado');
          document.getElementById("<%=HiddenField1.ClientID%>").value = xml;



            var x = location.pathname;
            console.log(x);
        });
      }

      /**
       * Open diagram in our modeler instance.
       *
       * @param {String} bpmnXML diagram to display
       */
      function openDiagram(bpmnXML) {

        // import diagram
        bpmnModeler.importXML(bpmnXML, function(err) {

          if (err) {
            return console.error('could not import BPMN 2.0 diagram', err);
          }

          // access modeler components
          var canvas = bpmnModeler.get('canvas');
          var overlays = bpmnModeler.get('overlays');


          // zoom to fit full viewport
          canvas.zoom('fit-viewport');

          // attach an overlay to a node
          overlays.add('SCAN_OK', 'note', {
            position: {
              bottom: 0,
              right: 0
            },
            html: '<div class="diagram-note">Mixed up the labels?</div>'
          });

          // add marker
          canvas.addMarker('SCAN_OK', 'needs-discussion');
        });
      }


      // load external diagram file via AJAX and open it
         $.get(diagramUrl, openDiagram, 'text');

      // wire save button
    //  $('#save-button').click(exportDiagram);
    </script>

                		<div class="container-login100-form-btn">
		
                           <asp:button id="aceptar" runat="server"   CssClass="btn btn-success"  OnClientClick="exportDiagram();" Text="Siguiente " OnClick="aceptar_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click"  >
								
							</asp:Button>
                       
							
					</div>
      

 <asp:HiddenField ID="HiddenField1" runat="server" />

                	<div class="col-md-2" >
						 <asp:Panel ID="Panel1" runat="server" Height="407px" Width="443px"  >
                            </asp:Panel>
					</div>



					

					
					</div>
				
				</div>
		</div>

    
    </form>
</body>
</html>