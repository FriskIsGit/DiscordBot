﻿using Shitcord.Extensions;

namespace Shitcord.Tests;

public class MatchingTest{
    private static int passedTests, failedTests;
    
    public static void RunTests(){
        //TODO: base larger tests on accuracy rather than matching len
        test("lil yachty", "lil yachty russia", 9);
        test("lil yachty", "lil yachty", 9);
        test("dekstop", "desktop", 6);
        test("beeee gees", "beeee", 5);
        test("gees", "skeler", 2);
        test("lyrics", "lyics", 4);
        test("coat", "cost", 3);
        test("post", "post", 4);
        test("cot", "coat", 3);
        test("coat", "cot", 3);
        test("bee gees", "skeler", 2);
        test("bee gees", "beeeez G", 5);
        test("recur", "owner", 0);
        test("q", "something", 0);
        test("Lil Yachty german", "lil yachty german", 15);
        test("lil yachty german", "lil yachty german", 15);
        test("lil yachty poland", "Lil Yachty - Poland", 15);
        test("lil yachty poland", "?lil yachty poland freestyle by?MAJ", 12);
        Console.WriteLine($"Passed/All  {passedTests}/{passedTests+failedTests}");
    }
    private static void test(string query, string target, int expected){
        int accuracy = StringMatching.Accuracy(query, target);
        if (accuracy == expected){
            passedTests++;
        }else{
            failedTests++;
            Console.WriteLine($"Expected: {expected}, Got:{accuracy}");
            Console.WriteLine($"For: {query} | {target}");
        }
    }
}