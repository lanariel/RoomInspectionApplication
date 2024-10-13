
using System.ComponentModel;

namespace RoomInspectionApplication
{
    public enum RoomName
    {
        None,
        [Description("Bokhyllerummet")]
        Bokhyllerum,
        [Description("Datorrummet")]
        Datorrum,
        [Description("Lilla köket")]
        Lilla_köket,
        [Description("Lilla badrummet")]
        Lilla_badrummet,
        [Description("Skrivarrummet")]
        Skrivarrum,
        [Description("Administrationsrummet")]
        Administrationsrum,
        [Description("Kundmottagningsrummet")]
        Kundmotagningsrum,
        [Description("Konferensrummet")]
        Konferensrum,
        [Description("Lilla rummet")]
        Lilla_rummet,
        [Description("Stora köket")]
        Stora_köket,
        [Description("Stora badrummet")]
        Stora_badrummet
    }

    public class InspectionType
    {
        private string name;
        public string Name => name;
        private string description;
        public string Description => description;
        private InspectionType(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public static InspectionType Doors = new InspectionType("Dörrar", "Handtag, lås, funktion (knarr, dålig passning, etc.) renhet med mera");
        public static InspectionType Windows = new InspectionType("Fönster", "Handtag, lås, funktion (knarr, dålig passning, etc.) renhet med mera");
        public static InspectionType Walls = new InspectionType("Skador på golv och väggar", "tavelkrokar som inte används, skador på målning med mera");
        public static InspectionType Sockets = new InspectionType("Eluttag", "Lösa, skadade, fungerar");
        public static InspectionType Lights = new InspectionType("Lyse", "Blinkar, funkar");
        public static InspectionType Whiteboard = new InspectionType("Whiteboard", "Ren");
        public static InspectionType Projector = new InspectionType("Projector", "Funktion");
        public static InspectionType FireExtinguisher = new InspectionType("Brandsläckare / Brandfilt", "Kontrollera att de finns där de ska vara, kontrollera datummärkning");
        public static InspectionType Water = new InspectionType("Toaletter och vaskar", "Kontrollera att toaletterna spolar som de ska och att det inte droppar från kranarna");
        public static InspectionType Other = new InspectionType("Övrigt", "Övrigt som verkar behöva åtgärdas");
    }
}