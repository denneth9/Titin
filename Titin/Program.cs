﻿// See https://aka.ms/new-console-template for more information
/*
 * a = methionyl
 * b = threonyl
 * c = glutaminyl
 * d = alanyl
 * e = prolyl
 * f = phenylalanyl
 * g = leucyl
 * h = seryl
 * i = valyl
 * j = glutamyl
 * k = glycyl
 * l = histidyl
 * m = isoleucyl
 * n = tryptophyl
 * o = arginyl
 * p = aspartyl
 * q = lysyl
 * r = asparaginyl
 * s = tyrosyl
 * t = cysteinyl
 * u = isoleucine
 * Courtesy of Wikitionary: https://en.wiktionary.org/wiki/Appendix:Protologisms/Long_words/Titin 
 */

//Titin, transcoded into characters
const string str_titin = "abbcdebfbcegchiiigjkhbdbfjdlmhkfeiejihnfopkcimhbhbgekicmhfhpkodqgbmedibqdrhkoshgqdbrkhkcdbhbdjggiqdjbdeerficogchabiockhciogcioibkmereiiqfsopkdjmchhgpfcmhcjkpgshggmdjdsejphkbshirdbrhikodbhbdjggickjjjiedqqbqbmihbdcmhjhocbomjqqmjdlfpdohmdbijaimpkddkccgelqbeeomeeqeqhohebeehmddqdcgdocchehemolheheioliodebeheiohiheddomhbhemohioheggaoqbcdhbidbkejieeenqcjksidhhhjdjaojbbgbbhbcmobjjonjkoskicjcibmhkddkdddhihdhdhsddjdidbkdqjiqcpdpqhddidbiiddipadoiojeimhdijcbdcobbbbdilmcedcjcioqjdjqbdibqiiiddpqdqjcjgqhobqjmmbbqcjcalibljcmoqjbjqbfieqiimhddqdqjcjbomhjjmbqqcqcibcjdmaqjboqbiieqimidbeqiqjcpgihokojkmbbqojcicmbcjqaoqjdjqbdghbmdidbdqdqjcjbmgobojbadbocjcmciblkqipikqqdjdidbiiddipcdoiojeojeklgjjhsdccbbgjsksqjomhddqidjeecoedhjeliieqdiqeoimcdehjblmqbbpcqkalmhhcmqqbbpgbbjogilipqoeobdhelfbihqmhieqbjlksjdhmdkhdmdbgcqjghdbhhdcqmbqhiqdebiqehjboiodjebegecfefdpbepbsqhjdkijiqqjikihmbkbbiojjofjiglkojdqibjbdoiedeijmeibeebgihkgqribimjkjhibgjtlmhksehebibnsojpscmjhhmpfcmbfchkmdogamojdfdjphkofbthdirjdkbihbhtsgdicihjjfjqjbbdibjqfbbjjqofijhopiiabpbhgbjjcdkekjeddesfmbqeiicqgijkkhiifktcikkreqelisnqqhkiegbbksosqihsrqcbkjtqgimhabfdppdkjsbmiiorqlkjbhdhdhggjjdpsjggaqhccjagscbcibdficjejikjbdekfishjsjqjsjqjcdgmoqqadqpbiiiobsijpcjflmhhfjjogmqjmjsommqbbgjjggjjpkjjqadipmhjhjdijhkfpgomqrsomgjkakibfltqahksegeqmdnsqpkqomqlkjoscapfgcpkodhgomeiigejpjkmsbdfdhrmqkrdmthkqgsijeddegkdebsmebgjeihomohgheohihohemoahedoahedoahedoahedoahekoogjjbpjhcgjogsqeifigqeihfqtgjkdrtofpgqiikoeaejbfnflpkccmirpsblqiimqjpkbchgmmiedbehphkjnbiidcrodkohhmhimgbijdijlciqeafijqgqrirmqjkhogjaqiodbkrerepmingqrhpmmielqseqmomjkbqkjddgqmphbihcphdnsbdbdmrqdkopbbotqirijijfdjejejoqgmmeokbsodqjmddejgjeglgoskcjcnjjkpgspqjqccqeffqqqgbhgogqofkedlfjtogbemhpebaiijnglpkqegjddrogoamrjfksthgpskidshophkmmbtodbrqskbplbhdbgmiqpjqhgijjhcgejkoqkgcomjjgjoadljkdgbkibbpcqjqcqepmigsejeioigjkjbdofotoibkseceqirnsgrkcgmoqhqofoiospkmlsgpmiptqhspbkjiqibdjrejkimjlqiqgjmccojpfohigoodejeoejfliljekqgcfjicqipoeipbbjbqjiiqgqodjombljqiejjhjjgohqfqoobjjkssjdmbdijgqhoqqpjhsjjggoqbqpjgglnbqjgbjjjqqdgdjjkqmbmebfqepqmjghehajdeqmfjomchcbikckhpdlfoioiikqepejtjnsqrkiqmjohpomsnsnejpritjgimopibdjphdhmaiqdmrmdkjbhhldfggicdqcgmbfbcjgcpiidqjqpbadbfjtjbhjefiqiqnsqpkajiljkpqsoalhpoqilfghmgbmpbhpdjpshtigijpjriqbbdqgmijkdiijfiqjgcpmjiejhshkjgjtmihejrmjkqnslrpijgqhrkqsbmbhookocrgbiqpibqjpckjshfimpkqqbbtqgqaqeoemdmgckghpcqitjkpmicgjiqihgjhijkinaqpkcjicehpoilmimpqchlaggmjpabqjpdkrshfbmedgkghbhkoihishipimbegqpirimjkbqdigjtqihiepibhiqnsgrpjcmqeppoicdmiqkbqcogimrobldhpjkesqgmikoijbrtrghijqmqmmokgopgbtbjbcriifjijghlhkmpignrfqpqjmqehhqsqmjdlkqmsqgbigraaqppjkqsbfsdkjrabhkqgbidkkdmhqegbpcbidjhcjdifjtjidrephqkjngopkqlgegbrrmohjhpklqoogmmddbqgppmkjsbsqidbhqbhdqgqijdiqmqqbgqrgbibjbcpdifbijgbleriqkicnmqrkiigjhrjqsdmhiqkbmshgomqrtdmipjhiskfogkogkdhdoglijbiqmmqqeqpibdgjrdbidfjihihlpbieiqnflqhijmqehpqlogihjoqilqgagcrmhehpdkjsbdiikcgjtqdqgfijbglmbqbaqrmjiejbqbdhfjtjihlfriehangqrkijmjahjqfqmiickqglcgmmarbhbjphdjsbfitkrpcihdbgbibemambhagqpmrdjjqpbmbfjibirsjkmhsqngqrkijmqhbpqtcaobqqgblhgrmorilfkpddpsbfidkqdbhbdbgsijdolmjfoqlmqpmqigjqqodafjtjihjepmbicnaqppcjgcmbpomqmcqjqsiloggmehboahpdkqsbiidkkrihbdqgfijkopiomohmqqjicimjqcodiijfjirjppipdlnsqpkmjmrfcicjolqsiijoomloafmhjbochpdkjsbfidkorohhibgsirdejeecigcjgceibichkqedoftdamhkoeceqmhnsqjjcgghbkfqtqfglpkcjsbgggmjdfejpddisbtjdqrpskidbbhdhghijiejiihepcjaeiseedmmbegcpbibhjkcedofctoihkbpgqihnshqpqqmqehoffoabcfjpbscgjmdjdsejpjkbsbfidrrdikcihhbdrghgjdejhmgljomjcjmjajaqjfhhhfghdjjjkglhdjgcghqmrjbgjgghjheisebqfphjqjkbkemfmqjihrdpmhakpidbghibimkmeqeqmcnffrkiggbehdpsqfifpkpplhgmmgfbqgjpjkjsbtadhrpskqbmthdsgqmrhqkjklqpbjbjhdidqhgjqgkketeelfgqjgqemotdckgedmfjsbiikjedebibnfqjrqcgtbhissbmmlrerkhkbfmirpecojphkgsmtqdjragkjhbtddjggiggjpbpabpbetqdqhbejdejpfecbegqkedijdgphjcjmdbfiqpbmgqddgmbjjrccghsjlmdqdrjghhcgegkdcjgchmgjcpqgbejhbojfgtmrkhmlfcegqjehergcgcmichcqbfhqjkmgaejjejbcdighpbjqmfehdahmjcmrhgbijegqbggdjejkrsechhmjeealhsgbhidjjighgqjqbihpbrojcoibgcqcjdchdgmghchgdjklijhgchepiamhcirsjegiehjlhtbjkkqmgmjhdregjrdkcphdiomjjkqhgofegdgjjqciggqjjlhpriiaeepcmmjhqojeidmqqicjickopgghqjhgghkmejjcogrgqmcmtodgcddidhjcekgfhjngormjqijijdirmbcjeolmatasgibhdqhibjjibmmmjpipecadrgqajgopdgtdmmsjjmpmgbdjkeomcckdqbhgcjjaphfhkhcqijembjejijhqsgmhbjjihsfrichoiqsgpdbeibqkidhdiihpjqcpjhgqehjjqjjhhhjhkbjjidbiqmcjdjkkgmqjpkeamlbegipbihjjkpmilgbbhmbrdqjirnsfjrqgiehpjqfqtgcpcrbsbgimpqirbjplckjsitjdgrphkqbdbhdqgbiiqoddeimqoqmjegjidgklgdqfbtjmchderiofcnfqdkojmsjhpqthmohhqsmhhgjmgobciiptkjsbtqdhrjskhihtbdbgbibiekkjqqioqggejoqejeqjjiigqhigoqoejjjjeqijeqqgjqiqqediejeeeeqeijjijiebibqojoqmejebqiejmqedmegedejeqeqejdjiqbmqeeeijejebemddeibieiikqqdjdqdeqjjddqeqkemqkieqqbehemjdjooqgoekhkkjqeepjdefbscgqdiegqfiqjmqpmmgbjhjfikhhdmfjtgihehbdmbbnaqpkhrmojheqlofmdpkqpoqglmmpicghpdkjsbtigogkrqjqbhbdqgiijjgeiofiqbgjjjibiiqkcegsghtjgrqjopiinoqpkqmiijqekomiekimkgaodgbmrpdppbpdkbsbibijrdrrgjthhtiqiijimopngiqemopcliqeqkbdmfdtpmdqpbermqnfqkspjmedjerpqbjmgopkrlgsgqmqrdaejpmdjsdijmjkqosedqgbgkjojijggqemjpibmsjqjhdhfpdjmhjdpmekcnqgqkjggoehebtjmqdjkkqofgbglqiqgpcdkjigscdgrdmbbdmgbiqjmjgpfdiegqpibiejoocdofjtigbojdrimnhqkepmmqhhpqfpmmdpkqqlmgimrphcfppjkisbdjijkqqbhdogfibkmogqfahegjpcbiqjkjbdbfitjghljqaliinfqrpdqglbhobigmhhjkqblqgjaqjibgppmhcmqdciqjghhbdcgqigjdpesfbiqglpqbdijqpjmbgqtjihqpieiqnfqpkjjmieheqshmqdpkgoomgqmqqdpgqpqkjsitptkbpqbqdribijdogmjijqegskijifikjbdlfjmjghjepilkcnqgqkcegbdheptjmmjpkqqlmgmglrtcgkabkjihfcddrdqhddrgqiqjgegmfmbeghpiqifjqpjdqfjtjihojeqbfongqkbcjmbkppofjgmqpkbqlhaimqhddfjpjdqsafjdjpqlbhkqgmmjkmogqfgbegqpibdqjqjhdifbijghlprmoiqnfqrpcoglbbohihacpjkqblhmbfqpghmppbhcmoijdakahhjdqgbigjkpesfbkqgcpsbkijqpjimgctjmhqdpdeiqnfqpkqjmqehqrdimqbpkqqoagmgqqdgqhpmkcsbtptkbpqbhkqgpmjpojmqgioeglhijiajbjbdofjbjmhjppmldrnqgqkjdggcbeptjmqjjkqmlhgiglrtogpcbkkipfcddriqhhdlgoiqeoimkggoegqpibibdkjbdbfptjghsjpmeijnsgqkqqgjehpqiieohjkqilbgbgopiqgjpdkjicgbdqpfqbldrgfiqjeeijfbqegjpcbijjkdbdigjtjihojrdqiqnfqrkbjmgqhqqsjmidpkoioqgimlptbejpmqbsbtpdqpfqbhtrgriieelijfgoegbpgciojqjadofjtjghojrdqiqnfqpkdjmqqkqqspmmhqkdiomgimrqtggppjdjshtjiobdobhkagbigjjjdifbqrgdrmjihjbpbmqgitjihqekdjimnsqkpjjmmjbkosjmgbjkoqomgimcrdlgjpdkrsrtogehhobpkqiqiljgddjfmhqecrgjmgjkjqdjfithmhqjhfeicnqoppqbgjhkpqspimdpkqqoigiiqpdbgcpakbsiiaikddodddlgbimjqgomiiegqpboiqjccjiifrtjirbjkdqdqnforjjdmfphhqsmmgcqpgisbgomopdlgppcdrsrihgbrlokjriqhddrgmijjjpgomijegqpmjbajqqhibfntqirogribgqnbqrkjjiefproihsoipqsqlagbmqptkfepjkjsmibdkcpqhidjggmmjdebjfijlgjpcbibjfppdifhtcghojqdriqnsorkojmqjkqqsqfjqpkhmlogmmqptogppjtjsdtkijpoqhodogfijjmeijmmoeecpmgjdekdpiifgdjgrqpqijicngorraiiickpqlcaahjkqmlogcmtpmqeopckjsofmdqpqjdodqgjgdddeqmqbdpcpgiipikqegbaiiespdseqdjdjnfqjrjeghbqbmpbbdjcbhfomgjdqqkpqkosqmigcrqlkqdjkfmrgqimpiekeiorgjibjbfpkjihgdnjjegbpkkhqmmksiijoopmqoqbnigdbpodjhtjfbibkgcqkkijsgfoihdoroikbkjeijbpreijdohqspiekeegribmbpirofkihgbnjeejspkkdjmbrsimjgopqbhmonpbdabiodjpghdbibpiijkcjshfoiodcromkikqehddbefiqidpemjoeheeirgbhhpcbchhicgqnjeegqpkkhemgksmmjotjjkqprnmotraqgiejgbsqibkgjqkrqsgsoihdjrqdkihpehjmgkegbdppdfijebapghdfqpkgjimierembmgiehbkseoebdbntfkpqigjbkpoiqaqbghdsdjgimhehjohpqkmsbgqgjroiqbmhkjmpirimdoehdeqjgqfkpmbqphilgbnjeepppkkhegbksiijqojihoqbnbqiapfibpgjfbiepgickqjsgfqitdorqtkekjedsipjeirahbedbiepeejriqnopobdrhmfgbnpeeqrpkkhomqksmijoteokhpqnidtkjeidjbqajibkgjjkqnsdsoiqbgrockdhqehoebjjmcdipbcjdejmfgpiqggdkgbiqdkbqmjgedbibkqejeqmbnbqdpamgqcpqombmjrieqqhbibmiphqohpbkbsmmjdiritkodbdiijirigpqekeeddfpmbpibrjhtggbnreeoppkkhqmbrsiijoodbphjinlqghhbiqpbrfqdbqgmerqjsmfoiddjraskdkjeicdhembdqscfpeekeebogjehpmbqpdibgbntjepppkkhembksnijogpepbpqniotrqaeiqpbbsoiqkgbrqqqsofoigdjrgdkekqehqhbjemgmqpempeeneekqebiqpikqbhiogrnbqejlpkkdqmjhsimjagqbkbpjnioidjkiebbclggekgajkcjshfoiodirqdkjhjehjehpeigtojqgseeheeongjimrmbqrbdpgqnbiejqpkkhembrsmijqopiooqkncbipbbiqpbqtbibegbjkhgsifoiddjrdmkchpsbjmjphigdqpbfbbekeesdgdiipibqolipgqnjeeqrpkkoemcosimjqqjogkboniqdkqbdkeptrfoibpimjkbjicfciodjrjdkiklehjebjmghmjpebheeheegpglibpdkoqlmdmdnqeejqrkkhemmkslijateikbjqnaoirhoemqpgqfqijjkiiepqjsigoiodirdmkihjehjmhjriidqpeptqebmpgjblpmmimjkjqghmeiefodieiebihnlqpkqjiqdhpogbaqrplmhdlgjieqhiodpdkmsbmbgjrqgkhdbdhmriqimkgeketqpmqdhpmbqhhtqgbnjeejfpkkbemglsigjoojdkoobsmeiahkjrqghnbiqpgmerkjsffoiqdirqikkkjsmjgqreimdcpeqceepeeipijilrebdjdabmbnqeegspkkhqmaksmmjqmdqkjjonqotrjlgiemgbsbdqkgjjkqjscfoiodjrddkmhjehodbeebqdipempdeqimgobhgjiqokpjmdgpdhmhkhesebmbnmqpjrimiejjmqqoddegioooqkjicjjjefigegbcoghmprhqqkjhcgoiophgoeplkgsamqijrplkmdqdetbihigpbekeemrfifjpmoqbhigtqnjeegppkkhjmmrsbgjqqpqbqephjnmiibhbgoltqshibqgmjkqjsgfoiodjrofkekeetihqegidqpefkeepdepqemijpibhrhagiqnrjeqprkhemgksngjqojirhblnhoirqhggrdgqdripkggjkgbsifoitdjrddkekqfheehpeqbdlpemheekeemeoibpbhhbbmjgjnjeedfrkkkjmiksfipqcgikbrqnhotbjqamqiocsbiqjmojkdpsqgoihdirddkjkeekjbceibidjecjeedijgpihiqkkmcmadkqbgomediibkoeiebqinbqjjkjgpqpoiimprikbqhjgmmqpdgoqplkosimbdbrhtkhqfdddoijifpiekeigpgqeiibroqatggrnhpejppkkhjmbkfmmjoqpdqalbnocemjbjohqtpmbkggjkcjsqfoimdqrqfktkeeijmkemgdipegkeebhejogbsbjocohbmbgpnqjeohrkkhemcksmmjqoolpqepfjoirqogtebbhfgijrgpjlcasjfoiqdirjmkjhjehgegriimcppjieebmqgoghiokpbmqiqdkjeilmedpibkgeaeqmjnhqrjbimjqebpdgcmbqjjihohjdqbjghmeqdiojpqkbsbibdhrogkhiforilijispoeheeorgdibpmqdjhtsgbnpdegprkkhjmblsimpqopdhoqqdjnjjibrbdijqoskmnqgmerkcsjfoiodirqskmhpjtqhpqiimcpesogekeekqeqigdobqkhagihnbeegprkkhembksngjqojjkhesnhoihodembqikgqkijfrieoggjkiqscfodadmrddkmkeehjehpejidkpemfeekeehtejiqpqbqhhmhgknqeedqpkkhemqksmijacjjkbbpnqoirjepqgmbbtjtiiergqjgoqsofoiqdirjdkjhjehpbbkjmedbpmcjjejifmpmkdcptgitqdkhcmomedimqkoebeqhhnjfpkqdqqdaqpkilpmejpdcgjbdjrhhimmmejtqohlbkqshmbdqrqdkcqbdrtoiqiapiekeeqpgqihpmbokhtoghnqaepppkkpomqksimjqobmpkqdnbqireptkhbbfiiepgghjccsffoiodjrofkmkeeijbmcobbdopemseepeemqgqmkgmbqrbilghnqeeqrpkkheiblsmijtgdnpebkbqqjdnoctrqopijjgcfbijpgijkkjsjfoiqdirddkihqehdbiketptcoepaeehmpgqjfajijjkbrirmidqmqkiefebgbnfqdeeqqeprqjeigspblirqgiippbtbgimechoohpbkgsbmbdirrgkbdhqjaogrigkoekeeikemqfjhihdpcabghnfeeqppkkhqmbrsimjqojdroqbnilihhjeqjtbsbmeqggjkljsifomadcrqskmkjegphjejbdorgfhiekdepqebihhiborhabirnjjejspkkheibksngjaqpbbhqonqoiropemqdabgkihsqibkgmjkhpscfoisdmrddkikedhgehpedbdopemdeekeefeqibpnbqhhdpgjnheegqpkkhqibksmijsqjjkqjjnjqkqpqjiokbqgiibkgqjkdfsqfoihdirmdkmkjekjibpimjaqpogihepgcgpdhiopomiildkkimommdsihkqeeebibnrarjobgecjdbmjbbdmhhhaimqrtcohlckishggdqrjdkjoqqbmmipigpiekeikbefgdlrgbrjhtqgbnfhejppkkhembrsimjqojhpoodnbeibsbibocrdbickgmckqdsffomddjrhmkakefijbhjdgimojembiejoejpgjiqjibqrbibgbnreeqspkkhjmmrsigjhogmkbjqflqibrprgghoqsbiqkgqjkpbsjsoihdirmikckqehftbqembtqpjgdeebglgpfopqgbmoikjdfdgbkoshkqeqeqihnfqpjdpigjppoblmqbbedbgdgjqmqdqohphkqstiiijrhbkhoqkftciriiplekeeikeihfpjibqpsaimhnqeegppkkhqmbrsmmjqqjikqpinaeibhdhdqbbtqihqggjkqpsmfomldjrgskmhpegihphaqdqpofoiepdepcemibjibqphdgibnrqelpkkqembrsmgjqojbahqondoibqpemlesbqfoiepggjktcsjfoihdjrjmkmkpeheehqeifdqpemdqeheeirejdmpbbtrhipgbnceeolpkkhqmgksmijscqikpjjnoodrlbejhtejbqsqibkgopkcbsqfoigdirddkjhpedliejeigiqpogjeejgmgpdradojclmqikpbgoghdmmqkiefeqibnqqjpopdebqdompibeikhqgjmorddljpkkmshgbijredkhqbihiqigigpqekeeopgjihjmoqphtsgbnqjegppkkhimbrsiijoopidhdcnheghdbhqqqhlfdqlgrjkrcsgfoiddjrcskokefijbeqemqdgpegleekeeqpgllipipqbjihginrqepopkkhembksgijscjjkbcpnmqfqbibrgjtiibkgcckqbsofoiqdjrmikgkgepbbmemjtcjqgieehijgpiqgmjkgiiqdkbbiofedmmokieiebdqnbbpkhjmqbpjlsbijbprfhhigbmqrtgoopbkjscmbihrddkhqbidilgbigpiekeebkemrmgpibejlabmhnceeqppkkheimrsmijqcpboqpbnkiihhkhhqbqgqmelgcqktjsifoiodjrqmkikeegphbebidqlqfheeheekqeiibpmbjrddbihnbgeqhpkkhembkssajoojibkqnioirqbemdpgqfoibkgsjkrbsjfoifdjrgdkghqehehhpemqdtoemqeekeemreqgqpqhojbdpginbqeghpkkhemgksiijtcqekbdcnromrqpjgmoctdfoiekgmjkrjsofomqddrmikjkjeojgdjhimdqpmgleejijgpibtopimbioikcbmomgdoiqkoejepmbnbqjkqigiojqoipgmcpgeoijgcmqjdiodplkqsmmhdqrhhkldckhdmirigpoeketcrgqibribqjrtbmhnjregprkkhjmbrfmijsoqercqknhmidhpibqogmqdrggdrrjssfoitdjrqikikebmjbqbemgdmrempoekjejrglmdpqkqbfisgqnooepspkkherghslijoogqkhppnjoilqkhmqjblsaipotijrcmsjfoicbqrjkkjhpniqbjjiiiqjpgcqeigpgqghkigbiqdkpbmogjdkiokqefejidnbqpqpdbpgboheoiqmpbodphhqfhgbqdqohpkkqsiibdbrbdkhfidsdbirigpqekeiorgqmipihhpotbitnpeejppkktjmcrsmgjqtjbqoainhbshdbigbekbbibogmjkrjsmfoiodjrqmkbkeebjhqeimdqbqspqekoepeejibqihqjjabiinreejspkkqhmbksfgjqqjqlhbonieirqhdmejooaqicrggepljscfoiqdjrjmkmkjehgehoeiidqpemjeekeebrfoiipbbqlhmbgknkqeispkkdemmksiijaoeqmdpdhepjknqotrdddcgioqjfbibhgpjrcjsjfoitdcrcikmkoedjgqjdmqeqjmgjeejmpgpdhaoqgimiodktemogfdmiokoedeqibnoqikmpriioqkcipgipbadfgimerhbopphkqshgbgiredkjqdifirioigpbekeihpgqihpibqbhtlihndeejrpkkhciblsmijqojdpoqbnhbibejiqqbhflibrgiekrjssfoibdirjskekiebpieqeigdhpeghjepeeoqgjdbjabqrhdbgdngeegopkkdqmpksmmhsojjjcedponbjshiiqpghgiibkgqjkqqsqfoiddordikihgeojdjkisjdqjcggeeqmgaejcmbmqdkqqgomjdliskqelebtqnqqkjpjiibhhlgdilqdphhhmgmmqpiboqphksshgbdjrhhkbpbcqmqiiiapdekeeceefpmhpmpdpdthghnlmegjpkkhrmbrsmijqtpihokpnibdgdhibqbhtoikqgmekcjsmfoiodjrofkmhjegbheqaidcfefkiehjeqrdoibqirqptmfidnpoephpkkhemmksgmjoqjorhggniqdrpbgiohbjsetdkgijkgjshfomsdgrqdkhheehqebjsibdoaeipeekqejimpibqhbihgmndoeqlpkkhqmmksfijdtqgekpqniotrbdelcmecjjsbdbkgjjqdcscfodmdobdirmheehjehpeibmgdjrieeompghidaqhggbiqdkbritgpdbifkqeaebihnqqpkbggqedjkmqadacorgtbgjgfhiroqphkpsbmbdjrhhkhqhdbmqgqigpqekeedhiqmrqashpodaghnjeegjpkkhjmbrsmipqojbhoerndcihdbiembhthijqgmjkljscfomtdjrqskikpeifbjedmdqrespeekotpeeimhrmbqplabihnqeedppkkhembksggjqojbcdirnbqiroqemmjobgqdbkgcjkbjsjfoibdmrqdkekqehpdhqddsdopecseedeedfeqispbbohhihghnkqedspkkhemmksgijiqodphprniotrgecrgcqbofjibkgajpbcscfoisdirqmkshpehpiepqlseqpmgmeejkjlpdpgoqbgmgodkibaogsieiqkoeeeqmbnhqerirgopomkgpmqhbpfpbfgotjrirqspdkqsmgbgjrhtkqqjsbmiiqigpbekeemribiqjmhqphdsibnjeemmpkkhemmrsiicqopdjoqhnhbibbjthqbhfoiergjjkqhsffoifdjrjskmkpekjbopdiqdhcbekeiipgqiohihqhhthmknqqelhpkkhommksiipfgbjjrqncoiaqhghgcshdqpgbjkqjsbfoihdjrjrkjkbehjmbiidoppiidepgpgqkgepgtsgdqjrhrfogqmemqkqedehihnqqkjpegdbpboihijhhdirbbgmisptcqhpdkqsbmbgqridkbqjkbmhmqiikqekmebkemqfpjibdjdabgqndeeqppkkhjmbrsmgjqophirrqnibtdhdicqbbfoibogljkajsbfoihdjrqskikjkgqhjemidolefpiepdeeeermipiolphihgbnbpeqqbkkhembkslgjfqjorhggnqodrqbemoaopfqibkgbjkgjsjfoiadmrgdkikqehgehjeiidgpempeekqejimrmborhibgmnbjeqspkklqgbksmijqopgehqhnaqdrliriejtdfbibpgijkkqsjfomodqrbdkdmhdehjhbjbmmtqpjsjdebmigpebmqpkgbmqdkpbmigrdmhmgkqegeqhhnhqdkqpmoehpmbcmbhbebhhagbmqsdboqpdkjsbmbdbrefkbqijliqibigpiekeekeijmhrihdjqdbgbnbeegjpkkhemqhsmgjqojbhoggnbiihjpmchtolidbqgmckrjsmfoihdirlskqkjeichjeiqaipofkeekeejqejihribqrbdbihnqoeippkkhjmbkslijoojqqhgoniodmqbeihpgotqibkgcjkhbsjfoihdjrodkmkeehjdhphigaqpddseekeehrelibpbbqqhdhgdnkqelspkkgjmbksiijlcqikpjdnmqpbbkbdgombcfiiepgcbqjqsrfomhdmrpdkikjedimepijmijojadepfjgpdjgoobgiiodkghmomfiemqkoedejibnbqprmrgqrodrmjrbjhfbggmmejtrospbkqfiabmjredkqqhkfirioigpbekeigrgoebpmbqphibglnpgegmpkkhombrsmijqojdboqhshbdbbqtlqtbsqibkghjktjsffoiadjrjskmkjebjbbjeiqdhjdeheephgrmapmbqhbihgdneqeqlpkkhqmbksimjdcoqkhpcnblmbbiqkgjtiiorgbjkjjsbfciadirhdkohdeojhoeimiqjcbagejgpgokmscqgimdqdkprmqijmeigkoeqebibnqqkpcmgqcbcoirfjbbdbhbmgrmrjtiohphkesegbdormikjikpimbmcilpmekeebkemqfpjihhpfibfhnpeejrpkkiemhrsiijaocbphbbnijgdbbimobbsqdbogbbkgjscfoiqdcroskikekmbhdnmidrsefqiekeekbecibdibqphabmhnljeghpkkhemgkslijoqjorkmgncbihqdgiekrmfqhhkgbpkmdsjfoimdjradkqhqehqehjeagdgpempeekqeiegrmbolbibgqndqejsbkkfqmbhsmijqopgerkongqdrfhrmgjrjfbihkgbjpddsjfoimdqrddkdmheehjehpdmbtoppijdeqmqipiqfqpbimgqdkjdfogjdpihkoeeebajnhqpkqjgjkbdqgjmqmdpfhbrgirqphboophkdsbgbdbrekkfdqlmfriqigpoekeejkegdibjibhjqtighnfeegppkkdqmplsmicqojbhogdnbridhjicibqgqibqggqkrjsmfoiadirqskikjegjhjeigdireskeepeeqrejibbmbqphaiitnklephpkkhjmmrsmijoopqdkconmqtrqqbgbpgosqihkgbjkljsjfomadjrddkmhdehebhefsqdtpbifqekeekreoigpbhohhmhmdnrqemspkkhjmbksaijmdgejjpjncmibeedkgqdbhsbmbkgbjrcjsqmomsdarhjkgkjedgiekbeqdjpoageejmjgpdpgoqiibmodttbgogfiemqkoepejiqndoplkjhgpqdhmjhdhhsbggmikrirofphkqsmgbijrhhkhqhdfirioigpbekeecpgqiqjibqbhibgbnpeeggpkkhqmqrsmijqojhboqdshbidbrtlqbhnqipcgcjkthssfoigdjrjskmkgedjbdjhiqdhjoegeekqmbgapiborhihghnjqejlpkkhomgksmijacbqkhpqndbtdbiqibjdbmbkgmckjjshfoihdcrjqkmhpeocghieimdqpgimeedfqggfrbfbigdkjpgqipiefmkoebedibnlqpriegqcbboirdjhbjrrhggbmqpdtojpiklsiiqgbrhdkjdmjbgrimigpqekeebkeiqapjibdphmbghnkeeqspkkhhmrrsmijqopbhbbbncmihdbidobbmqdtogqbktjscfomddjroskqhbsgrhjebidcsefqiekeekbeiibghhophajicnrjemhpkkhoimkslgjoqjorhmgniqgrqbemecbqfqbbkgjjkijsjfoihdjrmikmkqehqihjtsidopetpeekoejdmmiborhibgcnqqebspkkhqmbksmijqqjgejkonaqdhfbrmmpblfjibkgijplosjfoimdorddkifhjehjhbkdmbdopjipeeomhapeqsqpbmiildkjhfqipdpmskqemebmcnmqkpcjghrbdogjmqhbpfdbhghiqpdioiphkrsmgqdqridkjohibiriqigpoekeejkeiimhkibdjqtbgdnqeegcpkkhpmmrsmijoojbhoginbiipdricbghtqibqggjkrjsbfomadirqskikjegjhjeiidqrefiiepdeqdejibbibqphamiinjoedhpkkhjmgksigjqopqjkmonbotlqogmkjgogoibkgmjrlpsjfoihdjrddkghjeheehdscqdtpemsqekeerreqimpmbohhifghnhqemspkktjmcksmijqtpirikjnbatbeebkmrqbrmjijqggjqljsrfomtdmrqdkikjldpiekemmijjqgjdepmpgpgjgoqmmrmodkkhgogfiemqkoebejiqnkqipkjmopddmmpibhhfbhgigprirosphkqsbgbgjrhhkbqhdfibioigpbeheeirgqibjmbqphihmbnjeeggpkkhqmqrsmijqojdboqhsddiibrtlqrhnqmpcgcjkthssfoibdjrjskmkgedcbdpemqidjieceekqmbippiborhihghnbqejlpkkhqmmcsmijacdqlhjqnhjtdoiqhgcdimbrgbckjjsgfoiidirjqkohpeohgdiemidqpgimjepiqedfhhshicikcpgqajiemhkoeqebmbnbqpkgegqcbbomribphgpgbbghmqjblqppkkcskmbidriikcqbdhmjmibgpqepeeqkeiqfppihdjhmbghnreegsbkktcmbrsmicqopbbbbinpiihdbidobbgqibqgqbkbjscfomfdjroskchfdgjhpemidcsesqjekeekbefdbdmhqphaimcnljeirrkkheimkslgjoqjorhmgnbqirqbmmlpbcfqdcrgjjkmjsjfoisdjrmikikqdhqrhjtsidopetpeekbejemaiqorjmbgcnbqeispkkhambksmijqopgepkonaqdhfbrimjbcfbihkgbjpcosjfoimdqrddkdmhqehphbkembdqpjijgeomhapeqfopbmiirdkjbfogjdpilkqegebmjngokpqjmjjhdotjmqrbpfqdggmiqpdmompkkcsmgodhridkhqhfeiriqigpoekeejkeicibkibhjqthgbnheegcpkkhpmhlsiijqojbhogdnbiidhjiibrhgqibqggjkrjsifomadirqskikjegjhdeigaqrefigekeeqhgjibrmdqphabitnroephpkkhjmmksmijqopohkmonmqtrqoombpgogoibkgbjpljsjfoihdjrddkikjehedbissqdtpeifqekeebrdlmipbbqrhmbgdnkqemspkkhjmgksiijmtqdpjjjncmibecbkgoibofjmhqgbjlcjsqmoitdgrqikgkjdbhiekbiqejpqgjdejgpgphjgoqkmiiodkkhdomlmefqkoeaejmbnhojjkjfbpqicmjqkirsbcghmprtporpdkqsmgqgjrhhkhqhdfibiqigpbekeecrgdiqjioqphdfginjeemmpkkdqiqrsimpqojhboqdsdrihhqthqbhfqijrgbjkdmssfoiadjrjfkikieijbipdiqddjeeheekqibgbpihcbhdhganjqejlpkkhoigksiijaceqkbjqnhmidjhqitrdiibkghhkcjscfoiqdsrjqkqhpeoigkieimdqpgbmcehgqgefrbshmcdkjpgqmjmeimkoeoermhniqpkjegqcbboirijjbdbhbiglmqjkrqppfkqsbibdbrhdkbdbjrghimigjqekeeikeiofpjihdpfiimhnjeedsbkktcmhrsmijqopbbbbbnlaihdbidobbmqmbqgqbkbjscfomfdjroskqhdegphqdimicsefqjekeekbefibhmhqpcagicnljeirpkkbqmmkslgjcqjqrhmgniqgrqbemcpbqfqbbkgpjkgjsjfqihdjrmikmkqehqihjtfidopetpeekoejdmimborribgqnqqedspkkhqmbksmijqqpgepkonaqdhfbrigjbjfbihkgijpcosjfoimdorddkrfhjehphhkdmbdopjmpderdhgpeqsqpimiildkjbfigjdpmokqemepiinhqpkqjgjjbddoajmqhbmcqbbgiiqptmobpkkcsmgqghrikkbqhmembiqigpoekhejkegqibkibdjqtsgdnreegcpkkdrmhlsmmjqojbhoghnbcihbjicdgrsqibqggekrjsmfoiadirqskmkjegjhkeibdtresqeekeehbejihdmbqphaiibndoeippkkbjmjksmgjqopqjkionbqtrqqbgbpgogoibkgbjklhsjfoiddjrddkikjehjehifsodtpdgseekeehreqibpbhohhihgdnhqemspkkdeiqksiijiqjdddpjnbbtbeebkgckqcfbibqgqjrbjsrfomtdmrhjkikjedbgekhiidcjomjeejmjgpdpgoqiiigodhdbgogfibmqkoejejiqnjqdjkmgbpodcmjibhhfbagimpribofphkosrgbgjrrhkhqbdfirioigphehdeirgbmojiqqphibghnjeegmpkkdqmbrsmijqojbboqdsdbmbrrtbqbbfomjrgcjkthssfoigdhrjskmkgedjbbjeiqihjeegeekoibgipiborbdbmqnjqejhpkkhqmbksiijacbqkhjqnhbtbciqbgjdbmhkgbdkjjsifoiddirjqkohpeocgkieimdopmjmqehijgeflbfriqdojcgqmpiefqkoecdbirnoqpkcbgqjbboirihhhqbibhghmqjdhqjpikbsjgtihrhdkhmbiembmmigpoekeekemompjihtphmbmhnreejspkktcmhrsmijqqjbbhbbnlmihcdidobhmqmiogbbkhjscfoitdjroskqhhshjhhdiidjsefheekeekbeqiildbqhbagibncieirpkkhoimkslgjsqjohhmgnhqdrqmgmdpbciqihkgpjkgasjsoisdjrmdkmkqthqhtjeiedopetpeekcejibrmboqhihgqnhqelspkkdqmbksmijoojgepkongqtrsbrmcjbsfjibjgbjpcosjfoifdorddphihjehjhbkemmiqppijeeoiaapiqfopimiiqdkjigqmrdpmdkoegeimhndqpkmjmjjodobjmmhbprlbggbiqptmoopbkcsigbgqridkbohidirtqigpqekeedkegjmrkgbdjqthghnkoecjpkkdpmpssloqqojbhlgdnbmtjkjgcabhtqibqggqkrjsmfoibkirqskikjegjhidmqdgpefbieheebhgjmbhibqjhabgtnhoejhpkkhjmhksmmjoojqrhgonioirqqeispgoiqhbkgojktjsjsoisdjrddkghgehjbhegmodjpeifgeheehqeqmiphkqbbmbmdniqegfpkkdembksbijsqqhppbpnqbhmchgokbjsbmhkgbbkdjsifoiqhirqikdhpehphhpecmdqjojjjegfpmphjaoqbgmiqdkdhfbabiefokoeierignhqepbpgobodsipbbphobhgbmjrdrorphkqsbgbmcrighddhgbgiiqigpbekeebrmbicpibqjhdighnpiejrpkkdeiqrslmjqojdhqqdnihibrrtroghsqibrgcjkdmssfoihkjrjfkikmedjbqjkiqmbjqeheejqgkibhmhqphihgbngqejlpkkhomilsiijdgjqkcqrniqtdidqhblliihkgojrhjsffoifdjrcdkghpeojgggeigmqjcgjeejmpaqrfehlbisiodkhrgqipmemhkqegeqibghopkiegqdbaofrbjmbdjrgbmrgqjhibdpdkosjmbddrhhkbbqdfmrmiigpoekeebkeiimhpmbjjhibgqnjeeqspkkhcibrsmggqojbhbdinbjihdbidobaaqiaqgbbkjjscfomqdjrofkmhplmphdtibiqgesbbekeehbenibribojhmbiknljeihrkkhdiikslgjaqporhmgncqdrqgimobblfqibbmhdkgmsjfoisdjrddkikqehlehjeigdmpdtjeeoriombpmhqrhihghnccedfpkkhqmbksmijoopgepkonbqdhfbribjbcfbmhkgbcrhcsjfoifdordikhmhrehjiikembtmphskkeimpgegjsbjiiqsodkbhiqgodkmhkqedebmjnsqppqjgcbrdgitijrbbpgdhmgmqpdpogrhktsjgqgordadhdhdbmoicmgpqekeekkemjfqbibdjqmbggnoeedppkkdqmblsmijqojbhoiinhaihjlgjjtmmbbbqmmqkrjsmfoiodirqskmkjegjhphiidqrdfibekeekmejibqmbqrhabiinhoemdpkkhpmhksfgjqopqqhgknfqigqjbmopbocqibkgbjrhpscsoitdirddkckefhjehjfsqddpempeekeedqmomdphbqhhmbgknhqeispkkhdibksiijmockjjjjnbbihbqkjiobbjsiihrgqekirssfoihdirtdkckjemjarjeicdqpmgjdejmpgpidgobhimdqdkjpicigmefqkoeeebibnoqpjqrgkhpdoshmjrbphhhggbmeciborpbkqsmgbmjrkikjeqhhbihiqigpbeddtcqgciqlihokbibggnpeegmpkkhemmrsimjqopdbqobnhiihlqthhbhfqgmpghjqbefffoigdjrjmkmkjetjbbjeiqddjiedemopghaqphbqbhimghnbqepfpkkhimbjsiijoqkqkjcbnhldkmhqbtjmjihcgqjchigjfoifdqrjqkghpeibmkembiqjgmmbejipghpmekdcibiomklrilgjgesqkqeqehmhngqpkgegqjhjfiofhqbjrqmbghmqrdqqjlkkqsbimgprditomdiembimbgkeehqeqkemofpjmqdphimghnpiejprkkkjmbtshmjqojbhcbrnqaithhidobbfqiergiqpdjscfoiodjroskihcegihhmmidqlcfomekeekqeimsribhpkahgbnpdeispkkhjibkflijqqjorhmgncqirbhemhkojsodbkgijkgpscfoisdjrhdkghhehpehqfbgdiheipeekbepsmpibojbmbgqnreegopkkhqmikshmjqockrjoniotrfbpihjtcsbibkghekposjfommdordikbmheehchhkmmabopjrieemijfkejsfpkgmmqhkjhgomqdgickoeieoibnfqpkijmjqoarajmbrigkhbhgfiopdboplokisbijdqrdhkhdqdjmqiqicpbekqiikemofbrmbkjqabgnnpdegrpktdemblsmmjqojbhogdndgmjpqtjdchsbdmqgmrkrjscfoihdirqfkikoegphpeiidcmcsbiepdekmejehrmbkrhmbgbndoejhpkkhjmccsmgjoojqqhboniqimhqoemhjbofqibkgbjkrjsjfliadjrddkikedhkmhogmqtojeireekeebiiqibpbhqbbihgjnhqeifpkkajmmksmmjatqbpgkpnlqirdjdtiqbosbibpgcdkjjsqfoihdmrkdkqkphtjibkbmqdipogbdejgpmpdrfqcbliiodkdhmogfmdsckoebebdinhqephrghgodpmlbbphfhbgbijrtrorpdkqsbgbijrrhkhqhmbfbiqigpbekeekembfqpibokhdbganpdeggpkkdomllsiijqojdhoohncimhjqtbocmfqirpgdjkiessfoihdirjskikjesjaejemidbjcedeeoogpiipbhqhhdigdngqeplpkkhombksggjaocqkhpgnijdklbqcgbfbijogijqbjsjfoiqdqrpdkshjeojdfhhimmqjecmjebdpgbkmbrcgmbtqdkhefbmpiemhkoedeqibnqgjjaogqjbpoihmbbbqpobbgbiqphaokphkosfgbgjrbdkiqbfhibiiimkoekeibkemjihhihdjhtighnkjeqpkkkbjmbrsmijqojhkbbdncgirhhiqobcmqiblgbqsajshfoihhjrofkihqegjhdemmdjlefieehdeboejislihdrdahmonjjeslpkkhqmmksnijqqjorbmgniqjrqietgjtrsqibkgijkgjscfobsdgrddkihqdhjdhoemadcreipdekoejibpibohbihgmnhdedspkkhqiiksmmjoqeihjikpkongqtrsbmihprffbibdghjkpbsjfoigdqrddkimhqkhjhbkeibtopjsdeeqdjgpdoglkpgibmodkhpgigpddikkqejeqmmnbqkpqjgpgtjqihgcsbkqodbdimqftpohphkqsbgbiqrdhkbqdihiaiqigpheketkqgbihoibcjqtbgdnhgecjpkkdjmblsmijoojbhogrnimijkjtebghsiibogmqrrjsmfoiodirqskekieijhjemidorhfbmeheekmejjikbkqjlmmmcnbqejhpkkrjmhrsgipqojqjhgonboirqpsiispbogqibhgajktpscfoibdirddkrhjehjohrfmhtojehsbekeehdeoiipbbqlhmhgdnbqeaspkkbpmiksigjacjqpbpcnsoilbrdbmorbjfbiepgqakcqshfoiddiriqkahjshjhmdjmjeijomjmepgjgdppgqqbibmodkdhgogaihihkoeeeimbnhqckmpgdhodmmpbbjhshggmipqirospdkqsbmjdjrchkqqhdbigiqispbeketehiqiqjihophibmbnjmebmpkkdemrrsmijqojddaodfqbibbqthqbgsomhkgijkbalsfoigejrmskmkjetjbhpdigihjiegiedqgjiipibqhbibgdnjqegspkkhogbksigjdtqdkbjonaqiibgqebigjlbibhgrjkjcsgfomodcrjqkihjeojbibdibicpgoigebmpghbaecqbmliedkoeijgimemdkoeeeddhnffdkhqgojhjoibijblbqidqgbmojbbmopbkjsbgjgqribkbbhjbmqimmgpqekeebkemqmpjmpdbhmbmhnjeejgpkkdeghksiijcopdloekngeihjhibohbfqfbogbjkrjsifoiddbrofkmkhsgchjimjtohhmomekeejbgcmfpihopkabgbnseejppkkhcibksmijoqjiodponioirqieibabosohbkgbjkgjsjloibdmrdokhkqehoehqemidapemdeekqecreoibpbbobhihgdnhiejpjkkhqibksgmjacqipcljnbqtrbbebqmojsbgblgeckdjsofoigdtrdkkekjedjiekbiqibjagjsepsjgpjoscjkmfiockkimogbmemqkqefemtqnbqjkcpmhqodamdbhjblbjgimqjdpokphkbspgigjrqtkqqdismqioimkherhejkegjsppmciohioihnoeedppkkdpmgksmgjoojieqddnsbmphoiokbhgiiqkgqjrijslfoihdjrcfkmhqegqhjjeibeqbegreejeehreejigpibqhhihghnhoeqppkkhoibkssmjoqjbhbpqiiolrqbcmbbbasbibkgiepdjscfommdcrpikghjbhedhjeiitqpefpqehcekjgjmghmhqphibgcnjqejtpkkqjmgksnijsochkphdnqqhrqjomqpqcfbmkkggjdbjsjfoifdjrjbkghoeoobdahmqbqgbhkjdekmoqjaqpibbqgkjddcghtcmikoegepmqnsofkqjgmchoqsqahhpkoblbgbiabjjcjpjkisbtmdbrjikjijbhhqgggcdbecfleksegqjqsskdikhbgogliasmkoeiedabnflkcqggcrhjrmbmjrbjlsblgiaqricoqbldkqsqicghrifkbipdmgpijmcpqepqebkemimjdggqrhdimhnqeedppkkhnmbrsiijqtjdqjkdjncgihhdmhibbtomirgbjrdkssfoihdcrbfkmhpegjihhiimmqhefjqekdekqebmbdibqphtiidnqeedhpkkdqmorssgjqojqqcrqnmhibbjjmojbifhiqrgmjkgjsjfoiqtjrgkkjhjnhjmhjembeqhpiemcdelfqjjgorgrioschrdbgitqibkleqemiqnsockqjmmdpkgqsomcjfqkkslcgmmdhibpppdbisciodbrckkhihkbdhgjijiedqmlgeqbgjkakdildgokjiihmqmefhkqepeimbncqkcpgmprrklscimibohfbhgiferkijoqpdkfsiitdqrofkmpcqbijgpidpiepeeokiqihpdhophirgbnbjedhpkkhqmbrsmijqtdbbdjongoikcdojbosbimrgfkqbhscfoimdjrqfkghqehjehjebmbqjpqbodarspjjipjbojihabqdhlhhbqjgsjqsamdjpgkokjfkmilotijbhhqqbsadqfiqiqkbpcigiqqjmhmgrmdolormglgljhfjhajjgiamfjfmhkgpmfjomrbhdfjgrjojmihsilcitjdgcfglhlrmklfpmoejrmmscboohhbmqmmjfkcdocgqekprfoggfbdejssdejilclpiihbdbpanhgkbgisigghkmrefgdjbrccmmjrmardjsbfpjjdfqjmhmjdapfipoggiqjoqhoabdhjdgclengqcqmjoihbqimobgqloosslbgmqqpgraiihddomhtkkdmohcqkihidqiqidhmjmkeihkcmaldikjjkkliqsitqmjrspchbcibnsfkiocgjrhjqsjmbsjpkidmgsiqpmbqgppkbsotqiirpskjphhsdjgfiqkiojispsstoobaqqmqoobpbaoggjoeejfbgegsrqbdsikjriofkibmbilejelibnsqhkcqmqekprpqqsbfjhpqkgscgbmrhibbpppdjsbiidorqskjphtqdqgbibgleeebphbgoeafqoggdrdjtcjkchitfjmoihkmeeebgqnjqpkceghgkermjmmljkgpssdglmopbgejpbkssoibdbrbdkhbhtcdlgcijogosqqcjfqhqjjljolicqcmpqbgoadjmghkbjhiegbcidqjdgojddigsqedihbqbiqkjfogjmjjqqjjoqgoaespiejeoqsqcbbmjjpcomqcfieahpaqnsqqmopcsjaekqgpoiicqoeqomoghonjcfsiaegeombpcsoeqnomeqghcppgjmioedooobehepspfssoeooohgkpmhpjjgggemppsgdaqobjjjogogjjjgjgkfhdheehoheelfjghhgoshhecdliqijjboqrfoshbslmebqdjdhbhsdjgojoldcddsoceqcocomadjojpjjggoeibbbclghjsqhjgpfahqjjqhoqqhoocojibjmbjmjjjsjmhqldcojhhhhdhoggoooohghebsmjgaoeihjgmohoecedjjsjppbjoohebejoboeoheheihhjohghofjohdofpmfhosjhaqddgqbcqbhjoqsjighccefbgpldeombgoaohloietkcrbofmgrichqebdjiqnslrkijgcjhhqmlsbrbhkigbgjmgptlbpphkbsoditbrsqkjdhpsdbgpibkkpsbbsdhcoopjjieohifejgbobjdsdiehfqqbhjajdhhhiojiqhcabjbojhghhsjlhdhdjaqhddgjjqhgjjqhbboqmqbbgddomgbqeohabisjkjhdofhtpbpkjeiebibngoqkcighbhdolcibbbqsqhbfjmhhicdhpjkrshiiijrhjkqcjdjfbgbmcqdoibjqdibheeoiqhejeoiqhejdiqheqoiqhejehleqdihebjbqebeojqiclgeihdeeqmbcfgqdjdhqjmdqgbtiijhhigodqjibnsqpkqqgqjrklfcflshdpkbsjgqmrrgbjhpckjsitjmhkjkkbhqbrgcfakcdfqhmljqihqmhjbqqhpcqbbjhbiboqbjeqdejemhhqeimibkgcpbbihhphidqfdiqdbkjeoebdmnbqpkqdmbckkqsqghjpqkkffgjmlqbpbhphkgsbtbiqrhdkhihhhtqgbmqdmqpbjdcqihbcqbhjmbecqqdiicjjmhcqdgohjjmqahjdqhcjqgdgqjjdhqigmhjjiqqhddbhgjqhmiljjmbqbhcdhjjiobldjmqdfhbcahmrjkcogigqdrmdkdbpiqnigrkijgbrhjjsoskihkhpcbgbmqcdhlopjkmgbtmhqbqjkmiqtcspgbghqjghpdedfmhceohcrmrjkcrigfbtjmhkjehejmjnfqrrgemhmhhrihmhohorishgjmordhihphkqsbmqdqrfokcthdbdhgaigegijjehojiigobhkpbhgckhfhhchicahdhqcjdhfhhfhhhhdhhabjaqfdhahdchahhacjhfijahhhhfakmhrabcgjhhbhqagqdkmokmeeqmjdgehpmhmpjkqigbidtdfbkjebejibnhtkkoqmlhcjckoflmjrbppgbbgmmapicqcpkkgsbghgkrjfkhphdbirmlmohu";
string str_titin_out = ""; //An empty string to hold the regenerated (expanded? decompressed?) Titin string
foreach (char component in str_titin)
{
    str_titin_out += SwitchChar(component);
}
Console.WriteLine(str_titin_out);

