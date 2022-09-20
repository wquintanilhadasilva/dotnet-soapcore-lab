﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;

namespace ClassLibStandard
{
    [DataContract]
    [ExcludeFromCodeCoverage]
    public class Documento
    { 
         
        [DataMember]
        public string Tipo
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string IdProcedimento
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string ProtocoloProcedimento
        {
            get;
            set;
        }

        /// <remarks/>
        public string IdSerie
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string Numero
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string Data
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string Descricao
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string IdTipoConferencia
        {
            get;
            set;
        }
         
        /// <remarks/>
        [DataMember]
        public string Observacao
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string NomeArquivo
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string NivelAcesso
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string IdHipoteseLegal
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string Conteudo
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public byte[] ConteudoMTOM
        {
            get;
            set;
        }

        /// <remarks/>
        [DataMember]
        public string IdArquivo
        {
            get;
            set;
        }
         
        /// <remarks/>
        [DataMember]
        public string SinBloqueado
        {
            get;
            set;
        }
        
        [DataMember]
        public string SiglaSistema { get; set; }
       
        [DataMember]
        public string IdentificacaoServico { get; set; }
      
        [DataMember]
        public string IdUnidade { get; set; }

        public string ToSoapEnvelop()
        {
            return @$"<soapenv:Envelope
                                    xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""
                                    xmlns:xsd=""http://www.w3.org/2001/XMLSchema""
                                    xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/""
                                    xmlns:sei=""Sei""
                                    xmlns:soapenc=""http://schemas.xmlsoap.org/soap/encoding/"">
                                    <soapenv:Header/>
                                    <soapenv:Body>
                                        <sei:incluirDocumento soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
                                            <SiglaSistema xsi:type=""xsd:string"">{this.SiglaSistema}</SiglaSistema>
                                            <IdentificacaoServico xsi:type=""xsd:string"">{this.IdentificacaoServico}</IdentificacaoServico>
                                            <IdUnidade xsi:type=""xsd:string"">{this.IdUnidade}</IdUnidade>
                                                <Documento xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
		                                            <Conteudo>{this.Conteudo}</Conteudo>
		                                            <Data>{this.Data}</Data> 
		                                            <ProtocoloProcedimento xsi:type=""xsd:string"">{this.ProtocoloProcedimento}</ProtocoloProcedimento>
		                                            <IdSerie>{this.IdSerie}</IdSerie>
		                                            <NivelAcesso>{this.NivelAcesso}</NivelAcesso>
		                                            <NomeArquivo>{this.NomeArquivo}</NomeArquivo>
		                                            <Tipo>{this.Tipo}</Tipo>
		                                        </Documento>
                                        </sei:incluirDocumento>
                                    </soapenv:Body>
                                </soapenv:Envelope>";
        }
    }

}



