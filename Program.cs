List<string> invitees = new List<string>(); // List of type String was created

invitees.Add("Bülent Ersoy");
invitees.Add("Ajda Pekkan");
invitees.Add("Ebru Gündeş");
invitees.Add("Hadise");
invitees.Add("Hande Yener");
invitees.Add("Tarkan");
invitees.Add("Funda Arar");
invitees.Add("Demet Akalın");

foreach (string invite in invitees) // Names in invitees were printed on the screen with a forach
{
    Console.WriteLine(invite);
}