static string SwitchChar(char input)
{
    switch (input)
    {
        case 'a':
            {
                return "methionyl";
            }
        case 'b':
            {
                return "threonyl";
            }
        case 'c':
            {
                return "glutaminyl";
            }
        case 'd':
            {
                return "alanyl";
            }
        case 'e':
            {
                return "prolyl";
            }
        case 'f':
            {
                return "phenylalanyl";
            }
        case 'g':
            {
                return "leucyl";
            }
        case 'h':
            {
                return "seryl";
            }
        case 'i':
            {
                return "valyl";
            }
        case 'j':
            {
                return "glutamyl";
            }
        case 'k':
            {
                return "glycyl";
            }
        case 'l':
            {
                return "histidyl";
            }
        case 'm':
            {
                return "isoleucyl";
            }
        case 'n':
            {
                return "tryptophyl";
            }
        case 'o':
            {
                return "arginyl";
            }
        case 'p':
            {
                return "aspartyl";
            }
        case 'q':
            {
                return "lysyl";
            }
        case 'r':
            {
                return "asparaginyl";
            }
        case 's':
            {
                return "tyrosyl";
            }
        case 't':
            {
                return "cysteinyl";
            }
        case 'u':
            {
                return "isoleucine";
            }
        default:
            {
                return null; //do nothing
            }
    }
}