using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;
            Console.WriteLine(remainingNumberOfBirds);

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;
            Console.WriteLine(numberOfExtraBirds);



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int raccoonsPlaying = 3;
            int raccoonsHome = 2;
            int racoonsLeft = raccoonsPlaying - raccoonsHome;
            Console.WriteLine(racoonsLeft);
          


            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int lessBees = flowers - bees;
            Console.WriteLine(lessBees);
      





            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int pigeonOne = 1;
            int pigeonTwo = 1;
            int pigeonsEating = pigeonOne + pigeonTwo;
            Console.WriteLine(pigeonsEating);
          

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int initialOwls= 3;
            int joiningOwls = 2;
            int totalOwls = initialOwls + joiningOwls;
            Console.WriteLine(totalOwls);

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int workingBeavers = 2;
            int swimmingBeaver = 1;
            int beaverStillWorking = workingBeavers - swimmingBeaver;
            Console.WriteLine(beaverStillWorking);


            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int initial_toucans = 2;
            int joining_toucans = 1;
            int totalSittingToucans = initial_toucans + joining_toucans;
            Console.WriteLine(totalSittingToucans);

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrels = 4;
            int nuts = 2;
            int moreSquirrels = squirrels - nuts;
            Console.WriteLine(moreSquirrels);



            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarter = 0.25m;
            decimal dimes = 0.10m;
            decimal nickle = 0.05m;
            decimal moneyTotal = quarter + nickle + nickle + dimes;
            Console.WriteLine(moneyTotal);

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int brier = 18;
            int macadams = 20;
            int flannery = 17;
            int firstGradeMuffins = brier + macadams + flannery;
            Console.WriteLine(firstGradeMuffins);


            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyo = 0.24m;
            decimal whistle = 0.14m;
            decimal toysTotal = yoyo + whistle;
            Console.WriteLine(toysTotal);


            /*
             
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int marshmellowTotal = largeMarshmallows + miniMarshmallows;
            Console.WriteLine(marshmellowTotal);


            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouse = 29;
            Console.WriteLine(hiltHouse);


            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int hiltMoney = 10;
            int truck = 3;
            int pencil = 2;
            hiltMoney = hiltMoney - truck - pencil;
            Console.WriteLine(hiltMoney);


            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int joshMarbles = 16;
            joshMarbles -= 7;
            Console.WriteLine(joshMarbles);

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int meganShells = 19;
            int destination = 25;
            int shellsToGO = destination - meganShells;
            Console.WriteLine(shellsToGO);


            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBallons = 17;
            int redBallons = 8;
            int greenBallons = totalBallons - redBallons;
            Console.WriteLine(greenBallons);




            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int booksOnShelf = 38;
            booksOnShelf += 10;
            Console.WriteLine(booksOnShelf);




            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            beeLegs *= 8;
            Console.WriteLine(beeLegs);

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double iceCreamCone = 0.99;
            iceCreamCone *= 2;
            Console.WriteLine(iceCreamCone);

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int rockstotal = 125;
            int rocks = 64;
            int needrocks = rockstotal - rocks;
            Console.WriteLine(needrocks);

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int marblesHilt = 38;
            marblesHilt  -= 15;
            Console.WriteLine(marblesHilt);

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            int totalDistance = 78;
            totalDistance -= 32;
            Console.WriteLine(totalDistance);

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int shoveling = 90;
            shoveling += 45;
                Console.WriteLine(shoveling);

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            double hotDog = 0.50;
            hotDog *= 6;
            Console.WriteLine(hotDog);

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            
            int  numberOfPencils = 50 / 7 ;
            
            
            Console.WriteLine(numberOfPencils);





            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterfliesTotal = 33;
            int butterfliesOrange = 20;
            int butterfliesRed = butterfliesTotal - butterfliesOrange;
            Console.WriteLine(butterfliesRed);

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal candy = 0.54m;
            decimal moneyGiven = 1.00m;
            decimal  changeReturned = moneyGiven - candy;
            Console.WriteLine(changeReturned);

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int trees = 13;
            trees += 12;
            Console.WriteLine(trees);



            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            int day = 24;
            day += day;
            Console.WriteLine(day);


            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int cousins = 4;
            cousins *= 5 ;
            Console.WriteLine(cousins);



            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            decimal danMoney = 3.00m;
            decimal candyTwo = 1.00m;
            decimal afterMoney = danMoney - candyTwo;
            Console.WriteLine("$" + afterMoney);



            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int peoplePerBoat = 3;
            peoplePerBoat *= 5;
            Console.WriteLine(peoplePerBoat);




            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int legos = 380;
            legos -= 57;
            Console.WriteLine(legos);


            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthurBaked = 35;
            int arthurLeft = 83 - arthurBaked;
            Console.WriteLine(arthurLeft);


            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int moreCrayons = willyCrayons - lucyCrayons;
            Console.WriteLine(moreCrayons);

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int page = 22;
            int stickerTotal  = page *= 10;
            Console.WriteLine(stickerTotal);


            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int cupcakes = 96;
            int children = 8;
            int cupcakesShare = cupcakes / children;
            Console.WriteLine(cupcakesShare);

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            int mod = 47 % 6;
            Console.WriteLine(mod);

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int crossantsMod = 59 % 8;
            Console.WriteLine(crossantsMod);

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            double trays = 276 / 12.0;
            Console.WriteLine(trays);
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int pritzelsTotal = 480;
            int serving = 12;
            int prepare = pritzelsTotal / serving;
            Console.WriteLine(prepare);


            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int cupcakesTaken = 51;
            int box = 3;
            int boxesgiven= cupcakesTaken / box;
            Console.WriteLine(boxesgiven);


            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            int carrotSticks = 74;
            int peopleEat = 12;
            int equalCarrots = carrotSticks / peopleEat;
            Console.WriteLine(equalCarrots);

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int bearsTotal = 98;
            int shelvesPer = 7;
            int shelvesTotal = bearsTotal / shelvesPer;
            Console.WriteLine(shelvesTotal);





            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            int pictures = 480;
            int album = 20;
            int albumsNeeded = pictures / album;
            Console.WriteLine(albumsNeeded);


            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int cards = 94;
            int boxmax = 8; 
            int filledBoxes = cards / boxmax;
            int unfilledBox = cards % boxmax;
            Console.WriteLine("filled boxes " + filledBoxes + " " + "unfilled boxes " + unfilledBox);


            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int books = 210;
            int shelves = 10;
            int booksPerShelve = books / shelves;
            Console.WriteLine(booksPerShelve);


            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            int croiss = 17;
            int guests = 7;
            int even = croiss / guests;
            Console.WriteLine(even);



            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */

           double billHourlyRate = 168 / 2.15;
           double jillHourlyRate = 168 / 1.90;
          double feetOfRoom = 168;
            feetOfRoom *= 5;
          double timeForFiveRooms = ( feetOfRoom)/(billHourlyRate + jillHourlyRate );
          Console.WriteLine(timeForFiveRooms);
            feetOfRoom = 168 * 623;
            double days = ((feetOfRoom) / (billHourlyRate + jillHourlyRate))/8;
            Console.WriteLine(days);

             








            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */

            string firstName = "Brian";
            string lastName = "Jones";
            string middleInitial = "J";
            string fullName567 = lastName + ", " + firstName + " " + middleInitial + ".";
            Console.WriteLine(fullName567);


            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */


            double distanceTravedSoFar = 537;
           double  totalDistanceWent = 800;
            double percentWent = (int)((totalDistanceWent / distanceTravedSoFar) *10);
            Console.WriteLine(percentWent);




            Console.ReadKey();
        }
    }
}
