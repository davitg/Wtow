
export interface Title {
    titleId: number;
    name: string;
    year: number;
    rated: string;
    released: Date;
    runtime: string;
    genre: string;
    director: string;
    writer: string;
    actors: string;
    plot: string;
    language: string;
    country: string;
    awards: string;
    poster: string;
    ratings: Rating[];
    metascore: number;
    imdbRating: number;
    imdbVotes: string;
    imdbId: string;
    titleType: number;
    dvd?: any;
    boxOffice: string;
    production: string;
    website: string;
    response: string;
}


export interface Rating {
    ratingId: number;
    source: string;
    value: string;
}