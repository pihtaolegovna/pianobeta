using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Threading;
using NAudio;
using NAudio.Midi;

internal class Program
{
    public static class v
    {
        public static int operation;
        public static int flag;
        public static int playednote;
        public static int isrunning;
        public static int note_q, note_d2, note_w, note_e, note_d3, note_r, note_d5, note_t, note_d6, note_y, note_d7, note_u, note_d8;
        public static int[,] notes = new int[8, 12] { { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }, { 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 }, { 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47 }, { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59 }, { 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71 }, { 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, }, { 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95 }, { 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107 } };
    }
    public static void Main(string[] args)
    {
        Octave();
    }
    public static void Octave()
    {
        Console.WriteLine("Choose the octave:");
        while (v.flag == 0)
        {
            ConsoleKeyInfo menuchoosekey = Console.ReadKey();
            string choosekey = (menuchoosekey.Key.ToString());
            v.flag = 0;
            switch (choosekey)
            {
                case "D1":
                    Console.WriteLine("Selected octave 1 ");
                    v.note_q = v.notes[0, 0];
                    v.note_d2 = v.notes[0, 1];
                    v.note_w = v.notes[0, 2];
                    v.note_d3 = v.notes[0, 3];
                    v.note_e = v.notes[0, 4];
                    v.note_r = v.notes[0, 5];
                    v.note_d5 = v.notes[0, 6];
                    v.note_t = v.notes[0, 7];
                    v.note_d6 = v.notes[0, 8];
                    v.note_y = v.notes[0, 9];
                    v.note_d7 = v.notes[0, 10];
                    v.note_u = v.notes[0, 11];
                    break;
                case "D2":
                    Console.WriteLine("Selected octave 2 ");
                    v.note_q = v.notes[1, 0];
                    v.note_d2 = v.notes[1, 1];
                    v.note_w = v.notes[1, 2];
                    v.note_d3 = v.notes[1, 3];
                    v.note_e = v.notes[1, 4];
                    v.note_r = v.notes[1, 5];
                    v.note_d5 = v.notes[1, 6];
                    v.note_t = v.notes[1, 7];
                    v.note_d6 = v.notes[1, 8];
                    v.note_y = v.notes[1, 9];
                    v.note_d7 = v.notes[1, 10];
                    v.note_u = v.notes[1, 11];
                    break;
                case "D3":
                    Console.WriteLine("Selected octave 3 ");
                    v.note_q = v.notes[2, 0];
                    v.note_d2 = v.notes[2, 1];
                    v.note_w = v.notes[2, 2];
                    v.note_d3 = v.notes[2, 3];
                    v.note_e = v.notes[2, 4];
                    v.note_r = v.notes[2, 5];
                    v.note_d5 = v.notes[2, 6];
                    v.note_t = v.notes[2, 7];
                    v.note_d6 = v.notes[2, 8];
                    v.note_y = v.notes[2, 9];
                    v.note_d7 = v.notes[2, 10];
                    v.note_u = v.notes[2, 11];
                    break;
                case "D4":
                    Console.WriteLine("Selected octave 4 ");
                    v.note_q = v.notes[3, 0];
                    v.note_d2 = v.notes[3, 1];
                    v.note_w = v.notes[3, 2];
                    v.note_d3 = v.notes[3, 3];
                    v.note_e = v.notes[3, 4];
                    v.note_r = v.notes[3, 5];
                    v.note_d5 = v.notes[3, 6];
                    v.note_t = v.notes[3, 7];
                    v.note_d6 = v.notes[3, 8];
                    v.note_y = v.notes[3, 9];
                    v.note_d7 = v.notes[3, 10];
                    v.note_u = v.notes[3, 11];
                    break;
                case "D5":
                    Console.WriteLine("Selected octave 5 ");
                    v.note_q = v.notes[4, 0];
                    v.note_d2 = v.notes[4, 1];
                    v.note_w = v.notes[4, 2];
                    v.note_d3 = v.notes[4, 3];
                    v.note_e = v.notes[4, 4];
                    v.note_r = v.notes[4, 5];
                    v.note_d5 = v.notes[4, 6];
                    v.note_t = v.notes[4, 7];
                    v.note_d6 = v.notes[4, 8];
                    v.note_y = v.notes[4, 9];
                    v.note_d7 = v.notes[4, 10];
                    v.note_u = v.notes[4, 11];
                    break;
                case "D6":
                    Console.WriteLine("Selected octave 6 ");
                    v.note_q = v.notes[5, 0];
                    v.note_d2 = v.notes[5, 1];
                    v.note_w = v.notes[5, 2];
                    v.note_d3 = v.notes[5, 3];
                    v.note_e = v.notes[5, 4];
                    v.note_r = v.notes[5, 5];
                    v.note_d5 = v.notes[5, 6];
                    v.note_t = v.notes[5, 7];
                    v.note_d6 = v.notes[5, 8];
                    v.note_y = v.notes[5, 9];
                    v.note_d7 = v.notes[5, 10];
                    v.note_u = v.notes[5, 11];
                    break;
                case "D7":
                    Console.WriteLine("Selected octave 7 ");
                    v.note_q = v.notes[6, 0];
                    v.note_d2 = v.notes[6, 1];
                    v.note_w = v.notes[6, 2];
                    v.note_d3 = v.notes[6, 3];
                    v.note_e = v.notes[6, 4];
                    v.note_r = v.notes[6, 5];
                    v.note_d5 = v.notes[6, 6];
                    v.note_t = v.notes[6, 7];
                    v.note_d6 = v.notes[6, 8];
                    v.note_y = v.notes[6, 9];
                    v.note_d7 = v.notes[6, 10];
                    v.note_u = v.notes[6, 11];
                    break;
                case "D8":
                    Console.WriteLine("Selected octave 8 ");
                    v.note_q = v.notes[7, 0];
                    v.note_d2 = v.notes[7, 1];
                    v.note_w = v.notes[7, 2];
                    v.note_d3 = v.notes[7, 3];
                    v.note_e = v.notes[7, 4];
                    v.note_r = v.notes[7, 5];
                    v.note_d5 = v.notes[7, 6];
                    v.note_t = v.notes[7, 7];
                    v.note_d6 = v.notes[7, 8];
                    v.note_y = v.notes[7, 9];
                    v.note_d7 = v.notes[7, 10];
                    v.note_u = v.notes[7, 11];
                    break;
                case "Enter":
                    Console.WriteLine("Octave choosed. Start piano. To change Octave again, press Enter. Escape to exit");
                    v.flag = 1;
                    break;
            }
        }
        Piano();
    }
    public static void Piano()
    {
        v.flag = 0;
        v.operation = 0;
        v.isrunning = 1;
        MidiOut midiOut = new MidiOut(0);
        while (v.isrunning == 1)
        {
            ConsoleKeyInfo menuchoosekey = Console.ReadKey();
            v.isrunning = 1;
            string choosekey = (menuchoosekey.Key.ToString());
            Console.WriteLine("Press on knopoch'ki");
            switch (choosekey)
            {
                case "Q":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_q;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "D2":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_d2;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "W":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_w;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "D3":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_d3;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "E":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_e;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "R":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_r;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "D5":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_d5;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "T":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_t;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "Y":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_y;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "U":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_u;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "D6":
                    Console.Clear();
                    v.operation = 1;
                    v.isrunning = 1;
                    v.playednote = v.note_d6;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "D7":
                    Console.Clear();
                    v.isrunning = 1;
                    v.playednote = v.note_d7;
                    midiOut.Send(MidiMessage.StartNote(v.playednote, 127, 1).RawData);
                    break;
                case "Escape":
                    break;
                case "Enter":
                    Octave();
                    break;
            }
        }
    }
}