var RandomNameGen = {
    
    init: function() {        
        firstName = ['Ilbert', 'Terric', 'Searl', 'Reynald', 'Ulric', 'Conan', 'Raolin', 'Bardolf', 'Theodoric', 'Tristan'];
        
        lastName = ['Silverhand', 'Ironstar', 'Sunhunter', 'Wyvernsinger', 'Highbrand', 'Cliffwalker', 'Rockcleaver', 'Farrowwood', 'Deathglade', 'Frozensun'];
        
        var randomNameButton = document.querySelector('#randomNameButton');
        
        output = document.querySelector('#randomName');
        
        randomNameButton.addEventListener('click', RandomNameGen.displayRandomName, false);
    },
    
    displayRandomName: function() {
        var randomIndex = RandomNameGen.randomRange(1, firstName.length);
        
        var randFirstName = firstName[randomIndex];
        var randLastName = lastName[randomIndex];
        
        output.textContent = randFirstName + ' ' + randLastName;
    },
    
    randomRange: function(min, max) {
        return Math.floor(Math.random() * (max - min) + min);
    }
};

