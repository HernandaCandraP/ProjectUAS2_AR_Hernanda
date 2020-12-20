using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public GameObject GuiButtonBumi;
    public GameObject GuiButtonJupiter;
    public GameObject GuiButtonSun;
    public GameObject GuiButtonMerkury;
    public GameObject GuiPanel;
    public GameObject GuiHidePanel;
    public GameObject GuiHome;
    public GameObject GuiBack;
    AudioSource audio;
    public AudioClip btnclick;

    public Text title;
    public Text information;

    public void showButtonBumi(){
		GuiButtonBumi.SetActive(true);
        GuiHome.SetActive(false);
	}

    public void showButtonSun(){
        GuiButtonSun.SetActive(true);
        GuiHome.SetActive(false);
	}

    public void showButtonJupiter(){
        GuiButtonJupiter.SetActive(true);
        GuiHome.SetActive(false);
	}

    public void showButtonMerkury(){
        GuiButtonMerkury.SetActive(true);
        GuiHome.SetActive(false);
	}

    public void hideButtonBumi(){
		GuiButtonBumi.SetActive(false);
        hideButton();
	}

    public void hideButtonSun(){
        GuiButtonSun.SetActive(false);
        hideButton();
	}

    public void hideButtonJupiter(){
        GuiButtonJupiter.SetActive(false);
        hideButton();
	}

    public void hideButtonMerkury(){
        GuiButtonMerkury.SetActive(false);
        hideButton();
	}

	public void hideButton(){
        GuiHome.SetActive(true);
        GuiPanel.SetActive(false);
        GuiHidePanel.SetActive(false);
	}
    
    public void showPanelBumi(){
        title.text="BUMI";
        information.text = "Bumi adalah planet ketiga dari Matahari yang merupakan planet terpadat dan tebesar kelima dari delapan planet dalam Tata Surya. ";
        showPanel();
	}

    public void showPanelJupiter(){
		title.text="JUPITER";
        information.text = "Jupiter adalah planet kelima dari Matahari. Planet ini merupakan planet terbesar di Tata Surya. Jupiter merupakan raksasa gas dengan massa seperseribu massa Matahari.";
        showPanel();
	}

    public void showPanelSun(){
		title.text="MATAHARI";
        information.text = "Matahari adalah bintang di pusat tata surya. Berbentuk nyaris bulat dan terdiri dari plasma panas bercampur medan magnet.";
        showPanel();
	}

    public void showPanelMerkury(){
		title.text="MERKURIUS";
        information.text = "Merkurius adalah planet terkecil di Tata Surya sekaligus terdekat dengan Matahari. Periode Revolusi planet ini yakni 87,79 hari";
        showPanel();
	}

    public void showPanel(){
        GuiPanel.SetActive(true);
        GuiHidePanel.SetActive(true);
        soundClick();
	}

    public void hidePanel(){
		GuiPanel.SetActive(false);
        GuiHidePanel.SetActive(false);
        soundClick();
	}

    public void pindahGame(){
        soundClick();
        SceneManager.LoadScene("GameIntro");
    }

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void soundClick(){
        audio.clip = btnclick;
        audio.Play();
        audio.loop = false;
    }
}
