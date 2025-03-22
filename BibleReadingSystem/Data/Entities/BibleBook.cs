using System.ComponentModel.DataAnnotations;

namespace BibleReadingSystem.Data.Entities;

public class BibleBook : ISoftDeletable
{
    public Guid Id { get; set; }
    
    [MaxLength(32)]
    public string Name { get; set; } = string.Empty;

    public ICollection<BibleChapter> BibleChapters = new List<BibleChapter>();
    
    public int BookNumber { get; set; }
    
    public bool IsDeleted { get; set; }
}

public static class BibleBooks
{
    public static readonly BibleBook Genesis = new()
    {
        Id = Guid.Parse("941362D9-A2E0-4FB8-8943-1DE741F7DB8F"), 
        Name = "Genesis", 
        BookNumber = 1
    };
    
    public static readonly BibleBook Exodus = new()
    {
        Id = Guid.Parse("8268D09D-7115-4584-B167-9E28EDB028A7"), 
        Name = "Exodus", 
        BookNumber = 2
    };
    
    public static readonly BibleBook Leviticus = new()
    {
        Id = Guid.Parse("758DA933-CF9A-4322-AB46-ECCF8E4EDF3C"), 
        Name = "Leviticus", 
        BookNumber = 3
    };
    
    public static readonly BibleBook Numbers = new()
    {
        Id = Guid.Parse("D5835B64-9F8C-4F75-B786-2A0D006EE04E"), 
        Name = "Numbers", 
        BookNumber = 4
    };
    
    public static readonly BibleBook Deuteronomy = new()
    {
        Id = Guid.Parse("D20745D1-46E4-4CB8-9D99-EF865B058651"), 
        Name = "Deuteronomy", 
        BookNumber = 5
    };
    
    public static readonly BibleBook Joshua = new() 
    {
        Id = Guid.Parse("7D8C8D88-7CF4-4409-A8AF-7735B1D0481F"), 
        Name = "Joshua", 
        BookNumber = 6
    };
    
    public static readonly BibleBook Judges = new() 
    {
        Id = Guid.Parse("9FC43925-78BE-47E5-B61A-0AA306E36A25"), 
        Name = "Judges", 
        BookNumber = 7
    };
    
    public static readonly BibleBook Ruth = new() 
    {
        Id = Guid.Parse("1E57B873-250D-47E2-A5BF-A536ABB416DD"), 
        Name = "Ruth", 
        BookNumber = 8
    };
    
    public static readonly BibleBook FirstSamuel = new() 
    {
        Id = Guid.Parse("D4E1733F-A95E-4889-BFAA-C26A2C1FE6C7"), 
        Name = "1 Samuel", 
        BookNumber = 9
    };
    
    public static readonly BibleBook SecondSamuel = new() 
    {
        Id = Guid.Parse("FDF95D6F-BC0E-45B9-9DA2-75605314093B"), 
        Name = "2 Samuel", 
        BookNumber = 10
    };
    
    public static readonly BibleBook FirstKings = new() 
    {
        Id = Guid.Parse("53354D0E-CD91-4454-BE35-DE0A6A7EB776"), 
        Name = "1 Kings", 
        BookNumber = 11
    };
    
    public static readonly BibleBook SecondKings = new() 
    {
        Id = Guid.Parse("563B55A8-AF45-4EA0-BE09-C21A20E5CD47"), 
        Name = "2 Kings", 
        BookNumber = 12
    };
    
    public static readonly BibleBook FirstChronicles = new() 
    {
        Id = Guid.Parse("7C39F9BB-CE5F-4DE7-A8AC-A517A188F1C8"), 
        Name = "1 Chronicles", 
        BookNumber = 13
    };
    
    public static readonly BibleBook SecondChronicles = new() 
    {
        Id = Guid.Parse("170ABE4E-FF9E-4FC3-B2A0-CC3C5AA0EDFF"), 
        Name = "2 Chronicles", 
        BookNumber = 14
    };
    
    public static readonly BibleBook Ezra = new() 
    {
        Id = Guid.Parse("740F2044-0F63-4B13-A07B-6C802D159A99"), 
        Name = "Ezra", 
        BookNumber = 15
    };
    
    public static readonly BibleBook Nehemiah = new() 
    {
        Id = Guid.Parse("6813231C-D685-4698-9DF8-A47B4A6A3527"), 
        Name = "Nehemiah", 
        BookNumber = 16
    };
    
