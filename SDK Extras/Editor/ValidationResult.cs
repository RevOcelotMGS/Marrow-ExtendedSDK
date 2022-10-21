#if UNITY_EDITOR

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;

public class ValidationResult {
    public string Testcase { get; set; }
    public Func<bool> Success { get; set; }

    public static void DisplayResults(IEnumerable<ValidationResult> results) {
        const string pass = "✔";
        const string fail = "✖";
        var dialogString = "";
        var passes = 0;
        results.ToList().ForEach(e => {
            var passed = e.Success();
            dialogString += $"{(passed ? pass : fail)} {e.Testcase}\n";
            if (passed) passes++;
        });
        dialogString += $"\n\nPassed {passes}/{results.Count()}";

        EditorUtility.DisplayDialog("Validation results:", dialogString, "Ok");
    }
}

#endif