using System.ComponentModel.DataAnnotations.Schema;

namespace BibleReadingSystem.Data.Entities;

public class ReadingPlanListBibleBook : ISoftDeletable
{
    public Guid Id { get; set; }
    
    public Guid ReadingPlanListId { get; set; }
    
    [ForeignKey(nameof(ReadingPlanListId))]
    public ReadingPlanList ReadingPlanList { get; set; } = null!;
    
    public Guid BibleBookId { get; set; }
    
    [ForeignKey(nameof(BibleBookId))]
    public BibleBook BibleBook { get; set; } = null!;
    
    public bool IsDeleted { get; set; }
}

public static class ProfessorGrantHornerListBibleBooks
{
    public static readonly ReadingPlanListBibleBook List1Matthew = new()
    {
        Id = Guid.Parse("9B2EA912-C30E-4375-86A6-38A4071A6B6C"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList1.Id,
        BibleBookId = BibleBooks.Matthew.Id
    };
    
    public static readonly ReadingPlanListBibleBook List1Mark = new()
    {
        Id = Guid.Parse("A45E8705-371E-488D-A7D0-660C26271AB8"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList1.Id,
        BibleBookId = BibleBooks.Mark.Id
    };
    
    public static readonly ReadingPlanListBibleBook List1Luke = new()
    {
        Id = Guid.Parse("639F5C36-C2D4-4D29-AE4C-230EA285DA11"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList1.Id,
        BibleBookId = BibleBooks.Luke.Id
    };
    
    public static readonly ReadingPlanListBibleBook List1John = new()
    {
        Id = Guid.Parse("E6D0BFD2-F582-45E9-BEDD-F5116A1EE0E5"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList1.Id,
        BibleBookId = BibleBooks.John.Id
    };
    
    public static readonly ReadingPlanListBibleBook List2Genesis = new()
    {
        Id = Guid.Parse("760F2AC2-D602-4F70-A786-AEEB54B6454D"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList2.Id,
        BibleBookId = BibleBooks.Genesis.Id
    };
    
    public static readonly ReadingPlanListBibleBook List2Exodus = new()
    {
        Id = Guid.Parse("3058131C-A8B8-408F-B504-13CA4C3CAFF5"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList2.Id,
        BibleBookId = BibleBooks.Exodus.Id
    };
    
    public static readonly ReadingPlanListBibleBook List2Leviticus = new()
    {
        Id = Guid.Parse("AD836274-1D1C-4B10-A401-305E6F0660D6"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList2.Id,
        BibleBookId = BibleBooks.Leviticus.Id
    };
    
    public static readonly ReadingPlanListBibleBook List2Numbers = new()
    {
        Id = Guid.Parse("60BC5193-DDDC-4ADE-BBE8-BC6FECCB402B"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList2.Id,
        BibleBookId = BibleBooks.Numbers.Id
    };
    
    public static readonly ReadingPlanListBibleBook List2Deuteronomy = new()
    {
        Id = Guid.Parse("A6C5315D-9732-4733-81FA-1A627A9A2C1F"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList2.Id,
        BibleBookId = BibleBooks.Deuteronomy.Id
    };
    
    public static readonly ReadingPlanListBibleBook List3Romans = new()
    {
        Id = Guid.Parse("67D97C49-432E-4775-B034-756F19DCEADD"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList3.Id,
        BibleBookId = BibleBooks.Romans.Id
    };
    
    public static readonly ReadingPlanListBibleBook List3FirstCorinthians = new()
    {
        Id = Guid.Parse("C762D218-6127-45C4-90B3-136D0DF8839D"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList3.Id,
        BibleBookId = BibleBooks.FirstCorinthians.Id
    };
    
    public static readonly ReadingPlanListBibleBook List3SecondCorinthians = new()
    {
        Id = Guid.Parse("C0EBAC88-D1E0-4B09-8017-B79033D16F3A"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList3.Id,
        BibleBookId = BibleBooks.SecondCorinthians.Id
    };
    
    public static readonly ReadingPlanListBibleBook List3Galatians = new()
    {
        Id = Guid.Parse("1CBB49CA-BEAE-4369-8BCC-94054D702DC7"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList3.Id,
        BibleBookId = BibleBooks.Galatians.Id
    };
    
    public static readonly ReadingPlanListBibleBook List3Ephesians = new()
    {
        Id = Guid.Parse("21E10A44-342F-4F05-8F9B-1C011809CA86"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList3.Id,
        BibleBookId = BibleBooks.Ephesians.Id
    };
    
    public static readonly ReadingPlanListBibleBook List3Philippians = new()
    {
        Id = Guid.Parse("178A2BF8-8A21-421C-AAA3-F7101F345F88"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList3.Id,
        BibleBookId = BibleBooks.Philippians.Id
    };
    
    public static readonly ReadingPlanListBibleBook List3Colossians = new()
    {
        Id = Guid.Parse("11D4FD27-9594-40EA-BF60-BB0D8E025C80"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList3.Id,
        BibleBookId = BibleBooks.Colossians.Id
    };
    
    public static readonly ReadingPlanListBibleBook List3Hebrews = new()
    {
        Id = Guid.Parse("642538B5-1D13-4234-8F35-F6CADF33EE75"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList3.Id,
        BibleBookId = BibleBooks.Hebrews.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4FirstThessalonians = new()
    {
        Id = Guid.Parse("C12AE676-23B6-4B99-8E0D-0443445495FD"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.FirstThessalonians.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4SecondThessalonians = new()
    {
        Id = Guid.Parse("0956B0A6-AFD8-48FD-8CC5-0AF1E1113ABA"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.SecondThessalonians.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4FirstTimothy = new()
    {
        Id = Guid.Parse("CD3D0E20-7F81-47FC-A456-2A812B9CE9AB"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.FirstTimothy.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4SecondTimothy = new()
    {
        Id = Guid.Parse("FC6A8505-1A5E-4BD8-8A07-DB8838676CE1"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.SecondTimothy.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4Titus = new()
    {
        Id = Guid.Parse("35AB1FC5-CC72-48B6-9384-97689E06F388"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.Titus.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4Philemon = new()
    {
        Id = Guid.Parse("ADC92AC7-EC4D-4B22-898D-5F75B6CDE99C"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.Philemon.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4James = new()
    {
        Id = Guid.Parse("F4706FDC-CFF4-45C5-A551-90E5C995AE24"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.James.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4FirstPeter = new()
    {
        Id = Guid.Parse("E9166A80-56E8-4AA5-A391-43508B506E31"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.FirstPeter.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4SecondPeter = new()
    {
        Id = Guid.Parse("955B8B77-F7E7-4671-A62D-DE746C3D846A"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.SecondPeter.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4FirstJohn = new()
    {
        Id = Guid.Parse("667E2A41-0CB7-492A-9F18-2A09665F7AC6"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.FirstJohn.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4SecondJohn = new()
    {
        Id = Guid.Parse("784F2449-D09F-41E7-B227-2E00080A5940"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.SecondJohn.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4ThirdJohn = new()
    {
        Id = Guid.Parse("E4AFCC2D-C5AC-4C78-9080-609BF86FDB49"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.ThirdJohn.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4Jude = new()
    {
        Id = Guid.Parse("F3B120BD-F8F1-42B6-A24F-602D4728CFD9"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.Jude.Id
    };
    
    public static readonly ReadingPlanListBibleBook List4Revelation = new()
    {
        Id = Guid.Parse("2E5E2403-AC50-4AF8-82B0-6194DF4B5C26"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList4.Id,
        BibleBookId = BibleBooks.Revelation.Id
    };

    public static readonly ReadingPlanListBibleBook List5Job = new()
    {
        Id = Guid.Parse("7E6771B6-DE0E-42F9-B8FA-C48B1D9D2726"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList5.Id,
        BibleBookId = BibleBooks.Job.Id
    };

    public static readonly ReadingPlanListBibleBook List5Ecclesiastes = new()
    {
        Id = Guid.Parse("7DE49009-CBD9-4F2C-9976-015633D58E53"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList5.Id,
        BibleBookId = BibleBooks.Ecclesiastes.Id
    };

    public static readonly ReadingPlanListBibleBook List5SongOfSolomon = new()
    {
        Id = Guid.Parse("CBEB4E2B-DB3D-4C83-B6AC-CB24E4842FB8"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList5.Id,
        BibleBookId = BibleBooks.SongOfSolomon.Id
    };
    
    public static readonly ReadingPlanListBibleBook List6Psalms = new()
    {
        Id = Guid.Parse("3DA32FD6-F1C2-45CF-9CB3-50C3FE2CC43B"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList6.Id,
        BibleBookId = BibleBooks.Psalms.Id
    };
    
    public static readonly ReadingPlanListBibleBook List7Proverbs = new()
    {
        Id = Guid.Parse("313C1544-8B6B-43C3-B32C-0E9AD8281BD5"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList7.Id,
        BibleBookId = BibleBooks.Proverbs.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8Joshua = new()
    {
        Id = Guid.Parse("29FD0BB2-97E6-4838-873D-4659BF77170F"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.Joshua.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8Judges = new()
    {
        Id = Guid.Parse("CFD66731-372B-4717-9ED7-79CEE0CC5617"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.Judges.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8Ruth = new()
    {
        Id = Guid.Parse("2BD80269-2F2C-43AF-9D56-AF548BE2FBB2"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.Ruth.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8FirstSamuel = new()
    {
        Id = Guid.Parse("4EF34407-8540-42DF-959B-16C28AAF4D03"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.FirstSamuel.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8SecondSamuel = new()
    {
        Id = Guid.Parse("C9677F1A-CABC-42CC-9DAF-C7A7428B8AF9"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.SecondSamuel.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8FirstKings = new()
    {
        Id = Guid.Parse("DF99713C-D2CF-4E85-9309-BFA0FBE7BCC7"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.FirstKings.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8SecondKings = new()
    {
        Id = Guid.Parse("21C6AF9D-CA16-4983-BB10-43655E45CD05"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.SecondKings.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8FirstChronicles = new()
    {
        Id = Guid.Parse("329D2214-ECCC-4549-9DF2-787D4C4A5265"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.FirstChronicles.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8SecondChronicles = new()
    {
        Id = Guid.Parse("CBACA0DC-4D34-4F0D-95CB-7ACF992A502C"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.SecondChronicles.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8Ezra = new()
    {
        Id = Guid.Parse("FC0A6CE6-B15D-4BCB-A272-69ADAFF35AF0"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.Ezra.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8Nehemiah = new()
    {
        Id = Guid.Parse("1183D607-7E21-4FEE-8935-4377184DD63F"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.Nehemiah.Id
    };
    
    public static readonly ReadingPlanListBibleBook List8Esther = new()
    {
        Id = Guid.Parse("072361ED-9D6F-4FBD-9E12-498E23A89488"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList8.Id,
        BibleBookId = BibleBooks.Esther.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Isaiah = new()
    {
        Id = Guid.Parse("7C32F3C7-0069-408C-9D6D-E89F4FD4ADC4"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Isaiah.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Jeremiah = new()
    {
        Id = Guid.Parse("84C66E88-F825-4553-89AC-338DB0EEDCF6"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Jeremiah.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Lamentations = new()
    {
        Id = Guid.Parse("2DD9AC14-2B29-4026-BFAF-CAD8FB624404"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Lamentations.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Ezekiel = new()
    {
        Id = Guid.Parse("2EBD4C98-C4BE-4447-9232-5AF31750FC5C"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Ezekiel.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Daniel = new()
    {
        Id = Guid.Parse("74B45C2D-489E-4F93-A86A-A32EEE6C3A5C"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Daniel.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Hosea = new()
    {
        Id = Guid.Parse("03AEA73E-A649-4128-BB39-D07D6D9C98DF"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Hosea.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Joel = new()
    {
        Id = Guid.Parse("48B36396-C984-4D9B-BFE9-D482444D84C3"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Joel.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Amos = new()
    {
        Id = Guid.Parse("4AC7A9C1-83E2-4443-A642-6C7F3DF50B26"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Amos.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Obadiah = new()
    {
        Id = Guid.Parse("307C946E-864F-4900-AB1C-6A43F29082CE"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Obadiah.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Jonah = new()
    {
        Id = Guid.Parse("ED268988-27F1-4F3C-B4AC-611155BD4FBD"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Jonah.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Micah = new()
    {
        Id = Guid.Parse("F8552EDF-0CDE-4AD6-B9F4-5187D9B6713A"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Micah.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Nahum = new()
    {
        Id = Guid.Parse("0947026C-6F85-4615-8082-87A9455A5865"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Nahum.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Habakkuk = new()
    {
        Id = Guid.Parse("B45563E0-4342-42EC-8F6B-4309307577C4"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Habakkuk.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Zephaniah = new()
    {
        Id = Guid.Parse("D7D6D21C-E6DD-447F-A15E-57052FD619A2"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Zephaniah.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Haggai = new()
    {
        Id = Guid.Parse("D76B5935-909D-4117-89CE-B9951DD4F105"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Haggai.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Zechariah = new()
    {
        Id = Guid.Parse("81E4DD1B-96CC-4568-B219-85B71662040B"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Zechariah.Id
    };
    
    public static readonly ReadingPlanListBibleBook List9Malachi = new()
    {
        Id = Guid.Parse("BE3AEC6A-88A1-49C9-BC25-B2038C41F2E9"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList9.Id,
        BibleBookId = BibleBooks.Malachi.Id
    };
    
    public static readonly ReadingPlanListBibleBook List10Acts = new()
    {
        Id = Guid.Parse("5D47149E-D5D4-4117-8FAA-992B7A1158C7"),
        ReadingPlanListId = ReadingPlanLists.ProfessorGrantHornerList10.Id,
        BibleBookId = BibleBooks.Acts.Id
    };

    public static readonly IReadOnlyList<ReadingPlanListBibleBook> All =
    [
        List1Matthew, List1Mark, List1Luke, List1John, List2Genesis, List2Exodus, List2Leviticus, List2Numbers,
        List2Deuteronomy, List3Romans, List3FirstCorinthians, List3SecondCorinthians, List3Galatians, List3Ephesians,
        List3Philippians, List3Colossians, List3Hebrews, List4FirstThessalonians, List4SecondThessalonians,
        List4FirstTimothy, List4SecondTimothy, List4Titus, List4Philemon, List4James, List4FirstPeter, List4SecondPeter,
        List4FirstJohn, List4SecondJohn, List4ThirdJohn, List4Jude, List4Revelation, List5Job, List5Ecclesiastes,
        List5SongOfSolomon, List6Psalms, List7Proverbs, List8Joshua, List8Judges, List8Ruth, List8FirstSamuel,
        List8SecondSamuel, List8FirstKings, List8SecondKings, List8FirstChronicles, List8SecondChronicles, List8Ezra,
        List8Nehemiah, List8Esther, List9Isaiah, List9Jeremiah, List9Lamentations, List9Ezekiel, List9Daniel,
        List9Hosea, List9Joel, List9Amos, List9Obadiah, List9Jonah, List9Micah, List9Nahum, List9Habakkuk,
        List9Zephaniah, List9Haggai, List9Zechariah, List9Malachi, List10Acts
    ];
}