    public static readonly BibleBook Esther = new() 
    {
        Id = Guid.Parse("18D4A16C-CB0B-409B-B547-A8E37009A140"), 
        Name = "Esther", 
        BookNumber = 17
    };
    
    public static readonly BibleBook Job = new() 
    {
        Id = Guid.Parse("4E19ECFE-3F08-4717-967E-DDC8D0B31105"), 
        Name = "Job", 
        BookNumber = 18
    };
    
    public static readonly BibleBook Psalms = new() 
    {
        Id = Guid.Parse("0C13D0AA-C792-4729-AF5D-5B44C413B1FA"), 
        Name = "Psalms", 
        BookNumber = 19
    };
    
    public static readonly BibleBook Proverbs = new() 
    {
        Id = Guid.Parse("DFF15288-5E76-436E-AC26-33C2866A12E7"), 
        Name = "Proverbs", 
        BookNumber = 20
    };
    
    public static readonly BibleBook Ecclesiastes = new() 
    {
        Id = Guid.Parse("FD10C485-96B3-45FA-BE35-48A66FB994A0"), 
        Name = "Ecclesiastes", 
        BookNumber = 21
    };
    
    public static readonly BibleBook SongOfSolomon = new() 
    {
        Id = Guid.Parse("6EC286F3-2CC1-4CB7-9B97-A95FDF76CEE1"), 
        Name = "Song of Solomon", 
        BookNumber = 22
    };
    
    public static readonly BibleBook Isaiah = new() 
    {
        Id = Guid.Parse("B392194D-1A88-49D3-92F6-3671E6E1F113"), 
        Name = "Isaiah", 
        BookNumber = 23
    };
    
    public static readonly BibleBook Jeremiah = new() 
    {
        Id = Guid.Parse("9458FE07-BC47-4C43-9FB1-3A9912DE3A07"), 
        Name = "Jeremiah", 
        BookNumber = 24
    };
    
    public static readonly BibleBook Lamentations = new() 
    {
        Id = Guid.Parse("FAF838C8-AD2B-46FF-B34C-E137C91E9628"), 
        Name = "Lamentations", 
        BookNumber = 25
    };
    
    public static readonly BibleBook Ezekiel = new() 
    {
        Id = Guid.Parse("D0BDA764-7A29-4A14-A782-17D25C0A3AA4"), 
        Name = "Ezekiel", 
        BookNumber = 26
    };
    
    public static readonly BibleBook Daniel = new() 
    {
        Id = Guid.Parse("31186281-C83C-4D27-958E-07A23443E508"), 
        Name = "Daniel", 
        BookNumber = 27
    };
    
    public static readonly BibleBook Hosea = new() 
    {
        Id = Guid.Parse("D89B5CA2-B8CF-4494-AA74-6EC0202854EF"), 
        Name = "Hosea", 
        BookNumber = 28
    };
    
    public static readonly BibleBook Joel = new() 
    {
        Id = Guid.Parse("BB943306-AE15-43D3-B801-5C3E641389EB"), 
        Name = "Joel", 
        BookNumber = 29
    };
    
    public static readonly BibleBook Amos = new() 
    {
        Id = Guid.Parse("259413BA-8B67-423B-9F80-046E2A787E8B"), 
        Name = "Amos", 
        BookNumber = 30
    };
    
    public static readonly BibleBook Obadiah = new() 
    {
        Id = Guid.Parse("7EBC039E-F313-40CF-9802-1C1F50586AF8"), 
        Name = "Obadiah", 
        BookNumber = 31
    };
    
    public static readonly BibleBook Jonah = new() 
    {
        Id = Guid.Parse("B0388411-9316-4164-A917-6D01E3C2C23F"), 
        Name = "Jonah", 
        BookNumber = 32
    };
    
    public static readonly BibleBook Micah = new() 
    {
        Id = Guid.Parse("38E989DD-13AD-4AE3-B973-0CA0F619B86D"), 
        Name = "Micah", 
        BookNumber = 33
    };
    
    public static readonly BibleBook Nahum = new() 
    {
        Id = Guid.Parse("D7049536-570D-426E-9E00-7CAC584D9E7A"), 
        Name = "Nahum", 
        BookNumber = 34
    };
    
