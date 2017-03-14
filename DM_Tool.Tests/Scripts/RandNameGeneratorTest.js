QUnit.test("equal test", function (assert) {
    var firstNameTest = init();

    firstNameTest.firstName[0];

    assert.deepEqual(firstNameTest, "Ilbert", "Equal");
});
