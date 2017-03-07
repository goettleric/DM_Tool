/*

	Could make this universal for all games by passing in
	the number of stats, what kind of die you use,
	and how many rolls per stat.

*/

var arrayOfStats = []; // Array that holds the final added rolls used to assign to character stats
var rollArray = []; // Array that holds the random rolls that determine the final stat number
var rollHistory = [[]];
var sidesOnDie = 6;
var totalStats = 6;
var rollsPerStat = 4;
var roll;


document.getElementById('testButton').addEventListener('click', function () {

    for (var stats = 0; stats < totalStats; stats++) { // 6 stats, 6 loops
        for (var statRolls = 0; statRolls < rollsPerStat; statRolls++) { // 4 rolls per stat

            roll = Math.ceil(Math.random() * sidesOnDie); // I use ceil so it rounds it up so 0 is not possible and 6 is.		
            rollArray.push(roll); // Push the roll to be added later
        }

        // Sorts array largest to smallest, then throws away the smallest number (how'd you'd do it manually with dice).
        rollArray.sort(function (a, b) { return b - a }).pop();

        // Adds the array of rolls up and pushes that number into the stats array.
        arrayOfStats.push(rollArray.reduce(function (total, num) {
            return total + num;
        }));

        rollArray = []; // Reset the array so it doesn't keep the old rolls.
    }

    arrayOfStats = arrayOfStats.sort(function (a, b) { return b - a }); // Final list of stats, sorted highest to lowest.

    // Assigns values to view
    for (var i = 0; i < arrayOfStats.length; i++) {
        document.getElementById(i.toString()).innerHTML = arrayOfStats[i].toString();
    }

    // Roll history
    rollHistory.push(arrayOfStats);
    console.log(rollHistory.toString() + "\n");

    // Reset arrays
    rollArray = [];
    arrayOfStats = [];
});





