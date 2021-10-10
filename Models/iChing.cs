using System.Collections.Generic;

namespace i_ching_aspmvc.Models
{
    public class PageData
    {
        public string Key { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public List<string> Summary { get; set; }
        public string Upper { get; set; }
        public string Lower { get; set; }
        public string PathToNext { get; set; }
        public List<string> Image { get; set; }
    }

    public static class iChingModel
    {
        public static PageData[,] Hexagrams = new PageData[,]
        {
            {
                new PageData {
                    Upper = "Earth",
                    Lower = "Earth",
                    Name = "K'un - The Receptive",
                    PathToNext = "upper=0&lower=1",
                    Summary = new List<string> {
                        "The Receptive brings about sublime success,",
                        "Furthering through the perseverance of a mare.",
                        "If the superior man undertakes something and tries to lead, he goes astray.",
                        "But if he follows, he finds guidance.",
                        "It is favorable to find friends in the west and south,",
                        "To forego friends in the east and north.",
                        "Quiet perseverance brings good fortune."
                    },
                    Image = new List<string> {
                        "The earth's condition is receptive devotion.",
                        "Thus the superior man who has breadth of character",
                        "Carries the outer world."
                    }
                },
                new PageData {
                    Upper = "Earth",
                    Lower = "Mountain",
                    Name = "Ch'ien - Modesty",
                    PathToNext = "upper=0&lower=2",
                    Summary = new List<string> {
                        "Modesty creates success.",
                        "The superior man carries things through."
                    },
                    Image = new List<string> {
                        "Within the earth, a mountain:",
                        "The image of Modesty.",
                        "Thus the superior man reduces that which is too much,",
                        "And augments that which is too little.",
                        "He weighs things and makes them equal."
                    }
                },
                new PageData {
                    Upper = "Earth",
                    Lower = "Water",
                    Name = "Shih - The Army",
                    PathToNext = "upper=0&lower=3",
                    Summary = new List<string> {
                        "The army needs perseverance",
                        "And a strong man.",
                        "Good fortune without blame."
                    },
                    Image = new List<string> {
                        "In the middle of the earth is water:",
                        "The image of the Army.",
                        "Thus the superior man increases his masses",
                        "By generosity toward the people."
                    }
                },
                new PageData {
                    Upper = "Earth",
                    Lower = "Wind",
                    Name = "Shêng - Pushing Upward",
                    PathToNext = "upper=0&lower=4",
                    Summary = new List<string> {
                        "Pushing Upward has supreme success.",
                        "One must see the great man.",
                        "Fear not.",
                        "Departure toward the south",
                        "Brings good fortune."
                    },
                    Image = new List<string> {
                        "Within the earth, wood grows:",
                        "The image of Pushing Upward.",
                        "Thus the superior man of devoted character",
                        "Heaps up small things",
                        "In order to achieve something high and great."
                    }
                },
                new PageData {
                    Upper = "Earth",
                    Lower = "Thunder",
                    Name = "Fu - Return (The Turning Point)",
                    PathToNext = "upper=0&lower=5",
                    Summary = new List<string> {
                        "Return. Success.",
                        "Going out and coming in without error.",
                        "Friends come without blame.",
                        "To and fro goes the way.",
                        "On the seventh day comes return.",
                        "It furthers one to have somewhere to go."
                    },
                    Image = new List<string> {
                        "Thunder within the earth:",
                        "The image of the Turning Point.",
                        "Thus the kings of antiquity closed the passes",
                        "At the time of solstice.",
                        "Merchants and strangers did not go about,",
                        "And the ruler",
                        "Did not travel through the provinces."
                    }
                },
                new PageData {
                    Upper = "Earth",
                    Lower = "Fire",
                    Name = "Ming I - Darkening of the Light",
                    PathToNext = "upper=0&lower=6",
                    Summary = new List<string> {
                        "Darkening of the Light.",
                        "In adversity it furthers one",
                        "To be persevering."
                    },
                    Image = new List<string> {
                        "The light has sunk into the earth:",
                        "The image of Darkening of the Light.",
                        "Thus does the superior man live with the great mass:",
                        "He veils his light, yet still shines."
                    }
                },
                new PageData {
                    Upper = "Earth",
                    Lower = "Lake",
                    Name = "Lin - Approach",
                    PathToNext = "upper=0&lower=7",
                    Summary = new List<string> {
                        "Approach has supreme success.",
                        "Perseverance furthers.",
                        "When the eighth month comes,",
                        "There will be misfortune."
                    },
                    Image = new List<string> {
                        "The earth above the lake:",
                        "The image of Approach.",
                        "Thus the superior man is inexhaustible",
                        "In his will to teach,",
                        "And without limits",
                        "In his tolerance and protection of the people."
                    }
                },
                new PageData {
                    Upper = "Earth",
                    Lower = "Heaven",
                    Name = "T'ai - Peace",
                    PathToNext = "upper=1&lower=0",
                    Summary = new List<string> {
                        "Peace.",
                        "The small departs,",
                        "The great approaches.",
                        "Good fortune. Success."
                    },
                    Image = new List<string> {
                        "Heaven and earth unite:",
                        "The image of Peace.",
                        "Thus the Ruler",
                        "Divides and completes the course of heaven and earth;",
                        "He furthers and regulates the gifts of heaven and earth,",
                        "And so aids the people."
                    }
                }
            },
            {
                new PageData {
                    Upper = "Mountain",
                    Lower = "Earth",
                    Name = "Po - Splitting Apart",
                    PathToNext = "upper=1&lower=1",
                    Summary = new List<string> {
                        "Splitting Apart.",
                        "It does not further one",
                        "To go anywhere."
                    },
                    Image = new List<string> {
                        "The mountain rests on the earth:",
                        "The image of Splitting Apart.",
                        "Thus those above can ensure their position",
                        "Only by giving generously to those below."
                    }
                },
                new PageData {
                    Upper = "Mountain",
                    Lower = "Mountain",
                    Name = "Kên - Keeping Still, Mountain",
                    PathToNext = "upper=1&lower=2",
                    Summary = new List<string> {
                        "Keeping Still.",
                        "Keeping his back still",
                        "So that he no longer feels his body.",
                        "He goes into his courtyard",
                        "And does not see his people.",
                        "No blame."
                    },
                    Image = new List<string> {
                        "Mountains standing close together:",
                        "The image of Keeping Still.",
                        "Thus the superior man",
                        "Does not permit his thoughts",
                        "To go beyond his situation."
                    }
                },
                new PageData {
                    Upper = "Mountain",
                    Lower = "Water",
                    Name = "Mêng - Youthful Folly",
                    PathToNext = "upper=1&lower=3",
                    Summary = new List<string> {
                        "Youthful Folly has success.",
                        "It is not I who seek the young fool;",
                        "The young fool seeks me.",
                        "At the first oracle I inform him.",
                        "If he asks two or three times, it is importunity.",
                        "If he importunes, I give him no information.",
                        "Perseverance furthers."
                    },
                    Image = new List<string> {
                        "A spring wells up at the foot of the mountain:",
                        "The image of Youth.",
                        "Thus the superior man fosters his character",
                        "By thoroughness in all that he does."
                    }
                },
                new PageData {
                    Upper = "Mountain",
                    Lower = "Wind",
                    Name = "Ku - Work on What Has Been Spoiled [Decay]",
                    PathToNext = "upper=1&lower=4",
                    Summary = new List<string> {
                        "Work on What Has Been Spoiled",
                        "Has supreme success.",
                        "It furthers one to cross the great water.",
                        "Before the starting point, three days.",
                        "After the starting point, three days."
                    },
                    Image = new List<string> {
                        "The wind blows low on the mountain:",
                        "The image of Decay.",
                        "Thus the superior man stirs up the people",
                        "And strengthens their spirit."
                    }
                },
                new PageData {
                    Upper = "Mountain",
                    Lower = "Thunder",
                    Name = "I - The Corners of the Mouth (Providing Nourishment)",
                    PathToNext = "upper=1&lower=5",
                    Summary = new List<string> {
                        "The Corners of the Mouth.",
                        "Perseverance brings good fortune.",
                        "Pay heed to the providing of nourishment",
                        "And to what a man seeks",
                        "To fill his own mouth with."
                    },
                    Image = new List<string> {
                        "At the foot of the mountain, thunder:",
                        "The image of Providing Nourishment.",
                        "Thus the superior man is careful of his words",
                        "And temperate in eating and drinking."
                    }
                },
                new PageData {
                    Upper = "Mountain",
                    Lower = "Fire",
                    Name = "Pi - Grace",
                    PathToNext = "upper=1&lower=6",
                    Summary = new List<string> {
                        "Grace has success.",
                        "In small matters",
                        "It is favorable",
                        "To undertake something."
                    },
                    Image = new List<string> {
                        "Fire at the foot of the mountain:",
                        "The image of Grace.",
                        "Thus does the superior man proceed",
                        "When clearing up current affairs.",
                        "But he dare not decide controversial",
                        "Issues in this way."
                    }
                },
                new PageData {
                    Upper = "Mountain",
                    Lower = "Lake",
                    Name = "Sun - Decrease",
                    PathToNext = "upper=1&lower=7",
                    Summary = new List<string> {
                        "Decrease combined with sincerity",
                        "Brings about supreme good fortune",
                        "Without blame.",
                        "One may be persevering in this.",
                        "It furthers one to undertake something.",
                        "How is this to be carried out?",
                        "One may use two small bowls for the sacrifice."
                    },
                    Image = new List<string> {
                        "At the foot of the mountain, the lake:",
                        "The image of Decrease.",
                        "Thus the superior man controls his anger",
                        "And restrains his instincts."                    }
                },
                new PageData {
                    Upper = "Mountain",
                    Lower = "Heaven",
                    Name = "Ta Ch'u - The Taming Power of the Great",
                    PathToNext = "upper=2&lower=0",
                    Summary = new List<string> {
                        "The Taming Power of the Great.",
                        "Perseverance furthers.",
                        "Not eating at home brings good fortune.",
                        "It furthers one to cross the great water."
                    },
                    Image = new List<string> {
                        "Heaven within the mountain:",
                        "The image of the Taming Power of the Great.",
                        "Thus the superior man acquaints himself with many sayings of antiquity",
                        "And many deeds of the past,",
                        "In order to strengthen his character thereby."
                    }
                }
            },
            {
                new PageData {
                    Upper = "Water",
                    Lower = "Earth",
                    Name = "Pi - Holding Together [Union]",
                    PathToNext = "upper=2&lower=1",
                    Summary = new List<string> {
                        "Holding Together brings good fortune.",
                        "Inquire of the oracle once again",
                        "Whether you possess sublimity, constancy, and perseverance;",
                        "Then there is no blame.",
                        "Those who are uncertain gradually join.",
                        "Whoever comes too late",
                        "Meets with misfortune."
                    },
                    Image = new List<string> {
                        "On the earth is water:",
                        "The image of Holding Together.",
                        "Thus the kings of antiquity",
                        "Bestowed the different states as fiefs",
                        "And cultivated friendly relations",
                        "With the feudal lords."
                    }
                },
                new PageData {
                    Upper = "Water",
                    Lower = "Mountain",
                    Name = "Chien - Obstruction",
                    PathToNext = "upper=2&lower=2",
                    Summary = new List<string> {
                        "Obstruction.",
                        "The southwest furthers.",
                        "The northeast does not further.",
                        "It furthers one to see the great man.",
                        "Perseverance brings good fortune."
                    },
                    Image = new List<string> {
                        "Water on the mountain:",
                        "The image of Obstruction.",
                        "Thus the superior man turns his attention to himself",
                        "And molds his character."
                    }
                },
                new PageData {
                    Upper = "Water",
                    Lower = "Water",
                    Name = "K'an - The Abysmal (Water)",
                    PathToNext = "upper=2&lower=3",
                    Summary = new List<string> {
                        "The Abysmal repeated.",
                        "If you are sincere, you have success in your heart,",
                        "And whatever you do succeeds."
                    },
                    Image = new List<string> {
                        "Water flows on uninterruptedly and reaches its goal:",
                        "The image of the Abysmal repeated.",
                        "Thus the superior man walks in lasting virtue",
                        "And carries on the business of teaching."
                    }
                },
                new PageData {
                    Upper = "Water",
                    Lower = "Wind",
                    Name = "Ching - The Well",
                    PathToNext = "upper=2&lower=4",
                    Summary = new List<string> {
                        "The Well.",
                        "The town may be changed,",
                        "But the well cannot be changed.",
                        "It neither decreases nor increases.",
                        "They come and go and draw from the well.",
                        "If one gets down almost to the water",
                        "And the rope does not go all the way,",
                        "Or the jug breaks, it brings misfortune."
                    },
                    Image = new List<string> {
                        "Water over wood:",
                        "The image of the Well.",
                        "Thus the superior man encourages the people at their work,",
                        "And exhorts them to help one another."
                    }
                },
                new PageData {
                    Upper = "Water",
                    Lower = "Thunder",
                    Name = "Chun - Difficulty at the Beginning",
                    PathToNext = "upper=2&lower=5",
                    Summary = new List<string> {
                        "Difficulty at the Beginning works supreme success,",
                        "Furthering through perseverance.",
                        "Nothing should be undertaken.",
                        "It furthers one to appoint helpers."
                    },
                    Image = new List<string> {
                        "Clouds and thunder:",
                        "The image of Difficulty at the Beginning.",
                        "Thus the superior man",
                        "Brings order out of confusion."
                    }
                },
                new PageData {
                    Upper = "Water",
                    Lower = "Fire",
                    Name = "Chi Chi - After Completion",
                    PathToNext = "upper=2&lower=6",
                    Summary = new List<string> {
                        "After Completion.",
                        "Success in small matters.",
                        "Perseverance furthers.",
                        "At the beginning good fortune.",
                        "At the end disorder."
                    },
                    Image = new List<string> {
                        "Water over fire:",
                        "The image of the condition",
                        "In After Completion.",
                        "Thus the superior man",
                        "Takes thought of misfortune",
                        "And arms himself against it in advance."
                    }
                },
                new PageData {
                    Upper = "Water",
                    Lower = "Lake",
                    Name = "Chieh - Limitation",
                    PathToNext = "upper=2&lower=7",
                    Summary = new List<string> {
                        "Limitation. Success.",
                        "Galling limitation must not be persevered in."
                    },
                    Image = new List<string> {
                        "Water over lake:",
                        "The image of Limitation.",
                        "Thus the superior man",
                        "Creates number and measure,",
                        "And examines the nature of virtue and correct conduct."
                    }
                },
                new PageData {
                    Upper = "Water",
                    Lower = "Heaven",
                    Name = "Hsu - Waiting (Nourishment)",
                    PathToNext = "upper=3&lower=0",
                    Summary = new List<string> {
                        "Waiting. If you are sincere,",
                        "You have light and success.",
                        "Perseverance brings good fortune.",
                        "It furthers one to cross the great water."
                    },
                    Image = new List<string> {
                        "Clouds rise up to heaven:",
                        "The image of Waiting.",
                        "Thus the superior man eats and drinks,",
                        "Is joyous and of good cheer."
                    }
                }
            },
            {
                new PageData {
                    Upper = "Wind",
                    Lower = "Earth",
                    Name = "Kuan - Contemplation (View)",
                    PathToNext = "upper=3&lower=1",
                    Summary = new List<string> {
                        "Contemplation.",
                        "The ablution has been made,",
                        "But not yet the offering.",
                        "Full of trust they look up to him."
                    },
                    Image = new List<string> {
                        "The wind blows over the earth:",
                        "The image of Contemplation.",
                        "Thus the kings of old visited the regions of the world,",
                        "Contemplated the people,",
                        "And gave them instruction."
                    }
                },
                new PageData {
                    Upper = "Wind",
                    Lower = "Mountain",
                    Name = "Chien - Development (Gradual Progress)",
                    PathToNext = "upper=3&lower=2",
                    Summary = new List<string> {
                        "Development.",
                        "The maiden is given in marriage.",
                        "Good fortune.",
                        "Perseverance furthers."
                    },
                    Image = new List<string> {
                        "On the mountain, a tree:",
                        "The image of Development.",
                        "Thus the superior man abides in dignity and virtue,",
                        "In order to improve the mores."
                    }
                },
                new PageData {
                    Upper = "Wind",
                    Lower = "Water",
                    Name = "Huan - Dispersion [Dissolution]",
                    PathToNext = "upper=3&lower=3",
                    Summary = new List<string> {
                        "Dispersion. Success.",
                        "The king approaches his temple.",
                        "It furthers one to cross the great water.",
                        "Perseverance furthers."
                    },
                    Image = new List<string> {
                        "The wind drives over the water:",
                        "The image of Dispersion.",
                        "Thus the kings of old sacrificed to the Lord",
                        "And built temples."
                    }
                },
                new PageData {
                    Upper = "Wind",
                    Lower = "Wind",
                    Name = "Sun - The Gentle (The Penetrating, Wind)",
                    PathToNext = "upper=3&lower=4",
                    Summary = new List<string> {
                        "The Gentle.",
                        "Success through what is small.",
                        "It furthers one to have somewhere to go.",
                        "It furthers one to see the great man."
                    },
                    Image = new List<string> {
                        "Winds following one upon the other:",
                        "The image of the Gently Penetrating.",
                        "Thus the superior man",
                        "Spreads his commands abroad",
                        "And carries out his undertakings."
                    }
                },
                new PageData {
                    Upper = "Wind",
                    Lower = "Thunder",
                    Name = "I - Increase",
                    PathToNext = "upper=3&lower=5",
                    Summary = new List<string> {
                        "Increase.",
                        "It furthers one to undertake something.",
                        "It furthers one to cross the great water."
                    },
                    Image = new List<string> {
                        "Wind and thunder:",
                        "The image of Increase.",
                        "Thus the superior man:",
                        "If he sees good, he imitates it;",
                        "If he has faults, he rids himself of them."
                    }
                },
                new PageData {
                    Upper = "Wind",
                    Lower = "Fire",
                    Name = "Chia Jên - The Family [The Clan]",
                    PathToNext = "upper=3&lower=6",
                    Summary = new List<string> {
                        "The Family.",
                        "The perseverance of the woman furthers."
                    },
                    Image = new List<string> {
                        "Wind comes forth from fire:",
                        "The image of the Family.",
                        "Thus the superior man has substance in his words",
                        "And duration in his way of life."
                    }
                },
                new PageData {
                    Upper = "Wind",
                    Lower = "Lake",
                    Name = "Chung Fu - Inner Truth",
                    PathToNext = "upper=3&lower=7",
                    Summary = new List<string> {
                        "Inner Truth.",
                        "Pigs and fishes.",
                        "Good fortune.",
                        "It furthers one to cross the great water.",
                        "Perseverance furthers."
                    },
                    Image = new List<string> {
                        "Wind over lake:",
                        "The image of Inner Truth.",
                        "Thus the superior man discusses criminal cases",
                        "In order to delay executions."
                    }
                },
                new PageData {
                    Upper = "Wind",
                    Lower = "Heaven",
                    Name = "Hsiao Ch'u - The Taming Power of the Small",
                    PathToNext = "upper=4&lower=0",
                    Summary = new List<string> {
                        "The Taming Power of the Small",
                        "Has success.",
                        "Dense clouds, no rain from our western region."
                    },
                    Image = new List<string> {
                        "The wind drives across heaven:",
                        "The image of the Taming Power of the Small.",
                        "Thus the superior man",
                        "Refines the outward aspect of his nature."
                    }
                }
            },
            {
                new PageData {
                    Upper = "Thunder",
                    Lower = "Earth",
                    Name = "Yu - Enthusiasm",
                    PathToNext = "upper=4&lower=1",
                    Summary = new List<string> {
                        "Enthusiasm.",
                        "It furthers one to install helpers",
                        "And to set armies marching."
                    },
                    Image = new List<string> {
                        "Thunder comes resounding out of the earth:",
                        "The image of Enthusiasm.",
                        "Thus the ancient kings made music",
                        "In order to honor merit,",
                        "And offered it with splendor",
                        "To the Supreme Deity,",
                        "Inviting their ancestors to be present."
                    }
                },
                new PageData {
                    Upper = "Thunder",
                    Lower = "Mountain",
                    Name = "Hsiao Kuo - Preponderance of the Small",
                    PathToNext = "upper=4&lower=2",
                    Summary = new List<string> {
                        "Preponderance of the Small.",
                        "Success.",
                        "Perseverance furthers.",
                        "Small things may be done;",
                        "Great things should not be done.",
                        "The flying bird brings the message:",
                        "It is not well to strive upward,",
                        "It is well to remain below.",
                        "Great good fortune."
                    },
                    Image = new List<string> {
                        "Thunder on the mountain:",
                        "The image of Preponderance of the Small.",
                        "Thus in his conduct the superior man gives preponderance to reverence.",
                        "In bereavement he gives preponderance to grief.",
                        "In his expenditures he gives preponderance to thrift."
                    }
                },
                new PageData {
                    Upper = "Thunder",
                    Lower = "Water",
                    Name = "Hsieh - Deliverance",
                    PathToNext = "upper=4&lower=3",
                    Summary = new List<string> {
                        "Deliverance.",
                        "The southwest furthers.",
                        "If there is no longer anything where one has to go,",
                        "Return brings good fortune.",
                        "If there is still something where one has to go,",
                        "Hastening brings good fortune."
                    },
                    Image = new List<string> {
                        "Thunder and rain set in:",
                        "The image of Deliverance.",
                        "Thus the superior man pardons mistakes",
                        "And forgives misdeeds."
                    }
                },
                new PageData {
                    Upper = "Thunder",
                    Lower = "Wind",
                    Name = "Hêng - Duration",
                    PathToNext = "upper=4&lower=4",
                    Summary = new List<string> {
                        "Duration. Success. No blame.",
                        "Perseverance furthers.",
                        "It furthers one to have somewhere to go."
                    },
                    Image = new List<string> {
                        "Thunder and wind:",
                        "The image of Duration.",
                        "Thus the superior man stands firm",
                        "And does not change his direction."
                    }
                },
                new PageData {
                    Upper = "Thunder",
                    Lower = "Thunder",
                    Name = "Chên - The Arousing (Shock, Thunder)",
                    PathToNext = "upper=4&lower=5",
                    Summary = new List<string> {
                        "Shock brings success.",
                        "Shock comes: oh, oh!",
                        "Laughing words: ha, ha!",
                        "The shock terrifies for a hundred miles,",
                        "And he does not let fall the sacrificial spoon and chalice."
                    },
                    Image = new List<string> {
                        "Thunder repeated:",
                        "The image of Shock.",
                        "Thus in fear and trembling",
                        "The superior man sets his life in order",
                        "And examines himself."
                    }
                },
                new PageData {
                    Upper = "Thunder",
                    Lower = "Fire",
                    Name = "Fêng - Abundance [Fullness]",
                    PathToNext = "upper=4&lower=6",
                    Summary = new List<string> {
                        "Abundance has success.",
                        "The king attains abundance.",
                        "Be not sad.",
                        "Be like the sun at midday."
                    },
                    Image = new List<string> {
                        "Both thunder and lightning come:",
                        "The image of Abundance.",
                        "Thus the superior man decides lawsuits",
                        "And carries out punishments."
                    }
                },
                new PageData {
                    Upper = "Thunder",
                    Lower = "Lake",
                    Name = "Kuei Mei - The Marrying Maiden",
                    PathToNext = "upper=4&lower=7",
                    Summary = new List<string> {
                        "The Marrying Maiden.",
                        "Undertakings bring misfortune.",
                        "Nothing that would further."
                    },
                    Image = new List<string> {
                        "Thunder over the lake:",
                        "The image of the Marrying Maiden.",
                        "Thus the superior man",
                        "Understands the transitory",
                        "In the light of the eternity of the end."
                    }
                },
                new PageData {
                    Upper = "Thunder",
                    Lower = "Heaven",
                    Name = "Ta Chuang - The Power of the Great",
                    PathToNext = "upper=5&lower=0",
                    Summary = new List<string> {
                        "The Power of the Great.",
                        "Perseverance furthers."
                    },
                    Image = new List<string> {
                        "Thunder in heaven above:",
                        "The image of the Power of the Great.",
                        "Thus the superior man does not tread upon paths",
                        "That do not accord with established order."
                    }
                }
            },
            {
                new PageData {
                    Upper = "Fire",
                    Lower = "Earth",
                    Name = "Chin - Progress",
                    PathToNext = "upper=5&lower=1",
                    Summary = new List<string> {
                        "Progress. The powerful prince",
                        "Is honored with horses in large numbers.",
                        "In a single day he is granted audience three times."
                    },
                    Image = new List<string> {
                        "The sun rises over the earth:",
                        "The image of Progress.",
                        "Thus the superior man himself",
                        "Brightens his bright virtue."
                    }
                },
                new PageData {
                    Upper = "Fire",
                    Lower = "Mountain",
                    Name = "Lu - The Wanderer",
                    PathToNext = "upper=5&lower=2",
                    Summary = new List<string> {
                        "The Wanderer.",
                        "Success through smallness.",
                        "Perseverance brings good fortune",
                        "To the wanderer."
                    },
                    Image = new List<string> {
                        "Fire on the mountain:",
                        "The image of the Wanderer.",
                        "Thus the superior man",
                        "Is clear-minded and cautious",
                        "In imposing penalties,",
                        "And protracts no lawsuits."
                    }
                },
                new PageData {
                    Upper = "Fire",
                    Lower = "Water",
                    Name = "Wei Chi - Before Completion",
                    PathToNext = "upper=5&lower=3",
                    Summary = new List<string> {
                        "Before Completion. Success.",
                        "But if the little fox, after nearly completing the crossing,",
                        "Gets his tail in the water,",
                        "There is nothing that would further."
                    },
                    Image = new List<string> {
                        "Fire over water:",
                        "The image of the condition before transition.",
                        "Thus the superior man is careful",
                        "In the differentiation of things,",
                        "So that each finds its place."
                    }
                },
                new PageData {
                    Upper = "Fire",
                    Lower = "Wind",
                    Name = "Ting - The Cauldron",
                    PathToNext = "upper=5&lower=4",
                    Summary = new List<string> {
                        "The Cauldron.",
                        "Supreme good fortune.",
                        "Success."
                    },
                    Image = new List<string> {
                        "Fire over wood:",
                        "The image of the Cauldron.",
                        "Thus the superior man consolidates his fate",
                        "By making his position correct."
                    }
                },
                new PageData {
                    Upper = "Fire",
                    Lower = "Thunder",
                    Name = "Shih Ho - Biting Through",
                    PathToNext = "upper=5&lower=5",
                    Summary = new List<string> {
                        "Biting Through has success.",
                        "It is favorable to let justice be administered."
                    },
                    Image = new List<string> {
                        "Thunder and lightning:",
                        "The image of Biting Through.",
                        "Thus the kings of former times made firm the laws",
                        "Through clearly defined penalties."
                    }
                },
                new PageData {
                    Upper = "Fire",
                    Lower = "Fire",
                    Name = "Li - The Clinging, Fire",
                    PathToNext = "upper=5&lower=6",
                    Summary = new List<string> {
                        "The Clinging.",
                        "Perseverance furthers.",
                        "It brings success.",
                        "Care of the cow brings good fortune."
                    },
                    Image = new List<string> {
                        "That which is bright rises twice:",
                        "The image of Fire.",
                        "Thus the great man, by perpetuating this brightness,",
                        "Illumines the four quarters of the world."
                    }
                },
                new PageData {
                    Upper = "Fire",
                    Lower = "Lake",
                    Name = "K'uei - Opposition",
                    PathToNext = "upper=5&lower=7",
                    Summary = new List<string> {
                        "Opposition.",
                        "In small matters,",
                        "Good fortune."
                    },
                    Image = new List<string> {
                        "Above, fire; below, the lake:",
                        "The image of Opposition.",
                        "Thus amid all fellowship",
                        "The superior man retains his individuality."                    }
                },
                new PageData {
                    Upper = "Fire",
                    Lower = "Heaven",
                    Name = "Ta Yu - Possession in Great Measure",
                    PathToNext = "upper=6&lower=0",
                    Summary = new List<string> {
                        "Possession in Great Measure.",
                        "Supreme success."
                    },
                    Image = new List<string> {
                        "Fire in heaven above:",
                        "The image of Possession in Great Measure.",
                        "Thus the superior man curbs evil and furthers good,",
                        "And thereby obeys the benevolent will of heaven."
                    }
                }
            },
            {
                new PageData {
                    Upper = "Lake",
                    Lower = "Earth",
                    Name = "Ts'ui - Gathering Together [Massing]",
                    PathToNext = "upper=6&lower=1",
                    Summary = new List<string> {
                        "Gathering Together. Success.",
                        "The king approaches his temple.",
                        "It furthers one to see the great man.",
                        "This brings success.",
                        "Perseverance furthers.",
                        "To bring great offerings creates good fortune.",
                        "It furthers one to undertake something."
                    },
                    Image = new List<string> {
                        "Over the earth, the lake:",
                        "The image of Gathering Together.",
                        "Thus the superior man renews his weapons",
                        "In order to meet the unforseen."
                    }
                },
                new PageData {
                    Upper = "Lake",
                    Lower = "Mountain",
                    Name = "Hsien - Influence (Wooing)",
                    PathToNext = "upper=6&lower=2",
                    Summary = new List<string> {
                        "Influence. Success.",
                        "Perseverance furthers.",
                        "To take a maiden to wife brings good fortune."
                    },
                    Image = new List<string> {
                        "A lake on the mountain:",
                        "The image of Influence.",
                        "Thus the superior man encourages people to approach him",
                        "By his readiness to receive them."
                    }
                },
                new PageData {
                    Upper = "Lake",
                    Lower = "Water",
                    Name = "K'un - Oppression (Exhaustion)",
                    PathToNext = "upper=6&lower=3",
                    Summary = new List<string> {
                        "Oppression. Success. Perseverance.",
                        "The great man brings about good fortune.",
                        "No blame.",
                        "When one has something to say,",
                        "It is not believed."
                    },
                    Image = new List<string> {
                        "There is no water in the lake:",
                        "The image of Exhaustion.",
                        "Thus the superior man stakes his life",
                        "On following his will."
                    }
                },
                new PageData {
                    Upper = "Lake",
                    Lower = "Wind",
                    Name = "Ta Kuo - Preponderance of the Great",
                    PathToNext = "upper=6&lower=4",
                    Summary = new List<string> {
                        "Preponderance of the Great.",
                        "The ridgepole sags to the breaking point.",
                        "It furthers one to have somewhere to go.",
                        "Success."
                    },
                    Image = new List<string> {
                        "The lake rises above the trees:",
                        "The image of Preponderance of the Great.",
                        "Thus the superior man, when he stands alone,",
                        "Is unconcerned,",
                        "And if he has to renounce the world,",
                        "He is undaunted."
                    }
                },
                new PageData {
                    Upper = "Lake",
                    Lower = "Thunder",
                    Name = "Sui - Following",
                    PathToNext = "upper=6&lower=5",
                    Summary = new List<string> {
                        "Following has supreme success.",
                        "Perseverance furthers. No blame."
                    },
                    Image = new List<string> {
                        "Thunder in the middle of the lake:",
                        "The image of Following.",
                        "Thus the superior man at nightfall",
                        "Goes indoors for rest and recuperation."
                    }
                },
                new PageData {
                    Upper = "Lake",
                    Lower = "Fire",
                    Name = "Ko - Revolution (Molting)",
                    PathToNext = "upper=6&lower=6",
                    Summary = new List<string> {
                        "Revolution.",
                        "On your own day",
                        "You are believed.",
                        "Supreme success,",
                        "Furthering through perseverance.",
                        "Remorse disappears."
                    },
                    Image = new List<string> {
                        "Fire in the lake:",
                        "The image of Revolution.",
                        "Thus the superior man",
                        "Sets the calendar in order",
                        "And makes the seasons clear."
                    }
                },
                new PageData {
                    Upper = "Lake",
                    Lower = "Lake",
                    Name = "Tui - The Joyous, Lake",
                    PathToNext = "upper=6&lower=7",
                    Summary = new List<string> {
                        "The Joyous. Success.",
                        "Perseverance is favorable."
                    },
                    Image = new List<string> {
                        "Lakes resting one on the other:",
                        "The image of the Joyous.",
                        "Thus the superior man joins with his friends",
                        "For discussion and practice."
                    }
                },
                new PageData {
                    Upper = "Lake",
                    Lower = "Heaven",
                    Name = "Kuai - Break-through (Resoluteness)",
                    PathToNext = "upper=7&lower=0",
                    Summary = new List<string> {
                        "Breakthrough.",
                        "One must resolutely make the matter known",
                        "At the court of the king.",
                        "It must be announced truthfully.",
                        "Danger.",
                        "It is necessary to notify one's own city.",
                        "It does not further to resort to arms.",
                        "It furthers one to undertake something."
                    },
                    Image = new List<string> {
                        "The lake has risen up to heaven:",
                        "The image of Breakthrough.",
                        "Thus the superior man",
                        "Dispenses riches downward",
                        "And refrains from resting on his virtue."
                    }
                }
            },
            {
                new PageData {
                    Upper = "Heaven",
                    Lower = "Earth",
                    Name = "P'i - Standstill [Stagnation]",
                    PathToNext = "upper=7&lower=1",
                    Summary = new List<string> {
                        "Standstill.",
                        "Evil people do not further",
                        "The perseverance of the superior man.",
                        "The great departs;",
                        "The small approaches."
                    },
                    Image = new List<string> {
                        "Heaven and earth do not unite:",
                        "The image of Standstill.",
                        "Thus the superior man falls back upon his inner worth",
                        "In order to escape the difficulties.",
                        "He does not permit himself to be honored with revenue."
                    }
                },
                new PageData {
                    Upper = "Heaven",
                    Lower = "Mountain",
                    Name = "Tun - Retreat",
                    PathToNext = "upper=7&lower=2",
                    Summary = new List<string> {
                        "Retreat. Success.",
                        "In what is small, perseverance furthers."
                    },
                    Image = new List<string> {
                        "Mountain under heaven:",
                        "The image of Retreat.",
                        "Thus the superior man keeps the inferior man at a distance,",
                        "Not angrily but with reserve."
                    }
                },
                new PageData {
                    Upper = "Heaven",
                    Lower = "Water",
                    Name = "Sung - Conflict",
                    PathToNext = "upper=7&lower=3",
                    Summary = new List<string> {
                        "Conflict. You are sincere",
                        "And are being obstructed.",
                        "A cautious halt halfway brings good fortune.",
                        "Going through to the end brings misfortune.",
                        "It furthers one to see the great man.",
                        "It does not further one to cross the great water."
                    },
                    Image = new List<string> {
                        "Heaven and water go their opposite ways:",
                        "The image of Conflict.",
                        "Thus in all transactions",
                        "The superior man",
                        "Carefully considers the beginning."
                    }
                },
                new PageData {
                    Upper = "Heaven",
                    Lower = "Wind",
                    Name = "Kou - Coming to Meet",
                    PathToNext = "upper=7&lower=4",
                    Summary = new List<string> {
                        "Coming to Meet.",
                        "The maiden is powerful.",
                        "One should not marry such a maiden."
                    },
                    Image = new List<string> {
                        "Under heaven, wind:",
                        "The image of Coming to Meet.",
                        "Thus does the prince act when disseminating his commands",
                        "And proclaiming them to the four quarters of heaven."
                    }
                },
                new PageData {
                    Upper = "Heaven",
                    Lower = "Thunder",
                    Name = "Wu Wang - Innocence (The Unexpected)",
                    PathToNext = "upper=7&lower=5",
                    Summary = new List<string> {
                        "Innocence. Supreme success.",
                        "Perseverance furthers.",
                        "If someone is not as he should be,",
                        "He has misfortune,",
                        "And it does not further him",
                        "To undertake anything."
                    },
                    Image = new List<string> {
                        "Under heaven thunder rolls:",
                        "All things attain the natural state of innocence.",
                        "Thus the kings of old,",
                        "Rich in virtue, and in harmony with the time,",
                        "Fostered and nourished all beings."
                    }
                },
                new PageData {
                    Upper = "Heaven",
                    Lower = "Fire",
                    Name = "T'ung Jên - Fellowship with Men",
                    PathToNext = "upper=7&lower=6",
                    Summary = new List<string> {
                        "Fellowship with Men in the open.",
                        "Success.",
                        "It furthers one to cross the great water.",
                        "The perseverance of the superior man furthers."
                    },
                    Image = new List<string> {
                        "Heaven together with fire:",
                        "The image of Fellowship with Men.",
                        "Thus the superior man organizes the clans",
                        "And makes distinctions between things."
                    }
                },
                new PageData {
                    Upper = "Heaven",
                    Lower = "Lake",
                    Name = "Lu - Treading [Conduct]",
                    PathToNext = "upper=7&lower=7",
                    Summary = new List<string> {
                        "Treading upon the tail of the tiger.",
                        "It does not bite the man.",
                        "Success."
                    },
                    Image = new List<string> {
                        "Heaven above, the lake below:",
                        "The image of Treading.",
                        "Thus the superior man discriminates between high and low,",
                        "And thereby fortifies the thinking of the people."
                    }
                },
                new PageData {
                    Upper = "Heaven",
                    Lower = "Heaven",
                    Name = "Ch'ien - The Creative",
                    PathToNext = "upper=0&lower=0",
                    Summary = new List<string> {
                        "The Creative works sublime success,",
                        "Furthering through perseverance."
                    },
                    Image = new List<string> {
                        "The movement of heaven is full of power.",
                        "Thus the superior man makes himself strong and untiring."
                    }
                }
            }
        };
    }

