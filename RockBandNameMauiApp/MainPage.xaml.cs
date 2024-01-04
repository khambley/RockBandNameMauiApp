using Microsoft.Maui.Devices;
namespace RockBandNameMauiApp;


public partial class MainPage : ContentPage
{
	// For iOS Test Ads:
	// AdsId="ca-app-pub-3940256099942544/2934735716"
	// For Android Test Ads:
	// AdsId="ca-app-pub-3940256099942544/6300978111"
	public List<string> AdjectiveList { get; set; }
    public List<string> NounList { get; set; } 
	public List<string> CoolPhrasesList { get; set; }

	public MainPage()
	{
		InitializeComponent();
		// Get Metrics
		var metrics = DeviceDisplay.MainDisplayInfo;
        // if(metrics.Height > 2000)
        // {
        // 	rockMusicLogo.Margin = new Thickness(0, 30, 0, 30);
        // }

		// Google Test Ad unit Ids
        //myAds.AdsId = DeviceInfo.Platform == DevicePlatform.Android ? "ca-app-pub-3940256099942544/6300978111" : "ca-app-pub-3940256099942544/2934735716";

		// My production Ad unit Ids
		// Add the ad unit Ids back in before building.
        myAds.AdsId = DeviceInfo.Platform == DevicePlatform.Android ? "not added to source control" : "not added to source control";

        if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			rockMusicLogo.Source = "rockmusiclogo1.png";
		}

		var adjectiveString = "Lovely\nAggressive\nAdorable\nAiry\nAngelic\nAngry\nAnnoying\nAntsy\nArrogant\nBeautiful\nBeef\nBest\nBetter\nBig\nBigger\nBlack\nBleak\nBlissful\nBloody\nBlue\nBodacious\nBold\nBrown\nBurnt\nChicken\nCloudy\nCold\nCommon\nConfused\nConstruction\nCool\nCourageous\nCreative\nDainty\nDark\nDeplorable\nDepressed\nDim\nDry\nEastern\nEasy-going\nEdible\nEffervescent\nEfficient\nEight\nEmpty\nExcellent\nFabulous\nFat\nFickle\nFiery\nFighting\nFive\nFlaming\nFour\nFree\nFull\nGassy\nGolden\nGraceful\nGreen\nGrumpy\nHelpful\nHorizontal\nHot\nHuge\nHungry\nIncredible\nLarge\nLazy\nLight\nLittle\nMexican\nMild\nModern\nNarly\nNew\nNine\nOld\nOne\nOne-way\nOptimal\nOptimistic\nOrange\nPeaceful\nPessimistic\nPetite\nPink\nPrideful\nPrime\nPurple\nQuaint\nRadical\nRed\nReligious\nRich\nRocky\nRosy\nRound\nRoyal\nScary\nSeptic\nSeven\nSix\nSleepy\nSlimy\nSloppy\nSmall\nSmart\nSmelly\nSour\nSpectacular\nSpeedy\nSpiritual\nStable\nStinky\nStrange\nStrong\nStupid\nSunny\nSuper\nSuperb\nSweet\nTalented\nTart\nTen\nThin\nThree\nTwo\nUgly\nVertical\nVintage\nWavy\nWeak\nWeakest\nWeary\nWestern\nWet\nWhite\nWicked\nWispy\nWooden\nYellow\nYoung\nZany\nStony\nStone Cold\nNine-inch\nLast\nFirst\nLoaded\nPositive\nNegative\nHungry\nFried\nSealed\nClosed\nOpen\nBroken\nPoor\nRich\nRotten\nFoul\nMean\nNice\nHappy\nSad\nCrying\nDrunken\nLady\nGamey\nTossed\nPaper\nSteel\nFormer\nMany\nFew\nStinky\nSmelly\nGross\nThunder\nLightning\nDopey\nSneezy\nDroopy\nBashful\nLovey\nSpacey\nGold";
		var adjectiveList = new List<string>();
		foreach (string item in adjectiveString.Split(new char[] { '\n' }))
		{
			adjectiveList.Add(item);

		}
		AdjectiveList = adjectiveList;
		adjectives.ItemsSource = AdjectiveList;
		SelectRandomAdjective();