    public static readonly BibleBook Habakkuk = new() 
    {
        Id = Guid.Parse("E664E47E-1189-41DD-8870-390FF91A2084"), 
        Name = "Habakkuk", 
        BookNumber = 35
    };
    
    public static readonly BibleBook Zephaniah = new() 
    {
        Id = Guid.Parse("92F9CF16-81D6-4FF7-A436-B3A19B3853AC"), 
        Name = "Zephaniah", 
        BookNumber = 36
    };
    
    public static readonly BibleBook Haggai = new() 
    {
        Id = Guid.Parse("C4831B20-1C23-40C3-91A2-0AAB04E23092"), 
        Name = "Haggai", 
        BookNumber = 37
    };
    
    public static readonly BibleBook Zechariah = new() 
    {
        Id = Guid.Parse("E0A7E635-A130-4811-BE6A-31D532E2FC1C"), 
        Name = "Zechariah", 
        BookNumber = 38
    };
    
    public static readonly BibleBook Malachi = new() 
    {
        Id = Guid.Parse("4022FB3B-5A47-4E18-A0C7-7DED87110E8C"), 
        Name = "Malachi", 
        BookNumber = 39
    };
    
    public static readonly BibleBook Matthew = new() 
    {
        Id = Guid.Parse("F99E0E0A-3DC0-4851-A5DF-0AA45E9A0E56"), 
        Name = "Matthew", 
        BookNumber = 40
    };
    
    public static readonly BibleBook Mark = new() 
    {
        Id = Guid.Parse("58B893DD-0454-483C-B848-FCE040C8C13E"), 
        Name = "Mark", 
        BookNumber = 41
    };
    
    public static readonly BibleBook Luke = new() 
    {
        Id = Guid.Parse("0AC7DD9E-EF81-4878-851A-11A03FB59E7A"), 
        Name = "Luke", 
        BookNumber = 42
    };
    
    public static readonly BibleBook John = new() 
    {
        Id = Guid.Parse("5E2D70D2-20B5-45A6-952C-1F6B6436F0FC"), 
        Name = "John", 
        BookNumber = 43
    };
    
    public static readonly BibleBook Acts = new() 
    {
        Id = Guid.Parse("0BC854A8-ADB6-46B9-BD4B-747ADCDB85D1"), 
        Name = "Acts", 
        BookNumber = 44
    };
    
    public static readonly BibleBook Romans = new() 
    {
        Id = Guid.Parse("6E2A4F0F-FC19-4B6C-AD5B-DFFF3DCC5F2F"), 
        Name = "Romans", 
        BookNumber = 45
    };
    
    public static readonly BibleBook FirstCorinthians = new() 
    {
        Id = Guid.Parse("D8C07813-02C1-4E4A-8E64-D0B8CF4A5132"), 
        Name = "1 Corinthians", 
        BookNumber = 46
    };
    
    public static readonly BibleBook SecondCorinthians = new() 
    {
        Id = Guid.Parse("BA6298DA-003B-493E-B120-34191AF3CBC8"), 
        Name = "2 Corinthians", 
        BookNumber = 47
    };
    
    public static readonly BibleBook Galatians = new() 
    {
        Id = Guid.Parse("6A856D0A-A699-426B-A205-6593B7E5FF93"), 
        Name = "Galatians", 
        BookNumber = 48
    };
    
    public static readonly BibleBook Ephesians = new() 
    {
        Id = Guid.Parse("46B1336E-801B-4F79-A496-F792549AF4D4"), 
        Name = "Ephesians", 
        BookNumber = 49
    };
    
    public static readonly BibleBook Philippians = new() 
    {
        Id = Guid.Parse("FF5C2160-A444-4D35-B98E-9135D03A80CC"), 
        Name = "Philippians", 
        BookNumber = 50
    };
    
    public static readonly BibleBook Colossians = new() 
    {
        Id = Guid.Parse("C3D8E507-FFE2-4B27-9D08-F0C90DD07D82"), 
        Name = "Colossians", 
        BookNumber = 51
    };
    
    public static readonly BibleBook FirstThessalonians = new() 
    {
        Id = Guid.Parse("9310AC4A-D730-40E9-9302-D7F068FC1FC8"), 
        Name = "1 Thessalonians", 
        BookNumber = 52
    };
    
