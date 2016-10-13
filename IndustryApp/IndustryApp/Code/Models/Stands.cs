﻿using System.Collections.Generic;

namespace IndustryApp.Code.Models
{
    public class Stands
    {
        public int NumeroStand { get; set; }
        public string Nombre { get; set; }
        public string NumeroNombre { get; set; }

        public List<Stands> GetStands()
        {
            return new List<Stands>
            {
                //new Stands {NumeroStand = 002, Nombre = ""},
                new Stands {NumeroStand = 001, Nombre = "FIBRA Macquarie", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 002, Nombre = "P&Co", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 004, Nombre = "Prensas y Cilindros", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 005, Nombre = "Lubricantes de América", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 006, Nombre = "www.empleonuevo.com", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 007, Nombre = "Kafco de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 008, Nombre = "GIMAC", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 009, Nombre = "GIMAC", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 010, Nombre = "Kafco de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 011, Nombre = "Empresas Matco", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 012, Nombre = "Empresas Matco", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 013, Nombre = "Empresas Matco", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 014, Nombre = "Empresas Matco", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 015, Nombre = "Smurfit Kappa", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 016, Nombre = "Smurfit Kappa", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 017, Nombre = "Smurfit Kappa", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 018, Nombre = "Smurfit Kappa", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 019, Nombre = "Datatechnic Automatización y Servicio", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 020, Nombre = "Hiscomex", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 021, Nombre = "Soluciones de Aire", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 022, Nombre = "Modular Aluminio Estructural", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 023, Nombre = "Pexco Operaciones", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 024, Nombre = "Imexfast", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 025, Nombre = "Energía en Renta", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 026, Nombre = "Círculo Llantero", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 101, Nombre = "Palets Empaques y Embalajes", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 102, Nombre = "Suministros Industriales de Baja California", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 103, Nombre = "Suministros Industriales de Baja California", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 104, Nombre = "Steven Label Corp", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 105, Nombre = "Green Power", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 106, Nombre = "Instrumentos y Equipos Falcón", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 107, Nombre = "Baja California Railroad", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 108, Nombre = "T y P Refrigeración", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 109, Nombre = "Digiproduct", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 110, Nombre = "Cold Jet Latinoamérica", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 111, Nombre = "APN Piranha Canadá", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 112, Nombre = "RB Negocios", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 113, Nombre = "PROINDEMEX", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 114, Nombre = "Cadenas de Ayuda A.C.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 115, Nombre = "Integraciones Innovadoras J&J", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 116, Nombre = "American Bolt de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 117, Nombre = "CRC Industries", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 118, Nombre = "Industrias Especializadas Oliva", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 201, Nombre = "Lubricantes Gallardo", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 202, Nombre = "SIAT", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 203, Nombre = "SMK Electronics", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 204, Nombre = "Toyota Motor Manufacturing de B.C.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 205, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 206, Nombre = "DJO Orthopedics", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 207, Nombre = "Corrugados y Empaques de Norteamérica", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 208, Nombre = "Garage Photostudio", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 209, Nombre = "åtto Abrasives Ltd.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 210, Nombre = "Hilo Rojo", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 211, Nombre = "Etiquetas electránicas del Occidente", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 212, Nombre = "Advanex Americas Inc. / Fabricantes de Resortes", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 213, Nombre = "Motores y Controles Eléctricos", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 214, Nombre = "Corrugados y Empaques de Norteamérica", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 215, Nombre = "Sunrise Medical", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 216, Nombre = "JAE Tijuana", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 217, Nombre = "Toyota Motor Manufacturing de B.C.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 218, Nombre = "Bazz Houston", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 219, Nombre = "Capco Plastics", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 220, Nombre = "Compuproveedores", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 301, Nombre = "AIM Machines", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 302, Nombre = "Diproquim Industrial", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 303, Nombre = "Safety Stock", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 304, Nombre = "CITD - Pabellón California (USA)", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 305, Nombre = "CITD - Pabellón California (USA)", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 306, Nombre = "Allied Tool & Die", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 307, Nombre = "Grupo Loginam / Digixcan", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 308, Nombre = "Deltaplast", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 309, Nombre = "COEN", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 310, Nombre = "Baleros y Motores", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 311, Nombre = "Signal Test", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 312, Nombre = "Pemco", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 313, Nombre = "Pemco", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 314, Nombre = "Foam de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 315, Nombre = "Techmaster de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 316, Nombre = "Magid de México LLC.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 317, Nombre = "Arrega Tecnología SAPI", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 318, Nombre = "Safety Stock", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 319, Nombre = "Castelec México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 320, Nombre = "Centro de Ingeniería y Desarrollo Industrial", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 401, Nombre = "Southland Polymers Inc.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 402, Nombre = "Berkshire Corp.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 403, Nombre = "Testequity de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 404, Nombre = "IPS", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 405, Nombre = "GYGO Servicios Asesoria y Comercialización", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 406, Nombre = "Pisos Eficientes", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 407, Nombre = "Pisos Eficientes", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 408, Nombre = "Az Tools", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 409, Nombre = "Ingersoll Rand", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 410, Nombre = "Viakon", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 411, Nombre = "Arquitectos Especializados del Noroeste", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 412, Nombre = "HTP de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 413, Nombre = "Clover 3D", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 414, Nombre = "Pegamentos y Productos Industriales", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 501, Nombre = "Wens Graphic", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 502, Nombre = "Igus México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 503, Nombre = "Machine Tools Supply de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 504, Nombre = "H&J Precision Tools de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 505, Nombre = "Laube Technology", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 506, Nombre = "Clima y Mantenimiento del Noroeste", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 507, Nombre = "Midexacto", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 508, Nombre = "Distribuidora DC", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 509, Nombre = "CE & HP", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 510, Nombre = "CE & HP", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 511, Nombre = "H&J Precision Tools de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 512, Nombre = "Machine Tools Supply de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 513, Nombre = "Accutite Fasteners Inc.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 514, Nombre = "Maniobras de Precisión", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 601, Nombre = "Cali Resources", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 602, Nombre = "Thyssenkrupp Materials North America - Ken Mac Metals Division", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                //new Stands {NumeroStand = 002, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 603, Nombre = "Uline Shipping Supplies", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 604, Nombre = "Landsberg", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 605, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 606, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 607, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 608, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 609, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 610, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 611, Nombre = "Landsberg", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 612, Nombre = "Uline Shipping Supplies", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 613, Nombre = "Inova", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 614, Nombre = "Excell Limpieza", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 701, Nombre = "Coast Metal Supply", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 702, Nombre = "RSI México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 703, Nombre = "RSI México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 704, Nombre = "Lee Spring de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 705, Nombre = "Export Dynamics de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 706, Nombre = "Export Dynamics de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 707, Nombre = "Medtronic Tijuana El Lago", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 708, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 709, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 710, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 711, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 712, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 713, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 714, Nombre = "Ossur", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 715, Nombre = "Marman Industries Inc.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 716, Nombre = "Turismo Tijuana", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 717, Nombre = "SEI Automation", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 718, Nombre = "Insumos y Servicios", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 719, Nombre = "Sonora S. Plan", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 720, Nombre = "Maquinaria de Elevación", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 801, Nombre = "Vallen Proveedora Industrial", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 802, Nombre = "Neyenesch Printers Inc.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 803, Nombre = "Mission Plastics", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 804, Nombre = "Ensenada International Terminal", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 805, Nombre = "Publicidad Zin Limites", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 806, Nombre = "VEM Tooling", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 807, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 808, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 809, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 810, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 811, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 812, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 813, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 814, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 815, Nombre = "PDQ Precision", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 816, Nombre = "WEG Tijuana", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 817, Nombre = "CIBanco", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 818, Nombre = "Especialidades Troqueladas", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 819, Nombre = "BC Industrial Supply", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 820, Nombre = "Iris Chemical", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 901, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 902, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 903, Nombre = "Continuous Coating Corp.", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 904, Nombre = "KTL Manufacturing", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 905, Nombre = "Sigmatron International", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 906, Nombre = "Tijuana EDC", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 907, Nombre = "Productora de Cajas de Cartón", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 908, Nombre = "CETYS Universidad", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 909, Nombre = "LOGTECH", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 910, Nombre = "Gefran México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 911, Nombre = "Profe-Part", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 912, Nombre = "Proyectos y Equipos del Noroeste", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 913, Nombre = "Celulosa y Corrugados de Sonora", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 914, Nombre = "Celulosa y Corrugados de Sonora", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 915, Nombre = "C&V Technoplast", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 916, Nombre = "C&V Technoplast", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 917, Nombre = "Simpack de México", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 918, Nombre = "INTERMAQ", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 919, Nombre = "Open Ware House", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
                new Stands {NumeroStand = 920, Nombre = "", NumeroNombre = NumeroStand.ToString() + " - " + Nombre},
            };

        }
    }
}
