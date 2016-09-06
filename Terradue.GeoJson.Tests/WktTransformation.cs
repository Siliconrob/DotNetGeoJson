using NUnit.Framework;
using System;
using Terradue.GeoJson.Geometry;
using System.Collections.Generic;
using System.Linq;

namespace Terradue.GeoJson.Tests {

    [TestFixture()]
    public class WktTransformation {

        GeographicPosition Position1 = new GeographicPosition(10, 124);
        GeographicPosition Position2 = new GeographicPosition(11, 124);
        GeographicPosition Position3 = new GeographicPosition(10, 125);
        GeographicPosition Position4 = new GeographicPosition(10, 124);


        [Test()]
        public void MultiPolygonWktToGeometry() {

            MultiPolygon mpoly = (MultiPolygon)WktExtensions.WktToGeometry("MULTIPOLYGON (((-111.74531396699982 45.800278025000104, -111.74395898100003 45.799458047000122, -111.74420088647771 45.799690752098272, -111.74531396699982 45.800278025000104)), ((-112.1310830070001 45.787489974000046, -112.12902403499993 45.787670984000194, -112.128794054 45.788370957000041, -112.1310830070001 45.787489974000046)), ((-112.57685102500002 46.178858967000089, -112.57069400099985 46.176959947000192, -112.55682105799977 46.175464062999971, -112.55411693499993 46.177871015000129, -112.55349000099997 46.179476040000175, -112.55223295700014 46.179577994000176, -112.54923400200012 46.176872032000063, -112.54415802600015 46.17520299399996, -112.5398089320001 46.174870055000014, -112.538892013 46.176607953999984, -112.53183695799979 46.179383947000012, -112.52879404600007 46.183329069, -112.5244439490001 46.185402079999918, -112.51332694200016 46.184701939000128, -112.50979799299985 46.183598995999972, -112.5048199590001 46.184134005000153, -112.51675193100004 46.1658840550001, -112.51675193099994 46.164347055999961, -112.51452799400009 46.161339076000068, -112.51438291899996 46.159868930999991, -112.5124020009998 46.158999982000005, -112.51225592199992 46.155222999999907, -112.51399398900001 46.151545967999944, -112.51365603600001 46.148871929000045, -112.51568392000007 46.146299009000167, -112.5159239299998 46.143524019000083, -112.51790401199997 46.141384989000059, -112.52036495000003 46.135603021999906, -112.51964007299975 46.134667050000068, -112.51693594900011 46.133396970000085, -112.51307105399985 46.128316982000023, -112.51311902199983 46.126379017999987, -112.51456693700014 46.125042083000096, -112.50877193400015 46.123940978000164, -112.50533307299989 46.122271940000182, -112.50228497900004 46.121791920000007, -112.50202307399987 46.120915950000089, -112.50395000700006 46.116254977000004, -112.50273892600006 46.11352595000006, -112.49555300100016 46.111385081000044, -112.49534892599982 46.109381934000147, -112.49406798099973 46.108728927000037, -112.49370596100023 46.107562973000135, -112.48807308100002 46.107359065000175, -112.48566395600017 46.102793026000086, -112.48340391799984 46.102652964, -112.482133001 46.101268060000059, -112.47573095300007 46.099234995000025, -112.47254196300008 46.0992729360001, -112.47215002499999 46.09810798500007, -112.47050505400017 46.097354026000161, -112.47041797500003 46.096310919000196, -112.466109997 46.092622019000181, -112.46727193899993 46.089914051000171, -112.4688879949999 46.08841098099996, -112.46794700900001 46.086938998000171, -112.46909691699996 46.083728948000136, -112.47131099299982 46.082115064999975, -112.46877500999975 46.080599959999937, -112.46697794399995 46.080913010000188, -112.46527698200012 46.07911594299992, -112.46511201700004 46.077404953000027, -112.46159894600004 46.075316063999971, -112.46187706400002 46.073286008000132, -112.46283793900008 46.072063060000026, -112.46492298400001 46.071306929000166, -112.4655860199999 46.070191951999952, -112.46516199099977 46.068901982000106, -112.46809893699974 46.065064997999968, -112.46868208100005 46.062049999000067, -112.47100095199974 46.061039985000008, -112.47039206899984 46.058435977000073, -112.47173803000013 46.055871079000021, -112.47604099399986 46.053709987, -112.475834077 46.052688941999918, -112.47712204099993 46.051336964000022, -112.47254797999986 46.04775603500012, -112.47217693399992 46.045087011000206, -112.47411305900022 46.042076022000145, -112.47302098000003 46.040543033999924, -112.46666305600003 46.041120997000192, -112.46518505599998 46.040909065999955, -112.46413593199991 46.039855929999916, -112.46233502099989 46.039961059999989, -112.46132300200019 46.038009057000046, -112.4581779690001 46.035696036000175, -112.45679105899983 46.035653918000165, -112.45277005599991 46.033842978999949, -112.44622493800001 46.033692053000053, -112.44413304100013 46.0308879820002, -112.44242505899977 46.03009106799999, -112.4434589739999 46.024721931999977, -112.44233898299974 46.023231061999972, -112.4394379709998 46.021405080999976, -112.43979698299997 46.020168930000118, -112.43886502300019 46.018968044000175, -112.43960393899987 46.017309034000114, -112.43586807399997 46.014455990999927, -112.43770592200012 46.012421922999906, -112.43982305700011 46.011790978000121, -112.44204097599999 46.009236944000151, -112.44439895700008 46.005093930999941, -112.44486493699998 46.002205956000026, -112.44401604400019 46.000691019000087, -112.44534997099996 45.998027008000172, -112.44404997299981 45.996627062000094, -112.44365001199992 45.993626937000151, -112.44255007799983 45.992626952000009, -112.44274997499987 45.989126918000025, -112.44075000299979 45.985327039000005, -112.44095006700007 45.98112703200006, -112.43854996799978 45.974726988999954, -112.43804905600012 45.967726921, -112.43554900799981 45.965827065000141, -112.43594896900021 45.964126939000032, -112.4341490609999 45.962927056999931, -112.43394899699979 45.961327046000044, -112.43014895100012 45.960126996000042, -112.42974899000002 45.958727048999911, -112.42994905399988 45.958226973000222, -112.43204897400015 45.957827012000159, -112.43194902499998 45.954726939, -112.43334897199993 45.952126942999975, -112.43324902399989 45.95072699600005, -112.43014794800011 45.944926977999963, -112.43364798199993 45.94252704599996, -112.4361480299999 45.93952692100018, -112.43364898499976 45.937427000999996, -112.4311489370001 45.929527064000133, -112.42545003699989 45.928328017000119, -112.42384802100005 45.926628058000084, -112.41834701300003 45.924726029000105, -112.41614697700014 45.922326931999912, -112.41754592100004 45.9202280150002, -112.41754491799999 45.918928017000084, -112.41974695899994 45.917627016000132, -112.41834701300017 45.916027005000068, -112.42114707300011 45.912127009999956, -112.4209470089999 45.910626948000129, -112.41914693399998 45.909427066000077, -112.41514699100014 45.908527027999959, -112.41504704299996 45.903726995999946, -112.40874694900008 45.901627076, -112.40964698600004 45.899727053000163, -112.40594705500004 45.892227076000012, -112.40614594899992 45.890427002000095, -112.40404602899986 45.887326929000047, -112.41094598100007 45.883625995000109, -112.40934597099979 45.879326040000009, -112.41054602099986 45.877825977000015, -112.41094598099991 45.87492596900001, -112.41293492200003 45.873682963999933, -112.41578194800013 45.873005053000043, -112.41787200700011 45.871183919000067, -112.41692500399996 45.869299941000193, -112.41904397799992 45.86693594300008, -112.42290502899995 45.865954009, -112.42493307999992 45.86462793700013, -112.42487006899981 45.858958955000055, -112.42843595499983 45.857244957000134, -112.42895993200007 45.855644946000105, -112.43046500799993 45.85452495500013, -112.42807593999986 45.850776053000139, -112.42810903300001 45.847141975000085, -112.42699806799999 45.844192994000039, -112.42552591799996 45.84279906500015, -112.42160202199973 45.841997973000012, -112.41578094500004 45.83744797899999, -112.41172701699986 45.8358700310001, -112.40845696500011 45.83529791799991, -112.40034893999997 45.831363994000171, -112.28968997599983 45.795009004000235, -112.28327205000009 45.790929001999984, -112.27915494299987 45.790517007000211, -112.27529907300017 45.791315926000117, -112.272880922 45.790902928999955, -112.27026905900016 45.789416070000087, -112.26618805399995 45.785437019000106, -112.2657660309999 45.781802941000208, -112.2637409889999 45.780773037999957, -112.26322102299991 45.777206984000173, -112.26234004000001 45.776041031000169, -112.25427697499985 45.770755964999992, -112.2504769289998 45.770752956000081, -112.24716793399992 45.772178976000191, -112.24157700499998 45.772298980999985, -112.23487594800012 45.770581974000123, -112.23382097299994 45.76924804700014, -112.23223466800005 45.769025252000013, -112.23100403199984 45.76758101399998, -112.22584298199999 45.765690016000043, -112.22334193099984 45.765186931000045, -112.21792098199982 45.765553965999949, -112.21651702399991 45.7661030140002, -112.21374002899995 45.765669959999911, -112.20783103699988 45.759825985000184, -112.2040309910001 45.757426051999971, -112.19993093200016 45.755826042000074, -112.19393001499986 45.751226073999973, -112.19161398599994 45.750203023000026, -112.19167900199994 45.749732028000018, -112.19052892700005 45.749926076, -112.19027303900003 45.74849905300006, -112.18732706700007 45.747583972999948, -112.18176806199996 45.748295980000009, -112.17993907200005 45.7492100570001, -112.17941392500008 45.750277064999935, -112.17716107400007 45.750950965000094, -112.17441800800005 45.750606995000034, -112.17285292899997 45.749546003999981, -112.16772697800018 45.749614029000114, -112.16422894999992 45.751337053000142, -112.16429396700009 45.753714923000175, -112.16292092900007 45.755223008000016, -112.15276195599995 45.757754980000236, -112.15082800400013 45.760825971000124, -112.14542794700012 45.764725964999862, -112.14432801300016 45.76642592400011, -112.13692798500003 45.771026059000135, -112.13722799699997 45.780625956000023, -112.13472794900009 45.782625928000144, -112.1333280020001 45.78602601299999, -112.1309320809999 45.787804026000074, -112.12866301799993 45.789111044000052, -112.12878502800011 45.793211938, -112.12638292299989 45.793359019000079, -112.12455192799989 45.79448602999998, -112.12319393300004 45.795761959999908, -112.12247891700014 45.799122935000085, -112.11744706499998 45.800291062000007, -112.1160449460002 45.8031499550001, -112.11402006999995 45.805230988000204, -112.1125830189998 45.805802934000091, -112.11330405199992 45.807746078999941, -112.116897014 45.811467069000116, -112.11876695299998 45.812428946999958, -112.11710292800005 45.815972938000144, -112.11808101899992 45.817825995000142, -112.11772902700014 45.819698942000016, -112.11626005199997 45.821665987999921, -112.11547801400003 45.82447808199997, -112.11701802200018 45.827699998000178, -112.116365014 45.82884405699987, -112.11437105999975 45.829644981000072, -112.11443707900014 45.830238989000044, -112.11820002099992 45.832659981000013, -112.11807099099978 45.834488971000077, -112.11211804199982 45.833599964000065, -112.11061396800004 45.833897971000006, -112.11114396199984 45.837304074000087, -112.10639206599983 45.837063061000173, -112.10544907399992 45.83748892800002, -112.10515608200006 45.839067044000032, -112.10734792699994 45.840346985000075, -112.10600898600006 45.841466976000106, -112.09779700200012 45.838222997000031, -112.0948540389999 45.838726917999978, -112.09439791900014 45.841792059000021, -112.09096507500016 45.843575921000053, -112.08923302500011 45.846411081000028, -112.08894003299982 45.848970963999967, -112.08570307399992 45.851508953000213, -112.08475406499981 45.85080095699994, -112.08537498199991 45.84970302800015, -112.08485100500003 45.848812015999982, -112.08187294299982 45.848194943000109, -112.07503700500001 45.849841920000074, -112.06947699700004 45.85258598899992, -112.06744794299985 45.851352010000156, -112.06568196499984 45.8516939740002, -112.0630319940001 45.851145928999884, -112.05953095800008 45.852769004999864, -112.05848400599994 45.85061994600008, -112.056947006 45.849934013000158, -112.05269401700001 45.851717039000143, -112.04916205999984 45.84988805000004, -112.04713400899986 45.849773058999958, -112.04615207399988 45.850253078999991, -112.04628294299982 45.850847922000035, -112.04965194100008 45.853042944000137, -112.04935694199993 45.854276923000086, -112.04485408099985 45.855687065000083, -112.04278892599983 45.854097917999972, -112.04059006000007 45.854207059000139, -112.03908398099983 45.855784005000125, -112.03941106999991 45.85777294500005, -112.03761099500012 45.858573033999946, -112.03659696999998 45.85848094099989, -112.0357789969998 45.856744044000038, -112.03443804999985 45.855897993000191, -112.02233091899978 45.859049042000109, -112.01758704500006 45.85842996400018, -112.01601795499991 45.856440020999976, -112.00859302299983 45.855819939000135, -112.00754707400009 45.854698945999971, -112.00784407800005 45.852002009000095, -112.0060130830001 45.850698000000079, -112.00249499800017 45.8503219400001, -111.99997907200013 45.850878007000112, -112.00021607399988 45.852021063000173, -111.9979919699999 45.852409993000016, -111.99828496299996 45.850879010000149, -111.99956005800011 45.850625962999956, -111.99864096599991 45.848592063000083, -111.99245903900002 45.848686996999973, -111.99072598600004 45.849579011999907, -111.98487398900016 45.846596938000111, -111.97717996499986 45.847795985000225, -111.9767759930001 45.850115022999908, -111.97429098699983 45.851374072000034, -111.97306386099979 45.850780063999977, -111.96982305799985 45.846994057999964, -111.96769405599993 45.846067947000193, -111.96543802899986 45.846959962000163, -111.96527506999981 45.847806013000181, -111.96720501099995 45.84985094500005, -111.96728105800011 45.850777056000005, -111.96485003800007 45.85276900500002, -111.96332106099983 45.852661034000143, -111.95986097299996 45.851058015, -111.95753892700009 45.850987984000028, -111.9527810139999 45.853249024999947, -111.95124401399977 45.854757945000195, -111.94807507999995 45.855749073000176, -111.94519696700006 45.855903006999966, -111.94342597399987 45.854029057000012, -111.94194396300001 45.853615057000219, -111.93383894699988 45.8543700180001, -111.92992106800001 45.857208019000026, -111.92817899000003 45.856883938999985, -111.92690406300004 45.854163936999896, -111.92485996699993 45.851926963999922, -111.92219495399995 45.851157963000055, -111.918810078 45.848359073000104, -111.91793193600006 45.846898955999933, -111.91868505899983 45.844495012999978, -111.91806297199979 45.844661982999952, -111.91667606199981 45.84290503000004, -111.91718900800011 45.843117964000115, -111.91141305800001 45.840472003999949, -111.90970892100007 45.839078074999968, -111.91067297200004 45.836158009000137, -111.91389505499986 45.832886953999974, -111.91320494300018 45.831049942000028, -111.91068801399976 45.829015039000083, -111.90748398200017 45.828374064999991, -111.90284005599975 45.828647001000064, -111.890574979 45.8310659870001, -111.88380706599989 45.830468971000172, -111.87916497900004 45.82779192400006, -111.87665406799979 45.821984051000037, -111.87215505100004 45.818024054000034, -111.867099966 45.820547000000118, -111.86438598200014 45.820364986000186, -111.86176893699991 45.819383052000077, -111.85065493899985 45.820135005000225, -111.84290592700009 45.821250983999988, -111.83815102199983 45.821159058, -111.83456507900013 45.820319024000192, -111.82805907100006 45.816650013, -111.82537801300002 45.814432930000088, -111.82055591899987 45.813268982000125, -111.81288596299987 45.813617965999988, -111.81085506999986 45.812948077, -111.80661394700005 45.808878939000188, -111.80733297500001 45.804947021000139, -111.80576405099983 45.799523062999938, -111.80295396300015 45.795734048, -111.80063392200019 45.794864931000163, -111.79592798900012 45.794956022000022, -111.79377107499988 45.795526964000182, -111.78829396700013 45.792554082999949, -111.78206708000019 45.794610046000145, -111.77483001099996 45.798678014000188, -111.76383601700002 45.799911992999931, -111.76094904499983 45.802448979000168, -111.75612093400017 45.803527018000096, -111.75823505999993 45.8035340380002, -111.75703701599997 45.804207937000108, -111.75490299999984 45.803639000000061, -111.75050326299993 45.8035703060002, -111.75064098499996 45.803136081999931, -111.74616703899974 45.801582035000017, -111.74420088647771 45.799690752098272, -111.74042602099986 45.797698921000006, -111.73820292000005 45.7973079849999, -111.73128792599982 45.79753195000017, -111.73014403399978 45.796891979, -111.72769797200007 45.793103967000143, -111.72626292600002 45.793184026000205, -111.72426796899997 45.794223958000067, -111.72008400700014 45.794387919999991, -111.72110705800003 45.794100943999965, -111.71571201499995 45.795088060000147, -111.70731601200011 45.7954589389999, -111.70062097100022 45.798432990000109, -111.69744902900007 45.801421917000127, -111.69611192599993 45.804364043999925, -111.692525983 45.80652396699994, -111.691153949 45.809107081999969, -111.68961694900005 45.809039057000128, -111.6908270269998 45.8115310820002, -111.68997696399983 45.813130926000113, -111.6824310239998 45.816000014000096, -111.68360851000017 45.816099461000093, -111.68086176700002 45.817855745999921, -111.68323194899978 45.816821998000023, -111.68127994599982 45.818435046000133, -111.68042904699979 45.820125978999961, -111.68127894299998 45.822777956000088, -111.6789580670001 45.823257975999937, -111.67545903599988 45.822915009000113, -111.67906704100005 45.824757035000168, -111.67474903399979 45.827563948000133, -111.67406995300017 45.829882986000008, -111.67467298699992 45.831454082000171, -111.67364793000002 45.833138998000109, -111.66910395299979 45.833680024000053, -111.6670200789997 45.831829974999962, -111.66541705900005 45.833360957000124, -111.6617540659998 45.833016987999969, -111.65999794900003 45.833525922000057, -111.66044303700002 46.049456996999915, -111.78433397 46.050006044999954, -111.78451899199999 46.123110972000013, -111.78390492699981 46.124927927000037, -111.78374999099988 46.136165942000048, -111.78573107599995 46.136158923000139, -111.78504096299996 46.165469051999942, -111.78607705099979 46.249928989999972, -111.7860130370001 46.475704986000054, -111.78608808200016 46.48582000199999, -111.78774207799995 46.485794931000108, -111.78787796100008 46.569124015000007, -112.02931092999982 46.56909593600016, -112.03203293699991 46.566437941999936, -112.0332289749999 46.566369917000173, -112.03354302700016 46.564330000000133, -112.03114994700002 46.562414934000053, -112.02928101199983 46.557781037000105, -112.02997998200006 46.556495079000207, -112.02982003100011 46.550548981999924, -112.03203995599995 46.548825958000208, -112.03395201299972 46.542721080999996, -112.03660900400014 46.541057055999978, -112.03758391899999 46.539625019000006, -112.0395260610001 46.53899206799997, -112.04064404600004 46.536460932999965, -112.04259404299981 46.535661011000215, -112.04399298699991 46.533893026999941, -112.04638105299995 46.534199055999956, -112.04850804900011 46.532261927999926, -112.05042394999994 46.5321950729999, -112.05298901500016 46.530671946000169, -112.05733894500015 46.529525046, -112.05795100299996 46.527982029000015, -112.05969308100005 46.527264005000063, -112.06337295499981 46.523805923000033, -112.06700903899981 46.523760962999937, -112.06895001100006 46.524457928000146, -112.07173101799995 46.524058970000212, -112.073067954 46.521509950000159, -112.07605604399988 46.519645026000148, -112.07830304600006 46.519960080999958, -112.08357306899978 46.516476927999989, -112.08458207999999 46.51639402799993, -112.08520600600002 46.517393011000166, -112.08758705200002 46.517996044000093, -112.08928500499979 46.51683594000005, -112.09243906400009 46.515861025000149, -112.09662703700005 46.516179924000049, -112.09810403399985 46.515672995000031, -112.10332893100012 46.516174074000084, -112.10575894799993 46.515664972000174, -112.10832401200005 46.516185941000124, -112.11111404499992 46.515656949999908, -112.11302593399981 46.517245929000062, -112.11527795000016 46.517563993000159, -112.11851106500004 46.516146998000188, -112.12026901999987 46.514583925000188, -112.12174702 46.515618006999929, -112.12252103599998 46.517821051000091, -112.12478792699989 46.517705056999979, -112.13197401900007 46.520224995000163, -112.13455295600022 46.522265079000185, -112.13737691700004 46.519867987999923, -112.14342095599973 46.518118055000052, -112.14762798299992 46.515097038000192, -112.15052899399991 46.514156051999933, -112.15231101800018 46.51146697099999, -112.15756800499987 46.510746940999979, -112.15974096399984 46.509543047000051, -112.16214507499986 46.50967491900014, -112.16727002300016 46.507948051000007, -112.16947992000001 46.50790994299993, -112.17269598600004 46.506214998, -112.17687994800013 46.505630016000147, -112.17838201600003 46.504878063000127, -112.17953794199978 46.502563036000112, -112.18352702100007 46.501204037999919, -112.18733592499986 46.501113950999994, -112.18839892200003 46.499210919000049, -112.2006730239999 46.497951034000124, -112.20275606400011 46.4985390250002, -112.20520095599994 46.498230989999996, -112.20432799499991 46.496464008999958, -112.20462499899986 46.494840932999956, -112.20327402399988 46.492919015000041, -112.20335692400012 46.490475960999973, -112.20165897099996 46.486778036000182, -112.20107098000004 46.483659075999959, -112.20183597 46.481155017000148, -112.20152693200009 46.47894194500001, -112.19670099299975 46.476387075999959, -112.19344498100014 46.476289969000021, -112.1917349939999 46.476911052999981, -112.18711998299987 46.476667031999973, -112.1848460729998 46.473973939000018, -112.18208495500016 46.47404397000011, -112.182104009 46.472705029000188, -112.18032599700005 46.47128201699995, -112.18102897799993 46.469749029000006, -112.18049296700005 46.468158043000059, -112.17709906599998 46.466790020000147, -112.1766449520001 46.462973929000157, -112.177296957 46.460546920000134, -112.17501803299993 46.457444006000067, -112.17678802200012 46.455718976, -112.18920001400001 46.4501689960002, -112.1908429790001 46.450887020999865, -112.19298200899992 46.45080595900005, -112.19519892600007 46.452098937000194, -112.19860703299987 46.451627942999977, -112.20325797899999 46.449226004999964, -112.20705000200003 46.449025941000187, -112.21553993599991 46.45014091700007, -112.21741505599995 46.448049019999928, -112.21680099199978 46.443255005, -112.21892397700013 46.440797076000131, -112.21934800500003 46.43825607900007, -112.220991973 46.435324982000004, -112.22206600100009 46.434933044000161, -112.22385604699998 46.435451004000221, -112.22589897300017 46.431718983000025, -112.22673198900013 46.43119099499998, -112.23082001300004 46.430725014000181, -112.23156494699995 46.429525967000195, -112.23380593099994 46.429043942000163, -112.23412299200005 46.427104975999995, -112.23598708000013 46.425748986000144, -112.23945402000005 46.424474058999962, -112.24144195800001 46.424692006000022, -112.2431559569998 46.423636029000008, -112.24817393700009 46.422508015999938, -112.25210200999989 46.423568003999925, -112.25566906599994 46.420446036000193, -112.25765499799998 46.420425979999962, -112.26372594700018 46.4184930310001, -112.26680195200014 46.415969916999906, -112.26991506100013 46.414485065000044, -112.27163992400003 46.416169981000174, -112.27569702800004 46.417067010000096, -112.27761292899989 46.419154061000107, -112.28342197300013 46.419125982000075, -112.28570507599997 46.418337927000174, -112.28704802799993 46.419551013000117, -112.28736792999985 46.42142696800007, -112.29448699999982 46.421305960999987, -112.29540207999995 46.421814060000081, -112.30364498399985 46.420360963000135, -112.30754999299994 46.422058917000008, -112.30900292200005 46.421934065000166, -112.31299801799993 46.419316017000185, -112.31535098499997 46.416218953000048, -112.31700097000009 46.415693972999954, -112.32119094900013 46.412741983999972, -112.3244900829998 46.4120259660001, -112.32605699999991 46.410027999999976, -112.32907199999978 46.408507044999993, -112.33014903600005 46.407174957000095, -112.33175205500015 46.406548022000081, -112.33353992900003 46.406759953000169, -112.33641804299982 46.404267927999982, -112.33870198199999 46.40327797000014, -112.33923899599988 46.402712041999983, -112.33883201499978 46.399698045000072, -112.33996604500015 46.397362961999967, -112.3421590610001 46.395635926000111, -112.34468200699995 46.3948480380001, -112.34379099500006 46.39169698900006, -112.35149103600008 46.385251986000164, -112.35294797700006 46.384691070999985, -112.35875701999989 46.384290943000138, -112.3626080429998 46.385080836999933, -112.36615203400007 46.384970024000019, -112.36754596399997 46.38611592100014, -112.37585104399983 46.387028995000087, -112.38952793399974 46.383258030999968, -112.39280801500013 46.385052924999961, -112.39537592100005 46.385403077999932, -112.3968099629998 46.387522052000079, -112.39933207299984 46.387536927000042, -112.40483391700003 46.3854249730001, -112.40715195199984 46.381620080000012, -112.40934095699988 46.380995988000073, -112.4137370159999 46.377771063000182, -112.41723003000008 46.377758026000116, -112.41830104999991 46.377295053999966, -112.41860106200006 46.37629205999999, -112.41401697200017 46.371538994000161, -112.41510002599986 46.370913062000085, -112.42491001499988 46.369482028, -112.42585200399984 46.36861993100019, -112.42820196199999 46.36549696000008, -112.42519398199975 46.357921938000075, -112.43359299299986 46.353973975000045, -112.43593693499989 46.35108399500001, -112.43792102800016 46.3515999490001, -112.44400200500013 46.3516109799999, -112.45166293500007 46.350362961999991, -112.45299502399997 46.349437018000025, -112.45301992699984 46.348201033999985, -112.4504680669999 46.346846046999936, -112.45253004600022 46.345958044000135, -112.45274598799993 46.344856940000142, -112.45098903500012 46.342706043000106, -112.45113795499989 46.340100028999977, -112.44936094599984 46.334072035000013, -112.45344896999993 46.328988036000176, -112.46599801499983 46.328843963000246, -112.46758599100008 46.33717595199991, -112.46887194999994 46.3385550069999, -112.47500206500007 46.340971987000046, -112.48062892800003 46.339207011999882, -112.48539202200013 46.339372979000167, -112.48734101699999 46.341725946000125, -112.48859505200006 46.3422699799999, -112.49370495800014 46.342171034000167, -112.49590399099992 46.341617975000133, -112.49764907699995 46.341931024000147, -112.49916802599986 46.341339022000213, -112.50029704199997 46.338172929999949, -112.50005001199982 46.335831996999971, -112.49910200599992 46.334520968000184, -112.50234798999993 46.332357034000168, -112.50373406499986 46.330127081000128, -112.50475494300009 46.329866011, -112.50988406900021 46.330701032000135, -112.51369096800008 46.332530022000036, -112.51568793099983 46.331941028000145, -112.51911292 46.329421925999981, -112.52274699799983 46.329578033000011, -112.53247592599972 46.334918922999975, -112.53324793499981 46.331281000000168, -112.53647503300017 46.328995056000004, -112.53785793200001 46.326963997000135, -112.54216992099985 46.323314040000128, -112.54253093900012 46.321478031000048, -112.54455196999994 46.318682984999981, -112.54801707199981 46.316698056000114, -112.54790007499987 46.3143240290001, -112.55134896500006 46.313744061000044, -112.55602598299988 46.307521017000063, -112.56083002700008 46.307081946000125, -112.56545205699987 46.305471072000046, -112.56831094999976 46.305487953000039, -112.56982304599997 46.304726973999955, -112.56941305699993 46.302452061000132, -112.57252800500014 46.297123037000162, -112.56456004199998 46.290591959000047, -112.55845900899995 46.281933048000184, -112.55757702300008 46.278686060999995, -112.55805202799988 46.267091039000071, -112.55915497100015 46.263921939000106, -112.56117800799976 46.26069200000007, -112.56488094699974 46.258709076, -112.57126293800009 46.251225980000065, -112.5716119219998 46.249085946999976, -112.57678400299986 46.245039038000108, -112.58001895600012 46.240925942999993, -112.58364802099993 46.240890008000129, -112.58654802900007 46.239149936000054, -112.58981072699991 46.239331447999994, -112.5958850179999 46.238439933999921, -112.59747901200006 46.2370690700001, -112.5978159619999 46.235296071000135, -112.59263301699988 46.23192506800001, -112.59441704700002 46.228146916999918, -112.59208998599979 46.225440954999996, -112.58894595600003 46.2255109860001, -112.58463597199993 46.223141974000121, -112.57868402599991 46.221274041000129, -112.57791001099987 46.22070694300011, -112.57674205199983 46.216462978000017, -112.5734509399998 46.214660061999993, -112.57349506500009 46.21135106700018, -112.57557008100014 46.208408939000144, -112.57793006699981 46.202057032000212, -112.58049195599973 46.201151980999988, -112.58184192899976 46.198844977000014, -112.57883796000009 46.194669038000065, -112.57883294600009 46.190993007999943, -112.57704206399977 46.189623982000072, -112.5791650490001 46.186347076999979, -112.57664895599994 46.184877935000053, -112.57587293500006 46.182939972000057, -112.57685102500002 46.178858967000089), (-111.68046197299984 45.824012937000063, -111.67892497400014 45.824287043000034, -111.67817703199974 45.82382707999998, -111.68046197299984 45.824012937000063)))");
            Assert.AreEqual(3, mpoly.Polygons.Count);

        }
            
