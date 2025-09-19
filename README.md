# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

Rudna Danicia Souka

W03 : Explain Encapsulation

Meaning of Encapsulation :

Encapsulation is the act of enclosing something, such as in a capsule. This involves defining the behaviors we need for our classes and hiding the implementation details and preventing other parts of the program from accessing these details.

Benefit Of Encapsulation:

They protect data by making fields private, preventing external code from directly modifying the state of an object, and controlling access, i.e. you decide which parts of the code are publicly accessible and which remain hidden private.

Application of Encapsulation :

In this week's project, the program involves helping people memorize words. We created three classes. The Word class keeps the word's text and hidden state private.
The only way to change the hidden state is to call the public Hide() method, and the only way to display it is via GetDisplayText().
This ensures that words are always displayed or hidden consistently, regardless of their location in the program.

Code Exemple :

This code demonstrates encapsulation, as the _text and _isHidden fields are private and cannot be accessed or modified except via the public Hide() and GetDisplayText() methods.


public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string  GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}

Explain Concepts :

In Summary Encapsulation is the second principle of class-based programming. A key element of encapsulation is the hiding or controlling of access to information. Knowing how to use access modifiers properly will protect us from any intrusion into our programs.
It also aims to ensure that our classes define the appropriate behaviors and then internally manage the details necessary to implement them.
Encapsulation adds security, clarity, and consistency to your program.