    public static class Pages
    {
        public static readonly Dictionary<string, PageData> Page = new Dictionary<string, PageData>()
        {
            ["Tao"] = new PageData
            {
                Key = "Tao",
                Category = "About",
                Name = "Tao",
                Summary = new List<string> {
                    "Tao or Dao is a Chinese word signifying 'way', 'path', 'route', 'key' or sometimes more loosely 'doctrine' or 'principle'.",
                    "Within the context of traditional Chinese philosophy and religion, the Tao is the intuitive knowing of 'life' that cannot be grasped full-heartedly as just a concept but is known nonetheless through actual living experience of one's everyday being.",
                    "The Tao differs from Western ontology in that it is an active and holistic practice of the natural order of Nature and its universal awakening, rather than a static, atomistic one.",
                    "Laozi in the Tao Te Ching explains that the Tao is not a 'name' for a 'thing' but the underlying natural order of the Universe whose ultimate essence is difficult to circumscribe due to it being non conceptual yet evident' in one's being of aliveness."
                }
            },
            ["IChing"] = new PageData
            {
                Key = "IChing",
                Category = "About",
                Name = "I Ching",
                Summary = new List<string> {
                    "The Eight Gates are elements of the Tao, representing fundamental energies or concepts: Earth, Mountain, Water, Wind, Thunder, Fire, Lake and Heaven. Each is represented by a trigram as shown above: three closed or open lines.",
                    "The I Ching, or Classic of Changes, is an ancient Chinese divination text and the oldest of the Chinese classics, at 3000 years old.",
                    "The hexagrams used for I Ching divination are a combination of two trigrams; this yields 64 possible combinations. Each combination is named, based on its trigams, and a 'judgment' is offered: a divinatory meaning. An 'image' is also offered, which tends to be more poetic and descriptive than judgmental or divinatory.",

                    "The judgments and visions presented in the I Ching amply demonstrate the beauty and wisdom humans are able to bring to our world and our lives.",
                    "It's interesting and encouraging to consider that their beauty and wisdom were our provenance 3000 and more years ago."
                }
            },
            ["Earth"] = new PageData
            {
                Key = "Earth",
                Category = "Trigrams",
                Name = "Kūn, or Earth",
                Summary = new List<string> {
                    "Translation: The Receptive, Field",
                    "Direction: Southwest",
                    "Family: Mother",
                    "Body part: Belly",
                    "Attribute: Devoted, yielding",
                    "State: Receptive",
                    "Animal: Cow"
                }
            },
            ["Mountain"] = new PageData
            {
                Key = "Mountain",
                Category = "Trigrams",
                Name = "Gèn, or Mountain",
                Summary = new List<string> {
                    "Translation: Keeping Still, Bound",
                    "Direction: Northeast",
                    "Family: Third son",
                    "Body part: Hand",
                    "Attribute: Resting, stand-still",
                    "State: Completion",
                    "Animal: Wolf or Dog"                }
            },
            ["Water"] = new PageData
            {
                Key = "Water",
                Category = "Trigrams",
                Name = "Kǎn, or Water",
                Summary = new List<string> {
                    "Translation: The Abysmal, Gorge",
                    "Direction: North",
                    "Family: Second son",
                    "Body part: Ear",
                    "Attribute: Dangerous",
                    "State: In motion",
                    "Animal: Pig"
                }
            },
            ["Wind"] = new PageData
            {
                Key = "Wind",
                Category = "Trigrams",
                Name = "Xùn, or Wind",
                Summary = new List<string> {
                    "Translation: The Gentle, Ground",
                    "Direction: Southeast",
                    "Family: First daughter",
                    "Body part: Thigh",
                    "Attribute: Penetrating",
                    "State: Gentle entrance",
                    "Animal: Fowl"
                }
            },
            ["Thunder"] = new PageData
            {
                Key = "Thunder",
                Category = "Trigrams",
                Name = "Zhèn, or Thunder",
                Summary = new List<string> {
                    "Translation: The Arousing, Shake",
                    "Direction: East",
                    "Family: First son",
                    "Body part: Foot",
                    "Attribute: Inciting movement",
                    "State: Initiative",
                    "Animal: Dragon"
                }
            },
            ["Fire"] = new PageData
            {
                Key = "Fire",
                Category = "Trigrams",
                Name = "Lí, or Fire",
                Summary = new List<string> {
                    "Translation: The Clinging, Radiance",
                    "Direction: South",
                    "Family: Second daughter",
                    "Body part: Eye",
                    "Attribute: light - giving, dependence",
                    "State: Clinging, clarity, adaptable",
                    "Animal: Pheasant"
                }
            },
            ["Lake"] = new PageData
            {
                Key = "Lake",
                Category = "Trigrams",
                Name = "Duì, or Lake",
                Summary = new List<string> {
                    "Translation: The Joyous, Open",
                    "Direction: West",
                    "Family: Third daughter",
                    "Body part: Mouth",
                    "Attribute: Pleasure",
                    "State: Tranquil (complete devotion)",
                    "Animal: Sheep or Goat"
                }
            },
            ["Heaven"] = new PageData
            {
                Key = "Heaven",
                Category = "Trigrams",
                Name = "Qián, or Heaven",
                Summary = new List<string> {
                    "Translation: The Creative, Force",
                    "Direction: Northwest",
                    "Family: Father",
                    "Body part: Head",
                    "Attribute: Strong",
                    "State: Creative",
                    "Animal: Horse"
                }
            }
        };
    }
}