import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { Post } from '../models/post/post';
import { NewReaction } from '../models/reactions/newReaction';
import { NewDisReaction } from '../models/disreaction/newDisReaction';
import { NewPost } from '../models/post/new-post';

@Injectable({ providedIn: 'root' })
export class PostService {
    public routePrefix = '/api/posts';

    constructor(private httpService: HttpInternalService) { }

    public getPosts() {
        return this.httpService.getFullRequest<Post[]>(`${this.routePrefix}`);
    }

    public createPost(post: NewPost) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}`, post);
    }

    public likePost(reaction: NewReaction) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}/like`, reaction);
    }

    public deletePost(id: number) {
        console.log(id);
        return this.httpService.deleteFullRequest<Post>(`${this.routePrefix}`, id);
    }

    public dislikePost(reaction: NewDisReaction) {
        return this.httpService.postFullRequest<Post>(`${this.routePrefix}/dislike`, reaction);
    }
}
