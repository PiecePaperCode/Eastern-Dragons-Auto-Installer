Turn word wrap on!

***************************************************************************
*                                                                            
                                               *
*     This is a gauge made by the FREEWARE PANEL DESIGNER ASSOCIATION     *
*                                                                            
                                                *
*           Visit our homepage: www.flightsimmers.net/fpda                   
                         *
*                                                                            
                                                 *
***************************************************************************
!!!!!!!!!!THIS IS FREEWARE! DON'T MAKE MONEY WITH OUR FILES!!!!!!!!!!!!!!!!
***************************************************************************

                    Airbus A330/340 Altitude Callout Gauge
                                        version 1.0
                               for FS98 and FS2000

Programming by Andreas Jaros & Konstantin Prokopiu
Sounds recorded by Peter Binamira

If you want to contact us please leave a message in the forum of the 
FPDA-homepage, we will answer it there.

A gauge that gives you the radio altitude callouts for the Airbus A330/340 
series. This version uses the newer "Airbus voice" that you can hear on the 
real Airbus A330/340 series.

Peter Binamira came to me with some very good recordings of the altitude 
callouts taken from a Philippine Airlines A330 jumpseat ride. This gauge has 
a different set of wavs than the previous gauge of the A320 and the B737. 
For this gauge you will hear the following:

@ 2500ft AGL (Above Ground Level): "2500"
@ 1000ft AGL: "1000"
@ 500ft AGL: "500"
@ 400ft AGL: "hundred above" and three "clicks" (a landing configuration 
warning)
@ 300ft AGL: "minimums"
@ 200ft AGL: "200"
@ 100ft AGL: "100"
@ 50ft AGL: "50"
@ 40ft AGL: "40"
@ 30ft AGL: "30"
@ 20ft AGL: "20" - "Retard"
@ 10ft AGL: "10"

All of the recordings came from one flight so there is no way to change the 
decision height. The decision height that was set on this flight was at 
300ft AGL. If someone can send us the 400 and 300 ft. set of sounds with 
good/similar quality we can include them in this gauge, just leave a message 
in the FPDA forum.

The creation of the gauge was based on the Airbus A330/340 aircrafts of 
Camil Valiquette. So we recommend the Promax98/2000/2001/LT series of 
Valiquette for use with this gauge. If you use it on different aircrafts it 
can be possible that the last callout (10 ft.) may not be accurate or might 
not even be heard, due to the difference in gear height of the aircrafts.

Installation:
~~~~~~~~~~~~~
Copy the wav's to your Flightsim-main-sound directory (...\FS98\SOUND or 
...\FS2000\SOUND) and the gauge to the Flightsim-main-gauge-directory 
(...\FS98\GAUGES or ...\FS2000\GAUGES). Then open up the panel.cfg file of 
the panel you want to include this gauge and do the following:

gaugeXX=FPDA_A330_Callout, XXX, YYY

The "XX" stands for the next gauge number. As an example here some lines 
from the MS-737-panel (This is only an example, you can have other numbers 
and names!):

...
gauge15=737-400.ADI, 334, 55
gauge16=737-400.HSI, 334, 301
gauge17=737-400.Landing-Gear, 1170, 137

The last gauge number of [Window00] here is 17, so we change the "XX" to 18 
(just add one to the last number) and add it to this lines:

...
gauge15=737-400.ADI, 334, 55
gauge16=737-400.HSI, 334, 301
gauge17=737-400.Landing-Gear, 1170, 137
gauge18=FPDA_A330_Callout, XXX, YYY              (This is the new line)

The "XXX" and "YYY" stand for the x-coordinates ("XXX") and the 
y-coordinates ("YYY") of the gauge where it should be displayed.

Because this gauge doesn't have any visible parts it doesn't matter where 
you position it. But there can be 3dfx-problems if you place it wrong.
For 3dfx based cards, I recommend this:

gaugeXX=FPDA_A330_Callout, 0, 0

LEGAL INFORMATION:
~~~~~~~~~~~~~~~~~~
We hate to make restrictions, but unfortunately there are too many people 
who
only looking for possibilities to make money from our great hobby.

! We are not responsible for any damage resulting from using this file.
! This file is FREEWARE!!! DON'T MAKE MONEY WITH THIS FILE!!!
!
! DO NOT place this file on a BBS/net site that requires a fee for 
uploading/
! downloading files. DO NOT bundle this file in a commercial package without
! the explicit written permission from the authors.
!
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
!DO NOT use any included file (*.GAU AND *.WAV) in any COMMERCIAL (PAYWARE, 
SHAREWARE,...) PANEL,
!without the authors written permission. If you want to include it in a 
FREEWARE PANEL then it is OK.
!But then add to your documentation that the commercial use of any of the 
included files in this zip file is forbidden without our permission. Thank 
you!
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

And I'm also sure we will not allow you to make money with this file.


CREDITS:
~~~~~~~~
-Konstantin Prokopiu, the founder of the FPDA (Freeware Panel Designer 
Assotiation) who found out for us, how to make fantastic sound effects, and 
for writing this necessary header file!
Danke Kosta!!!

- Peter Binamira for the great A330 callout sounds he recorded and prepared 
for this gauge!

-Hiroyuki Toyohara, my mentor in gauge programming. Without his help I never 
had begun to program new gauges. Domo arigatou gozaimasu Toyo!

-Filipino Flightsimmers Group (you guys know who you are) for betatesting 
the gauge. Maraming Salamat!!!

- And finally thanks to Microsoft for giving us this great Flightsimulator! 
And for giving us the SDK (ok almost all...) secrets for making new gauges! 
Thanks Mr.Gates :-)


Included Files:
~~~~~~~~~~~~~~~
FPDA_A330_Callout.gau
FPDA_A330_2500ft.wav
FPDA_A330_1000ft.wav
FPDA_A330_500ft.wav
FPDA_A330_400ft.wav
FPDA_A330_300ft.wav
FPDA_A330_200ft.wav
FPDA_A330_100ft.wav
FPDA_A330_50ft.wav
FPDA_A330_40ft.wav
FPDA_A330_30ft.wav
FPDA_A330_20ft.wav
FPDA_A330_10ft.wav
Readme.txt
File_id.diz

ALL this files are copyrighted!!!


Happy landings!

Andreas Jaros (jaros@bigfoot.de)
Freeware Panel Designer Association
FPDA - "Don't Charge For Fun!"

FPDA-Homepage: www.flightsimmers.net/fpda

Peter Binamira (downhill@i-next.net)
Filipino Flightsimmers Group
Homepage: www.fspb.tripod.com

5/26/2000

