export interface IMovieList {
    id : number,
    name: string,
    slug : string,
    privacy: boolean,
    defaultImageUrl : string,
    created: Date
}

export interface ICreateMovieList {
    name: string,
    privacy: boolean
}

export interface IUpdateMovieList {
    name?: string,
    defaultImageUrl?: string
}