    public static readonly BibleBook SecondThessalonians = new() 
    {
        Id = Guid.Parse("59BF320B-23DE-431C-AC47-0C38AFD4BBFB"), 
        Name = "2 Thessalonians", 
        BookNumber = 53
    };
    
    public static readonly BibleBook FirstTimothy = new() 
    {
        Id = Guid.Parse("4F65CDC4-A25C-4DD0-A450-4960AE0F76D0"), 
        Name = "1 Timothy", 
        BookNumber = 54
    };
    
    public static readonly BibleBook SecondTimothy = new() 
    {
        Id = Guid.Parse("3E9AFB72-3795-423D-BADB-50CD71013E47"), 
        Name = "2 Timothy", 
        BookNumber = 55
    };
    
    public static readonly BibleBook Titus = new() 
    {
        Id = Guid.Parse("C7E4ACF8-9C97-428D-B556-EC297EC678D0"), 
        Name = "Titus", 
        BookNumber = 56
    };
    
    public static readonly BibleBook Philemon = new() 
    {
        Id = Guid.Parse("7F78C54F-306A-4885-847C-908766E83283"), 
        Name = "Philemon", 
        BookNumber = 57
    };
    
    public static readonly BibleBook Hebrews = new() 
    {
        Id = Guid.Parse("E39EE606-C075-43E1-B180-392B8C3AA2E8"), 
        Name = "Hebrews", 
        BookNumber = 58
    };
    
    public static readonly BibleBook James = new() 
    {
        Id = Guid.Parse("873250C8-88BC-4C7F-BB50-529207BD90A5"), 
        Name = "James", 
        BookNumber = 59
    };
    
    public static readonly BibleBook FirstPeter = new() 
    {
        Id = Guid.Parse("A8240D3A-B208-415B-B851-95207252534A"), 
        Name = "1 Peter", 
        BookNumber = 60
    };
    
    public static readonly BibleBook SecondPeter = new() 
    {
        Id = Guid.Parse("517BA936-2726-49A6-B119-E81E3544A45B"), 
        Name = "2 Peter", 
        BookNumber = 61
    };
    
    public static readonly BibleBook FirstJohn = new() 
    {
        Id = Guid.Parse("75B320B4-C904-4ABA-A374-27AD6D285CDC"), 
        Name = "1 John", 
        BookNumber = 62
    };
    
    public static readonly BibleBook SecondJohn = new() 
    {
        Id = Guid.Parse("1BDBB875-17FB-42DF-9B82-1ABF7FCA1903"), 
        Name = "2 John", 
        BookNumber = 63
    };
    
    public static readonly BibleBook ThirdJohn = new() 
    {
        Id = Guid.Parse("95C194B2-49D0-4861-9823-EA6ABA1EBA49"), 
        Name = "3 John", 
        BookNumber = 64
    };
    
    public static readonly BibleBook Jude = new() 
    {
        Id = Guid.Parse("5D560094-1DE6-413B-85D4-A431D8B1725B"), 
        Name = "Jude", 
        BookNumber = 65
    };
    
    public static readonly BibleBook Revelation = new() 
    {
        Id = Guid.Parse("63473956-DBD2-4827-B8E0-FD5991614530"), 
        Name = "Revelation", 
        BookNumber = 66
    };
    
    public static readonly List<BibleBook> All =
    [
        Genesis, Exodus, Leviticus, Numbers, Deuteronomy, Joshua, Judges, Ruth, FirstSamuel, SecondSamuel,
        FirstKings, SecondKings, FirstChronicles, SecondChronicles, Ezra, Nehemiah, Esther, Job, Psalms,
        Proverbs, Ecclesiastes, SongOfSolomon, Isaiah, Jeremiah, Lamentations, Ezekiel, Daniel, Hosea, Joel,
        Amos, Obadiah, Jonah, Micah, Nahum, Habakkuk, Zephaniah, Haggai, Zechariah, Malachi, Matthew, Mark,
        Luke, John, Acts, Romans, FirstCorinthians, SecondCorinthians, Galatians, Ephesians, Philippians,
        Colossians, FirstThessalonians, SecondThessalonians, FirstTimothy, SecondTimothy, Titus, Philemon,
        Hebrews, James, FirstPeter, SecondPeter, FirstJohn, SecondJohn, ThirdJohn, Jude, Revelation
    ];
}