        [Test()]
        public void PointFeatureToWkt() {

            Terradue.GeoJson.Feature.Feature pointf = new Terradue.GeoJson.Feature.Feature(new Terradue.GeoJson.Geometry.Point(Position1), null);
            string wkt = pointf.ToWkt();
            Assert.AreEqual("POINT(124 10)", wkt);

        }

        [Test()]
        public void LineStringFeatureToWkt() {

            Terradue.GeoJson.Feature.Feature linestringf = 
                new Terradue.GeoJson.Feature.Feature(new Terradue.GeoJson.Geometry.LineString(
                    new List<IPosition>(){ Position1, Position2, Position3 }), null);
            string wkt = linestringf.ToWkt();
            Assert.AreEqual("LINESTRING(124 10,124 11,125 10)", wkt);

        }

        [Test()]
        public void PolygonFeatureToWkt() {

            List<LineString> list = new List<LineString>();
            list.Add(new Terradue.GeoJson.Geometry.LineString(
                                        new List<IPosition>(){ Position1, Position2, Position3, Position4 }));

            Terradue.GeoJson.Feature.Feature polygonf = 
                new Terradue.GeoJson.Feature.Feature(new Polygon(list), null);
            string wkt = polygonf.ToWkt();
            Assert.AreEqual("POLYGON((124 10,124 11,125 10,124 10))", wkt);

            var geometry = WktExtensions.WktToGeometry("POLYGON((-5.361328125 36.03133177633189,-4.921875 36.80928470205937,-2.021484375 36.949891786813296,3.076171875 42.553080288955826,4.21875 43.51668853502909,8.4375 44.5278427984555,13.095703125 45.89000815866182,19.248046875 42.09822241118974,26.71875 39.707186656826565,35.947265625 36.5978891330702,34.1015625 31.203404950917395,18.984375 30.29701788337205,-5.361328125 36.03133177633189))");

            GeometryFactory.SplitWorldExtent((Polygon)geometry);

            string geomstring = geometry.ToWkt();

            var feature = WktExtensions.WktToGeometry("POLYGON((-5.361328125 36.03133177633189,-4.921875 36.80928470205937,-2.021484375 36.949891786813296,3.076171875 42.553080288955826,4.21875 43.51668853502909,8.4375 44.5278427984555,13.095703125 45.89000815866182,19.248046875 42.09822241118974,26.71875 39.707186656826565,35.947265625 36.5978891330702,34.1015625 31.203404950917395,18.984375 30.29701788337205,-5.361328125 36.03133177633189))");

        }

        [Test()]
        public void WktToPolygon()
        {

            string wkt = "POLYGON (( 92.99937250451114 24.82896048436444, 93.84438636458545 24.97660545359885, 93.86765684814931 24.86831321058645, 94.70675421741745 25.00944549863781, 94.69785708876971 25.06663480860851, 95.46549034341051 25.19266122464629, 96.0439164448816 22.18602549895745, 95.30575899901886 22.05960884155055, 95.31629252216543 22.00256333935973, 94.4631564435164 21.85283317715932, 94.44212653424229 21.96119034519396, 93.66534852062075 21.8241281324206, 92.99937250451114 24.82896048436444 ))";

            Polygon geometry = (Polygon)WktExtensions.WktToGeometry(wkt);

            Assert.IsTrue(geometry is Polygon);


            Assert.AreEqual("Latitude: 24.8289604843644, Longitude: 92.9993725045111", geometry.LineStrings.First().Positions.First().ToString());

        }
    }
}

