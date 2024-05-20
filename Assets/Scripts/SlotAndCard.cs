using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotAndCard : MonoBehaviour
{
    public class EVO
    {
        public EVO(string name, string category, int index)
        {
            Name = name;
            Category = category;
            Index = index;
            this.Trait.Add("Heat Resistance", 0);
            this.Trait.Add("Cold Resistance", 0);
            this.Trait.Add("Can Fly", 0);
            this.Trait.Add("Can Swim", 0);
            this.Trait.Add("Camouflage", 0);
            this.Trait.Add("Multiple Food", 0);
            this.Trait.Add("Speed", 0);
            this.Trait.Add("Environmental Awareness", 0);
            this.Trait.Add("Immunity", 0);
        }
        public EVO()
        {
            this.Trait.Add("Heat Resistance", 0);
            this.Trait.Add("Cold Resistance", 0);
            this.Trait.Add("Can Fly", 0);
            this.Trait.Add("Can Swim", 0);
            this.Trait.Add("Camouflage", 0);
            this.Trait.Add("Multiple Food", 0);
            this.Trait.Add("Speed", 0);
            this.Trait.Add("Environmental Awareness", 0);
            this.Trait.Add("Immunity", 0);
        }
        public void SetTrait(byte HeatResistance = 0, byte ColdResistance = 0, byte CanFly = 0, byte CanSwim = 0, byte Camouflage = 0, byte MultipleFood = 0, byte Speed = 0, byte EnvironmentalAwareness = 0, byte Immunity = 0)
        {
            Trait["Heat Resistance"] = HeatResistance;
            Trait["Cold Resistance"] = ColdResistance;
            Trait["Can Fly"] = CanFly;
            Trait["Can Swim"] = CanSwim;
            Trait["Camouflage"] = Camouflage;
            Trait["Multiple Food"] = MultipleFood;
            Trait["Speed"] = Speed;
            Trait["Environmental Awareness"] = EnvironmentalAwareness;
            Trait["Immunity"] = Immunity;
        }
        public void SetSingleTrait(string toSet, byte value)
        {
            Trait[toSet] = value;
        }
        public void SetHunt(sbyte hl, byte hp)
        {
            HL = hl;
            HP = hp;
        }
        public void SetMutant(EVO mutant)
        {
            this.Mutant = mutant;
        }
        public void SetMaterial(Material material)
        {
            EVOMaterial = material;
        }
        public void AddTraitByOne(string trait)
        {
            Trait[trait]++;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetCategory()
        {
            return Category;
        }
        public int GetIndex()
        {
            return Index;
        }
        public sbyte GetHL()
        {
            return HL;
        }
        public byte GetHP()
        {
            return HP;
        }
        public byte GetTrait(string trait)
        {
            return Trait[trait];
        }
        public EVO GetMutant()
        {
            return Mutant;
        }
        public Material GetMaterial()
        {
            return EVOMaterial;
        }
        readonly string Name;
        readonly string Category;
        readonly int Index;
        sbyte HL;
        byte HP;
        public Dictionary<string, byte> Trait = new Dictionary<string, byte>();
        EVO Mutant = null;
        Material EVOMaterial;
    }

    public EVO Grass = new EVO("Grass", "Species", 0);
    public EVO HotDog = new EVO("(Hot) Dog", "Species", 1);
    public EVO WirelessMouse = new EVO("\"Wireless\" Mouse", "Species", 2);
    public EVO HoneyBee = new EVO("Honey Bee", "Species", 3);
    public EVO Mouse = new EVO("Mouse", "Species", 4);
    public EVO Groundhog = new EVO("Groundhog", "Species", 5);
    public EVO Pigeon = new EVO("Pigeon", "Species", 6);
    public EVO Hornet = new EVO("Hornet", "Species", 7);
    public EVO Snake = new EVO("Snake", "Species", 8);
    public EVO Wolf = new EVO("Wolf", "Species", 9);
    public EVO WinnieThePooh = new EVO("Winnie the Pooh", "Species", 10);
    public EVO Monkey = new EVO("Monkey", "Species", 11);
    public EVO Hippo = new EVO("Hippo", "Species", 12);
    public EVO Ape = new EVO("Ape", "Species", 13);
    public EVO Bear = new EVO("Bear", "Species", 14);
    public EVO Dragon = new EVO("Dragon", "Species", 15);

    public Dictionary<int, EVO> SpeciesDict = new Dictionary<int, EVO>();

    public EVO HeatResistance = new EVO("Heat Resistance", "Trait", 0);
    public EVO ColdResistance = new EVO("Cold Resistance", "Trait", 1);
    public EVO CanFly = new EVO("Can Fly", "Trait", 2);
    public EVO CanSwim = new EVO("Can Swim", "Trait", 3);
    public EVO Camouflage = new EVO("Camouflage", "Trait", 4);
    public EVO MultipleFood = new EVO("Multiple Food", "Trait", 5);
    public EVO Speed = new EVO("Speed", "Trait", 6);
    public EVO EnvironmentalAwareness = new EVO("Environmental Awareness", "Trait", 7);
    public EVO Immunity = new EVO("Immunity", "Trait", 8);
    public EVO TraitExtension = new EVO("Trait Extension", "Trait", 9);

    public Dictionary<int, EVO> TraitDict = new Dictionary<int, EVO>();

    public EVO Mutation = new EVO("Mutation", "Effect", 0);
    public EVO Human = new EVO("Human", "Effect", 1);
    public EVO Drought = new EVO("Drought", "Effect", 2);
    public EVO VolcanicEruption = new EVO("Volcanic Eruption", "Effect", 3);
    public EVO Flood = new EVO("Flood", "Effect", 4);
    public EVO Tornado = new EVO("Tornado", "Effect", 5);
    public EVO Plague = new EVO("Plague", "Effect", 6);
    public EVO Meteorite = new EVO("Meteorite", "Effect", 7);
    public EVO IceAge = new EVO("Ice Age", "Effect", 8);
    public EVO ForestFire = new EVO("Forest Fire", "Effect", 9);

    public Dictionary<int, EVO> EffectDict = new Dictionary<int, EVO>();

    void InitializeSpecies()
    {
        SetSpeciesDict();
        
        Grass.SetTrait(HeatResistance: 1, ColdResistance: 1);
        Grass.SetHunt(0, 1);
        HotDog.SetTrait(ColdResistance: 3);
        HotDog.SetHunt(1, 2);
        HotDog.SetMutant(Wolf);
        WirelessMouse.SetTrait(Camouflage: 1, Speed: 4);
        WirelessMouse.SetHunt(1, 4);
        WirelessMouse.SetMutant(Mouse);
        HoneyBee.SetTrait(CanFly: 2);
        HoneyBee.SetHunt(2, 2);
        HoneyBee.SetMutant(Hornet);
        Mouse.SetTrait(Speed: 3, MultipleFood: 1);
        Mouse.SetHunt(2, 3);
        Mouse.SetMutant(WirelessMouse);
        Groundhog.SetTrait(Camouflage: 1, EnvironmentalAwareness: 1, MultipleFood: 1);
        Groundhog.SetHunt(2, 4);
        Pigeon.SetTrait(CanFly: 1, EnvironmentalAwareness: 1, Speed: 1);
        Pigeon.SetHunt(3, 2);
        Hornet.SetTrait(CanFly: 2, HeatResistance: 1, Speed: 1);
        Hornet.SetHunt(3, 4);
        Hornet.SetMutant(HoneyBee);
        Snake.SetTrait(Camouflage: 1, EnvironmentalAwareness: 1, Speed: 2);
        Snake.SetHunt(3, 5);
        Snake.SetMutant(Dragon);
        Wolf.SetTrait(ColdResistance: 2, EnvironmentalAwareness: 1, Speed: 2);
        Wolf.SetHunt(3, 6);
        Wolf.SetMutant(HotDog);
        WinnieThePooh.SetTrait(EnvironmentalAwareness: 1);
        WinnieThePooh.SetHunt(4, 2);
        WinnieThePooh.SetMutant(Bear);
        Monkey.SetTrait(EnvironmentalAwareness: 1, Speed: 3);
        Monkey.SetHunt(4, 4);
        Monkey.SetMutant(Ape);
        Hippo.SetTrait(CanSwim: 2, ColdResistance: 2, MultipleFood: 1);
        Hippo.SetHunt(5, 7);
        Ape.SetTrait(EnvironmentalAwareness: 2, Speed: 2, MultipleFood: 1);
        Ape.SetHunt(6, 5);
        Ape.SetMutant(Monkey);
        Bear.SetTrait(ColdResistance: 2, EnvironmentalAwareness: 1, Speed: 3);
        Bear.SetHunt(6, 6);
        Bear.SetMutant(WinnieThePooh);
        Dragon.SetTrait(HeatResistance: 2, ColdResistance: 2, CanFly: 2, CanSwim: 2, Camouflage: 2, MultipleFood: 1, EnvironmentalAwareness: 2, Speed: 5);
        Dragon.SetHunt(10, 1);
        Dragon.SetMutant(Snake);

        foreach (KeyValuePair<int, EVO> species in SpeciesDict) species.Value.SetMaterial(Species_Material[species.Value.GetIndex()]);
    }
    void InitializeTrait()
    {
        SetTraitDict();
        
        HeatResistance.SetTrait(HeatResistance: 1);
        ColdResistance.SetTrait(ColdResistance: 1);
        CanFly.SetTrait(CanFly: 1);
        CanSwim.SetTrait(CanSwim: 1);
        Camouflage.SetTrait(Camouflage: 1);
        MultipleFood.SetTrait(MultipleFood: 1);
        Speed.SetTrait(Speed: 1);
        EnvironmentalAwareness.SetTrait(EnvironmentalAwareness: 1);
        Immunity.SetTrait(Immunity: 1);
        TraitExtension.SetTrait();

        foreach (KeyValuePair<int, EVO> trait in TraitDict) trait.Value.SetMaterial(Trait_Material[trait.Value.GetIndex()]);
    }
    void InitializeEffect()
    {
        SetEffectDict();

        foreach (KeyValuePair<int, EVO> effect in EffectDict) effect.Value.SetMaterial(Effect_Material[effect.Value.GetIndex()]);
    }
    void SetSpeciesDict()
    {
        SpeciesDict.Add(Grass.GetIndex(), Grass);
        SpeciesDict.Add(HotDog.GetIndex(), HotDog);
        SpeciesDict.Add(WirelessMouse.GetIndex(), WirelessMouse);
        SpeciesDict.Add(HoneyBee.GetIndex(), HoneyBee);
        SpeciesDict.Add(Mouse.GetIndex(), Mouse);
        SpeciesDict.Add(Groundhog.GetIndex(), Groundhog);
        SpeciesDict.Add(Pigeon.GetIndex(), Pigeon);
        SpeciesDict.Add(Hornet.GetIndex(), Hornet);
        SpeciesDict.Add(Snake.GetIndex(), Snake);
        SpeciesDict.Add(Wolf.GetIndex(), Wolf);
        SpeciesDict.Add(WinnieThePooh.GetIndex(), WinnieThePooh);
        SpeciesDict.Add(Monkey.GetIndex(), Monkey);
        SpeciesDict.Add(Hippo.GetIndex(), Hippo);
        SpeciesDict.Add(Ape.GetIndex(), Ape);
        SpeciesDict.Add(Bear.GetIndex(), Bear);
        SpeciesDict.Add(Dragon.GetIndex(), Dragon);
    }
    void SetTraitDict()
    {
        TraitDict.Add(HeatResistance.GetIndex(), HeatResistance);
        TraitDict.Add(ColdResistance.GetIndex(), ColdResistance);
        TraitDict.Add(CanFly.GetIndex(), CanFly);
        TraitDict.Add(CanSwim.GetIndex(), CanSwim);
        TraitDict.Add(Camouflage.GetIndex(), Camouflage);
        TraitDict.Add(MultipleFood.GetIndex(), MultipleFood);
        TraitDict.Add(Speed.GetIndex(), Speed);
        TraitDict.Add(EnvironmentalAwareness.GetIndex(), EnvironmentalAwareness);
        TraitDict.Add(Immunity.GetIndex(), Immunity);
        TraitDict.Add(TraitExtension.GetIndex(), TraitExtension);
    }
    void SetEffectDict()
    {
        EffectDict.Add(Mutation.GetIndex(), Mutation);
        EffectDict.Add(Human.GetIndex(), Human);
        EffectDict.Add(Drought.GetIndex(), Drought);
        EffectDict.Add(VolcanicEruption.GetIndex(), VolcanicEruption);
        EffectDict.Add(Flood.GetIndex(), Flood);
        EffectDict.Add(Tornado.GetIndex(), Tornado);
        EffectDict.Add(Plague.GetIndex(), Plague);
        EffectDict.Add(Meteorite.GetIndex(), Meteorite);
        EffectDict.Add(IceAge.GetIndex(), IceAge);
        EffectDict.Add(ForestFire.GetIndex(), ForestFire);
    }

    public GameObject Manager;
    public GameObject[] CardDecks, Slots, ResetSlotButtons, MutateTypeDisplayer, PlusHPDisplayer;
    public Material[] Slot_Empty_Material, Slot_Species_Material, Slot_Trait_Material, Slot_Effect_Material, Species_Material, Trait_Material, Effect_Material, Card_Back_Material;
    public Transform CardCopies, CardPlayed;
    public GameObject PlayedReader, CardTemplate;
    int Holding;
    int[] SpeciesDeck = { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15};
    int[] TraitDeck = { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 9, 9};
    int[] EffectDeck = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 2, 2, 2, 3, 3, 4, 4, 5, 5, 5, 6, 6, 6, 6, 7, 8, 9};

    
    byte HandIndex;
    byte[,] Hands = {
        { 0, 0, 0, 0, 0 },
        { 1, 1, 1, 1, 1 },
        { 1, 2, 3, 4, 5 },
        { 1, 1, 1, 1, 2 },
        { 1, 1, 1, 2, 2 },
        { 1, 1, 1, 0, 0 },
        { 1, 1, 2, 2, 3 },
        { 1, 1, 0, 0, 0 },
        { 1, 0, 0, 0, 0 }
    };
    string[] HandNames =
    {
        "",
        "Five of a Kind",
        "Straight",
        "Four of a Kind",
        "Full House",
        "Three of a Kind",
        "Two Pair",
        "Pair",
        "Single"
    };
    public GameObject HandName;
    
    public void SetHand(int handindex)
    {
        HandIndex = (byte)handindex;
        for (byte j = 0; j < 5; j++)
        {
            if (Hands[HandIndex, j] == 0) ReturnSlot(j);
            if (SlotContents[j].Main == null) Slots[j].GetComponent<Renderer>().material = Slot_Empty_Material[Hands[HandIndex, j]];
        }
        HandName.GetComponent<Text>().text = HandNames[HandIndex];
    }
    public void SwitchHand(bool dir)
    {
        if (dir)
        {
            if (HandIndex >= 8) HandIndex = 1;
            else HandIndex++;
        }
        else
        {
            if (HandIndex <= 1) HandIndex = 8;
            else HandIndex--;
        }
        SetHand(HandIndex);
    }

    int MaxCardCount = 16;
    public GameObject MaxCardCountDisplayer;
    public void ChangeMaxCardCount(bool dir)
    {
        if (dir)
        {
            if(MaxCardCount < 20) MaxCardCount++;
        }
        else
        {
            if (MaxCardCount > 13)  MaxCardCount--;
        }
        MaxCardCountDisplayer.GetComponent<Text>().text = "Card Max Count: " + MaxCardCount;
    }

    int GetDroppedSlot(GameObject gameobject)
    {
        int r = -1;
        for (int i = 0; i < Slots.Length; i++)
        {
            if (gameobject.transform.position.x < Slots[i].transform.position.x + (Slots[i].transform.localScale.x / 2) + 1 &&
                gameobject.transform.position.x > Slots[i].transform.position.x - (Slots[i].transform.localScale.x / 2) - 1 &&
                gameobject.transform.position.z < Slots[i].transform.position.z + (Slots[i].transform.localScale.z / 2) + 2 &&
                gameobject.transform.position.z > Slots[i].transform.position.z - (Slots[i].transform.localScale.z / 2) - 2
                )
            {
                r = i;
                break;
            }
        }
        return r;
    }

    void Shuffle(int[] cardDeck, int n)
    {
        for (var i = 1; i < n; i++)
        {
            int r = i + Random.Range(1, n - i);
            int temp = cardDeck[r];
            cardDeck[r] = cardDeck[i];
            cardDeck[i] = temp;
        }
    }

    SlotContent[] SlotContents = new SlotContent[5];
    void InitializeSlotContents()
    {
        for (var i = 0; i < 5; i++)
        {
            Manager.GetComponent<SlotAndCard>().SlotContents[i] = new SlotContent();
            Manager.GetComponent<SlotAndCard>().ResetSlotButtons[i].SetActive(false);
            Manager.GetComponent<SlotAndCard>().MutateTypeDisplayer[i].SetActive(false);
            Manager.GetComponent<SlotAndCard>().PlusHPDisplayer[i].SetActive(false);
        }
    }

    int CloneCount = 0, DisplayCount = 0;
    void GenerateCardCopy(EVO ID, double ipx = 0, double ipy = -5.13, double ipz = -8.4, double irx = 0, double iry = 0, double irz = 0)
    {
        GameObject clone = Instantiate(CardTemplate, new Vector3((float)ipx, (float)ipy, (float)ipz), Quaternion.Euler((float)irx, (float)iry, (float)irz), CardCopies);
        clone.GetComponent<Card>().ID = ID;
        clone.transform.GetChild(0).transform.GetComponent<Renderer>().material = ID.GetMaterial();
        clone.transform.GetComponent<Renderer>().material = Card_Back_Material[ID.GetCategory() == "Species" ? 0 : (ID.GetCategory() == "Trait" ? 1 : 2)];
        clone.SetActive(true);
        CloneCount++;
    }
    class SlotContent
    {
        public SlotContent()
        {

        }
        public EVO Main = null;
        public bool? MutateType = null;
        public byte SpeedCount = 0;
        public byte EnvironmentalAwarenessCount = 0;
        public byte PlusHP = 0;
        public void SetEVO(EVO toSet)
        {
            Main = toSet;
        }
        public void AddEVO(string toAdd)
        {
            if (toAdd == "Mutation")
            {
                MutateType = true;
                Main = Main.GetMutant();
            }
            else if (toAdd == "Human")
            {
                MutateType = false;
                Main = Main.GetMutant();
            }
            else if (toAdd == "Speed")
            {
                SpeedCount++;
                PlusHP += 1;
            }
            else if (toAdd == "Environmental Awareness")
            {
                EnvironmentalAwarenessCount++;
                PlusHP += 2;
            }
        }
    }
    bool SlotMutatedCheck(int slot)
    {
        if (Manager.GetComponent<SlotAndCard>().SlotContents[slot].MutateType == null) return true;
        else return false;
    }
    byte SlotTraitCheck(int slot, string toCheck, bool add)
    {
        int exceed = 0, speed = 0, environmental_awareness = 0;
        speed = Manager.GetComponent<SlotAndCard>().SlotContents[slot].Main.GetTrait("Speed") + Manager.GetComponent<SlotAndCard>().SlotContents[slot].SpeedCount;
        environmental_awareness = Manager.GetComponent<SlotAndCard>().SlotContents[slot].Main.GetTrait("Environmental Awareness") + Manager.GetComponent<SlotAndCard>().SlotContents[slot].EnvironmentalAwarenessCount;
        //Debug.Log("(Before Adding) Speed: " + speed + ", EA: " + environmental_awareness);
        
        if (toCheck == "Speed")
        {
            if (add) speed++;
            exceed = speed - 6;
        }
        else if (toCheck == "Environmental Awareness")
        {
            if (add) environmental_awareness++; 
            exceed = environmental_awareness - 3;
        }
        if (exceed < 0) exceed = 0;
        return (byte)exceed;
    }
    /*public GameObject TraitExtensionInterface;
    byte TraitExtendionChoice = 10;
    public void ChooseTraitExtension(int index)
    {
        TraitExtendionChoice = (byte)index;
    }*/
    bool SlotOPLegal(int slot, EVO toAdd)
    {
        /*if (toAdd.GetName() == "Trait Extension")
        {
            TraitExtensionInterface.SetActive(true);
            
            toAdd = TraitDict[TraitExtendionChoice];
            TraitExtensionInterface.SetActive(false);
            TraitExtendionChoice = 10;
        }*/
        if (Manager.GetComponent<SlotAndCard>().SlotContents[slot].Main == null)
        {
            Manager.GetComponent<SlotAndCard>().SlotContents[slot].SetEVO(toAdd);
            return true;
        }
        else
        {
            if (Manager.GetComponent<SlotAndCard>().SlotContents[slot].Main.GetCategory() == "Species")
            {
                if (toAdd == Mutation || toAdd == Human)
                {
                    if (SlotMutatedCheck(slot))
                    {
                        if (Manager.GetComponent<SlotAndCard>().SlotContents[slot].Main.GetMutant() != null)
                        {
                            Manager.GetComponent<SlotAndCard>().SlotContents[slot].AddEVO(toAdd.GetName());
                            byte SpeedExceed = SlotTraitCheck(slot, "Speed", false);
                            byte EnvironmentalAwarenessExceed = SlotTraitCheck(slot, "Environmental Awareness", false);
                            if (SpeedExceed > 0 || EnvironmentalAwarenessExceed > 0)
                            {
                                while (SpeedExceed > 0)
                                {
                                    Debug.Log("Speed Exceed: " + SpeedExceed);
                                    GenerateCardCopy(Speed);
                                    Manager.GetComponent<SlotAndCard>().SlotContents[slot].SpeedCount--;
                                    Manager.GetComponent<SlotAndCard>().SlotContents[slot].PlusHP -= 1;
                                    SpeedExceed--;
                                }
                                while (EnvironmentalAwarenessExceed > 0)
                                {
                                    Debug.Log("Environmental Awareness Exceed: " + EnvironmentalAwarenessExceed); 
                                    GenerateCardCopy(EnvironmentalAwareness);
                                    Manager.GetComponent<SlotAndCard>().SlotContents[slot].EnvironmentalAwarenessCount--;
                                    Manager.GetComponent<SlotAndCard>().SlotContents[slot].PlusHP -= 2;
                                    EnvironmentalAwarenessExceed--;
                                }
                                if (Manager.GetComponent<SlotAndCard>().SlotContents[slot].PlusHP > 0)
                                {
                                    PlusHPDisplayer[slot].GetComponent<Text>().text = "+" + Manager.GetComponent<SlotAndCard>().SlotContents[slot].PlusHP;
                                    PlusHPDisplayer[slot].SetActive(true);
                                }
                                else
                                {
                                    PlusHPDisplayer[slot].SetActive(false);
                                }
                            }
                            return true;
                        }
                        else
                        {
                            Debug.Log("Cannot Mutate");
                            return false;
                        }
                    }
                    else
                    {
                        Debug.Log("Already Mutated");
                        return false;
                    }
                }
                if (toAdd == Speed || toAdd == EnvironmentalAwareness)
                {
                    if (SlotTraitCheck(slot, toAdd == Speed ? "Speed" : "Environmental Awareness", true) == 0)
                    {
                        Manager.GetComponent<SlotAndCard>().SlotContents[slot].AddEVO(toAdd.GetName());
                        return true;
                    }
                    else
                    {
                        Debug.Log("Trait Check Failed");
                        return false;
                    }
                }
            }
            else
            {
                Debug.Log("Multiple Main");
                return false;
            }
        }
        return false;
    }
    public void ReturnSlot(int slot)
    {
        SlotContent ToReturn = Manager.GetComponent<SlotAndCard>().SlotContents[slot];
        if (ToReturn.Main == null) return;
        if (ToReturn.MutateType == null) GenerateCardCopy(ToReturn.Main);
        else GenerateCardCopy(ToReturn.Main.GetMutant());
        if (ToReturn.MutateType == true) GenerateCardCopy(Mutation);
        else if (ToReturn.MutateType == false) GenerateCardCopy(Human);
        for (var i = 0; i < ToReturn.SpeedCount; i++) GenerateCardCopy(Speed);
        for (var i = 0; i < ToReturn.EnvironmentalAwarenessCount; i++) GenerateCardCopy(EnvironmentalAwareness);
        Manager.GetComponent<SlotAndCard>().SlotContents[slot] = new SlotContent();
        Slots[slot].transform.GetComponent<Renderer>().material = Slot_Empty_Material[Hands[HandIndex, slot]];
        ResetSlotButtons[slot].SetActive(false);
        MutateTypeDisplayer[slot].SetActive(false);
        PlusHPDisplayer[slot].SetActive(false);
    }
    public void DrawFromDeck(int cardDeck)
    {
        if (Holding < MaxCardCount)
        {
            EVO drawn = new EVO();
            if (cardDeck == 0)
            {
                if (SpeciesDeck[0] < 60)
                {
                    drawn = SpeciesDict[SpeciesDeck[1 + SpeciesDeck[0]]];
                    SpeciesDeck[0]++;
                }
                else return;
            }
            else if (cardDeck == 1)
            {
                if (TraitDeck[0] < 58)
                {
                    drawn = TraitDict[TraitDeck[1 + TraitDeck[0]]];
                    TraitDeck[0]++;
                }
                else return;
            }
            else
            {
                if (EffectDeck[0] < 30)
                {
                    drawn = EffectDict[EffectDeck[1 + EffectDeck[0]]];
                    EffectDeck[0]++;
                }
                else return;
            }
            GenerateCardCopy(drawn, ipx: CardDecks[cardDeck].transform.position.x, ipy: -4, ipz: CardDecks[cardDeck].transform.position.z);
            CardCopies.GetChild(CloneCount - 1).transform.rotation = Quaternion.Euler(-180, 0, 0);
            CardCopies.GetChild(CloneCount - 1).transform.GetComponent<Card>().DrawAnimation();
            Holding++;
        }
    }
    
    bool SameSlotContent(byte a, byte b)
    {
        bool same = false;
        if (Manager.GetComponent<SlotAndCard>().SlotContents[a].Main.GetName() == Manager.GetComponent<SlotAndCard>().SlotContents[b].Main.GetName() && Manager.GetComponent<SlotAndCard>().SlotContents[a].PlusHP == Manager.GetComponent<SlotAndCard>().SlotContents[b].PlusHP)
        {
            same = true;
        }
        return same;
    }
    bool CheckHand()
    {
        bool legal = true;
        switch (HandIndex)
        {
            case 0: //null
                return false;
            case 1: //Five of a Kind
                for (byte i = 0; i < 5; i++)
                {
                    if (Manager.GetComponent<SlotAndCard>().SlotContents[i].Main == null)
                    {
                        return false;
                    }
                }
                for (byte i = 1; i < 5; i++)
                {
                    if (!SameSlotContent(0, i))
                    {
                        return false;
                    }
                }
                break;
            case 2: //Straight
                for (byte i = 0; i < 5; i++)
                {
                    if (Manager.GetComponent<SlotAndCard>().SlotContents[i].Main == null)
                    {
                        return false;
                    }
                }
                int HL = Manager.GetComponent<SlotAndCard>().SlotContents[0].Main.GetHL();
                for (int i = 1; i < 5; i++)
                {
                    HL++;
                    if (Manager.GetComponent<SlotAndCard>().SlotContents[i].Main.GetHL() != HL)
                    {
                        return false;
                    }
                }
                break;
            case 3: //Four of a Kind
                for (byte i = 0; i < 5; i++)
                {
                    if (Manager.GetComponent<SlotAndCard>().SlotContents[i].Main == null)
                    {
                        return false;
                    }
                }
                for (byte i = 1; i < 4; i++)
                {
                    if (!SameSlotContent(0, i))
                    {
                        return false;
                    }
                }
                break;
            case 4: //Full House
                for (byte i = 0; i < 5; i++)
                {
                    if (Manager.GetComponent<SlotAndCard>().SlotContents[i].Main == null)
                    {
                        return false;
                    }
                }
                for (byte i = 1; i < 3; i++)
                {
                    if (!SameSlotContent(0, i))
                    {
                        return false;
                    }
                }
                if (!SameSlotContent(3, 4))
                {
                    return false;
                }
                break;
            case 5: //Three of a Kind
                for (byte i = 0; i < 3; i++)
                {
                    if (Manager.GetComponent<SlotAndCard>().SlotContents[i].Main == null)
                    {
                        return false;
                    }
                }
                for (byte i = 1; i < 3; i++)
                {
                    if (!SameSlotContent(0, i))
                    {
                        return false;
                    }
                }
                break;
            case 6: //Two Pair
                for (byte i = 0; i < 5; i++)
                {
                    if (Manager.GetComponent<SlotAndCard>().SlotContents[i].Main == null)
                    {
                        return false;
                    }
                }
                if (!SameSlotContent(0, 1))
                {
                    return false;
                }
                if (!SameSlotContent(2, 3))
                {
                    return false;
                }
                break;
            case 7: //Pair
                for (byte i = 0; i < 2; i++)
                {
                    if (Manager.GetComponent<SlotAndCard>().SlotContents[i].Main == null)
                    {
                        return false;
                    }
                }
                if (!SameSlotContent(0, 1))
                {
                    return false;
                }
                break;
            case 8: //Single
                if (Manager.GetComponent<SlotAndCard>().SlotContents[0].Main == null)
                {
                    return false;
                }
                break;
            default:
                return false;
        }
        return legal;
    }
    bool? ABeatB(EVO A, EVO B) // no Five of Grass, Great Disaster
    {
        if (B == null) return true;
        else if (A.GetCategory() == "Trait")
        {
            return false;
        }
        else if (A.GetCategory() == "Effect")
        {
            if (B.GetName() == "Mutation" || B.GetName() == "Human") return true;
            else if (B.GetCategory() == "Effect") return false;
            else
            {
                if (A.GetName() == "Mutation" || A.GetName() == "Human")
                {
                    if (B.GetCategory() == "Trait")
                    {
                        Debug.Log("Beat");
                        return true;
                    }
                    else if (B.GetMutant() != null)
                    {
                        Debug.Log("Mutate");
                        return null;
                    }
                    else
                    {
                        Debug.Log(B.GetName());
                        Debug.Log("No Mutant");
                        return false;
                    }
                }
                else
                {
                    EVO b;
                    if (Humaned) b = new EVO(B.GetMutant().GetName(), B.GetMutant().GetCategory(), B.GetMutant().GetIndex());
                    else b = new EVO(B.GetName(), B.GetCategory(), B.GetIndex());
                    foreach (KeyValuePair<string, byte> x in (Humaned ? B.GetMutant() : B).Trait)
                    {
                        if (x.Value != 0) b.SetSingleTrait(x.Key, x.Value);
                        //Debug.Log(x.Key + ": " + x.Value);
                    }
                    bool beat = true;
                    switch (A.GetIndex())
                    {
                        case 2:
                            if (b.GetTrait("Heat Resistance") >= 1 || b.GetTrait("Multiple Food") >= 1) beat = false;
                            else beat = true;
                            break;
                        case 3:
                            if (b.GetTrait("Heat Resistance") >= 2) beat = false;
                            else beat = true;
                            break;
                        case 4:
                            if (b.GetTrait("Can Swim") >= 2) beat = false;
                            else beat = true;
                            break;
                        case 5:
                            beat = true;
                            break;
                        case 6:
                            if (b.GetTrait("Immunity") >= 1) beat = false;
                            else beat = true;
                            break;
                        case 7:
                            if (b.GetTrait("Heat Resistance") >= 3) beat = false;
                            else beat = true;
                            break;
                        case 8:
                            if (b.GetTrait("Cold Resistance") >= 3) beat = false;
                            else beat = true;
                            break;
                        case 9:
                            if (b.GetTrait("Heat Resistance") >= 3 && b.GetTrait("Multiple Food") >= 1) beat = false;
                            else beat = true;
                            break;
                    }
                    //Debug.Log(beat ? "Effect Wins" : "Effect Resisted");
                    if (beat) Humaned = false;
                    return beat;
                }
            }
        }
        else
        {
            if (B.GetCategory() == "Trait" || B.GetName() == "Mutation" || B.GetName() == "Human")
            {
                Debug.Log("Beat Weak Card");
                return true;
            }
            else if (B.GetCategory() == "Effect")
            {
                Debug.Log("Cannot Beat Effect");
                return false;
            }
            else if (A.GetHL() > B.GetHL())
            {
                Debug.Log("HL Wins");
                return true;
            }
            else if (A.GetHL() == B.GetHL() && A.GetHP() > B.GetHP())
            {
                Debug.Log("HP Wins");
                return true;
            }
            else
            {
                Debug.Log("HP Does Not Win");
                return false;
            }
        }
    }
    void PrepareCard()
    {
        SpeciesDeck[0] = 0;
        TraitDeck[0] = 0;
        EffectDeck[0] = 0;
        Shuffle(Manager.GetComponent<SlotAndCard>().SpeciesDeck, 60);
        Shuffle(Manager.GetComponent<SlotAndCard>().TraitDeck, 58);
        Shuffle(Manager.GetComponent<SlotAndCard>().EffectDeck, 30);
    }
    void ClearCard()
    {
        for (int i = 0; i < CardCopies.childCount; i++)
        {
            Destroy(CardCopies.GetChild(i).gameObject);
            CloneCount--;
        }
        for (int i = 0; i < CardPlayed.childCount; i++)
        {
            Destroy(CardPlayed.GetChild(i).gameObject);
            DisplayCount--;
        }
    }
    EVO SlotContentsToEVO()
    {
        byte slot = (byte)(HandIndex == 2 ? 4 : 0);
        EVO r = new EVO(SlotContents[slot].Main.GetName(), SlotContents[slot].Main.GetCategory(), SlotContents[slot].Main.GetIndex());
        if (r.GetCategory() == "Trait")
        {
            for (int i = 0; i < 5; i++)
            {
                if (SlotContents[i].Main == null) break;
                else if (SlotContents[i].Main.GetCategory() == "Trait")
                {
                    if (SlotContents[i].Main.GetIndex() != 9)
                    {
                        r.AddTraitByOne(SlotContents[i].Main.GetName());
                    }
                }
            }
        }
        else if (r.GetCategory() == "Species")
        {
            foreach (KeyValuePair<string, byte> x in SpeciesDict[SlotContents[slot].Main.GetIndex()].Trait)
            {
                if (x.Value != 0) r.SetSingleTrait(x.Key, x.Value);
            }
            r.SetHunt(SlotContents[slot].Main.GetHL(), (byte)(SlotContents[slot].Main.GetHP() + SlotContents[slot].PlusHP));
            r.SetMutant(SlotContents[slot].Main.GetMutant());
        }
        return r;
    }
    EVO PrevEVO = new EVO();
    int PlayedHand, PrevHand = 0;
    bool Humaned = false;
    void DisplayPlayedHand()
    {
        for (int i = 0; i < 5; i++)
        {
            if (SlotContents[i].Main == null) break;
            Holding--;
            if (SlotContents[i].MutateType != null) Holding--;
            Holding -= SlotContents[i].SpeedCount + SlotContents[i].EnvironmentalAwarenessCount;
            GameObject clone = Instantiate(CardTemplate, new Vector3(-4f + 3 * i, -5 + 0.05f * DisplayCount, 0), Quaternion.Euler(0, Random.Range(-10.0f, 10.0f), -5), CardPlayed);
            clone.GetComponent<Card>().ID = SlotContents[i].Main;
            clone.transform.GetChild(0).transform.GetComponent<Renderer>().material = clone.GetComponent<Card>().ID.GetMaterial();
            clone.transform.tag = "Untagged";
            clone.SetActive(true);
            DisplayCount++;
        }
    }
    void PlayedReaderAnimation(string name, int plusHP, int hand)
    {
        string human_str = (Humaned ? "(Human) " : "");
        name += (plusHP > 0 ? (" +" + plusHP) : "");
        string played;
        switch (hand)
        {
            case 1:
                played = human_str + "Five of " + name;
                break;
            case 3:
                played = human_str + "Four of " + name;
                break;
            case 5:
                played = human_str + "Three of " + name;
                break;
            case 8:
                played = human_str + name;
                break;
            default:
                played = human_str + name + " " + HandNames[hand];
                break;
        }
        PlayedReader.GetComponent<Text>().text = played;
        PlayedReader.SetActive(true);
    }
    void PlayHandProcedure(bool beat)
    {
        string name;
        int plusHP = 0;
        if (SlotContents[(HandIndex == 2 ? 4 : 0)].MutateType == false) Humaned = !Humaned;
        if (beat == true)
        {
            PrevEVO = SlotContentsToEVO();
            name = PrevEVO.GetName();
            if (PrevEVO.GetCategory() == "Species")
            {
                plusHP = PrevEVO.GetHP() - SpeciesDict[PrevEVO.GetIndex()].GetHP();
            }
        }
        else
        {
            EVO temp = PrevEVO;
            PrevEVO = new EVO(temp.GetMutant().GetName(), temp.GetMutant().GetCategory(), temp.GetMutant().GetIndex());
            foreach (KeyValuePair<string, byte> x in temp.GetMutant().Trait)
            {
                if (x.Value != 0) PrevEVO.SetSingleTrait(x.Key, x.Value);
            }
            PrevEVO.SetMutant(SpeciesDict[temp.GetIndex()]);
            name = PrevEVO.GetName();
            plusHP = temp.GetHP() - SpeciesDict[temp.GetIndex()].GetHP();
            PrevEVO.SetHunt(temp.GetMutant().GetHL(), (byte)(plusHP + temp.GetMutant().GetHP()));
        }
        PlayedReaderAnimation(name, plusHP, PlayedHand);
        PrevHand = PlayedHand;
        DisplayPlayedHand();
        InitializeSlotContents();
        SetHand(PrevHand);
    }
    public void PlayHand()
    {
        if (CheckHand())
        {
            EVO t = SlotContentsToEVO();
            PlayedHand = HandIndex;
            if (PrevHand == 0) PlayHandProcedure(true);
            else
            {
                if (PrevEVO.GetName() == "Grass" && PrevHand == 1)
                {
                    Debug.Log("Cannot Beat Five of a Grass");
                    return;
                }
                else if (t.GetName() == "Grass" && PlayedHand == 1)
                {
                    Debug.Log("Five of a Grass!");
                    PlayHandProcedure(true);
                }
                else if (PrevEVO.GetName() == "Meteorite" || PrevEVO.GetName() == "Ice Age" || PrevEVO.GetName() == "Forest Fire")
                {
                    Debug.Log("Cannot Beat Great Disasters");
                    return;
                }
                else if (t.GetName() == "Meteorite" || t.GetName() == "Ice Age" || t.GetName() == "Forest Fire")
                {
                    if (PrevEVO.GetCategory() == "Effect" || ABeatB(t, PrevEVO) == true)
                    {
                        Debug.Log("Great Disaster!");
                        PlayHandProcedure(true);
                    }
                    else
                    {
                        Debug.Log("Great Disaster Resisted");
                        return;
                    }
                }
                else if (PlayedHand != PrevHand)
                {
                    if (PlayedHand <= 3 && PlayedHand < PrevHand)
                    {
                        Debug.Log("Hand Type Wins");
                        PlayHandProcedure(true);
                    }
                    else
                    {
                        Debug.Log("Hand Does Not Match With Previous Hand");
                        return;
                    }
                }
                else
                {
                    if (ABeatB(t, PrevEVO) == true) PlayHandProcedure(true);
                    else if (ABeatB(t, PrevEVO) == null)
                    {
                        if (t.GetName() == "Human") Humaned = !Humaned;
                        PlayHandProcedure(false);
                    }
                }
            }
        }
        else
        {
            Debug.Log("Hand Format Does Not Match");
        }
    }
    public void Pass()
    {
        PrevEVO = new EVO();
        PrevHand = 0;
        PlayedReader.GetComponent<Text>().text = "";
        for (int i = 0; i < CardPlayed.childCount; i++)
        {
            Destroy(CardPlayed.GetChild(i).gameObject);
            DisplayCount--;
        }
        Humaned = false;
    }
    public void Restart()
    {
        InitializeSlotContents();
        HandIndex = 0;
        ClearCard();
        PrepareCard();
        PrevEVO = new EVO();
        PrevHand = 0;
        SetHand(0);
        Holding = 0;
        PlayedReader.GetComponent<Text>().text = "";
        Humaned = false;
    }
    int DrawToFront_cardDeck;
    float DrawToFront_x;
    void DrawToFront()
    {
        EVO drawn = new EVO();
        if (DrawToFront_cardDeck == 0)
        {
            if (SpeciesDeck[0] < 60)
            {
                drawn = SpeciesDict[SpeciesDeck[1 + SpeciesDeck[0]]];
                SpeciesDeck[0]++;
            }
        }
        else if (DrawToFront_cardDeck == 1)
        {
            if (TraitDeck[0] < 58)
            {
                drawn = TraitDict[TraitDeck[1 + TraitDeck[0]]];
                TraitDeck[0]++;
            }
        }
        else
        {
            if (EffectDeck[0] < 30)
            {
                drawn = EffectDict[EffectDeck[1 + EffectDeck[0]]];
                EffectDeck[0]++;
            }
        }
        GenerateCardCopy(drawn, ipx: CardDecks[DrawToFront_cardDeck].transform.position.x, ipy: -4, ipz: CardDecks[DrawToFront_cardDeck].transform.position.z, irx: 180, irz: -8);
        CardCopies.GetChild(CloneCount - 1).transform.GetComponent<Card>().DrawAnimation(DrawToFront_x, -3.5f, -7, -8);
    }
    public void OpeningDraw()
    {
        int count;
        float dis = 1.7f;
        for (count = 0; count < 6; count++)
        {
            DrawToFront_cardDeck = 1;
            DrawToFront_x = (-6 + count) * dis;
            DrawToFront();
        }
        for (count = 6; count < 12; count++)
        {
            DrawToFront_cardDeck = 0;
            DrawToFront_x = (-6 + count) * dis;
            DrawToFront();
        }
        for (count = 12; count < 13; count++)
        {
            DrawToFront_cardDeck = 2;
            DrawToFront_x = (-6 + count) * dis;
            DrawToFront();
        }
        Holding = 13;
    }
    
    void Awake()
    {
        if (CompareTag("Manager"))
        {
            InitializeSpecies();
            InitializeTrait();
            InitializeEffect();
            InitializeSlotContents();
            CardCopies = transform.GetChild(0);
            CardPlayed = transform.GetChild(1);
            HandIndex = 0;
            Humaned = false;
            ClearCard();
            PrepareCard();
            OpeningDraw();
            PlayedReader.GetComponent<Text>().text = "";
        }
    }
    void Update()
    {
        if (CompareTag("Manager"))
        {
            if (Manager.GetComponent<Grabber>().grabbedCard != null)
            {
                GameObject grabbedCard = GetComponent<Grabber>().grabbedCard;
                EVO grabbedEVO = grabbedCard.transform.GetComponent<Card>().ID;
                Vector3 ObjectPosition = GetComponent<Grabber>().ObjectPosition(x_offset: -1, y_offset: -4.15f);
                if (grabbedCard.GetComponent<Grabbed>().dropped == false)
                {
                    grabbedCard.transform.position = ObjectPosition;
                    grabbedCard.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else if (GetComponent<Grabber>().grabbedCard.GetComponent<Grabbed>().dropped == true)
                {
                    if (GetDroppedSlot(grabbedCard) != -1 && Hands[HandIndex, GetDroppedSlot(grabbedCard)] != 0 && SlotOPLegal(GetDroppedSlot(grabbedCard), grabbedEVO))
                    {
                        EVO Update = Manager.GetComponent<SlotAndCard>().SlotContents[GetDroppedSlot(grabbedCard)].Main;
                        if (Update.GetCategory() == "Species")
                        {
                            Slots[GetDroppedSlot(grabbedCard)].GetComponent<Renderer>().material = Slot_Species_Material[Update.GetIndex()];
                        }
                        else if (Update.GetCategory() == "Trait")
                        {
                            Slots[GetDroppedSlot(grabbedCard)].GetComponent<Renderer>().material = Slot_Trait_Material[Update.GetIndex()];
                        }
                        else if (Update.GetCategory() == "Effect")
                        {
                            Slots[GetDroppedSlot(grabbedCard)].GetComponent<Renderer>().material = Slot_Effect_Material[Update.GetIndex()];
                        }
                        if (Manager.GetComponent<SlotAndCard>().SlotContents[GetDroppedSlot(grabbedCard)].PlusHP > 0)
                        {
                            PlusHPDisplayer[GetDroppedSlot(grabbedCard)].GetComponent<Text>().text = "+" + Manager.GetComponent<SlotAndCard>().SlotContents[GetDroppedSlot(grabbedCard)].PlusHP;
                            PlusHPDisplayer[GetDroppedSlot(grabbedCard)].SetActive(true);
                        }
                        else PlusHPDisplayer[GetDroppedSlot(grabbedCard)].SetActive(false);
                        if (Manager.GetComponent<SlotAndCard>().SlotContents[GetDroppedSlot(grabbedCard)].MutateType == true)
                        {
                            MutateTypeDisplayer[GetDroppedSlot(grabbedCard)].GetComponent<Text>().text = "M";
                            MutateTypeDisplayer[GetDroppedSlot(grabbedCard)].SetActive(true);
                        }
                        else if (Manager.GetComponent<SlotAndCard>().SlotContents[GetDroppedSlot(grabbedCard)].MutateType == false)
                        {
                            MutateTypeDisplayer[GetDroppedSlot(grabbedCard)].GetComponent<Text>().text = "H";
                            MutateTypeDisplayer[GetDroppedSlot(grabbedCard)].SetActive(true);
                        }
                        ResetSlotButtons[GetDroppedSlot(grabbedCard)].SetActive(true);
                        Destroy(grabbedCard);
                        CloneCount--;
                    }
                    else
                    {
                        grabbedCard.transform.rotation = Quaternion.Euler(-15, 0, 0);
                    }
                    grabbedCard.GetComponent<Grabbed>().dropped = null;
                    Manager.GetComponent<Grabber>().grabbedCard = null;
                }
            }
            else if (Manager.GetComponent<Grabber>().grabbedCardDeck != null)
            {
                GameObject grabbedCardDeck = GetComponent<Grabber>().grabbedCardDeck;
                for (var i = 0; i < 3; i++)
                {
                    if (CardDecks[i] == grabbedCardDeck)
                    {
                        DrawFromDeck(i);
                        Manager.GetComponent<Grabber>().grabbedCardDeck = null;
                        break;
                    }
                }
            }
        }
    }
}
