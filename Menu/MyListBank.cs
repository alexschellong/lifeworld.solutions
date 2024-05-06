using UnityEngine;
using TMPro;

public class MyListBank : BaseListBank
{
	private string[] _contents = {
		"All Shapes 2023",
		"Untitled (semantic bounds violation) 2022-23",
		"2021 freesounds & all their \n 5 beat rhythms  (1.406704e+12) 2021",
		"FreesoundPercussion2020 2020",
		"8063-1 2020",
        "Creation of Adam 2019",
        "Aesthetic alignment p.2 (landscape) 2018-19",
        "Genesis of failure 2017-18",
        "Aesthetic alignments p.1 2017-18",
        "Retrospective Alex Schellong 2017",

    };

	public override string GetListContent(int index)
	{
        return _contents[index];
	}

	public override int GetListLength()
	{
		return _contents.Length;
	}
}

