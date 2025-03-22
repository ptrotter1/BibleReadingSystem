using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable MemberCanBePrivate.Global

namespace BibleReadingSystem.Data.Entities;

public class BibleChapter : ISoftDeletable
{
    public Guid Id { get; set; }
    
    [MaxLength(32)]
    public string Name { get; set; } = string.Empty;

    public int ChapterNumber { get; set; }
    
    public Guid BibleBookId { get; set; }
    
    [ForeignKey(nameof(BibleBookId))]
    public BibleBook BibleBook { get; set; } = null!;
    
    public bool IsDeleted { get; set; }
}

public static class BibleChapters
{
    public static readonly BibleChapter Genesis1 = new() { Id = Guid.Parse("D8668F72-D4D1-4091-BDD1-F52F59EA74F5"), Name = "Genesis 1", ChapterNumber = 1, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis2 = new() { Id = Guid.Parse("C920875B-A4FD-48EE-8355-0E5602D468F7"), Name = "Genesis 2", ChapterNumber = 2, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis3 = new() { Id = Guid.Parse("56861D21-A588-4651-AF5A-55736520CC65"), Name = "Genesis 3", ChapterNumber = 3, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis4 = new() { Id = Guid.Parse("FEE2FA01-137F-47E2-A15B-C1DC512A0CD7"), Name = "Genesis 4", ChapterNumber = 4, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis5 = new() { Id = Guid.Parse("00872B7E-FECE-492D-81CB-E1B62CAB7849"), Name = "Genesis 5", ChapterNumber = 5, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis6 = new() { Id = Guid.Parse("C7CFE006-0EC5-4E46-898A-0AD6F33F9F43"), Name = "Genesis 6", ChapterNumber = 6, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis7 = new() { Id = Guid.Parse("81527487-202E-4181-A9F5-A00187698C8A"), Name = "Genesis 7", ChapterNumber = 7, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis8 = new() { Id = Guid.Parse("B0F175E8-DD7F-458A-8FAF-81FF75B1E109"), Name = "Genesis 8", ChapterNumber = 8, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis9 = new() { Id = Guid.Parse("DC8C0E22-E9B0-4514-AF06-17C1B02724BD"), Name = "Genesis 9", ChapterNumber = 9, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis10 = new() { Id = Guid.Parse("FD3B074C-D69B-4B55-9BB7-D11E7E6F4172"), Name = "Genesis 10", ChapterNumber = 10, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis11 = new() { Id = Guid.Parse("32F1084F-BB3C-4284-90A6-0B2623855F69"), Name = "Genesis 11", ChapterNumber = 11, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis12 = new() { Id = Guid.Parse("60B83A73-86F1-4F14-8E31-849D869281DB"), Name = "Genesis 12", ChapterNumber = 12, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis13 = new() { Id = Guid.Parse("FF2A4606-C12B-4505-B3BA-0329F934C490"), Name = "Genesis 13", ChapterNumber = 13, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis14 = new() { Id = Guid.Parse("16BAFDCA-0669-49B2-AE70-61924AC11B72"), Name = "Genesis 14", ChapterNumber = 14, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis15 = new() { Id = Guid.Parse("5F45DA38-310A-4803-8AEC-6C1512A9D394"), Name = "Genesis 15", ChapterNumber = 15, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis16 = new() { Id = Guid.Parse("37A8C973-4F5E-4FA3-ACC0-C8E0C38086BF"), Name = "Genesis 16", ChapterNumber = 16, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis17 = new() { Id = Guid.Parse("7E5EB8B1-7ACA-4557-A577-9C48E33ECFD4"), Name = "Genesis 17", ChapterNumber = 17, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis18 = new() { Id = Guid.Parse("B95B5EDA-6524-4DD3-86B6-1DEDBE98623C"), Name = "Genesis 18", ChapterNumber = 18, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis19 = new() { Id = Guid.Parse("EF006340-A124-4373-9169-56BED9F1943D"), Name = "Genesis 19", ChapterNumber = 19, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis20 = new() { Id = Guid.Parse("8E80F806-B2C8-4EA8-82C4-CCF5D8D5FF45"), Name = "Genesis 20", ChapterNumber = 20, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis21 = new() { Id = Guid.Parse("0D0F77AC-E12A-407F-81BD-FB0B3DCE7E79"), Name = "Genesis 21", ChapterNumber = 21, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis22 = new() { Id = Guid.Parse("AE22A0A9-97BB-4962-B887-557751C99590"), Name = "Genesis 22", ChapterNumber = 22, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis23 = new() { Id = Guid.Parse("62642CED-3E2B-4946-AB87-7001560B6EE6"), Name = "Genesis 23", ChapterNumber = 23, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis24 = new() { Id = Guid.Parse("92F54C06-E4D1-4552-A079-F5CB7E598DFF"), Name = "Genesis 24", ChapterNumber = 24, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis25 = new() { Id = Guid.Parse("40EBB38E-E5CF-4787-8A77-A95463DE3273"), Name = "Genesis 25", ChapterNumber = 25, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis26 = new() { Id = Guid.Parse("52BBBD92-1590-4820-A0EC-FF37AA792076"), Name = "Genesis 26", ChapterNumber = 26, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis27 = new() { Id = Guid.Parse("1CE40950-836F-425B-A22D-1BDD70DCFD09"), Name = "Genesis 27", ChapterNumber = 27, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis28 = new() { Id = Guid.Parse("6F4EDBCD-53B7-4E22-98BB-61C41159BC8A"), Name = "Genesis 28", ChapterNumber = 28, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis29 = new() { Id = Guid.Parse("1A0474F3-FD2B-406D-99F4-7ADB25AD85F3"), Name = "Genesis 29", ChapterNumber = 29, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis30 = new() { Id = Guid.Parse("3420608F-CC49-4DB3-BBD1-4B7556CBF1FE"), Name = "Genesis 30", ChapterNumber = 30, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis31 = new() { Id = Guid.Parse("10347827-C741-4DDD-BF8A-5ED3DA84C83C"), Name = "Genesis 31", ChapterNumber = 31, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis32 = new() { Id = Guid.Parse("C593B382-50E1-4224-9DE9-8998E49A22E7"), Name = "Genesis 32", ChapterNumber = 32, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis33 = new() { Id = Guid.Parse("F05C8A58-DA9B-495F-8420-F6EF5D348D87"), Name = "Genesis 33", ChapterNumber = 33, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis34 = new() { Id = Guid.Parse("D3BF707D-2C5D-48C1-A19F-4C761BDD5FE8"), Name = "Genesis 34", ChapterNumber = 34, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis35 = new() { Id = Guid.Parse("E06C9FF2-7D72-4C5F-9D53-94EA99199C2C"), Name = "Genesis 35", ChapterNumber = 35, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis36 = new() { Id = Guid.Parse("1B215793-FC7D-425C-80BB-6394F2A2917D"), Name = "Genesis 36", ChapterNumber = 36, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis37 = new() { Id = Guid.Parse("86E846F9-CC54-4549-93A5-437F635D9386"), Name = "Genesis 37", ChapterNumber = 37, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis38 = new() { Id = Guid.Parse("BB97A352-8A09-46A8-969F-E4FB2EF0FA5C"), Name = "Genesis 38", ChapterNumber = 38, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis39 = new() { Id = Guid.Parse("9889D73A-F5E9-4F45-9114-D6B228B24436"), Name = "Genesis 39", ChapterNumber = 39, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis40 = new() { Id = Guid.Parse("66314924-7F8C-4CAC-898B-529ED09B9941"), Name = "Genesis 40", ChapterNumber = 40, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis41 = new() { Id = Guid.Parse("CCC9C169-F420-473E-BE3F-692F00AAAE09"), Name = "Genesis 41", ChapterNumber = 41, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis42 = new() { Id = Guid.Parse("E243E6AA-F3A3-4D53-A43A-DD52CA82E40A"), Name = "Genesis 42", ChapterNumber = 42, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis43 = new() { Id = Guid.Parse("CF2E274C-EDFF-46F8-AEC2-D654EE050829"), Name = "Genesis 43", ChapterNumber = 43, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis44 = new() { Id = Guid.Parse("2F4CEAF6-BE6F-4EAC-B521-CFE3C579B709"), Name = "Genesis 44", ChapterNumber = 44, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis45 = new() { Id = Guid.Parse("829A2ED7-D352-4D07-A14A-B29731CD4046"), Name = "Genesis 45", ChapterNumber = 45, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis46 = new() { Id = Guid.Parse("EE6221D3-B534-44C0-A4BD-916813A86B63"), Name = "Genesis 46", ChapterNumber = 46, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis47 = new() { Id = Guid.Parse("C89A74D8-4F63-4FC7-98DB-764F1E506881"), Name = "Genesis 47", ChapterNumber = 47, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis48 = new() { Id = Guid.Parse("21F191D9-B656-4C94-85E5-4FFA4BA79EE3"), Name = "Genesis 48", ChapterNumber = 48, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis49 = new() { Id = Guid.Parse("652295AF-65AE-4FFA-92C1-65240320677A"), Name = "Genesis 49", ChapterNumber = 49, BibleBookId = BibleBooks.Genesis.Id };
    public static readonly BibleChapter Genesis50 = new() { Id = Guid.Parse("5939E0C7-BFD6-4CB5-A7E7-1C81FC3C863A"), Name = "Genesis 50", ChapterNumber = 50, BibleBookId = BibleBooks.Genesis.Id };

    public static readonly BibleChapter Exodus1 = new() { Id = Guid.Parse("DD244031-7651-40BF-8E15-E55AE3127D95"), Name = "Exodus 1", ChapterNumber = 1, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus2 = new() { Id = Guid.Parse("B2E5A3C2-A06D-419F-BAC0-9F14891A72A6"), Name = "Exodus 2", ChapterNumber = 2, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus3 = new() { Id = Guid.Parse("07B6A932-F7BF-42CA-9D24-ABB6EDD6FBA5"), Name = "Exodus 3", ChapterNumber = 3, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus4 = new() { Id = Guid.Parse("616C272D-4CCA-449F-BC2D-57B3708F581A"), Name = "Exodus 4", ChapterNumber = 4, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus5 = new() { Id = Guid.Parse("3CA12B78-7207-413A-ABAE-03EFCE14BDFA"), Name = "Exodus 5", ChapterNumber = 5, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus6 = new() { Id = Guid.Parse("C1B75EA2-D8DD-46A4-A695-2D7B72AF5457"), Name = "Exodus 6", ChapterNumber = 6, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus7 = new() { Id = Guid.Parse("1ED17114-D5E8-4C19-8254-BCC39D8FE060"), Name = "Exodus 7", ChapterNumber = 7, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus8 = new() { Id = Guid.Parse("2C4929C8-5C48-4809-ACE0-FB5A8C607963"), Name = "Exodus 8", ChapterNumber = 8, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus9 = new() { Id = Guid.Parse("C8727F21-98BE-4695-B607-617109198ED9"), Name = "Exodus 9", ChapterNumber = 9, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus10 = new() { Id = Guid.Parse("0F2A9F81-59E3-4F9C-862E-E164983C5671"), Name = "Exodus 10", ChapterNumber = 10, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus11 = new() { Id = Guid.Parse("195DA3C7-8790-4DE0-986D-DF088A03D572"), Name = "Exodus 11", ChapterNumber = 11, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus12 = new() { Id = Guid.Parse("1D384433-09AF-4BC4-8950-FD73A051879F"), Name = "Exodus 12", ChapterNumber = 12, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus13 = new() { Id = Guid.Parse("D4219502-F7F4-400B-8FD7-E72507E2EEFC"), Name = "Exodus 13", ChapterNumber = 13, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus14 = new() { Id = Guid.Parse("7ACBFF0E-AEBE-42A2-BC70-25294BA50ED4"), Name = "Exodus 14", ChapterNumber = 14, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus15 = new() { Id = Guid.Parse("A8D13D0E-528C-40DF-B079-FF72C390BD03"), Name = "Exodus 15", ChapterNumber = 15, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus16 = new() { Id = Guid.Parse("6E44E791-85F5-4942-8114-E803F4B279D3"), Name = "Exodus 16", ChapterNumber = 16, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus17 = new() { Id = Guid.Parse("E097FE2C-C3B6-42A7-A57A-3797FC386883"), Name = "Exodus 17", ChapterNumber = 17, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus18 = new() { Id = Guid.Parse("D5DFFA45-2D74-4C0D-BE0F-CC03A4B3C077"), Name = "Exodus 18", ChapterNumber = 18, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus19 = new() { Id = Guid.Parse("1FC26854-B69E-44A2-B8DB-6C90CDFC97F3"), Name = "Exodus 19", ChapterNumber = 19, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus20 = new() { Id = Guid.Parse("16D2F454-C88E-43B8-9DC1-A82F81FBE254"), Name = "Exodus 20", ChapterNumber = 20, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus21 = new() { Id = Guid.Parse("088272CE-8CF6-497E-A432-208FE13EE88C"), Name = "Exodus 21", ChapterNumber = 21, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus22 = new() { Id = Guid.Parse("F68520D8-A727-4EE3-ABA2-EA08B941A0DC"), Name = "Exodus 22", ChapterNumber = 22, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus23 = new() { Id = Guid.Parse("0EF13A72-BD0D-4F28-9D9D-17D3AD66624D"), Name = "Exodus 23", ChapterNumber = 23, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus24 = new() { Id = Guid.Parse("FE6FE67A-5065-4436-960B-A4C016A54E15"), Name = "Exodus 24", ChapterNumber = 24, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus25 = new() { Id = Guid.Parse("43068AD3-98E7-467A-AA54-85AFBC2C20D4"), Name = "Exodus 25", ChapterNumber = 25, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus26 = new() { Id = Guid.Parse("75325FEF-028D-4979-AC44-5C0DB4D4A5DC"), Name = "Exodus 26", ChapterNumber = 26, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus27 = new() { Id = Guid.Parse("E926E4FE-0889-4818-AE21-D27C7F0F5159"), Name = "Exodus 27", ChapterNumber = 27, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus28 = new() { Id = Guid.Parse("1A808A6C-D630-4ABF-9682-B8EEE74FFDD1"), Name = "Exodus 28", ChapterNumber = 28, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus29 = new() { Id = Guid.Parse("BF1B7F30-85FE-4E04-B880-274C387253BA"), Name = "Exodus 29", ChapterNumber = 29, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus30 = new() { Id = Guid.Parse("2A23D346-FCE2-4431-A7E2-3A93DEA45FDD"), Name = "Exodus 30", ChapterNumber = 30, BibleBookId = BibleBooks.Exodus.Id };    
    public static readonly BibleChapter Exodus31 = new() { Id = Guid.Parse("426C36D9-72BF-4572-80F3-6A3A5CAF8974"), Name = "Exodus 31", ChapterNumber = 31, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus32 = new() { Id = Guid.Parse("519F4433-7715-4DED-A505-9606740AF295"), Name = "Exodus 32", ChapterNumber = 32, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus33 = new() { Id = Guid.Parse("1D0332A7-4825-44DA-B0B8-ED2405B40C3C"), Name = "Exodus 33", ChapterNumber = 33, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus34 = new() { Id = Guid.Parse("65E163FA-A750-41B2-92E1-2C4F8D316511"), Name = "Exodus 34", ChapterNumber = 34, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus35 = new() { Id = Guid.Parse("B3EAE87E-1F88-43F6-BDD9-B982F28B7389"), Name = "Exodus 35", ChapterNumber = 35, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus36 = new() { Id = Guid.Parse("9A696DCC-504B-4A4C-9BBA-7FFD175E5399"), Name = "Exodus 36", ChapterNumber = 36, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus37 = new() { Id = Guid.Parse("D687F770-AA7F-4ADF-A8F4-618FA760EFCC"), Name = "Exodus 37", ChapterNumber = 37, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus38 = new() { Id = Guid.Parse("85DBF13A-B017-49EF-AE7F-5E4377A5D9F4"), Name = "Exodus 38", ChapterNumber = 38, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus39 = new() { Id = Guid.Parse("589C329A-E14F-4E3C-8573-F4F8AF3D0E66"), Name = "Exodus 39", ChapterNumber = 39, BibleBookId = BibleBooks.Exodus.Id };
    public static readonly BibleChapter Exodus40 = new() { Id = Guid.Parse("A7EA07E3-8AB2-42CD-B12D-CC32D6DE9D2E"), Name = "Exodus 40", ChapterNumber = 40, BibleBookId = BibleBooks.Exodus.Id };
    
    public static readonly BibleChapter Leviticus1 = new() { Id = Guid.Parse("61BA4D75-2BD1-4EB4-8012-641B18227FB4"), Name = "Leviticus 1", ChapterNumber = 1, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus2 = new() { Id = Guid.Parse("03084B3D-C230-4D94-A4BD-DBE362875677"), Name = "Leviticus 2", ChapterNumber = 2, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus3 = new() { Id = Guid.Parse("52FEE156-D30E-4FAC-95D4-6BE24F262853"), Name = "Leviticus 3", ChapterNumber = 3, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus4 = new() { Id = Guid.Parse("05DAB55A-8F4C-4DD2-A16D-253FA2FD6CF1"), Name = "Leviticus 4", ChapterNumber = 4, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus5 = new() { Id = Guid.Parse("FCC9CE42-A692-4B78-BBB3-F97A7C48B029"), Name = "Leviticus 5", ChapterNumber = 5, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus6 = new() { Id = Guid.Parse("585B91A2-5C57-4CA9-BC31-0B4905298446"), Name = "Leviticus 6", ChapterNumber = 6, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus7 = new() { Id = Guid.Parse("7DA13559-518A-4F36-AE05-A1A224893D50"), Name = "Leviticus 7", ChapterNumber = 7, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus8 = new() { Id = Guid.Parse("12F6BDEE-1032-42D4-B9C2-AB4138FAB225"), Name = "Leviticus 8", ChapterNumber = 8, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus9 = new() { Id = Guid.Parse("2C800548-CAB3-4E88-8AE3-0CC397A6E7C4"), Name = "Leviticus 9", ChapterNumber = 9, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus10 = new() { Id = Guid.Parse("013D0A55-F317-4283-99F4-DCC608C55FB6"), Name = "Leviticus 10", ChapterNumber = 10, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus11 = new() { Id = Guid.Parse("FC0D46C0-A063-405D-89EF-2159826AFB86"), Name = "Leviticus 11", ChapterNumber = 11, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus12 = new() { Id = Guid.Parse("F8C83E0A-C21E-45F7-A72A-5825A225F9FD"), Name = "Leviticus 12", ChapterNumber = 12, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus13 = new() { Id = Guid.Parse("A90FD42A-EC6E-47AA-A7BF-344F3412AD46"), Name = "Leviticus 13", ChapterNumber = 13, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus14 = new() { Id = Guid.Parse("FF06EF28-158F-4453-98BF-001735AAEB61"), Name = "Leviticus 14", ChapterNumber = 14, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus15 = new() { Id = Guid.Parse("576A4435-4375-463A-A19B-61E4B5DD2221"), Name = "Leviticus 15", ChapterNumber = 15, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus16 = new() { Id = Guid.Parse("8E3285E5-8E19-4D10-878E-0F4F4CA28546"), Name = "Leviticus 16", ChapterNumber = 16, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus17 = new() { Id = Guid.Parse("730EFE13-9560-45C6-9685-0552170ADCB2"), Name = "Leviticus 17", ChapterNumber = 17, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus18 = new() { Id = Guid.Parse("30CBF680-6622-4A0E-9799-224F3EEDE218"), Name = "Leviticus 18", ChapterNumber = 18, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus19 = new() { Id = Guid.Parse("B684224E-51A3-49DD-BBC4-9BE0794125D0"), Name = "Leviticus 19", ChapterNumber = 19, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus20 = new() { Id = Guid.Parse("93BC8958-9727-4CFD-8711-FFF26EC53C69"), Name = "Leviticus 20", ChapterNumber = 20, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus21 = new() { Id = Guid.Parse("F8DCB488-C874-4AA1-B26C-1B6EFDC37EF1"), Name = "Leviticus 21", ChapterNumber = 21, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus22 = new() { Id = Guid.Parse("5FB326E2-AA01-4FBD-8B58-291811634DC2"), Name = "Leviticus 22", ChapterNumber = 22, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus23 = new() { Id = Guid.Parse("C153A9DC-7BB7-49F2-838C-DACD81E44FA2"), Name = "Leviticus 23", ChapterNumber = 23, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus24 = new() { Id = Guid.Parse("D9C680A2-2D13-47D2-BC73-31696A0D268C"), Name = "Leviticus 24", ChapterNumber = 24, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus25 = new() { Id = Guid.Parse("C84B6801-5814-49E1-8352-8DFAFCD97740"), Name = "Leviticus 25", ChapterNumber = 25, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus26 = new() { Id = Guid.Parse("579C289D-749C-46D5-AFAE-22355AE5C85A"), Name = "Leviticus 26", ChapterNumber = 26, BibleBookId = BibleBooks.Leviticus.Id };
    public static readonly BibleChapter Leviticus27 = new() { Id = Guid.Parse("32DD46A6-6E36-4EDB-9436-6212FCE89257"), Name = "Leviticus 27", ChapterNumber = 27, BibleBookId = BibleBooks.Leviticus.Id };
    
    public static readonly BibleChapter Numbers1 = new() { Id = Guid.Parse("E3290D61-CEA7-4A39-8993-0B6530DF4245"), Name = "Numbers 1", ChapterNumber = 1, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers2 = new() { Id = Guid.Parse("2A3027F0-2BED-4269-A5E2-D8576C54D87C"), Name = "Numbers 2", ChapterNumber = 2, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers3 = new() { Id = Guid.Parse("38496552-9A40-4F5C-90DE-187DDA0A3372"), Name = "Numbers 3", ChapterNumber = 3, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers4 = new() { Id = Guid.Parse("CCD684FE-4598-47CE-9ACD-97B83C74493A"), Name = "Numbers 4", ChapterNumber = 4, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers5 = new() { Id = Guid.Parse("C29B753C-CC69-46DB-BC9D-3135FE2FCFAD"), Name = "Numbers 5", ChapterNumber = 5, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers6 = new() { Id = Guid.Parse("B7BE93AA-BE5A-4F0B-9F39-4CC7A2AB9199"), Name = "Numbers 6", ChapterNumber = 6, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers7 = new() { Id = Guid.Parse("16A87555-73A4-40A8-8A74-2222971ADCB1"), Name = "Numbers 7", ChapterNumber = 7, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers8 = new() { Id = Guid.Parse("5AE399F5-606C-4EFB-9CD1-A80A7415A684"), Name = "Numbers 8", ChapterNumber = 8, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers9 = new() { Id = Guid.Parse("36929B55-2CB7-4DE9-AC62-BD0279DD7220"), Name = "Numbers 9", ChapterNumber = 9, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers10 = new() { Id = Guid.Parse("82F0B8B3-ADF6-4384-9744-0BEF70DDA526"), Name = "Numbers 10", ChapterNumber = 10, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers11 = new() { Id = Guid.Parse("8377E796-B32F-44AD-A0E5-215B1A2C9E9A"), Name = "Numbers 11", ChapterNumber = 11, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers12 = new() { Id = Guid.Parse("7783DE42-CD2F-460D-B47A-EE1DDE7DE023"), Name = "Numbers 12", ChapterNumber = 12, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers13 = new() { Id = Guid.Parse("6CFC2A11-9807-46B7-80E3-6A20B04BCE53"), Name = "Numbers 13", ChapterNumber = 13, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers14 = new() { Id = Guid.Parse("2525EDC0-7E8B-4637-80CA-4B24CFADB29D"), Name = "Numbers 14", ChapterNumber = 14, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers15 = new() { Id = Guid.Parse("118B3C0A-3469-467B-8B10-DDAD6AFC7641"), Name = "Numbers 15", ChapterNumber = 15, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers16 = new() { Id = Guid.Parse("0DD93487-13D1-4D1C-B84A-E30C6127EC65"), Name = "Numbers 16", ChapterNumber = 16, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers17 = new() { Id = Guid.Parse("5DFBCD2B-78E7-4853-B378-13F3A7A06D70"), Name = "Numbers 17", ChapterNumber = 17, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers18 = new() { Id = Guid.Parse("EAC426FD-D683-4898-B6EE-BA880F2E1CC0"), Name = "Numbers 18", ChapterNumber = 18, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers19 = new() { Id = Guid.Parse("2CE2D390-D923-4D11-A227-7BC2B92EF697"), Name = "Numbers 19", ChapterNumber = 19, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers20 = new() { Id = Guid.Parse("02180AEB-B6A3-4A33-83C5-09EB8086BCF3"), Name = "Numbers 20", ChapterNumber = 20, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers21 = new() { Id = Guid.Parse("8FF095D4-BFB7-4A4F-8C93-E304657D6FD2"), Name = "Numbers 21", ChapterNumber = 21, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers22 = new() { Id = Guid.Parse("8F9F854E-3021-4E1B-A397-444E89F6D46F"), Name = "Numbers 22", ChapterNumber = 22, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers23 = new() { Id = Guid.Parse("C2F017CE-D498-4493-9B51-9B80DC4FD6CF"), Name = "Numbers 23", ChapterNumber = 23, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers24 = new() { Id = Guid.Parse("ECED8B0C-8E87-4D98-A309-02F111EF6B47"), Name = "Numbers 24", ChapterNumber = 24, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers25 = new() { Id = Guid.Parse("0D049905-2B86-41E4-B537-6AC70717FA75"), Name = "Numbers 25", ChapterNumber = 25, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers26 = new() { Id = Guid.Parse("B3B5DEF2-2214-40E7-9D7E-00F208E99DF5"), Name = "Numbers 26", ChapterNumber = 26, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers27 = new() { Id = Guid.Parse("B9B97719-EE2F-4053-858C-2E0ED84A2697"), Name = "Numbers 27", ChapterNumber = 27, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers28 = new() { Id = Guid.Parse("4A06C2A7-4796-4988-B38D-386BB92EC3AD"), Name = "Numbers 28", ChapterNumber = 28, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers29 = new() { Id = Guid.Parse("738DC7F0-23F4-459C-B122-D1C18F8C00E2"), Name = "Numbers 29", ChapterNumber = 29, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers30 = new() { Id = Guid.Parse("8CC253E0-5C34-4B77-8B41-DC346D9949DF"), Name = "Numbers 30", ChapterNumber = 30, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers31 = new() { Id = Guid.Parse("D2382247-74C1-4B07-8F59-16BF5A565BDE"), Name = "Numbers 31", ChapterNumber = 31, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers32 = new() { Id = Guid.Parse("89ECED57-B989-4651-B861-2B1FBEBE1440"), Name = "Numbers 32", ChapterNumber = 32, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers33 = new() { Id = Guid.Parse("6A27DB69-1FF0-4FC3-983B-B7EB5DDDBCC5"), Name = "Numbers 33", ChapterNumber = 33, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers34 = new() { Id = Guid.Parse("8CD101EF-8F9B-4686-865F-43E274F00986"), Name = "Numbers 34", ChapterNumber = 34, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers35 = new() { Id = Guid.Parse("A6633F84-A1E2-460C-8D9B-644D55D4E3A5"), Name = "Numbers 35", ChapterNumber = 35, BibleBookId = BibleBooks.Numbers.Id };
    public static readonly BibleChapter Numbers36 = new() { Id = Guid.Parse("46570A62-7225-4A5B-82DC-F55F6D77F147"), Name = "Numbers 36", ChapterNumber = 36, BibleBookId = BibleBooks.Numbers.Id };
    
    public static readonly BibleChapter Deuteronomy1 = new() { Id = Guid.Parse("E6903100-BC3A-43D8-A44E-F8B2987B6FC4"), Name = "Deuteronomy 1", ChapterNumber = 1, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy2 = new() { Id = Guid.Parse("0745A0F8-D938-4711-B5B4-899EDBDF34E8"), Name = "Deuteronomy 2", ChapterNumber = 2, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy3 = new() { Id = Guid.Parse("518B97B4-5C0D-4E96-BB9F-2DE528B5F63D"), Name = "Deuteronomy 3", ChapterNumber = 3, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy4 = new() { Id = Guid.Parse("89B466AC-993E-4E4A-9EEA-695936E4E5C4"), Name = "Deuteronomy 4", ChapterNumber = 4, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy5 = new() { Id = Guid.Parse("4CF57323-8A05-46B6-952F-356280A2AB40"), Name = "Deuteronomy 5", ChapterNumber = 5, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy6 = new() { Id = Guid.Parse("52C5EB62-3F96-4152-8DDF-9F1CFFFEC2FC"), Name = "Deuteronomy 6", ChapterNumber = 6, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy7 = new() { Id = Guid.Parse("F2D991BB-5C2C-4267-8E9C-9F1665661B97"), Name = "Deuteronomy 7", ChapterNumber = 7, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy8 = new() { Id = Guid.Parse("CA91F64D-897A-47A0-90A8-D3C768E4C4AA"), Name = "Deuteronomy 8", ChapterNumber = 8, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy9 = new() { Id = Guid.Parse("DD064C45-A42D-40F8-B693-4FE9EF792D39"), Name = "Deuteronomy 9", ChapterNumber = 9, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy10 = new() { Id = Guid.Parse("E6EA3579-7716-4854-9A87-075994C18984"), Name = "Deuteronomy 10", ChapterNumber = 10, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy11 = new() { Id = Guid.Parse("0BBC21DD-7320-4243-8725-45BC3A8A2898"), Name = "Deuteronomy 11", ChapterNumber = 11, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy12 = new() { Id = Guid.Parse("EEEAC751-3E7E-4BB9-8BF1-2C3B98F98C20"), Name = "Deuteronomy 12", ChapterNumber = 12, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy13 = new() { Id = Guid.Parse("4154C49A-3D6D-452A-8A59-5CA4772C35BB"), Name = "Deuteronomy 13", ChapterNumber = 13, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy14 = new() { Id = Guid.Parse("BF759D06-633D-425C-9637-A1EA4E5F5A3D"), Name = "Deuteronomy 14", ChapterNumber = 14, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy15 = new() { Id = Guid.Parse("E2A3DFB7-1036-4B3F-B0AA-170B7A679A87"), Name = "Deuteronomy 15", ChapterNumber = 15, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy16 = new() { Id = Guid.Parse("626E12CF-086C-4336-B770-FCC368A581C7"), Name = "Deuteronomy 16", ChapterNumber = 16, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy17 = new() { Id = Guid.Parse("3C6DC95A-16F3-463C-AD65-B71FCDC6A5B9"), Name = "Deuteronomy 17", ChapterNumber = 17, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy18 = new() { Id = Guid.Parse("AF9A964B-F77C-4947-A6E8-8EA381019B02"), Name = "Deuteronomy 18", ChapterNumber = 18, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy19 = new() { Id = Guid.Parse("1F8AE460-1DF7-46A6-9D20-2E7FEF03560E"), Name = "Deuteronomy 19", ChapterNumber = 19, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy20 = new() { Id = Guid.Parse("9090F8E0-8FBA-4BD6-B4CF-F140D8503D53"), Name = "Deuteronomy 20", ChapterNumber = 20, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy21 = new() { Id = Guid.Parse("F66E9688-E444-4D2D-A5D4-358326C8A750"), Name = "Deuteronomy 21", ChapterNumber = 21, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy22 = new() { Id = Guid.Parse("F415749D-7C0C-4031-A532-2C513D296A35"), Name = "Deuteronomy 22", ChapterNumber = 22, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy23 = new() { Id = Guid.Parse("469837D2-9E2F-4771-996D-44A39C94693F"), Name = "Deuteronomy 23", ChapterNumber = 23, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy24 = new() { Id = Guid.Parse("A402CFCB-15D0-4388-BD76-521596F9D01B"), Name = "Deuteronomy 24", ChapterNumber = 24, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy25 = new() { Id = Guid.Parse("5A8F8540-3448-41A9-A214-53C2A5540CF7"), Name = "Deuteronomy 25", ChapterNumber = 25, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy26 = new() { Id = Guid.Parse("15AF2CBD-41D8-4438-BC20-82C1B7D6FEAD"), Name = "Deuteronomy 26", ChapterNumber = 26, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy27 = new() { Id = Guid.Parse("4DF3E261-2ADD-42A4-B874-7DFF55A81874"), Name = "Deuteronomy 27", ChapterNumber = 27, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy28 = new() { Id = Guid.Parse("8D92E8FE-B7CA-47CB-908C-6006F0DE3950"), Name = "Deuteronomy 28", ChapterNumber = 28, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy29 = new() { Id = Guid.Parse("0753C85D-63BD-4CC9-B7BF-5D1C56E7EB56"), Name = "Deuteronomy 29", ChapterNumber = 29, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy30 = new() { Id = Guid.Parse("8029FD97-CB90-4661-9763-7265430EF85A"), Name = "Deuteronomy 30", ChapterNumber = 30, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy31 = new() { Id = Guid.Parse("1C4E8E37-4929-425E-B08F-C591C1C19116"), Name = "Deuteronomy 31", ChapterNumber = 31, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy32 = new() { Id = Guid.Parse("90B39C98-7706-40C3-AFF2-3690D8E0323A"), Name = "Deuteronomy 32", ChapterNumber = 32, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy33 = new() { Id = Guid.Parse("B06F11E5-058E-4B93-A72B-DA3B64500ECB"), Name = "Deuteronomy 33", ChapterNumber = 33, BibleBookId = BibleBooks.Deuteronomy.Id };
    public static readonly BibleChapter Deuteronomy34 = new() { Id = Guid.Parse("E9BD81D3-629F-4C95-B128-3EE6EC809275"), Name = "Deuteronomy 34", ChapterNumber = 34, BibleBookId = BibleBooks.Deuteronomy.Id };
    
    public static readonly BibleChapter Joshua1 = new() { Id = Guid.Parse("AC72AB61-44D4-484F-8BD3-70253D4BB20F"), Name = "Joshua 1", ChapterNumber = 1, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua2 = new() { Id = Guid.Parse("DE888854-928E-469E-A984-E57685A8527C"), Name = "Joshua 2", ChapterNumber = 2, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua3 = new() { Id = Guid.Parse("9E3EDFC3-C732-45E1-BAAA-89FAA46DB6EF"), Name = "Joshua 3", ChapterNumber = 3, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua4 = new() { Id = Guid.Parse("38726525-3BB5-42D7-A224-2F5629A687EC"), Name = "Joshua 4", ChapterNumber = 4, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua5 = new() { Id = Guid.Parse("F4A130AA-AC0E-4D14-8CB0-1F5E2FDDA789"), Name = "Joshua 5", ChapterNumber = 5, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua6 = new() { Id = Guid.Parse("8360F5CC-438D-4C26-98FB-632722111D9A"), Name = "Joshua 6", ChapterNumber = 6, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua7 = new() { Id = Guid.Parse("CA2C4FA9-CCFC-4CCA-9819-168A810BDE2E"), Name = "Joshua 7", ChapterNumber = 7, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua8 = new() { Id = Guid.Parse("194AB1C3-E0C7-4426-8709-7D35512AF88D"), Name = "Joshua 8", ChapterNumber = 8, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua9 = new() { Id = Guid.Parse("C2FE1E1C-DC1F-481C-A470-21336688E2B8"), Name = "Joshua 9", ChapterNumber = 9, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua10 = new() { Id = Guid.Parse("9A4D7554-3ABF-48BE-BD5F-6E3EA4B0F562"), Name = "Joshua 10", ChapterNumber = 10, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua11 = new() { Id = Guid.Parse("42F2B925-7E80-45FD-9719-54AF1638F47A"), Name = "Joshua 11", ChapterNumber = 11, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua12 = new() { Id = Guid.Parse("97D5FBE0-A4D9-4F60-AA99-3F4CD18EBBC9"), Name = "Joshua 12", ChapterNumber = 12, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua13 = new() { Id = Guid.Parse("F7BDA199-1A83-4EC8-BAA7-A56CAED4FDD8"), Name = "Joshua 13", ChapterNumber = 13, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua14 = new() { Id = Guid.Parse("92F36903-DED0-4078-AAF9-385CEC67657B"), Name = "Joshua 14", ChapterNumber = 14, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua15 = new() { Id = Guid.Parse("E65D72D9-2328-4346-8E51-0D52E02321FF"), Name = "Joshua 15", ChapterNumber = 15, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua16 = new() { Id = Guid.Parse("BD467622-D7D5-4710-BEDF-976C67D350AF"), Name = "Joshua 16", ChapterNumber = 16, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua17 = new() { Id = Guid.Parse("38883F7C-FBA6-47D3-B3A1-4642E9D0C8E3"), Name = "Joshua 17", ChapterNumber = 17, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua18 = new() { Id = Guid.Parse("18DA5654-3155-4373-AC58-FF21F44101AD"), Name = "Joshua 18", ChapterNumber = 18, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua19 = new() { Id = Guid.Parse("EE307636-404F-4C50-A908-EFFBBF93D01D"), Name = "Joshua 19", ChapterNumber = 19, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua20 = new() { Id = Guid.Parse("F26FC025-F93B-427E-BFCC-51AF16A94035"), Name = "Joshua 20", ChapterNumber = 20, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua21 = new() { Id = Guid.Parse("2A930A39-B660-43F7-AEE2-9DC346254709"), Name = "Joshua 21", ChapterNumber = 21, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua22 = new() { Id = Guid.Parse("E129093E-C44B-4450-AD83-ED8688777225"), Name = "Joshua 22", ChapterNumber = 22, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua23 = new() { Id = Guid.Parse("5EAAF988-04A5-4EDF-B690-8D7E59466337"), Name = "Joshua 23", ChapterNumber = 23, BibleBookId = BibleBooks.Joshua.Id };
    public static readonly BibleChapter Joshua24 = new() { Id = Guid.Parse("7005A87D-B215-4F0B-921B-D5CF67118CA0"), Name = "Joshua 24", ChapterNumber = 24, BibleBookId = BibleBooks.Joshua.Id };
    
    public static readonly BibleChapter Judges1 = new() { Id = Guid.Parse("3C3305F7-8C5D-4D9F-A592-C7AD070F4C5B"), Name = "Judges 1", ChapterNumber = 1, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges2 = new() { Id = Guid.Parse("C63804C0-A66A-468A-8776-935BF4F0E972"), Name = "Judges 2", ChapterNumber = 2, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges3 = new() { Id = Guid.Parse("01FA3E60-8908-4A0C-970D-3275FF1D473E"), Name = "Judges 3", ChapterNumber = 3, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges4 = new() { Id = Guid.Parse("C1507473-007D-4BD2-9A7E-5D4571E11E1B"), Name = "Judges 4", ChapterNumber = 4, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges5 = new() { Id = Guid.Parse("3464B99D-8A28-44E3-B7A2-E0C762DE86AA"), Name = "Judges 5", ChapterNumber = 5, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges6 = new() { Id = Guid.Parse("6CE5BD44-42D2-4AC2-B9B8-E4032F86532B"), Name = "Judges 6", ChapterNumber = 6, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges7 = new() { Id = Guid.Parse("A8ADF84F-4746-4693-8C12-8DF559C84D4A"), Name = "Judges 7", ChapterNumber = 7, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges8 = new() { Id = Guid.Parse("E06DEF7B-2D80-4D56-BC59-8862DC9BA843"), Name = "Judges 8", ChapterNumber = 8, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges9 = new() { Id = Guid.Parse("AD81DF9C-D136-4AD5-AA34-0194C6117D21"), Name = "Judges 9", ChapterNumber = 9, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges10 = new() { Id = Guid.Parse("CBC0F274-2F6C-4F5D-A887-59D16AA03BA2"), Name = "Judges 10", ChapterNumber = 10, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges11 = new() { Id = Guid.Parse("79E92009-0B75-473B-A6BD-9E08D7CC47A6"), Name = "Judges 11", ChapterNumber = 11, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges12 = new() { Id = Guid.Parse("F72D1E22-5A21-4B1C-95BC-B4E9103751EE"), Name = "Judges 12", ChapterNumber = 12, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges13 = new() { Id = Guid.Parse("58E64597-CCD0-4A97-9618-DFA3E44DACB1"), Name = "Judges 13", ChapterNumber = 13, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges14 = new() { Id = Guid.Parse("AF424F34-EB4B-4891-9E4C-75DE98022635"), Name = "Judges 14", ChapterNumber = 14, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges15 = new() { Id = Guid.Parse("CCB3033B-9F4F-47FA-B375-E1DC51C1283F"), Name = "Judges 15", ChapterNumber = 15, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges16 = new() { Id = Guid.Parse("4AC47C96-27DD-46F2-9ED3-E3EA9C8654B0"), Name = "Judges 16", ChapterNumber = 16, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges17 = new() { Id = Guid.Parse("35BD49DE-5622-47D7-B59D-32AD2D7D33E6"), Name = "Judges 17", ChapterNumber = 17, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges18 = new() { Id = Guid.Parse("3F010E9C-57A3-4FAD-8098-9B1840A4AE3C"), Name = "Judges 18", ChapterNumber = 18, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges19 = new() { Id = Guid.Parse("FCC2AE70-E949-41B9-9DF3-07133147ABB1"), Name = "Judges 19", ChapterNumber = 19, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges20 = new() { Id = Guid.Parse("6AEA5049-C101-40E3-9216-3EBF1463FE91"), Name = "Judges 20", ChapterNumber = 20, BibleBookId = BibleBooks.Judges.Id };
    public static readonly BibleChapter Judges21 = new() { Id = Guid.Parse("40D32F05-C364-49BB-B87B-38FF04CDAF16"), Name = "Judges 21", ChapterNumber = 21, BibleBookId = BibleBooks.Judges.Id };
    
    public static readonly BibleChapter Ruth1 = new() { Id = Guid.Parse("1ECABF30-4064-4CFA-BA23-9BA33FDE6AC7"), Name = "Ruth 1", ChapterNumber = 1, BibleBookId = BibleBooks.Ruth.Id };
    public static readonly BibleChapter Ruth2 = new() { Id = Guid.Parse("B429966E-5828-43FB-945F-A54EC71D3CD5"), Name = "Ruth 2", ChapterNumber = 2, BibleBookId = BibleBooks.Ruth.Id };
    public static readonly BibleChapter Ruth3 = new() { Id = Guid.Parse("30AACD85-D67B-44EF-A7FC-B9157ED8238E"), Name = "Ruth 3", ChapterNumber = 3, BibleBookId = BibleBooks.Ruth.Id };
    public static readonly BibleChapter Ruth4 = new() { Id = Guid.Parse("CF49638F-1030-4156-930B-6D15F206F57D"), Name = "Ruth 4", ChapterNumber = 4, BibleBookId = BibleBooks.Ruth.Id };   
    
    public static readonly BibleChapter FirstSamuel1 = new() { Id = Guid.Parse("36644843-80FB-43AD-AFFF-27C0341C01A4"), Name = "1 Samuel 1", ChapterNumber = 1, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel2 = new() { Id = Guid.Parse("866397AC-090D-4A06-8407-FC41A9DF9B5A"), Name = "1 Samuel 2", ChapterNumber = 2, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel3 = new() { Id = Guid.Parse("DA83A9CB-A180-4881-977C-3DDEA2E9C843"), Name = "1 Samuel 3", ChapterNumber = 3, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel4 = new() { Id = Guid.Parse("648C1F21-8FF9-4E77-B0BA-490F90AD58AF"), Name = "1 Samuel 4", ChapterNumber = 4, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel5 = new() { Id = Guid.Parse("0AFCA43F-A55B-4233-97D7-E71D9477AD64"), Name = "1 Samuel 5", ChapterNumber = 5, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel6 = new() { Id = Guid.Parse("E1912CFB-7AA2-439F-816B-2158E4B0D0F3"), Name = "1 Samuel 6", ChapterNumber = 6, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel7 = new() { Id = Guid.Parse("7CFD4BBB-F2AC-4169-9C9D-8F6A80E53389"), Name = "1 Samuel 7", ChapterNumber = 7, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel8 = new() { Id = Guid.Parse("661FC86C-80D8-484B-93AA-07AEBB93AF88"), Name = "1 Samuel 8", ChapterNumber = 8, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel9 = new() { Id = Guid.Parse("09AB9B30-4601-4EA6-8233-E406DCCD76A6"), Name = "1 Samuel 9", ChapterNumber = 9, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel10 = new() { Id = Guid.Parse("F38A5A3E-50E8-4321-906E-232CBC44B982"), Name = "1 Samuel 10", ChapterNumber = 10, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel11 = new() { Id = Guid.Parse("1E2F5D1A-7B11-495C-8423-1CABDFFB7019"), Name = "1 Samuel 11", ChapterNumber = 11, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel12 = new() { Id = Guid.Parse("BFD5597A-5157-44C5-9C26-E48C05139D8D"), Name = "1 Samuel 12", ChapterNumber = 12, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel13 = new() { Id = Guid.Parse("986200C4-83DD-4A18-ACFE-1C14248E3F98"), Name = "1 Samuel 13", ChapterNumber = 13, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel14 = new() { Id = Guid.Parse("3D517F53-DA26-4AD0-9C99-70FC1DCD6950"), Name = "1 Samuel 14", ChapterNumber = 14, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel15 = new() { Id = Guid.Parse("CFD1FD04-FCC8-43A9-8E86-8522D31FF3C3"), Name = "1 Samuel 15", ChapterNumber = 15, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel16 = new() { Id = Guid.Parse("44144E02-FAEC-4710-9936-079D709AEB25"), Name = "1 Samuel 16", ChapterNumber = 16, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel17 = new() { Id = Guid.Parse("7D4530DE-0D63-4A8D-AC39-E33EA50EAB82"), Name = "1 Samuel 17", ChapterNumber = 17, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel18 = new() { Id = Guid.Parse("A8A57585-D7CE-4E96-BC72-3E3E90B1EC21"), Name = "1 Samuel 18", ChapterNumber = 18, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel19 = new() { Id = Guid.Parse("2DFFFF14-54E9-4596-8DD3-3FF6085A5AE8"), Name = "1 Samuel 19", ChapterNumber = 19, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel20 = new() { Id = Guid.Parse("090C003F-CCE1-474B-A282-22A29B7963B4"), Name = "1 Samuel 20", ChapterNumber = 20, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel21 = new() { Id = Guid.Parse("CCF2C72C-596A-4259-95FC-D3095BD9CC29"), Name = "1 Samuel 21", ChapterNumber = 21, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel22 = new() { Id = Guid.Parse("363D6383-EF4E-4511-8682-55006A48FAB8"), Name = "1 Samuel 22", ChapterNumber = 22, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel23 = new() { Id = Guid.Parse("04284367-0C5C-4E53-AF0F-B7FDF29BA4F4"), Name = "1 Samuel 23", ChapterNumber = 23, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel24 = new() { Id = Guid.Parse("10C6B4B4-33A6-4568-A882-4BA2A86D2A68"), Name = "1 Samuel 24", ChapterNumber = 24, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel25 = new() { Id = Guid.Parse("225D013A-A1C0-4702-9A9D-E2C56A802F7F"), Name = "1 Samuel 25", ChapterNumber = 25, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel26 = new() { Id = Guid.Parse("D15CBC58-6460-44BC-A091-2B3E7BB8B7CD"), Name = "1 Samuel 26", ChapterNumber = 26, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel27 = new() { Id = Guid.Parse("214947BE-FE4F-4D2F-AE05-53C436D28BCF"), Name = "1 Samuel 27", ChapterNumber = 27, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel28 = new() { Id = Guid.Parse("ED3281FA-2641-4C6D-96E2-DEA7D6E51918"), Name = "1 Samuel 28", ChapterNumber = 28, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel29 = new() { Id = Guid.Parse("5A46D85D-7ECB-4DAC-88F9-5FA454520542"), Name = "1 Samuel 29", ChapterNumber = 29, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel30 = new() { Id = Guid.Parse("955C18E7-C328-448F-9238-18412A20D3D6"), Name = "1 Samuel 30", ChapterNumber = 30, BibleBookId = BibleBooks.FirstSamuel.Id };
    public static readonly BibleChapter FirstSamuel31 = new() { Id = Guid.Parse("BAE495D2-6644-4320-8B9B-E90A682686DE"), Name = "1 Samuel 31", ChapterNumber = 31, BibleBookId = BibleBooks.FirstSamuel.Id };

    public static readonly BibleChapter SecondSamuel1 = new() { Id = Guid.Parse("1A2BC106-385C-4F25-8304-8DFB0FC105F5"), Name = "2 Samuel 1", ChapterNumber = 1, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel2 = new() { Id = Guid.Parse("2A7B7C01-2756-4F52-AE9E-E134B2B77BB8"), Name = "2 Samuel 2", ChapterNumber = 2, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel3 = new() { Id = Guid.Parse("5867632F-80B4-41ED-A009-9F9C3433D546"), Name = "2 Samuel 3", ChapterNumber = 3, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel4 = new() { Id = Guid.Parse("20DE88F2-9174-4B8E-ACBC-13ED6273FC57"), Name = "2 Samuel 4", ChapterNumber = 4, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel5 = new() { Id = Guid.Parse("B766C58F-06FB-45BC-A4EF-8855FEBBCF7F"), Name = "2 Samuel 5", ChapterNumber = 5, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel6 = new() { Id = Guid.Parse("07F46C31-5E8D-4F6D-8A36-0EC055EBFADD"), Name = "2 Samuel 6", ChapterNumber = 6, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel7 = new() { Id = Guid.Parse("D3679452-2C96-4124-A944-B601586247D5"), Name = "2 Samuel 7", ChapterNumber = 7, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel8 = new() { Id = Guid.Parse("FB6E0347-65C8-43FA-8BC6-50F0482F56F7"), Name = "2 Samuel 8", ChapterNumber = 8, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel9 = new() { Id = Guid.Parse("08B6B236-DF85-4514-B58F-1310E040FC54"), Name = "2 Samuel 9", ChapterNumber = 9, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel10 = new() { Id = Guid.Parse("CBBD9AF8-9581-4237-94BE-84A30D564535"), Name = "2 Samuel 10", ChapterNumber = 10, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel11 = new() { Id = Guid.Parse("640C8B2D-C818-4F6D-92EA-8B9DF26B4F14"), Name = "2 Samuel 11", ChapterNumber = 11, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel12 = new() { Id = Guid.Parse("BA750D63-0713-4A4D-B3E4-48CC1F5D7A0C"), Name = "2 Samuel 12", ChapterNumber = 12, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel13 = new() { Id = Guid.Parse("5A6C8277-2540-43C4-B9B8-28EBF5C63B73"), Name = "2 Samuel 13", ChapterNumber = 13, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel14 = new() { Id = Guid.Parse("4A8CAE49-74A3-4839-A24D-B2F6D367BC66"), Name = "2 Samuel 14", ChapterNumber = 14, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel15 = new() { Id = Guid.Parse("E2C95B6F-B94A-4E4A-B185-B08915DE2E49"), Name = "2 Samuel 15", ChapterNumber = 15, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel16 = new() { Id = Guid.Parse("57F0B1D2-9064-48EA-A52B-A91526FCE5EA"), Name = "2 Samuel 16", ChapterNumber = 16, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel17 = new() { Id = Guid.Parse("6D6747D1-5643-4B5D-9956-4B48BECCE0A2"), Name = "2 Samuel 17", ChapterNumber = 17, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel18 = new() { Id = Guid.Parse("302919B6-E98D-4E86-9A85-6ED164AB30F9"), Name = "2 Samuel 18", ChapterNumber = 18, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel19 = new() { Id = Guid.Parse("EE2EBF25-9188-4A0C-87AB-804F9D0A0491"), Name = "2 Samuel 19", ChapterNumber = 19, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel20 = new() { Id = Guid.Parse("993777F2-6829-4B93-A109-0370FB12D456"), Name = "2 Samuel 20", ChapterNumber = 20, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel21 = new() { Id = Guid.Parse("709423EB-3D0E-4575-A86A-04C3EAEB27C5"), Name = "2 Samuel 21", ChapterNumber = 21, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel22 = new() { Id = Guid.Parse("495BBE74-18EA-46FA-A851-3E9F6114B5E6"), Name = "2 Samuel 22", ChapterNumber = 22, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel23 = new() { Id = Guid.Parse("5254CD4F-6F9F-40C8-8C3B-E4CBD28B0BBC"), Name = "2 Samuel 23", ChapterNumber = 23, BibleBookId = BibleBooks.SecondSamuel.Id };
    public static readonly BibleChapter SecondSamuel24 = new() { Id = Guid.Parse("20659413-C23D-4679-9323-6032E996645B"), Name = "2 Samuel 24", ChapterNumber = 24, BibleBookId = BibleBooks.SecondSamuel.Id };
    
    public static readonly BibleChapter FirstKings1 = new() { Id = Guid.Parse("0154885E-807A-45B5-A60A-AE0EE0E9AE8F"), Name = "1 Kings 1", ChapterNumber = 1, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings2 = new() { Id = Guid.Parse("233C3059-678F-444D-9AD3-AD13AD70AAC8"), Name = "1 Kings 2", ChapterNumber = 2, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings3 = new() { Id = Guid.Parse("7E864422-2072-4E39-8CDD-B2BCCCA13992"), Name = "1 Kings 3", ChapterNumber = 3, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings4 = new() { Id = Guid.Parse("EA78F3D1-301C-41D2-8FA5-F1A438762CF8"), Name = "1 Kings 4", ChapterNumber = 4, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings5 = new() { Id = Guid.Parse("8F9069D7-D54A-4ED5-8173-C1BB3B2A1099"), Name = "1 Kings 5", ChapterNumber = 5, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings6 = new() { Id = Guid.Parse("6537E515-4DF9-4E63-AA79-1EC0FF7AA909"), Name = "1 Kings 6", ChapterNumber = 6, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings7 = new() { Id = Guid.Parse("BE28445B-C34A-48FB-BCF1-9D2319EA5105"), Name = "1 Kings 7", ChapterNumber = 7, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings8 = new() { Id = Guid.Parse("3E2BAE0E-88B1-4569-88F6-8B900531CCDC"), Name = "1 Kings 8", ChapterNumber = 8, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings9 = new() { Id = Guid.Parse("BEC01CEB-0CF1-4C1A-8B0F-33E4E49FC1AF"), Name = "1 Kings 9", ChapterNumber = 9, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings10 = new() { Id = Guid.Parse("0E5BF454-5758-494F-A112-D1E87D4EE15E"), Name = "1 Kings 10", ChapterNumber = 10, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings11 = new() { Id = Guid.Parse("846CFA1B-56B3-433F-A7CF-95A69A11A7F9"), Name = "1 Kings 11", ChapterNumber = 11, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings12 = new() { Id = Guid.Parse("CCB133A5-C17A-4427-B834-262FD436E6B5"), Name = "1 Kings 12", ChapterNumber = 12, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings13 = new() { Id = Guid.Parse("E6B90F8A-5218-45C1-BBD5-4032D3C6E3B0"), Name = "1 Kings 13", ChapterNumber = 13, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings14 = new() { Id = Guid.Parse("BAE4D8C5-5C58-4D15-928B-D5CFFA1AC34C"), Name = "1 Kings 14", ChapterNumber = 14, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings15 = new() { Id = Guid.Parse("95A2FDE8-A7C0-44AD-9872-79AFED7B85AC"), Name = "1 Kings 15", ChapterNumber = 15, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings16 = new() { Id = Guid.Parse("719EF205-8407-4547-B34C-89984CDD119C"), Name = "1 Kings 16", ChapterNumber = 16, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings17 = new() { Id = Guid.Parse("95D2D77C-0B1B-42E5-B144-AD0B038A089D"), Name = "1 Kings 17", ChapterNumber = 17, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings18 = new() { Id = Guid.Parse("74C6312A-DE0D-4F61-9772-D163DA0236CF"), Name = "1 Kings 18", ChapterNumber = 18, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings19 = new() { Id = Guid.Parse("26829406-4487-43E5-9528-2C6F343CD606"), Name = "1 Kings 19", ChapterNumber = 19, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings20 = new() { Id = Guid.Parse("A71F6D2B-627F-4B28-A958-2E521A51ED5A"), Name = "1 Kings 20", ChapterNumber = 20, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings21 = new() { Id = Guid.Parse("A2848856-B8BF-444F-B627-47DB33A258B2"), Name = "1 Kings 21", ChapterNumber = 21, BibleBookId = BibleBooks.FirstKings.Id };
    public static readonly BibleChapter FirstKings22 = new() { Id = Guid.Parse("AA0689BF-0582-4F86-9966-69AAAEE28F8C"), Name = "1 Kings 22", ChapterNumber = 22, BibleBookId = BibleBooks.FirstKings.Id };
    
    public static readonly BibleChapter SecondKings1 = new() { Id = Guid.Parse("6ED9C897-8435-49CC-80FE-79DC997FED8E"), Name = "2 Kings 1", ChapterNumber = 1, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings2 = new() { Id = Guid.Parse("230CF0E6-9161-4077-B817-9FF46F3A1F29"), Name = "2 Kings 2", ChapterNumber = 2, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings3 = new() { Id = Guid.Parse("0239C740-77A2-49AE-9FA6-48F4A048ACC8"), Name = "2 Kings 3", ChapterNumber = 3, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings4 = new() { Id = Guid.Parse("B9C85D99-E06A-471A-9301-0923E6805A87"), Name = "2 Kings 4", ChapterNumber = 4, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings5 = new() { Id = Guid.Parse("489D7866-4D33-48D3-A842-F6DC351FEC57"), Name = "2 Kings 5", ChapterNumber = 5, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings6 = new() { Id = Guid.Parse("CC73E07E-24C7-4500-B495-0F2A1C1770E6"), Name = "2 Kings 6", ChapterNumber = 6, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings7 = new() { Id = Guid.Parse("49C81C53-9ED2-45A2-9205-9B43D9502F17"), Name = "2 Kings 7", ChapterNumber = 7, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings8 = new() { Id = Guid.Parse("24E86EDA-9DA9-4BEB-AF5F-1C30CCAE2ED9"), Name = "2 Kings 8", ChapterNumber = 8, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings9 = new() { Id = Guid.Parse("C1AF4E12-7D4D-4B3D-9FC5-A33D049ACC50"), Name = "2 Kings 9", ChapterNumber = 9, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings10 = new() { Id = Guid.Parse("B0C38D2F-F4AD-4E38-906C-9D1D49CDAC2B"), Name = "2 Kings 10", ChapterNumber = 10, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings11 = new() { Id = Guid.Parse("A388BCC4-F478-4D46-A2BE-F6AAA81CEFEC"), Name = "2 Kings 11", ChapterNumber = 11, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings12 = new() { Id = Guid.Parse("7C4D86C1-2170-465C-92F4-314156ACCB55"), Name = "2 Kings 12", ChapterNumber = 12, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings13 = new() { Id = Guid.Parse("1A1AFBF6-D773-49C2-A9FE-CBF2B5095D30"), Name = "2 Kings 13", ChapterNumber = 13, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings14 = new() { Id = Guid.Parse("7F0D87FA-2A33-4D01-AB25-AEFD60E80068"), Name = "2 Kings 14", ChapterNumber = 14, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings15 = new() { Id = Guid.Parse("3B7663B5-8653-4842-A31B-C0677036475F"), Name = "2 Kings 15", ChapterNumber = 15, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings16 = new() { Id = Guid.Parse("D19F1F11-A304-4D16-B26B-2D211E6D0BC8"), Name = "2 Kings 16", ChapterNumber = 16, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings17 = new() { Id = Guid.Parse("7BED3424-F8DE-4A7F-8B5B-9C9D7B84799B"), Name = "2 Kings 17", ChapterNumber = 17, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings18 = new() { Id = Guid.Parse("70698A41-DD87-4FBC-972D-5A41DD9C164A"), Name = "2 Kings 18", ChapterNumber = 18, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings19 = new() { Id = Guid.Parse("4ADB59F1-2DC4-4ED5-A0A3-A07DAAC6B5B4"), Name = "2 Kings 19", ChapterNumber = 19, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings20 = new() { Id = Guid.Parse("A9AB9070-B81A-44DB-A5AB-DDEE2C6B6503"), Name = "2 Kings 20", ChapterNumber = 20, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings21 = new() { Id = Guid.Parse("2857B11D-E401-4684-B0A0-F58BBD788473"), Name = "2 Kings 21", ChapterNumber = 21, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings22 = new() { Id = Guid.Parse("78709CAD-ABDA-45BF-9A86-9E5EBA5AA7B7"), Name = "2 Kings 22", ChapterNumber = 22, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings23 = new() { Id = Guid.Parse("EF16A68A-8B4F-422A-9119-6159DEC44E6F"), Name = "2 Kings 23", ChapterNumber = 23, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings24 = new() { Id = Guid.Parse("FD4108B7-E92C-4F40-AC55-0BBC55FAF93D"), Name = "2 Kings 24", ChapterNumber = 24, BibleBookId = BibleBooks.SecondKings.Id };
    public static readonly BibleChapter SecondKings25 = new() { Id = Guid.Parse("48C5F217-82A0-49A0-B3D4-E416A88230C8"), Name = "2 Kings 25", ChapterNumber = 25, BibleBookId = BibleBooks.SecondKings.Id };
    
    public static readonly BibleChapter FirstChronicles1 = new() { Id = Guid.Parse("5077FB39-DDE7-4470-B9E8-EAD8C62C14F2"), Name = "1 Chronicles 1", ChapterNumber = 1, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles2 = new() { Id = Guid.Parse("9A1F1368-FB5F-487A-A3D3-D68969CB24E9"), Name = "1 Chronicles 2", ChapterNumber = 2, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles3 = new() { Id = Guid.Parse("2395D08B-E1EE-4205-960B-F53C161B7BE9"), Name = "1 Chronicles 3", ChapterNumber = 3, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles4 = new() { Id = Guid.Parse("99E14B6E-4E47-4D04-A942-7F9C7CFDB606"), Name = "1 Chronicles 4", ChapterNumber = 4, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles5 = new() { Id = Guid.Parse("13602BBD-D9F4-4138-BABA-DF3FD97BD8B3"), Name = "1 Chronicles 5", ChapterNumber = 5, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles6 = new() { Id = Guid.Parse("04D239BB-2966-444D-B167-9D5A2931B60B"), Name = "1 Chronicles 6", ChapterNumber = 6, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles7 = new() { Id = Guid.Parse("2C530128-5624-444F-839F-BE67DDA0F95B"), Name = "1 Chronicles 7", ChapterNumber = 7, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles8 = new() { Id = Guid.Parse("F6B5507B-434F-4E5F-8AB6-010F9AA123EC"), Name = "1 Chronicles 8", ChapterNumber = 8, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles9 = new() { Id = Guid.Parse("2B1F03A0-54D7-48ED-BBDB-89B8EB2526F2"), Name = "1 Chronicles 9", ChapterNumber = 9, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles10 = new() { Id = Guid.Parse("B8CC8D0F-2875-4A27-A60B-D7D3A31233D0"), Name = "1 Chronicles 10", ChapterNumber = 10, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles11 = new() { Id = Guid.Parse("C268D46B-B88E-40BE-8E1B-A3D4B183828A"), Name = "1 Chronicles 11", ChapterNumber = 11, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles12 = new() { Id = Guid.Parse("A8C0A088-E5CC-468D-B9A2-B78E1C96E84D"), Name = "1 Chronicles 12", ChapterNumber = 12, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles13 = new() { Id = Guid.Parse("1F0B982C-C724-4FA0-A50D-E3F3BB1D78CE"), Name = "1 Chronicles 13", ChapterNumber = 13, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles14 = new() { Id = Guid.Parse("13713AE8-42E6-4833-8EFC-8D3BD4429E1F"), Name = "1 Chronicles 14", ChapterNumber = 14, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles15 = new() { Id = Guid.Parse("0C230276-1A26-4DD2-B380-641A22BCA1AC"), Name = "1 Chronicles 15", ChapterNumber = 15, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles16 = new() { Id = Guid.Parse("41251304-19A6-4B55-92D4-3E553D28933B"), Name = "1 Chronicles 16", ChapterNumber = 16, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles17 = new() { Id = Guid.Parse("F0777283-EBD7-4A34-81C5-A104DAE35681"), Name = "1 Chronicles 17", ChapterNumber = 17, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles18 = new() { Id = Guid.Parse("E2458011-5AE2-446B-852C-5A700C50072A"), Name = "1 Chronicles 18", ChapterNumber = 18, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles19 = new() { Id = Guid.Parse("2AF67875-D706-49CF-805B-EC9E4F73F1FF"), Name = "1 Chronicles 19", ChapterNumber = 19, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles20 = new() { Id = Guid.Parse("ACD70A81-C9B4-4505-AA44-E31555CAD51F"), Name = "1 Chronicles 20", ChapterNumber = 20, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles21 = new() { Id = Guid.Parse("4B92EA37-882D-457F-A91B-609112E2A268"), Name = "1 Chronicles 21", ChapterNumber = 21, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles22 = new() { Id = Guid.Parse("02544BD8-DCA3-4AFE-8D5A-389CC4CBDA32"), Name = "1 Chronicles 22", ChapterNumber = 22, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles23 = new() { Id = Guid.Parse("E6EC3DA2-BA0A-4025-9409-9BF515FA6C26"), Name = "1 Chronicles 23", ChapterNumber = 23, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles24 = new() { Id = Guid.Parse("A74482F8-F8A7-4F3E-A4A9-D3861DB45503"), Name = "1 Chronicles 24", ChapterNumber = 24, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles25 = new() { Id = Guid.Parse("97983EFB-2107-4B06-AF70-20860FC2AD08"), Name = "1 Chronicles 25", ChapterNumber = 25, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles26 = new() { Id = Guid.Parse("5B9DB8C9-0809-409C-948A-F09C6F07E1C2"), Name = "1 Chronicles 26", ChapterNumber = 26, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles27 = new() { Id = Guid.Parse("3FA9CF1A-FF5B-4E77-938B-E1E33148D8D0"), Name = "1 Chronicles 27", ChapterNumber = 27, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles28 = new() { Id = Guid.Parse("CEC58C2A-23A2-44C6-9D72-CB8AD41EC747"), Name = "1 Chronicles 28", ChapterNumber = 28, BibleBookId = BibleBooks.FirstChronicles.Id };
    public static readonly BibleChapter FirstChronicles29 = new() { Id = Guid.Parse("7F3CF2D3-0683-40AD-A9CE-E376775EB0A2"), Name = "1 Chronicles 29", ChapterNumber = 29, BibleBookId = BibleBooks.FirstChronicles.Id };
    
    public static readonly BibleChapter SecondChronicles1 = new() { Id = Guid.Parse("2059B223-05EA-4254-BA46-21170326DD9E"), Name = "2 Chronicles 1", ChapterNumber = 1, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles2 = new() { Id = Guid.Parse("A543BB27-0CBD-41E8-9D2D-086F3D450B10"), Name = "2 Chronicles 2", ChapterNumber = 2, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles3 = new() { Id = Guid.Parse("553FC11E-466C-4CE7-98D9-B34453E58711"), Name = "2 Chronicles 3", ChapterNumber = 3, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles4 = new() { Id = Guid.Parse("96559149-2AA0-4CA0-8E9C-B0E9D94C6327"), Name = "2 Chronicles 4", ChapterNumber = 4, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles5 = new() { Id = Guid.Parse("416805E5-A5BD-4309-B226-ADF818AD0082"), Name = "2 Chronicles 5", ChapterNumber = 5, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles6 = new() { Id = Guid.Parse("87B08D29-D7B2-44E1-A6B3-E5BB8F4F51F5"), Name = "2 Chronicles 6", ChapterNumber = 6, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles7 = new() { Id = Guid.Parse("5BF352B2-B8B8-452D-B3D7-6A93E3A0FE9C"), Name = "2 Chronicles 7", ChapterNumber = 7, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles8 = new() { Id = Guid.Parse("FA8F04E3-B030-4EF7-B883-BAA352F84E5C"), Name = "2 Chronicles 8", ChapterNumber = 8, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles9 = new() { Id = Guid.Parse("1FF7C0E1-DCB6-44A0-A3C6-20222BC96F03"), Name = "2 Chronicles 9", ChapterNumber = 9, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles10 = new() { Id = Guid.Parse("A8132DF4-2110-4970-8510-F22BE678F5BF"), Name = "2 Chronicles 10", ChapterNumber = 10, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles11 = new() { Id = Guid.Parse("AEDA32CE-DB7F-4151-882E-753A0FFC4818"), Name = "2 Chronicles 11", ChapterNumber = 11, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles12 = new() { Id = Guid.Parse("33BE5331-AE9E-4A77-8661-83A53DD4A549"), Name = "2 Chronicles 12", ChapterNumber = 12, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles13 = new() { Id = Guid.Parse("FACB3100-819A-4DC6-9023-287CF6B1C654"), Name = "2 Chronicles 13", ChapterNumber = 13, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles14 = new() { Id = Guid.Parse("F2BF4F52-1290-4FE7-9879-5097AC6AC643"), Name = "2 Chronicles 14", ChapterNumber = 14, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles15 = new() { Id = Guid.Parse("2476223E-A2C9-4291-97A5-7ED377DF6732"), Name = "2 Chronicles 15", ChapterNumber = 15, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles16 = new() { Id = Guid.Parse("695B98FF-64CC-4EEF-ACE0-594E0206C707"), Name = "2 Chronicles 16", ChapterNumber = 16, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles17 = new() { Id = Guid.Parse("81A06482-AFFF-4DA9-B084-CA50882DBADF"), Name = "2 Chronicles 17", ChapterNumber = 17, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles18 = new() { Id = Guid.Parse("FCF98C21-4E59-4F20-A31D-D6075B2EC7B4"), Name = "2 Chronicles 18", ChapterNumber = 18, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles19 = new() { Id = Guid.Parse("C2AB3015-D619-41C1-A451-70EDE1723B29"), Name = "2 Chronicles 19", ChapterNumber = 19, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles20 = new() { Id = Guid.Parse("E48FA31A-8C5F-47A9-BDA3-C0C935A4CF6B"), Name = "2 Chronicles 20", ChapterNumber = 20, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles21 = new() { Id = Guid.Parse("CDC359CF-F365-43AA-83E8-233B3CC76105"), Name = "2 Chronicles 21", ChapterNumber = 21, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles22 = new() { Id = Guid.Parse("B36E85C8-0856-4718-BBB1-F583609FA896"), Name = "2 Chronicles 22", ChapterNumber = 22, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles23 = new() { Id = Guid.Parse("39BE15BC-9AC7-4D22-9619-AA1A2165DFF6"), Name = "2 Chronicles 23", ChapterNumber = 23, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles24 = new() { Id = Guid.Parse("DD0DFD66-D031-4785-9311-733A79D3022E"), Name = "2 Chronicles 24", ChapterNumber = 24, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles25 = new() { Id = Guid.Parse("B0824DA0-4FC8-4952-86FB-9562E39B5DF3"), Name = "2 Chronicles 25", ChapterNumber = 25, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles26 = new() { Id = Guid.Parse("81721A3D-95D5-4F31-A1A0-5EB5BD621011"), Name = "2 Chronicles 26", ChapterNumber = 26, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles27 = new() { Id = Guid.Parse("036673CC-EADA-4A8F-B339-D88EF1C8407A"), Name = "2 Chronicles 27", ChapterNumber = 27, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles28 = new() { Id = Guid.Parse("6EC8EFC4-6403-4391-83A1-7D83E3DF92F3"), Name = "2 Chronicles 28", ChapterNumber = 28, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles29 = new() { Id = Guid.Parse("755BADA0-511A-48AC-8AD1-78BF13E1337B"), Name = "2 Chronicles 29", ChapterNumber = 29, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles30 = new() { Id = Guid.Parse("2075497A-5161-4FB4-BC71-C3C7A0D59518"), Name = "2 Chronicles 30", ChapterNumber = 30, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles31 = new() { Id = Guid.Parse("087947A0-07AC-4024-B30E-045F0FB60070"), Name = "2 Chronicles 31", ChapterNumber = 31, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles32 = new() { Id = Guid.Parse("9A30F46D-569F-4D92-8CBA-567ABD34DC7D"), Name = "2 Chronicles 32", ChapterNumber = 32, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles33 = new() { Id = Guid.Parse("EF3C49A9-B4A7-48F9-9EB3-C27FA6F993F5"), Name = "2 Chronicles 33", ChapterNumber = 33, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles34 = new() { Id = Guid.Parse("5669F8A9-973A-406A-9ED1-E0452CFB3EDC"), Name = "2 Chronicles 34", ChapterNumber = 34, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles35 = new() { Id = Guid.Parse("235C1FB6-CE84-4432-A3B2-EA019771FC02"), Name = "2 Chronicles 35", ChapterNumber = 35, BibleBookId = BibleBooks.SecondChronicles.Id };
    public static readonly BibleChapter SecondChronicles36 = new() { Id = Guid.Parse("7C17C732-0AFC-45B2-BFB2-39269AF5CE28"), Name = "2 Chronicles 36", ChapterNumber = 36, BibleBookId = BibleBooks.SecondChronicles.Id };
    
    public static readonly BibleChapter Ezra1 = new() { Id = Guid.Parse("1FF0CCFE-CF26-42F6-B998-67805BF98901"), Name = "Ezra 1", ChapterNumber = 1, BibleBookId = BibleBooks.Ezra.Id };
    public static readonly BibleChapter Ezra2 = new() { Id = Guid.Parse("C6C866A6-8700-41CF-A4DA-41AA873B7812"), Name = "Ezra 2", ChapterNumber = 2, BibleBookId = BibleBooks.Ezra.Id };
    public static readonly BibleChapter Ezra3 = new() { Id = Guid.Parse("7C569D90-C0EE-46A6-9AEB-02670846E318"), Name = "Ezra 3", ChapterNumber = 3, BibleBookId = BibleBooks.Ezra.Id };
    public static readonly BibleChapter Ezra4 = new() { Id = Guid.Parse("9511A1CE-40B1-43F5-9694-CB8310877A7C"), Name = "Ezra 4", ChapterNumber = 4, BibleBookId = BibleBooks.Ezra.Id };
    public static readonly BibleChapter Ezra5 = new() { Id = Guid.Parse("C9640D8E-E3E5-4265-B930-BA958E98AE43"), Name = "Ezra 5", ChapterNumber = 5, BibleBookId = BibleBooks.Ezra.Id };
    public static readonly BibleChapter Ezra6 = new() { Id = Guid.Parse("B3842010-C6C8-4005-91CC-853C3FA5E983"), Name = "Ezra 6", ChapterNumber = 6, BibleBookId = BibleBooks.Ezra.Id };
    public static readonly BibleChapter Ezra7 = new() { Id = Guid.Parse("4CFC7265-6E61-4510-B7E9-1B8C9D88A5EB"), Name = "Ezra 7", ChapterNumber = 7, BibleBookId = BibleBooks.Ezra.Id };
    public static readonly BibleChapter Ezra8 = new() { Id = Guid.Parse("BB5FE0C8-BEBE-45DF-8D94-1D01A2132CF8"), Name = "Ezra 8", ChapterNumber = 8, BibleBookId = BibleBooks.Ezra.Id };
    public static readonly BibleChapter Ezra9 = new() { Id = Guid.Parse("D91EAFCB-B727-41EF-B13D-8B9E09DCC05A"), Name = "Ezra 9", ChapterNumber = 9, BibleBookId = BibleBooks.Ezra.Id };
    public static readonly BibleChapter Ezra10 = new() { Id = Guid.Parse("AE2CE10B-C787-4A1E-B7E7-822E0117EDA7"), Name = "Ezra 10", ChapterNumber = 10, BibleBookId = BibleBooks.Ezra.Id };
    
    public static readonly BibleChapter Nehemiah1 = new() { Id = Guid.Parse("200E234B-5E45-4D52-86E3-5DCF92E8CF53"), Name = "Nehemiah 1", ChapterNumber = 1, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah2 = new() { Id = Guid.Parse("C35987A3-0427-4485-BE2D-DB13BD826037"), Name = "Nehemiah 2", ChapterNumber = 2, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah3 = new() { Id = Guid.Parse("C016F3DE-B520-43A1-8CC0-17004096144C"), Name = "Nehemiah 3", ChapterNumber = 3, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah4 = new() { Id = Guid.Parse("8C6600CE-1F5A-45BB-A898-49E82F5CC273"), Name = "Nehemiah 4", ChapterNumber = 4, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah5 = new() { Id = Guid.Parse("B752E840-8B92-4A37-9564-86EDADD5E4E1"), Name = "Nehemiah 5", ChapterNumber = 5, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah6 = new() { Id = Guid.Parse("F0C52787-FA21-4532-80E7-2DFA766886F7"), Name = "Nehemiah 6", ChapterNumber = 6, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah7 = new() { Id = Guid.Parse("D1E31F69-2893-49A0-8193-90D8C121D9B8"), Name = "Nehemiah 7", ChapterNumber = 7, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah8 = new() { Id = Guid.Parse("C569266B-6736-4B3D-A398-DBE2F5D740F4"), Name = "Nehemiah 8", ChapterNumber = 8, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah9 = new() { Id = Guid.Parse("71FBF6CF-FA53-4081-89FF-2F5437B7CB58"), Name = "Nehemiah 9", ChapterNumber = 9, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah10 = new() { Id = Guid.Parse("08A70FB6-1A6C-4948-B5A7-ABFCEF1B24EC"), Name = "Nehemiah 10", ChapterNumber = 10, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah11 = new() { Id = Guid.Parse("63D1FE53-E60B-4709-8589-76E72330F5C0"), Name = "Nehemiah 11", ChapterNumber = 11, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah12 = new() { Id = Guid.Parse("AE9E961F-6645-4448-A960-6D7AC4AAD0C4"), Name = "Nehemiah 12", ChapterNumber = 12, BibleBookId = BibleBooks.Nehemiah.Id };
    public static readonly BibleChapter Nehemiah13 = new() { Id = Guid.Parse("95A9DA1D-593F-4D74-B5F0-7850CDCE079B"), Name = "Nehemiah 13", ChapterNumber = 13, BibleBookId = BibleBooks.Nehemiah.Id };
    
    public static readonly BibleChapter Esther1 = new() { Id = Guid.Parse("D9DA0A20-FDA7-4D20-A106-C02A29633981"), Name = "Esther 1", ChapterNumber = 1, BibleBookId = BibleBooks.Esther.Id };
    public static readonly BibleChapter Esther2 = new() { Id = Guid.Parse("4474F9CD-552E-4169-9FF9-254551A31EF7"), Name = "Esther 2", ChapterNumber = 2, BibleBookId = BibleBooks.Esther.Id };
    public static readonly BibleChapter Esther3 = new() { Id = Guid.Parse("94A8B7FD-A852-4AF1-BE2D-51BE12C65F32"), Name = "Esther 3", ChapterNumber = 3, BibleBookId = BibleBooks.Esther.Id };
    public static readonly BibleChapter Esther4 = new() { Id = Guid.Parse("A4808580-6F61-4BF6-B587-FD7DDE438DC0"), Name = "Esther 4", ChapterNumber = 4, BibleBookId = BibleBooks.Esther.Id };
    public static readonly BibleChapter Esther5 = new() { Id = Guid.Parse("CC02DDD7-0DEA-4DF6-BFAC-D352B56A62C1"), Name = "Esther 5", ChapterNumber = 5, BibleBookId = BibleBooks.Esther.Id };
    public static readonly BibleChapter Esther6 = new() { Id = Guid.Parse("3A2FE379-45E5-453A-B41E-C1868F124376"), Name = "Esther 6", ChapterNumber = 6, BibleBookId = BibleBooks.Esther.Id };
    public static readonly BibleChapter Esther7 = new() { Id = Guid.Parse("249A0487-9FE1-4250-BFA5-A9027CA3F85A"), Name = "Esther 7", ChapterNumber = 7, BibleBookId = BibleBooks.Esther.Id };
    public static readonly BibleChapter Esther8 = new() { Id = Guid.Parse("0B3E6E5B-8012-476C-9A38-E75C1A5E817A"), Name = "Esther 8", ChapterNumber = 8, BibleBookId = BibleBooks.Esther.Id };
    public static readonly BibleChapter Esther9 = new() { Id = Guid.Parse("FE2573C5-0529-438D-AE69-46EBC0094B5D"), Name = "Esther 9", ChapterNumber = 9, BibleBookId = BibleBooks.Esther.Id };
    public static readonly BibleChapter Esther10 = new() { Id = Guid.Parse("809C5EF3-62ED-421A-9FC1-5A24E64286AE"), Name = "Esther 10", ChapterNumber = 10, BibleBookId = BibleBooks.Esther.Id };
    
    public static readonly BibleChapter Job1 = new() { Id = Guid.Parse("AA859B63-D37C-4E83-A8D9-FCD08D8DA868"), Name = "Job 1", ChapterNumber = 1, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job2 = new() { Id = Guid.Parse("2C6546F6-92D1-4795-81CA-50388F2D44E5"), Name = "Job 2", ChapterNumber = 2, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job3 = new() { Id = Guid.Parse("4CE3D87D-AAC0-4F38-BD57-76B9BC5FE3AE"), Name = "Job 3", ChapterNumber = 3, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job4 = new() { Id = Guid.Parse("10EA613B-45B8-4C1C-8669-EB856FD27620"), Name = "Job 4", ChapterNumber = 4, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job5 = new() { Id = Guid.Parse("29A01E80-60D5-45EC-89E7-E57206748899"), Name = "Job 5", ChapterNumber = 5, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job6 = new() { Id = Guid.Parse("DA2B6A76-BBAA-46D2-B198-679C1DA92F72"), Name = "Job 6", ChapterNumber = 6, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job7 = new() { Id = Guid.Parse("F46C892A-DFE7-4147-8CA7-B7F1D1913BCA"), Name = "Job 7", ChapterNumber = 7, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job8 = new() { Id = Guid.Parse("184E681B-3C09-4AE1-8858-A626CB501D75"), Name = "Job 8", ChapterNumber = 8, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job9 = new() { Id = Guid.Parse("D7704C66-667F-41B0-9004-C6ADAAC6DFE6"), Name = "Job 9", ChapterNumber = 9, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job10 = new() { Id = Guid.Parse("02DAD905-B47B-47C8-9F95-4A0CBC5EA70D"), Name = "Job 10", ChapterNumber = 10, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job11 = new() { Id = Guid.Parse("84722B06-7EDC-462D-AABB-B3136129A11D"), Name = "Job 11", ChapterNumber = 11, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job12 = new() { Id = Guid.Parse("BFC75718-BAAE-4B5A-9188-E84E6B14E419"), Name = "Job 12", ChapterNumber = 12, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job13 = new() { Id = Guid.Parse("5FC6653F-B127-4284-85F7-3270E71270E0"), Name = "Job 13", ChapterNumber = 13, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job14 = new() { Id = Guid.Parse("89812ACD-2ABD-42BE-8615-77EAA26DE4D9"), Name = "Job 14", ChapterNumber = 14, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job15 = new() { Id = Guid.Parse("8BF9490B-ADBC-4C52-873E-661CEA418593"), Name = "Job 15", ChapterNumber = 15, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job16 = new() { Id = Guid.Parse("E2AA3627-FC33-4D93-A775-C67F30D582AA"), Name = "Job 16", ChapterNumber = 16, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job17 = new() { Id = Guid.Parse("AA7C08A5-2DCE-4928-93C9-20853DBE3901"), Name = "Job 17", ChapterNumber = 17, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job18 = new() { Id = Guid.Parse("338DE968-787E-4ECA-AA07-9912B7F123B6"), Name = "Job 18", ChapterNumber = 18, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job19 = new() { Id = Guid.Parse("8FE2BD5E-56B2-49AA-88DA-5104D7E404AA"), Name = "Job 19", ChapterNumber = 19, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job20 = new() { Id = Guid.Parse("8471DE78-C9C5-4AEA-B52D-CF7E0A0E1C01"), Name = "Job 20", ChapterNumber = 20, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job21 = new() { Id = Guid.Parse("89F7664D-FF48-4FB8-AE58-7373C9298F07"), Name = "Job 21", ChapterNumber = 21, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job22 = new() { Id = Guid.Parse("89142CE1-4040-43AF-986C-A8518DE42630"), Name = "Job 22", ChapterNumber = 22, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job23 = new() { Id = Guid.Parse("F6235233-9D3F-401D-8159-3B90CC9FBA75"), Name = "Job 23", ChapterNumber = 23, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job24 = new() { Id = Guid.Parse("2CADDF24-1608-4552-9F6E-656FE80F2E99"), Name = "Job 24", ChapterNumber = 24, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job25 = new() { Id = Guid.Parse("8E37E260-656F-4D42-A23A-3BE74E23FE53"), Name = "Job 25", ChapterNumber = 25, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job26 = new() { Id = Guid.Parse("B2BAFF58-CF5D-4116-89D8-A27B5A08ED00"), Name = "Job 26", ChapterNumber = 26, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job27 = new() { Id = Guid.Parse("D898B3CE-E22E-473C-88FC-DA96209FAD80"), Name = "Job 27", ChapterNumber = 27, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job28 = new() { Id = Guid.Parse("7531A60B-99FB-4B25-A226-0128BFA4BE92"), Name = "Job 28", ChapterNumber = 28, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job29 = new() { Id = Guid.Parse("46574440-D013-4F92-B32C-0782E5DD42D6"), Name = "Job 29", ChapterNumber = 29, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job30 = new() { Id = Guid.Parse("2B5BC112-056C-4D15-A263-0106146C5900"), Name = "Job 30", ChapterNumber = 30, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job31 = new() { Id = Guid.Parse("7E844AF6-C8B7-45EA-AE88-B9105FC50B4B"), Name = "Job 31", ChapterNumber = 31, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job32 = new() { Id = Guid.Parse("63B065BD-37B5-43ED-A0E3-62EFE5033A02"), Name = "Job 32", ChapterNumber = 32, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job33 = new() { Id = Guid.Parse("1A2CB0AD-5654-490E-B01C-6D4B23853337"), Name = "Job 33", ChapterNumber = 33, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job34 = new() { Id = Guid.Parse("B4820C88-520C-4491-9F34-79FC210D6C7B"), Name = "Job 34", ChapterNumber = 34, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job35 = new() { Id = Guid.Parse("DEBAC47E-7AA4-421F-9E27-992FB9A874A7"), Name = "Job 35", ChapterNumber = 35, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job36 = new() { Id = Guid.Parse("6857942F-98C5-4812-87EE-A1935995E730"), Name = "Job 36", ChapterNumber = 36, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job37 = new() { Id = Guid.Parse("E5608719-E927-43B4-9FB0-C06E85C6363F"), Name = "Job 37", ChapterNumber = 37, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job38 = new() { Id = Guid.Parse("59E3210C-DE69-4EAC-AE52-2BE34E7FA400"), Name = "Job 38", ChapterNumber = 38, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job39 = new() { Id = Guid.Parse("087FC721-853D-4D58-AA58-E09A5F296043"), Name = "Job 39", ChapterNumber = 39, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job40 = new() { Id = Guid.Parse("9E0B192B-4EBC-4209-8E32-F4C518B9F9F3"), Name = "Job 40", ChapterNumber = 40, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job41 = new() { Id = Guid.Parse("6D70A27D-7594-4829-8771-D1CE318A153B"), Name = "Job 41", ChapterNumber = 41, BibleBookId = BibleBooks.Job.Id };
    public static readonly BibleChapter Job42 = new() { Id = Guid.Parse("32A40C4D-F96B-4F0B-BBE8-806D76292434"), Name = "Job 42", ChapterNumber = 42, BibleBookId = BibleBooks.Job.Id };

    public static readonly BibleChapter Psalms1 = new() { Id = Guid.Parse("FBE96469-D035-41C3-B480-4086096D525E"), Name = "Psalms 1", ChapterNumber = 1, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms2 = new() { Id = Guid.Parse("905A6E41-43C4-4A34-92E5-D2966C16C3DF"), Name = "Psalms 2", ChapterNumber = 2, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms3 = new() { Id = Guid.Parse("766A3923-6BA7-4831-ADA2-5F44A9AEE375"), Name = "Psalms 3", ChapterNumber = 3, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms4 = new() { Id = Guid.Parse("EDF901A1-5A04-44B0-AE88-67EE6D2C9BB4"), Name = "Psalms 4", ChapterNumber = 4, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms5 = new() { Id = Guid.Parse("D1274E79-84BC-4B89-BA6A-FCB26C980AB6"), Name = "Psalms 5", ChapterNumber = 5, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms6 = new() { Id = Guid.Parse("D2160202-A2E0-4367-B377-742A7A865889"), Name = "Psalms 6", ChapterNumber = 6, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms7 = new() { Id = Guid.Parse("797EB909-D1D7-47A1-8CC8-5E58D1F4A891"), Name = "Psalms 7", ChapterNumber = 7, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms8 = new() { Id = Guid.Parse("06E355E1-2A03-4CE2-8B52-E8C9FCCD6638"), Name = "Psalms 8", ChapterNumber = 8, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms9 = new() { Id = Guid.Parse("5661A3A5-B493-4ECC-8AC1-BEEA8684D415"), Name = "Psalms 9", ChapterNumber = 9, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms10 = new() { Id = Guid.Parse("3063BCD7-6A0E-4BFD-8CFE-B2E9D3ED1C88"), Name = "Psalms 10", ChapterNumber = 10, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms11 = new() { Id = Guid.Parse("FFFF97A7-581F-4416-8C76-1459CAF08778"), Name = "Psalms 11", ChapterNumber = 11, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms12 = new() { Id = Guid.Parse("46927D96-1573-4113-BDD4-646C445F58E9"), Name = "Psalms 12", ChapterNumber = 12, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms13 = new() { Id = Guid.Parse("B35394AA-B1E0-4FAB-A3FF-69E7EDD07A31"), Name = "Psalms 13", ChapterNumber = 13, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms14 = new() { Id = Guid.Parse("3A89BB04-0C21-43C4-AF54-E7F1E0A1A33E"), Name = "Psalms 14", ChapterNumber = 14, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms15 = new() { Id = Guid.Parse("4BEBE3CA-3C38-499E-BFA2-D0E4EFABA989"), Name = "Psalms 15", ChapterNumber = 15, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms16 = new() { Id = Guid.Parse("6306E999-25FC-479F-99D7-B8DE9962C836"), Name = "Psalms 16", ChapterNumber = 16, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms17 = new() { Id = Guid.Parse("3C9DE472-4A85-44DF-9D30-954A66E6C3B4"), Name = "Psalms 17", ChapterNumber = 17, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms18 = new() { Id = Guid.Parse("E00B7BC1-6965-481D-815F-99EF5B1FC19D"), Name = "Psalms 18", ChapterNumber = 18, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms19 = new() { Id = Guid.Parse("ACED0F0D-825B-405C-A9F5-B094A0C32710"), Name = "Psalms 19", ChapterNumber = 19, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms20 = new() { Id = Guid.Parse("71E69EB6-F748-4801-83E4-2E0DB847367C"), Name = "Psalms 20", ChapterNumber = 20, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms21 = new() { Id = Guid.Parse("48D817E6-4608-4A04-AF88-5C66BD9CAE3F"), Name = "Psalms 21", ChapterNumber = 21, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms22 = new() { Id = Guid.Parse("76468BA2-0296-492A-8C31-9D66B00BE3A5"), Name = "Psalms 22", ChapterNumber = 22, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms23 = new() { Id = Guid.Parse("5F729266-99D5-40E1-8F94-6CE5EF7C56B4"), Name = "Psalms 23", ChapterNumber = 23, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms24 = new() { Id = Guid.Parse("2EB96F48-11D7-470D-A955-37992CD562D4"), Name = "Psalms 24", ChapterNumber = 24, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms25 = new() { Id = Guid.Parse("15412FBB-174A-4C40-A617-9CD594AD48BC"), Name = "Psalms 25", ChapterNumber = 25, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms26 = new() { Id = Guid.Parse("206A1E42-EADF-403B-872D-62A0ED97D0A2"), Name = "Psalms 26", ChapterNumber = 26, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms27 = new() { Id = Guid.Parse("AA430F87-6059-4231-AC25-AC81EDFD0E5E"), Name = "Psalms 27", ChapterNumber = 27, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms28 = new() { Id = Guid.Parse("16E89A19-D7B0-4CEF-B145-B56354968DAF"), Name = "Psalms 28", ChapterNumber = 28, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms29 = new() { Id = Guid.Parse("9BE2D42E-F8D7-4122-8C33-7B6F492F4255"), Name = "Psalms 29", ChapterNumber = 29, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms30 = new() { Id = Guid.Parse("83825E9B-70B4-4BF8-A4CB-C61CB1B65822"), Name = "Psalms 30", ChapterNumber = 30, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms31 = new() { Id = Guid.Parse("60BCC045-ADAD-43E0-903E-2D97EBFFABB4"), Name = "Psalms 31", ChapterNumber = 31, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms32 = new() { Id = Guid.Parse("4C73DB51-84EB-43F7-8BE0-CF0AB2DB81A3"), Name = "Psalms 32", ChapterNumber = 32, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms33 = new() { Id = Guid.Parse("6EBDB556-37F9-410E-B2BE-21CA936F4849"), Name = "Psalms 33", ChapterNumber = 33, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms34 = new() { Id = Guid.Parse("139A238D-7BAE-46F6-9D4C-989E4F164240"), Name = "Psalms 34", ChapterNumber = 34, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms35 = new() { Id = Guid.Parse("B50DB648-DB84-437B-9A83-4957FE09F1C5"), Name = "Psalms 35", ChapterNumber = 35, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms36 = new() { Id = Guid.Parse("C1366D33-ED88-4562-A87F-8A30FCF5EEC1"), Name = "Psalms 36", ChapterNumber = 36, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms37 = new() { Id = Guid.Parse("80D0F23A-6ADE-4FE5-B0D5-2B9DE4C4649C"), Name = "Psalms 37", ChapterNumber = 37, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms38 = new() { Id = Guid.Parse("AFDB435E-24B2-4BCF-AECA-3D0D8EEF7869"), Name = "Psalms 38", ChapterNumber = 38, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms39 = new() { Id = Guid.Parse("66A4727C-EC36-4906-A4B1-57D70B11B727"), Name = "Psalms 39", ChapterNumber = 39, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms40 = new() { Id = Guid.Parse("E106203D-91E8-41F1-A527-22E74264AD87"), Name = "Psalms 40", ChapterNumber = 40, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms41 = new() { Id = Guid.Parse("F3E24530-F76D-42D7-B5A7-3DEAE1E2FD46"), Name = "Psalms 41", ChapterNumber = 41, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms42 = new() { Id = Guid.Parse("8B019BA8-93D1-4B80-A5C7-A84BE6B90016"), Name = "Psalms 42", ChapterNumber = 42, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms43 = new() { Id = Guid.Parse("8DD3E84D-0EF9-471E-BD1D-5D8563F9EEEA"), Name = "Psalms 43", ChapterNumber = 43, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms44 = new() { Id = Guid.Parse("A1AA5164-FADF-40AA-8529-624F823E445A"), Name = "Psalms 44", ChapterNumber = 44, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms45 = new() { Id = Guid.Parse("EF9DC10E-8868-4DE4-9F6E-8C8F0A3A365D"), Name = "Psalms 45", ChapterNumber = 45, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms46 = new() { Id = Guid.Parse("1012CE9A-189F-4368-9183-2C6D358BBA45"), Name = "Psalms 46", ChapterNumber = 46, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms47 = new() { Id = Guid.Parse("2F0F2699-56CC-4C16-9AB5-2924D98621F2"), Name = "Psalms 47", ChapterNumber = 47, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms48 = new() { Id = Guid.Parse("0CBE43EC-D287-4BE7-B627-811033483608"), Name = "Psalms 48", ChapterNumber = 48, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms49 = new() { Id = Guid.Parse("CE0B8FBB-3DC3-4A6F-A052-21A4D1564902"), Name = "Psalms 49", ChapterNumber = 49, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms50 = new() { Id = Guid.Parse("B8DF870B-384E-403F-8B68-1B27F53E5E38"), Name = "Psalms 50", ChapterNumber = 50, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms51 = new() { Id = Guid.Parse("FAE4BFF0-A99E-4471-B757-D8720BBBECA3"), Name = "Psalms 51", ChapterNumber = 51, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms52 = new() { Id = Guid.Parse("A807A982-57C7-4B59-A37E-DC763E10DBFE"), Name = "Psalms 52", ChapterNumber = 52, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms53 = new() { Id = Guid.Parse("DA3AB0A5-6157-4E78-B98A-FEF559967BF9"), Name = "Psalms 53", ChapterNumber = 53, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms54 = new() { Id = Guid.Parse("AFDA80B1-1B73-478F-A7CD-4A66D177B3BC"), Name = "Psalms 54", ChapterNumber = 54, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms55 = new() { Id = Guid.Parse("7DD4B3B1-AD26-437A-B9B3-72A94CFD3591"), Name = "Psalms 55", ChapterNumber = 55, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms56 = new() { Id = Guid.Parse("7BA2F139-C664-4551-8AF3-A4021788855D"), Name = "Psalms 56", ChapterNumber = 56, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms57 = new() { Id = Guid.Parse("225A82F6-7403-4358-AD38-FB9019D5614B"), Name = "Psalms 57", ChapterNumber = 57, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms58 = new() { Id = Guid.Parse("7262CABF-65DE-41F2-B83F-FD9EB628F3B3"), Name = "Psalms 58", ChapterNumber = 58, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms59 = new() { Id = Guid.Parse("4DE4FFB2-27B0-43C6-91A0-F7CD53BAF588"), Name = "Psalms 59", ChapterNumber = 59, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms60 = new() { Id = Guid.Parse("071B64AB-1BE1-453A-90DB-F7684981B5FA"), Name = "Psalms 60", ChapterNumber = 60, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms61 = new() { Id = Guid.Parse("F5A5CCCF-E29B-430D-99BE-80715006F991"), Name = "Psalms 61", ChapterNumber = 61, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms62 = new() { Id = Guid.Parse("971EF830-0EAD-48A0-AD26-F271EE4209FF"), Name = "Psalms 62", ChapterNumber = 62, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms63 = new() { Id = Guid.Parse("A37A42C9-751F-4569-8A75-1477CECE7D73"), Name = "Psalms 63", ChapterNumber = 63, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms64 = new() { Id = Guid.Parse("03EE6B4C-4AF8-45B9-B015-56B490E3DA0A"), Name = "Psalms 64", ChapterNumber = 64, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms65 = new() { Id = Guid.Parse("2DAD7B18-A022-41EC-89F5-6557CEC3C917"), Name = "Psalms 65", ChapterNumber = 65, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms66 = new() { Id = Guid.Parse("F62F0E61-ACEE-4175-82E0-7B0B08744452"), Name = "Psalms 66", ChapterNumber = 66, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms67 = new() { Id = Guid.Parse("1119F72F-AF95-465E-8234-5CFADFCB0607"), Name = "Psalms 67", ChapterNumber = 67, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms68 = new() { Id = Guid.Parse("1FF57052-E49B-4ADA-ADD0-22FA41030CBB"), Name = "Psalms 68", ChapterNumber = 68, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms69 = new() { Id = Guid.Parse("DD191562-EC82-4ED6-8E44-F5C4BE0E66A1"), Name = "Psalms 69", ChapterNumber = 69, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms70 = new() { Id = Guid.Parse("9AF7C6C7-BC94-4794-B644-0AB5643C5856"), Name = "Psalms 70", ChapterNumber = 70, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms71 = new() { Id = Guid.Parse("667D6F55-03C2-4B66-862E-701FAE05C088"), Name = "Psalms 71", ChapterNumber = 71, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms72 = new() { Id = Guid.Parse("AEE6102E-2B46-4F35-B794-EADA7EA92401"), Name = "Psalms 72", ChapterNumber = 72, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms73 = new() { Id = Guid.Parse("32B3F460-5BC7-47F7-819E-767416632267"), Name = "Psalms 73", ChapterNumber = 73, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms74 = new() { Id = Guid.Parse("DAA9FCC7-90FC-414E-BBC0-72168F330462"), Name = "Psalms 74", ChapterNumber = 74, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms75 = new() { Id = Guid.Parse("AEA35C54-B979-4E99-8317-90D3584FD98C"), Name = "Psalms 75", ChapterNumber = 75, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms76 = new() { Id = Guid.Parse("8DA03FC1-19A5-4B3C-A697-CBE4E906CB03"), Name = "Psalms 76", ChapterNumber = 76, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms77 = new() { Id = Guid.Parse("71EB615F-D989-4742-BA72-51774829B83C"), Name = "Psalms 77", ChapterNumber = 77, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms78 = new() { Id = Guid.Parse("2822D28A-BC6A-4D04-AA11-1653C977ADDD"), Name = "Psalms 78", ChapterNumber = 78, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms79 = new() { Id = Guid.Parse("AE58A274-91A5-4F29-8A42-1E67AFDCD5AB"), Name = "Psalms 79", ChapterNumber = 79, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms80 = new() { Id = Guid.Parse("03E49E8A-13EC-4534-A4B8-B2DF38A7ADA4"), Name = "Psalms 80", ChapterNumber = 80, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms81 = new() { Id = Guid.Parse("9EA46E44-3C89-4FBB-A058-BB5F67E4F641"), Name = "Psalms 81", ChapterNumber = 81, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms82 = new() { Id = Guid.Parse("707540D5-BAA5-4B51-882D-27CAAA54757C"), Name = "Psalms 82", ChapterNumber = 82, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms83 = new() { Id = Guid.Parse("73EDFB19-B949-43A5-9D51-359A135749E0"), Name = "Psalms 83", ChapterNumber = 83, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms84 = new() { Id = Guid.Parse("5E25B14A-1171-4434-B8A1-BD63E0151B36"), Name = "Psalms 84", ChapterNumber = 84, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms85 = new() { Id = Guid.Parse("6D7C5C8C-A3C8-4DAD-A719-539D749A724C"), Name = "Psalms 85", ChapterNumber = 85, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms86 = new() { Id = Guid.Parse("F2C6073A-3E94-46A1-A419-C16184A5A9A9"), Name = "Psalms 86", ChapterNumber = 86, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms87 = new() { Id = Guid.Parse("C7F50725-1F55-45F2-AFF4-8280D067D94F"), Name = "Psalms 87", ChapterNumber = 87, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms88 = new() { Id = Guid.Parse("88A1C115-78DE-40F1-818D-86C9F101AED7"), Name = "Psalms 88", ChapterNumber = 88, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms89 = new() { Id = Guid.Parse("E3286B5A-AD3B-4153-A4A6-20B1CCA2958A"), Name = "Psalms 89", ChapterNumber = 89, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms90 = new() { Id = Guid.Parse("D4160BE3-4434-4608-B614-3F8690249E3E"), Name = "Psalms 90", ChapterNumber = 90, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms91 = new() { Id = Guid.Parse("EAB8E48C-6C03-450F-98F9-87740895589F"), Name = "Psalms 91", ChapterNumber = 91, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms92 = new() { Id = Guid.Parse("1EA92E0B-BD4F-431C-A6FD-2FDD737BFDF4"), Name = "Psalms 92", ChapterNumber = 92, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms93 = new() { Id = Guid.Parse("2EDFD0E8-AE3D-4127-92DD-7E5EDE18F1B4"), Name = "Psalms 93", ChapterNumber = 93, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms94 = new() { Id = Guid.Parse("57CEBC80-1328-40B7-B025-C026AC75DBCE"), Name = "Psalms 94", ChapterNumber = 94, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms95 = new() { Id = Guid.Parse("5DBF95D4-D946-4E11-AAAF-84FD2FAD55EF"), Name = "Psalms 95", ChapterNumber = 95, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms96 = new() { Id = Guid.Parse("A999FA0F-F096-406F-A7FB-F8258DE7DF2D"), Name = "Psalms 96", ChapterNumber = 96, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms97 = new() { Id = Guid.Parse("AC8F805B-80EF-4B18-B5D6-989642F58843"), Name = "Psalms 97", ChapterNumber = 97, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms98 = new() { Id = Guid.Parse("E5B01568-D9AB-455A-BA0C-078B064DD8C4"), Name = "Psalms 98", ChapterNumber = 98, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms99 = new() { Id = Guid.Parse("254FAE83-A438-4B2C-94B5-A3897B19F09B"), Name = "Psalms 99", ChapterNumber = 99, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms100 = new() { Id = Guid.Parse("0EC119E6-4868-467C-8C59-3CF616387B4E"), Name = "Psalms 100", ChapterNumber = 100, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms101 = new() { Id = Guid.Parse("07B621C6-62CB-465E-9881-13C535338251"), Name = "Psalms 101", ChapterNumber = 101, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms102 = new() { Id = Guid.Parse("68D6A45A-3332-4EF2-8222-F4696E4CB4E8"), Name = "Psalms 102", ChapterNumber = 102, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms103 = new() { Id = Guid.Parse("F4219461-5FDA-4C21-983B-3D2AA3EE8E73"), Name = "Psalms 103", ChapterNumber = 103, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms104 = new() { Id = Guid.Parse("8C6F9A3F-7C2C-4A96-AA6B-13D899CCB9FB"), Name = "Psalms 104", ChapterNumber = 104, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms105 = new() { Id = Guid.Parse("C8298EA5-09FF-4DCD-9B84-446CA47A8F56"), Name = "Psalms 105", ChapterNumber = 105, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms106 = new() { Id = Guid.Parse("4D62EC96-3FC5-4210-A35D-B6E28567BFA5"), Name = "Psalms 106", ChapterNumber = 106, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms107 = new() { Id = Guid.Parse("42D9E84F-F54C-4A49-B160-375892B99E1E"), Name = "Psalms 107", ChapterNumber = 107, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms108 = new() { Id = Guid.Parse("297EE46E-031A-44C8-8A8A-731C3442DC6C"), Name = "Psalms 108", ChapterNumber = 108, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms109 = new() { Id = Guid.Parse("9E8E93E8-A5AE-48BA-8660-49C45C4635A0"), Name = "Psalms 109", ChapterNumber = 109, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms110 = new() { Id = Guid.Parse("EEB7A1DD-B94B-4D5A-A544-A632BDD3837C"), Name = "Psalms 110", ChapterNumber = 110, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms111 = new() { Id = Guid.Parse("92AF3BED-5CAC-498D-8BBC-7F790BECCE88"), Name = "Psalms 111", ChapterNumber = 111, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms112 = new() { Id = Guid.Parse("F222B016-FC9C-4FE4-A861-F5BA52DE30BC"), Name = "Psalms 112", ChapterNumber = 112, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms113 = new() { Id = Guid.Parse("5C45CA4A-420B-4328-B773-D885AB436B57"), Name = "Psalms 113", ChapterNumber = 113, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms114 = new() { Id = Guid.Parse("D8567F98-280A-469B-8BC4-D699DDABA2E3"), Name = "Psalms 114", ChapterNumber = 114, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms115 = new() { Id = Guid.Parse("100DFB7E-32D8-4D7D-BE73-72CEC65D85D2"), Name = "Psalms 115", ChapterNumber = 115, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms116 = new() { Id = Guid.Parse("C6C9C3A1-6069-40D1-BB49-853354FD623F"), Name = "Psalms 116", ChapterNumber = 116, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms117 = new() { Id = Guid.Parse("D420E8E3-DA5D-4FCF-8E5A-72FF9AF63AC9"), Name = "Psalms 117", ChapterNumber = 117, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms118 = new() { Id = Guid.Parse("C267218A-5A56-496E-A489-4056D45BEE00"), Name = "Psalms 118", ChapterNumber = 118, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms119 = new() { Id = Guid.Parse("EC2825DA-9AE3-4354-BA87-9D0679A71EA9"), Name = "Psalms 119", ChapterNumber = 119, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms120 = new() { Id = Guid.Parse("17491AAE-326D-41D2-AA0D-6DB1DE9662F9"), Name = "Psalms 120", ChapterNumber = 120, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms121 = new() { Id = Guid.Parse("37B1B032-B0BE-4003-9D64-D9D147479029"), Name = "Psalms 121", ChapterNumber = 121, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms122 = new() { Id = Guid.Parse("CE7CEB26-7520-497B-BCFF-8DD3D8C2C2A7"), Name = "Psalms 122", ChapterNumber = 122, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms123 = new() { Id = Guid.Parse("58C8AEB1-5692-453C-954B-00EDA9D65324"), Name = "Psalms 123", ChapterNumber = 123, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms124 = new() { Id = Guid.Parse("46B59C70-A24D-4545-ACED-C6B062E7600B"), Name = "Psalms 124", ChapterNumber = 124, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms125 = new() { Id = Guid.Parse("45C4BEC0-44DD-49A5-A6ED-30D3E78E7F3C"), Name = "Psalms 125", ChapterNumber = 125, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms126 = new() { Id = Guid.Parse("F22CCA2E-5DBD-413D-B687-0ED54038272B"), Name = "Psalms 126", ChapterNumber = 126, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms127 = new() { Id = Guid.Parse("0A4EEA9A-CBA0-4AD2-899E-AE6C5D4402FC"), Name = "Psalms 127", ChapterNumber = 127, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms128 = new() { Id = Guid.Parse("3C5D9FAB-B3E6-4C9F-83D7-24EFA8D49B8D"), Name = "Psalms 128", ChapterNumber = 128, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms129 = new() { Id = Guid.Parse("F500B495-BDE6-4792-816E-F0CE05A27660"), Name = "Psalms 129", ChapterNumber = 129, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms130 = new() { Id = Guid.Parse("67EE5377-E22A-4274-96ED-713FF2ED223E"), Name = "Psalms 130", ChapterNumber = 130, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms131 = new() { Id = Guid.Parse("BA3CCCF2-907A-4DE2-B4D5-C13095AD04B2"), Name = "Psalms 131", ChapterNumber = 131, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms132 = new() { Id = Guid.Parse("4B7A1EFE-5C01-4AA0-A17E-CF28C0C7EF1C"), Name = "Psalms 132", ChapterNumber = 132, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms133 = new() { Id = Guid.Parse("35C471A6-C2E5-4CEF-A533-D83FC20BED1D"), Name = "Psalms 133", ChapterNumber = 133, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms134 = new() { Id = Guid.Parse("74A67ABA-902C-41DA-BA49-A5E1DEA602C9"), Name = "Psalms 134", ChapterNumber = 134, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms135 = new() { Id = Guid.Parse("915A4F33-3B1C-456A-83DF-06352A8428A0"), Name = "Psalms 135", ChapterNumber = 135, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms136 = new() { Id = Guid.Parse("1F7A0151-54AF-46FC-9B6B-463ACADEB2BB"), Name = "Psalms 136", ChapterNumber = 136, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms137 = new() { Id = Guid.Parse("30D72548-33C4-4A63-9426-8FE27AC862CC"), Name = "Psalms 137", ChapterNumber = 137, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms138 = new() { Id = Guid.Parse("9CB944AE-4198-4709-A3B4-836592ABBDE8"), Name = "Psalms 138", ChapterNumber = 138, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms139 = new() { Id = Guid.Parse("281EAE24-81CB-4BDC-9F51-9F980889CF61"), Name = "Psalms 139", ChapterNumber = 139, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms140 = new() { Id = Guid.Parse("04F32AF6-1BDC-471C-B7E9-9B704D178EB2"), Name = "Psalms 140", ChapterNumber = 140, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms141 = new() { Id = Guid.Parse("4405031B-D165-4596-888F-1DBA61BB9668"), Name = "Psalms 141", ChapterNumber = 141, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms142 = new() { Id = Guid.Parse("23D089FE-FCBC-491F-BACE-DE95220ADF1A"), Name = "Psalms 142", ChapterNumber = 142, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms143 = new() { Id = Guid.Parse("87E3E40E-726F-4B70-95C4-58A5764FC557"), Name = "Psalms 143", ChapterNumber = 143, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms144 = new() { Id = Guid.Parse("DD2F38E3-4173-4DD7-AA1B-EFA0FBBA2EF4"), Name = "Psalms 144", ChapterNumber = 144, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms145 = new() { Id = Guid.Parse("9EDA1C65-8E8D-4C3C-86CE-60750084C995"), Name = "Psalms 145", ChapterNumber = 145, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms146 = new() { Id = Guid.Parse("0255F3A9-818B-4D24-A746-5E1E6E051D56"), Name = "Psalms 146", ChapterNumber = 146, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms147 = new() { Id = Guid.Parse("3F642A40-19B5-4BBE-A3F7-307B2D6AEDC7"), Name = "Psalms 147", ChapterNumber = 147, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms148 = new() { Id = Guid.Parse("BE1B05D1-BA66-4908-AE6C-BFDA0C92AF76"), Name = "Psalms 148", ChapterNumber = 148, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms149 = new() { Id = Guid.Parse("4BA49D39-E105-4FF4-8DED-0E1B840A6BB8"), Name = "Psalms 149", ChapterNumber = 149, BibleBookId = BibleBooks.Psalms.Id };
    public static readonly BibleChapter Psalms150 = new() { Id = Guid.Parse("76856325-E37F-4387-BACF-785B0026AC26"), Name = "Psalms 150", ChapterNumber = 150, BibleBookId = BibleBooks.Psalms.Id };
    
    public static readonly BibleChapter Proverbs1 = new() { Id = Guid.Parse("AE2453BE-1C07-40C2-8D76-97D545930AFF"), Name = "Proverbs 1", ChapterNumber = 1, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs2 = new() { Id = Guid.Parse("76BD9A58-F299-4CA0-997F-4B636DF07384"), Name = "Proverbs 2", ChapterNumber = 2, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs3 = new() { Id = Guid.Parse("9FDE54CD-88D1-4F65-97BB-035C29200D85"), Name = "Proverbs 3", ChapterNumber = 3, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs4 = new() { Id = Guid.Parse("6DDBD6FF-5CA4-4323-9918-8560EE4745C7"), Name = "Proverbs 4", ChapterNumber = 4, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs5 = new() { Id = Guid.Parse("1F055C16-C28A-463C-9260-E64EA69DBE28"), Name = "Proverbs 5", ChapterNumber = 5, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs6 = new() { Id = Guid.Parse("90BCE1C2-ED35-4804-A6A4-EA41E3108A7A"), Name = "Proverbs 6", ChapterNumber = 6, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs7 = new() { Id = Guid.Parse("CBFEDD53-D887-49A8-819D-FACC7705EB1D"), Name = "Proverbs 7", ChapterNumber = 7, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs8 = new() { Id = Guid.Parse("3DA6CC0D-A9EA-49A6-B130-DC4CD5DED4E5"), Name = "Proverbs 8", ChapterNumber = 8, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs9 = new() { Id = Guid.Parse("02D11B9A-2314-471A-8E9E-3027CBE16632"), Name = "Proverbs 9", ChapterNumber = 9, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs10 = new() { Id = Guid.Parse("C088120E-16BC-4F29-B816-7A7B34D7E87C"), Name = "Proverbs 10", ChapterNumber = 10, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs11 = new() { Id = Guid.Parse("CF791C66-00B7-45DA-AD12-EB27D2C7690A"), Name = "Proverbs 11", ChapterNumber = 11, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs12 = new() { Id = Guid.Parse("D67F21D9-0530-4875-95BB-7C3A5E9F30A6"), Name = "Proverbs 12", ChapterNumber = 12, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs13 = new() { Id = Guid.Parse("1350F6F7-0F76-4FF4-B981-9F746AE59453"), Name = "Proverbs 13", ChapterNumber = 13, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs14 = new() { Id = Guid.Parse("A2FCE1D6-6D78-4FED-8EB9-B58AAF0CA82E"), Name = "Proverbs 14", ChapterNumber = 14, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs15 = new() { Id = Guid.Parse("81B3063A-C3EB-4869-A9C9-D01EEB817E4E"), Name = "Proverbs 15", ChapterNumber = 15, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs16 = new() { Id = Guid.Parse("B97AFDCE-0118-4B11-B1DB-3A47DD9AE658"), Name = "Proverbs 16", ChapterNumber = 16, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs17 = new() { Id = Guid.Parse("0309995D-D8B1-4521-B075-33EB2DAFAE8D"), Name = "Proverbs 17", ChapterNumber = 17, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs18 = new() { Id = Guid.Parse("F8608001-AE94-469D-8570-F43EF7D6A5E9"), Name = "Proverbs 18", ChapterNumber = 18, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs19 = new() { Id = Guid.Parse("71B00CEB-D09F-4717-B6B0-1936FCB35DD4"), Name = "Proverbs 19", ChapterNumber = 19, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs20 = new() { Id = Guid.Parse("C65FF37A-C7D4-4781-B7B2-AF3AB27F2DF5"), Name = "Proverbs 20", ChapterNumber = 20, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs21 = new() { Id = Guid.Parse("BA1A1862-F02A-4E44-9C3B-457FCB0B9EDA"), Name = "Proverbs 21", ChapterNumber = 21, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs22 = new() { Id = Guid.Parse("A49DCDD0-ED19-4402-AD5A-168DD86A521B"), Name = "Proverbs 22", ChapterNumber = 22, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs23 = new() { Id = Guid.Parse("45D25880-74B0-45E3-B830-06EB4AAE1FBA"), Name = "Proverbs 23", ChapterNumber = 23, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs24 = new() { Id = Guid.Parse("D511D5DE-4137-48AB-8A6F-842210A261A3"), Name = "Proverbs 24", ChapterNumber = 24, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs25 = new() { Id = Guid.Parse("D7E81C5D-8656-45C4-815F-E8A935090F10"), Name = "Proverbs 25", ChapterNumber = 25, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs26 = new() { Id = Guid.Parse("C72ED93C-0851-4C12-A9E4-98FE2582D2A7"), Name = "Proverbs 26", ChapterNumber = 26, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs27 = new() { Id = Guid.Parse("DC4BEF32-E922-4E7C-8C49-719844991006"), Name = "Proverbs 27", ChapterNumber = 27, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs28 = new() { Id = Guid.Parse("DB0BA521-29B6-4E59-A4F8-1BB731776341"), Name = "Proverbs 28", ChapterNumber = 28, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs29 = new() { Id = Guid.Parse("0C614AA8-D0D5-4493-9708-8FBE66279F03"), Name = "Proverbs 29", ChapterNumber = 29, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs30 = new() { Id = Guid.Parse("89091DD7-9225-4EF1-B338-995E6353F283"), Name = "Proverbs 30", ChapterNumber = 30, BibleBookId = BibleBooks.Proverbs.Id };
    public static readonly BibleChapter Proverbs31 = new() { Id = Guid.Parse("1D4DAC76-6A33-4EE4-B862-081A6B96563B"), Name = "Proverbs 31", ChapterNumber = 31, BibleBookId = BibleBooks.Proverbs.Id };
    
    public static readonly BibleChapter Ecclesiastes1 = new() { Id = Guid.Parse("FE70B2D5-57DF-4444-905E-7D3925ADF787"), Name = "Ecclesiastes 1", ChapterNumber = 1, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes2 = new() { Id = Guid.Parse("95D77843-EB51-4B59-ABC1-1EB18492E6C0"), Name = "Ecclesiastes 2", ChapterNumber = 2, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes3 = new() { Id = Guid.Parse("FB9DB46E-3102-4724-B10B-8D6E73C472AF"), Name = "Ecclesiastes 3", ChapterNumber = 3, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes4 = new() { Id = Guid.Parse("4EC9330F-01ED-4183-B13E-BD0E73A57F33"), Name = "Ecclesiastes 4", ChapterNumber = 4, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes5 = new() { Id = Guid.Parse("668DAABA-0873-4E33-BA33-101CF721AB88"), Name = "Ecclesiastes 5", ChapterNumber = 5, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes6 = new() { Id = Guid.Parse("370115D6-B54A-4B76-AF94-CFF3FDA0FD8D"), Name = "Ecclesiastes 6", ChapterNumber = 6, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes7 = new() { Id = Guid.Parse("40388C8E-85D4-4D49-9079-ABFEFD4CB2D1"), Name = "Ecclesiastes 7", ChapterNumber = 7, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes8 = new() { Id = Guid.Parse("B2276FEE-DCD1-4095-B007-81C73C28845D"), Name = "Ecclesiastes 8", ChapterNumber = 8, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes9 = new() { Id = Guid.Parse("535C6474-3DA1-4DAA-A068-A4FD87DED4F6"), Name = "Ecclesiastes 9", ChapterNumber = 9, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes10 = new() { Id = Guid.Parse("0E0379E1-1A9A-4E1D-B110-AE87B6F99953"), Name = "Ecclesiastes 10", ChapterNumber = 10, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes11 = new() { Id = Guid.Parse("A92A8B12-311F-4C58-9919-805B482098B2"), Name = "Ecclesiastes 11", ChapterNumber = 11, BibleBookId = BibleBooks.Ecclesiastes.Id };
    public static readonly BibleChapter Ecclesiastes12 = new() { Id = Guid.Parse("79F39AF1-D360-4D8A-B847-B5561C090791"), Name = "Ecclesiastes 12", ChapterNumber = 12, BibleBookId = BibleBooks.Ecclesiastes.Id };
    
    public static readonly BibleChapter SongOfSolomon1 = new() { Id = Guid.Parse("07C01E10-7F38-4780-A689-852F6B5C5CE0"), Name = "Song of Solomon 1", ChapterNumber = 1, BibleBookId = BibleBooks.SongOfSolomon.Id };
    public static readonly BibleChapter SongOfSolomon2 = new() { Id = Guid.Parse("0D31A8F3-7F2E-484D-A6AC-6C4B15889936"), Name = "Song of Solomon 2", ChapterNumber = 2, BibleBookId = BibleBooks.SongOfSolomon.Id };
    public static readonly BibleChapter SongOfSolomon3 = new() { Id = Guid.Parse("6C9043B3-C99E-461D-A331-CDC711A5C70D"), Name = "Song of Solomon 3", ChapterNumber = 3, BibleBookId = BibleBooks.SongOfSolomon.Id };
    public static readonly BibleChapter SongOfSolomon4 = new() { Id = Guid.Parse("F8F94929-A822-4D6D-97A8-CC954065A10C"), Name = "Song of Solomon 4", ChapterNumber = 4, BibleBookId = BibleBooks.SongOfSolomon.Id };
    public static readonly BibleChapter SongOfSolomon5 = new() { Id = Guid.Parse("BCEBA7C1-D63B-4ADA-B44E-A9B7E6B404AC"), Name = "Song of Solomon 5", ChapterNumber = 5, BibleBookId = BibleBooks.SongOfSolomon.Id };
    public static readonly BibleChapter SongOfSolomon6 = new() { Id = Guid.Parse("7CBA152F-DD15-4F38-B072-06BE1270E9C4"), Name = "Song of Solomon 6", ChapterNumber = 6, BibleBookId = BibleBooks.SongOfSolomon.Id };
    public static readonly BibleChapter SongOfSolomon7 = new() { Id = Guid.Parse("25A21229-CE97-4C9D-9CE1-7C7961B6ACF1"), Name = "Song of Solomon 7", ChapterNumber = 7, BibleBookId = BibleBooks.SongOfSolomon.Id };
    public static readonly BibleChapter SongOfSolomon8 = new() { Id = Guid.Parse("6FAF7B22-BF60-48CE-8BA1-D3BD49E52BAA"), Name = "Song of Solomon 8", ChapterNumber = 8, BibleBookId = BibleBooks.SongOfSolomon.Id };
    
    public static readonly BibleChapter Isaiah1 = new() { Id = Guid.Parse("808BCEE3-6A87-42DD-BF3B-564037DC0D08"), Name = "Isaiah 1", ChapterNumber = 1, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah2 = new() { Id = Guid.Parse("E27BE89D-C122-4692-89EF-2557E3F5F855"), Name = "Isaiah 2", ChapterNumber = 2, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah3 = new() { Id = Guid.Parse("32D01443-21BB-4D25-B7B2-2BA903E4AE5B"), Name = "Isaiah 3", ChapterNumber = 3, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah4 = new() { Id = Guid.Parse("DF395E5A-D7AE-4731-9BB0-BE5BE9DE45F4"), Name = "Isaiah 4", ChapterNumber = 4, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah5 = new() { Id = Guid.Parse("46E89075-5D61-4DD7-A599-48DE0FFBD276"), Name = "Isaiah 5", ChapterNumber = 5, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah6 = new() { Id = Guid.Parse("7D182F58-D803-440E-9D57-3038AEFD0533"), Name = "Isaiah 6", ChapterNumber = 6, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah7 = new() { Id = Guid.Parse("052586C3-76FC-43D9-AE42-AA86C84A71FD"), Name = "Isaiah 7", ChapterNumber = 7, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah8 = new() { Id = Guid.Parse("F7680B7F-3175-4D11-AA6F-1F98D0E8D8C4"), Name = "Isaiah 8", ChapterNumber = 8, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah9 = new() { Id = Guid.Parse("7013248F-148A-4961-A22E-D90247369A5A"), Name = "Isaiah 9", ChapterNumber = 9, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah10 = new() { Id = Guid.Parse("D0799EB4-AD6D-43DB-B4DE-15F48611C5B1"), Name = "Isaiah 10", ChapterNumber = 10, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah11 = new() { Id = Guid.Parse("42261073-AEC3-4EC4-8802-5D0BCE631F0C"), Name = "Isaiah 11", ChapterNumber = 11, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah12 = new() { Id = Guid.Parse("1CD71FF1-DFFE-4662-A3B0-83BA00C26E54"), Name = "Isaiah 12", ChapterNumber = 12, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah13 = new() { Id = Guid.Parse("36DBB931-B859-444A-9F17-21F6DF8B4392"), Name = "Isaiah 13", ChapterNumber = 13, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah14 = new() { Id = Guid.Parse("03D7FED3-28F6-4267-81E7-5D5829E7144E"), Name = "Isaiah 14", ChapterNumber = 14, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah15 = new() { Id = Guid.Parse("81916520-15A3-4CD7-B79A-7F9AD4E3EF8F"), Name = "Isaiah 15", ChapterNumber = 15, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah16 = new() { Id = Guid.Parse("74885AD0-4D74-4E17-BADB-27F5B385DAB6"), Name = "Isaiah 16", ChapterNumber = 16, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah17 = new() { Id = Guid.Parse("942B0958-E03F-4B40-9714-876D05ABF50B"), Name = "Isaiah 17", ChapterNumber = 17, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah18 = new() { Id = Guid.Parse("30FC39E8-0B5F-434F-8B49-BB6C2F11B8DC"), Name = "Isaiah 18", ChapterNumber = 18, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah19 = new() { Id = Guid.Parse("B408441D-3C42-4C0C-A432-83DC7E44B3D3"), Name = "Isaiah 19", ChapterNumber = 19, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah20 = new() { Id = Guid.Parse("AC1EE399-599B-4732-BD17-99D954E1667E"), Name = "Isaiah 20", ChapterNumber = 20, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah21 = new() { Id = Guid.Parse("F8804DE8-DE23-4AEB-9724-918A08636837"), Name = "Isaiah 21", ChapterNumber = 21, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah22 = new() { Id = Guid.Parse("2AA5C11D-9F4F-4BBE-AB65-A90EEF2067FC"), Name = "Isaiah 22", ChapterNumber = 22, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah23 = new() { Id = Guid.Parse("1921D42F-7B4B-4FD9-8F4F-477B93A896B7"), Name = "Isaiah 23", ChapterNumber = 23, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah24 = new() { Id = Guid.Parse("C0C5BCB1-9C51-4F34-BA13-AD1F63CE7597"), Name = "Isaiah 24", ChapterNumber = 24, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah25 = new() { Id = Guid.Parse("258CBBD7-C1EF-45C4-9F54-A0539547B824"), Name = "Isaiah 25", ChapterNumber = 25, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah26 = new() { Id = Guid.Parse("ACDD133B-F5EF-48A6-BF2F-45DCB47184B5"), Name = "Isaiah 26", ChapterNumber = 26, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah27 = new() { Id = Guid.Parse("785D9742-C5C1-41C3-97A6-4B0E47682763"), Name = "Isaiah 27", ChapterNumber = 27, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah28 = new() { Id = Guid.Parse("DEC2EDAE-9A9E-44B0-B931-9B5EE19232FC"), Name = "Isaiah 28", ChapterNumber = 28, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah29 = new() { Id = Guid.Parse("2ED3F6A1-D833-4C38-86D1-D7EA5BB70733"), Name = "Isaiah 29", ChapterNumber = 29, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah30 = new() { Id = Guid.Parse("77E60124-5A1B-451D-ACE5-FA007381F489"), Name = "Isaiah 30", ChapterNumber = 30, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah31 = new() { Id = Guid.Parse("388DA375-727F-406A-AD48-1EEEF1C05097"), Name = "Isaiah 31", ChapterNumber = 31, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah32 = new() { Id = Guid.Parse("729B90A8-BE9B-409C-AAC4-0E5FA138DE31"), Name = "Isaiah 32", ChapterNumber = 32, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah33 = new() { Id = Guid.Parse("83CF3891-DF84-42D5-9D9E-3549BA842986"), Name = "Isaiah 33", ChapterNumber = 33, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah34 = new() { Id = Guid.Parse("11ACDA90-EC52-4F2D-B698-9F87928FAE4C"), Name = "Isaiah 34", ChapterNumber = 34, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah35 = new() { Id = Guid.Parse("F2ADBABA-A392-4D7A-AFA2-41B8C1F80719"), Name = "Isaiah 35", ChapterNumber = 35, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah36 = new() { Id = Guid.Parse("0A7EA857-3023-460E-A4EB-1651F1F84004"), Name = "Isaiah 36", ChapterNumber = 36, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah37 = new() { Id = Guid.Parse("AA7ED98B-07C8-4769-A4A8-D8F382CFF137"), Name = "Isaiah 37", ChapterNumber = 37, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah38 = new() { Id = Guid.Parse("49C8B0EC-82F3-4927-97F2-4827AC72D4AA"), Name = "Isaiah 38", ChapterNumber = 38, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah39 = new() { Id = Guid.Parse("0057CC7E-4C07-4AA0-A12C-FA3A4BF5B3B1"), Name = "Isaiah 39", ChapterNumber = 39, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah40 = new() { Id = Guid.Parse("62D73552-36E9-4267-A9DE-0041B66E1404"), Name = "Isaiah 40", ChapterNumber = 40, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah41 = new() { Id = Guid.Parse("46BC3330-6953-4831-B98C-EE72252CBE26"), Name = "Isaiah 41", ChapterNumber = 41, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah42 = new() { Id = Guid.Parse("ECA87217-BC29-4372-82E7-FD1203AFB25E"), Name = "Isaiah 42", ChapterNumber = 42, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah43 = new() { Id = Guid.Parse("6227854D-CDCC-40C3-ABE3-FFB8B56BD6D7"), Name = "Isaiah 43", ChapterNumber = 43, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah44 = new() { Id = Guid.Parse("879C89BE-8434-49BD-B222-DD2C6AFC0E33"), Name = "Isaiah 44", ChapterNumber = 44, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah45 = new() { Id = Guid.Parse("00AFD8E7-01DE-4BA7-A46B-E982C0A6FA5B"), Name = "Isaiah 45", ChapterNumber = 45, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah46 = new() { Id = Guid.Parse("80B0052A-22AC-46A2-84D8-483986B1BD45"), Name = "Isaiah 46", ChapterNumber = 46, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah47 = new() { Id = Guid.Parse("1A1EA19A-CD0C-4970-959C-161F314AFB27"), Name = "Isaiah 47", ChapterNumber = 47, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah48 = new() { Id = Guid.Parse("226240F7-2F92-4A36-BC6A-66BE997E39D4"), Name = "Isaiah 48", ChapterNumber = 48, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah49 = new() { Id = Guid.Parse("3BD45A3F-5451-4C26-BD2A-78FD6FA948EA"), Name = "Isaiah 49", ChapterNumber = 49, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah50 = new() { Id = Guid.Parse("B54EA8E7-2457-4108-AAA2-F20635948E3D"), Name = "Isaiah 50", ChapterNumber = 50, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah51 = new() { Id = Guid.Parse("F7F431FC-C90A-43FB-8006-58E8F6E7EE33"), Name = "Isaiah 51", ChapterNumber = 51, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah52 = new() { Id = Guid.Parse("F81B70B9-9602-4B83-8B1D-5CCB6DA5C626"), Name = "Isaiah 52", ChapterNumber = 52, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah53 = new() { Id = Guid.Parse("5C108C55-22F6-49E1-9071-DC29FCE5D536"), Name = "Isaiah 53", ChapterNumber = 53, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah54 = new() { Id = Guid.Parse("7A8F9989-B6F2-4227-B476-E0148DAEDFAE"), Name = "Isaiah 54", ChapterNumber = 54, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah55 = new() { Id = Guid.Parse("3D6FD65B-A512-43BF-9711-0D45A045879C"), Name = "Isaiah 55", ChapterNumber = 55, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah56 = new() { Id = Guid.Parse("EE20E265-F3F3-479F-9FC2-535ACD619430"), Name = "Isaiah 56", ChapterNumber = 56, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah57 = new() { Id = Guid.Parse("69148A5C-5C17-42C3-9347-5A68D7B7AFF0"), Name = "Isaiah 57", ChapterNumber = 57, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah58 = new() { Id = Guid.Parse("2ACE77F0-7075-4050-9438-057D8701A915"), Name = "Isaiah 58", ChapterNumber = 58, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah59 = new() { Id = Guid.Parse("F5F6CFC7-BFE8-44FF-A1CA-CA91BF82076B"), Name = "Isaiah 59", ChapterNumber = 59, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah60 = new() { Id = Guid.Parse("66DC291E-CECC-44A1-964F-7896A955F892"), Name = "Isaiah 60", ChapterNumber = 60, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah61 = new() { Id = Guid.Parse("BE9C5100-127F-4886-B1AA-703F7A8D4F31"), Name = "Isaiah 61", ChapterNumber = 61, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah62 = new() { Id = Guid.Parse("0FD568A7-D9B6-400A-8716-58596C2C2BC7"), Name = "Isaiah 62", ChapterNumber = 62, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah63 = new() { Id = Guid.Parse("48C0A5F2-AFB2-4880-B1A9-4A5B86F77FD0"), Name = "Isaiah 63", ChapterNumber = 63, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah64 = new() { Id = Guid.Parse("ECC8992A-0876-4926-AF77-5BC2A664CB1E"), Name = "Isaiah 64", ChapterNumber = 64, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah65 = new() { Id = Guid.Parse("DDFA3C23-330C-46D3-A566-41ACE0E92EDB"), Name = "Isaiah 65", ChapterNumber = 65, BibleBookId = BibleBooks.Isaiah.Id };
    public static readonly BibleChapter Isaiah66 = new() { Id = Guid.Parse("6F910DE2-2712-4BDA-BEF3-16C8EA802879"), Name = "Isaiah 66", ChapterNumber = 66, BibleBookId = BibleBooks.Isaiah.Id };
    
    public static readonly BibleChapter Jeremiah1 = new() { Id = Guid.Parse("CA6A98B2-A62C-47E2-ACD6-FA16837C10AB"), Name = "Jeremiah 1", ChapterNumber = 1, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah2 = new() { Id = Guid.Parse("BE1D9A57-FC3E-4CA7-BEA9-3AD9EE81240B"), Name = "Jeremiah 2", ChapterNumber = 2, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah3 = new() { Id = Guid.Parse("78736B03-D8BA-481E-B0BC-AB018EDA3E02"), Name = "Jeremiah 3", ChapterNumber = 3, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah4 = new() { Id = Guid.Parse("9DB5A6AC-99E4-4666-906D-1E7E1EF64CA6"), Name = "Jeremiah 4", ChapterNumber = 4, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah5 = new() { Id = Guid.Parse("22DF1F34-4D63-4037-992D-300C16947118"), Name = "Jeremiah 5", ChapterNumber = 5, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah6 = new() { Id = Guid.Parse("6E02C4BB-D311-4848-B78E-C48C5028AA24"), Name = "Jeremiah 6", ChapterNumber = 6, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah7 = new() { Id = Guid.Parse("09D01D0A-A4A9-423F-96A0-F2CACDB16128"), Name = "Jeremiah 7", ChapterNumber = 7, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah8 = new() { Id = Guid.Parse("A58AA200-BF69-46F0-8BFB-2D9D1E116475"), Name = "Jeremiah 8", ChapterNumber = 8, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah9 = new() { Id = Guid.Parse("9BEB565C-3DED-43DD-B517-9700E0222B74"), Name = "Jeremiah 9", ChapterNumber = 9, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah10 = new() { Id = Guid.Parse("448435B5-7439-4070-A9A5-468DFA585F46"), Name = "Jeremiah 10", ChapterNumber = 10, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah11 = new() { Id = Guid.Parse("A1FF9C67-5F19-4B8B-BFD8-EABEB68A4B7C"), Name = "Jeremiah 11", ChapterNumber = 11, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah12 = new() { Id = Guid.Parse("D93F48A6-B7C5-4D41-B4FF-849AD56578AE"), Name = "Jeremiah 12", ChapterNumber = 12, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah13 = new() { Id = Guid.Parse("9D1384F0-E121-4756-AC8D-DA54EEE4FD71"), Name = "Jeremiah 13", ChapterNumber = 13, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah14 = new() { Id = Guid.Parse("A6C4CF9B-D65E-4463-921E-82BFD9C491F9"), Name = "Jeremiah 14", ChapterNumber = 14, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah15 = new() { Id = Guid.Parse("A8EC4F98-6FD1-4A46-A9AD-7B0B851D06F6"), Name = "Jeremiah 15", ChapterNumber = 15, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah16 = new() { Id = Guid.Parse("320E28A7-A472-4D29-BFB5-9C11557C9F5F"), Name = "Jeremiah 16", ChapterNumber = 16, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah17 = new() { Id = Guid.Parse("B36FE49F-A76F-4BC7-81EF-6CA70BD49B41"), Name = "Jeremiah 17", ChapterNumber = 17, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah18 = new() { Id = Guid.Parse("E423525A-61D7-460F-A29F-B8C02DA3D5B0"), Name = "Jeremiah 18", ChapterNumber = 18, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah19 = new() { Id = Guid.Parse("3D71FC22-1F2B-4819-8BBE-B5345F65630B"), Name = "Jeremiah 19", ChapterNumber = 19, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah20 = new() { Id = Guid.Parse("DD754B9A-0A9A-46B2-BDA4-C98113C74F3E"), Name = "Jeremiah 20", ChapterNumber = 20, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah21 = new() { Id = Guid.Parse("07DDB87C-C1EA-448E-BAE9-8CBD363EE2EF"), Name = "Jeremiah 21", ChapterNumber = 21, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah22 = new() { Id = Guid.Parse("9C0506EC-13B8-4563-BAC7-50433249B8E5"), Name = "Jeremiah 22", ChapterNumber = 22, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah23 = new() { Id = Guid.Parse("E6AAB9A7-421F-44F5-B3A4-79B3203207AA"), Name = "Jeremiah 23", ChapterNumber = 23, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah24 = new() { Id = Guid.Parse("1627474C-7871-448C-BFC5-3C7C5D4C8CA2"), Name = "Jeremiah 24", ChapterNumber = 24, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah25 = new() { Id = Guid.Parse("E4250C14-2497-46DC-ACDE-D2FA987C43B8"), Name = "Jeremiah 25", ChapterNumber = 25, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah26 = new() { Id = Guid.Parse("00EE9E9B-5EC0-454B-A137-1BA773B02B2D"), Name = "Jeremiah 26", ChapterNumber = 26, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah27 = new() { Id = Guid.Parse("D0A6D7D4-4D86-49B7-8C4B-AA266BA4B902"), Name = "Jeremiah 27", ChapterNumber = 27, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah28 = new() { Id = Guid.Parse("7C872839-94CB-4750-AB72-1D5582E4FFF4"), Name = "Jeremiah 28", ChapterNumber = 28, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah29 = new() { Id = Guid.Parse("0E067913-385A-4A05-A168-87BA8F55A79E"), Name = "Jeremiah 29", ChapterNumber = 29, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah30 = new() { Id = Guid.Parse("B0ED9C6B-55D8-46FE-AF81-A9AACD60A6B9"), Name = "Jeremiah 30", ChapterNumber = 30, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah31 = new() { Id = Guid.Parse("E8D01C38-B8F4-4B5A-B272-67CD06186465"), Name = "Jeremiah 31", ChapterNumber = 31, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah32 = new() { Id = Guid.Parse("B8635187-5AEB-46CE-AD5B-99E9E82754DC"), Name = "Jeremiah 32", ChapterNumber = 32, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah33 = new() { Id = Guid.Parse("9C817CDF-B98B-4DA0-B4A7-D68427C32A2E"), Name = "Jeremiah 33", ChapterNumber = 33, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah34 = new() { Id = Guid.Parse("ECF284CB-5189-46D9-A635-1C15F4703662"), Name = "Jeremiah 34", ChapterNumber = 34, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah35 = new() { Id = Guid.Parse("752C31DA-004B-4871-A442-8036169E5526"), Name = "Jeremiah 35", ChapterNumber = 35, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah36 = new() { Id = Guid.Parse("5155C66A-6A57-43F6-9D23-E54254DE7A13"), Name = "Jeremiah 36", ChapterNumber = 36, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah37 = new() { Id = Guid.Parse("8AB03BB0-933C-4C26-BF75-71CA528CA798"), Name = "Jeremiah 37", ChapterNumber = 37, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah38 = new() { Id = Guid.Parse("034465AB-12AB-4029-8983-CC84650AD72E"), Name = "Jeremiah 38", ChapterNumber = 38, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah39 = new() { Id = Guid.Parse("BD071F49-AC62-4C39-B8C9-98EFDE2AF3D9"), Name = "Jeremiah 39", ChapterNumber = 39, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah40 = new() { Id = Guid.Parse("32ED1D8A-1529-4B5A-8492-079A1FE5270B"), Name = "Jeremiah 40", ChapterNumber = 40, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah41 = new() { Id = Guid.Parse("498CD9A0-2481-4AFE-BDA8-19970CF6EAD7"), Name = "Jeremiah 41", ChapterNumber = 41, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah42 = new() { Id = Guid.Parse("87F6C7FB-715B-4210-9260-BC1F88F071F2"), Name = "Jeremiah 42", ChapterNumber = 42, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah43 = new() { Id = Guid.Parse("C7343699-98C7-493D-8ACA-447380FA3D4D"), Name = "Jeremiah 43", ChapterNumber = 43, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah44 = new() { Id = Guid.Parse("D4DFE98B-C57A-45EC-B580-F6F9E57CD18B"), Name = "Jeremiah 44", ChapterNumber = 44, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah45 = new() { Id = Guid.Parse("E96CCE3A-E365-4276-9133-EE89D874102D"), Name = "Jeremiah 45", ChapterNumber = 45, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah46 = new() { Id = Guid.Parse("5D2C5DAB-C3F5-494E-B6B6-543666C36483"), Name = "Jeremiah 46", ChapterNumber = 46, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah47 = new() { Id = Guid.Parse("139F8471-0811-4DFD-A602-54040B2F41FF"), Name = "Jeremiah 47", ChapterNumber = 47, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah48 = new() { Id = Guid.Parse("3BCC0039-32ED-4D6B-8E78-4B21C26B012D"), Name = "Jeremiah 48", ChapterNumber = 48, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah49 = new() { Id = Guid.Parse("606F4756-19B5-4E96-93C2-037D6C0DA657"), Name = "Jeremiah 49", ChapterNumber = 49, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah50 = new() { Id = Guid.Parse("4B7BE571-2803-4369-B8BC-50DC9122F8DA"), Name = "Jeremiah 50", ChapterNumber = 50, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah51 = new() { Id = Guid.Parse("A2DAE7DA-96FA-4BA6-9F04-B0B9F1AE4B15"), Name = "Jeremiah 51", ChapterNumber = 51, BibleBookId = BibleBooks.Jeremiah.Id };
    public static readonly BibleChapter Jeremiah52 = new() { Id = Guid.Parse("0DBAE16E-890D-4976-AA4D-4011CE425822"), Name = "Jeremiah 52", ChapterNumber = 52, BibleBookId = BibleBooks.Jeremiah.Id };
    
    public static readonly BibleChapter Lamentations1 = new() { Id = Guid.Parse("77A9E004-C5EE-425B-96E5-F14464B0064C"), Name = "Lamentations 1", ChapterNumber = 1, BibleBookId = BibleBooks.Lamentations.Id };
    public static readonly BibleChapter Lamentations2 = new() { Id = Guid.Parse("2C26E9CD-65F2-4E83-9334-B1F8AEB714A5"), Name = "Lamentations 2", ChapterNumber = 2, BibleBookId = BibleBooks.Lamentations.Id };
    public static readonly BibleChapter Lamentations3 = new() { Id = Guid.Parse("9753BC2A-7B26-4FC3-817A-7225EDB4DDAC"), Name = "Lamentations 3", ChapterNumber = 3, BibleBookId = BibleBooks.Lamentations.Id };
    public static readonly BibleChapter Lamentations4 = new() { Id = Guid.Parse("033F95B9-60D2-4985-9838-563BBDE05853"), Name = "Lamentations 4", ChapterNumber = 4, BibleBookId = BibleBooks.Lamentations.Id };
    public static readonly BibleChapter Lamentations5 = new() { Id = Guid.Parse("7D8EA2D2-9BCA-4078-B8FE-EE3E4983E28C"), Name = "Lamentations 5", ChapterNumber = 5, BibleBookId = BibleBooks.Lamentations.Id };
    
    public static readonly BibleChapter Ezekiel1 = new() { Id = Guid.Parse("E34F9F0D-F94C-4B5D-B2A9-4971B9991E7A"), Name = "Ezekiel 1", ChapterNumber = 1, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel2 = new() { Id = Guid.Parse("32659D53-D9D4-49BB-BE81-E3A93CA98FBD"), Name = "Ezekiel 2", ChapterNumber = 2, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel3 = new() { Id = Guid.Parse("56CA124C-2098-4952-B991-EA5D67C8939F"), Name = "Ezekiel 3", ChapterNumber = 3, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel4 = new() { Id = Guid.Parse("322990FE-07DC-4706-91FD-807562E51E93"), Name = "Ezekiel 4", ChapterNumber = 4, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel5 = new() { Id = Guid.Parse("7E34AC86-B66E-47C7-8D2E-74183CE883ED"), Name = "Ezekiel 5", ChapterNumber = 5, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel6 = new() { Id = Guid.Parse("F07D4018-7B87-41C7-A082-9009DAB658B2"), Name = "Ezekiel 6", ChapterNumber = 6, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel7 = new() { Id = Guid.Parse("13D32DE1-0310-48E4-B64C-309913A0D87A"), Name = "Ezekiel 7", ChapterNumber = 7, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel8 = new() { Id = Guid.Parse("B3B416D8-2693-48C7-869E-55BC1D5707E7"), Name = "Ezekiel 8", ChapterNumber = 8, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel9 = new() { Id = Guid.Parse("DDB9C74C-64B5-425C-805C-18B655DABDE3"), Name = "Ezekiel 9", ChapterNumber = 9, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel10 = new() { Id = Guid.Parse("ECF721ED-79A1-4C8B-B08D-A17B77773A4A"), Name = "Ezekiel 10", ChapterNumber = 10, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel11 = new() { Id = Guid.Parse("777D43BB-E98A-4544-9955-8D21D04331A0"), Name = "Ezekiel 11", ChapterNumber = 11, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel12 = new() { Id = Guid.Parse("2B6CFE9A-83F7-475E-839A-A32E7C1F1889"), Name = "Ezekiel 12", ChapterNumber = 12, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel13 = new() { Id = Guid.Parse("A3534DFD-AB10-401F-9703-C4ADCCFCC93F"), Name = "Ezekiel 13", ChapterNumber = 13, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel14 = new() { Id = Guid.Parse("8EAAACEE-F39B-484C-975D-02DA7431927D"), Name = "Ezekiel 14", ChapterNumber = 14, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel15 = new() { Id = Guid.Parse("D1DBE6DF-855B-4BF0-840E-887849396424"), Name = "Ezekiel 15", ChapterNumber = 15, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel16 = new() { Id = Guid.Parse("337A004F-9DF0-446A-8EF2-B793A1201E56"), Name = "Ezekiel 16", ChapterNumber = 16, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel17 = new() { Id = Guid.Parse("179EB732-394A-4274-A775-D353D0F2D8E3"), Name = "Ezekiel 17", ChapterNumber = 17, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel18 = new() { Id = Guid.Parse("324D0440-6FD4-48E8-8232-B11E3EE7F38F"), Name = "Ezekiel 18", ChapterNumber = 18, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel19 = new() { Id = Guid.Parse("7F167956-537A-4740-BB71-9B93A99BDB3E"), Name = "Ezekiel 19", ChapterNumber = 19, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel20 = new() { Id = Guid.Parse("717067C7-2A83-4AE9-9A07-422EFB6A8360"), Name = "Ezekiel 20", ChapterNumber = 20, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel21 = new() { Id = Guid.Parse("61A40B34-7CBB-4BCA-8760-E57BD034704C"), Name = "Ezekiel 21", ChapterNumber = 21, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel22 = new() { Id = Guid.Parse("C77378D7-D6E0-4BD1-8B25-FB7DE5F75761"), Name = "Ezekiel 22", ChapterNumber = 22, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel23 = new() { Id = Guid.Parse("23C572F5-0AE3-427E-8A4D-99379B6D022E"), Name = "Ezekiel 23", ChapterNumber = 23, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel24 = new() { Id = Guid.Parse("26FB9F76-1A70-4DB6-AE20-0DF1E6C279DB"), Name = "Ezekiel 24", ChapterNumber = 24, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel25 = new() { Id = Guid.Parse("E41A7F19-A449-4F5C-8631-66CDF8107B53"), Name = "Ezekiel 25", ChapterNumber = 25, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel26 = new() { Id = Guid.Parse("EB1C1F0E-3054-4A10-BD8C-46B995741AE4"), Name = "Ezekiel 26", ChapterNumber = 26, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel27 = new() { Id = Guid.Parse("33038D03-906D-46C5-85CA-F5E9AF0D6B6B"), Name = "Ezekiel 27", ChapterNumber = 27, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel28 = new() { Id = Guid.Parse("C3D7A83F-9318-43C3-AD66-EF9381CB79C9"), Name = "Ezekiel 28", ChapterNumber = 28, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel29 = new() { Id = Guid.Parse("CAB18AA1-510B-44FA-978E-248868718A1B"), Name = "Ezekiel 29", ChapterNumber = 29, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel30 = new() { Id = Guid.Parse("364D8CA1-222A-450C-B732-6CE0F1F1C6CC"), Name = "Ezekiel 30", ChapterNumber = 30, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel31 = new() { Id = Guid.Parse("BCB3DEC4-BB62-4E9C-AFB9-B722701F6EEE"), Name = "Ezekiel 31", ChapterNumber = 31, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel32 = new() { Id = Guid.Parse("056B05BC-1EEA-4E44-817B-B88794E9258B"), Name = "Ezekiel 32", ChapterNumber = 32, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel33 = new() { Id = Guid.Parse("8C27CD07-62EC-44C8-B584-82FB2BB7A6F1"), Name = "Ezekiel 33", ChapterNumber = 33, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel34 = new() { Id = Guid.Parse("98BFBE37-C394-4A42-8703-73A859A76178"), Name = "Ezekiel 34", ChapterNumber = 34, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel35 = new() { Id = Guid.Parse("A220B12B-1820-410C-86AE-A7F20A90507D"), Name = "Ezekiel 35", ChapterNumber = 35, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel36 = new() { Id = Guid.Parse("194F5285-5E51-4081-A117-EB104BC92731"), Name = "Ezekiel 36", ChapterNumber = 36, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel37 = new() { Id = Guid.Parse("2EE03A74-984F-40C9-9244-E29835BA0884"), Name = "Ezekiel 37", ChapterNumber = 37, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel38 = new() { Id = Guid.Parse("0DE49C14-7978-40F4-925F-D82F36848E2D"), Name = "Ezekiel 38", ChapterNumber = 38, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel39 = new() { Id = Guid.Parse("E9F6EBB2-9D0C-4929-8037-48B039FAECA0"), Name = "Ezekiel 39", ChapterNumber = 39, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel40 = new() { Id = Guid.Parse("548549C3-3E18-4D73-899E-521319A71301"), Name = "Ezekiel 40", ChapterNumber = 40, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel41 = new() { Id = Guid.Parse("22A83E07-18F0-4D0C-9E93-F65CF1B4E84F"), Name = "Ezekiel 41", ChapterNumber = 41, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel42 = new() { Id = Guid.Parse("9D0E8575-3F17-495A-8EAB-CB09D10F70CC"), Name = "Ezekiel 42", ChapterNumber = 42, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel43 = new() { Id = Guid.Parse("CEB1FBFB-D9FE-4C64-8A41-45278096E1D4"), Name = "Ezekiel 43", ChapterNumber = 43, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel44 = new() { Id = Guid.Parse("FBF86430-7A89-4F55-97D2-5CA8081B8BDD"), Name = "Ezekiel 44", ChapterNumber = 44, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel45 = new() { Id = Guid.Parse("5310EAA7-43B7-4F50-BA49-C8B45D23B23F"), Name = "Ezekiel 45", ChapterNumber = 45, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel46 = new() { Id = Guid.Parse("FC7C5380-DB61-4A8A-B551-E24475B79257"), Name = "Ezekiel 46", ChapterNumber = 46, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel47 = new() { Id = Guid.Parse("399A5ED4-02C3-4FDD-B9D4-466A4D426A7E"), Name = "Ezekiel 47", ChapterNumber = 47, BibleBookId = BibleBooks.Ezekiel.Id };
    public static readonly BibleChapter Ezekiel48 = new() { Id = Guid.Parse("0A17E409-F880-46C4-A8B3-AB052294A87F"), Name = "Ezekiel 48", ChapterNumber = 48, BibleBookId = BibleBooks.Ezekiel.Id };
    
    public static readonly BibleChapter Daniel1 = new() { Id = Guid.Parse("ABE72FC3-921B-4FD1-BF1C-016ED582E050"), Name = "Daniel 1", ChapterNumber = 1, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel2 = new() { Id = Guid.Parse("2E9D2060-CA12-42B3-91CB-67AE028157BC"), Name = "Daniel 2", ChapterNumber = 2, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel3 = new() { Id = Guid.Parse("F312B55B-5DB9-4980-9B15-DEFCAA2A89BE"), Name = "Daniel 3", ChapterNumber = 3, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel4 = new() { Id = Guid.Parse("84CCFDCD-3287-469C-89DE-64EE93A724F6"), Name = "Daniel 4", ChapterNumber = 4, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel5 = new() { Id = Guid.Parse("B5761554-E8DF-45F5-B30F-CE6A76406BF3"), Name = "Daniel 5", ChapterNumber = 5, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel6 = new() { Id = Guid.Parse("BA492967-252F-490A-A7FF-19B5DAC5466E"), Name = "Daniel 6", ChapterNumber = 6, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel7 = new() { Id = Guid.Parse("C3BD0E0B-3F3C-4A49-8D22-4B25730169C5"), Name = "Daniel 7", ChapterNumber = 7, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel8 = new() { Id = Guid.Parse("FBD39306-9D12-4ED5-81D2-FCC37B2CBCCF"), Name = "Daniel 8", ChapterNumber = 8, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel9 = new() { Id = Guid.Parse("0906E1BF-6A2C-404C-8CEF-99D600689B2A"), Name = "Daniel 9", ChapterNumber = 9, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel10 = new() { Id = Guid.Parse("5A74B74D-9A20-41D5-84DA-1A5F0F2F5E38"), Name = "Daniel 10", ChapterNumber = 10, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel11 = new() { Id = Guid.Parse("07A752F2-1AA8-4E40-91B0-F432996980F1"), Name = "Daniel 11", ChapterNumber = 11, BibleBookId = BibleBooks.Daniel.Id };
    public static readonly BibleChapter Daniel12 = new() { Id = Guid.Parse("080ABB82-C25C-4CFE-B596-CA4457B4EC9D"), Name = "Daniel 12", ChapterNumber = 12, BibleBookId = BibleBooks.Daniel.Id };
    
    public static readonly BibleChapter Hosea1 = new() { Id = Guid.Parse("C186260F-E9D8-4956-A9B5-FFC9A4FAD6A1"), Name = "Hosea 1", ChapterNumber = 1, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea2 = new() { Id = Guid.Parse("93D3017E-4E1E-4CBF-A93D-11EDAB0B3A21"), Name = "Hosea 2", ChapterNumber = 2, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea3 = new() { Id = Guid.Parse("5A388BB9-761E-4D3D-81B9-E55449099E7D"), Name = "Hosea 3", ChapterNumber = 3, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea4 = new() { Id = Guid.Parse("6FAE3F75-C23B-4536-86B5-ADDB07964847"), Name = "Hosea 4", ChapterNumber = 4, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea5 = new() { Id = Guid.Parse("3B3A7F5D-7926-4B3D-AEEA-73E79D35E369"), Name = "Hosea 5", ChapterNumber = 5, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea6 = new() { Id = Guid.Parse("C1515553-21E3-4502-9CE1-486041CD93E5"), Name = "Hosea 6", ChapterNumber = 6, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea7 = new() { Id = Guid.Parse("45F98E16-6902-4102-9FC8-E2824199E418"), Name = "Hosea 7", ChapterNumber = 7, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea8 = new() { Id = Guid.Parse("175C675F-83E0-4C48-9B7F-C6B8C8695F80"), Name = "Hosea 8", ChapterNumber = 8, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea9 = new() { Id = Guid.Parse("7CF23C4E-34D5-4E6F-A032-4156BBE601D6"), Name = "Hosea 9", ChapterNumber = 9, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea10 = new() { Id = Guid.Parse("E727CCC4-5188-4CBE-95ED-CA669ACD7277"), Name = "Hosea 10", ChapterNumber = 10, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea11 = new() { Id = Guid.Parse("DF03DD59-A107-4262-A1C2-FB9D21269C27"), Name = "Hosea 11", ChapterNumber = 11, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea12 = new() { Id = Guid.Parse("7B7A797D-5D08-43A5-82C0-85F6AD006F5A"), Name = "Hosea 12", ChapterNumber = 12, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea13 = new() { Id = Guid.Parse("9A766E19-6344-4E6F-9364-D6906C4F0E9B"), Name = "Hosea 13", ChapterNumber = 13, BibleBookId = BibleBooks.Hosea.Id };
    public static readonly BibleChapter Hosea14 = new() { Id = Guid.Parse("06949021-7FFD-403C-A421-A941C88B8ABA"), Name = "Hosea 14", ChapterNumber = 14, BibleBookId = BibleBooks.Hosea.Id };
    
    public static readonly BibleChapter Joel1 = new() { Id = Guid.Parse("3D8D0677-6983-4E59-BA49-3257608E4C78"), Name = "Joel 1", ChapterNumber = 1, BibleBookId = BibleBooks.Joel.Id };
    public static readonly BibleChapter Joel2 = new() { Id = Guid.Parse("C2B2F8AF-A922-4F9A-A5C2-09518F52E781"), Name = "Joel 2", ChapterNumber = 2, BibleBookId = BibleBooks.Joel.Id };
    public static readonly BibleChapter Joel3 = new() { Id = Guid.Parse("2A31DF75-2A9B-4D8D-957D-F94E6F9BD5F2"), Name = "Joel 3", ChapterNumber = 3, BibleBookId = BibleBooks.Joel.Id };
    
    public static readonly BibleChapter Amos1 = new() { Id = Guid.Parse("242CB81F-3E06-4644-BB1C-0165344180C2"), Name = "Amos 1", ChapterNumber = 1, BibleBookId = BibleBooks.Amos.Id };
    public static readonly BibleChapter Amos2 = new() { Id = Guid.Parse("9F85465D-6F35-4C0F-BC58-A35FB1309860"), Name = "Amos 2", ChapterNumber = 2, BibleBookId = BibleBooks.Amos.Id };
    public static readonly BibleChapter Amos3 = new() { Id = Guid.Parse("3EEFA97D-F41B-4D54-8DFC-E587423092F4"), Name = "Amos 3", ChapterNumber = 3, BibleBookId = BibleBooks.Amos.Id };
    public static readonly BibleChapter Amos4 = new() { Id = Guid.Parse("CB07115A-5EEA-4F59-B933-67D75B363CCF"), Name = "Amos 4", ChapterNumber = 4, BibleBookId = BibleBooks.Amos.Id };
    public static readonly BibleChapter Amos5 = new() { Id = Guid.Parse("78178525-8769-42F7-A20A-F6A2DEA3A1AF"), Name = "Amos 5", ChapterNumber = 5, BibleBookId = BibleBooks.Amos.Id };
    public static readonly BibleChapter Amos6 = new() { Id = Guid.Parse("F2BC8EA3-E2A7-48D8-9A00-3ED989D23D63"), Name = "Amos 6", ChapterNumber = 6, BibleBookId = BibleBooks.Amos.Id };
    public static readonly BibleChapter Amos7 = new() { Id = Guid.Parse("F03B7421-26D8-4108-A662-3C9E0D30F1B9"), Name = "Amos 7", ChapterNumber = 7, BibleBookId = BibleBooks.Amos.Id };
    public static readonly BibleChapter Amos8 = new() { Id = Guid.Parse("212C220B-858B-4218-9152-83FF17B4B778"), Name = "Amos 8", ChapterNumber = 8, BibleBookId = BibleBooks.Amos.Id };
    public static readonly BibleChapter Amos9 = new() { Id = Guid.Parse("CBBA143D-7318-42D7-BB3C-500C03ABE7EE"), Name = "Amos 9", ChapterNumber = 9, BibleBookId = BibleBooks.Amos.Id };
    
    public static readonly BibleChapter Obadiah1 = new() { Id = Guid.Parse("D549EE6C-C375-45D1-8DD0-11A7279B9BE7"), Name = "Obadiah 1", ChapterNumber = 1, BibleBookId = BibleBooks.Obadiah.Id };
    
    public static readonly BibleChapter Jonah1 = new() { Id = Guid.Parse("E69449FF-439B-4918-B000-91272E55A3D0"), Name = "Jonah 1", ChapterNumber = 1, BibleBookId = BibleBooks.Jonah.Id };
    public static readonly BibleChapter Jonah2 = new() { Id = Guid.Parse("E289DBAE-4E6B-40C3-93F0-8EB810D34A63"), Name = "Jonah 2", ChapterNumber = 2, BibleBookId = BibleBooks.Jonah.Id };
    public static readonly BibleChapter Jonah3 = new() { Id = Guid.Parse("852A7518-EA72-4C7E-8ECD-202EBB1F299F"), Name = "Jonah 3", ChapterNumber = 3, BibleBookId = BibleBooks.Jonah.Id };
    public static readonly BibleChapter Jonah4 = new() { Id = Guid.Parse("1681AAFB-1887-4433-9391-54294294004C"), Name = "Jonah 4", ChapterNumber = 4, BibleBookId = BibleBooks.Jonah.Id };
    
    public static readonly BibleChapter Micah1 = new() { Id = Guid.Parse("C5A36FB2-8C6E-4E0D-B7DF-9E6D41438FAD"), Name = "Micah 1", ChapterNumber = 1, BibleBookId = BibleBooks.Micah.Id };
    public static readonly BibleChapter Micah2 = new() { Id = Guid.Parse("217269E5-2C5D-4678-8B92-FF5853C3BA99"), Name = "Micah 2", ChapterNumber = 2, BibleBookId = BibleBooks.Micah.Id };
    public static readonly BibleChapter Micah3 = new() { Id = Guid.Parse("3A46C5BB-6747-42F9-82F9-C16E84CC2EDE"), Name = "Micah 3", ChapterNumber = 3, BibleBookId = BibleBooks.Micah.Id };
    public static readonly BibleChapter Micah4 = new() { Id = Guid.Parse("CAF05729-AA0F-4534-96AD-02A650B76069"), Name = "Micah 4", ChapterNumber = 4, BibleBookId = BibleBooks.Micah.Id };
    public static readonly BibleChapter Micah5 = new() { Id = Guid.Parse("1C773AB6-C923-4CCC-9E86-0D6C919C733B"), Name = "Micah 5", ChapterNumber = 5, BibleBookId = BibleBooks.Micah.Id };
    public static readonly BibleChapter Micah6 = new() { Id = Guid.Parse("BC08C055-FBFC-4CE2-8BE8-2DF2008A1FC0"), Name = "Micah 6", ChapterNumber = 6, BibleBookId = BibleBooks.Micah.Id };
    public static readonly BibleChapter Micah7 = new() { Id = Guid.Parse("5166F5F0-BAF0-4DCA-89BA-C3265B039EA9"), Name = "Micah 7", ChapterNumber = 7, BibleBookId = BibleBooks.Micah.Id };
    
    public static readonly BibleChapter Nahum1 = new() { Id = Guid.Parse("02C12C01-5D89-472F-BDD4-1CCAE31A2439"), Name = "Nahum 1", ChapterNumber = 1, BibleBookId = BibleBooks.Nahum.Id };
    public static readonly BibleChapter Nahum2 = new() { Id = Guid.Parse("73F883D2-EB8E-4E0A-A8A7-C2180C7A0BC1"), Name = "Nahum 2", ChapterNumber = 2, BibleBookId = BibleBooks.Nahum.Id };
    public static readonly BibleChapter Nahum3 = new() { Id = Guid.Parse("AF7B3A2B-F415-456B-A0F8-47AF8C724F8B"), Name = "Nahum 3", ChapterNumber = 3, BibleBookId = BibleBooks.Nahum.Id };
    
    public static readonly BibleChapter Habakkuk1 = new() { Id = Guid.Parse("93960283-6F0C-4457-9D72-C82C6FAD2326"), Name = "Habakkuk 1", ChapterNumber = 1, BibleBookId = BibleBooks.Habakkuk.Id };
    public static readonly BibleChapter Habakkuk2 = new() { Id = Guid.Parse("F74CFEEF-1C3C-481B-B753-AAA2600D10B7"), Name = "Habakkuk 2", ChapterNumber = 2, BibleBookId = BibleBooks.Habakkuk.Id };
    public static readonly BibleChapter Habakkuk3 = new() { Id = Guid.Parse("12561B4A-777F-4F41-9AE6-13344ED3931B"), Name = "Habakkuk 3", ChapterNumber = 3, BibleBookId = BibleBooks.Habakkuk.Id };
    
    public static readonly BibleChapter Zephaniah1 = new() { Id = Guid.Parse("0A8564F7-7BF7-43AF-8943-921F328F78D9"), Name = "Zephaniah 1", ChapterNumber = 1, BibleBookId = BibleBooks.Zephaniah.Id };
    public static readonly BibleChapter Zephaniah2 = new() { Id = Guid.Parse("EE759B84-FD78-4523-8033-5B5D79EC099C"), Name = "Zephaniah 2", ChapterNumber = 2, BibleBookId = BibleBooks.Zephaniah.Id };
    public static readonly BibleChapter Zephaniah3 = new() { Id = Guid.Parse("9B7AD541-B025-4F88-A925-30C43583C3C2"), Name = "Zephaniah 3", ChapterNumber = 3, BibleBookId = BibleBooks.Zephaniah.Id };
    
    public static readonly BibleChapter Haggai1 = new() { Id = Guid.Parse("FCE88ACD-DC46-4E1A-A6E8-6E774F3BDFAA"), Name = "Haggai 1", ChapterNumber = 1, BibleBookId = BibleBooks.Haggai.Id };
    public static readonly BibleChapter Haggai2 = new() { Id = Guid.Parse("E8478660-8118-48E0-A6BA-012FAA9D42DE"), Name = "Haggai 2", ChapterNumber = 2, BibleBookId = BibleBooks.Haggai.Id };
    
    public static readonly BibleChapter Zechariah1 = new() { Id = Guid.Parse("71234A1B-2C3D-4E5F-8901-23456789ABCD"), Name = "Zechariah 1", ChapterNumber = 1, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah2 = new() { Id = Guid.Parse("81234B1C-3D4E-5F60-9012-3456789ABCDF"), Name = "Zechariah 2", ChapterNumber = 2, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah3 = new() { Id = Guid.Parse("8B2E256C-30B4-4EC5-9810-07C7037E93C9"), Name = "Zechariah 3", ChapterNumber = 3, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah4 = new() { Id = Guid.Parse("AE9DE9BD-5F2F-40E6-94FA-1548487E6D7E"), Name = "Zechariah 4", ChapterNumber = 4, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah5 = new() { Id = Guid.Parse("AE5D660D-9334-498B-AA1B-B57E48134A38"), Name = "Zechariah 5", ChapterNumber = 5, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah6 = new() { Id = Guid.Parse("2A15BA20-818D-4E56-985C-D1B8BA2C20ED"), Name = "Zechariah 6", ChapterNumber = 6, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah7 = new() { Id = Guid.Parse("D61AE86E-D343-402F-A924-9C2265958F9C"), Name = "Zechariah 7", ChapterNumber = 7, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah8 = new() { Id = Guid.Parse("F76D0054-E376-4B4C-A7B2-49400D816BA6"), Name = "Zechariah 8", ChapterNumber = 8, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah9 = new() { Id = Guid.Parse("5B1D2A20-18F9-4A5C-BAE7-41725359B981"), Name = "Zechariah 9", ChapterNumber = 9, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah10 = new() { Id = Guid.Parse("AFC64406-DADF-4F02-A2CA-ECDE1FE04C02"), Name = "Zechariah 10", ChapterNumber = 10, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah11 = new() { Id = Guid.Parse("F4363AE4-E3FC-4944-A751-CEBDEF1BB545"), Name = "Zechariah 11", ChapterNumber = 11, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah12 = new() { Id = Guid.Parse("484DEC74-59AC-4A80-8423-4D11DF4801DD"), Name = "Zechariah 12", ChapterNumber = 12, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah13 = new() { Id = Guid.Parse("67CD99C5-A5A8-4350-AB26-38940A2D7471"), Name = "Zechariah 13", ChapterNumber = 13, BibleBookId = BibleBooks.Zechariah.Id };
    public static readonly BibleChapter Zechariah14 = new() { Id = Guid.Parse("94EFA0F1-7B15-404C-9EF4-BB9D7F166612"), Name = "Zechariah 14", ChapterNumber = 14, BibleBookId = BibleBooks.Zechariah.Id };

    public static readonly BibleChapter Malachi1 = new() { Id = Guid.Parse("3F2404A0-8D50-4FDE-9B2C-8D49E2DB1E68"), Name = "Malachi 1", ChapterNumber = 1, BibleBookId = BibleBooks.Malachi.Id };
    public static readonly BibleChapter Malachi2 = new() { Id = Guid.Parse("F3E4A5B6-C7D8-4E9F-8A1B-2C3D4E5F6A7B"), Name = "Malachi 2", ChapterNumber = 2, BibleBookId = BibleBooks.Malachi.Id };
    public static readonly BibleChapter Malachi3 = new() { Id = Guid.Parse("D4C3B2A1-9E8F-7D6C-5B4A-392817265443"), Name = "Malachi 3", ChapterNumber = 3, BibleBookId = BibleBooks.Malachi.Id };
    public static readonly BibleChapter Malachi4 = new() { Id = Guid.Parse("1A2B3C4D-5E6F-7A8B-9C0D-1E2F3A4B5C6D"), Name = "Malachi 4", ChapterNumber = 4, BibleBookId = BibleBooks.Malachi.Id };
    
    public static readonly BibleChapter Matthew1 = new() { Id = Guid.Parse("2F879342-102F-4FC1-A91F-6B997DAE45AA"), Name = "Matthew 1", ChapterNumber = 1, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew2 = new() { Id = Guid.Parse("465147F1-3367-4ECD-A7E9-743248DB784D"), Name = "Matthew 2", ChapterNumber = 2, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew3 = new() { Id = Guid.Parse("1684F925-62C9-40C5-88E2-C0427416784E"), Name = "Matthew 3", ChapterNumber = 3, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew4 = new() { Id = Guid.Parse("D90E3715-EFB8-408A-BDF5-796CC6A26C7A"), Name = "Matthew 4", ChapterNumber = 4, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew5 = new() { Id = Guid.Parse("AA97A4DE-00EB-4486-8F11-BBFAB659F7F7"), Name = "Matthew 5", ChapterNumber = 5, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew6 = new() { Id = Guid.Parse("321D9B67-F7AE-47FD-88A8-574DDF249277"), Name = "Matthew 6", ChapterNumber = 6, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew7 = new() { Id = Guid.Parse("69A6EF21-1D11-4398-9513-7B9699D22C9A"), Name = "Matthew 7", ChapterNumber = 7, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew8 = new() { Id = Guid.Parse("736F69BE-CEDB-40D2-811F-4200E104ED0C"), Name = "Matthew 8", ChapterNumber = 8, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew9 = new() { Id = Guid.Parse("42751603-CFBC-443A-BF27-608C2D470C98"), Name = "Matthew 9", ChapterNumber = 9, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew10 = new() { Id = Guid.Parse("D320BFB6-6AC8-45A2-A213-8D119342FAC5"), Name = "Matthew 10", ChapterNumber = 10, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew11 = new() { Id = Guid.Parse("A9BC944C-80DD-419E-A4D3-AF4868316FD9"), Name = "Matthew 11", ChapterNumber = 11, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew12 = new() { Id = Guid.Parse("1CE4451B-A7C8-42D5-92EA-F59A01F21F5E"), Name = "Matthew 12", ChapterNumber = 12, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew13 = new() { Id = Guid.Parse("B3EE97B3-423D-4F5F-9F65-D42698E395F9"), Name = "Matthew 13", ChapterNumber = 13, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew14 = new() { Id = Guid.Parse("0D23C63E-C2CE-4706-BEEB-0324BAE1CEE6"), Name = "Matthew 14", ChapterNumber = 14, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew15 = new() { Id = Guid.Parse("A563911A-3BE4-4881-A60D-82A719C61DC8"), Name = "Matthew 15", ChapterNumber = 15, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew16 = new() { Id = Guid.Parse("24BECF41-9ED7-4F92-B974-51BCCAD46062"), Name = "Matthew 16", ChapterNumber = 16, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew17 = new() { Id = Guid.Parse("53491002-712E-41B8-86CA-69C688FBE969"), Name = "Matthew 17", ChapterNumber = 17, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew18 = new() { Id = Guid.Parse("1CB41AD4-B218-48BF-A074-9205CB41F4A4"), Name = "Matthew 18", ChapterNumber = 18, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew19 = new() { Id = Guid.Parse("42C4BB19-9057-450D-84A1-9AF3E30F083B"), Name = "Matthew 19", ChapterNumber = 19, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew20 = new() { Id = Guid.Parse("7AA92ABD-1E35-4AB6-8D82-0916C21F4BB1"), Name = "Matthew 20", ChapterNumber = 20, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew21 = new() { Id = Guid.Parse("179D803B-6E2F-49F3-9334-EE13FC730456"), Name = "Matthew 21", ChapterNumber = 21, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew22 = new() { Id = Guid.Parse("4ED181C1-3B6B-4D6F-99B1-D705C30B1E83"), Name = "Matthew 22", ChapterNumber = 22, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew23 = new() { Id = Guid.Parse("042E5E46-F9AB-44A9-A773-BED13DA8B186"), Name = "Matthew 23", ChapterNumber = 23, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew24 = new() { Id = Guid.Parse("0E465021-7CBD-48BA-A269-3A8E9F3A6674"), Name = "Matthew 24", ChapterNumber = 24, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew25 = new() { Id = Guid.Parse("BD25F801-FF16-404B-B1A0-BEB71F04B01E"), Name = "Matthew 25", ChapterNumber = 25, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew26 = new() { Id = Guid.Parse("CFEAE408-E632-4391-A3F2-7F025F0F5755"), Name = "Matthew 26", ChapterNumber = 26, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew27 = new() { Id = Guid.Parse("C417E4AB-C424-4495-B003-A4CCD3BFA974"), Name = "Matthew 27", ChapterNumber = 27, BibleBookId = BibleBooks.Matthew.Id };
    public static readonly BibleChapter Matthew28 = new() { Id = Guid.Parse("C56B03CB-4AE6-4618-BDFC-3BE182C0FBC5"), Name = "Matthew 28", ChapterNumber = 28, BibleBookId = BibleBooks.Matthew.Id };
    
    public static readonly BibleChapter Mark1 = new() { Id = Guid.Parse("12C39BC3-0724-4EE6-A1D6-9471D0C4E9AF"), Name = "Mark 1", ChapterNumber = 1, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark2 = new() { Id = Guid.Parse("BDFDCC7E-8246-4194-ACC6-C544B4C90405"), Name = "Mark 2", ChapterNumber = 2, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark3 = new() { Id = Guid.Parse("067312A2-3D3E-4A0A-AF8D-797EACB3EFAC"), Name = "Mark 3", ChapterNumber = 3, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark4 = new() { Id = Guid.Parse("F69C534E-16DF-42F1-AABE-B107C83177D7"), Name = "Mark 4", ChapterNumber = 4, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark5 = new() { Id = Guid.Parse("8AC44500-54CB-4F5B-A363-248322F96AC7"), Name = "Mark 5", ChapterNumber = 5, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark6 = new() { Id = Guid.Parse("76638337-BEA4-4822-911E-6EC8100489E0"), Name = "Mark 6", ChapterNumber = 6, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark7 = new() { Id = Guid.Parse("33C55D7C-9FB4-4AD3-B245-2259BED4E2E4"), Name = "Mark 7", ChapterNumber = 7, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark8 = new() { Id = Guid.Parse("F2D43481-605B-4E28-B0FB-B5C83BDBF35B"), Name = "Mark 8", ChapterNumber = 8, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark9 = new() { Id = Guid.Parse("9496D5C3-1F35-4CB2-9D88-5F21E542E5F2"), Name = "Mark 9", ChapterNumber = 9, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark10 = new() { Id = Guid.Parse("B09E0461-CAF7-47BB-839B-E0486DDC8435"), Name = "Mark 10", ChapterNumber = 10, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark11 = new() { Id = Guid.Parse("BE079B16-8F6E-4E94-B8C3-04104A98CE62"), Name = "Mark 11", ChapterNumber = 11, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark12 = new() { Id = Guid.Parse("77FCB8CE-00A0-4513-BAFF-983E16FEECC3"), Name = "Mark 12", ChapterNumber = 12, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark13 = new() { Id = Guid.Parse("AE1EDA46-3AB6-45BC-A439-10C75BB59CC4"), Name = "Mark 13", ChapterNumber = 13, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark14 = new() { Id = Guid.Parse("54E31D45-C205-45C8-A2C6-4045BE3308C8"), Name = "Mark 14", ChapterNumber = 14, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark15 = new() { Id = Guid.Parse("E731ACEF-B4DC-48FC-880E-2B0B607D4A9D"), Name = "Mark 15", ChapterNumber = 15, BibleBookId = BibleBooks.Mark.Id };
    public static readonly BibleChapter Mark16 = new() { Id = Guid.Parse("CD1B493B-3543-4075-872F-D6DEAF0787DF"), Name = "Mark 16", ChapterNumber = 16, BibleBookId = BibleBooks.Mark.Id };
    
    public static readonly BibleChapter Luke1 = new() { Id = Guid.Parse("3F9E5900-8360-4619-9D10-F02F79EFB360"), Name = "Luke 1", ChapterNumber = 1, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke2 = new() { Id = Guid.Parse("5B321394-8D81-4B18-84DC-FD2DB479E56A"), Name = "Luke 2", ChapterNumber = 2, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke3 = new() { Id = Guid.Parse("23725B74-D2CE-47F9-A304-A8B7BCE1E66A"), Name = "Luke 3", ChapterNumber = 3, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke4 = new() { Id = Guid.Parse("F6BD16AB-D409-4CA5-A7C1-2989AA7F8B2F"), Name = "Luke 4", ChapterNumber = 4, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke5 = new() { Id = Guid.Parse("39F57CF9-0961-4A43-9C8D-C37C89FCF470"), Name = "Luke 5", ChapterNumber = 5, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke6 = new() { Id = Guid.Parse("F2E65012-4365-4E3F-8849-0F35C9BA1A7B"), Name = "Luke 6", ChapterNumber = 6, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke7 = new() { Id = Guid.Parse("9D9F69D7-BE1A-485C-8104-7518BB082C80"), Name = "Luke 7", ChapterNumber = 7, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke8 = new() { Id = Guid.Parse("164696BF-CA44-41BD-B1BA-A1B7589823DC"), Name = "Luke 8", ChapterNumber = 8, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke9 = new() { Id = Guid.Parse("2A7C3B90-C66A-465B-B04C-ED840F931B85"), Name = "Luke 9", ChapterNumber = 9, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke10 = new() { Id = Guid.Parse("DE42C62F-3588-4CFD-B896-D3D622CFB266"), Name = "Luke 10", ChapterNumber = 10, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke11 = new() { Id = Guid.Parse("6A108B46-6C55-427D-9498-28B7288714DC"), Name = "Luke 11", ChapterNumber = 11, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke12 = new() { Id = Guid.Parse("42324C6B-AC3F-4201-838A-5B146BFA4CBE"), Name = "Luke 12", ChapterNumber = 12, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke13 = new() { Id = Guid.Parse("BE599C7C-E7B1-4FB7-BCED-B1A6FF4618AE"), Name = "Luke 13", ChapterNumber = 13, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke14 = new() { Id = Guid.Parse("BEA57583-A31D-4C90-8A57-614674421622"), Name = "Luke 14", ChapterNumber = 14, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke15 = new() { Id = Guid.Parse("13041FD1-1A65-4858-B0C4-B1ADAE6A5C57"), Name = "Luke 15", ChapterNumber = 15, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke16 = new() { Id = Guid.Parse("5ADD4C8E-C9E6-4B78-BFB5-F08E17B486B7"), Name = "Luke 16", ChapterNumber = 16, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke17 = new() { Id = Guid.Parse("F942A2E1-387F-4154-B732-867FE098AA7E"), Name = "Luke 17", ChapterNumber = 17, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke18 = new() { Id = Guid.Parse("F4E2B2CE-2094-4423-A95E-F33A925638B1"), Name = "Luke 18", ChapterNumber = 18, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke19 = new() { Id = Guid.Parse("5F096599-97DD-4126-8F06-EBD30952BA49"), Name = "Luke 19", ChapterNumber = 19, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke20 = new() { Id = Guid.Parse("A0A4A443-B143-4702-8A69-1F8602A3D6D1"), Name = "Luke 20", ChapterNumber = 20, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke21 = new() { Id = Guid.Parse("CD82EBB4-3C57-410B-A59B-07F9AC2B5601"), Name = "Luke 21", ChapterNumber = 21, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke22 = new() { Id = Guid.Parse("75F2FFDD-D0AD-450A-BA45-1479DA1CDDA8"), Name = "Luke 22", ChapterNumber = 22, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke23 = new() { Id = Guid.Parse("F8E69C41-EEA4-4392-AF02-BFC4E1600E6B"), Name = "Luke 23", ChapterNumber = 23, BibleBookId = BibleBooks.Luke.Id };
    public static readonly BibleChapter Luke24 = new() { Id = Guid.Parse("F62411E3-6CD0-4421-87E2-A51173337CE3"), Name = "Luke 24", ChapterNumber = 24, BibleBookId = BibleBooks.Luke.Id };

    public static readonly BibleChapter John1 = new() { Id = Guid.Parse("73FA5CF3-5D74-4A69-87D9-D76B5837BE2C"), Name = "John 1", ChapterNumber = 1, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John2 = new() { Id = Guid.Parse("50C1DD6C-21CC-4E00-9780-D4989F6789A2"), Name = "John 2", ChapterNumber = 2, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John3 = new() { Id = Guid.Parse("3AC2EA7E-2392-4272-9A29-15C5E5CC6B10"), Name = "John 3", ChapterNumber = 3, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John4 = new() { Id = Guid.Parse("2646009B-5820-4365-B9A1-D0F4F96C3454"), Name = "John 4", ChapterNumber = 4, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John5 = new() { Id = Guid.Parse("65CE4E58-DEB8-4F84-B9BC-74225B3CC440"), Name = "John 5", ChapterNumber = 5, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John6 = new() { Id = Guid.Parse("D8DF8D60-88D8-49AA-AB10-2E66B18C68CA"), Name = "John 6", ChapterNumber = 6, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John7 = new() { Id = Guid.Parse("BF13EC63-302A-4CB4-B103-EF4CC61DAC63"), Name = "John 7", ChapterNumber = 7, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John8 = new() { Id = Guid.Parse("AE390C97-30FD-41F7-9958-A18B4A515B06"), Name = "John 8", ChapterNumber = 8, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John9 = new() { Id = Guid.Parse("E6035E44-79E8-4E53-9E62-600C57BF3161"), Name = "John 9", ChapterNumber = 9, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John10 = new() { Id = Guid.Parse("6F0FDFDB-1C45-4DF5-8911-7B68BDA6CA40"), Name = "John 10", ChapterNumber = 10, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John11 = new() { Id = Guid.Parse("DF4C88CE-195B-4F3A-BC9A-F77E702FF14A"), Name = "John 11", ChapterNumber = 11, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John12 = new() { Id = Guid.Parse("5C5A8276-E7E7-47E0-9923-70CD2D56E4E8"), Name = "John 12", ChapterNumber = 12, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John13 = new() { Id = Guid.Parse("D03D62C3-F410-40B9-A6ED-DDAF866FA33D"), Name = "John 13", ChapterNumber = 13, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John14 = new() { Id = Guid.Parse("2BCD6C0A-5F9E-4267-A990-96962D72ABAE"), Name = "John 14", ChapterNumber = 14, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John15 = new() { Id = Guid.Parse("1704D531-85B0-4C72-B241-E032148CB3DF"), Name = "John 15", ChapterNumber = 15, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John16 = new() { Id = Guid.Parse("0D73C95E-C004-457D-91A0-0F75DE4F05EA"), Name = "John 16", ChapterNumber = 16, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John17 = new() { Id = Guid.Parse("33386243-24E0-42C1-BBC0-9A9E01C94A10"), Name = "John 17", ChapterNumber = 17, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John18 = new() { Id = Guid.Parse("9E87617D-4906-4E28-8E96-11F5D906EFAC"), Name = "John 18", ChapterNumber = 18, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John19 = new() { Id = Guid.Parse("F24C57BF-0A22-4BB8-8F48-762E240C3A07"), Name = "John 19", ChapterNumber = 19, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John20 = new() { Id = Guid.Parse("92F8F20A-C5F5-425C-842F-F46A539D9B8B"), Name = "John 20", ChapterNumber = 20, BibleBookId = BibleBooks.John.Id };
    public static readonly BibleChapter John21 = new() { Id = Guid.Parse("B8E5705D-76D7-4EA4-9617-56872BF07A7A"), Name = "John 21", ChapterNumber = 21, BibleBookId = BibleBooks.John.Id };

    public static readonly BibleChapter Acts1 = new() { Id = Guid.Parse("D6F547E5-B379-4067-AEC9-227AC1617E1F"), Name = "Acts 1", ChapterNumber = 1, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts2 = new() { Id = Guid.Parse("3FACCBEE-1C82-4A31-8982-689EF24FA7FA"), Name = "Acts 2", ChapterNumber = 2, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts3 = new() { Id = Guid.Parse("E7AE119C-580C-484D-A1DA-FA61273CD81F"), Name = "Acts 3", ChapterNumber = 3, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts4 = new() { Id = Guid.Parse("6D7D47A3-DEAD-48D9-B630-376CAEF05591"), Name = "Acts 4", ChapterNumber = 4, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts5 = new() { Id = Guid.Parse("65C1C934-4E56-4D71-9997-8D1F2C7BB49F"), Name = "Acts 5", ChapterNumber = 5, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts6 = new() { Id = Guid.Parse("E56C09BB-7D93-422E-BE5A-581D8F7A2229"), Name = "Acts 6", ChapterNumber = 6, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts7 = new() { Id = Guid.Parse("DF2271BD-B3BF-499C-89D4-4A2A70086BB5"), Name = "Acts 7", ChapterNumber = 7, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts8 = new() { Id = Guid.Parse("C8E86681-081B-46FB-A4D6-23DB355FB00F"), Name = "Acts 8", ChapterNumber = 8, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts9 = new() { Id = Guid.Parse("2365E518-D602-480B-BD2E-ED610E5B8C49"), Name = "Acts 9", ChapterNumber = 9, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts10 = new() { Id = Guid.Parse("E0AD1B7A-8444-4941-9DBA-10FDBA31093E"), Name = "Acts 10", ChapterNumber = 10, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts11 = new() { Id = Guid.Parse("E8CED802-AAC0-4EF3-99F6-7266EB402F40"), Name = "Acts 11", ChapterNumber = 11, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts12 = new() { Id = Guid.Parse("F39E0A66-71C0-4402-B6BE-A6B63EA48750"), Name = "Acts 12", ChapterNumber = 12, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts13 = new() { Id = Guid.Parse("FDDE8AB5-859E-455B-8DBE-2D1A1D279855"), Name = "Acts 13", ChapterNumber = 13, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts14 = new() { Id = Guid.Parse("6F87087B-6CF2-4A84-8C4C-CF1EDFAF1FA3"), Name = "Acts 14", ChapterNumber = 14, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts15 = new() { Id = Guid.Parse("41F8B172-5EFD-42A8-AF18-55181DBDF5BE"), Name = "Acts 15", ChapterNumber = 15, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts16 = new() { Id = Guid.Parse("EC75F195-4736-4E0D-8409-EE1F4065E4C6"), Name = "Acts 16", ChapterNumber = 16, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts17 = new() { Id = Guid.Parse("49576916-7CBA-49A6-AB70-B5E835DE0A11"), Name = "Acts 17", ChapterNumber = 17, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts18 = new() { Id = Guid.Parse("8E2626EB-9BB7-4364-9710-34199EA3DBD9"), Name = "Acts 18", ChapterNumber = 18, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts19 = new() { Id = Guid.Parse("951EA133-5A73-4F04-A7D0-45A095407F4F"), Name = "Acts 19", ChapterNumber = 19, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts20 = new() { Id = Guid.Parse("FE7646D2-495E-4E64-82A8-348E2341774A"), Name = "Acts 20", ChapterNumber = 20, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts21 = new() { Id = Guid.Parse("58843720-1CF3-4EC3-BB8C-C198D50E7FBA"), Name = "Acts 21", ChapterNumber = 21, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts22 = new() { Id = Guid.Parse("63C579E5-8894-44D1-B7E8-B49DD7B7004F"), Name = "Acts 22", ChapterNumber = 22, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts23 = new() { Id = Guid.Parse("74FE525E-7FA1-46A7-9462-42C627081985"), Name = "Acts 23", ChapterNumber = 23, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts24 = new() { Id = Guid.Parse("FB9B88EA-CE20-4C11-8394-910BB5C91ED0"), Name = "Acts 24", ChapterNumber = 24, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts25 = new() { Id = Guid.Parse("BC5615F1-EEC0-4F55-B6CC-72B1C35FF126"), Name = "Acts 25", ChapterNumber = 25, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts26 = new() { Id = Guid.Parse("FAD79CC4-4505-4D2E-8713-4D457B4ADDE1"), Name = "Acts 26", ChapterNumber = 26, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts27 = new() { Id = Guid.Parse("CE632DF7-A21C-4D53-97B9-4964525C7476"), Name = "Acts 27", ChapterNumber = 27, BibleBookId = BibleBooks.Acts.Id };
    public static readonly BibleChapter Acts28 = new() { Id = Guid.Parse("6D62758F-B73E-4145-A91F-C99ED716D927"), Name = "Acts 28", ChapterNumber = 28, BibleBookId = BibleBooks.Acts.Id };
    
    public static readonly BibleChapter Romans1 = new() { Id = Guid.Parse("E4786415-B6DA-4C97-9475-6BDAE2CF4B57"), Name = "Romans 1", ChapterNumber = 1, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans2 = new() { Id = Guid.Parse("FA373CEC-2489-44C2-86B1-59B8136CC35B"), Name = "Romans 2", ChapterNumber = 2, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans3 = new() { Id = Guid.Parse("7710A473-5D7C-4C04-A6FF-8948F300CBB3"), Name = "Romans 3", ChapterNumber = 3, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans4 = new() { Id = Guid.Parse("1CCF8F0A-630B-4614-B98C-FC43F3F36823"), Name = "Romans 4", ChapterNumber = 4, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans5 = new() { Id = Guid.Parse("6DACEC9F-41FE-4675-B767-AACA288798B9"), Name = "Romans 5", ChapterNumber = 5, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans6 = new() { Id = Guid.Parse("90E23557-5B7D-45D9-A6C8-1A4C3BF987FD"), Name = "Romans 6", ChapterNumber = 6, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans7 = new() { Id = Guid.Parse("E388A359-CFDB-43E4-B44C-B0632E27510E"), Name = "Romans 7", ChapterNumber = 7, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans8 = new() { Id = Guid.Parse("7AC02F4D-8BF5-414D-8B00-D3FD01FC4CA7"), Name = "Romans 8", ChapterNumber = 8, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans9 = new() { Id = Guid.Parse("2D50777B-08A7-466F-8CC8-977DE627A853"), Name = "Romans 9", ChapterNumber = 9, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans10 = new() { Id = Guid.Parse("A6DEEBD3-E7CF-49C1-BEF6-153AB446FF3C"), Name = "Romans 10", ChapterNumber = 10, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans11 = new() { Id = Guid.Parse("5CD73138-4155-4675-9D8C-0F396C19515A"), Name = "Romans 11", ChapterNumber = 11, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans12 = new() { Id = Guid.Parse("97202CB7-F6E9-4FA2-BA38-717DC622710D"), Name = "Romans 12", ChapterNumber = 12, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans13 = new() { Id = Guid.Parse("66A71AB6-A663-4EA7-98D2-027BAAAA60DF"), Name = "Romans 13", ChapterNumber = 13, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans14 = new() { Id = Guid.Parse("C56464F7-896F-4785-8ACC-5F8F8A841A51"), Name = "Romans 14", ChapterNumber = 14, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans15 = new() { Id = Guid.Parse("5BC3063A-F6D2-42DE-8A35-E95F5B227F3A"), Name = "Romans 15", ChapterNumber = 15, BibleBookId = BibleBooks.Romans.Id };
    public static readonly BibleChapter Romans16 = new() { Id = Guid.Parse("CE13EA4B-8652-46F6-8154-FECD8B5A0CD1"), Name = "Romans 16", ChapterNumber = 16, BibleBookId = BibleBooks.Romans.Id };
    
    public static readonly BibleChapter FirstCorinthians1 = new() { Id = Guid.Parse("D80BF7A5-E8A5-460D-A9B5-196BE34119F0"), Name = "1 Corinthians 1", ChapterNumber = 1, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians2 = new() { Id = Guid.Parse("10757347-F25E-4BC2-92E1-A2D09BA06448"), Name = "1 Corinthians 2", ChapterNumber = 2, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians3 = new() { Id = Guid.Parse("BA571590-B63B-47CC-814A-F3A660654138"), Name = "1 Corinthians 3", ChapterNumber = 3, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians4 = new() { Id = Guid.Parse("D43C8E37-70A8-4578-B1EE-A7904B5B4FDE"), Name = "1 Corinthians 4", ChapterNumber = 4, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians5 = new() { Id = Guid.Parse("9242F687-4563-48C3-86F9-B962F9389251"), Name = "1 Corinthians 5", ChapterNumber = 5, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians6 = new() { Id = Guid.Parse("24FFD619-5AFA-4D1A-8191-21B374699CA6"), Name = "1 Corinthians 6", ChapterNumber = 6, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians7 = new() { Id = Guid.Parse("AB8EC548-AAF4-4A9F-A7CF-3E5BE981C0B4"), Name = "1 Corinthians 7", ChapterNumber = 7, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians8 = new() { Id = Guid.Parse("CDAF4B2B-8944-48CF-969B-4921D5BFD336"), Name = "1 Corinthians 8", ChapterNumber = 8, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians9 = new() { Id = Guid.Parse("F2EA0E88-7F64-40C6-9688-AB27165E4C8A"), Name = "1 Corinthians 9", ChapterNumber = 9, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians10 = new() { Id = Guid.Parse("10C571E7-D06B-4919-86DC-3331C41F97E0"), Name = "1 Corinthians 10", ChapterNumber = 10, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians11 = new() { Id = Guid.Parse("DA03F182-2A65-4E1E-B83F-E3D8D4ADA581"), Name = "1 Corinthians 11", ChapterNumber = 11, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians12 = new() { Id = Guid.Parse("FE1F1EE6-E453-472B-8E6B-F03A861E0548"), Name = "1 Corinthians 12", ChapterNumber = 12, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians13 = new() { Id = Guid.Parse("034B4D47-A7C7-49F9-8F25-FBB6C52A3ED9"), Name = "1 Corinthians 13", ChapterNumber = 13, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians14 = new() { Id = Guid.Parse("A3B52573-B860-4018-AEAD-3F7567853000"), Name = "1 Corinthians 14", ChapterNumber = 14, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians15 = new() { Id = Guid.Parse("2D50B6AD-E865-407C-B5AB-30DE304544C3"), Name = "1 Corinthians 15", ChapterNumber = 15, BibleBookId = BibleBooks.FirstCorinthians.Id };
    public static readonly BibleChapter FirstCorinthians16 = new() { Id = Guid.Parse("BC8E0ED7-A52C-48F6-88A7-FAEEFC83A195"), Name = "1 Corinthians 16", ChapterNumber = 16, BibleBookId = BibleBooks.FirstCorinthians.Id };
    
    public static readonly BibleChapter SecondCorinthians1 = new() { Id = Guid.Parse("E265F9EE-2481-47DA-B484-51D93527397C"), Name = "2 Corinthians 1", ChapterNumber = 1, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians2 = new() { Id = Guid.Parse("8CE46CE3-F382-4FAC-815B-A92893F1FC6D"), Name = "2 Corinthians 2", ChapterNumber = 2, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians3 = new() { Id = Guid.Parse("5E9ECA33-3D28-4E63-A917-DB7AF6646E98"), Name = "2 Corinthians 3", ChapterNumber = 3, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians4 = new() { Id = Guid.Parse("5FB2B994-FBA0-417D-BBB1-76D089AD65CC"), Name = "2 Corinthians 4", ChapterNumber = 4, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians5 = new() { Id = Guid.Parse("DE42C3EF-A5A7-4CF1-BAC6-4B1D2557D2AF"), Name = "2 Corinthians 5", ChapterNumber = 5, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians6 = new() { Id = Guid.Parse("3FC75BB4-5808-4711-A252-701131E16A72"), Name = "2 Corinthians 6", ChapterNumber = 6, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians7 = new() { Id = Guid.Parse("B3E8A969-6EEC-42C9-8900-5BB2AD708FC1"), Name = "2 Corinthians 7", ChapterNumber = 7, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians8 = new() { Id = Guid.Parse("D1094567-F050-48E3-B5E0-AD58048CEDA7"), Name = "2 Corinthians 8", ChapterNumber = 8, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians9 = new() { Id = Guid.Parse("D4061861-0B4F-4EB2-A323-2DC6766F7CDC"), Name = "2 Corinthians 9", ChapterNumber = 9, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians10 = new() { Id = Guid.Parse("4649216E-CBF0-47D2-9BFA-F5CB5EA791AE"), Name = "2 Corinthians 10", ChapterNumber = 10, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians11 = new() { Id = Guid.Parse("3C70D052-C27E-4096-8083-987D9A649077"), Name = "2 Corinthians 11", ChapterNumber = 11, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians12 = new() { Id = Guid.Parse("F4760262-C8FD-4B69-8949-0BBE1719BF4E"), Name = "2 Corinthians 12", ChapterNumber = 12, BibleBookId = BibleBooks.SecondCorinthians.Id };
    public static readonly BibleChapter SecondCorinthians13 = new() { Id = Guid.Parse("AD2A8B6D-FB43-4980-9725-5DFDD1F34E85"), Name = "2 Corinthians 13", ChapterNumber = 13, BibleBookId = BibleBooks.SecondCorinthians.Id };
    
    public static readonly BibleChapter Galatians1 = new() { Id = Guid.Parse("DCA2F563-EFDD-448F-948C-5405D188FC00"), Name = "Galatians 1", ChapterNumber = 1, BibleBookId = BibleBooks.Galatians.Id };
    public static readonly BibleChapter Galatians2 = new() { Id = Guid.Parse("1DFAEC87-FD3C-462D-80D7-A06FCC889298"), Name = "Galatians 2", ChapterNumber = 2, BibleBookId = BibleBooks.Galatians.Id };
    public static readonly BibleChapter Galatians3 = new() { Id = Guid.Parse("50121F1F-F5BB-46EE-B379-410707D5D5BA"), Name = "Galatians 3", ChapterNumber = 3, BibleBookId = BibleBooks.Galatians.Id };
    public static readonly BibleChapter Galatians4 = new() { Id = Guid.Parse("55F9AC04-1010-450A-AE54-19CDBB3218B3"), Name = "Galatians 4", ChapterNumber = 4, BibleBookId = BibleBooks.Galatians.Id };
    public static readonly BibleChapter Galatians5 = new() { Id = Guid.Parse("C1A435DA-D84D-4C6A-9CAA-62499472613B"), Name = "Galatians 5", ChapterNumber = 5, BibleBookId = BibleBooks.Galatians.Id };
    public static readonly BibleChapter Galatians6 = new() { Id = Guid.Parse("5BB5790C-F89B-49A5-804A-E5C79B37D22A"), Name = "Galatians 6", ChapterNumber = 6, BibleBookId = BibleBooks.Galatians.Id };
    
    public static readonly BibleChapter Ephesians1 = new() { Id = Guid.Parse("1A6D67A8-195C-4598-B706-ABD68655EF6C"), Name = "Ephesians 1", ChapterNumber = 1, BibleBookId = BibleBooks.Ephesians.Id };
    public static readonly BibleChapter Ephesians2 = new() { Id = Guid.Parse("4192CCBF-9AE8-4EEE-9DF6-A656D3EB3AE4"), Name = "Ephesians 2", ChapterNumber = 2, BibleBookId = BibleBooks.Ephesians.Id };
    public static readonly BibleChapter Ephesians3 = new() { Id = Guid.Parse("96B0CC2F-E5B6-47A7-95CA-4649FBA8F308"), Name = "Ephesians 3", ChapterNumber = 3, BibleBookId = BibleBooks.Ephesians.Id };
    public static readonly BibleChapter Ephesians4 = new() { Id = Guid.Parse("7C69DBF1-1D14-42C2-9968-3E4881B0607E"), Name = "Ephesians 4", ChapterNumber = 4, BibleBookId = BibleBooks.Ephesians.Id };
    public static readonly BibleChapter Ephesians5 = new() { Id = Guid.Parse("43BC6343-C428-4398-9F36-8F4F81637082"), Name = "Ephesians 5", ChapterNumber = 5, BibleBookId = BibleBooks.Ephesians.Id };
    public static readonly BibleChapter Ephesians6 = new() { Id = Guid.Parse("165529B0-BD95-44EF-998C-775393B07CFB"), Name = "Ephesians 6", ChapterNumber = 6, BibleBookId = BibleBooks.Ephesians.Id };
    
    public static readonly BibleChapter Philippians1 = new() { Id = Guid.Parse("AF52D2AE-644C-4F2A-BAC1-FEBC3C446684"), Name = "Philippians 1", ChapterNumber = 1, BibleBookId = BibleBooks.Philippians.Id };
    public static readonly BibleChapter Philippians2 = new() { Id = Guid.Parse("C3A313E2-5916-4912-995E-5A752A733B09"), Name = "Philippians 2", ChapterNumber = 2, BibleBookId = BibleBooks.Philippians.Id };
    public static readonly BibleChapter Philippians3 = new() { Id = Guid.Parse("A17D21C5-E29A-41EB-B65D-5E4D9C28E864"), Name = "Philippians 3", ChapterNumber = 3, BibleBookId = BibleBooks.Philippians.Id };
    public static readonly BibleChapter Philippians4 = new() { Id = Guid.Parse("73C389E7-E303-46C1-A099-DC1131016CAB"), Name = "Philippians 4", ChapterNumber = 4, BibleBookId = BibleBooks.Philippians.Id };
    
    public static readonly BibleChapter Colossians1 = new() { Id = Guid.Parse("3EBB212E-B9AA-4116-A53F-B114E1532AE2"), Name = "Colossians 1", ChapterNumber = 1, BibleBookId = BibleBooks.Colossians.Id };
    public static readonly BibleChapter Colossians2 = new() { Id = Guid.Parse("8885202C-FB84-42CF-965E-203077325096"), Name = "Colossians 2", ChapterNumber = 2, BibleBookId = BibleBooks.Colossians.Id };
    public static readonly BibleChapter Colossians3 = new() { Id = Guid.Parse("DBE149DF-3A44-4244-9AB3-3535B36F1A97"), Name = "Colossians 3", ChapterNumber = 3, BibleBookId = BibleBooks.Colossians.Id };
    public static readonly BibleChapter Colossians4 = new() { Id = Guid.Parse("3B168A2F-C254-40C4-AFD5-A08FE6B3B5E5"), Name = "Colossians 4", ChapterNumber = 4, BibleBookId = BibleBooks.Colossians.Id };
    
    public static readonly BibleChapter FirstThessalonians1 = new() { Id = Guid.Parse("67AED3E4-9FB4-4585-9DDA-FC931C530246"), Name = "1 Thessalonians 1", ChapterNumber = 1, BibleBookId = BibleBooks.FirstThessalonians.Id };
    public static readonly BibleChapter FirstThessalonians2 = new() { Id = Guid.Parse("DFA5871C-0FC0-4152-B494-24A42CB8D620"), Name = "1 Thessalonians 2", ChapterNumber = 2, BibleBookId = BibleBooks.FirstThessalonians.Id };
    public static readonly BibleChapter FirstThessalonians3 = new() { Id = Guid.Parse("A1A1103D-C76B-40B2-ADA3-51D240CF02A9"), Name = "1 Thessalonians 3", ChapterNumber = 3, BibleBookId = BibleBooks.FirstThessalonians.Id };
    public static readonly BibleChapter FirstThessalonians4 = new() { Id = Guid.Parse("7AB035CD-9F9D-4348-B1D1-161B3A893F8B"), Name = "1 Thessalonians 4", ChapterNumber = 4, BibleBookId = BibleBooks.FirstThessalonians.Id };
    public static readonly BibleChapter FirstThessalonians5 = new() { Id = Guid.Parse("8147023B-7328-4BE9-9CB1-59D6926229E7"), Name = "1 Thessalonians 5", ChapterNumber = 5, BibleBookId = BibleBooks.FirstThessalonians.Id };
    
    public static readonly BibleChapter SecondThessalonians1 = new() { Id = Guid.Parse("90F5C977-0928-43EE-BE11-290128BE4B09"), Name = "2 Thessalonians 1", ChapterNumber = 1, BibleBookId = BibleBooks.SecondThessalonians.Id };
    public static readonly BibleChapter SecondThessalonians2 = new() { Id = Guid.Parse("1FE27504-1D91-481C-9273-AF465B10B619"), Name = "2 Thessalonians 2", ChapterNumber = 2, BibleBookId = BibleBooks.SecondThessalonians.Id };
    public static readonly BibleChapter SecondThessalonians3 = new() { Id = Guid.Parse("7332D3E7-B61D-4FC6-910D-BD9C7C066146"), Name = "2 Thessalonians 3", ChapterNumber = 3, BibleBookId = BibleBooks.SecondThessalonians.Id };
    
    public static readonly BibleChapter FirstTimothy1 = new() { Id = Guid.Parse("E90639D3-4969-488A-82C2-59E36B670554"), Name = "1 Timothy 1", ChapterNumber = 1, BibleBookId = BibleBooks.FirstTimothy.Id };
    public static readonly BibleChapter FirstTimothy2 = new() { Id = Guid.Parse("52357907-9684-4AE3-A8B5-E7C25C79A736"), Name = "1 Timothy 2", ChapterNumber = 2, BibleBookId = BibleBooks.FirstTimothy.Id };
    public static readonly BibleChapter FirstTimothy3 = new() { Id = Guid.Parse("B1AF725A-9320-4D36-A5B0-8CBA95F9CE1C"), Name = "1 Timothy 3", ChapterNumber = 3, BibleBookId = BibleBooks.FirstTimothy.Id };
    public static readonly BibleChapter FirstTimothy4 = new() { Id = Guid.Parse("4F3A4F46-8B12-4319-B3B2-1C6371F49AF1"), Name = "1 Timothy 4", ChapterNumber = 4, BibleBookId = BibleBooks.FirstTimothy.Id };
    public static readonly BibleChapter FirstTimothy5 = new() { Id = Guid.Parse("C1558635-7861-4639-8213-43F2AFCEDFDB"), Name = "1 Timothy 5", ChapterNumber = 5, BibleBookId = BibleBooks.FirstTimothy.Id };
    public static readonly BibleChapter FirstTimothy6 = new() { Id = Guid.Parse("5447FFE6-15D6-467F-B219-83EB6CFA2A43"), Name = "1 Timothy 6", ChapterNumber = 6, BibleBookId = BibleBooks.FirstTimothy.Id };
    
    public static readonly BibleChapter SecondTimothy1 = new() { Id = Guid.Parse("EB9C2809-8A8D-4986-91D6-9E41F8D6C037"), Name = "2 Timothy 1", ChapterNumber = 1, BibleBookId = BibleBooks.SecondTimothy.Id };
    public static readonly BibleChapter SecondTimothy2 = new() { Id = Guid.Parse("4CA71710-22B7-47AA-8111-E7954D415594"), Name = "2 Timothy 2", ChapterNumber = 2, BibleBookId = BibleBooks.SecondTimothy.Id };
    public static readonly BibleChapter SecondTimothy3 = new() { Id = Guid.Parse("4CC3B138-ADB6-4A04-AB11-B257AC33F163"), Name = "2 Timothy 3", ChapterNumber = 3, BibleBookId = BibleBooks.SecondTimothy.Id };
    public static readonly BibleChapter SecondTimothy4 = new() { Id = Guid.Parse("023538BA-E279-4B97-BE48-42617AA53AE0"), Name = "2 Timothy 4", ChapterNumber = 4, BibleBookId = BibleBooks.SecondTimothy.Id };
    
    public static readonly BibleChapter Titus1 = new() { Id = Guid.Parse("54B2C107-F3E3-4F77-9225-7776519253B4"), Name = "Titus 1", ChapterNumber = 1, BibleBookId = BibleBooks.Titus.Id };
    public static readonly BibleChapter Titus2 = new() { Id = Guid.Parse("1E2ED13D-55F0-4A33-868E-387D9B14C282"), Name = "Titus 2", ChapterNumber = 2, BibleBookId = BibleBooks.Titus.Id };
    public static readonly BibleChapter Titus3 = new() { Id = Guid.Parse("E450CB32-3536-4259-8F73-F2905D59E13D"), Name = "Titus 3", ChapterNumber = 3, BibleBookId = BibleBooks.Titus.Id };
    
    public static readonly BibleChapter Philemon1 = new() { Id = Guid.Parse("28AC627C-42EC-4FAB-84B9-FC0195F35F64"), Name = "Philemon 1", ChapterNumber = 1, BibleBookId = BibleBooks.Philemon.Id };
    
    public static readonly BibleChapter Hebrews1 = new() { Id = Guid.Parse("BE510037-8883-41C3-85F0-BD7CFEED6D5A"), Name = "Hebrews 1", ChapterNumber = 1, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews2 = new() { Id = Guid.Parse("55FEA07A-50CF-4EC1-A9F7-1D3FF8E50182"), Name = "Hebrews 2", ChapterNumber = 2, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews3 = new() { Id = Guid.Parse("E7562032-3989-4EDC-8448-95C50A12FE6D"), Name = "Hebrews 3", ChapterNumber = 3, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews4 = new() { Id = Guid.Parse("6F7BABAC-8673-4054-AA8C-AACB7CD134F8"), Name = "Hebrews 4", ChapterNumber = 4, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews5 = new() { Id = Guid.Parse("95BD74EE-C6BF-45AF-B5DD-4C2858D56E5A"), Name = "Hebrews 5", ChapterNumber = 5, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews6 = new() { Id = Guid.Parse("AC74B07F-23B9-49AE-A13C-BCF638901105"), Name = "Hebrews 6", ChapterNumber = 6, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews7 = new() { Id = Guid.Parse("61DF52EC-CB32-4469-9ED0-011AB57D6A99"), Name = "Hebrews 7", ChapterNumber = 7, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews8 = new() { Id = Guid.Parse("C8E8E819-6703-47E1-ACC4-E4BC43AD0689"), Name = "Hebrews 8", ChapterNumber = 8, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews9 = new() { Id = Guid.Parse("4FDBBAB9-B390-4DE5-95AC-C5F76506A05B"), Name = "Hebrews 9", ChapterNumber = 9, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews10 = new() { Id = Guid.Parse("9120CAFC-4A4D-4CBF-A263-0AB09B1D08AD"), Name = "Hebrews 10", ChapterNumber = 10, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews11 = new() { Id = Guid.Parse("36A49ABB-AF98-4AEA-9861-659D64A121D8"), Name = "Hebrews 11", ChapterNumber = 11, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews12 = new() { Id = Guid.Parse("6A94D037-7F48-4446-8E55-3324C99CFE26"), Name = "Hebrews 12", ChapterNumber = 12, BibleBookId = BibleBooks.Hebrews.Id };
    public static readonly BibleChapter Hebrews13 = new() { Id = Guid.Parse("404BE62F-30C0-4AF6-A5D8-240B3A6BE85C"), Name = "Hebrews 13", ChapterNumber = 13, BibleBookId = BibleBooks.Hebrews.Id };
    
    public static readonly BibleChapter James1 = new() { Id = Guid.Parse("D08F1F0A-7B96-413B-8F46-061D50AEE255"), Name = "James 1", ChapterNumber = 1, BibleBookId = BibleBooks.James.Id };
    public static readonly BibleChapter James2 = new() { Id = Guid.Parse("23C2557C-BD1A-4004-9063-39024F5E5A4E"), Name = "James 2", ChapterNumber = 2, BibleBookId = BibleBooks.James.Id };
    public static readonly BibleChapter James3 = new() { Id = Guid.Parse("573E7417-9293-4183-AEB9-1390A5A78970"), Name = "James 3", ChapterNumber = 3, BibleBookId = BibleBooks.James.Id };
    public static readonly BibleChapter James4 = new() { Id = Guid.Parse("A0245971-42E6-4D44-B0FA-2CD7BE8C0E00"), Name = "James 4", ChapterNumber = 4, BibleBookId = BibleBooks.James.Id };
    public static readonly BibleChapter James5 = new() { Id = Guid.Parse("6D24C3D9-BD98-48FB-8462-1A984C149FB6"), Name = "James 5", ChapterNumber = 5, BibleBookId = BibleBooks.James.Id };
    
    public static readonly BibleChapter FirstPeter1 = new() { Id = Guid.Parse("2BB00C8C-849D-4E40-A89C-D84A30BD0AE9"), Name = "1 Peter 1", ChapterNumber = 1, BibleBookId = BibleBooks.FirstPeter.Id };
    public static readonly BibleChapter FirstPeter2 = new() { Id = Guid.Parse("187292AF-3BE8-47E7-AB56-59465E845DA5"), Name = "1 Peter 2", ChapterNumber = 2, BibleBookId = BibleBooks.FirstPeter.Id };
    public static readonly BibleChapter FirstPeter3 = new() { Id = Guid.Parse("8CF4D376-DFB5-416B-97D0-18669B16E6D8"), Name = "1 Peter 3", ChapterNumber = 3, BibleBookId = BibleBooks.FirstPeter.Id };
    public static readonly BibleChapter FirstPeter4 = new() { Id = Guid.Parse("5C8E185B-68BB-4C08-9AD8-28F9CAC98FA7"), Name = "1 Peter 4", ChapterNumber = 4, BibleBookId = BibleBooks.FirstPeter.Id };
    public static readonly BibleChapter FirstPeter5 = new() { Id = Guid.Parse("755D762D-4718-46B4-9DD6-6D8576985C02"), Name = "1 Peter 5", ChapterNumber = 5, BibleBookId = BibleBooks.FirstPeter.Id };
    
    public static readonly BibleChapter SecondPeter1 = new() { Id = Guid.Parse("CC56DF0A-92A7-48BA-BE0E-68ABADE528E8"), Name = "2 Peter 1", ChapterNumber = 1, BibleBookId = BibleBooks.SecondPeter.Id };
    public static readonly BibleChapter SecondPeter2 = new() { Id = Guid.Parse("2A20BD25-D25F-44A4-A3FE-409EBE2E65E5"), Name = "2 Peter 2", ChapterNumber = 2, BibleBookId = BibleBooks.SecondPeter.Id };
    public static readonly BibleChapter SecondPeter3 = new() { Id = Guid.Parse("0D663C8C-0C2C-4387-91C5-6CB3F74E7B50"), Name = "2 Peter 3", ChapterNumber = 3, BibleBookId = BibleBooks.SecondPeter.Id };
    
    public static readonly BibleChapter FirstJohn1 = new() { Id = Guid.Parse("833CE0AB-2902-431B-AD23-0E1700EC6499"), Name = "1 John 1", ChapterNumber = 1, BibleBookId = BibleBooks.FirstJohn.Id };
    public static readonly BibleChapter FirstJohn2 = new() { Id = Guid.Parse("B9E17F51-49F2-4DB8-A850-67A5BE7FFCAE"), Name = "1 John 2", ChapterNumber = 2, BibleBookId = BibleBooks.FirstJohn.Id };
    public static readonly BibleChapter FirstJohn3 = new() { Id = Guid.Parse("747F2E6A-6A1E-43F6-9470-8E145C741AC1"), Name = "1 John 3", ChapterNumber = 3, BibleBookId = BibleBooks.FirstJohn.Id };
    public static readonly BibleChapter FirstJohn4 = new() { Id = Guid.Parse("D009A0AB-E683-4EFF-8ECE-35478B9D406D"), Name = "1 John 4", ChapterNumber = 4, BibleBookId = BibleBooks.FirstJohn.Id };
    public static readonly BibleChapter FirstJohn5 = new() { Id = Guid.Parse("8E638F38-CE2C-4A95-926B-F60FCABD0013"), Name = "1 John 5", ChapterNumber = 5, BibleBookId = BibleBooks.FirstJohn.Id };
    
    public static readonly BibleChapter SecondJohn1 = new() { Id = Guid.Parse("6B550918-BF0B-435D-826F-0094F915F104"), Name = "2 John 1", ChapterNumber = 1, BibleBookId = BibleBooks.SecondJohn.Id };
    
    public static readonly BibleChapter ThirdJohn1 = new() { Id = Guid.Parse("47858910-D720-4229-9A7C-F74FE543581E"), Name = "3 John 1", ChapterNumber = 1, BibleBookId = BibleBooks.ThirdJohn.Id };
    
    public static readonly BibleChapter Jude1 = new() { Id = Guid.Parse("84BD60A6-76DC-4F0D-AEDC-C5D72877F4F3"), Name = "Jude 1", ChapterNumber = 1, BibleBookId = BibleBooks.Jude.Id };
    
    public static readonly BibleChapter Revelation1 = new() { Id = Guid.Parse("0FF2F49A-2A74-4F70-B037-70A78D0A28AE"), Name = "Revelation 1", ChapterNumber = 1, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation2 = new() { Id = Guid.Parse("E341AE30-89E4-42A0-BC28-50C30A8AB9B1"), Name = "Revelation 2", ChapterNumber = 2, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation3 = new() { Id = Guid.Parse("89BD3B07-AC1E-4B30-A30B-7829BCC395D7"), Name = "Revelation 3", ChapterNumber = 3, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation4 = new() { Id = Guid.Parse("8342709F-3A29-485A-9DC5-E55D5876C958"), Name = "Revelation 4", ChapterNumber = 4, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation5 = new() { Id = Guid.Parse("2B1D58DA-5ADA-47D4-B63C-02AEC96D0EE8"), Name = "Revelation 5", ChapterNumber = 5, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation6 = new() { Id = Guid.Parse("85374EA3-FD4F-4AED-B6FC-D0B10D58C2E4"), Name = "Revelation 6", ChapterNumber = 6, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation7 = new() { Id = Guid.Parse("39B7EFEC-8EAA-49B2-B3C5-78E95EAE278A"), Name = "Revelation 7", ChapterNumber = 7, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation8 = new() { Id = Guid.Parse("7EEEBAAB-5D5B-4299-AAE0-0D588CE3E0E4"), Name = "Revelation 8", ChapterNumber = 8, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation9 = new() { Id = Guid.Parse("E0EC579A-DB7D-4B7F-87D1-34CC9D1B471F"), Name = "Revelation 9", ChapterNumber = 9, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation10 = new() { Id = Guid.Parse("BC356A52-19F6-45C1-A68D-62E57995F764"), Name = "Revelation 10", ChapterNumber = 10, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation11 = new() { Id = Guid.Parse("094104CF-BDCD-4B9C-B447-5429CBB70670"), Name = "Revelation 11", ChapterNumber = 11, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation12 = new() { Id = Guid.Parse("C49E295D-CF24-46D4-8CE5-4F34BBB1DA9C"), Name = "Revelation 12", ChapterNumber = 12, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation13 = new() { Id = Guid.Parse("0FF2C5B1-5DED-475F-A2D2-000FE3ECC6CD"), Name = "Revelation 13", ChapterNumber = 13, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation14 = new() { Id = Guid.Parse("03EB2F6C-CEF9-4FC2-9391-0B38E11EF3E0"), Name = "Revelation 14", ChapterNumber = 14, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation15 = new() { Id = Guid.Parse("9662E969-FE60-46AB-B2EB-046DA628FDB8"), Name = "Revelation 15", ChapterNumber = 15, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation16 = new() { Id = Guid.Parse("34066E57-2336-47D4-B812-2748BB35649C"), Name = "Revelation 16", ChapterNumber = 16, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation17 = new() { Id = Guid.Parse("B2AE6BE1-CD92-4597-B6F2-39F943527692"), Name = "Revelation 17", ChapterNumber = 17, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation18 = new() { Id = Guid.Parse("585FA3FC-8099-4D85-867E-47BBEEC6A848"), Name = "Revelation 18", ChapterNumber = 18, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation19 = new() { Id = Guid.Parse("7EE38324-AA1F-4EDC-B187-A01F15ECF131"), Name = "Revelation 19", ChapterNumber = 19, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation20 = new() { Id = Guid.Parse("A00A83E2-D58A-4004-A23C-B32E29BD8F87"), Name = "Revelation 20", ChapterNumber = 20, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation21 = new() { Id = Guid.Parse("A86DA371-6A8B-4BC6-8039-25CE63E304D0"), Name = "Revelation 21", ChapterNumber = 21, BibleBookId = BibleBooks.Revelation.Id };
    public static readonly BibleChapter Revelation22 = new() { Id = Guid.Parse("6A9DF7D9-F856-4EFD-A6BE-4E8403DBAAE5"), Name = "Revelation 22", ChapterNumber = 22, BibleBookId = BibleBooks.Revelation.Id };
    
    public static readonly IReadOnlyList<BibleChapter> All =
    [
        Genesis1, Genesis2, Genesis3, Genesis4, Genesis5, Genesis6, Genesis7, Genesis8, Genesis9, Genesis10,
        Genesis11, Genesis12, Genesis13, Genesis14, Genesis15, Genesis16, Genesis17, Genesis18, Genesis19, Genesis20,
        Genesis21, Genesis22, Genesis23, Genesis24, Genesis25, Genesis26, Genesis27, Genesis28, Genesis29, Genesis30,
        Genesis31, Genesis32, Genesis33, Genesis34, Genesis35, Genesis36, Genesis37, Genesis38, Genesis39, Genesis40,
        Genesis41, Genesis42, Genesis43, Genesis44, Genesis45, Genesis46, Genesis47, Genesis48, Genesis49, Genesis50,
        
        Exodus1, Exodus2, Exodus3, Exodus4, Exodus5, Exodus6, Exodus7, Exodus8, Exodus9, Exodus10,
        Exodus11, Exodus12, Exodus13, Exodus14, Exodus15, Exodus16, Exodus17, Exodus18, Exodus19, Exodus20,
        Exodus21, Exodus22, Exodus23, Exodus24, Exodus25, Exodus26, Exodus27, Exodus28, Exodus29, Exodus30,
        Exodus31, Exodus32, Exodus33, Exodus34, Exodus35, Exodus36, Exodus37, Exodus38, Exodus39, Exodus40,
        
        Leviticus1, Leviticus2, Leviticus3, Leviticus4, Leviticus5, Leviticus6, Leviticus7, Leviticus8, Leviticus9, Leviticus10,
        Leviticus11, Leviticus12, Leviticus13, Leviticus14, Leviticus15, Leviticus16, Leviticus17, Leviticus18, Leviticus19, Leviticus20,
        Leviticus21, Leviticus22, Leviticus23, Leviticus24, Leviticus25, Leviticus26, Leviticus27,
        
        Numbers1, Numbers2, Numbers3, Numbers4, Numbers5, Numbers6, Numbers7, Numbers8, Numbers9, Numbers10,
        Numbers11, Numbers12, Numbers13, Numbers14, Numbers15, Numbers16, Numbers17, Numbers18, Numbers19, Numbers20,
        Numbers21, Numbers22, Numbers23, Numbers24, Numbers25, Numbers26, Numbers27, Numbers28, Numbers29, Numbers30,
        Numbers31, Numbers32, Numbers33, Numbers34, Numbers35, Numbers36,
        
        Deuteronomy1, Deuteronomy2, Deuteronomy3, Deuteronomy4, Deuteronomy5, Deuteronomy6, Deuteronomy7, Deuteronomy8, Deuteronomy9, Deuteronomy10,
        Deuteronomy11, Deuteronomy12, Deuteronomy13, Deuteronomy14, Deuteronomy15, Deuteronomy16, Deuteronomy17, Deuteronomy18, Deuteronomy19, Deuteronomy20,
        Deuteronomy21, Deuteronomy22, Deuteronomy23, Deuteronomy24, Deuteronomy25, Deuteronomy26, Deuteronomy27, Deuteronomy28, Deuteronomy29, Deuteronomy30,
        Deuteronomy31, Deuteronomy32, Deuteronomy33, Deuteronomy34,
        
        Joshua1, Joshua2, Joshua3, Joshua4, Joshua5, Joshua6, Joshua7, Joshua8, Joshua9, Joshua10,
        Joshua11, Joshua12, Joshua13, Joshua14, Joshua15, Joshua16, Joshua17, Joshua18, Joshua19, Joshua20,
        Joshua21, Joshua22, Joshua23, Joshua24,
        
        Judges1, Judges2, Judges3, Judges4, Judges5, Judges6, Judges7, Judges8, Judges9, Judges10,
        Judges11, Judges12, Judges13, Judges14, Judges15, Judges16, Judges17, Judges18, Judges19, Judges20,
        Judges21,
        
        Ruth1, Ruth2, Ruth3, Ruth4,
        
        FirstSamuel1, FirstSamuel2, FirstSamuel3, FirstSamuel4, FirstSamuel5, FirstSamuel6, FirstSamuel7, FirstSamuel8, FirstSamuel9, FirstSamuel10,
        FirstSamuel11, FirstSamuel12, FirstSamuel13, FirstSamuel14, FirstSamuel15, FirstSamuel16, FirstSamuel17, FirstSamuel18, FirstSamuel19, FirstSamuel20,
        FirstSamuel21, FirstSamuel22, FirstSamuel23, FirstSamuel24, FirstSamuel25, FirstSamuel26, FirstSamuel27, FirstSamuel28, FirstSamuel29, FirstSamuel30,
        FirstSamuel31,
        
        SecondSamuel1, SecondSamuel2, SecondSamuel3, SecondSamuel4, SecondSamuel5, SecondSamuel6, SecondSamuel7, SecondSamuel8, SecondSamuel9, SecondSamuel10,
        SecondSamuel11, SecondSamuel12, SecondSamuel13, SecondSamuel14, SecondSamuel15, SecondSamuel16, SecondSamuel17, SecondSamuel18, SecondSamuel19, SecondSamuel20,
        SecondSamuel21, SecondSamuel22, SecondSamuel23, SecondSamuel24,
        
        FirstKings1, FirstKings2, FirstKings3, FirstKings4, FirstKings5, FirstKings6, FirstKings7, FirstKings8, FirstKings9, FirstKings10,
        FirstKings11, FirstKings12, FirstKings13, FirstKings14, FirstKings15, FirstKings16, FirstKings17, FirstKings18, FirstKings19, FirstKings20,
        FirstKings21, FirstKings22,
        
        SecondKings1, SecondKings2, SecondKings3, SecondKings4, SecondKings5, SecondKings6, SecondKings7, SecondKings8, SecondKings9, SecondKings10,
        SecondKings11, SecondKings12, SecondKings13, SecondKings14, SecondKings15, SecondKings16, SecondKings17, SecondKings18, SecondKings19, SecondKings20,
        SecondKings21, SecondKings22, SecondKings23, SecondKings24, SecondKings25,
        
        FirstChronicles1, FirstChronicles2, FirstChronicles3, FirstChronicles4, FirstChronicles5, FirstChronicles6, FirstChronicles7, FirstChronicles8, FirstChronicles9, FirstChronicles10,
        FirstChronicles11, FirstChronicles12, FirstChronicles13, FirstChronicles14, FirstChronicles15, FirstChronicles16, FirstChronicles17, FirstChronicles18, FirstChronicles19, FirstChronicles20,
        FirstChronicles21, FirstChronicles22, FirstChronicles23, FirstChronicles24, FirstChronicles25, FirstChronicles26, FirstChronicles27, FirstChronicles28, FirstChronicles29,
        
        SecondChronicles1, SecondChronicles2, SecondChronicles3, SecondChronicles4, SecondChronicles5, SecondChronicles6, SecondChronicles7, SecondChronicles8, SecondChronicles9, SecondChronicles10,
        SecondChronicles11, SecondChronicles12, SecondChronicles13, SecondChronicles14, SecondChronicles15, SecondChronicles16, SecondChronicles17, SecondChronicles18, SecondChronicles19, SecondChronicles20,
        SecondChronicles21, SecondChronicles22, SecondChronicles23, SecondChronicles24, SecondChronicles25, SecondChronicles26, SecondChronicles27, SecondChronicles28, SecondChronicles29, SecondChronicles30,
        SecondChronicles31, SecondChronicles32, SecondChronicles33, SecondChronicles34, SecondChronicles35, SecondChronicles36,
        
        Ezra1, Ezra2, Ezra3, Ezra4, Ezra5, Ezra6, Ezra7, Ezra8, Ezra9, Ezra10,
        
        Nehemiah1, Nehemiah2, Nehemiah3, Nehemiah4, Nehemiah5, Nehemiah6, Nehemiah7, Nehemiah8, Nehemiah9, Nehemiah10,
        Nehemiah11, Nehemiah12, Nehemiah13,
        
        Esther1, Esther2, Esther3, Esther4, Esther5, Esther6, Esther7, Esther8, Esther9, Esther10,
        
        Job1, Job2, Job3, Job4, Job5, Job6, Job7, Job8, Job9, Job10,
        Job11, Job12, Job13, Job14, Job15, Job16, Job17, Job18, Job19, Job20,
        Job21, Job22, Job23, Job24, Job25, Job26, Job27, Job28, Job29, Job30,
        Job31, Job32, Job33, Job34, Job35, Job36, Job37, Job38, Job39, Job40,
        Job41, Job42,
        
        Psalms1, Psalms2, Psalms3, Psalms4, Psalms5, Psalms6, Psalms7, Psalms8, Psalms9, Psalms10,
        Psalms11, Psalms12, Psalms13, Psalms14, Psalms15, Psalms16, Psalms17, Psalms18, Psalms19, Psalms20,
        Psalms21, Psalms22, Psalms23, Psalms24, Psalms25, Psalms26, Psalms27, Psalms28, Psalms29, Psalms30,
        Psalms31, Psalms32, Psalms33, Psalms34, Psalms35, Psalms36, Psalms37, Psalms38, Psalms39, Psalms40,
        Psalms41, Psalms42, Psalms43, Psalms44, Psalms45, Psalms46, Psalms47, Psalms48, Psalms49, Psalms50,
        Psalms51, Psalms52, Psalms53, Psalms54, Psalms55, Psalms56, Psalms57, Psalms58, Psalms59, Psalms60,
        Psalms61, Psalms62, Psalms63, Psalms64, Psalms65, Psalms66, Psalms67, Psalms68, Psalms69, Psalms70,
        Psalms71, Psalms72, Psalms73, Psalms74, Psalms75, Psalms76, Psalms77, Psalms78, Psalms79, Psalms80,
        Psalms81, Psalms82, Psalms83, Psalms84, Psalms85, Psalms86, Psalms87, Psalms88, Psalms89, Psalms90,
        Psalms91, Psalms92, Psalms93, Psalms94, Psalms95, Psalms96, Psalms97, Psalms98, Psalms99, Psalms100,
        Psalms101, Psalms102, Psalms103, Psalms104, Psalms105, Psalms106, Psalms107, Psalms108, Psalms109, Psalms110,
        Psalms111, Psalms112, Psalms113, Psalms114, Psalms115, Psalms116, Psalms117, Psalms118, Psalms119, Psalms120,
        Psalms121, Psalms122, Psalms123, Psalms124, Psalms125, Psalms126, Psalms127, Psalms128, Psalms129, Psalms130,
        Psalms131, Psalms132, Psalms133, Psalms134, Psalms135, Psalms136, Psalms137, Psalms138, Psalms139, Psalms140,
        Psalms141, Psalms142, Psalms143, Psalms144, Psalms145, Psalms146, Psalms147, Psalms148, Psalms149, Psalms150,
        
        Proverbs1, Proverbs2, Proverbs3, Proverbs4, Proverbs5, Proverbs6, Proverbs7, Proverbs8, Proverbs9, Proverbs10,
        Proverbs11, Proverbs12, Proverbs13, Proverbs14, Proverbs15, Proverbs16, Proverbs17, Proverbs18, Proverbs19, Proverbs20,
        Proverbs21, Proverbs22, Proverbs23, Proverbs24, Proverbs25, Proverbs26, Proverbs27, Proverbs28, Proverbs29, Proverbs30,
        Proverbs31,
        
        Ecclesiastes1, Ecclesiastes2, Ecclesiastes3, Ecclesiastes4, Ecclesiastes5, Ecclesiastes6, Ecclesiastes7, Ecclesiastes8, Ecclesiastes9, Ecclesiastes10,
        Ecclesiastes11, Ecclesiastes12,
        
        SongOfSolomon1, SongOfSolomon2, SongOfSolomon3, SongOfSolomon4, SongOfSolomon5, SongOfSolomon6, SongOfSolomon7, SongOfSolomon8,
        
        Isaiah1, Isaiah2, Isaiah3, Isaiah4, Isaiah5, Isaiah6, Isaiah7, Isaiah8, Isaiah9, Isaiah10,
        Isaiah11, Isaiah12, Isaiah13, Isaiah14, Isaiah15, Isaiah16, Isaiah17, Isaiah18, Isaiah19, Isaiah20,
        Isaiah21, Isaiah22, Isaiah23, Isaiah24, Isaiah25, Isaiah26, Isaiah27, Isaiah28, Isaiah29, Isaiah30,
        Isaiah31, Isaiah32, Isaiah33, Isaiah34, Isaiah35, Isaiah36, Isaiah37, Isaiah38, Isaiah39, Isaiah40,
        Isaiah41, Isaiah42, Isaiah43, Isaiah44, Isaiah45, Isaiah46, Isaiah47, Isaiah48, Isaiah49, Isaiah50,
        Isaiah51, Isaiah52, Isaiah53, Isaiah54, Isaiah55, Isaiah56, Isaiah57, Isaiah58, Isaiah59, Isaiah60,
        Isaiah61, Isaiah62, Isaiah63, Isaiah64, Isaiah65, Isaiah66,
        
        Jeremiah1, Jeremiah2, Jeremiah3, Jeremiah4, Jeremiah5, Jeremiah6, Jeremiah7, Jeremiah8, Jeremiah9, Jeremiah10,
        Jeremiah11, Jeremiah12, Jeremiah13, Jeremiah14, Jeremiah15, Jeremiah16, Jeremiah17, Jeremiah18, Jeremiah19, Jeremiah20,
        Jeremiah21, Jeremiah22, Jeremiah23, Jeremiah24, Jeremiah25, Jeremiah26, Jeremiah27, Jeremiah28, Jeremiah29, Jeremiah30,
        Jeremiah31, Jeremiah32, Jeremiah33, Jeremiah34, Jeremiah35, Jeremiah36, Jeremiah37, Jeremiah38, Jeremiah39, Jeremiah40,
        Jeremiah41, Jeremiah42, Jeremiah43, Jeremiah44, Jeremiah45, Jeremiah46, Jeremiah47, Jeremiah48, Jeremiah49, Jeremiah50,
        Jeremiah51, Jeremiah52,
        
        Lamentations1, Lamentations2, Lamentations3, Lamentations4, Lamentations5,
        
        Ezekiel1, Ezekiel2, Ezekiel3, Ezekiel4, Ezekiel5, Ezekiel6, Ezekiel7, Ezekiel8, Ezekiel9, Ezekiel10,
        Ezekiel11, Ezekiel12, Ezekiel13, Ezekiel14, Ezekiel15, Ezekiel16, Ezekiel17, Ezekiel18, Ezekiel19, Ezekiel20,
        Ezekiel21, Ezekiel22, Ezekiel23, Ezekiel24, Ezekiel25, Ezekiel26, Ezekiel27, Ezekiel28, Ezekiel29, Ezekiel30,
        Ezekiel31, Ezekiel32, Ezekiel33, Ezekiel34, Ezekiel35, Ezekiel36, Ezekiel37, Ezekiel38, Ezekiel39, Ezekiel40,
        Ezekiel41, Ezekiel42, Ezekiel43, Ezekiel44, Ezekiel45, Ezekiel46, Ezekiel47, Ezekiel48,
        
        Daniel1, Daniel2, Daniel3, Daniel4, Daniel5, Daniel6, Daniel7, Daniel8, Daniel9, Daniel10,
        Daniel11, Daniel12,
        
        Hosea1, Hosea2, Hosea3, Hosea4, Hosea5, Hosea6, Hosea7, Hosea8, Hosea9, Hosea10,
        Hosea11, Hosea12, Hosea13, Hosea14,
        
        Joel1, Joel2, Joel3,
        
        Amos1, Amos2, Amos3, Amos4, Amos5, Amos6, Amos7, Amos8, Amos9,
        
        Obadiah1,
        
        Jonah1, Jonah2, Jonah3, Jonah4,
        
        Micah1, Micah2, Micah3, Micah4, Micah5, Micah6, Micah7,
        
        Nahum1, Nahum2, Nahum3,
        
        Habakkuk1, Habakkuk2, Habakkuk3,
        
        Zephaniah1, Zephaniah2, Zephaniah3,
        
        Haggai1, Haggai2,
        
        Zechariah1, Zechariah2, Zechariah3, Zechariah4, Zechariah5, Zechariah6, Zechariah7, Zechariah8, Zechariah9, Zechariah10,
        Zechariah11, Zechariah12, Zechariah13, Zechariah14,
        
        Malachi1, Malachi2, Malachi3, Malachi4,
        
        Matthew1, Matthew2, Matthew3, Matthew4, Matthew5, Matthew6, Matthew7, Matthew8, Matthew9, Matthew10,
        Matthew11, Matthew12, Matthew13, Matthew14, Matthew15, Matthew16, Matthew17, Matthew18, Matthew19, Matthew20,
        Matthew21, Matthew22, Matthew23, Matthew24, Matthew25, Matthew26, Matthew27, Matthew28,
        
        Mark1, Mark2, Mark3, Mark4, Mark5, Mark6, Mark7, Mark8, Mark9, Mark10,
        Mark11, Mark12, Mark13, Mark14, Mark15, Mark16,
        
        Luke1, Luke2, Luke3, Luke4, Luke5, Luke6, Luke7, Luke8, Luke9, Luke10,
        Luke11, Luke12, Luke13, Luke14, Luke15, Luke16, Luke17, Luke18, Luke19, Luke20,
        Luke21, Luke22, Luke23, Luke24,
        
        John1, John2, John3, John4, John5, John6, John7, John8, John9, John10,
        John11, John12, John13, John14, John15, John16, John17, John18, John19, John20,
        John21,
        
        Acts1, Acts2, Acts3, Acts4, Acts5, Acts6, Acts7, Acts8, Acts9, Acts10,
        Acts11, Acts12, Acts13, Acts14, Acts15, Acts16, Acts17, Acts18, Acts19, Acts20,
        Acts21, Acts22, Acts23, Acts24, Acts25, Acts26, Acts27, Acts28,
        
        Romans1, Romans2, Romans3, Romans4, Romans5, Romans6, Romans7, Romans8, Romans9, Romans10,
        Romans11, Romans12, Romans13, Romans14, Romans15, Romans16,
        
        FirstCorinthians1, FirstCorinthians2, FirstCorinthians3, FirstCorinthians4, FirstCorinthians5, FirstCorinthians6, FirstCorinthians7, FirstCorinthians8, FirstCorinthians9, FirstCorinthians10,
        FirstCorinthians11, FirstCorinthians12, FirstCorinthians13, FirstCorinthians14, FirstCorinthians15, FirstCorinthians16,
        
        SecondCorinthians1, SecondCorinthians2, SecondCorinthians3, SecondCorinthians4, SecondCorinthians5, SecondCorinthians6, SecondCorinthians7, SecondCorinthians8, SecondCorinthians9, SecondCorinthians10,
        SecondCorinthians11, SecondCorinthians12, SecondCorinthians13,
        
        Galatians1, Galatians2, Galatians3, Galatians4, Galatians5, Galatians6,
        
        Ephesians1, Ephesians2, Ephesians3, Ephesians4, Ephesians5, Ephesians6,
        
        Philippians1, Philippians2, Philippians3, Philippians4,
        
        Colossians1, Colossians2, Colossians3, Colossians4,
        
        FirstThessalonians1, FirstThessalonians2, FirstThessalonians3, FirstThessalonians4, FirstThessalonians5,
        
        SecondThessalonians1, SecondThessalonians2, SecondThessalonians3,
        
        FirstTimothy1, FirstTimothy2, FirstTimothy3, FirstTimothy4, FirstTimothy5, FirstTimothy6,
        
        SecondTimothy1, SecondTimothy2, SecondTimothy3, SecondTimothy4,
        
        Titus1, Titus2, Titus3,
        
        Philemon1,
        
        Hebrews1, Hebrews2, Hebrews3, Hebrews4, Hebrews5, Hebrews6, Hebrews7, Hebrews8, Hebrews9, Hebrews10,
        Hebrews11, Hebrews12, Hebrews13,
        
        James1, James2, James3, James4, James5,
        
        FirstPeter1, FirstPeter2, FirstPeter3, FirstPeter4, FirstPeter5,
        
        SecondPeter1, SecondPeter2, SecondPeter3,
        
        FirstJohn1, FirstJohn2, FirstJohn3, FirstJohn4, FirstJohn5,
        
        SecondJohn1,
        
        ThirdJohn1,
        
        Jude1,
        
        Revelation1, Revelation2, Revelation3, Revelation4, Revelation5, Revelation6, Revelation7, Revelation8, Revelation9, Revelation10,
        Revelation11, Revelation12, Revelation13, Revelation14, Revelation15, Revelation16, Revelation17, Revelation18, Revelation19, Revelation20,
        Revelation21, Revelation22
    ];
}