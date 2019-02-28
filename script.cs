/*
 *   R e a d m e
 *   -----------
 * 
 *   Uses https://github.com/malware-dev/MDK-SE to minify
 *   
 *   
     Taleden's Inventory Manager
     version 1.7.0 (2018-10-30)

     Updated by Therian

     "There are some who call me... TIM?"

     Steam Workshop: http://steamcommunity.com/sharedfiles/filedetails/?id=546825757
     User's Guide:   http://steamcommunity.com/sharedfiles/filedetails/?id=546909551


     **********************
     ADVANCED CONFIGURATION

     The settings below may be changed if you like, but read the notes and remember
     that any changes will be reverted when you update the script from the workshop.
     

         Each "Type/" section can have multiple "/Subtype"s, which are formatted like
         "/Subtype,MinQta,PctQta,Label,Blueprint". Label and Blueprint specified only
         if different from Subtype, but Ingot and Ore have no Blueprint. Quota values
         are based on material requirements for various blueprints (some built in to
         the game, some from the community workshop).
 *   
 * 
 */
const string Ƨ=@"
AmmoMagazine/
/Missile200mm
/NATO_25x184mm,,,,NATO_25x184mmMagazine
/NATO_5p56x45mm,,,,NATO_5p56x45mmMagazine

Component/
/BulletproofGlass,50,2%
/Computer,30,5%,,ComputerComponent
/Construction,150,20%,,ConstructionComponent
/Detector,10,0.1%,,DetectorComponent
/Display,10,0.5%
/Explosives,5,0.1%,,ExplosivesComponent
/Girder,10,0.5%,,GirderComponent
/GravityGenerator,1,0.1%,GravityGen,GravityGeneratorComponent
/InteriorPlate,100,10%
/LargeTube,10,2%
/Medical,15,0.1%,,MedicalComponent
/MetalGrid,20,2%
/Motor,20,4%,,MotorComponent
/PowerCell,20,1%
/RadioCommunication,10,0.5%,RadioComm,RadioCommunicationComponent
/Reactor,25,2%,,ReactorComponent
/SmallTube,50,3%
/SolarCell,20,0.1%
/SteelPlate,150,40%
/Superconductor,10,1%
/Thrust,15,5%,,ThrustComponent

GasContainerObject/
/HydrogenBottle

Ingot/
/Cobalt,50,3.5%
/Gold,5,0.2%
/Iron,200,88%
/Magnesium,5,0.1%
/Nickel,30,1.5%
/Platinum,5,0.1%
/Silicon,50,2%
/Silver,20,1%
/Stone,50,2.5%
/Uranium,1,0.1%

Ore/
/Cobalt
/Gold
/Ice
/Iron
/Magnesium
/Nickel
/Platinum
/Scrap
/Silicon
/Silver
/Stone
/Uranium

OxygenContainerObject/
/OxygenBottle