/**


string soapEnvelop = @"<soapenv:Envelope
                                    xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""
                                    xmlns:xsd=""http://www.w3.org/2001/XMLSchema""
                                    xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/""
                                    xmlns:sei=""Sei""
                                    xmlns:soapenc=""http://schemas.xmlsoap.org/soap/encoding/"">
                                    <soapenv:Header/>
                                    <soapenv:Body>
                                        <sei:incluirDocumento soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
                                            <SiglaSistema xsi:type=""xsd:string"">SIS_RABDIGITAL</SiglaSistema>
                                            <IdentificacaoServico xsi:type=""xsd:string"">SERV_RABDIGITAL</IdentificacaoServico>
                                            <IdUnidade xsi:type=""xsd:string"">110000072</IdUnidade>
                                           <Documento xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
		                                  <Conteudo>DQo8IURPQ1RZUEUgaHRtbD4NCjxodG1sPg0KPGhlYWQ+DQogICAgPG1ldGEgaHR0cC1lcXVpdj0iQ29udGVudC1UeXBlIiBjb250ZW50PSJ0ZXh0L2h0bWw7Y2hhcnNldD1VVEYtOCI+DQogICAgPG1ldGEgaHR0cC1lcXVpdj0iWC1VQS1Db21wYXRpYmxlIiBjb250ZW50PSJJRT1lZGdlIiAvPg0KICAgIDxtZXRhIG5hbWU9InZpZXdwb3J0IiBjb250ZW50PSJ3aWR0aD1kZXZpY2Utd2lkdGgsIGluaXRpYWwtc2NhbGU9MS4wIiAvPg0KICAgIDxtZXRhIGh0dHAtZXF1aXY9ImNvbnRlbnQtbGFuZ3VhZ2UiIGNvbnRlbnQ9InB0LWJyIiAvPg0KICAgIDxsaW5rIHJlbD0iaWNvbiIgaHJlZj0iaHR0cDovL3N1Ym1pc3Nhby5hbmFjLmdvdi5ici9mYXZpY29uLmljbyIgLz4NCiAgICAgDQogICAgPGxpbmsgcmVsPSJzdHlsZXNoZWV0IiBocmVmPSJodHRwczovL2Nkbi5qc2RlbGl2ci5uZXQvbnBtL2Jvb3RzdHJhcEA0LjUuMy9kaXN0L2Nzcy9ib290c3RyYXAubWluLmNzcyIgaW50ZWdyaXR5PSJzaGEzODQtVFg4dDI3RWNSRTNlL2loVTd6bVF4Vm5jREF5NXVJS3o0ckVrZ0lYZU1lZDRNMGpsZklEUHZnNnVxS0kyeFhyMiIgY3Jvc3NvcmlnaW49ImFub255bW91cyI+DQogICAgICAgICAgDQogICAgPHRpdGxlPkNlcmlkw6NvIGRlIFByb3ByaWVkYWRlIGRlIMOUbnVzIFJlYWlzPC90aXRsZT4NCiAgICA8c3R5bGUgdHlwZT0idGV4dC9jc3MiPg0KICAgICAgICBkaXYsIHAgew0KICAgICAgICAgICAgZm9udC1zaXplOiAxMnB4DQogICAgICAgIH0NCiAgICA8L3N0eWxlPg0KPC9oZWFkPg0KPGJvZHk+DQogICAgPGRpdiBjbGFzcz0iY29udGFpbmVyLWZsdWlkIj4NCiAgICAgICAgPGRpdiBjbGFzcz0icm93IiBzdHlsZT0iYmFja2dyb3VuZC1jb2xvcjojMWQ2MThmOyI+IA0KICAgICAgICAgICAgPGRpdiBjbGFzcz0iY29sLWxnLTEyIiBzdHlsZT0iY29sb3I6I0ZGRkZGRjsgdGV4dC1hbGlnbjogbGVmdDsgcGFkZGluZzogMTVweDsiPg0KICAgICAgICAgICAgICAgIDx0YWJsZSBzdHlsZT0id2lkdGg6MTAwJTsiPg0KICAgICAgICAgICAgICAgICAgICA8dHI+DQogICAgICAgICAgICAgICAgICAgICAgICA8dGQgc3R5bGU9IndpZHRoOjgwJTsiPjxwIHN0eWxlPSJmb250LXNpemU6MjBweDsgbWFyZ2luOjA7Ij5DZXJ0aWTDo28gZGUgUHJvcHJpZWRhZGUgZGUgw5RudXMgUmVhaXM8L3A+PC90ZD4NCiAgICAgICAgICAgICAgICAgICAgICAgIDx0ZCBzdHlsZT0id2lkdGg6MjAlOyI+DQogICAgICAgICAgICAgICAgICAgICAgICA8L3RkPg0KICAgICAgICAgICAgICAgICAgICA8L3RyPg0KICAgICAgICAgICAgICAgIDwvdGFibGU+DQogICAgICAgICAgICA8L2Rpdj4NCiAgICAgICAgPC9kaXY+DQogICAgICAgIDxociAvPg0KICAgICAgICA8ZGl2IGNsYXNzPSJyb3ciPg0KICAgICAgICAgICAgPGRpdiBjbGFzcz0iY29sLWxnLTEyIiBzdHlsZT0idGV4dC1hbGlnbjpjZW50ZXIiPg0KICAgICAgICAgICAgICAgIDxwIHN0eWxlPSJmb250LXNpemU6MTVweDsgZm9udC13ZWlnaHQ6NjAwIj4NCiAgICAgICAgICAgICAgICAgICAgQUfDik5DSUEgTkFDSU9OQUwgREUgQVZJQcOHw4NPIENJVklMPGJyIC8+DQogICAgICAgICAgICAgICAgICAgIFJFR0lTVFJPIEFFUk9Ow4FVVElDTyBCUkFTSUxFSVJPPGJyIC8+DQogICAgICAgICAgICAgICAgICAgIENFUlRJRMODTyBERSBQUk9QUklFREFERSBFIMOUTlVTIFJFQUlTPGJyIC8+PGJyIC8+DQogICAgICAgICAgICAgICAgICAgIENFUlRJRklDTyBRVUUgTk8gTElWUk8oUykgRSBQw4FHSU5BKFMpIEFCQUlYTywgRE8gUkVHSVNUUk8gQUVST07DgVVUSUNPIEJSQVNJTEVJUk8sIENPTlNUQSBPIFNFR1VJTlRFOg0KICAgICAgICAgICAgICAgIDwvcD4NCiAgICAgICAgICAgIDwvZGl2Pg0KICAgICAgICA8L2Rpdj4NCiAgICAgICAgPGJyIC8+DQogICAgICAgIDxiciAvPg0KICAgICAgICA8ZGl2IGNsYXNzPSJyb3ciIHN0eWxlPSJkaXNwbGF5OmJsb2NrIj4NCiAgICAgICAgICAgIDx0YWJsZSBzdHlsZT0id2lkdGg6MTAwJSI+DQogICAgICAgICAgICAgICAgPHRyPg0KICAgICAgICAgICAgICAgICAgICA8dGQgc3R5bGU9IndpZHRoOjgwJSI+PGRpdiBjbGFzcz0iY29sLWxnLTUiPkxJVlJPOiA8Yj41MDAyLjwvYj48L2Rpdj48L3RkPg0KICAgICAgICAgICAgICAgICAgICA8dGQgc3R5bGU9IndpZHRoOjQwJSI+PGRpdiBjbGFzcz0iY29sLWxnLTUiPlDDgUdJTkE6IDk5PGI+PC9iPjwvZGl2PjwvdGQ+DQogICAgICAgICAgICAgICAgPC90cj4NCiAgICAgICAgICAgIDwvdGFibGU+DQogICAgICAgIDwvZGl2Pg0KDQogICAgICAgIDxociBzdHlsZT0iYm9yZGVyOiAxcHggc29saWQiIC8+DQoNCiAgICAgICAgPGRpdiBjbGFzcz0icm93Ij4NCiAgICAgICAgICAgIDxkaXYgY2xhc3M9ImNvbC1sZy00Ij4NCiAgICAgICAgICAgICAgICA8dGFibGUgY2xhc3M9InRhYmxlIj4NCiAgICAgICAgICAgICAgICAgICAgPHRyPg0KICAgICAgICAgICAgICAgICAgICAgICAgPHRkIHN0eWxlPSJ3aWR0aDo0MCUiPjxkaXYgY2xhc3M9ImNvbC1sZy00Ij5NQVJDQVM6IDxiPlBQUFBQPC9iPjwvZGl2PjwvdGQ+DQogICAgICAgICAgICAgICAgICAgICAgICA8dGQgc3R5bGU9IndpZHRoOjQwJSI+PGRpdiBjbGFzcz0iY29sLWxnLTQiPkZBQlJJQ0FOVEU6IDxiPlBJUEVSIEFJUkNSQUZUPC9iPjwvZGl2PjwvdGQ+DQogICAgICAgICAgICAgICAgICAgICAgICA8dGQgc3R5bGU9IndpZHRoOjQwJSI+PGRpdiBjbGFzcz0iY29sLWxnLTQiPk1PREVMTzogUEEtNDZSLTM1MFQ8Yj48L2I+PC9kaXY+PC90ZD4NCiAgICAgICAgICAgICAgICAgICAgPC90cj4NCiAgICAgICAgICAgICAgICA8L3RhYmxlPg0KICAgICAgICAgICAgPC9kaXY+DQogICAgICAgIDwvZGl2Pg0KICAgICAgICA8YnIgLz4NCiAgICAgICAgPGRpdiBjbGFzcz0icm93Ij4NCiAgICAgICAgICAgIDx0YWJsZSBzdHlsZT0id2lkdGg6MTAwJSI+DQogICAgICAgICAgICAgICAgPHRyPg0KICAgICAgICAgICAgICAgICAgICA8dGQgc3R5bGU9IndpZHRoOjYwJSI+PGRpdiBjbGFzcz0iY29sLWxnLTQiPk7Dmk1FUk8gREUgU8OJUklFOiA8Yj40NjkyMDcwPC9iPjwvZGl2PjwvdGQ+DQogICAgICAgICAgICAgICAgICAgIDx0ZCBzdHlsZT0id2lkdGg6NDAlIj48ZGl2IGNsYXNzPSJjb2wtbGctNCI+Q0FURUdPUklBIERFIFJFR0lTVFJPOiA8Yj5UUFA8L2I+PC9kaXY+PC90ZD4NCiAgICAgICAgICAgICAgICA8L3RyPg0KICAgICAgICAgICAgPC90YWJsZT4NCiAgICAgICAgPC9kaXY+DQogICAgICAgIDxiciAvPg0KICAgICAgICA8ZGl2IGNsYXNzPSJyb3ciPg0KICAgICAgICAgICAgPHRhYmxlIHN0eWxlPSJ3aWR0aDoxMDAlIj4NCiAgICAgICAgICAgICAgICA8dHI+DQogICAgICAgICAgICAgICAgICAgIDx0ZD48ZGl2IGNsYXNzPSJjb2wtbGctOCI+UFJPUFJJRVTDgVJJTzogPGI+QkVOSkFNSU0gUElWRVRBIEFTU1VOQ0FPPC9iPjwvZGl2PjwvdGQ+DQogICAgICAgICAgICAgICAgPC90cj4NCiAgICAgICAgICAgIDwvdGFibGU+DQogICAgICAgIDwvZGl2Pg0KICAgICAgICA8YnIgLz4NCiAgICAgICAgPGRpdiBjbGFzcz0icm93Ij4NCiAgICAgICAgICAgIDx0YWJsZSBzdHlsZT0id2lkdGg6MTAwJSI+DQogICAgICAgICAgICAgICAgPHRyPg0KICAgICAgICAgICAgICAgICAgICA8dGQ+PGRpdiBjbGFzcz0iY29sLWxnLTQiPkNQRi9DTlBKOiA8Yj4wODY1ODY1MDk0NDwvYj48L2Rpdj48L3RkPg0KICAgICAgICAgICAgICAgIDwvdHI+DQogICAgICAgICAgICA8L3RhYmxlPg0KICAgICAgICA8L2Rpdj4NCiAgICAgICAgPGJyIC8+DQogICAgICAgIDxkaXYgY2xhc3M9InJvdyI+DQogICAgICAgICAgICA8dGFibGUgc3R5bGU9IndpZHRoOjEwMCUiPg0KICAgICAgICAgICAgICAgIDx0cj4NCiAgICAgICAgICAgICAgICAgICAgPHRkPjxkaXYgY2xhc3M9ImNvbC1sZy0xMiI+RU5ERVJFw4dPOiA8Yj5BVi4gIEJSQVNJTCAgTsKwICAzNzcyIC0gU0FMQSAxNTIyIC0gWk9OQSAxPC9iPjwvZGl2PjwvdGQ+DQogICAgICAgICAgICAgICAgPC90cj4NCiAgICAgICAgICAgIDwvdGFibGU+DQogICAgICAgIDwvZGl2Pg0KICAgICAgICA8YnIgLz4NCiAgICAgICAgPGRpdiBjbGFzcz0icm93Ij4NCiAgICAgICAgICAgIDx0YWJsZSBzdHlsZT0id2lkdGg6MTAwJSI+DQogICAgICAgICAgICAgICAgPHRyPg0KICAgICAgICAgICAgICAgICAgICA8dGQgc3R5bGU9IndpZHRoOjYwJSI+PGRpdiBjbGFzcz0iY29sLWxnLTQiPkNJREFERTogPGI+TUFSSU5HQTwvYj48L2Rpdj48L3RkPg0KICAgICAgICAgICAgICAgICAgICA8dGQgc3R5bGU9IndpZHRoOjIwJSI+PGRpdiBjbGFzcz0iY29sLWxnLTQiPlVGOiA8Yj5QUjwvYj48L2Rpdj48L3RkPg0KICAgICAgICAgICAgICAgICAgICA8dGQgc3R5bGU9IndpZHRoOjIwJSI+PGRpdiBjbGFzcz0iY29sLWxnLTQiPkNFUDogPGI+ODcwMTMwMDA8L2I+PC9kaXY+PC90ZD4NCiAgICAgICAgICAgICAgICA8L3RyPg0KICAgICAgICAgICAgPC90YWJsZT4NCiAgICAgICAgPC9kaXY+DQogICAgICAgIDxiciAvPg0KICAgICAgICA8ZGl2IGNsYXNzPSJyb3ciPg0KICAgICAgICAgICAgPHRhYmxlIHN0eWxlPSJ3aWR0aDoxMDAlIj4NCiAgICAgICAgICAgICAgICA8dHI+DQogICAgICAgICAgICAgICAgICAgIDx0ZD48ZGl2IGNsYXNzPSJjb2wtbGctNCI+T1BFUkFET1I6IDxiPkJFTkpBTUlNIFBJVkVUQSBBU1NVTkNBTzwvYj48L2Rpdj48L3RkPg0KICAgICAgICAgICAgICAgIDwvdHI+DQogICAgICAgICAgICA8L3RhYmxlPg0KICAgICAgICA8L2Rpdj4NCiAgICAgICAgPGJyIC8+DQogICAgICAgIDxkaXYgY2xhc3M9InJvdyI+DQogICAgICAgICAgICA8dGFibGUgc3R5bGU9IndpZHRoOjEwMCUiPg0KICAgICAgICAgICAgICAgIDx0cj4NCiAgICAgICAgICAgICAgICAgICAgPHRkPjxkaXYgY2xhc3M9ImNvbC1sZy00Ij5DUEYvQ05QSjogPGI+MDg2NTg2NTA5NDQ8L2I+PC9kaXY+PC90ZD4NCiAgICAgICAgICAgICAgICA8L3RyPg0KICAgICAgICAgICAgPC90YWJsZT4NCiAgICAgICAgPC9kaXY+DQogICAgICAgIDxiciAvPg0KICAgICAgICA8ZGl2IGNsYXNzPSJyb3ciPg0KICAgICAgICAgICAgPHRhYmxlIHN0eWxlPSJ3aWR0aDoxMDAlIj4NCiAgICAgICAgICAgICAgICA8dHI+DQogICAgICAgICAgICAgICAgICAgIDx0ZD48ZGl2IGNsYXNzPSJjb2wtbGctMTIiPkVOREVSRcOHTzogPGI+QVYuICBCUkFTSUwgIE7CsCAgMzc3MiAtIFNBTEEgMTUyMiAtIFpPTkEgMTwvYj48L2Rpdj48L3RkPg0KICAgICAgICAgICAgICAgIDwvdHI+DQogICAgICAgICAgICA8L3RhYmxlPg0KICAgICAgICA8L2Rpdj4NCiAgICAgICAgPGJyIC8+DQogICAgICAgIDxkaXYgY2xhc3M9InJvdyI+DQogICAgICAgICAgICA8dGFibGUgc3R5bGU9IndpZHRoOjEwMCUiPg0KICAgICAgICAgICAgICAgIDx0cj4NCiAgICAgICAgICAgICAgICAgICAgPHRkIHN0eWxlPSJ3aWR0aDo2MCUiPjxkaXYgY2xhc3M9ImNvbC1sZy00Ij5DSURBREU6IDxiPk1BUklOR0E8L2I+PC9kaXY+PC90ZD4NCiAgICAgICAgICAgICAgICAgICAgPHRkIHN0eWxlPSJ3aWR0aDoyMCUiPjxkaXYgY2xhc3M9ImNvbC1sZy00Ij5VRjogPGI+UFI8L2I+PC9kaXY+PC90ZD4NCiAgICAgICAgICAgICAgICAgICAgPHRkIHN0eWxlPSJ3aWR0aDoyMCUiPjxkaXYgY2xhc3M9ImNvbC1sZy00Ij5DRVA6IDxiPjg3MDEzMDAwPC9iPjwvZGl2PjwvdGQ+DQogICAgICAgICAgICAgICAgPC90cj4NCiAgICAgICAgICAgIDwvdGFibGU+DQogICAgICAgIDwvZGl2Pg0KICAgICAgICA8YnIgLz4NCiAgICAgICAgPGhyIHN0eWxlPSJib3JkZXI6IDFweCBzb2xpZCIgLz4NCiAgICAgICAgPGRpdiBjbGFzcz0icm93Ij4NCiAgICAgICAgICAgIDx0YWJsZSBzdHlsZT0id2lkdGg6MTAwJSI+DQogICAgICAgICAgICAgICAgPHRyPg0KICAgICAgICAgICAgICAgICAgICA8dGQ+PGRpdiBjbGFzcz0iY29sLWxnLTEyIj5BRVJPTkFWRSDDiSBPQkpFVE8gREU6IDxiPjwvYj48L2Rpdj48L3RkPg0KICAgICAgICAgICAgICAgIDwvdHI+DQogICAgICAgICAgICA8L3RhYmxlPg0KICAgICAgICA8L2Rpdj4NCiAgICAgICAgPGJyIC8+DQogICAgICAgIDxkaXYgY2xhc3M9InJvdyIgc3R5bGU9ImRpc3BsYXk6YmxvY2siPg0KDQogICAgICAgICAgICA8dGFibGUgc3R5bGU9IndpZHRoOjEwMCUiPg0KDQogICAgICAgICAgICAgICAgPHRyPg0KICAgICAgICAgICAgICAgICAgICA8dGQ+DQogICAgICAgICAgICAgICAgICAgICAgICA8ZGl2IGNsYXNzPSJjb2wtbGctMTIiIHN0eWxlPSJ0ZXh0LWFsaWduOmp1c3RpZnkiPg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWCZuYnNwOwpYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFgmbmJzcDsKWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFgmbmJzcDsKWFhYWFhYWFhYWFhYUE9SJm5ic3A7Jm5ic3A7REVTUEFDSE8mbmJzcDsmbmJzcDtETyZuYnNwOyZuYnNwO1NSJm5ic3A7Jm5ic3A7Q0hFRkUmbmJzcDtETyZuYnNwO1JBQiwmbmJzcDtERSZuYnNwOzE3LzEyLzkyLCZuYnNwO0VYQVJBRE8mbmJzcDtBUyZuYnNwO0ZMUyZuYnNwOzAxJm5ic3A7TyZuYnNwO1BST0NFU1NPJm5ic3A7Ck7CujA3MDEvMDI0NDYvOTIsJm5ic3A7Jm5ic3A7Rk9JJm5ic3A7Jm5ic3A7QVVUT1JJWkFEQSZuYnNwOyZuYnNwO0EmbmJzcDsmbmJzcDtBVkVSQkFDQU8mbmJzcDsmbmJzcDtETyZuYnNwOyZuYnNwO0NPTlRSQVRPJm5ic3A7Jm5ic3A7REUmbmJzcDtBUlJFTkRBTUVOVE8mbmJzcDsKT1BFUkFDSU9OQUwmbmJzcDsmbmJzcDtERSZuYnNwOyZuYnNwO0FFUk9OQVZFJm5ic3A7Jm5ic3A7REFUQURPJm5ic3A7Jm5ic3A7REUmbmJzcDsmbmJzcDswNy8xMS85MSwmbmJzcDtDRUxFQlJBRE8mbmJzcDtFTlRSRSZuYnNwO1BBUlRFUywmbmJzcDtERSZuYnNwO1VNJm5ic3A7CkxBRE8sJm5ic3A7RU5UUkUmbmJzcDtNQkImbmJzcDtIRUxJQ09QVEVSJm5ic3A7Q09SUE9SQVRJT04sJm5ic3A7V0VTVCZuYnNwO0NIRVNURVIsJm5ic3A7UEVOTlNZTFZBTklBLCZuYnNwO0RFTk9NSU5BREEmbmJzcDsKQVJSRU5EQURPUkEsJm5ic3A7Jm5ic3A7RSZuYnNwOyZuYnNwO0hFTElKRVQmbmJzcDsmbmJzcDtBRVJPVEFYSSZuYnNwOyZuYnNwO0xUREEmbmJzcDsmbmJzcDsoQVJSRU5EQVRBUklBKSwmbmJzcDsmbmJzcDtURU5ETyZuYnNwO0NPTU8mbmJzcDtPQkpFVE8mbmJzcDtBJm5ic3A7CkFFUk9OQVZFJm5ic3A7TsK6Jm5ic3A7REUmbmJzcDtTRVJJRSZuYnNwOzcxMTQsJm5ic3A7UkVHSVNUUk8mbmJzcDtBTUVSSUNBTk8mbmJzcDtONjI5TUIsJm5ic3A7TU9ERUxPJm5ic3A7QksmbmJzcDsxMTcmbmJzcDtVU0FETywmbmJzcDtRVUUmbmJzcDsKUkVDRUJFVSZuYnNwOyZuYnNwO0FTJm5ic3A7TUFSQ0FTJm5ic3A7QlJBU0lMRUlSQVMmbmJzcDtQVCZuZGFzaDtISkQuJm5ic3A7TyZuYnNwO1BSQVpPJm5ic3A7RE8mbmJzcDtBUlJFTkRBTUVOVE8mbmJzcDtFJm5ic3A7UE9SJm5ic3A7VU0mbmJzcDtNSU5JTU8mbmJzcDsKREUmbmJzcDsmbmJzcDszMCZuYnNwOyZuYnNwO01FU0VTLCZuYnNwOyZuYnNwO0NPTlNFQ1VUSVZPUywmbmJzcDsmbmJzcDtDT01FQ0FORE8mbmJzcDtDT00mbmJzcDtBJm5ic3A7REFUQSZuYnNwO0RBJm5ic3A7RU5UUkVHQSZuYnNwO0RPJm5ic3A7SEVMSUNPUFRFUk8sJm5ic3A7Ck9DT1JSSURBJm5ic3A7Jm5ic3A7RU0mbmJzcDsmbmJzcDsxOS8xMi85MSwmbmJzcDtDT05GT1JNRSZuYnNwO1BST1RPQ09MTyZuYnNwO0RFJm5ic3A7QUNFSVRFJm5ic3A7RSZuYnNwO0VOVFJFR1VFJm5ic3A7SU5DTFVTTyZuYnNwO0FTJm5ic3A7RkxTJm5ic3A7CjM3LzQ4Jm5ic3A7Jm5ic3A7RE8mbmJzcDsmbmJzcDtKQSZuYnNwOyZuYnNwO01FTkNJT05BRE8mbmJzcDsmbmJzcDtQUk9DRVNTTy4mbmJzcDtPJm5ic3A7Q09OVFJBVE8mbmJzcDtERSZuYnNwO0FSUkVOREFNRU5UTyZuYnNwO05PJm5ic3A7VkFMT1ImbmJzcDtERSZuYnNwO1VNJm5ic3A7CkFMVUdVRUwmbmJzcDsmbmJzcDtNRU5TQUwmbmJzcDsmbmJzcDtERSZuYnNwOyZuYnNwO1VTJCZuYnNwOyZuYnNwOzIxLjAwMCwwMCwmbmJzcDtQT1ImbmJzcDtNRVMmbmJzcDtDSVZJTCwmbmJzcDtPVSZuYnNwO0EmbmJzcDtQQVJDRUxBJm5ic3A7UFJPUkFUQSZuYnNwO0RFU1NBJm5ic3A7ClNPTUEsJm5ic3A7Jm5ic3A7UEFHQU5ETyZuYnNwOyZuYnNwO0FJTkRBJm5ic3A7QSZuYnNwO0FSUkVOREFUQVJJQSZuYnNwO0EmbmJzcDtBUlJFTkRBRE9SQSZuYnNwO0EmbmJzcDtRVUFOVElBJm5ic3A7REUmbmJzcDtVUyQmbmJzcDsyMTAsMDAmbmJzcDtQT1ImbmJzcDsKSE9SQSZuYnNwO1ZPQURBLCZuYnNwO0FTJm5ic3A7UEFSVEVTJm5ic3A7Jm5ic3A7QUNFSVRBTSZuYnNwO0UmbmJzcDtBU1NJTkFNJm5ic3A7VE9EQVMmbmJzcDtBUyZuYnNwO0RFTUFJUyZuYnNwO0NMQVVTVUxBUyZuYnNwO0UmbmJzcDtDT05ESUNPRVMmbmJzcDsKRE8mbmJzcDtDT05UUkFUTyZuYnNwO0RFJm5ic3A7QVJSRU5EQU1FTlRPLCZuYnNwOyZuYnNwO1FVRSZuYnNwOyZuYnNwO1NFJm5ic3A7Jm5ic3A7RU5DT05UUkEmbmJzcDtJTkNMVVNBJm5ic3A7UE9SJm5ic3A7Q09QSUEmbmJzcDtBUyZuYnNwO0ZMUyZuYnNwOzE0LzMwJm5ic3A7CkRPJm5ic3A7Jm5ic3A7U1VQUkFDSVRBRE8mbmJzcDsmbmJzcDtQUk9DRVNTTywmbmJzcDsmbmJzcDtUUkFEVVpJRE8mbmJzcDsmbmJzcDtQQVJBJm5ic3A7TyZuYnNwO1ZFUk5BQ1VMTyZuYnNwO1BPUiZuYnNwO0FMT1lTSU8mbmJzcDtERSZuYnNwO01PUkFFUywmbmJzcDsKVFJBRFVUT1ImbmJzcDsmbmJzcDtQVUJMSUNPJm5ic3A7Jm5ic3A7RSZuYnNwOyZuYnNwO0lOVEVSUFJFVEUmbmJzcDsmbmJzcDtDT01FUkNJQUwsJm5ic3A7Q09ORk9STUUmbmJzcDtUUkFEVUNBTyZuYnNwO07CuiZuYnNwOzMzLjY4NS85MS4mbmJzcDtPJm5ic3A7ClBST1RPQ09MTyZuYnNwO0RFJm5ic3A7QUNFSVRFJm5ic3A7RSZuYnNwOyZuYnNwO0VOVFJFR0EmbmJzcDsmbmJzcDtFTkNPTlRSQSZuZGFzaDtTRSZuYnNwOyZuYnNwO0FTJm5ic3A7Jm5ic3A7RkxTJm5ic3A7Jm5ic3A7MzcvNDgsJm5ic3A7Q09ORk9STUUmbmJzcDtUUkFEVUNBTyZuYnNwOwpOwrombmJzcDszNjA5NS85MiwmbmJzcDtFWEVDVVRBREEmbmJzcDtQRUxPJm5ic3A7TUVTTU8mbmJzcDtUUkFEVVRPUi4mbmJzcDtFVSwmbmJzcDtOSUxEQSwmbmJzcDtJTlNDUkVWSSZuYnNwO08mbmJzcDsmbmJzcDtURVJNTy4mbmJzcDsmbmJzcDtFTSxQT1ImbmJzcDsmbmJzcDtERVNQQUNITyZuYnNwOyZuYnNwO0RPJm5ic3A7Jm5ic3A7U1ImbmJzcDsmbmJzcDtDSEVGRSZuYnNwOyZuYnNwO0RPJm5ic3A7UkFCLCZuYnNwO0RFJm5ic3A7MzEvMDUvOTQsJm5ic3A7RVhBUkFETyZuYnNwO0FTJm5ic3A7RkxTJm5ic3A7MSwmbmJzcDtWT0wmbmJzcDsyLCZuYnNwO0RPJm5ic3A7ClBST0NFU1NPJm5ic3A7Jm5ic3A7TsK6MDcwMS8xMDUxLzk0LCZuYnNwOyZuYnNwO0ZPSSZuYnNwOyZuYnNwO0FVVE9SSVpBREEmbmJzcDsmbmJzcDtBJm5ic3A7Jm5ic3A7QVZFUkJBQ0FPJm5ic3A7RE8mbmJzcDtNQU5EQURPJm5ic3A7REUmbmJzcDtBUlJFU1RPJm5ic3A7Ck7CujEyMC85NCwmbmJzcDsmbmJzcDtEQVRBRE8mbmJzcDtERSZuYnNwOzEwLzA1Lzk0LCZuYnNwO1BBU1NBRE8mbmJzcDtOT1MmbmJzcDtBVVRPUyZuYnNwO0RBJm5ic3A7TUVESURBJm5ic3A7Q0FVVEVMQVImbmJzcDtERSZuYnNwO0FSUkVTVE8mbmJzcDsKTsK6Jm5ic3A7Jm5ic3A7MTI4MC85NCwmbmJzcDsmbmJzcDtJTlRFUlBPU1RBJm5ic3A7Jm5ic3A7UE9SJm5ic3A7Q0VMU08mbmJzcDtMVUlaJm5ic3A7RklHVUVJUkVETyZuYnNwO1RSQVZBU1NPUyZuYnNwO0UmbmJzcDtPVVRST1MsJm5ic3A7Q09OVFJBJm5ic3A7CkhFTElKRVQmbmJzcDtBRVJPJm5ic3A7VEFYSSZuYnNwO0xUREEsJm5ic3A7QVRSQVZFUyZuYnNwO0RPJm5ic3A7UVVBTCZuYnNwO08mbmJzcDtET1VUT1ImbmJzcDtBTEVYQU5EUkUmbmJzcDtURUlYRUlSQSZuYnNwO0RFJm5ic3A7RlJFSVRBUyZuYnNwOwpCQVNUT1MmbmJzcDsmbmJzcDtDVU5IQSwmbmJzcDtKVUlaJm5ic3A7UFJFU0lERU5URSZuYnNwO0RBJm5ic3A7NjLCqiZuYnNwO0pVTlRBJm5ic3A7REUmbmJzcDtDT05DSUxJQUNBTyZuYnNwO0UmbmJzcDtKVUxHQU1FTlRPJm5ic3A7RE8mbmJzcDtSSU8mbmJzcDsKREUmbmJzcDsmbmJzcDtKQU5FSVJPLCZuYnNwOyZuYnNwO0RFVEVSTUlOQSZuYnNwOyZuYnNwO0FPJm5ic3A7Jm5ic3A7T0ZJQ0lBTCZuYnNwOyZuYnNwO0RFJm5ic3A7Jm5ic3A7SlVTVElDQSZuYnNwOyZuYnNwO1FVRSZuYnNwOyZuYnNwO1BST0NFREEmbmJzcDtBTyZuYnNwO0FSUkVTVE8mbmJzcDtET1MmbmJzcDsKU0VHVUlOVEVTJm5ic3A7QkVOUzombmJzcDswMihET0lTKSZuYnNwO1NJUktPUlNLWSwmbmJzcDtNT0RFTE8mbmJzcDtTJm5ic3A7NzYuQSxQUkVGSVhPUyZuYnNwO1BUJm5kYXNoO0hVSiZuYnNwO0UmbmJzcDtQVCZuZGFzaDtIT1I7Jm5ic3A7MDEmbmJzcDsKKFVNKSZuYnNwO0JFTEwmbmJzcDs0MTIsJm5ic3A7UFJFRklYTyZuYnNwO1BUJm5kYXNoO0hYVSZuYnNwO0UmbmJzcDswMyhUUkVTKSZuYnNwO0JLJm5kYXNoOzExNywmbmJzcDtQUkVGSVhPUyZuYnNwO1BUJm5kYXNoO0hKRCwmbmJzcDtQVCZuZGFzaDtISk0mbmJzcDtFJm5ic3A7UFQmbmRhc2g7Jm5ic3A7CkhLRiwmbmJzcDsmbmJzcDsmbmJzcDsmbmJzcDtUT0RPUyZuYnNwOyZuYnNwO0hFTElDT1BURVJPUy4mbmJzcDsmbmJzcDtFVSwmbmJzcDsmbmJzcDtOSUxEQSwmbmJzcDsmbmJzcDtJTlNDUkVWSSZuYnNwOyZuYnNwO08mbmJzcDsmbmJzcDtURVJNTy4mbmJzcDsmbmJzcDtFTSwmbmJzcDsmbmJzcDszMS8wNS85NC5QT1ImbmJzcDsmbmJzcDtERVNQQUNITyZuYnNwOyZuYnNwO0RPJm5ic3A7Jm5ic3A7U1ImbmJzcDtDSEVGRSZuYnNwO0RPJm5ic3A7UkFCLCZuYnNwO0RFJm5ic3A7MjIvMTEvOTEsJm5ic3A7RVhBUkFETyZuYnNwO0FTJm5ic3A7RkxTJm5ic3A7MDgmbmJzcDtETyZuYnNwO1BST0NFU1NPJm5ic3A7Ck7CujA3MDEvNDk3LzkxLCZuYnNwOyZuYnNwO0ZPSSZuYnNwOyZuYnNwO0FVVE9SSVpBRE8mbmJzcDsmbmJzcDtPJm5ic3A7Jm5ic3A7UkVHSVNUUk8mbmJzcDsmbmJzcDtETyZuYnNwOyZuYnNwO0NPTlRSQVRPJm5ic3A7REUmbmJzcDtBUlJFTkRBTUVOVE8sJm5ic3A7REUmbmJzcDsKMzEvMTAvOTEsJm5ic3A7Jm5ic3A7VFJBRFVaSURPJm5ic3A7Jm5ic3A7UEFSQSZuYnNwOyZuYnNwO08mbmJzcDsmbmJzcDtWRVJOQUNVTE8mbmJzcDsmbmJzcDtQT1ImbmJzcDsmbmJzcDtST1NBJm5ic3A7Jm5ic3A7TUFSSUEmbmJzcDsmbmJzcDtSSVBQRVImbmJzcDsmbmJzcDtEJ0FMTUVJREEsJm5ic3A7ClRSQURVVE9SQSZuYnNwOyZuYnNwO1BVQkxJQ0EsJm5ic3A7Jm5ic3A7Q09NJm5ic3A7Jm5ic3A7RU5ERVJFQ08mbmJzcDsmbmJzcDtOQSZuYnNwOyZuYnNwO0FWLiZuYnNwO1BSRVNJREVOVEUmbmJzcDtWQVJHQVMsJm5ic3A7NTA5LzUwMywmbmJzcDtSSU8mbmJzcDtERSZuYnNwOwpKQU5FSVJPLCZuYnNwOyZuYnNwO1JKLCZuYnNwOyZuYnNwO0JSQVNJTCwmbmJzcDsmbmJzcDtDRVAmbmJzcDsyMC4wNzEsJm5ic3A7VFJBRFVDQU8mbmJzcDtOwrombmJzcDsxNDkwNi9YSS85MSwmbmJzcDtFTlRSRSZuYnNwO0EmbmJzcDtWQVJJRyZuYnNwO1NBLCZuYnNwOwpVTUEmbmJzcDsmbmJzcDtTT0NJRURBREUmbmJzcDtCUkFTSUxFSVJBLCZuYnNwO0NPTSZuYnNwO0VTQ1JJVE9SSU8mbmJzcDtOQSZuYnNwO0NJREFERSZuYnNwO0RPJm5ic3A7UklPJm5ic3A7REUmbmJzcDtKQU5FSVJPLCZuYnNwO0JSQVNJTCwmbmJzcDsKTkEmbmJzcDsmbmJzcDtRVUFMSURBREUmbmJzcDsmbmJzcDtERSZuYnNwOyZuYnNwO0FSUkVOREFUQVJJQSwmbmJzcDtFJm5ic3A7V0lMTUlOR1RPTiZuYnNwO1RSVVNUJm5ic3A7Q09NUEFOWSwmbmJzcDtDT00mbmJzcDtFU0NSSVRPUklPJm5ic3A7RU0mbmJzcDsKV0lMTUlOR1RPTiwmbmJzcDtERUxBV0FSRSZuYnNwOyhOQU8mbmJzcDtOQSZuYnNwO1NVQSZuYnNwOyZuYnNwO0NBUEFDSURBREUmbmJzcDsmbmJzcDtJTkRJVklEVUFMJm5ic3A7RSZuYnNwO1NJTSZuYnNwO1VOSUNBTUVOVEUmbmJzcDtDT01PJm5ic3A7ClBST1BSSUVUQVJJQSZuYnNwOyZuYnNwO0ZJRFVDSUFSSUEpLCZuYnNwO05BJm5ic3A7UVVBTElEQURFJm5ic3A7REUmbmJzcDtBUlJFTkRBRE9SQSwmbmJzcDtDT00mbmJzcDtBUyZuYnNwO0NBUkFDVEVSSVNUSUNBUyZuYnNwOwpQUklOQ0lQQUlTJm5ic3A7Jm5ic3A7QSZuYnNwOyZuYnNwO1NFR1VJUjombmJzcDsmbmJzcDsoMSkmbmJzcDsmbmJzcDtPQkpFVE86Jm5ic3A7Jm5ic3A7QVJSRU5EQU1FTlRPJm5ic3A7REUmbmJzcDsyKERVQVMpJm5ic3A7QUVST05BVkVTJm5ic3A7Qk9FSU5HJm5ic3A7CjczNy4zNDEsJm5ic3A7Jm5ic3A7TlVNRVJPUyZuYnNwOyZuYnNwO0RFJm5ic3A7Jm5ic3A7U0VSSUUmbmJzcDsyNS4wNTAmbmJzcDtFJm5ic3A7MjUuMDUxLCZuYnNwO0VRVUlQQURPUyZuYnNwO0NBREEmbmJzcDtRVUFMJm5ic3A7Q09NJm5ic3A7MDIoRE9JUykmbmJzcDsKTU9UT1JFUyZuYnNwOyZuYnNwO0NGTSZuYnNwOyZuYnNwOzU2Jm5kYXNoOzNCJm5kYXNoOzIsJm5ic3A7Jm5ic3A7U0VORE8mbmJzcDsmbmJzcDtRVUUmbmJzcDsmbmJzcDtBUyZuYnNwOyZuYnNwO0FFUk9OQVZFUywmbmJzcDtOQSZuYnNwO0RBVEEmbmJzcDtERSZuYnNwO0VOVFJFR0EmbmJzcDtTRVJBTyZuYnNwO0RFJm5ic3A7ClBST1BSSUVEQURFJm5ic3A7REEmbmJzcDtBUlJFTkRBRE9SQTsmbmJzcDsoMikmbmJzcDtQUkFaTzombmJzcDtURVJBJm5ic3A7SU5JQ0lPJm5ic3A7TkEmbmJzcDtEQVRBJm5ic3A7REUmbmJzcDtGRUNIQU1FTlRPJm5ic3A7UE9OVEUmbmJzcDsKRSZuYnNwOyZuYnNwO1RFUk1JTkFSQSZuYnNwO05BJm5ic3A7REFUQSZuYnNwO0RFJm5ic3A7VEVSTUlOTyZuYnNwO0RPJm5ic3A7QVJSRU5EQU1FTlRPLCZuYnNwO1RBTCZuYnNwO0NPTU8mbmJzcDtERUZJTklET1MmbmJzcDtOTyZuYnNwO0FORVhPJm5ic3A7WCZuYnNwOwpETyZuYnNwOyZuYnNwO0NPTlRSQVRPJm5ic3A7REUmbmJzcDtBUlJFTkRBTUVOVE87Jm5ic3A7KDMpJm5ic3A7QUxVR1VFTCZuYnNwO0JBU0lDTzombmJzcDtTRVJBJm5ic3A7TyZuYnNwO0VRVUlWQUxFTlRFJm5ic3A7QTombmJzcDsoQSkmbmJzcDtFTSZuYnNwOwpDQURBJm5ic3A7Jm5ic3A7REFUQSZuYnNwO0RFJm5ic3A7UEFHQU1FTlRPJm5ic3A7RE8mbmJzcDtBTFVHVUVMJm5ic3A7UVVFJm5ic3A7T0NPUlJBJm5ic3A7TkEmbmJzcDtEQVRBJm5ic3A7REUmbmJzcDtGRUNIQU1FTlRPJm5ic3A7RE8mbmJzcDtQRVJJT0RPJm5ic3A7Ck9VJm5ic3A7Jm5ic3A7QVRFJm5ic3A7Jm5ic3A7RVNUQSZuYnNwO0RBVEE6Jm5ic3A7QSZuYnNwO1NPTUEmbmJzcDtETyZuYnNwO1ZBTE9SJm5ic3A7UE9OVEUmbmJzcDtETyZuYnNwO0FMVUdVRUwmbmJzcDtGSVhPJm5ic3A7TUFJUyZuYnNwO0ZBVE9SJm5ic3A7RkxVVFVBTlRFJm5ic3A7CkRPJm5ic3A7Jm5ic3A7QUxVR1VFTCwmbmJzcDsmbmJzcDtERSZuYnNwOyZuYnNwO0NBREEmbmJzcDsmbmJzcDtBRVJPTkFWRSwmbmJzcDsmbmJzcDtDT1JSRVNQT05ERU5URSZuYnNwOyZuYnNwO0EmbmJzcDtDQURBJm5ic3A7REFUQSZuYnNwO0RFJm5ic3A7UEFHQU1FTlRPJm5ic3A7RE8mbmJzcDsKQUxVR1VFTDsmbmJzcDsoQikmbmJzcDtQQVJBJm5ic3A7UVVBTFFVRVImbmJzcDtEQVRBJm5ic3A7REUmbmJzcDtQQUdBTUVOVE8mbmJzcDtERSZuYnNwO0FMVUdVRUwmbmJzcDtRVUUmbmJzcDtPQ09SUkEmbmJzcDtBUE9TJm5ic3A7QSZuYnNwO0RBVEEmbmJzcDsKREUmbmJzcDsmbmJzcDtGRUNIQU1FTlRPJm5ic3A7Jm5ic3A7RE8mbmJzcDsmbmJzcDtQRVJJT0RPLCZuYnNwOyZuYnNwO08mbmJzcDsmbmJzcDtWQUxPUiZuYnNwOyZuYnNwO0RPJm5ic3A7Jm5ic3A7QUxVR1VFTCZuYnNwOyZuYnNwO0ZJWE8mbmJzcDtSRUxBVElWQU1FTlRFJm5ic3A7QSZuYnNwO0NBREEmbmJzcDsKQUVST05BVkUmbmJzcDsmbmJzcDtQQVJBJm5ic3A7Jm5ic3A7QVFVRUxBJm5ic3A7Jm5ic3A7REFUQSZuYnNwOyZuYnNwO0RFJm5ic3A7Jm5ic3A7UEFHQU1FTlRPJm5ic3A7Jm5ic3A7RE8mbmJzcDsmbmJzcDtBTFVHVUVMLCZuYnNwOyZuYnNwO1RVRE8mbmJzcDtDT05GT1JNRSZuYnNwO1RBSVMsJm5ic3A7CkVYUFJFU1NPRVMmbmJzcDsmbmJzcDsmbmJzcDsmbmJzcDtTQU8mbmJzcDsmbmJzcDtERUZJTklEQVMmbmJzcDsmbmJzcDtOTyZuYnNwOyZuYnNwO0FORVhPJm5ic3A7Jm5ic3A7WCZuYnNwOyZuYnNwO0RPJm5ic3A7Jm5ic3A7Q09OVFJBVE8mbmJzcDsmbmJzcDtERSZuYnNwOyZuYnNwO0FSUkVOREFNRU5UTy4mbmJzcDsmbmJzcDtBJm5ic3A7CkFSUkVOREFUQVJJQSZuYnNwOyZuYnNwO1BBR0FSQSZuYnNwOyZuYnNwO1RBTUJFTSZuYnNwOyZuYnNwO0NPTU8mbmJzcDtBTFVHVUVMJm5ic3A7U1VQTEVNRU5UQVImbmJzcDtPUyZuYnNwO1ZBTE9SRVMmbmJzcDtJTkRJQ0FET1MmbmJzcDtOQSZuYnNwOwpDTEFVU1VMQSZuYnNwOzM7Jm5ic3A7KEQpJm5ic3A7RE8mbmJzcDtDT05UUkFUTyZuYnNwO0RFJm5ic3A7QVJSRU5EQU1FTlRPOyZuYnNwOyg0KSZuYnNwO0xPQ0FMJm5ic3A7REUmbmJzcDtQQUdBTUVOVE86Jm5ic3A7TyZuYnNwO0FMVUdVRUwmbmJzcDsKRSZuYnNwOyZuYnNwO09VVFJPUyZuYnNwOyZuYnNwO01PTlRBTlRFUyZuYnNwOyZuYnNwO0RFVklET1MmbmJzcDsmbmJzcDtTRUdVTkRPJm5ic3A7Jm5ic3A7TyZuYnNwO0NPTlRSQVRPJm5ic3A7REUmbmJzcDtBUlJFTkRBTUVOVE8mbmJzcDtERVZFUkFPJm5ic3A7U0VSJm5ic3A7ClBBR09TJm5ic3A7Jm5ic3A7RU0mbmJzcDsmbmJzcDtET0xBUkVTJm5ic3A7Tk9SVEUmbmRhc2g7QU1FUklDQU5PUywmbmJzcDtNRURJQU5URSZuYnNwO1RSQU5TRkVSRU5DSUEmbmJzcDtURUxFR1JBRklDQSZuYnNwO1BBUkEmbmJzcDtPJm5ic3A7CkZJUlNUJm5ic3A7Jm5ic3A7U0VDVVJJVFkmbmJzcDsmbmJzcDtCQU5LJm5ic3A7Jm5ic3A7T0YmbmJzcDsmbmJzcDtVVEFIJm5ic3A7Jm5ic3A7TkFUSU9OQUwmbmJzcDsmbmJzcDtBU1NPQ0lBVElPTiZuYnNwOyZuYnNwO05BJm5ic3A7UVVBTElEQURFJm5ic3A7REUmbmJzcDtBR0VOVEUmbmJzcDsKRklEVUNJQVJJTywmbmJzcDsmbmJzcDtFTSZuYnNwOyZuYnNwOzc5Jm5ic3A7U09VVEgmbmJzcDtNQUlOJm5ic3A7U1RSRUVULCZuYnNwO1NBTFRFJm5ic3A7TEFLRSZuYnNwO0NJVFksJm5ic3A7VVRBSCZuYnNwOzg0LjEzMDsmbmJzcDsoNSkmbmJzcDtPUENBTyZuYnNwOwpERSZuYnNwOyZuYnNwO0NPTVBSQTombmJzcDsmbmJzcDtBJm5ic3A7Jm5ic3A7QVJSRU5EQVRBUklBJm5ic3A7Jm5ic3A7VEVSQSZuYnNwO0EmbmJzcDtPUENBTyZuYnNwO0RFJm5ic3A7Q09NUFJBUiZuYnNwO0NBREEmbmJzcDtBRVJPTkFWRSZuYnNwO05BJm5ic3A7REFUQSZuYnNwO0RFJm5ic3A7ClRFUk1JTk8mbmJzcDsmbmJzcDtETyZuYnNwOyZuYnNwO0FSUkVOREFNRU5UTywmbmJzcDsmbmJzcDtQT1ImbmJzcDsmbmJzcDtVTSZuYnNwOyZuYnNwO1BSRUNPJm5ic3A7Jm5ic3A7REUmbmJzcDsmbmJzcDtDT01QUkEmbmJzcDsmbmJzcDtFUVVJVkFMRU5URSZuYnNwO0EmbmJzcDtVUyQmbmJzcDsxMDAsJm5ic3A7Ck1FRElBTlRFJm5ic3A7Jm5ic3A7QVZJU08mbmJzcDtFU0NSSVRPJm5ic3A7SVJSRVZPR0FWRUwmbmJzcDtFTlRSRUdVRSZuYnNwO0EmbmJzcDtBUlJFTkRBRE9SQSZuYnNwO0FOVEVTJm5ic3A7REFRVUVMQSZuYnNwO0RBVEE7Jm5ic3A7Cig2KSZuYnNwOyZuYnNwO1NFR1VSTzombmJzcDsmbmJzcDtBJm5ic3A7QVJSRU5EQVRBUklBJm5ic3A7REVWRVJBJm5ic3A7TUFOVEVSJm5ic3A7T1MmbmJzcDtTRUdVUk9TJm5ic3A7SU5ESUNBRE9TJm5ic3A7TkEmbmJzcDtDTEFVU1VMQSZuYnNwO0lJJm5ic3A7CkRPJm5ic3A7Jm5ic3A7Q09OVFJBVE8mbmJzcDsmbmJzcDtERSZuYnNwOyZuYnNwO0FSUkVOREFNRU5UTyZuYnNwOyg3KSZuYnNwO0ZSVUlDQU8mbmJzcDtUUkFOUVVJTEE6Jm5ic3A7REVTREUmbmJzcDtRVUUmbmJzcDtORU5IVU0mbmJzcDtDQVNPJm5ic3A7REUmbmJzcDsKSU5BRElNUExFTkNJQSZuYnNwOyZuYnNwO1RFTkhBJm5ic3A7Jm5ic3A7T0NPUlJJRE8mbmJzcDtFJm5ic3A7UEVSRFVSRSwmbmJzcDtBJm5ic3A7QVJSRU5EQURPUkEmbmJzcDtBQ09SREEmbmJzcDtRVUUmbmJzcDtOQU8mbmJzcDtJUkEmbmJzcDtQT1ImbmJzcDsKU0VVUyZuYnNwOyZuYnNwO1BST1BSSU9TJm5ic3A7Jm5ic3A7TUVJT1MmbmJzcDsmbmJzcDtPVSZuYnNwOyZuYnNwO0FUT1MmbmJzcDsmbmJzcDtERSZuYnNwO1RFUkNFSVJPUyZuYnNwO1FVRSZuYnNwO0ZBQ0FNJm5ic3A7REVWSURBUyZuYnNwO1JFSVZJTkRJQ0FDT0VTJm5ic3A7CkFUUkFWRVMmbmJzcDtERSZuYnNwO0FDT1JETyZuYnNwO0NPTSZuYnNwO0EmbmJzcDtBUlJFTkRBRE9SQSwmbmJzcDtJTlRFUkZFUklSJm5ic3A7Tk8mbmJzcDtVU08sJm5ic3A7TkEmbmJzcDtPUEVSQUNBTyZuYnNwO0UmbmJzcDtOQSZuYnNwO1BPU1NFUE9SJm5ic3A7Jm5ic3A7REVTUEFDSE8mbmJzcDsmbmJzcDtETyZuYnNwO0VYTU8uJm5ic3A7U1IuJm5ic3A7RElSRVRPUiZuYnNwO0dFUkFMJm5ic3A7RE8mbmJzcDtERVBBUlRBTUVOVE8mbmJzcDtERSZuYnNwO0FWSUFDQU8mbmJzcDtDSVZJTCwmbmJzcDtERSZuYnNwOwoxNyZuYnNwOyZuYnNwO0RFJm5ic3A7Jm5ic3A7REVaRU1CUk8mbmJzcDsmbmJzcDtERSZuYnNwOyZuYnNwOzE5OTIsJm5ic3A7Jm5ic3A7RVhBUkFETyZuYnNwOyZuYnNwO05PJm5ic3A7Jm5ic3A7UFJPQ0VTU08mbmJzcDtELkMuJm5ic3A7TsK6Jm5ic3A7MDcmbmRhc2g7MDEvMDI0NDYvOTImbmJzcDtGSUNBJm5ic3A7Ck1BVFJJQ1VMQURBJm5ic3A7Jm5ic3A7Jm5ic3A7QSZuYnNwOyZuYnNwO0FFUk9OQVZFJm5ic3A7Jm5ic3A7REVTQ1JJVEEmbmJzcDsmbmJzcDtBJm5ic3A7Jm5ic3A7U0VHVUlSLCZuYnNwO0EmbmJzcDsmbmJzcDtRVUFMJm5ic3A7Jm5ic3A7Rk9SQU0mbmJzcDsmbmJzcDtBVFJJQlVJREFTJm5ic3A7Jm5ic3A7QVMmbmJzcDsKTUFSQ0FTJm5ic3A7Jm5ic3A7Jm5ic3A7Jm5ic3A7REUmbmJzcDsmbmJzcDsmbmJzcDsmbmJzcDtOQUNJT05BTElEQURFJm5ic3A7Jm5ic3A7RSZuYnNwO0RFJm5ic3A7TUFUUklDVUxBJm5ic3A7UFQmbmRhc2g7SEpEJm5ic3A7RkFCUklDQU5URTombmJzcDtNRVNTRVJTQ0hNSVRUJm5ic3A7CkRFU0lHTkFDQU8mbmJzcDsmbmJzcDtEQURBJm5ic3A7Jm5ic3A7UEVMTyZuYnNwOyZuYnNwO0ZBQlJJQ0FOVEU6Jm5ic3A7QksmbmJzcDsxMTcmbmJzcDtBJm5kYXNoOzMmbmJzcDsmbmJzcDtOVU1FUk8mbmJzcDtERSZuYnNwO1NFUklFOiZuYnNwOzcxMTQmbmJzcDsmbmJzcDtOT01FJm5ic3A7RE8mbmJzcDsKUFJPUFJJRVRBUklPOiZuYnNwOyZuYnNwO0hFTElKRVQmbmJzcDsmbmJzcDtBRVJPJm5ic3A7VEFYSSZuYnNwO0xUREEmbmJzcDtDR0MmbmJzcDtOwro6Jm5ic3A7MjcuMDA2LjA2My8wMDAxJm5kYXNoOzAxJm5ic3A7RE9NSUNJTElPJm5ic3A7RE8mbmJzcDsKUFJPUFJJRVRBUklPJm5ic3A7Jm5ic3A7OiZuYnNwO1BSQUNBJm5ic3A7U0VOQURPUiZuYnNwO1NBTEdBRE8mbmJzcDtGSUxITyZuYnNwO1MvTsK6LCZuYnNwO0FFUk9QT1JUTyZuYnNwO1NBTlRPUyZuYnNwO0RVTU9OVCwmbmJzcDtSSU8mbmJzcDsKREUmbmJzcDsmbmJzcDtKQU5FSVJPLCZuYnNwOyZuYnNwO1JKLCZuYnNwOyZuYnNwO0NFUCZuYnNwOzIwLjAwMCZuYnNwO0NBVEVHT1JJQTombmJzcDtUUFgmbmJzcDtSSU8mbmJzcDtERSZuYnNwO0pBTkVJUk8sJm5ic3A7MTcmbmJzcDtERSZuYnNwO0RFWkVNQlJPJm5ic3A7REUmbmJzcDsKMTk5MlhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWCZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwO01BVFLDjUNVTEEmbmJzcDs8YnIgLz4NCjxiciAvPg0KQ29uc2lkZXJhbmRvJm5ic3A7b3MmbmJzcDtkb2N1bWVudG9zJm5ic3A7anVudGFkb3MmbmJzcDthbyZuYnNwO3Byb2Nlc3NvJm5ic3A7bsK6Jm5ic3A7MDAwNjUuMDA5NjUzLzIwMTImbmRhc2g7NDEsJm5ic3A7ZGUmbmJzcDsyNCZuYnNwO2RlJm5ic3A7amFuZWlybyZuYnNwO2RlJm5ic3A7MjAxMiwmbmJzcDtmaWNhJm5ic3A7bWF0cmljdWxhZGEmbmJzcDthJm5ic3A7YWVyb25hdmUmbmJzcDthJm5ic3A7c2VndWlyJm5ic3A7ZGVzY3JpdGEsJm5ic3A7dGVuZG8mbmJzcDthJm5ic3A7ZXN0YSZuYnNwO3NpZG8mbmJzcDthdHJpYnXDrWRhcyZuYnNwO2FzJm5ic3A7bWFyY2FzJm5ic3A7ZGUmbmJzcDtuYWNpb25hbGlkYWRlJm5ic3A7ZSZuYnNwO2RlJm5ic3A7bWF0csOtY3VsYSZuYnNwO1BQJm5kYXNoO1BQUCwmbmJzcDtmYWJyaWNhbnRlJm5ic3A7UElQRVImbmJzcDtBSVJDUkFGVCwmbmJzcDttb2RlbG8mbmJzcDtQQSZuZGFzaDs0NlImbmRhc2g7MzUwVCwmbmJzcDtuwrombmJzcDtkZSZuYnNwO3PDqXJpZSZuYnNwOzQ2OTIwNzAsJm5ic3A7Y2F0ZWdvcmlhJm5ic3A7VFBQLCZuYnNwO2VtJm5ic3A7bm9tZSZuYnNwO2RlJm5ic3A7QkVOSkFNSU4mbmJzcDtQSVZFVEEmbmJzcDtBU1NVTsOHw4NPLCZuYnNwO0NQRiZuYnNwOzA4Ni41ODYuNTA5Jm5kYXNoOzQ0LCZuYnNwO2NvbSZuYnNwO2VuZGVyZcOnbyZuYnNwO8OgJm5ic3A7QVZFTklEQSZuYnNwO0JSQVNJTCwmbmJzcDtOwrombmJzcDszNzcyLCZuYnNwO1NBTEEmbmJzcDsxNTIyLCZuYnNwO01BUklOR8OBJm5ic3A7LyZuYnNwO1BSLCZuYnNwO0NFUCZuYnNwOzg3LjAxMyZuZGFzaDswMDAuPGJyIC8+DQpPQlNFUlZBw4fDlUVTOiZuYnNwO0EmbmJzcDthZXJvbmF2ZSZuYnNwO2ZvaSZuYnNwO3ZlbmRpZGEmbmJzcDtwb3ImbmJzcDtWRVJBQ0lUWSZuYnNwO0FWSUFUSU9OLCZuYnNwO0xMQyZuYnNwO8KWJm5ic3A7w7psdGltbyZuYnNwO3Byb3ByaWV0w6FyaW8mbmJzcDtyZWdpc3RyYWRvJm5ic3A7bmEmbmJzcDtGZWRlcmFsJm5ic3A7QXZpYXRpb24mbmJzcDtBZG1pbmlzdHJhdGlvbiZuYnNwO2RvcyZuYnNwO0VzdGFkb3MmbmJzcDtVbmlkb3MmbmJzcDtkYSZuYnNwO0Ftw6lyaWNhLCZuYnNwO2RlJm5ic3A7YWNvcmRvJm5ic3A7Y29tJm5ic3A7byZuYnNwO2RvY3VtZW50byZuYnNwO2RlJm5ic3A7ZGVzcmVnaXN0cm8mbmJzcDtqdW50YWRvJm5ic3A7w6BzJm5ic3A7ZmxzLiZuYnNwOzA3LzA5Jm5ic3A7Jm5kYXNoOyZuYnNwO3BhcmEmbmJzcDtCRU5KQU1JTiZuYnNwO1BJVkVUQSZuYnNwO0FTU1VOw4fDg08sJm5ic3A7Y29uZm9ybWUmbmJzcDthdGVzdGEmbmJzcDthJm5ic3A7QmlsbCZuYnNwO29mJm5ic3A7U2FsZSwmbmJzcDtqdW50YWRhJm5ic3A7w6BzJm5ic3A7ZmxzLiZuYnNwOzIwLiZuYnNwO0V4cG9ydCZuYnNwO0NlcnRpZmljYXRlJm5ic3A7b2YmbmJzcDtBaXJ3b3J0aGluZXNzJm5ic3A7bsK6Jm5ic3A7RSZuZGFzaDs0NDE1NjMsJm5ic3A7anVudGFkbyZuYnNwO8OgcyZuYnNwO2Zscy4mbmJzcDsyMS4mbmJzcDtBJm5ic3A7aW1wb3J0YcOnw6NvJm5ic3A7Zm9pJm5ic3A7cmVnaXN0cmFkYSZuYnNwO2VtJm5ic3A7MzEmbmJzcDtkZSZuYnNwO2Fnb3N0byZuYnNwO2RlJm5ic3A7MjAxMSwmbmJzcDtkZSZuYnNwO2Fjb3JkbyZuYnNwO2NvbSZuYnNwO0NvbXByb3ZhbnRlJm5ic3A7ZGUmbmJzcDtJbXBvcnRhw6fDo28mbmJzcDtlbWl0aWRvJm5ic3A7cGVsYSZuYnNwO1NlY3JldGFyaWEmbmJzcDtkYSZuYnNwO1JlY2VpdGEmbmJzcDtGZWRlcmFsJm5ic3A7ZG8mbmJzcDtCcmFzaWwmbmJzcDsoZmxzLiZuYnNwOzE0LzE5KSwmbmJzcDthcG9udGFuZG8mbmJzcDtjb21vJm5ic3A7dmFsb3ImbmJzcDt0b3RhbCZuYnNwO2RhJm5ic3A7aW1wb3J0YcOnw6NvJm5ic3A7YSZuYnNwO3F1YW50aWEmbmJzcDtkZSZuYnNwO1IkJm5ic3A7MS4xNzkuODY0LDAwJm5ic3A7KGh1bSZuYnNwO21pbGjDo28sJm5ic3A7Y2VudG8mbmJzcDtlJm5ic3A7c2V0ZW50YSZuYnNwO2UmbmJzcDtub3ZlJm5ic3A7bWlsJm5ic3A7ZSZuYnNwO29pdG9jZW50b3MmbmJzcDtlJm5ic3A7c2Vzc2VudGEmbmJzcDtlJm5ic3A7cXVhdHJvJm5ic3A7cmVhaXMpLCZuYnNwO2RhdGEmbmJzcDtkZSZuYnNwO2Rlc2VtYmFyYcOnbyZuYnNwO2VtJm5ic3A7MjMmbmJzcDtkZSZuYnNwO2RlemVtYnJvJm5ic3A7ZGUmbmJzcDsyMDExJm5ic3A7ZSZuYnNwO2RhdGEmbmJzcDtkZSZuYnNwO2VtaXNzw6NvJm5ic3A7ZGUmbmJzcDsyNiZuYnNwO2RlJm5ic3A7ZGV6ZW1icm8mbmJzcDtkZSZuYnNwOzIwMTEsJm5ic3A7cmVmZXJlbnRlJm5ic3A7w6AmbmJzcDtEZWNsYXJhw6fDo28mbmJzcDtkZSZuYnNwO0ltcG9ydGHDp8OjbyZuYnNwO27CuiZuYnNwOzExLzIzODgxNTEmbmRhc2g7Mi48YnIgLz4NCiZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwOyZuYnNwO0FWRVJCQcOHw4NPJm5ic3A7REUmbmJzcDtTRUdVUk8mbmJzcDtERSZuYnNwO0FFUk9OQVZFPGJyIC8+DQo8YnIgLz4NCkNvbnNpZGVyYW5kbyZuYnNwO29zJm5ic3A7ZG9jdW1lbnRvcyZuYnNwO2p1bnRhZG9zJm5ic3A7YW8mbmJzcDtwcm9jZXNzbyZuYnNwO27CuiZuYnNwOzAwMDY1LjAwOTY1My8yMDEyJm5kYXNoOzQxLCZuYnNwO2RlJm5ic3A7MjQmbmJzcDtkZSZuYnNwO2phbmVpcm8mbmJzcDtkZSZuYnNwOzIwMTIsJm5ic3A7ZmljYSZuYnNwO2F2ZXJiYWRvLCZuYnNwO2NvbmZvcm1lJm5ic3A7YXJ0LiZuYnNwOzI4MyZuYnNwO2RhJm5ic3A7TGVpJm5ic3A7Ny41NjUsJm5ic3A7ZGUmbmJzcDsxOSZuYnNwO2RlJm5ic3A7ZGV6ZW1icm8mbmJzcDtkZSZuYnNwOzE5ODYsJm5ic3A7byZuYnNwO0NFUlRJRklDQURPJm5ic3A7REUmbmJzcDtTRUdVUk8mbmJzcDtBRVJPTsOBVVRJQ08sJm5ic3A7YXDDs2xpY2UmbmJzcDtuwrombmJzcDszNTIvNDAwMDAxNDYyMDAwMDU2NzM1LCZuYnNwO2RlJm5ic3A7TUFQRlJFJm5ic3A7VkVSQSZuYnNwO0NSVVombmJzcDtTRUdVUkFET1JBJm5ic3A7Uy5BLiwmbmJzcDtjb20mbmJzcDtwcmF6byZuYnNwO2RlJm5ic3A7dmlnw6puY2lhJm5ic3A7ZGVzZGUmbmJzcDsyNCZuYnNwO2hvcmFzJm5ic3A7ZGUmbmJzcDsxNyZuYnNwO2RlJm5ic3A7amFuZWlybyZuYnNwO2RlJm5ic3A7MjAxMiZuYnNwO2F0w6kmbmJzcDsyNCZuYnNwO2hvcmFzJm5ic3A7ZGUmbmJzcDsyNCZuYnNwO2RlJm5ic3A7bm92ZW1icm8mbmJzcDtkZSZuYnNwOzIwMTIsJm5ic3A7cmVmZXJlbnRlJm5ic3A7w6AmbmJzcDthZXJvbmF2ZSZuYnNwO1BJUEVSJm5ic3A7QUlSQ1JBRlQsJm5ic3A7bW9kZWxvJm5ic3A7UEEmbmRhc2g7NDZSJm5kYXNoOzM1MFQsJm5ic3A7bsK6Jm5ic3A7ZGUmbmJzcDtzw6lyaWUmbmJzcDs0NjkyMDcwJm5ic3A7ZSZuYnNwO21hcmNhcyZuYnNwO1BQJm5kYXNoO1BQUCwmbmJzcDthbm8mbmJzcDtkZSZuYnNwO2ZhYnJpY2HDp8OjbyZuYnNwOzIwMDgsJm5ic3A7UE1EJm5ic3A7MS44ODYmbmJzcDtrZyZuYnNwO2UmbmJzcDtvcGVyYWRhJm5ic3A7cG9yJm5ic3A7QkVOSkFNSU4mbmJzcDtQSVZFVEEmbmJzcDtBU1NVTsOHw4NPJm5ic3A7Jm5kYXNoOyZuYnNwO0NQRiZuYnNwO27CuiZuYnNwOzA4Ni41ODYuNTA5Jm5kYXNoOzQ0LiZuYnNwO1NlZ3VybyZuYnNwO0dhcmFudGlhJm5ic3A7Ui5FLlQuQS4mbmJzcDsmbmRhc2g7Jm5ic3A7Q2xhc3NlcyZuYnNwOzImbmJzcDtlJm5ic3A7My80LiZuYnNwO05hJm5ic3A7Y2xhc3NlJm5ic3A7MiZuYnNwO28mbmJzcDtsaW1pdGUmbmJzcDtwb3ImbmJzcDt0cmlwdWxhbnRlJm5ic3A7KDAxJm5ic3A7YXNzZW50bykmbmJzcDvDqSZuYnNwO1IkJm5ic3A7NDYuOTcwLDc3LiZuYnNwO05hcyZuYnNwO2NsYXNzZXMmbmJzcDszJm5ic3A7ZSZuYnNwOzQmbmJzcDtvJm5ic3A7bGltaXRlJm5ic3A7w7puaWNvJm5ic3A7cG9yJm5ic3A7YWVyb25hdmUmbmJzcDvDqSZuYnNwO1IkJm5ic3A7MTU2LjYwMiw5MS4mbmJzcDtPJm5ic3A7bGltaXRlJm5ic3A7bcOheGltbyZuYnNwO3BvciZuYnNwO2FjaWRlbnRlJm5ic3A7cG9yJm5ic3A7YWVyb25hdmUmbmJzcDvDqSZuYnNwO1IkJm5ic3A7MjAzLjU3Myw2OC4mbmJzcDtEZW1haXMmbmJzcDt0ZXJtb3MmbmJzcDtlJm5ic3A7Y29uZGnDp8O1ZXMmbmJzcDtjb25mb3JtZSZuYnNwO2NlcnRpZmljYWRvJm5ic3A7cXVpdGFkbywmbmJzcDtqdW50YWRvJm5ic3A7YW8mbmJzcDtyZWZlcmlkbyZuYnNwO3Byb2Nlc3NvJm5ic3A7w6BzJm5ic3A7ZmxzLiZuYnNwOzEwLg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIDxiciAvPjxiciAvPg0KICAgICAgICAgICAgICAgICAgICAgICAgPC9kaXY+DQogICAgICAgICAgICAgICAgICAgIDwvdGQ+DQogICAgICAgICAgICAgICAgPC90cj4NCiAgICAgICAgICAgIDwvdGFibGU+DQoNCiAgICAgICAgPC9kaXY+DQogICAgICAgIDxociBzdHlsZT0iYm9yZGVyOiAxcHggc29saWQiIC8+DQogICAgICAgIDxkaXYgY2xhc3M9InJvdyI+DQogICAgICAgICAgICA8dGFibGUgc3R5bGU9IndpZHRoOjEwMCUiPg0KICAgICAgICAgICAgICAgIDx0cj4NCiAgICAgICAgICAgICAgICAgICAgPHRkPjxkaXYgY2xhc3M9ImNvbC1sZy0xMiI+QSBhY2VpdGHDp8OjbyBkZXN0YSBjZXJ0aWTDo28gZXN0w6EgY29uZGljaW9uYWRhIGEgdmVyaWZpY2HDp8OjbyBkZSBzdWEgYXV0ZW50aWNpZGFkZSBuYSBpbnRlcm5ldCwgbm8gZW5kZXJlw6dvPC9kaXY+PC90ZD4NCiAgICAgICAgICAgICAgICA8L3RyPg0KICAgICAgICAgICAgPC90YWJsZT4NCiAgICAgICAgPC9kaXY+DQogICAgICAgIDxiciAvPg0KICAgICAgICA8ZGl2IGNsYXNzPSJyb3ciPg0KICAgICAgICAgICAgPHRhYmxlIHN0eWxlPSJ3aWR0aDoxMDAlIj4NCiAgICAgICAgICAgICAgICA8dHI+DQogICAgICAgICAgICAgICAgICAgIDx0ZD4NCiAgICAgICAgICAgICAgICAgICAgICAgIDxkaXYgY2xhc3M9ImNvbC1sZy0xMiI+PGEgaHJlZj0iaHR0cDovL3N1Ym1pc3Nhby5hbmFjLmdvdi5ici9DTlBBL0NvbnN1bHRhclByb3ByaWVkYWRlIiwgdGFyZ2V0PSJfYmxhbmsiPmh0dHA6Ly9zdWJtaXNzYW8uYW5hYy5nb3YuYnIvQ05QQS9Db25zdWx0YXJQcm9wcmllZGFkZTwvYT48L2Rpdj4NCiAgICAgICAgICAgICAgICAgICAgPC90ZD4NCiAgICAgICAgICAgICAgICA8L3RyPg0KICAgICAgICAgICAgPC90YWJsZT4NCiAgICAgICAgPC9kaXY+DQogICAgICAgIDxiciAvPg0KDQogICAgICAgIDxkaXYgY2xhc3M9InJvdyI+DQogICAgICAgICAgICA8dGFibGUgc3R5bGU9IndpZHRoOjEwMCUiPg0KICAgICAgICAgICAgICAgIDx0cj4NCiAgICAgICAgICAgICAgICAgICAgPHRkPg0KICAgICAgICAgICAgICAgICAgICAgICAgPGRpdiBjbGFzcz0iY29sLWxnLTEyIj5Dw7NkaWdvIGRlIGNvbnRyb2xlIGRhIGNlcnRpZMOjbzogPGI+MDAwMDAwMDYwNC8yMDIyPC9iPjwvZGl2Pg0KICAgICAgICAgICAgICAgICAgICA8L3RkPg0KICAgICAgICAgICAgICAgIDwvdHI+DQogICAgICAgICAgICA8L3RhYmxlPg0KICAgICAgICA8L2Rpdj4NCg0KICAgICAgICA8YnIgLz4NCiAgICAgICAgPGRpdiBjbGFzcz0icm93Ij4NCiAgICAgICAgICAgIDx0YWJsZSBzdHlsZT0id2lkdGg6MTAwJSI+DQogICAgICAgICAgICAgICAgPHRyPg0KICAgICAgICAgICAgICAgICAgICA8dGQ+DQogICAgICAgICAgICAgICAgICAgICAgICA8ZGl2IGNsYXNzPSJjb2wtbGctMTIiPkF0ZW7Dp8OjbzogcXVhbHF1ZXIgcmFzdXJhIG91IGVtZW5kYSBpbnZhbGlkYXLDoSBlc3RlIGRvY3VtZW50by4gRWxhYm9yYWRhIHZpYSBJTlRFUk5FVC48L2Rpdj4NCiAgICAgICAgICAgICAgICAgICAgPC90ZD4NCiAgICAgICAgICAgICAgICA8L3RyPg0KICAgICAgICAgICAgPC90YWJsZT4NCiAgICAgICAgPC9kaXY+DQogICAgICAgIDxiciAvPg0KICAgICAgICA8ZGl2IGNsYXNzPSJyb3ciPg0KICAgICAgICAgICAgPHRhYmxlIHN0eWxlPSJ3aWR0aDoxMDAlIj4NCiAgICAgICAgICAgICAgICA8dHI+DQogICAgICAgICAgICAgICAgICAgIDx0ZD4NCiAgICAgICAgICAgICAgICAgICAgICAgIDxkaXYgY2xhc3M9ImNvbC1sZy0xMiI+PHAgc3R5bGU9ImZvbnQtd2VpZ2h0OjYwMCI+Q29uc3VsdGEgcmVhbGl6YWRhIGFzOiAxMjo0NDoxMCBkbyBkaWEgMjAvMDkvMjAyMiAoaG9yYSBlIGRhdGEgZGUgQnJhc8OtbGlhKS48L3A+PC9kaXY+DQogICAgICAgICAgICAgICAgICAgIDwvdGQ+DQogICAgICAgICAgICAgICAgPC90cj4NCiAgICAgICAgICAgIDwvdGFibGU+DQogICAgICAgIDwvZGl2Pg0KICAgIDwvZGl2Pg0KPC9ib2R5Pg0KPC9odG1sPg==</Conteudo>
		                                  <Data>20/09/2022</Data>
		                                  <!--<IdProcedimento>3417954</IdProcedimento> -->
		                                   <ProtocoloProcedimento xsi:type=""xsd:string"">00058.001055/2022-95</ProtocoloProcedimento>

		                                  <IdSerie>2884</IdSerie>
		                                  <NivelAcesso>0</NivelAcesso>
		                                  <NomeArquivo>DocumentoExterno.pdf</NomeArquivo>
		                                  <Tipo>R</Tipo>
		                                </Documento>

                                        </sei:incluirDocumento>
                                    </soapenv:Body>
                                </soapenv:Envelope>";

**/