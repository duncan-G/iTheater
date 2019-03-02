declare var require;
var slugify = require("slugify");

export const movies = getMovies().map(movie => {
  movie['slug'] = slugify(movie.title);
  return movie;
});

function getMovies() {
  return [
    {
      vote_count: 8,
      id: 443055,
      video: false,
      vote_average: 5.4,
      title: "Love of My Life",
      popularity: 57.077,
      poster_path: "/7b19Sh0Aef5vGa0OFtvJxLe2SK9.jpg",
      original_language: "en",
      original_title: "Love of My Life",
      genre_ids: [18, 35],
      backdrop_path: "/7xWjv95DPjbx6zDiDVJspdZbrfL.jpg",
      adult: false,
      overview: "What if you had only five days to figure out... everything.",
      release_date: "2017-02-17"
    },
    {
      vote_count: 231,
      id: 491418,
      video: false,
      vote_average: 7.5,
      title: "Instant Family",
      popularity: 56.762,
      poster_path: "/xYV1mODz99w7AjKDSQ7h2mzZhVe.jpg",
      original_language: "en",
      original_title: "Instant Family",
      genre_ids: [35, 18],
      backdrop_path: "/e33P9ajdOTHR5en2tYPVKrCnYDE.jpg",
      adult: false,
      overview:
        "When Pete and Ellie decide to start a family, they stumble into the world of foster care adoption. They hope to take in one small child but when they meet three siblings, including a rebellious 15 year old girl, they find themselves speeding from zero to three kids overnight.",
      release_date: "2018-11-16"
    },
    {
      vote_count: 27,
      id: 33125,
      video: false,
      vote_average: 6.6,
      title: "Border",
      popularity: 56.185,
      poster_path: "/mmGwawOiUaP4Nkr2b1k0xsVhuY5.jpg",
      original_language: "hi",
      original_title: "Border",
      genre_ids: [28, 36],
      backdrop_path: "/k45BW6kEXNtOqNT2uAniMnjcKNQ.jpg",
      adult: false,
      overview:
        "The year is 1971 when the Pakistani Army is at war with the Indian Soldiers. The Indian battalion is posted in Longewala region in Punjab and are just 150 in number while the Pakistani Army consists of 2000 armed soldiers with tanks.",
      release_date: "1997-07-13"
    },
    {
      vote_count: 1275,
      id: 424783,
      video: false,
      vote_average: 6.4,
      title: "Bumblebee",
      popularity: 54.392,
      poster_path: "/fw02ONlDhrYjTSZV8XO6hhU3ds3.jpg",
      original_language: "en",
      original_title: "Bumblebee",
      genre_ids: [28, 12, 878],
      backdrop_path: "/hMANgfPHR1tRObNp2oPiOi9mMlz.jpg",
      adult: false,
      overview:
        "On the run in the year 1987, Bumblebee finds refuge in a junkyard in a small Californian beach town. Charlie, on the cusp of turning 18 and trying to find her place in the world, discovers Bumblebee, battle-scarred and broken.  When Charlie revives him, she quickly learns this is no ordinary yellow VW bug.",
      release_date: "2018-12-15"
    },
    {
      vote_count: 5,
      id: 543103,
      video: false,
      vote_average: 5,
      title: "Kamen Rider Heisei Generations FOREVER",
      popularity: 52.79,
      poster_path: "/6sOFQDlkY6El1B2P5gklzJfVdsT.jpg",
      original_language: "ja",
      original_title: "仮面ライダー平成ジェネレーションズFOREVER",
      genre_ids: [28, 12, 878],
      backdrop_path: "/uufTqD2CSn1NqL3cXEl4Vp3bCav.jpg",
      adult: false,
      overview:
        "In the world of Sougo Tokiwa and Sento Kiryu, their \"companions\" are losing their memories one after the other as they're replaced by other people. The Super Time Jacker, Tid , appears before them. He orders his powerful underlings, Another Double and Another Den-O, to pursue a young boy called Shingo. While fighting to protect Shingo, Sougo meets Ataru, a young man who loves Riders, but Ataru says that Kamen Riders aren't real. What is the meaning of those words? While the mystery deepens, the true enemy that Sougo and Sento must defeat appears in the Kuriogatake mountain...",
      release_date: "2018-12-22"
    },
    {
      vote_count: 46,
      id: 454294,
      video: false,
      vote_average: 6.1,
      title: "The Kid Who Would Be King",
      popularity: 52.467,
      poster_path: "/kBuvLX6zynQP0sjyqbXV4jNaZ4E.jpg",
      original_language: "en",
      original_title: "The Kid Who Would Be King",
      genre_ids: [28, 12, 14, 10751],
      backdrop_path: "/jmbgxBd86MshzQQvv5laKvOKoMm.jpg",
      adult: false,
      overview:
        "Old-school magic meets the modern world when young Alex stumbles upon the mythical sword Excalibur. He soon unites his friends and enemies, and they become knights who join forces with the legendary wizard Merlin. Together, they must save mankind from the wicked enchantress Morgana and her army of supernatural warriors.",
      release_date: "2019-01-16"
    },
    {
      vote_count: 18168,
      id: 24428,
      video: false,
      vote_average: 7.6,
      title: "The Avengers",
      popularity: 52.136,
      poster_path: "/cezWGskPY5x7GaglTTRN4Fugfb8.jpg",
      original_language: "en",
      original_title: "The Avengers",
      genre_ids: [878, 28, 12],
      backdrop_path: "/hbn46fQaRmlpBuUrEiFqv0GDL6Y.jpg",
      adult: false,
      overview:
        "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins!",
      release_date: "2012-04-25"
    },
    {
      vote_count: 873,
      id: 400650,
      video: false,
      vote_average: 6.8,
      title: "Mary Poppins Returns",
      popularity: 52.112,
      poster_path: "/uTVGku4LibMGyKgQvjBtv3OYfAX.jpg",
      original_language: "en",
      original_title: "Mary Poppins Returns",
      genre_ids: [14, 10751, 35],
      backdrop_path: "/cwiJQXezWz876K3jS57Sq56RYCZ.jpg",
      adult: false,
      overview:
        "In Depression-era London, a now-grown Jane and Michael Banks, along with Michael's three children, are visited by the enigmatic Mary Poppins following a personal loss. Through her unique magical skills, and with the aid of her friend Jack, she helps the family rediscover the joy and wonder missing in their lives.",
      release_date: "2018-12-19"
    },
    {
      vote_count: 1772,
      id: 369972,
      video: false,
      vote_average: 7.1,
      title: "First Man",
      popularity: 51.887,
      poster_path: "/i91mfvFcPPlaegcbOyjGgiWfZzh.jpg",
      original_language: "en",
      original_title: "First Man",
      genre_ids: [36, 18],
      backdrop_path: "/3LX7SkR7ERIR2ZB6NPlyrgmZ5ga.jpg",
      adult: false,
      overview:
        "A look at the life of the astronaut, Neil Armstrong, and the legendary space mission that led him to become the first man to walk on the Moon on July 20, 1969.",
      release_date: "2018-10-11"
    },
    {
      vote_count: 7895,
      id: 122917,
      video: false,
      vote_average: 7.2,
      title: "The Hobbit: The Battle of the Five Armies",
      popularity: 51.451,
      poster_path: "/9zRzFJuaj0CHIOhAkcCcFTvyu2X.jpg",
      original_language: "en",
      original_title: "The Hobbit: The Battle of the Five Armies",
      genre_ids: [28, 12, 14],
      backdrop_path: "/qhH3GyIfAnGv1pjdV3mw03qAilg.jpg",
      adult: false,
      overview:
        "Immediately after the events of The Desolation of Smaug, Bilbo and the dwarves try to defend Erebor's mountain of treasure from others who claim it: the men of the ruined Laketown and the elves of Mirkwood. Meanwhile an army of Orcs led by Azog the Defiler is marching on Erebor, fueled by the rise of the dark lord Sauron. Dwarves, elves and men must unite, and the hope for Middle-Earth falls into Bilbo's hands.",
      release_date: "2014-12-10"
    },
    {
      vote_count: 4875,
      id: 363088,
      video: false,
      vote_average: 6.9,
      title: "Ant-Man and the Wasp",
      popularity: 48.434,
      poster_path: "/rv1AWImgx386ULjcf62VYaW8zSt.jpg",
      original_language: "en",
      original_title: "Ant-Man and the Wasp",
      genre_ids: [28, 12, 878, 35, 10751],
      backdrop_path: "/6P3c80EOm7BodndGBUAJHHsHKrp.jpg",
      adult: false,
      overview:
        "Just when his time under house arrest is about to end, Scott Lang once again puts his freedom at risk to help Hope van Dyne and Dr. Hank Pym dive into the quantum realm and try to accomplish, against time and any chance of success, a very dangerous rescue mission.",
      release_date: "2018-07-04"
    },
    {
      vote_count: 5067,
      id: 447332,
      video: false,
      vote_average: 7.3,
      title: "A Quiet Place",
      popularity: 46.707,
      poster_path: "/nAU74GmpUk7t5iklEp3bufwDq4n.jpg",
      original_language: "en",
      original_title: "A Quiet Place",
      genre_ids: [18, 27, 53, 878],
      backdrop_path: "/qtO7A1rVaBvqX8CBh92As5NuWjp.jpg",
      adult: false,
      overview:
        "A family is forced to live in silence while hiding from creatures that hunt by sound.",
      release_date: "2018-04-03"
    },
    {
      vote_count: 16672,
      id: 118340,
      video: false,
      vote_average: 7.9,
      title: "Guardians of the Galaxy",
      popularity: 46.46,
      poster_path: "/y31QB9kn3XSudA15tV7UWQ9XLuW.jpg",
      original_language: "en",
      original_title: "Guardians of the Galaxy",
      genre_ids: [28, 878, 12],
      backdrop_path: "/bHarw8xrmQeqf3t8HpuMY7zoK4x.jpg",
      adult: false,
      overview:
        "Light years from Earth, 26 years after being abducted, Peter Quill finds himself the prime target of a manhunt after discovering an orb wanted by Ronan the Accuser.",
      release_date: "2014-07-30"
    },
    {
      vote_count: 8,
      id: 463364,
      video: false,
      vote_average: 4.5,
      title: "The Isle",
      popularity: 46.32,
      poster_path: "/r4XDWsBWMzpoNm5fUMjr9cyY5rI.jpg",
      original_language: "en",
      original_title: "The Isle",
      genre_ids: [53, 14, 12, 14],
      backdrop_path: "/i2XFi9vIblYl40AxT8YOk79qd0x.jpg",
      adult: false,
      overview:
        "1840 and another ship crashes on the rocks of an almost deserted island in Scotland. Three sailors survive the wreck and make it to shore where the few locals take them in as they wait for the mainland boat to come for them. But the sailors' survival story has only just started as they uncover the strange past of the once vibrant island.",
      release_date: "2018-03-30"
    },
    {
      vote_count: 549,
      id: 483906,
      video: false,
      vote_average: 6.4,
      title: "Polar",
      popularity: 45.843,
      poster_path: "/qOBEpKVLl8Q9CZScbOcRRVISezV.jpg",
      original_language: "en",
      original_title: "Polar",
      genre_ids: [28, 80, 18],
      backdrop_path: "/u8CP7EeWbYMlIVqEoKAt6OYsEe1.jpg",
      adult: false,
      overview:
        "When a retiring assassin realizes that he is the target of a hit, he winds up back in the game going head to head with a gang of younger, ruthless killers.",
      release_date: "2019-01-25"
    },
    {
      vote_count: 7609,
      id: 383498,
      video: false,
      vote_average: 7.5,
      title: "Deadpool 2",
      popularity: 45.798,
      poster_path: "/to0spRl1CMDvyUbOnbb4fTk3VAd.jpg",
      original_language: "en",
      original_title: "Deadpool 2",
      genre_ids: [28, 35, 12],
      backdrop_path: "/3P52oz9HPQWxcwHOwxtyrVV1LKi.jpg",
      adult: false,
      overview:
        "Wisecracking mercenary Deadpool battles the evil and powerful Cable and other bad guys to save a boy's life.",
      release_date: "2018-05-15"
    },
    {
      vote_count: 669,
      id: 429197,
      video: false,
      vote_average: 7.2,
      title: "Vice",
      popularity: 45.279,
      poster_path: "/e0NZxqQ4B8YZ6kRrZish2DPqtdi.jpg",
      original_language: "en",
      original_title: "Vice",
      genre_ids: [18, 36, 35],
      backdrop_path: "/uvy89JLcYEiUb0VOoSjkUrIW3nJ.jpg",
      adult: false,
      overview:
        "George W. Bush picks Dick Cheney, the CEO of Halliburton Co., to be his Republican running mate in the 2000 presidential election. No stranger to politics, Cheney's impressive résumé includes stints as White House chief of staff, House Minority Whip and defense secretary. When Bush wins by a narrow margin, Cheney begins to use his newfound power to help reshape the country and the world.",
      release_date: "2018-12-25"
    },
    {
      vote_count: 5315,
      id: 351286,
      video: false,
      vote_average: 6.5,
      title: "Jurassic World: Fallen Kingdom",
      popularity: 44.864,
      poster_path: "/c9XxwwhPHdaImA2f1WEfEsbhaFB.jpg",
      original_language: "en",
      original_title: "Jurassic World: Fallen Kingdom",
      genre_ids: [28, 12, 878],
      backdrop_path: "/3s9O5af2xWKWR5JzP2iJZpZeQQg.jpg",
      adult: false,
      overview:
        "Three years after the demise of Jurassic World, a volcanic eruption threatens the remaining dinosaurs on the isla Nublar, so Claire Dearing, the former park manager, recruits Owen Grady to help prevent the extinction of the dinosaurs once again.",
      release_date: "2018-06-06"
    },
    {
      vote_count: 3298,
      id: 348350,
      video: false,
      vote_average: 6.6,
      title: "Solo: A Star Wars Story",
      popularity: 44.645,
      poster_path: "/3IGbjc5ZC5yxim5W0sFING2kdcz.jpg",
      original_language: "en",
      original_title: "Solo: A Star Wars Story",
      genre_ids: [28, 12, 878],
      backdrop_path: "/pH0rtDSgBM98Ho8HgiEq8topsxL.jpg",
      adult: false,
      overview:
        "Through a series of daring escapades deep within a dark and dangerous criminal underworld, Han Solo meets his mighty future copilot Chewbacca and encounters the notorious gambler Lando Calrissian.",
      release_date: "2018-05-15"
    },
    {
      vote_count: 192,
      id: 465914,
      video: false,
      vote_average: 7.3,
      title: "If Beale Street Could Talk",
      popularity: 44.326,
      poster_path: "/ye3KqC2hUYia6ktGIhZtmKjj3ya.jpg",
      original_language: "en",
      original_title: "If Beale Street Could Talk",
      genre_ids: [18, 10749, 80],
      backdrop_path: "/1BeMxME8SPuJgCTmyEBzGWSZrAR.jpg",
      adult: false,
      overview:
        "After her fiance is falsely imprisoned, a pregnant African-American woman sets out to clear his name and prove his innocence.",
      release_date: "2018-11-30"
    }
  ];
}