		var nounString = "Adults\nAirplanes\nAngels\nAreas\nArrows\nBadgers\nBadgers\nBalls\nBananas\nBanks\nBeds\nBells\nBirds\nBlankets\nBloats\nBoats\nBones\nBoobies\nBoogers\nBoys\nBranches\nBreasts\nBricks\nBridges\nBurgers\nCapitals\nCars\nCasinos\nCircles\nClaps\nClouds\nClowns\nCones\nCows\nCrappers\nCrazies\nCrews\nCrows\nCups\nCuties\nDamsels\nDaydreamers\nDemons\nDesserts\nDevils\nDiamonds\nDinosaurs\nDiseases\nDoctors\nDogs\nDonors\nDreams\nDrinks\nDumps\nDuties\nEagles\nExits\nFanatics\nFarts\nFeet\nFins\nFishes\nFlags\nFlavors\nFoods\nFootballs\nForks\nFounders\nFreaks\nGases\nGeeks\nGenerals\nGenies\nGills\nGirls\nGods\nGoiters\nGrasses\nGrounds\nHandcuffs\nHeads\nHeroes\nHexes\nHospitals\nHostages\nHouses\nIdiots\nIndians\nJudges\nJustice\nKids\nKings\nLandfills\nLanes\nLeaves\nLefties\nLights\nLimits\nLions\nLocals\nMasters\nMiles\nMilkshakes\nMonarchs\nMongers\nMonkeys\nMoonlights\nMorons\nMounds\nNests\nNightmares\nNoobs\nNotes\nOpportunities\nOrchids\nOrgans\nPackers\nPants\nParties\nPatriot\nPeaches\nPilots\nPineapples\nPipes\nPlanets\nPlants\nPlates\nPlayers\nPreachers\nQueens\nRacers\nRazors\nRibs\nRoads\nRocks\nRods\nRows\nRubies\nRunners\nSandwiches\nSchmoozers\nShaves\nShorts\nSigns\nSkirts\nSlammers\nSluts\nSoldiers\nSpoons\nSpots\nSquares\nStars\nStones\nStreets\nSuns\nTarts\nTeasers\nTemples\nToilets\nTolls\nTons\nTowers\nTrails\nTrains\nTrees\nTrolls\nTrucks\nUnderwear\nVerbage\nVolcanoes\nWalkers\nWalks\nWarlocks\nWarriors\nWaves\nWhippersnappers\nWhips\nWitches\nWorkers\nZones\nNails\nInches\nYards\nResorts\nFirstborns\nTwins\nBabies\nDiapers\nLoads\nDumpers\nGarbage\nGarages\nBarns\nToys\nAlligators\nStates\nGates\nLocks\nAnimals\nWhales\nBooks\nElements\nMangos\nBananas\nKickers\nSnickers\nTracks\nDrivers\nMalls\nBallers\nWomen\nRockers\nChangers\nSalads\nPizzas\nNachos\nAtoms\nAnts\nFlames\nParks\nPuppets\nSenators\nHouses\nEagles\nJuice\nLeaves\nIdiots\nTrunks\nPiercings\nButchers\nTatoos\nPaintings\nArts\nFlowers\nCoconuts\nWaters\nMorons\nImbeciles\nInfidels\nTerrorists\nFrogs\nChickens\nChums\nRainbows\nStorms\nNeanderthals\nWhiners\nAddicts\nTissues\nCleaners\nDitches\nStench\nDiggers\nPipelines\nCoasters\nEnergizers\nBridges\nCruises";
		var nounList = new List<string>();
		foreach (string item in nounString.Split(new char[] { '\n' }))
		{
			nounList.Add(item);

		}
		NounList = nounList;
		nouns.ItemsSource = NounList;
		SelectRandomNoun();

		var coolPhrases = new List<string>()
		{
			"So Cool!",
			"You Rock!",
			"Most Excellent!",
			"Sublime!",
			"Yeah!!!",
			"Totally Awesome, Dude!",
			"Party On!!",
			"Rock it!",
			"Totally Tubular!",
			"Bodacious!",
			"Wicked Verbage!",
			"Totally Rad!",
			"Rockmeister!",
			"Suh-weet!",
			"You're My Hero!"

		};
		CoolPhrasesList = coolPhrases;
	}
	void letsRockButton_Clicked(System.Object sender, System.EventArgs e)
        {
            SelectRandomAdjective();
            SelectRandomNoun();
            SelectRandomButtonText();
        }
        void SelectRandomAdjective()
        {
            var random = new Random();
            var randomIndex = random.Next(0, AdjectiveList.Count);
            adjectives.SelectedIndex = randomIndex;
        }
        void SelectRandomNoun()
        {
            var random = new Random();
            var randomIndex = random.Next(0,NounList.Count);
            nouns.SelectedIndex = randomIndex;
        }
        void SelectRandomButtonText()
        {
            var random = new Random();
            var randomIndex = random.Next(0, CoolPhrasesList.Count);
            letsRockButton.Text = CoolPhrasesList[randomIndex];
        }
	
}