PhysicalGunObject/
/AngleGrinderItem,,,,AngleGrinder
/AngleGrinder2Item,,,,AngleGrinder2
/AngleGrinder3Item,,,,AngleGrinder3
/AngleGrinder4Item,,,,AngleGrinder4
/AutomaticRifleItem,,,AutomaticRifle,AutomaticRifle
/HandDrillItem,,,,HandDrill
/HandDrill2Item,,,,HandDrill2
/HandDrill3Item,,,,HandDrill3
/HandDrill4Item,,,,HandDrill4
/PreciseAutomaticRifleItem,,,PreciseAutomaticRifle,PreciseAutomaticRifle
/RapidFireAutomaticRifleItem,,,RapidFireAutomaticRifle,RapidFireAutomaticRifle
/UltimateAutomaticRifleItem,,,UltimateAutomaticRifle,UltimateAutomaticRifle
/WelderItem,,,,Welder
/Welder2Item,,,,Welder2
/Welder3Item,,,,Welder3
/Welder4Item,,,,Welder4
";static HashSet<string>ƨ=new HashSet<string>{"INGOT","ORE"};static Dictionary<string,string>Ʃ=new Dictionary<string,
string>{{"ICE",""},{"ORGANIC",""},{"SCRAP","IRON"}};const string ƪ=Ơ+
"Assembler:AmmoMagazine,Component,GasContainerObject,Ore,OxygenContainerObject,PhysicalGunObject\n"+Ơ+"InteriorTurret:AmmoMagazine/Missile200mm,AmmoMagazine/NATO_25x184mm,"+ƙ+Ơ+
"LargeGatlingTurret:AmmoMagazine/Missile200mm,AmmoMagazine/NATO_5p56x45mm,"+ƙ+Ơ+"LargeMissileTurret:AmmoMagazine/NATO_25x184mm,AmmoMagazine/NATO_5p56x45mm,"+ƙ+Ơ+"OxygenGenerator:AmmoMagazine,Component,Ingot,Ore/Cobalt,Ore/Gold,Ore/Iron,Ore/Magnesium,Ore/Nickel,Ore/Organic,Ore/Platinum,Ore/Scrap,Ore/Silicon,Ore/Silver,Ore/Stone,Ore/Uranium,PhysicalGunObject\n"
+Ơ+"OxygenTank:AmmoMagazine,Component,GasContainerObject,Ingot,Ore,PhysicalGunObject\n"+Ơ+
"OxygenTank/LargeHydrogenTank:AmmoMagazine,Component,Ingot,Ore,OxygenContainerObject,PhysicalGunObject\n"+Ơ+"OxygenTank/SmallHydrogenTank:AmmoMagazine,Component,Ingot,Ore,OxygenContainerObject,PhysicalGunObject\n"+Ơ+"Reactor:AmmoMagazine,Component,GasContainerObject,Ingot/Cobalt,Ingot/Gold,Ingot/Iron,Ingot/Magnesium,Ingot/Nickel,Ingot/Platinum,Ingot/Scrap,Ingot/Silicon,Ingot/Silver,Ingot/Stone,Ore,OxygenContainerObject,PhysicalGunObject\n"
+Ơ+"Refinery:AmmoMagazine,Component,GasContainerObject,Ingot,Ore/Ice,Ore/Organic,OxygenContainerObject,PhysicalGunObject\n"
+Ơ+"Refinery/Blast Furnace:AmmoMagazine,Component,GasContainerObject,Ingot,Ore/Gold,Ore/Ice,Ore/Magnesium,Ore/Organic,Ore/Platinum,Ore/Silicon,Ore/Silver,Ore/Stone,Ore/Uranium,OxygenContainerObject,PhysicalGunObject\n"
+Ơ+"SmallGatlingGun:AmmoMagazine/Missile200mm,AmmoMagazine/NATO_5p56x45mm,"+ƙ+Ơ+
"SmallMissileLauncher:AmmoMagazine/NATO_25x184mm,AmmoMagazine/NATO_5p56x45mm,"+ƙ+Ơ+"SmallMissileLauncherReload:AmmoMagazine/NATO_25x184mm,AmmoMagazine/NATO_5p56x45mm,"+ƙ;const int ƫ=1,Ƭ=7,ƭ=0;const
string Ʈ="2018-10-30";const int Ư=(ƫ*1000000)+(Ƭ*1000)+ƭ;const int ư=11,Ʊ=1;const bool Ʋ=true,Ƴ=true;const char ƴ='[',Ƶ=']';
const string ƶ="TIM";const bool Ʒ=false,Ƹ=false,Ʀ=false,Ƙ=false;const string Ơ="MyObjectBuilder_";const string ƙ=
"Component,GasContainerObject,Ingot,Ore,OxygenContainerObject,PhysicalGunObject\n";const StringComparison ƚ=StringComparison.OrdinalIgnoreCase;const StringSplitOptions ƛ=StringSplitOptions.
RemoveEmptyEntries;static char[]Ɯ=new char[]{' ','\t','\u00AD'},Ɲ=new char[]{':'},ƞ=new char[]{'\r','\n'},Ɵ=new char[]{' ','\t','\u00AD',
','};struct ơ{public int ƥ;public float é;public ơ(int Ƣ,float ĥ){ƥ=Ƣ;é=ĥ;}}struct ƣ{public int Õ,Ƥ;public ƣ(int ƹ,int ǘ){Õ
=ƹ;Ƥ=ǘ;}}struct ǎ{public string Å,Ê;public ǎ(string Ċ,string â){Å=Ċ;Ê=â;}}struct Ǐ{public ǎ J;public double ǐ;public Ǐ(ǎ
Î,double Ǒ){J=Î;ǐ=Ǒ;}}static int ǒ=0;static string Ǔ="";static string[]ǔ=new string[12];static long Ǖ=0;static double ǖ=
0.0;static int Ǘ,Ǚ,Ǎ;static int ƺ=Ʊ,ǂ=0;static bool ƻ=Ʋ;static char Ƽ=ƴ,ƽ=Ƶ;static string ƾ=ƶ;static System.Text.
RegularExpressions.Regex ƿ=null;static string ǀ="";static bool ǁ=false;static Dictionary<ǎ,ơ>ǃ=new Dictionary<ǎ,ơ>();static Dictionary<
string,Dictionary<string,Dictionary<string,HashSet<string>>>>ǋ=new Dictionary<string,Dictionary<string,Dictionary<string,
HashSet<string>>>>();static HashSet<IMyCubeGrid>Ǆ=new HashSet<IMyCubeGrid>();static List<string>ǅ=new List<string>();static
Dictionary<string,string>ǆ=new Dictionary<string,string>();static Dictionary<string,List<string>>Ǉ=new Dictionary<string,List<
string>>();static Dictionary<string,long>ǈ=new Dictionary<string,long>();static List<string>ǉ=new List<string>();static
Dictionary<string,string>Ǌ=new Dictionary<string,string>();static Dictionary<string,List<string>>ǌ=new Dictionary<string,List<
string>>();static Dictionary<string,Dictionary<string,Ż>>Ɨ=new Dictionary<string,Dictionary<string,Ż>>();static Dictionary<
MyDefinitionId,ǎ>ų=new Dictionary<MyDefinitionId,ǎ>();static Dictionary<int,Dictionary<string,Dictionary<string,Dictionary<
IMyInventory,long>>>>ƕ=new Dictionary<int,Dictionary<string,Dictionary<string,Dictionary<IMyInventory,long>>>>();static Dictionary<
IMyTextPanel,int>Ŵ=new Dictionary<IMyTextPanel,int>();static Dictionary<IMyTextPanel,List<string>>ŵ=new Dictionary<IMyTextPanel,List
<string>>();static Dictionary<IMyTextPanel,List<string>>Ŷ=new Dictionary<IMyTextPanel,List<string>>();static List<
IMyTextPanel>ŷ=new List<IMyTextPanel>();static List<IMyTextPanel>Ÿ=new List<IMyTextPanel>();static HashSet<string>Ź=new HashSet<
string>();static List<string>ź=new List<string>();static Dictionary<IMyTerminalBlock,System.Text.RegularExpressions.Match>ż=
new Dictionary<IMyTerminalBlock,System.Text.RegularExpressions.Match>();static Dictionary<IMyTerminalBlock,System.Text.
RegularExpressions.Match>Ƅ=new Dictionary<IMyTerminalBlock,System.Text.RegularExpressions.Match>();static HashSet<IMyInventory>Ž=new
HashSet<IMyInventory>();static HashSet<IMyInventory>ž=new HashSet<IMyInventory>();static Dictionary<IMyRefinery,HashSet<string>
>ſ=new Dictionary<IMyRefinery,HashSet<string>>();static Dictionary<IMyAssembler,HashSet<ǎ>>ƀ=new Dictionary<IMyAssembler,
HashSet<ǎ>>();static Dictionary<IMyFunctionalBlock,Ǐ>Ɓ=new Dictionary<IMyFunctionalBlock,Ǐ>();static Dictionary<
IMyFunctionalBlock,int>Ƃ=new Dictionary<IMyFunctionalBlock,int>();static Dictionary<IMyTextPanel,ƣ>ƃ=new Dictionary<IMyTextPanel,ƣ>();
static Dictionary<IMyTerminalBlock,HashSet<IMyTerminalBlock>>ƅ=new Dictionary<IMyTerminalBlock,HashSet<IMyTerminalBlock>>();
class Ż{public string Å,Ê,ũ;public MyDefinitionId Ū;public long G,Ă,ý,ū,Ŭ;public float é;public int Ų,ŭ,Ç;public Dictionary<
IMyInventory,long>Ů;public Dictionary<IMyInventory,int>ů;public HashSet<IMyFunctionalBlock>Ű;public Dictionary<string,double>ű;
public static void Ģ(string Å,string Ê,long Ŭ=0L,float é=0.0f,string ũ="",string Ū=""){string ƒ=Å,Ɠ=Ê;Å=Å.ToUpper();Ê=Ê.
ToUpper();if(!Ǉ.ContainsKey(Å)){ǅ.Add(Å);ǆ[Å]=ƒ;Ǉ[Å]=new List<string>();ǈ[Å]=0L;Ɨ[Å]=new Dictionary<string,Ż>();}if(!ǌ.
ContainsKey(Ê)){ǉ.Add(Ê);Ǌ[Ê]=Ɠ;ǌ[Ê]=new List<string>();}if(!Ɨ[Å].ContainsKey(Ê)){ǁ=true;Ǉ[Å].Add(Ê);ǌ[Ê].Add(Å);Ɨ[Å][Ê]=new Ż(Å,Ê,
Ŭ,é,(ũ=="")?Ɠ:ũ,(Ū=="")?Ɠ:Ū);if(Ū!=null)ų[Ɨ[Å][Ê].Ū]=new ǎ(Å,Ê);}}private Ż(string Å,string Ê,long Ŭ,float é,string ũ,
string Ū){this.Å=Å;this.Ê=Ê;this.ũ=ũ;this.Ū=(Ū==null)?default(MyDefinitionId):MyDefinitionId.Parse(
"MyObjectBuilder_BlueprintDefinition/"+Ū);this.G=this.Ă=this.ý=this.ū=0L;this.Ŭ=(long)((double)Ŭ*1000000.0+0.5);this.é=(é/100.0f);this.Ų=-1;this.ŭ=this.Ç=0;
this.Ů=new Dictionary<IMyInventory,long>();this.ů=new Dictionary<IMyInventory,int>();this.Ű=new HashSet<IMyFunctionalBlock>(
);this.ű=new Dictionary<string,double>();}}void Ɣ(string I){string Å="";long Ŭ;float é;foreach(string ļ in I.Split(ƞ,ƛ)){
string[]Ɩ=(ļ.Trim()+",,,,").Split(Ɵ,6);Ɩ[0]=Ɩ[0].Trim();if(Ɩ[0].EndsWith("/")){Å=Ɩ[0].Substring(0,Ɩ[0].Length-1);}else if(Å!=
""&Ɩ[0].StartsWith("/")){long.TryParse(Ɩ[1],out Ŭ);float.TryParse(Ɩ[2].Substring(0,(Ɩ[2]+"%").IndexOf("%")),out é);Ż.Ģ(Å,Ɩ
[0].Substring(1),Ŭ,é,Ɩ[3].Trim(),(Å=="Ingot"|Å=="Ore")?null:Ɩ[4].Trim());}}}void Ƒ(string I){foreach(string ļ in I.Split(
ƞ,ƛ)){string[]Ɔ=(ļ+":").Split(':');string[]Ô=(Ɔ[0]+"/*").Split('/');foreach(string J in Ɔ[1].Split(',')){string[]Ƈ=J.
ToUpper().Split('/');ƈ(Ô[0].Trim(Ɯ),Ô[1].Trim(Ɯ),Ƈ[0],((Ƈ.Length>1)?Ƈ[1]:null),true);}}}void ƈ(string Ɖ,string Ɗ,string Å,
string Ê,bool Ƌ=false){Dictionary<string,Dictionary<string,HashSet<string>>>ƌ;Dictionary<string,HashSet<string>>ƍ;HashSet<
string>Ǝ;if(!ǋ.TryGetValue(Ɖ.ToUpper(),out ƌ))ǋ[Ɖ.ToUpper()]=ƌ=new Dictionary<string,Dictionary<string,HashSet<string>>>{{"*",
new Dictionary<string,HashSet<string>>()}};if(!ƌ.TryGetValue(Ɗ.ToUpper(),out ƍ)){ƌ[Ɗ.ToUpper()]=ƍ=new Dictionary<string,
HashSet<string>>();if(Ɗ!="*"&!Ƌ){foreach(KeyValuePair<string,HashSet<string>>Ə in ƌ["*"])ƍ[Ə.Key]=((Ə.Value!=null)?(new HashSet
<string>(Ə.Value)):null);}}if(Ê==null|Ê=="*"){ƍ[Å]=null;}else{(ƍ.TryGetValue(Å,out Ǝ)?Ǝ:(ƍ[Å]=new HashSet<string>())).Add
(Ê);}if(!Ƌ)ź.Add(Ɖ+"/"+Ɗ+" does not accept "+ǆ[Å]+"/"+Ǌ[Ê]);}bool Ɛ(IMyCubeBlock Ô,string Å,string Ê){Dictionary<string,
Dictionary<string,HashSet<string>>>ƌ;Dictionary<string,HashSet<string>>ƍ;HashSet<string>Ǝ;if(ǋ.TryGetValue(Ô.BlockDefinition.
TypeIdString.ToUpper(),out ƌ)){ƌ.TryGetValue(Ô.BlockDefinition.SubtypeName.ToUpper(),out ƍ);if((ƍ??ƌ["*"]).TryGetValue(Å,out Ǝ))
return!(Ǝ==null||Ǝ.Contains(Ê));}return true;}HashSet<string>Ȇ(IMyCubeBlock Ô,string Å,HashSet<string>å=null){Dictionary<
string,Dictionary<string,HashSet<string>>>ƌ;Dictionary<string,HashSet<string>>ƍ;HashSet<string>Ǝ;å=å??new HashSet<string>(Ǉ[Å]
);if(ǋ.TryGetValue(Ô.BlockDefinition.TypeIdString.ToUpper(),out ƌ)){ƌ.TryGetValue(Ô.BlockDefinition.SubtypeName.ToUpper()
,out ƍ);if((ƍ??ƌ["*"]).TryGetValue(Å,out Ǝ))å.ExceptWith(Ǝ??å);}return å;}string ȇ(IMyCubeBlock Ô,string Ê){string Ȉ=null
;foreach(string Å in ǌ[Ê]){if(Ɛ(Ô,Å,Ê)){if(Ȉ!=null)return null;Ȉ=Å;}}return Ȉ;}string ȉ(long G){long Ȋ;if(G<=0L)return"0"
;if(G<10000L)return"< 0.01";if(G>=100000000000000L)return""+(G/1000000000000L)+" M";Ȋ=(long)Math.Pow(10.0,Math.Floor(Math
.Log10(G))-2.0);G=(long)((double)G/Ȋ+0.5)*Ȋ;if(G<1000000000L)return(G/1e6).ToString("0.##");if(G<1000000000000L)return(G/
1e9).ToString("0.##")+" K";return(G/1e12).ToString("0.##")+" M";}void ȋ(){List<IMyTerminalBlock>Ŧ=new List<IMyTerminalBlock
>();IMyCubeGrid ȅ,Ƕ;Dictionary<IMyCubeGrid,HashSet<IMyCubeGrid>>Ǽ=new Dictionary<IMyCubeGrid,HashSet<IMyCubeGrid>>();
Dictionary<IMyCubeGrid,int>Ƿ=new Dictionary<IMyCubeGrid,int>();List<HashSet<IMyCubeGrid>>Ǹ=new List<HashSet<IMyCubeGrid>>();List<
string>ǹ=new List<string>();HashSet<IMyCubeGrid>Ǻ;List<IMyCubeGrid>ǻ=new List<IMyCubeGrid>();int Ǒ,ǧ,Ǩ;IMyShipConnector ȃ;
HashSet<string>ǽ=new HashSet<string>();HashSet<string>Ǿ=new HashSet<string>();System.Text.RegularExpressions.Match ǝ;Dictionary
<int,Dictionary<int,List<string>>>ǿ=new Dictionary<int,Dictionary<int,List<string>>>();Dictionary<int,List<string>>Ȁ;List
<string>ȁ;HashSet<int>Ȃ=new HashSet<int>();Queue<int>Ȍ=new Queue<int>();GridTerminalSystem.GetBlocksOfType<
IMyMechanicalConnectionBlock>(Ŧ);foreach(IMyTerminalBlock Ô in Ŧ){ȅ=Ô.CubeGrid;Ƕ=(Ô as IMyMechanicalConnectionBlock).TopGrid;if(Ƕ==null)continue;(Ǽ.
TryGetValue(ȅ,out Ǻ)?Ǻ:(Ǽ[ȅ]=new HashSet<IMyCubeGrid>())).Add(Ƕ);(Ǽ.TryGetValue(Ƕ,out Ǻ)?Ǻ:(Ǽ[Ƕ]=new HashSet<IMyCubeGrid>())).Add(ȅ
);}foreach(IMyCubeGrid Ț in Ǽ.Keys){if(!Ƿ.ContainsKey(Ț)){ǧ=(Ț.Max-Ț.Min+Vector3I.One).Size;ȅ=Ț;Ƿ[Ț]=Ǹ.Count;Ǻ=new
HashSet<IMyCubeGrid>{Ț};ǻ.Clear();ǻ.AddRange(Ǽ[Ț]);for(Ǒ=0;Ǒ<ǻ.Count;Ǒ++){Ƕ=ǻ[Ǒ];if(!Ǻ.Add(Ƕ))continue;Ǩ=(Ƕ.Max-Ƕ.Min+Vector3I.
One).Size;ȅ=(Ǩ>ǧ)?Ƕ:ȅ;ǧ=(Ǩ>ǧ)?Ǩ:ǧ;Ƿ[Ƕ]=Ǹ.Count;ǻ.AddRange(Ǽ[Ƕ].Except(Ǻ));}Ǹ.Add(Ǻ);ǹ.Add(ȅ.CustomName);}}
GridTerminalSystem.GetBlocksOfType<IMyShipConnector>(Ŧ);foreach(IMyTerminalBlock Ô in Ŧ){ȃ=(Ô as IMyShipConnector).OtherConnector;if(ȃ!=
null&&(Ô.EntityId<ȃ.EntityId&(Ô as IMyShipConnector).Status==MyShipConnectorStatus.Connected)){ǽ.Clear();Ǿ.Clear();if((ǝ=ƿ.
Match(Ô.CustomName)).Success){foreach(string Ǣ in ǝ.Groups[1].Captures[0].Value.Split(Ɵ,ƛ)){if(Ǣ.StartsWith("DOCK:",ƚ))ǽ.
UnionWith(Ǣ.Substring(5).ToUpper().Split(Ɲ,ƛ));}}if((ǝ=ƿ.Match(ȃ.CustomName)).Success){foreach(string Ǣ in ǝ.Groups[1].Captures[0
].Value.Split(Ɵ,ƛ)){if(Ǣ.StartsWith("DOCK:",ƚ))Ǿ.UnionWith(Ǣ.Substring(5).ToUpper().Split(Ɲ,ƛ));}}if((ǽ.Count>0|Ǿ.Count>0
)&!ǽ.Overlaps(Ǿ))continue;ȅ=Ô.CubeGrid;Ƕ=ȃ.CubeGrid;if(!Ƿ.TryGetValue(ȅ,out ǧ)){Ƿ[ȅ]=ǧ=Ǹ.Count;Ǹ.Add(new HashSet<
IMyCubeGrid>{ȅ});ǹ.Add(ȅ.CustomName);}if(!Ƿ.TryGetValue(Ƕ,out Ǩ)){Ƿ[Ƕ]=Ǩ=Ǹ.Count;Ǹ.Add(new HashSet<IMyCubeGrid>{Ƕ});ǹ.Add(Ƕ.
CustomName);}((ǿ.TryGetValue(ǧ,out Ȁ)?Ȁ:(ǿ[ǧ]=new Dictionary<int,List<string>>())).TryGetValue(Ǩ,out ȁ)?ȁ:(ǿ[ǧ][Ǩ]=new List<string
>())).Add(Ô.CustomName);((ǿ.TryGetValue(Ǩ,out Ȁ)?Ȁ:(ǿ[Ǩ]=new Dictionary<int,List<string>>())).TryGetValue(ǧ,out ȁ)?ȁ:(ǿ[Ǩ
][ǧ]=new List<string>())).Add(ȃ.CustomName);}}Ǆ.Clear();Ǆ.Add(Me.CubeGrid);if(!Ƿ.TryGetValue(Me.CubeGrid,out ǧ))return;Ȃ.
Add(ǧ);Ǆ.UnionWith(Ǹ[ǧ]);Ȍ.Enqueue(ǧ);while(Ȍ.Count>0){ǧ=Ȍ.Dequeue();if(!ǿ.TryGetValue(ǧ,out Ȁ))continue;foreach(int ȓ in Ȁ
.Keys){if(Ȃ.Add(ȓ)){Ǆ.UnionWith(Ǹ[ȓ]);Ȍ.Enqueue(ȓ);ź.Add(ǹ[ȓ]+" docked to "+ǹ[ǧ]+" at "+String.Join(", ",Ȁ[ȓ]));}}}}void
Ȕ(){List<IMyBlockGroup>ȕ=new List<IMyBlockGroup>();List<IMyTerminalBlock>Ŧ=new List<IMyTerminalBlock>();System.Text.
RegularExpressions.Match ǝ;GridTerminalSystem.GetBlockGroups(ȕ);foreach(IMyBlockGroup Ȗ in ȕ){if((ǝ=ƿ.Match(Ȗ.Name)).Success){Ȗ.GetBlocks(
Ŧ);foreach(IMyTerminalBlock Ô in Ŧ)ż[Ô]=ǝ;}}}void ȗ<Ș>()where Ș:class{List<IMyTerminalBlock>Ŧ=new List<IMyTerminalBlock>(
);System.Text.RegularExpressions.Match ǝ;int Î,â,ș;IMyInventory ß;List<MyInventoryItem>Y;string Å,Ê;Ż I;long G,ǥ;Y=new
List<MyInventoryItem>();GridTerminalSystem.GetBlocksOfType<Ș>(Ŧ);foreach(IMyTerminalBlock Ô in Ŧ){if(!Ǆ.Contains(Ô.CubeGrid)
)continue;ǝ=ƿ.Match(Ô.CustomName);if(ǝ.Success){ż.Remove(Ô);Ƅ[Ô]=ǝ;}else if(ż.TryGetValue(Ô,out ǝ)){Ƅ[Ô]=ǝ;}if((Ô is
IMySmallMissileLauncher&!(Ô is IMySmallMissileLauncherReload|Ô.BlockDefinition.SubtypeName=="LargeMissileLauncher"))|Ô is
IMyLargeInteriorTurret){Ž.Add(Ô.GetInventory(0));}else if((Ô is IMyFunctionalBlock)&&((Ô as IMyFunctionalBlock).Enabled&Ô.IsFunctional)){if((Ô
is IMyRefinery|Ô is IMyReactor|Ô is IMyGasGenerator)&!Ƅ.ContainsKey(Ô)){Ž.Add(Ô.GetInventory(0));}else if(Ô is
IMyAssembler&&!(Ô as IMyAssembler).IsQueueEmpty){Ž.Add(Ô.GetInventory(((Ô as IMyAssembler).Mode==MyAssemblerMode.Disassembly)?1:0));
}}Î=Ô.InventoryCount;while(Î-->0){ß=Ô.GetInventory(Î);ß.GetItems(Y);â=Y.Count;while(â-->0){Å=""+Y[â].Type.TypeId;Å=Å.
Substring(Å.LastIndexOf('_')+1);Ê=Y[â].Type.SubtypeId.ToString();Ż.Ģ(Å,Ê,0L,0.0f,Y[â].Type.SubtypeId.ToString(),null);Å=Å.ToUpper
();Ê=Ê.ToUpper();G=(long)((double)Y[â].Amount*1e6);ǈ[Å]+=G;I=Ɨ[Å][Ê];I.G+=G;I.Ă+=G;I.Ů.TryGetValue(ß,out ǥ);I.Ů[ß]=ǥ+G;I.
ů.TryGetValue(ß,out ș);I.ů[ß]=Math.Max(ș,â+1);}}}}void ȍ(){string Å,Ê;long G;Ż I;foreach(IMyInventory ß in ž){List<
MyInventoryItem>Ȏ;Ȏ=new List<MyInventoryItem>();ß.GetItems(Ȏ);foreach(MyInventoryItem ȏ in Ȏ){Å=""+ȏ.Type.TypeId;Å=Å.Substring(Å.
LastIndexOf('_')+1).ToUpper();Ê=ȏ.Type.SubtypeId.ToString().ToUpper();G=(long)((double)ȏ.Amount*1e6);ǈ[Å]-=G;Ɨ[Å][Ê].G-=G;}}foreach
(IMyInventory ß in Ž){List<MyInventoryItem>Ȏ;Ȏ=new List<MyInventoryItem>();ß.GetItems(Ȏ);foreach(MyInventoryItem ȏ in Ȏ){
Å=""+ȏ.Type.TypeId;Å=Å.Substring(Å.LastIndexOf('_')+1).ToUpper();Ê=ȏ.Type.SubtypeId.ToString().ToUpper();G=(long)((double
)ȏ.Amount*1e6);I=Ɨ[Å][Ê];I.Ă-=G;I.ý+=G;}}}void Ȑ(){StringBuilder ȑ=new StringBuilder();IMyTextPanel Ȓ;IMyRefinery Ȅ;
IMyAssembler ǵ;System.Text.RegularExpressions.Match ǝ;int Î,V,ǟ,Ǡ;string[]ǡ,ç;string Ǣ,Å,Ê;long G;float é;bool ǣ,ê,Ǥ=false;foreach(
IMyTerminalBlock Ô in Ƅ.Keys){ǝ=Ƅ[Ô];ǡ=ǝ.Groups[1].Captures[0].Value.Split(Ɵ,ƛ);ȑ.Clear();if(!(ǣ=ż.ContainsKey(Ô))){ȑ.Append(Ô.
CustomName,0,ǝ.Index);ȑ.Append(Ƽ);if(ƾ!="")ȑ.Append(ƾ+" ");}if((Ȓ=(Ô as IMyTextPanel))!=null){foreach(string Õ in ǡ){Ǣ=Õ.ToUpper()
;if(ǒ<1005903&(Î=Ǣ.IndexOf(":P"))>0&Ɨ.ContainsKey(Ǣ.Substring(0,Math.Min(Ǣ.Length,Math.Max(0,Î))))){Ǣ="QUOTA:"+Ǣ;}else if
(ǒ<1005903&Ɨ.ContainsKey(Ǣ)){Ǣ="INVEN:"+Ǣ;}ç=Ǣ.Split(Ɲ);Ǣ=ç[0];if(Ǣ.Length>=4&"STATUS".StartsWith(Ǣ)){if(Ȓ.Enabled)ŷ.Add(
Ȓ);ȑ.Append("STATUS ");}else if(Ǣ.Length>=5&"DEBUGGING".StartsWith(Ǣ)){if(Ȓ.Enabled)Ÿ.Add(Ȓ);ȑ.Append("DEBUG ");}else if(
Ǣ=="SPAN"){if(ç.Length>=3&&(int.TryParse(ç[1],out ǟ)&int.TryParse(ç[2],out Ǡ)&ǟ>=1&Ǡ>=1)){ƃ[Ȓ]=new ƣ(ǟ,Ǡ);ȑ.Append(
"SPAN:"+ǟ+":"+Ǡ+" ");}else{ȑ.Append((Ǣ=String.Join(":",ç).ToLower())+" ");ź.Add("Invalid panel span rule: "+Ǣ);}}else if(Ǣ==
"THE"){Ǥ=true;}else if(Ǣ=="ENCHANTER"&Ǥ){Ǥ=false;Ȓ.SetValueFloat("FontSize",0.2f);Ȓ.WritePublicTitle("TIM the Enchanter",
false);Ȓ.WritePublicText(ǀ,false);Ȓ.ShowPublicTextOnScreen();ȑ.Append("THE ENCHANTER ");}else if(Ǣ.Length>=3&"QUOTAS".
StartsWith(Ǣ)){if(Ȓ.Enabled&!Ŵ.ContainsKey(Ȓ))Ŵ[Ȓ]=0;if(Ȓ.Enabled&!ŵ.ContainsKey(Ȓ))ŵ[Ȓ]=new List<string>();ȑ.Append("QUOTA");Î=0;
while(++Î<ç.Length){if(Ǭ(null,true,ç[Î],"",out Å,out Ê)&Å!="ORE"&Ê==""){if(Ȓ.Enabled)ŵ[Ȓ].Add(Å);ȑ.Append(":"+ǆ[Å]);}else if(
ç[Î].StartsWith("P")&int.TryParse(ç[Î].Substring(Math.Min(1,ç[Î].Length)),out V)){if(Ȓ.Enabled)Ŵ[Ȓ]=Math.Max(0,V);if(V>0)
ȑ.Append(":P"+V);}else{ȑ.Append(":"+ç[Î].ToLower());ź.Add("Invalid quota panel rule: "+ç[Î].ToLower());}}ȑ.Append(" ");}
else if(Ǣ.Length>=3&"INVENTORY".StartsWith(Ǣ)){if(Ȓ.Enabled&!Ŷ.ContainsKey(Ȓ))Ŷ[Ȓ]=new List<string>();ȑ.Append("INVEN");Î=0;
while(++Î<ç.Length){if(Ǭ(null,true,ç[Î],"",out Å,out Ê)&Ê==""){if(Ȓ.Enabled)Ŷ[Ȓ].Add(Å);ȑ.Append(":"+ǆ[Å]);}else{ȑ.Append(":"
+ç[Î].ToLower());ź.Add("Invalid inventory panel rule: "+ç[Î].ToLower());}}ȑ.Append(" ");}else{ȑ.Append((Ǣ=String.Join(":"
,ç).ToLower())+" ");ź.Add("Invalid panel attribute: "+Ǣ);}}}else{Ȅ=(Ô as IMyRefinery);ǵ=(Ô as IMyAssembler);foreach(
string Õ in ǡ){Ǣ=Õ.ToUpper();if(ǒ<1005900&((Ȅ!=null&Ǣ=="ORE")|(ǵ!=null&Ɨ["COMPONENT"].ContainsKey(Ǣ)))){Ǣ="AUTO";}ç=Ǣ.Split(Ɲ)
;Ǣ=ç[0];if((Ǣ.Length>=4&"LOCKED".StartsWith(Ǣ))|Ǣ=="EXEMPT"){Î=Ô.InventoryCount;while(Î-->0)Ž.Add(Ô.GetInventory(Î));ȑ.
Append(Ǣ+" ");}else if(Ǣ=="HIDDEN"){Î=Ô.InventoryCount;while(Î-->0)ž.Add(Ô.GetInventory(Î));ȑ.Append("HIDDEN ");}else if((Ô is
IMyShipConnector)&Ǣ=="DOCK"){ȑ.Append(String.Join(":",ç)+" ");}else if((Ȅ!=null|ǵ!=null)&Ǣ=="AUTO"){ȑ.Append("AUTO");HashSet<string>W,Ǟ=
(Ȅ==null|ç.Length>1)?(new HashSet<string>()):Ȇ(Ȅ,"ORE");HashSet<ǎ>L,ǜ=new HashSet<ǎ>();Î=0;while(++Î<ç.Length){if(Ǭ(null,
true,ç[Î],(Ȅ!=null)?"ORE":"",out Å,out Ê)&(Ȅ!=null)==(Å=="ORE")&(Ȅ!=null|Å!="INGOT")){if(Ê==""){if(Ȅ!=null){Ǟ.UnionWith(Ǉ[Å]
);}else{foreach(string â in Ǉ[Å])ǜ.Add(new ǎ(Å,â));}ȑ.Append(":"+ǆ[Å]);}else{if(Ȅ!=null){Ǟ.Add(Ê);}else{ǜ.Add(new ǎ(Å,Ê))
;}ȑ.Append(":"+((Ȅ==null&ǌ[Ê].Count>1)?(ǆ[Å]+"/"):"")+Ǌ[Ê]);}}else{ȑ.Append(":"+ç[Î].ToLower());ź.Add(
"Unrecognized or ambiguous item: "+ç[Î].ToLower());}}if(Ȅ!=null){if(Ȅ.Enabled)(ſ.TryGetValue(Ȅ,out W)?W:(ſ[Ȅ]=new HashSet<string>())).UnionWith(Ǟ);}else{
if(ǒ<1005900){ǵ.ClearQueue();ǵ.Repeating=false;ǵ.Enabled=true;}if(ǵ.Enabled)(ƀ.TryGetValue(ǵ,out L)?L:(ƀ[ǵ]=new HashSet<ǎ>
())).UnionWith(ǜ);}ȑ.Append(" ");}else if(!æ(Ô,ç,"",out Å,out Ê,out V,out G,out é,out ê)){ȑ.Append((Ǣ=String.Join(":",ç).
ToLower())+" ");ź.Add("Unrecognized or ambiguous it3m: "+Ǣ);}else if(!Ô.HasInventory|(Ô is IMySmallMissileLauncher&!(Ô is
IMySmallMissileLauncherReload|Ô.BlockDefinition.SubtypeName=="LargeMissileLauncher"))|Ô is IMyLargeInteriorTurret){ȑ.Append(String.Join(":",ç).
ToLower()+" ");ź.Add("Cannot sort items to "+Ô.CustomName+": no conveyor-connected inventory");}else{if(Ê==""){foreach(string â
in(ê?(IEnumerable<string>)Ǉ[Å]:(IEnumerable<string>)Ȇ(Ô,Å)))à(Ô,0,Å,â,V,G);}else{à(Ô,0,Å,Ê,V,G);}if(ƻ&!ǣ){if(ê){ȑ.Append(
"FORCE:"+ǆ[Å]);if(Ê!="")ȑ.Append("/"+Ǌ[Ê]);}else if(Ê==""){ȑ.Append(ǆ[Å]);}else if(ǌ[Ê].Count==1||ȇ(Ô,Ê)==Å){ȑ.Append(Ǌ[Ê]);}
else{ȑ.Append(ǆ[Å]+"/"+Ǌ[Ê]);}if(V>0&V<int.MaxValue)ȑ.Append(":P"+V);if(G>=0L)ȑ.Append(":"+(G/1e6));ȑ.Append(" ");}}}}if(ƻ&!
ǣ){if(ȑ[ȑ.Length-1]==' ')ȑ.Length--;ȑ.Append(ƽ).Append(Ô.CustomName,ǝ.Index+ǝ.Length,Ô.CustomName.Length-ǝ.Index-ǝ.Length
);Ô.CustomName=ȑ.ToString();}if(Ô.GetUserRelationToOwner(Me.OwnerId)!=MyRelationsBetweenPlayerAndBlock.Owner&Ô.
GetUserRelationToOwner(Me.OwnerId)!=MyRelationsBetweenPlayerAndBlock.FactionShare)ź.Add("Cannot control \""+Ô.CustomName+
"\" due to differing ownership");}}void ǚ(bool Ǜ){bool D=Ź.Contains("quotas");int ì,Ķ,Ļ,Ŏ,ŏ,ŋ,Ō,Ń,Þ,V;long G,ă,ǥ;float é;bool ê;string Ǯ,Å,Ê;string[]Ɩ,
ǯ=new string[1]{" "};string[][]Ī;IMyTextPanel ǰ;IMySlimBlock Ĺ;Matrix ĸ=new Matrix();StringBuilder ĩ=new StringBuilder();
List<string>Ǳ=new List<string>(),ǲ=new List<string>(),ǳ=new List<string>();Dictionary<string,SortedDictionary<string,string[
]>>Ǵ=new Dictionary<string,SortedDictionary<string,string[]>>();Ż I;Ő À;foreach(Ż É in Ɨ["ORE"].Values)É.Ŭ=(É.G==0L)?0L:
Math.Max(É.Ŭ,É.G);foreach(IMyTextPanel Ã in Ŵ.Keys){Ŏ=Ã.BlockDefinition.SubtypeName.EndsWith("Wide")?2:1;ŏ=Ã.BlockDefinition
.SubtypeName.StartsWith("Small")?3:1;ŋ=Ō=1;if(ƃ.ContainsKey(Ã)){ŋ=ƃ[Ã].Õ;Ō=ƃ[Ã].Ƥ;}Ī=new string[ŋ][];Ã.Orientation.
GetMatrix(out ĸ);ĩ.Clear();for(Ļ=0;Ļ<Ō;Ļ++){Ń=0;for(Ķ=0;Ķ<ŋ;Ķ++){Ī[Ķ]=ǯ;Ĺ=Ã.CubeGrid.GetCubeBlock(new Vector3I(Ã.Position+Ķ*Ŏ*ŏ*ĸ
.Right+Ļ*ŏ*ĸ.Down));ǰ=(Ĺ!=null)?(Ĺ.FatBlock as IMyTextPanel):null;if(ǰ!=null&&(""+ǰ.BlockDefinition==""+Ã.BlockDefinition
&ǰ.GetPublicTitle().ToUpper().Contains("QUOTAS"))){Ī[Ķ]=ǰ.GetPublicText().Split('\n');Ń=Math.Max(Ń,Ī[Ķ].Length);}}for(ì=0
;ì<Ń;ì++){for(Ķ=0;Ķ<ŋ;Ķ++)ĩ.Append((ì<Ī[Ķ].Length)?Ī[Ķ][ì]:" ");ĩ.Append("\n");}}V=Ŵ[Ã];Ǯ="";Ǳ.Clear();Ǵ.Clear();ǲ.Clear(
);foreach(string ļ in ĩ.ToString().Split('\n')){Ɩ=ļ.ToUpper().Split(Ɯ,4,ƛ);if(Ɩ.Length<1){}else if(æ(null,Ɩ,Ǯ,out Å,out Ê
,out Þ,out G,out é,out ê)&Å==Ǯ&Å!=""&Ê!=""){I=Ɨ[Å][Ê];Ǵ[Å][Ê]=new string[]{I.ũ,""+Math.Round(G/1e6,2),""+Math.Round(é*
100.0f,2)+"%"};if((V>0&(V<I.Ų|I.Ų<=0))|(V==0&I.Ų<0)){I.Ų=V;I.Ŭ=G;I.é=é;}else if(V==I.Ų){I.Ŭ=Math.Max(I.Ŭ,G);I.é=Math.Max(I.é,é
);}}else if(æ(null,Ɩ,"",out Å,out Ê,out Þ,out G,out é,out ê)&Å!=Ǯ&Å!=""&Ê==""){if(!Ǵ.ContainsKey(Ǯ=Å)){Ǳ.Add(Ǯ);Ǵ[Ǯ]=new
SortedDictionary<string,string[]>();}}else if(Ǯ!=""){Ǵ[Ǯ][Ɩ[0]]=Ɩ;}else{ǲ.Add(ļ);}}À=new Ő(4,2);À.į(1,1);À.į(2,1);if(Ǳ.Count==0&ŵ[Ã].
Count==0)ŵ[Ã].AddRange(ǅ);foreach(string è in ŵ[Ã]){if(!Ǵ.ContainsKey(è)){Ǳ.Add(è);Ǵ[è]=new SortedDictionary<string,string[]>
();}}foreach(string è in Ǳ){if(è=="ORE")continue;if(À.ĭ()>0)À.Ĭ();À.ģ(0,ǆ[è],true);À.ģ(1,"  Min",true);À.ģ(2,"  Pct",true
);À.ģ(3,"",true);À.Ĭ();foreach(Ż É in Ɨ[è].Values){if(!Ǵ[è].ContainsKey(É.Ê))Ǵ[è][É.Ê]=new string[]{É.ũ,""+Math.Round(É.Ŭ
/1e6,2),""+Math.Round(É.é*100.0f,2)+"%"};}foreach(string Ǧ in Ǵ[è].Keys){Ɩ=Ǵ[è][Ǧ];À.ģ(0,Ɨ[è].ContainsKey(Ǧ)?Ɩ[0]:Ɩ[0].
ToLower(),true);À.ģ(1,(Ɩ.Length>1)?Ɩ[1]:"",true);À.ģ(2,(Ɩ.Length>2)?Ɩ[2]:"",true);À.ģ(3,(Ɩ.Length>3)?Ɩ[3]:"",true);}}ņ(
"TIM Quotas",À,Ã,true,((ǲ.Count==0)?"":(String.Join("\n",ǲ).Trim().ToLower()+"\n\n")),"");}foreach(string è in ǅ){ă=1L;if(!ƨ.
Contains(è))ă=1000000L;ǥ=ǈ[è];if(Ǜ&ǥ>0L){ǳ.Clear();foreach(Ż É in Ɨ[è].Values){if(É.é>0.0f&ǥ>=(long)(É.Ŭ/É.é))ǳ.Add(É.Ê);}if(ǳ.
Count>0){ǳ.Sort((string ǧ,string Ǩ)=>{Ż ǩ=Ɨ[è][ǧ],Ǫ=Ɨ[è][Ǩ];long ǭ=(long)(ǩ.G/ǩ.é),ǫ=(long)(Ǫ.G/Ǫ.é);return(ǭ==ǫ)?ǩ.é.
CompareTo(Ǫ.é):ǭ.CompareTo(ǫ);});Ê=ǳ[(ǳ.Count-1)/2];I=Ɨ[è][Ê];ǥ=(long)(I.G/I.é+0.5f);if(D){ź.Add("median "+ǆ[è]+" is "+Ǌ[Ê]+", "+
(ǥ/1e6)+" -> "+(I.G/1e6/I.é));foreach(string Ǧ in ǳ){I=Ɨ[è][Ǧ];ź.Add("  "+Ǌ[Ǧ]+" @ "+(I.G/1e6)+" / "+I.é+" => "+(long)(I.
G/1e6/I.é+0.5f));}}}}foreach(Ż É in Ɨ[è].Values){G=Math.Max(É.ū,Math.Max(É.Ŭ,(long)(É.é*ǥ+0.5f)));É.ū=(G/ă)*ă;}}}bool Ǭ(
IMyCubeBlock Ô,bool ê,string Ƈ,string è,out string Å,out string Ê){int Ċ,â,ã;string[]ä;Å="";Ê="";ã=0;ä=Ƈ.Trim().Split('/');if(ä.
Length>=2){ä[0]=ä[0].Trim();ä[1]=ä[1].Trim();if(Ǉ.ContainsKey(ä[0])&&(ä[1]==""|Ɨ[ä[0]].ContainsKey(ä[1]))){if(ê||Ɛ(Ô,ä[0],ä[1]
)){ã=1;Å=ä[0];Ê=ä[1];}}else{Ċ=ǅ.BinarySearch(ä[0]);Ċ=Math.Max(Ċ,~Ċ);while((ã<2&Ċ<ǅ.Count)&&ǅ[Ċ].StartsWith(ä[0])){â=Ǉ[ǅ[Ċ
]].BinarySearch(ä[1]);â=Math.Max(â,~â);while((ã<2&â<Ǉ[ǅ[Ċ]].Count)&&Ǉ[ǅ[Ċ]][â].StartsWith(ä[1])){if(ê||Ɛ(Ô,ǅ[Ċ],Ǉ[ǅ[Ċ]][â
])){ã++;Å=ǅ[Ċ];Ê=Ǉ[ǅ[Ċ]][â];}â++;}if(ã==0&ǅ[Ċ]=="INGOT"&"GRAVEL".StartsWith(ä[1])&(ê||Ɛ(Ô,"INGOT","STONE"))){ã++;Å=
"INGOT";Ê="STONE";}Ċ++;}}}else if(Ǉ.ContainsKey(ä[0])){if(ê||Ɛ(Ô,ä[0],"")){ã++;Å=ä[0];Ê="";}}else if(ǌ.ContainsKey(ä[0])){if(è
!=""&&Ɨ[è].ContainsKey(ä[0])){ã++;Å=è;Ê=ä[0];}else{Ċ=ǌ[ä[0]].Count;while(ã<2&Ċ-->0){if(ê||Ɛ(Ô,ǌ[ä[0]][Ċ],ä[0])){ã++;Å=ǌ[ä[
0]][Ċ];Ê=ä[0];}}}}else if(è!=""){â=Ǉ[è].BinarySearch(ä[0]);â=Math.Max(â,~â);while((ã<2&â<Ǉ[è].Count)&&Ǉ[è][â].StartsWith(
ä[0])){ã++;Å=è;Ê=Ǉ[è][â];â++;}if(ã==0&è=="INGOT"&"GRAVEL".StartsWith(ä[0])){ã++;Å="INGOT";Ê="STONE";}}else{Ċ=ǅ.
BinarySearch(ä[0]);Ċ=Math.Max(Ċ,~Ċ);while((ã<2&Ċ<ǅ.Count)&&ǅ[Ċ].StartsWith(ä[0])){if(ê||Ɛ(Ô,ǅ[Ċ],"")){ã++;Å=ǅ[Ċ];Ê="";}Ċ++;}â=ǉ.
BinarySearch(ä[0]);â=Math.Max(â,~â);while((ã<2&â<ǉ.Count)&&ǉ[â].StartsWith(ä[0])){Ċ=ǌ[ǉ[â]].Count;while(ã<2&Ċ-->0){if(ê||Ɛ(Ô,ǌ[ǉ[â]]
[Ċ],ǉ[â])){if(ã!=1||(Å!=ǌ[ǉ[â]][Ċ]|Ê!=""|Ǉ[Å].Count!=1))ã++;Å=ǌ[ǉ[â]][Ċ];Ê=ǉ[â];}}â++;}if(ã==0&"GRAVEL".StartsWith(ä[0])&
(ê||Ɛ(Ô,"INGOT","STONE"))){ã++;Å="INGOT";Ê="STONE";}}if(!ê&Ô!=null&ã==1&Ê==""){HashSet<string>å=Ȇ(Ô,Å);if(å.Count==1)Ê=å.
First();}return(ã==1);}bool æ(IMyCubeBlock Ô,string[]ç,string è,out string Å,out string Ê,out int V,out long G,out float é,
out bool ê){int ë,ì;double í,î;Å="";Ê="";V=0;G=-1L;é=-1.0f;ê=(Ô==null);ë=0;if(ç[0].Trim()=="FORCE"){if(ç.Length==1)return
false;ê=true;ë=1;}if(!Ǭ(Ô,ê,ç[ë],è,out Å,out Ê))return false;while(++ë<ç.Length){ç[ë]=ç[ë].Trim();ì=ç[ë].Length;if(ì==0){}
else if(ç[ë]=="IGNORE"){G=0L;}else if(ç[ë]=="OVERRIDE"|ç[ë]=="SPLIT"){}else if(ç[ë][ì-1]=='%'&double.TryParse(ç[ë].Substring
(0,ì-1),out í)){é=Math.Max(0.0f,(float)(í/100.0));}else if(ç[ë][0]=='P'&double.TryParse(ç[ë].Substring(1),out í)){V=Math.
Max(1,(int)(í+0.5));}else{î=1.0;if(ç[ë][ì-1]=='K'){ì--;î=1e3;}else if(ç[ë][ì-1]=='M'){ì--;î=1e6;}if(double.TryParse(ç[ë].
Substring(0,ì),out í))G=Math.Max(0L,(long)(í*î*1e6+0.5));}}return true;}void à(IMyTerminalBlock Ô,int Ù,string Å,string Ê,int V,
long G){long Õ;Dictionary<string,Dictionary<string,Dictionary<IMyInventory,long>>>Ö;Dictionary<string,Dictionary<
IMyInventory,long>>Ø;Dictionary<IMyInventory,long>Ú;if(V==0)V=int.MaxValue;Ö=(ƕ.TryGetValue(V,out Ö)?Ö:(ƕ[V]=new Dictionary<string,
Dictionary<string,Dictionary<IMyInventory,long>>>()));Ø=(Ö.TryGetValue(Å,out Ø)?Ø:(Ö[Å]=new Dictionary<string,Dictionary<
IMyInventory,long>>()));Ú=(Ø.TryGetValue(Ê,out Ú)?Ú:(Ø[Ê]=new Dictionary<IMyInventory,long>()));IMyInventory ß=Ô.GetInventory(Ù);Ú.
TryGetValue(ß,out Õ);Ú[ß]=G;Ɨ[Å][Ê].ū+=Math.Min(0L,-Õ)+Math.Max(0L,G);if(((Ô is IMyGasGenerator|Ô is IMyReactor|Ô is IMyRefinery|Ô
is IMyUserControllableGun)&ß.Owner!=null)&&Ô.GetUseConveyorSystem()){Ô.GetActionWithName("UseConveyor").Apply(Ô);ź.Add(
"Disabling conveyor system for "+Ô.CustomName);}}void Û(bool Ü){List<int>Ý;Ý=new List<int>(ƕ.Keys);Ý.Sort();foreach(int Þ in Ý){foreach(string Å in ƕ[Þ]
.Keys){foreach(string Ê in ƕ[Þ][Å].Keys)ï(Ü,Þ,Å,Ê);}}if(!Ü){foreach(string Å in ǅ){foreach(Ż I in Ɨ[Å].Values){if(I.Ă>0L)
ź.Add("No place to put "+ȉ(I.Ă)+" "+ǆ[Å]+"/"+Ǌ[I.Ê]+", containers may be full");}}}}void ï(bool Ü,int V,string Å,string Ê
){bool D=Ź.Contains("sorting");int ý,þ;long ÿ,Ā,ā,Ă,G,ú,ă;List<IMyInventory>Ą=null;Dictionary<IMyInventory,long>ą;if(D)ź.
Add("sorting "+ǆ[Å]+"/"+Ǌ[Ê]+" lim="+Ü+" p="+V);ă=1L;if(!ƨ.Contains(Å))ă=1000000L;ą=new Dictionary<IMyInventory,long>();Ż I
=Ɨ[Å][Ê];ÿ=0L;foreach(IMyInventory Ć in ƕ[V][Å][Ê].Keys){ā=ƕ[V][Å][Ê][Ć];if(ā!=0L&Ü==(ā>=0L)){if(ā<0L){ā=1000000L;if(Ć.
MaxVolume!=VRage.MyFixedPoint.MaxValue)ā=(long)((double)Ć.MaxVolume*1e6);}ą[Ć]=ā;ÿ+=ā;}}if(D)ź.Add("total req="+(ÿ/1e6));if(ÿ<=0L
)return;Ā=I.Ă+I.ý;if(D)ź.Add("total avail="+(Ā/1e6));if(Ā>0L){Ą=new List<IMyInventory>(I.Ů.Keys);do{ý=0;þ=0;foreach(
IMyInventory ü in Ą){Ă=I.Ů[ü];if(Ă>0L&Ž.Contains(ü)){ý++;ą.TryGetValue(ü,out ā);G=(long)((double)ā/ÿ*Ā);if(Ü)G=Math.Min(G,ā);G=(G/ă)
*ă;if(Ă>=G){if(D)ź.Add("locked "+(ü.Owner==null?"???":(ü.Owner as IMyTerminalBlock).CustomName)+" gets "+(G/1e6)+", has "
+(Ă/1e6));þ++;ÿ-=ā;ą[ü]=0L;Ā-=Ă;I.ý-=Ă;I.Ů[ü]=0L;}}}}while(ý>þ&þ>0);}foreach(IMyInventory Ć in ą.Keys){ā=ą[Ć];if(ā<=0L|ÿ
<=0L|Ā<=0L){if(Ü&ā>0L)ź.Add("Insufficient "+ǆ[Å]+"/"+Ǌ[Ê]+" to satisfy "+(Ć.Owner==null?"???":(Ć.Owner as IMyTerminalBlock
).CustomName));continue;}G=(long)((double)ā/ÿ*Ā);if(Ü)G=Math.Min(G,ā);G=(G/ă)*ă;if(D)ź.Add((Ć.Owner==null?"???":(Ć.Owner
as IMyTerminalBlock).CustomName)+" gets "+(ā/1e6)+" / "+(ÿ/1e6)+" of "+(Ā/1e6)+" = "+(G/1e6));ÿ-=ā;if(I.Ů.TryGetValue(Ć,
out Ă)){Ă=Math.Min(Ă,G);G-=Ă;Ā-=Ă;if(Ž.Contains(Ć)){I.ý-=Ă;}else{I.Ă-=Ă;}I.Ů[Ć]-=Ă;}ú=0L;foreach(IMyInventory ü in Ą){Ă=
Math.Min(I.Ů[ü],G);ú=0L;if(Ă>0L&Ž.Contains(ü)==false){ú=ð(Å,Ê,Ă,ü,Ć);G-=ú;Ā-=ú;I.Ă-=ú;I.Ů[ü]-=ú;}if(G<=0L|(ú!=0L&ú!=Ă))break
;}if(Ü&G>0L){ź.Add("Insufficient "+ǆ[Å]+"/"+Ǌ[Ê]+" to satisfy "+(Ć.Owner==null?"???":(Ć.Owner as IMyTerminalBlock).
CustomName));continue;}}if(D)ź.Add(""+(Ā/1e6)+" left over");}long ð(string Å,string Ê,long G,IMyInventory ñ,IMyInventory ò){bool D
=Ź.Contains("sorting");List<MyInventoryItem>Y;Y=new List<MyInventoryItem>();int â;VRage.MyFixedPoint ó,ú;uint ô;string õ,
ö;ó=(VRage.MyFixedPoint)(G/1e6);ñ.GetItems(Y);â=Math.Min(Ɨ[Å][Ê].ů[ñ],Y.Count);while(ó>0&â-->0){õ=""+Y[â].Type.TypeId;õ=õ
.Substring(õ.LastIndexOf('_')+1).ToUpper();ö=Y[â].Type.SubtypeId.ToString().ToUpper();if(õ==Å&ö==Ê){ú=Y[â].Amount;ô=Y[â].
ItemId;if(ñ==ò){ó-=ú;if(ó<0)ó=0;}else if(ñ.TransferItemTo(ò,â,null,true,ó)){ñ.GetItems(Y);if(â<Y.Count&&Y[â].ItemId==ô)ú-=Y[â]
.Amount;if(ú<=0){if((double)ò.CurrentVolume<(double)ò.MaxVolume/2&ò.Owner!=null){var ø=(ò.Owner as IMyCubeBlock).
BlockDefinition;ƈ(ø.TypeIdString,ø.SubtypeName,Å,Ê);}â=0;}else{Ǘ++;if(D)ź.Add("Transferred "+ȉ((long)((double)ú*1e6))+" "+ǆ[Å]+"/"+Ǌ[Ê]
+" from "+(ñ.Owner==null?"???":(ñ.Owner as IMyTerminalBlock).CustomName)+" to "+(ò.Owner==null?"???":(ò.Owner as
IMyTerminalBlock).CustomName));}ó-=ú;}else if(!ñ.IsConnectedTo(ò)&ñ.Owner!=null&ò.Owner!=null){if(!ƅ.ContainsKey(ñ.Owner as
IMyTerminalBlock))ƅ[ñ.Owner as IMyTerminalBlock]=new HashSet<IMyTerminalBlock>();ƅ[ñ.Owner as IMyTerminalBlock].Add(ò.Owner as
IMyTerminalBlock);â=0;}}}return G-(long)((double)ó*1e6+0.5);}void ù(){if(!Ǉ.ContainsKey("ORE")|!Ǉ.ContainsKey("INGOT"))return;bool D=Ź.
Contains("refineries");string Å,û,Ê,U,Ò;Ż I;int F,V;List<string>W=new List<string>();Dictionary<string,int>X=new Dictionary<
string,int>();List<MyInventoryItem>Y;double P,A;Ǐ R;bool e;List<IMyRefinery>g=new List<IMyRefinery>();Y=new List<
MyInventoryItem>();if(D)ź.Add("Refinery management:");foreach(string B in Ǉ["ORE"]){if(!Ʃ.TryGetValue(B,out Ò))Ò=B;if(Ò!=""&Ɨ["ORE"][B]
.Ă>0L&Ɨ["INGOT"].TryGetValue(Ò,out I)){if(I.ū>0L){F=(int)(100L*I.G/I.ū);W.Add(B);X[B]=F;if(D)ź.Add("  "+Ǌ[Ò]+" @ "+(I.G/
1e6)+"/"+(I.ū/1e6)+","+((B==Ò)?"":(" Ore/"+Ǌ[B]))+" L="+F+"%");}}}foreach(IMyRefinery H in ſ.Keys){Å=û=Ê=U="";H.
GetInventory(0).GetItems(Y);if(Y.Count>0){Å=""+Y[0].Type.TypeId;Å=Å.Substring(Å.LastIndexOf('_')+1).ToUpper();Ê=Y[0].Type.SubtypeId.
ToString().ToUpper();if(Å=="ORE"&X.ContainsKey(Ê))X[Ê]+=Math.Max(1,X[Ê]/ſ.Count);if(Y.Count>1){û=""+Y[1].Type.TypeId;û=û.
Substring(û.LastIndexOf('_')+1).ToUpper();U=Y[1].Type.SubtypeId.ToString().ToUpper();if(û=="ORE"&X.ContainsKey(U))X[U]+=Math.Max(
1,X[U]/ſ.Count);à(H,0,û,U,-2,(long)((double)Y[1].Amount*1e6+0.5));}}if(Ɓ.TryGetValue(H,out R)){I=Ɨ[R.J.Å][R.J.Ê];A=(I.ű.
TryGetValue(""+H.BlockDefinition,out A)?A:1.0);P=((R.J.Ê==Ê)?Math.Max(R.ǐ-(double)Y[0].Amount,0.0):Math.Max(R.ǐ,A));P=Math.Min(Math
.Max((P+A)/2.0,0.2),10000.0);I.ű[""+H.BlockDefinition]=P;if(D&(int)(A+0.5)!=(int)(P+0.5))ź.Add("  Update "+H.
BlockDefinition.SubtypeName+":"+Ǌ[R.J.Ê]+" refine speed: "+((int)(A+0.5))+" -> "+((int)(P+0.5))+"kg/cycle");}if(ſ[H].Count>0)ſ[H].
IntersectWith(X.Keys);else ſ[H].UnionWith(X.Keys);e=(ſ[H].Count>0);if(Y.Count>0){P=(Å=="ORE"?(Ɨ["ORE"][Ê].ű.TryGetValue(""+H.
BlockDefinition,out P)?P:1.0):1e6);à(H,0,Å,Ê,-1,(long)Math.Min((double)Y[0].Amount*1e6+0.5,10*P*1e6+0.5));e=(e&Å=="ORE"&(double)Y[0].
Amount<2.5*P&Y.Count==1);}if(e)g.Add(H);if(D)ź.Add("  "+H.CustomName+((Y.Count<1)?" idle":(" refining "+(int)Y[0].Amount+"kg "
+((Ê=="")?"unknown":(Ǌ[Ê]+(!X.ContainsKey(Ê)?"":(" (L="+X[Ê]+"%)"))))+((Y.Count<2)?"":(", then "+(int)Y[1].Amount+"kg "+(
(U=="")?"unknown":(Ǌ[U]+(!X.ContainsKey(U)?"":(" (L="+X[U]+"%)"))))))))+"; "+((X.Count==0)?"nothing to do":(e?"ready":((ſ
[H].Count==0)?"restricted":"busy"))));}if(W.Count>0&g.Count>0){W.Sort((string h,string k)=>{string o,u;if(!Ʃ.TryGetValue(
h,out o))o=h;if(!Ʃ.TryGetValue(k,out u))u=k;return-1*Ɨ["INGOT"][o].ū.CompareTo(Ɨ["INGOT"][u].ū);});g.Sort((IMyRefinery Z,
IMyRefinery S)=>ſ[Z].Count.CompareTo(ſ[S].Count));foreach(IMyRefinery H in g){Ê="";F=int.MaxValue;foreach(string B in W){if((Ê==""|
X[B]<F)&ſ[H].Contains(B)){Ê=B;F=X[Ê];}}if(Ê!=""){Ǚ++;H.UseConveyorSystem=false;V=H.GetInventory(0).IsItemAt(0)?-4:-3;P=(Ɨ
["ORE"][Ê].ű.TryGetValue(""+H.BlockDefinition,out P)?P:1.0);à(H,0,"ORE",Ê,V,(long)(5*P*1e6+0.5));X[Ê]+=Math.Min(Math.Max(
(int)(X[Ê]*0.41),1),(100/ſ.Count));if(D)ź.Add("  "+H.CustomName+" assigned "+((int)(5*P+0.5))+"kg "+Ǌ[Ê]+" (L="+X[Ê]+"%)"
);}else if(D)ź.Add("  "+H.CustomName+" unassigned, nothing to do");}}for(V=-1;V>=-4;V--){if(ƕ.ContainsKey(V)){foreach(
string B in ƕ[V]["ORE"].Keys)ï(true,V,"ORE",B);}}}void C(){if(!Ǉ.ContainsKey("INGOT"))return;bool D=Ź.Contains("assemblers");
long E;int F,G;Ż I,Q;ǎ J,K;List<ǎ>L;Dictionary<ǎ,int>M=new Dictionary<ǎ,int>(),N=new Dictionary<ǎ,int>();List<
MyProductionItem>O=new List<MyProductionItem>();double P,A;Ǐ R;bool e,Ç;List<IMyAssembler>È=new List<IMyAssembler>();if(D)ź.Add(
"Assembler management:");ǈ.TryGetValue("COMPONENT",out E);G=90+(int)(10*Ɨ["INGOT"].Values.Min(É=>(É.Ê!="URANIUM"&(É.Ŭ>0L|É.é>0.0f))?(É.G/Math.
Max((double)É.Ŭ,17.5*É.é*E)):2.0));if(D)ź.Add("  Component par L="+G+"%");foreach(string Å in ǅ){if(Å!="ORE"&Å!="INGOT"){
foreach(string Ê in Ǉ[Å]){I=Ɨ[Å][Ê];I.ŭ=Math.Max(0,I.ŭ-1);J=new ǎ(Å,Ê);N[J]=((Å=="COMPONENT"&I.é>0.0f)?G:100);F=(int)(100L*I.G/
Math.Max(1L,I.ū));if(I.ū>0L&F<N[J]&I.Ū!=default(MyDefinitionId)){if(I.ŭ==0)M[J]=F;if(D)ź.Add("  "+ǆ[Å]+"/"+Ǌ[Ê]+((I.ŭ>0)?"":
(" @ "+(I.G/1e6)+"/"+(I.ū/1e6)+", L="+F+"%"))+((I.ŭ>0|I.Ç>0)?("; HOLD "+I.ŭ+"/"+(10*I.Ç)):""));}}}}foreach(IMyAssembler Ë
in ƀ.Keys){e=Ç=false;I=Q=null;J=K=new ǎ("","");if(!Ë.IsQueueEmpty){Ë.GetQueue(O);I=(ų.TryGetValue(O[0].BlueprintId,out J)?
Ɨ[J.Å][J.Ê]:null);if(I!=null&M.ContainsKey(J))M[J]+=Math.Max(1,(int)(1e8*(double)O[0].Amount/I.ū+0.5));if(O.Count>1&&(ų.
TryGetValue(O[1].BlueprintId,out K)&M.ContainsKey(K)))M[K]+=Math.Max(1,(int)(1e8*(double)O[1].Amount/Ɨ[K.Å][K.Ê].ū+0.5));}if(Ɓ.
TryGetValue(Ë,out R)){Q=Ɨ[R.J.Å][R.J.Ê];A=(Q.ű.TryGetValue(""+Ë.BlockDefinition,out A)?A:1.0);if(R.J.Å!=J.Å|R.J.Ê!=J.Ê){P=Math.Max(
A,(Ë.IsQueueEmpty?2:1)*R.ǐ);Ƃ.Remove(Ë);}else if(Ë.IsProducing){P=R.ǐ-(double)O[0].Amount+Ë.CurrentProgress;Ƃ.Remove(Ë);}
else{P=Math.Max(A,R.ǐ-(double)O[0].Amount+Ë.CurrentProgress);if((Ƃ[Ë]=(Ƃ.TryGetValue(Ë,out F)?F:0)+1)>=3){ź.Add("  "+Ë.
CustomName+" is jammed by "+Ǌ[J.Ê]);Ƃ.Remove(Ë);Ë.ClearQueue();Q.ŭ=10*((Q.Ç<1|Q.ŭ<1)?(Q.Ç=Math.Min(10,Q.Ç+1)):Q.Ç);Ç=true;}}P=Math
.Min(Math.Max((P+A)/2.0,Math.Max(0.2,0.5*A)),Math.Min(1000.0,2.0*A));Q.ű[""+Ë.BlockDefinition]=P;if(D&(int)(A+0.5)!=(int)
(P+0.5))ź.Add("  Update "+Ë.BlockDefinition.SubtypeName+":"+ǆ[R.J.Å]+"/"+Ǌ[R.J.Ê]+" assemble speed: "+((int)(A*100)/100.0
)+" -> "+((int)(P*100)/100.0)+"/cycle");}if(ƀ[Ë].Count==0)ƀ[Ë].UnionWith(M.Keys);else ƀ[Ë].IntersectWith(M.Keys);P=((I!=
null&&I.ű.TryGetValue(""+Ë.BlockDefinition,out P))?P:1.0);if(!Ç&(Ë.IsQueueEmpty||(((double)O[0].Amount-Ë.CurrentProgress)<
2.5*P&O.Count==1&Ë.Mode==MyAssemblerMode.Assembly))){if(Q!=null)Q.Ç=Math.Max(0,Q.Ç-((Q.ŭ<1)?1:0));if(e=(ƀ[Ë].Count>0))È.Add
(Ë);}if(D)ź.Add("  "+Ë.CustomName+(Ë.IsQueueEmpty?" idle":(((Ë.Mode==MyAssemblerMode.Assembly)?" making ":" breaking ")+O
[0].Amount+"x "+((J.Å=="")?"unknown":(Ǌ[J.Ê]+(!M.ContainsKey(J)?"":(" (L="+M[J]+"%)"))))+((O.Count<=1)?"":(", then "+O[1]
.Amount+"x "+((K.Å=="")?"unknown":(Ǌ[K.Ê]+(!M.ContainsKey(K)?"":(" (L="+M[K]+"%)"))))))))+"; "+((M.Count==0)?
"nothing to do":(e?"ready":((ƀ[Ë].Count==0)?"restricted":"busy"))));}if(M.Count>0&È.Count>0){L=new List<ǎ>(M.Keys);L.Sort((o,u)=>-1*Ɨ[o
.Å][o.Ê].ū.CompareTo(Ɨ[u.Å][u.Ê].ū));È.Sort((IMyAssembler Ì,IMyAssembler Í)=>ƀ[Ì].Count.CompareTo(ƀ[Í].Count));foreach(
IMyAssembler Ë in È){J=new ǎ("","");F=int.MaxValue;foreach(ǎ Î in L){if(M[Î]<Math.Min(F,N[Î])&ƀ[Ë].Contains(Î)&Ɨ[Î.Å][Î.Ê].ŭ<1){J=Î;
F=M[Î];}}if(J.Å!=""){Ǎ++;Ë.UseConveyorSystem=true;Ë.CooperativeMode=false;Ë.Repeating=false;Ë.Mode=MyAssemblerMode.
Assembly;I=Ɨ[J.Å][J.Ê];P=(I.ű.TryGetValue(""+Ë.BlockDefinition,out P)?P:1.0);G=Math.Max((int)(5*P),1);Ë.AddQueueItem(I.Ū,(double
)G);M[J]+=(int)Math.Ceiling(1e8*(double)G/I.ū);if(D)ź.Add("  "+Ë.CustomName+" assigned "+G+"x "+Ǌ[J.Ê]+" (L="+M[J]+"%)");
}else if(D)ź.Add("  "+Ë.CustomName+" unassigned, nothing to do");}}}void Ï(){List<IMyTerminalBlock>Ð=new List<
IMyTerminalBlock>(),Ñ=new List<IMyTerminalBlock>();List<MyInventoryItem>Y;string Å,Ê,Ó;List<MyProductionItem>O=new List<MyProductionItem
>();ǎ J;Y=new List<MyInventoryItem>();Ɓ.Clear();GridTerminalSystem.GetBlocksOfType<IMyGasGenerator>(Ð,v=>Ǆ.Contains(v.
CubeGrid));GridTerminalSystem.GetBlocksOfType<IMyRefinery>(Ñ,v=>Ǆ.Contains(v.CubeGrid));foreach(IMyFunctionalBlock v in Ð.Concat
(Ñ)){v.GetInventory(0).GetItems(Y);if(Y.Count>0&v.Enabled){Å=""+Y[0].Type.TypeId;Å=Å.Substring(Å.LastIndexOf('_')+1).
ToUpper();Ê=Y[0].Type.SubtypeId.ToString().ToUpper();if(Ǉ.ContainsKey(Å)&ǌ.ContainsKey(Ê))Ɨ[Å][Ê].Ű.Add(v);if(Å=="ORE"&(Ʃ.
TryGetValue(Ê,out Ó)?Ó:(Ó=Ê))!=""&Ɨ["INGOT"].ContainsKey(Ó))Ɨ["INGOT"][Ó].Ű.Add(v);Ɓ[v]=new Ǐ(new ǎ(Å,Ê),(double)Y[0].Amount);}}
GridTerminalSystem.GetBlocksOfType<IMyAssembler>(Ð,v=>Ǆ.Contains(v.CubeGrid));foreach(IMyAssembler v in Ð){if(v.Enabled&!v.IsQueueEmpty&v.
Mode==MyAssemblerMode.Assembly){v.GetQueue(O);if(ų.TryGetValue(O[0].BlueprintId,out J)){if(Ǉ.ContainsKey(J.Å)&ǌ.ContainsKey(
J.Ê))Ɨ[J.Å][J.Ê].Ű.Add(v);Ɓ[v]=new Ǐ(J,(double)O[0].Amount-v.CurrentProgress);}}}}void z(){string ª,µ,º;Dictionary<string
,List<IMyTextPanel>>Æ=new Dictionary<string,List<IMyTextPanel>>();Ő À;long Á,Â;foreach(IMyTextPanel Ã in Ŷ.Keys){ª=String
.Join("/",Ŷ[Ã]);if(Æ.ContainsKey(ª))Æ[ª].Add(Ã);else Æ[ª]=new List<IMyTextPanel>(){Ã};}foreach(List<IMyTextPanel>Ä in Æ.
Values){À=new Ő(6);À.Ĳ(0);À.İ(0,1);À.į(2,1);À.į(3,1);À.į(4,1);À.į(5,1);Á=Â=0L;foreach(string Å in((Ŷ[Ä[0]].Count>0)?Ŷ[Ä[0]]:ǅ)
){µ=" Asm ";º="Quota";if(Å=="INGOT"){µ=" Ref ";}else if(Å=="ORE"){µ=" Ref ";º="Max";}if(À.ĭ()>0)À.Ĭ();À.ģ(0,"");À.ģ(1,ǆ[Å
],true);À.ģ(2,µ,true);À.ģ(3,"Qty",true);À.ģ(4," / ",true);À.ģ(5,º,true);À.Ĭ();foreach(Ż I in Ɨ[Å].Values){À.ģ(0,(I.G==0L)
?"0.0":(""+((double)I.G/I.ū)));À.ģ(1,I.ũ,true);ª=((I.Ű.Count>0)?(I.Ű.Count+" "+(I.Ű.All(v=>(!(v is IMyProductionBlock)||(
v as IMyProductionBlock).IsProducing))?" ":"!")):((I.ŭ>0)?"-  ":""));À.ģ(2,ª,true);À.ģ(3,(I.G>0L|I.ū>0L)?ȉ(I.G):"");À.ģ(4
,(I.ū>0L)?" / ":"",true);À.ģ(5,(I.ū>0L)?ȉ(I.ū):"");Á=Math.Max(Á,I.G);Â=Math.Max(Â,I.ū);}}À.Ĵ(3,Ő.Ŗ("8.88"+((Á>=
1000000000000L)?" M":((Á>=1000000000L)?" K":"")),true));À.Ĵ(5,Ő.Ŗ("8.88"+((Â>=1000000000000L)?" M":((Â>=1000000000L)?" K":"")),true));
foreach(IMyTextPanel Ã in Ä)ņ("TIM Inventory",À,Ã,true);}}void ć(){long ĥ;StringBuilder ĩ;if(ŷ.Count>0){ĩ=new StringBuilder();ĩ
.Append(Ǔ);for(ĥ=Math.Max(1,Ǖ-ǔ.Length+1);ĥ<=Ǖ;ĥ++)ĩ.Append(ǔ[ĥ%ǔ.Length]);foreach(IMyTextPanel Ã in ŷ){Ã.
WritePublicTitle("Script Status",false);if(ƃ.ContainsKey(Ã))ź.Add("Status panels cannot be spanned");Ã.WritePublicText(ĩ.ToString(),
false);Ã.ShowPublicTextOnScreen();}}if(Ÿ.Count>0){foreach(IMyTerminalBlock ń in ƅ.Keys){foreach(IMyTerminalBlock Ņ in ƅ[ń])ź.
Add("No conveyor connection from "+ń.CustomName+" to "+Ņ.CustomName);}foreach(IMyTextPanel Ã in Ÿ){Ã.WritePublicTitle(
"Script Debugging",false);if(ƃ.ContainsKey(Ã))ź.Add("Debug panels cannot be spanned");Ã.WritePublicText(String.Join("\n",ź),false);Ã.
ShowPublicTextOnScreen();}}ƅ.Clear();}void ņ(string Ň,Ő À,IMyTextPanel Ã,bool ň=true,string ŉ="",string Ŋ=""){int ŋ,Ō,ō,Ŏ,ŏ,Ĉ,Ń;int Ķ,Ļ,ĥ;
float ķ;string[][]Ī;string ª;Matrix ĸ;IMySlimBlock Ĺ;IMyTextPanel ĺ;Ŏ=Ã.BlockDefinition.SubtypeName.EndsWith("Wide")?2:1;ŏ=Ã.
BlockDefinition.SubtypeName.StartsWith("Small")?3:1;ŋ=Ō=1;if(ň&ƃ.ContainsKey(Ã)){ŋ=ƃ[Ã].Õ;Ō=ƃ[Ã].Ƥ;}Ķ=À.Į();Ķ=(Ķ/ŋ)+((Ķ%ŋ>0)?1:0);Ļ=À.ĭ
();Ļ=(Ļ/Ō)+((Ļ%Ō>0)?1:0);Ĉ=658*Ŏ;ķ=Ã.GetValueFloat("FontSize");if(ķ<0.25f)ķ=1.0f;if(Ķ>0)ķ=Math.Min(ķ,Math.Max(0.5f,(float
)(Ĉ*100/Ķ)/100.0f));if(Ļ>0)ķ=Math.Min(ķ,Math.Max(0.5f,(float)(1760/Ļ)/100.0f));Ĉ=(int)((float)Ĉ/ķ);Ń=(int)(17.6f/ķ);if(ŋ>
1|Ō>1){Ī=À.ħ(Ĉ,ŋ);ĸ=new Matrix();Ã.Orientation.GetMatrix(out ĸ);for(Ķ=0;Ķ<ŋ;Ķ++){ĥ=0;for(Ļ=0;Ļ<Ō;Ļ++){Ĺ=Ã.CubeGrid.
GetCubeBlock(new Vector3I(Ã.Position+Ķ*Ŏ*ŏ*ĸ.Right+Ļ*ŏ*ĸ.Down));if(Ĺ!=null&&(Ĺ.FatBlock is IMyTextPanel)&&""+Ĺ.FatBlock.
BlockDefinition==""+Ã.BlockDefinition){ĺ=Ĺ.FatBlock as IMyTextPanel;ō=Math.Max(0,Ī[Ķ].Length-ĥ);if(Ļ+1<Ō)ō=Math.Min(ō,Ń);ª="";if(ĥ<Ī[Ķ]
.Length)ª=String.Join("\n",Ī[Ķ],ĥ,ō);if(Ķ==0)ª+=((Ļ==0)?ŉ:(((Ļ+1)==Ō)?Ŋ:""));ĺ.SetValueFloat("FontSize",ķ);ĺ.
WritePublicTitle(Ň+" ("+(Ķ+1)+","+(Ļ+1)+")",false);ĺ.WritePublicText(ª,false);ĺ.ShowPublicTextOnScreen();}ĥ+=Ń;}}}else{Ã.SetValueFloat(
"FontSize",ķ);Ã.WritePublicTitle(Ň,false);Ã.WritePublicText(ŉ+À.á(Ĉ)+Ŋ,false);Ã.ShowPublicTextOnScreen();}}Program(){int Ł;Runtime
.UpdateFrequency=UpdateFrequency.Update100;foreach(string ļ in Me.CustomData.Split(ƞ,ƛ)){string[]Ľ=ļ.Trim().Split('=');if
(Ľ[0].Equals("TIM_version",ƚ)){if(!int.TryParse(Ľ[1],out ǒ)|ǒ>Ư){Echo("Invalid prior version: "+ǒ);ǒ=0;}}}Ő.Ģ();Ǔ=(
"Taleden's Inventory Manager\n"+"v"+ƫ+"."+Ƭ+"."+ƭ+" ("+Ʈ+")\n\n"+Ő.Ě("Run",80,out Ł,1)+Ő.Ě("Step",125+Ł,out Ł,1)+Ő.Ě("Time",145+Ł,out Ł,1)+Ő.Ě("Load",
105+Ł,out Ł,1)+Ő.Ě("S",65+Ł,out Ł,1)+Ő.Ě("R",65+Ł,out Ł,1)+Ő.Ě("A",65+Ł,out Ł,1)+"\n\n");Ɣ(Ƨ);Ƒ(ƪ);Echo("Compiled TIM v"+ƫ+
"."+Ƭ+"."+ƭ+" ("+Ʈ+")");}void Save(){}void Main(string ľ,UpdateType Ŀ){if(Ǖ>0&(ǖ+=Runtime.TimeSinceLastRun.TotalSeconds)<
0.5)return;ǖ=0.0;DateTime ŀ=DateTime.Now;int Î,Ħ,Ũ,Ř,ř,Ś;bool ś,Ŝ,ŝ,Ş,ş,Š,š;char Ţ,ţ;string Ť,ť;StringBuilder ĩ=new
StringBuilder();List<IMyTerminalBlock>Ŧ;Ǖ++;Echo("Taleden's Inventory Manager");Echo("v"+ƫ+"."+Ƭ+"."+ƭ+" ("+Ʈ+")");Echo("Last Run: #"
+Ǖ+" at "+ŀ.ToString("h:mm:ss tt"));if(ǒ>0&ǒ<Ư)Echo("Upgraded from v"+(ǒ/1000000)+"."+(ǒ/1000%1000)+"."+(ǒ%1000));ź.Clear
();Ź.Clear();Ř=Ǘ=Ǚ=Ǎ=0;š=true;ś=Ʋ;Ţ=ƴ;ţ=Ƶ;Ť=ƶ;Ũ=Ʊ;Ŝ=Ʒ;ŝ=Ƹ;Ş=Ʀ;ş=Ƙ;Š=Ƴ;foreach(string ŧ in ľ.Split(Ɯ,ƛ)){if(ŧ.Equals(
"rewrite",ƚ)){ś=true;ź.Add("Tag rewriting enabled");}else if(ŧ.Equals("norewrite",ƚ)){ś=false;ź.Add("Tag rewriting disabled");}
else if(ŧ.StartsWith("tags=",ƚ)){ť=ŧ.Substring(5);if(ť.Length!=2){Echo("Invalid 'tags=' delimiters \""+ť+
"\": must be exactly two characters");š=false;}else if(ť[0]==' '||ť[1]==' '){Echo("Invalid 'tags=' delimiters \""+ť+"\": cannot be spaces");š=false;}else if
(char.ToUpper(ť[0])==char.ToUpper(ť[1])){Echo("Invalid 'tags=' delimiters \""+ť+"\": characters must be different");š=
false;}else{Ţ=char.ToUpper(ť[0]);ţ=char.ToUpper(ť[1]);ź.Add("Tags are delimited by \""+Ţ+"\" and \""+ţ+"\"");}}else if(ŧ.
StartsWith("prefix=",ƚ)){Ť=ŧ.Substring(7).Trim().ToUpper();if(Ť==""){ź.Add("Tag prefix disabled");}else{ź.Add("Tag prefix is \""+Ť
+"\"");}}else if(ŧ.StartsWith("cycle=",ƚ)){if(int.TryParse(ŧ.Substring(6),out Ũ)==false||Ũ<1){Echo(
"Invalid 'cycle=' length \""+ŧ.Substring(6)+"\": must be a positive integer");š=false;}else{Ũ=Math.Min(Math.Max(Ũ,1),ư);if(Ũ<2){ź.Add(
"Function cycling disabled");}else{ź.Add("Cycle length is "+Ũ);}}}else if(ŧ.StartsWith("scan=",ƚ)){ť=ŧ.Substring(5);if(ť.Equals("collectors",ƚ)){Ŝ=
true;ź.Add("Enabled scanning of Collectors");}else if(ť.Equals("drills",ƚ)){ŝ=true;ź.Add("Enabled scanning of Drills");}else
if(ť.Equals("grinders",ƚ)){Ş=true;ź.Add("Enabled scanning of Grinders");}else if(ť.Equals("welders",ƚ)){ş=true;ź.Add(
"Enabled scanning of Welders");}else{Echo("Invalid 'scan=' block type '"+ť+"': must be 'collectors', 'drills', 'grinders' or 'welders'");š=false;}}
else if(ŧ.StartsWith("quota=",ƚ)){ť=ŧ.Substring(6);if(ť.Equals("literal",ƚ)){Š=false;ź.Add("Disabled stable dynamic quotas")
;}else if(ť.Equals("stable",ƚ)){Š=true;ź.Add("Enabled stable dynamic quotas");}else{Echo("Invalid 'quota=' mode '"+ť+
"': must be 'literal' or 'stable'");š=false;}}else if(ŧ.StartsWith("debug=",ƚ)){ť=ŧ.Substring(6);if(ť.Length>=1&"quotas".StartsWith(ť,ƚ)){Ź.Add("quotas");
}else if(ť.Length>=1&"sorting".StartsWith(ť,ƚ)){Ź.Add("sorting");}else if(ť.Length>=1&"refineries".StartsWith(ť,ƚ)){Ź.Add
("refineries");}else if(ť.Length>=1&"assemblers".StartsWith(ť,ƚ)){Ź.Add("assemblers");}else{Echo(
"Invalid 'debug=' type '"+ť+"': must be 'quotas', 'sorting', 'refineries', or 'assemblers'");š=false;}}else{Echo("Unrecognized argument: "+ŧ);š=
false;}}if(š==false)return;š=(Ƽ!=Ţ)|(ƽ!=ţ)|(ƾ!=Ť);if((š|(ƻ!=ś)|(ƺ!=Ũ))&&(ǂ>0)){ǂ=0;Echo(ť=
"Options changed; cycle step reset.");ź.Add(ť);}ƻ=ś;Ƽ=Ţ;ƽ=ţ;ƾ=Ť;ƺ=Ũ;if(ƿ==null|š){ť="\\"+Ƽ;if(ƾ!=""){ť+=" *"+System.Text.RegularExpressions.Regex.Escape(ƾ)+
"(|[ ,]+[^\\"+ƽ+"]*)";}else{ť+="([^\\"+ƽ+"]*)";}ť+="\\"+ƽ;ƿ=new System.Text.RegularExpressions.Regex(ť,System.Text.RegularExpressions
.RegexOptions.IgnoreCase);}if(ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť="Scanning grid connectors ...");ź.Add(ť);}ȋ();}Ŧ=new
List<IMyTerminalBlock>();GridTerminalSystem.GetBlocksOfType<IMyProgrammableBlock>(Ŧ,(IMyTerminalBlock v)=>(v==Me)|(ƿ.IsMatch
(v.CustomName)&Ǆ.Contains(v.CubeGrid)));Î=Ŧ.IndexOf(Me);Ħ=Ŧ.FindIndex(Ô=>Ô.IsFunctional&Ô.IsWorking);ť=Ƽ+ƾ+((Ŧ.Count>1)?(
" #"+(Î+1)):"")+ƽ;Me.CustomName=ƿ.IsMatch(Me.CustomName)?ƿ.Replace(Me.CustomName,ť,1):(Me.CustomName+" "+ť);if(Î!=Ħ){Echo(
"TIM #"+(Ħ+1)+" is on duty. Standing by.");if((""+(Ŧ[Ħ]as IMyProgrammableBlock).TerminalRunArgument).Trim()!=(""+Me.
TerminalRunArgument).Trim())Echo("WARNING: Script arguments do not match TIM #"+(Ħ+1)+".");return;}if(ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť=
"Scanning inventories ...");ź.Add(ť);}foreach(string Å in ǅ){ǈ[Å]=0;foreach(Ż I in Ɨ[Å].Values){I.G=0L;I.Ă=0L;I.ý=0L;I.Ů.Clear();I.ů.Clear();}}Ƅ.
Clear();ż.Clear();Ž.Clear();ž.Clear();Ȕ();ȗ<IMyAssembler>();ȗ<IMyCargoContainer>();if(Ŝ)ȗ<IMyCollector>();ȗ<IMyGasGenerator>(
);ȗ<IMyGasTank>();ȗ<IMyReactor>();ȗ<IMyRefinery>();ȗ<IMyShipConnector>();ȗ<IMyShipController>();if(ŝ)ȗ<IMyShipDrill>();if
(Ş)ȗ<IMyShipGrinder>();if(ş)ȗ<IMyShipWelder>();ȗ<IMyTextPanel>();ȗ<IMyUserControllableGun>();if(ǁ){ǁ=false;ǅ.Sort();
foreach(string Å in ǅ)Ǉ[Å].Sort();ǉ.Sort();foreach(string Ê in ǉ)ǌ[Ê].Sort();}}if(ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť=
"Scanning tags ...");ź.Add(ť);}foreach(string Å in ǅ){foreach(Ż I in Ɨ[Å].Values){I.Ų=-1;I.ū=0L;I.Ű.Clear();}}Ŵ.Clear();ŵ.Clear();Ŷ.Clear()
;ƕ.Clear();ŷ.Clear();Ÿ.Clear();ſ.Clear();ƀ.Clear();ƃ.Clear();Ȑ();}if(ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť=
"Adjusting tallies ...");ź.Add(ť);}ȍ();}if(ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť="Scanning quota panels ...");ź.Add(ť);}ǚ(Š);}if(ƺ<=1||(ǂ==Ř++*ƺ/ư
)){if(ƺ>1){Echo(ť="Processing limited item requests ...");ź.Add(ť);}Û(true);}if(ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť=
"Managing refineries ...");ź.Add(ť);}ù();}if(ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť="Processing remaining item requests ...");ź.Add(ť);}Û(false);}if(
ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť="Managing assemblers ...");ź.Add(ť);}C();}if(ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť=
"Scanning production ...");ź.Add(ť);}Ï();}if(ƺ<=1||(ǂ==Ř++*ƺ/ư)){if(ƺ>1){Echo(ť="Updating inventory panels ...");ź.Add(ť);}z();Me.CustomData=
"TIM_version="+(ǒ=Ư);}if(Ř!=ư)ź.Add("ERROR: step"+Ř+" of "+ư);ǂ++;ř=(int)((DateTime.Now-ŀ).TotalMilliseconds+0.5);Ś=(int)(100.0f*
Runtime.CurrentInstructionCount/Runtime.MaxInstructionCount+0.5);Î=0;ǔ[Ǖ%ǔ.Length]=(Ő.Ě(""+Ǖ,80,out Î,1)+Ő.Ě(ǂ+" / "+ƺ,125+Î,
out Î,1,true)+Ő.Ě(ř+" ms",145+Î,out Î,1)+Ő.Ě(Ś+"%",105+Î,out Î,1,true)+Ő.Ě(""+Ǘ,65+Î,out Î,1,true)+Ő.Ě(""+Ǚ,65+Î,out Î,1,
true)+Ő.Ě(""+Ǎ,65+Î,out Î,1,true)+"\n");Echo(ť=((ƺ>1)?("Cycle "+ǂ+" of "+ƺ+" completed in "):"Completed in ")+ř+" ms, "+Ś+
"% load ("+Runtime.CurrentInstructionCount+" instructions)");ź.Add(ť);ć();if(ǂ>=ƺ)ǂ=0;if(ǀ==""&Ǖ>ƺ)ǀ=
"This easter egg will return when Keen raises the 100kb script code size limit!\n";}class Ő{private static Dictionary<char,byte>ő=new Dictionary<char,byte>();private static Dictionary<string,int>Œ=new
Dictionary<string,int>();private static byte œ;private static byte Ŕ;public static int Ŗ(string ª,bool ĝ=false){int Ĉ;if(!Œ.
TryGetValue(ª,out Ĉ)){Dictionary<char,byte>ĉ=ő;string Ċ=ª+"\0\0\0\0\0\0\0";int Î=Ċ.Length-(Ċ.Length%8);byte ŕ,ŗ,ł,ĵ,ĕ,ė,Ę,ę;while(Î
>0){ĉ.TryGetValue(Ċ[Î-1],out ŕ);ĉ.TryGetValue(Ċ[Î-2],out ŗ);ĉ.TryGetValue(Ċ[Î-3],out ł);ĉ.TryGetValue(Ċ[Î-4],out ĵ);ĉ.
TryGetValue(Ċ[Î-5],out ĕ);ĉ.TryGetValue(Ċ[Î-6],out ė);ĉ.TryGetValue(Ċ[Î-7],out Ę);ĉ.TryGetValue(Ċ[Î-8],out ę);Ĉ+=ŕ+ŗ+ł+ĵ+ĕ+ė+Ę+ę;Î
-=8;}if(ĝ)Œ[ª]=Ĉ;}return Ĉ;}public static string Ě(string ª,int Ĉ,out int ě,int Ĝ=-1,bool ĝ=false){int Ğ,ğ;ě=Ĉ-Ŗ(ª,ĝ);if(ě
<=œ/2)return ª;Ğ=ě/œ;ğ=0;ě-=Ğ*œ;if(2*ě<=œ+(Ğ*(Ŕ-œ))){ğ=Math.Min(Ğ,(int)((float)ě/(Ŕ-œ)+0.4999f));Ğ-=ğ;ě-=ğ*(Ŕ-œ);}else if(
ě>œ/2){Ğ++;ě-=œ;}if(Ĝ>0)return new String(' ',Ğ)+new String('\u00AD',ğ)+ª;if(Ĝ<0)return ª+new String('\u00AD',ğ)+new
String(' ',Ğ);if((Ğ%2)>0&(ğ%2)==0)return new String(' ',Ğ/2)+new String('\u00AD',ğ/2)+ª+new String('\u00AD',ğ/2)+new String(
' ',Ğ-(Ğ/2));return new String(' ',Ğ-(Ğ/2))+new String('\u00AD',ğ/2)+ª+new String('\u00AD',ğ-(ğ/2))+new String(' ',Ğ/2);}
public static string Ě(double Ġ,int Ĉ,out int ě){int Ğ,ğ;Ġ=Math.Min(Math.Max(Ġ,0.0f),1.0f);Ğ=Ĉ/œ;ğ=(int)(Ğ*Ġ+0.5f);ě=Ĉ-(Ğ*œ);
return new String('I',ğ)+new String(' ',Ğ-ğ);}public static void Ģ(){Ė(0,"\u2028\u2029\u202F");Ė(7,
"'|\u00A6\u02C9\u2018\u2019\u201A");Ė(8,"\u0458");Ė(9," !I`ijl\u00A0\u00A1\u00A8\u00AF\u00B4\u00B8\u00CC\u00CD\u00CE\u00CF\u00EC\u00ED\u00EE\u00EF\u0128\u0129\u012A\u012B\u012E\u012F\u0130\u0131\u0135\u013A\u013C\u013E\u0142\u02C6\u02C7\u02D8\u02D9\u02DA\u02DB\u02DC\u02DD\u0406\u0407\u0456\u0457\u2039\u203A\u2219"
);Ė(10,"(),.1:;[]ft{}\u00B7\u0163\u0165\u0167\u021B");Ė(11,"\"-r\u00AA\u00AD\u00BA\u0140\u0155\u0157\u0159");Ė(12,
"*\u00B2\u00B3\u00B9");Ė(13,"\\\u00B0\u201C\u201D\u201E");Ė(14,"\u0491");Ė(15,"/\u0133\u0442\u044D\u0454");Ė(16,
"L_vx\u00AB\u00BB\u0139\u013B\u013D\u013F\u0141\u0413\u0433\u0437\u043B\u0445\u0447\u0490\u2013\u2022");Ė(17,"7?Jcz\u00A2\u00BF\u00E7\u0107\u0109\u010B\u010D\u0134\u017A\u017C\u017E\u0403\u0408\u0427\u0430\u0432\u0438\u0439\u043D\u043E\u043F\u0441\u044A\u044C\u0453\u0455\u045C"
);Ė(18,"3FKTabdeghknopqsuy\u00A3\u00B5\u00DD\u00E0\u00E1\u00E2\u00E3\u00E4\u00E5\u00E8\u00E9\u00EA\u00EB\u00F0\u00F1\u00F2\u00F3\u00F4\u00F5\u00F6\u00F8\u00F9\u00FA\u00FB\u00FC\u00FD\u00FE\u00FF\u00FF\u0101\u0103\u0105\u010F\u0111\u0113\u0115\u0117\u0119\u011B\u011D\u011F\u0121\u0123\u0125\u0127\u0136\u0137\u0144\u0146\u0148\u0149\u014D\u014F\u0151\u015B\u015D\u015F\u0161\u0162\u0164\u0166\u0169\u016B\u016D\u016F\u0171\u0173\u0176\u0177\u0178\u0219\u021A\u040E\u0417\u041A\u041B\u0431\u0434\u0435\u043A\u0440\u0443\u0446\u044F\u0451\u0452\u045B\u045E\u045F"
);Ė(19,"+<=>E^~\u00AC\u00B1\u00B6\u00C8\u00C9\u00CA\u00CB\u00D7\u00F7\u0112\u0114\u0116\u0118\u011A\u0404\u040F\u0415\u041D\u042D\u2212"
);Ė(20,"#0245689CXZ\u00A4\u00A5\u00C7\u00DF\u0106\u0108\u010A\u010C\u0179\u017B\u017D\u0192\u0401\u040C\u0410\u0411\u0412\u0414\u0418\u0419\u041F\u0420\u0421\u0422\u0423\u0425\u042C\u20AC"
);Ė(21,"$&GHPUVY\u00A7\u00D9\u00DA\u00DB\u00DC\u00DE\u0100\u011C\u011E\u0120\u0122\u0124\u0126\u0168\u016A\u016C\u016E\u0170\u0172\u041E\u0424\u0426\u042A\u042F\u0436\u044B\u2020\u2021"
);Ė(22,"ABDNOQRS\u00C0\u00C1\u00C2\u00C3\u00C4\u00C5\u00D0\u00D1\u00D2\u00D3\u00D4\u00D5\u00D6\u00D8\u0102\u0104\u010E\u0110\u0143\u0145\u0147\u014C\u014E\u0150\u0154\u0156\u0158\u015A\u015C\u015E\u0160\u0218\u0405\u040A\u0416\u0444"
);Ė(23,"\u0459");Ė(24,"\u044E");Ė(25,"%\u0132\u042B");Ė(26,"@\u00A9\u00AE\u043C\u0448\u045A");Ė(27,"M\u041C\u0428");Ė(28,
"mw\u00BC\u0175\u042E\u0449");Ė(29,"\u00BE\u00E6\u0153\u0409");Ė(30,"\u00BD\u0429");Ė(31,"\u2122");Ė(32,"W\u00C6\u0152\u0174\u2014\u2026\u2030");œ=ő
[' '];Ŕ=ő['\u00AD'];}private static void Ė(byte Ĉ,string ª){Dictionary<char,byte>ĉ=ő;string Ċ=ª+"\0\0\0\0\0\0\0";byte ċ=
Math.Max((byte)0,Ĉ);int Î=Ċ.Length-(Ċ.Length%8);while(Î>0){ĉ[Ċ[--Î]]=ċ;ĉ[Ċ[--Î]]=ċ;ĉ[Ċ[--Î]]=ċ;ĉ[Ċ[--Î]]=ċ;ĉ[Ċ[--Î]]=ċ;ĉ[Ċ[
--Î]]=ċ;ĉ[Ċ[--Î]]=ċ;ĉ[Ċ[--Î]]=ċ;}ĉ['\0']=0;}private int Č;private int č;private int Ď;private List<string>[]ď;private List
<int>[]Ĕ;private int[]Đ;private int[]đ;private bool[]Ē;private int[]ē;public Ő(int Č,int Ď=1){this.Č=Č;this.č=0;this.Ď=Ď;
this.ď=new List<string>[Č];this.Ĕ=new List<int>[Č];this.Đ=new int[Č];this.đ=new int[Č];this.Ē=new bool[Č];this.ē=new int[Č];
for(int ġ=0;ġ<Č;ġ++){this.ď[ġ]=new List<string>();this.Ĕ[ġ]=new List<int>();this.Đ[ġ]=-1;this.đ[ġ]=0;this.Ē[ġ]=false;this.ē
[ġ]=0;}}public void ģ(int ī,string ª,bool ĝ=false){int Ĉ=0;this.ď[ī].Add(ª);if(this.Ē[ī]==false){Ĉ=Ŗ(ª,ĝ);this.ē[ī]=Math.
Max(this.ē[ī],Ĉ);}this.Ĕ[ī].Add(Ĉ);this.č=Math.Max(this.č,this.ď[ī].Count);}public void Ĭ(){for(int ġ=0;ġ<this.Č;ġ++){this.
ď[ġ].Add("");this.Ĕ[ġ].Add(0);}this.č++;}public int ĭ(){return this.č;}public int Į(){int Ĉ=this.Ď*œ;for(int ġ=0;ġ<this.Č
;ġ++)Ĉ+=this.Ď*œ+this.ē[ġ];return Ĉ;}public void į(int ī,int Ĝ){this.Đ[ī]=Ĝ;}public void İ(int ī,int ı=1){this.đ[ī]=ı;}
public void Ĳ(int ī,bool ĳ=true){this.Ē[ī]=ĳ;}public void Ĵ(int ī,int Ĉ){this.ē[ī]=Ĉ;}public string[][]ħ(int Ĉ=0,int Ĥ=1){int
ġ,ĥ,â,Î,Ħ,Ĩ,ě,ó;int[]ē;byte ċ;double Ġ;string ª;StringBuilder ĩ;string[][]Ī;ē=(int[])this.ē.Clone();ě=Ĉ*Ĥ-this.Ď*œ;ó=0;
for(ġ=0;ġ<this.Č;ġ++){ě-=this.Ď*œ;if(this.đ[ġ]==0)ě-=ē[ġ];ó+=this.đ[ġ];}for(ġ=0;ġ<this.Č&ó>0;ġ++){if(this.đ[ġ]>0){ē[ġ]=Math
.Max(ē[ġ],this.đ[ġ]*ě/ó);ě-=ē[ġ];ó-=this.đ[ġ];}}Ī=new string[Ĥ][];for(â=0;â<Ĥ;â++)Ī[â]=new string[this.č];Ĥ--;Î=0;ĩ=new
StringBuilder();for(ĥ=0;ĥ<this.č;ĥ++){ĩ.Clear();â=0;ó=Ĉ;ě=0;for(ġ=0;ġ<this.Č;ġ++){ě+=this.Ď*œ;if(ĥ>=this.ď[ġ].Count||ď[ġ][ĥ]==""){ě+=
ē[ġ];}else{ª=this.ď[ġ][ĥ];ő.TryGetValue(ª[0],out ċ);Ĩ=this.Ĕ[ġ][ĥ];if(this.Ē[ġ]==true){Ġ=0.0;if(double.TryParse(ª,out Ġ))
Ġ=Math.Min(Math.Max(Ġ,0.0),1.0);Î=(int)((ē[ġ]/œ)*Ġ+0.5);ċ=œ;Ĩ=Î*œ;}if(this.Đ[ġ]>0){ě+=(ē[ġ]-Ĩ);}else if(this.Đ[ġ]==0){ě+=
(ē[ġ]-Ĩ)/2;}while(â<Ĥ&ě>ó-ċ){ĩ.Append(' ');Ī[â][ĥ]=ĩ.ToString();ĩ.Clear();â++;ě-=ó;ó=Ĉ;}ó-=ě;ĩ.Append(Ě("",ě,out ě));ó+=ě
;if(this.Đ[ġ]<0){ě+=(ē[ġ]-Ĩ);}else if(this.Đ[ġ]==0){ě+=(ē[ġ]-Ĩ)-((ē[ġ]-Ĩ)/2);}if(this.Ē[ġ]==true){while(â<Ĥ&Ĩ>ó){Ħ=ó/œ;ó
-=Ħ*œ;Ĩ-=Ħ*œ;ĩ.Append(new String('I',Ħ));Ī[â][ĥ]=ĩ.ToString();ĩ.Clear();â++;ě-=ó;ó=Ĉ;Î-=Ħ;}ª=new String('I',Î);}else{while
(â<Ĥ&Ĩ>ó){Î=0;while(ó>=ċ){ó-=ċ;Ĩ-=ċ;ő.TryGetValue(ª[++Î],out ċ);}ĩ.Append(ª,0,Î);Ī[â][ĥ]=ĩ.ToString();ĩ.Clear();â++;ě-=ó;
ó=Ĉ;ª=ª.Substring(Î);}}ó-=Ĩ;ĩ.Append(ª);}}Ī[â][ĥ]=ĩ.ToString();}return Ī;}public string á(int Ĉ=0){return String.Join(
"\n",this.ħ(Ĉ,1)[0]);}}